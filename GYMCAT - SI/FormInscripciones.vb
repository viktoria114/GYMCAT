Imports System.Data.Common
Imports System.Diagnostics.Eventing
Imports System.Net.Mail
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class FormInscripciones
	Private miConexion As MySqlConnection
	Private InscripcionesDataAdapter As MySqlDataAdapter
	Private GymcatDataSet As New DataSet
	Private vistaDatos1 As DataView
	Private vistadatos2 As DataView
	Private Fila As DataGridViewRow
	Private lector As MySqlDataReader

#Region "FUNCIONES"

	Sub SeleccionarMiembro(IDMiembro As Integer)
		Fila = dgvListadoMiembros.CurrentRow
		GymcatDataSet.Tables("TInscritos").Clear()
		GymcatDataSet.Tables("TNoInscritos").Clear()

		'Llenar la tabla de Cursos Inscritos del Miembro
		Dim ComandoIncritos As New MySqlCommand("SELECT miembros_cursos.ID_inscripción, cursos.nombre, " +
											"miembros_cursos.fecha_inscripcion FROM cursos, miembros_cursos " +
											"Where miembros_cursos.FK_cursos = cursos.ID_cursos And miembros_cursos.FK_miembros =@num", miConexion)
		ComandoIncritos.Parameters.AddWithValue("@num", IDMiembro)
		InscripcionesDataAdapter.SelectCommand = ComandoIncritos
		InscripcionesDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey
		InscripcionesDataAdapter.Fill(GymcatDataSet.Tables("TInscritos"))
		dgvCursosInscritos.DataSource = GymcatDataSet.Tables("TInscritos").DefaultView

		'Llenar la tabla de Cursos a los que el miembro no esta Inscrito
		Dim ComandoNoInscritos As New MySqlCommand("Select ID_cursos, nombre From cursos Where ID_cursos " +
												   "Not In (Select FK_cursos FROM miembros_cursos WHERE FK_miembros = @num)", miConexion)
		ComandoNoInscritos.Parameters.AddWithValue("@num", IDMiembro)
		InscripcionesDataAdapter.SelectCommand = ComandoNoInscritos
		InscripcionesDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey
		InscripcionesDataAdapter.Fill(GymcatDataSet.Tables("TNoInscritos"))
		dgvCursosDisponibles.DataSource = GymcatDataSet.Tables("TNoInscritos").DefaultView

		dgvCursosDisponibles.Columns(0).Visible = False
		dgvCursosInscritos.Columns(0).Visible = False

		btnDesinscribir.Enabled = False
		btnInscribir.Enabled = False
	End Sub

	Sub Desinscribir(FilaCurso As DataGridViewRow)

		MsgBox(dgvListadoMiembros.CurrentRow.Cells(1).Value.ToString + " , " + FilaCurso.Cells(1).Value)
		If (MessageBox.Show("¿Está seguro de Desincribir el miembro " + dgvListadoMiembros.CurrentRow.Cells(1).Value.ToString + " del Curso " +
			FilaCurso.Cells(1).Value.ToString + "?", "Desincribir Miembro", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) = DialogResult.Yes) Then
			GymcatDataSet.Tables("TInscripciones").Rows.Find(FilaCurso.Cells(0).Value).Delete()
			InscripcionesDataAdapter.DeleteCommand = New MySqlCommand("DELETE FROM `miembros_cursos` WHERE ID_inscripción = @id", miConexion)
			InscripcionesDataAdapter.DeleteCommand.Parameters.Add("@id", SqlDbType.BigInt, 0, "ID_inscripción")
			InscripcionesDataAdapter.Update(GymcatDataSet.Tables("TInscripciones"))

			SeleccionarMiembro(dgvListadoMiembros.CurrentRow.Cells(0).Value)
		End If

	End Sub

	Sub Inscribir(FilaCurso As DataGridViewRow)
		Dim NuevaFila As DataRow
		If (MessageBox.Show("¿Quiere agregar el miembro a este Curso?", "Agregar Miembro",
							MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) = DialogResult.Yes) Then

			Dim comando As New MySqlCommand("SELECT * FROM cursos where ID_cursos=" + FilaCurso.Cells(0).Value.ToString, miConexion)
			lector = comando.ExecuteReader
			lector.Read()


			NuevaFila = GymcatDataSet.Tables("TInscripciones").NewRow
			'2. Rellenar la fila con información
			NuevaFila("FK_miembros") = dgvListadoMiembros.CurrentRow.Cells(0).Value
			NuevaFila("FK_cursos") = lector("ID_cursos")
			NuevaFila("Fecha_Inscripcion") = Today

			'3. Agregar fila a la tabla del DataSet
			GymcatDataSet.Tables("TInscripciones").Rows.Add(NuevaFila)

			'4. Crear Comando para agregar a la BD la fila nueva cmd
			InscripcionesDataAdapter.InsertCommand = New MySqlCommand("INSERT INTO miembros_cursos (FK_miembros, FK_cursos, " +
																	 "Fecha_Inscripcion) VALUES (@miem, @cur, @fe)", miConexion)
			InscripcionesDataAdapter.InsertCommand.Parameters.Add("@miem", MySqlDbType.Int32, 11, "FK_miembros")
			InscripcionesDataAdapter.InsertCommand.Parameters.Add("@cur", MySqlDbType.Int32, 11, "FK_cursos")
			InscripcionesDataAdapter.InsertCommand.Parameters.Add("@fe", MySqlDbType.Date, 10, "Fecha_Inscripcion")
			lector.Close()
			'5. Guardar los cambios en la base de datos
			InscripcionesDataAdapter.Update(GymcatDataSet.Tables("TInscripciones"))

			'6. V1olver a cargar la tabla del dataset para obtener los ultimos cambios de la BD
			GymcatDataSet.Tables("TInscripciones").Clear()

			SeleccionarMiembro(dgvListadoMiembros.CurrentRow.Cells(0).Value)

		End If
	End Sub

	Sub MostrarInfoCurso(curso As DataGridViewRow)
		If miConexion.State = ConnectionState.Closed Then
			miConexion.Open()
		End If
		Dim comando As New MySqlCommand("SELECT * FROM cursos WHERE nombre= '" + curso.Cells(1).Value.ToString + "'", miConexion)
		lector = comando.ExecuteReader
		lector.Read()

		lbCursos.Text = "Curso: " + lector("nombre").ToString
		lbHorariosCurso.Text = "Horarios: " + lector("horario")
		lbPrecioCurso.Text = "Precio: " + lector("precio").ToString
		lbDiasCurso.Text = "Dias de Clase: " + lector("dias_clase")
		lbProfesorCurso.Text = "Profesor: " + lector("FK_empleados").ToString
		lector.Close()
	End Sub


