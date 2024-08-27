Imports System.Data.Common
Imports System.Diagnostics.Eventing
Imports System.Net.Mail
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class FormInscripciones
	Private _Conexion As Conexion
	Public Tabla As String = "TMiembros"
	Public Tabla2 As String = "TInscripciones"
	Private lector As MySqlDataReader
	Private edicion As Boolean = False
	Private PrevFila As DataGridViewCell
	Private PopUp As FormPagopopup

	Public Shared listaIns As New List(Of Curso_Pago)

#Region "FUNCIONES <<<"

	Sub SeleccionarMiembro(IDMiembro As Integer)
		PrevFila = dgvListadoMiembros.CurrentCell
		_Conexion.GymcatDataSet.Tables("TInscritos").Clear()
		_Conexion.GymcatDataSet.Tables("TNoInscritos").Clear()

		'Llenar la tabla de Cursos Inscritos del Miembro
		Dim ComandoIncritos As New MySqlCommand("SELECT miembros_cursos.ID_inscripción, cursos.nombre AS 'Curso', " +
						"miembros_cursos.fecha_inscripcion AS 'Fecha de Inscripcion', miembros_cursos.meses FROM cursos, miembros_cursos " +
						"WHERE miembros_cursos.FK_cursos = cursos.ID_cursos AND miembros_cursos.FK_miembros=@num", _Conexion.miConexion)
		ComandoIncritos.Parameters.AddWithValue("@num", IDMiembro)
		_Conexion.TablaDataAdapter.SelectCommand = ComandoIncritos
		_Conexion.TablaDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey
		_Conexion.TablaDataAdapter.Fill(_Conexion.GymcatDataSet.Tables("TInscritos"))
		dgvCursosInscritos.DataSource = _Conexion.GymcatDataSet.Tables("TInscritos").DefaultView

		'Llenar la tabla de Cursos a los que el miembro no esta Inscrito
		Dim ComandoNoInscritos As New MySqlCommand("Select ID_cursos, nombre AS 'Curso', precio FROM cursos Where ID_cursos " +
						"Not In (Select FK_cursos FROM miembros_cursos WHERE FK_miembros = @num)", _Conexion.miConexion)
		ComandoNoInscritos.Parameters.AddWithValue("@num", IDMiembro)
		_Conexion.TablaDataAdapter.SelectCommand = ComandoNoInscritos
		_Conexion.TablaDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey
		_Conexion.TablaDataAdapter.Fill(_Conexion.GymcatDataSet.Tables("TNoInscritos"))
		dgvCursosDisponibles.DataSource = _Conexion.GymcatDataSet.Tables("TNoInscritos").DefaultView

		dgvCursosInscritos.Columns(0).Visible = False
		dgvCursosDisponibles.Columns(0).Visible = False
		dgvCursosDisponibles.Columns(2).Visible = False


		dgvCursosInscritos.ClearSelection()
		dgvCursosDisponibles.ClearSelection()
		btnInscribir.Enabled = False
		btnDesinscribir.Enabled = False
	End Sub


	Sub Desinscribir(FilaCurso As DataGridViewRow)

		If (MessageBox.Show("¿Quiere desincribir al miembro " + dgvListadoMiembros.CurrentRow.Cells(1).Value.ToString + " del Curso " +
			FilaCurso.Cells(1).Value.ToString + "?", "Desincribir Miembro", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = DialogResult.OK) Then
			edicion = True
			_Conexion.GymcatDataSet.Tables(Tabla2).Rows.Find(FilaCurso.Cells(0).Value).Delete()

			btnCancelar.Enabled = True
			btnGuardar.Enabled = True
			lbDesinscripciones.Visible = True
			lbDesinscripciones.Text += vbCrLf + "    - " + FilaCurso.Cells(1).Value.ToString
			SeleccionarMiembro(dgvListadoMiembros.CurrentRow.Cells(0).Value)
		End If

	End Sub


	Sub Inscribir(FilaCurso As DataGridViewRow)

		If (MessageBox.Show("¿Quiere inscribir al miembro " + dgvListadoMiembros.CurrentRow.Cells(1).Value.ToString + "al Curso " +
			FilaCurso.Cells(1).Value.ToString + "?", "Inscribir Miembro", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = DialogResult.OK) Then

			edicion = True
			Dim NuevaFila As DataRow = _Conexion.GymcatDataSet.Tables(Tabla2).NewRow
			NuevaFila("FK_miembros") = dgvListadoMiembros.CurrentRow.Cells(0).Value
			NuevaFila("FK_cursos") = dgvCursosDisponibles.CurrentRow.Cells(0).Value
			NuevaFila("Fecha_Inscripcion") = Today
			NuevaFila("Meses") = tbMeses.Text
			_Conexion.GymcatDataSet.Tables(Tabla2).Rows.Add(NuevaFila)

			btnCancelar.Enabled = True
			btnGuardar.Enabled = True
			lbInscripciones.Visible = True
			lbInscripciones.Text += vbCrLf + "    - " + FilaCurso.Cells(1).Value.ToString
			listaIns.Add(New Curso_Pago(FilaCurso.Cells(0).Value, FilaCurso.Cells(1).Value.ToString, FilaCurso.Cells(2).Value, tbMeses.Text))
			SeleccionarMiembro(dgvListadoMiembros.CurrentRow.Cells(0).Value)
		End If
	End Sub


	Sub MostrarInfoCurso(curso As DataGridViewRow)

		Dim comando As New MySqlCommand("SELECT cursos.nombre,horario,precio,dias_clase,FK_empleados,CONCAT(empleados.nombre,' ',empleados.apellido)" +
									" AS 'ProfNombre' FROM cursos,empleados WHERE empleados.id_empleados=cursos.FK_empleados " + "
									AND cursos.nombre= '" + curso.Cells(1).Value.ToString + "'", _Conexion.miConexion)
		lector = comando.ExecuteReader
		lector.Read()
		lbCursos.Visible = True
		lbCursos.Text = "Curso: " + lector("nombre").ToString
		lbHorariosCurso.Visible = True
		lbHorariosCurso.Text = "Horarios: " + lector("horario")
		lbPrecioCurso.Visible = True
		lbPrecioCurso.Text = "Precio: $" + lector("precio").ToString
		lbDiasCurso.Visible = True
		lbDiasCurso.Text = "Dias de Clase: " + lector("dias_clase")
		lbProfesorCurso.Visible = True
		lbProfesorCurso.Text = "Profesor: " + lector("ProfNombre").ToString
		lector.Close()

	End Sub


	Public Sub CargarDatosForm()
		Dim consulta As String = "SELECT ID_miembro, nombre AS Nombre, apellido AS Apellido, DNI FROM miembros"
		Dim consulta2 As String = "SELECT * FROM miembros_cursos"

		_Conexion = New Conexion(consulta, consulta2, Tabla, Tabla2)
		_Conexion.GymcatDataSet.Tables.Add("TInscritos")
		_Conexion.GymcatDataSet.Tables.Add("TNoInscritos")

		dgvListadoMiembros.DataSource = _Conexion.vistaDatos
		dgvListadoMiembros.Columns(0).Visible = False
		dgvListadoMiembros.CurrentCell = dgvListadoMiembros.Rows(0).Cells(1)

		_Conexion.miConexion.Open()
		SeleccionarMiembro(dgvListadoMiembros.CurrentRow.Cells(0).Value)
		ConfigurarComandos()
	End Sub

	Private Sub ConfigurarComandos()
		_Conexion.TablaDataAdapter.DeleteCommand = New MySqlCommand("DELETE FROM miembros_cursos WHERE ID_inscripción = @id", _Conexion.miConexion)
		_Conexion.TablaDataAdapter.DeleteCommand.Parameters.Add("@id", MySqlDbType.Int32, 0, "ID_inscripción")

		_Conexion.TablaDataAdapter.InsertCommand = New MySqlCommand("INSERT INTO miembros_cursos (FK_miembros, FK_cursos, Fecha_Inscripcion, Meses) VALUES (@miem, @cur, @fe, @mes)", _Conexion.miConexion)
		_Conexion.TablaDataAdapter.InsertCommand.Parameters.Add("@miem", MySqlDbType.Int32, 11, "FK_miembros")
		_Conexion.TablaDataAdapter.InsertCommand.Parameters.Add("@cur", MySqlDbType.Int32, 11, "FK_cursos")
		_Conexion.TablaDataAdapter.InsertCommand.Parameters.Add("@fe", MySqlDbType.Date, 10, "Fecha_Inscripcion")
		_Conexion.TablaDataAdapter.InsertCommand.Parameters.Add("@mes", MySqlDbType.Int32, 0, "Meses")

		_Conexion.TablaDataAdapter.UpdateCommand = New MySqlCommand("UPDATE miembros_cursos SET FK_miembros = @miem, FK_cursos = @cur, Fecha_Inscripcion = @fe WHERE ID_inscripción = @id", _Conexion.miConexion)
		_Conexion.TablaDataAdapter.UpdateCommand.Parameters.Add("@miem", MySqlDbType.Int32, 11, "FK_miembros")
		_Conexion.TablaDataAdapter.UpdateCommand.Parameters.Add("@cur", MySqlDbType.Int32, 11, "FK_cursos")
		_Conexion.TablaDataAdapter.UpdateCommand.Parameters.Add("@fe", MySqlDbType.Date, 10, "Fecha_Inscripcion")
		_Conexion.TablaDataAdapter.UpdateCommand.Parameters.Add("@mes", MySqlDbType.Int32, 0, "Meses")
		_Conexion.TablaDataAdapter.UpdateCommand.Parameters.Add("@id", MySqlDbType.Int32, 0, "ID_inscripción")

	End Sub

#End Region

	Private Sub FormInscripciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		lbDesinscripciones.Text = vbCrLf + "Desisncripciones:"
	End Sub


	Private Sub dgvListadoMiembros_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListadoMiembros.CellClick
		If edicion Then

			If (MessageBox.Show("Se realizaron cambios que todavia no han sido guardados." + vbCrLf + "Desea descartar los cambios realizados?",
						   "Cambios Sin Guardar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = DialogResult.OK) Then
				_Conexion.GymcatDataSet.Tables(Tabla2).RejectChanges()
				btnCancelar.Enabled = False
				btnGuardar.Enabled = False
				edicion = False
				SeleccionarMiembro(dgvListadoMiembros.CurrentRow.Cells(0).Value)
			End If
			dgvListadoMiembros.CurrentCell = PrevFila
		Else
			SeleccionarMiembro(dgvListadoMiembros.CurrentRow.Cells(0).Value)
		End If
	End Sub


	Private Sub btnInscribir_Click(sender As Object, e As EventArgs) Handles btnInscribir.Click
		Inscribir(dgvCursosDisponibles.CurrentRow)
	End Sub

	Private Sub btnDesinscribir_Click(sender As Object, e As EventArgs) Handles btnDesinscribir.Click
		Desinscribir(dgvCursosInscritos.CurrentRow)
	End Sub

	Private Sub dgvCursosInscritos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCursosInscritos.CellClick
		btnInscribir.Enabled = False
		btnDesinscribir.Enabled = True
		MostrarInfoCurso(dgvCursosInscritos.CurrentRow)
		dgvCursosDisponibles.ClearSelection()
	End Sub

	Private Sub dgvCursosDisponibles_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCursosDisponibles.CellClick
		btnInscribir.Enabled = True
		btnDesinscribir.Enabled = False
		MostrarInfoCurso(dgvCursosDisponibles.CurrentRow)
		dgvCursosInscritos.ClearSelection()
	End Sub

	Private Sub dgvCursosDisponibles_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCursosDisponibles.CellDoubleClick
		btnDesinscribir.Enabled = False
		Inscribir(dgvCursosDisponibles.CurrentRow)
		dgvCursosDisponibles.ClearSelection()

	End Sub

	Private Sub dgvCursosInscriptos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCursosInscritos.CellDoubleClick
		btnInscribir.Enabled = False
		Desinscribir(dgvCursosInscritos.CurrentRow)
		dgvCursosDisponibles.ClearSelection()
	End Sub

	Private Sub tbBuscar_TextChanged(sender As Object, e As EventArgs) Handles tbBuscar.TextChanged
		Select Case cbOpciones.SelectedItem.ToString()
			Case "Nombre"
				_Conexion.vistaDatos.RowFilter = "nombre LIKE '" + tbBuscar.Text + "%'"
				'vistaDatos.RowFilter = columnaSeleccionada + " LIKE '" + tbBuscar.Text + "%'"
			Case "Apellido"
				_Conexion.vistaDatos.RowFilter = "apellido LIKE '" + tbBuscar.Text + "%'"
			Case "DNI"
				_Conexion.vistaDatos.RowFilter = String.Format("CONVERT({0}, System.String) like '%{1}%'", "DNI", tbBuscar.Text)
		End Select
	End Sub


	Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
		If (MessageBox.Show("Desea Guardar las Inscripciones realizadas?", "Guardar Cambios",
				MessageBoxButtons.YesNo) = DialogResult.Yes) Then

			If listaIns.Count <> 0 Then
				PopUp = New FormPagopopup(listaIns, dgvListadoMiembros.CurrentRow.Cells(3).Value.ToString)
				PopUp.ShowDialog()
			End If
			_Conexion.TablaDataAdapter.Update(_Conexion.GymcatDataSet.Tables(Tabla2))
			btnGuardar.Enabled = False
			btnCancelar.Enabled = False
			edicion = False
			lbInscripciones.Visible = False
			lbInscripciones.Text = "Inscripciones:"
			lbDesinscripciones.Visible = False
			lbDesinscripciones.Text = vbCrLf + "Desisncripciones:"

			SeleccionarMiembro(dgvListadoMiembros.CurrentRow.Cells(0).Value)
		End If
	End Sub



	Private Sub btnCancelar_Click_1(sender As Object, e As EventArgs) Handles btnCancelar.Click

		If (MessageBox.Show("Desea Cancelar las Inscripciones realizadas?", "Cancelar Cambios",
				MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes) Then
			_Conexion.GymcatDataSet.Tables(Tabla2).RejectChanges()
			btnGuardar.Enabled = False
			btnCancelar.Enabled = False
			edicion = False
			listaIns.Clear()
			lbInscripciones.Visible = False
			lbInscripciones.Text = "Inscripciones:"
			lbDesinscripciones.Visible = False
			lbDesinscripciones.Text = vbCrLf + "Desisncripciones:"
			SeleccionarMiembro(dgvListadoMiembros.CurrentRow.Cells(0).Value)
		End If

	End Sub

	Private Sub btnReducirMeses_Click(sender As Object, e As EventArgs) Handles btnReducirMeses.Click
		If 0 <> tbMeses.Text Then
			tbMeses.Text -= 1
		End If
	End Sub

	Private Sub btnAumentarMeses_Click(sender As Object, e As EventArgs) Handles btnAumentarMeses.Click
		tbMeses.Text += 1
	End Sub
End Class