#End Region

	Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		miConexion = New MySqlConnection()
		miConexion.ConnectionString = "Server=localhost; Database=gymcat; Uid=root; Pwd=;"
		InscripcionesDataAdapter = New MySqlDataAdapter()

		'Llenar el selector de miembros
		InscripcionesDataAdapter.SelectCommand = New MySqlCommand("SELECT ID_miembro, nombre AS Nombre, apellido, DNI FROM miembros", miConexion)
		GymcatDataSet = New DataSet()
		GymcatDataSet.Tables.Add("TMiembros")
		InscripcionesDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey
		InscripcionesDataAdapter.Fill(GymcatDataSet.Tables("TMiembros"))
		vistaDatos1 = GymcatDataSet.Tables("TMiembros").DefaultView
		dgvListadoMiembros.DataSource = vistaDatos1

		dgvListadoMiembros.Columns(0).Visible = False
		dgvListadoMiembros.CurrentCell = dgvListadoMiembros.Rows(0).Cells(1)

		GymcatDataSet.Tables.Add("TInscritos")
		GymcatDataSet.Tables.Add("TNoInscritos")

		InscripcionesDataAdapter.SelectCommand = New MySqlCommand("SELECT * FROM miembros_cursos", miConexion)
		GymcatDataSet.Tables.Add("TInscripciones")
		InscripcionesDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey
		InscripcionesDataAdapter.Fill(GymcatDataSet.Tables("TInscripciones"))
		vistadatos2 = GymcatDataSet.Tables("TInscripciones").DefaultView

		miConexion.Open()
		SeleccionarMiembro(dgvListadoMiembros.CurrentRow.Cells(0).Value)
	End Sub


	Private Sub dgvListadoMiembros_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListadoMiembros.CellClick
		SeleccionarMiembro(dgvListadoMiembros.CurrentRow.Cells(0).Value)
	End Sub

	Private Sub btnInscribir_Click(sender As Object, e As EventArgs) Handles btnInscribir.Click
		Inscribir(dgvCursosDisponibles.CurrentRow)
	End Sub

	Private Sub btnDesinscribir_Click(sender As Object, e As EventArgs) Handles btnDesinscribir.Click
		Desinscribir(dgvCursosInscritos.CurrentRow)
	End Sub

	Private Sub dgvCursosInscritos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCursosInscritos.CellClick
		MostrarInfoCurso(dgvCursosInscritos.CurrentRow)
	End Sub

	Private Sub dgvCursosDisponibles_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCursosDisponibles.CellClick
		MostrarInfoCurso(dgvCursosDisponibles.CurrentRow)
	End Sub

	Private Sub dgvCursosDisponibles_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCursosDisponibles.CellDoubleClick
		Inscribir(dgvCursosDisponibles.CurrentRow)
	End Sub

	Private Sub dgvCursosInscriptos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCursosInscritos.CellDoubleClick
		Desinscribir(dgvCursosInscritos.CurrentRow)
	End Sub

	Private Sub tbBuscar_TextChanged(sender As Object, e As EventArgs) Handles tbBuscar.TextChanged
		Select Case cbOpciones.SelectedItem.ToString()
			Case "Nombre"
				vistaDatos1.RowFilter = "nombre LIKE '" + tbBuscar.Text + "%'"
				'vistaDatos.RowFilter = columnaSeleccionada + " LIKE '" + tbBuscar.Text + "%'"
			Case "Apellido"
				vistaDatos1.RowFilter = "apellido LIKE '" + tbBuscar.Text + "%'"
			Case "DNI"
				vistaDatos1.RowFilter = String.Format("CONVERT({0}, System.String) like '%{1}%'", "DNI", tbBuscar.Text)
		End Select
	End Sub

	Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click
		btnInscribir.Enabled = True
		btnDesinscribir.Enabled = True
	End Sub
End Class