Imports MySql.Data.MySqlClient

Public Class FormCursos
    Implements ICRUD
    Public _Conexion As Conexion
    Public Tabla As String

    Private Sub FormCursos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim consulta As String = "SELECT * FROM cursos"
        Tabla = "TCursos"

        _Conexion = New Conexion(consulta, Tabla)

        dgvListadoCursos.DataSource = _Conexion.vistaDatos
        dgvListadoCursos.Columns(0).Visible = False
        dgvListadoCursos.Columns(4).Width = 115
        dgvListadoCursos.CurrentCell = dgvListadoCursos.Rows(0).Cells(1)

    End Sub

    Private Sub Agregar() Implements ICRUD.Agregar
        _Conexion.esNuevo = True
        FormCursospopup.ShowDialog()
    End Sub

    Private Sub Editar() Implements ICRUD.Editar
        _Conexion.esNuevo = False
        FormCursospopup.ShowDialog()
    End Sub

    Public Sub Guardar() Implements ICRUD.Guardar
        Dim fila As DataRow
        Dim cmd As String

        If _Conexion.esNuevo Then
            '1. Crear una nueva fila 
            fila = _Conexion.GymcatDataSet.Tables(Tabla).NewRow
            '2. Rellenar la fila con información
            fila("nombre") = FormCursospopup.tbNombreCurso.Text
            fila("horario") = FormCursospopup.tbHorarioCurso.Text
            fila("precio") = FormCursospopup.tbPrecioCurso.Text
            fila("dias_clase") = FormCursospopup.tbDiasCurso.Text
            fila("FK_empleados") = FormCursospopup.tbIdTurno.Text
            fila("turno") = FormCursospopup.tbIdTurno.Text

            '3. Agregar fila a la tabla del DataSet
            _Conexion.GymcatDataSet.Tables(Tabla).Rows.Add(fila)

            '4. Crear Comando para agregar a la BD la fila nueva cmd
            cmd = "INSERT INTO cursos (nombre, horario, precio, dias_clase, turno, FK_empleados) VALUES (@nom, @hor, @pre, @dias, @tur, @empl)"
            _Conexion.TablaDataAdapter.InsertCommand = New MySqlCommand(cmd, _Conexion.miConexion)
            _Conexion.TablaDataAdapter.InsertCommand.Parameters.Add("@nom", MySqlDbType.VarChar, 50, "nombre")
            _Conexion.TablaDataAdapter.InsertCommand.Parameters.Add("@hor", MySqlDbType.VarChar, 50, "horario")
            _Conexion.TablaDataAdapter.InsertCommand.Parameters.Add("@pre", MySqlDbType.Int32, 10, "precio")
            _Conexion.TablaDataAdapter.InsertCommand.Parameters.Add("@dias", MySqlDbType.VarChar, 50, "dias_clase")
            _Conexion.TablaDataAdapter.InsertCommand.Parameters.Add("@tur", MySqlDbType.VarChar, 15, "turno")
            _Conexion.TablaDataAdapter.InsertCommand.Parameters.Add("@empl", MySqlDbType.Int32, 11, "FK_empleados")

            '5. Guardar los cambios en la base de datos
            _Conexion.TablaDataAdapter.Update(_Conexion.GymcatDataSet.Tables(Tabla))

            '6. V1olver a cargar la tabla del dataset para obtener los ultimos cambios de la BD
            _Conexion.GymcatDataSet.Tables(Tabla).Clear()
            _Conexion.TablaDataAdapter.Fill(_Conexion.GymcatDataSet.Tables(Tabla))
        Else
            '1 seleccionar fila editar
            fila = _Conexion.GymcatDataSet.Tables(Tabla).Rows.Find(_Conexion.idFila)

            '2. Rellenar la fila con información
            fila("nombre") = FormCursospopup.tbNombreCurso.Text
            fila("horario") = FormCursospopup.tbHorarioCurso.Text
            fila("precio") = FormCursospopup.tbPrecioCurso.Text
            fila("dias_clase") = FormCursospopup.tbDiasCurso.Text
            fila("FK_empleados") = FormCursospopup.tbIdProfesor.Text
            fila("turno") = FormCursospopup.tbIdTurno.Text

            '3. Crear el comando para odificar la Fila
            cmd = "UPDATE cursos 
                   SET nombre=@nom, horario=@hor, precio=@pre, dias_clase=@dias, FK_empleados=@empl, turno=@tur                                       
                   WHERE ID_cursos=@id"
            _Conexion.TablaDataAdapter.UpdateCommand = New MySqlCommand(cmd, _Conexion.miConexion)
            _Conexion.TablaDataAdapter.UpdateCommand.Parameters.Add("@nom", MySqlDbType.VarChar, 50, "nombre") 'NO OLVIDAR EL UPDATECOMMAND
            _Conexion.TablaDataAdapter.UpdateCommand.Parameters.Add("@hor", MySqlDbType.VarChar, 50, "horario")
            _Conexion.TablaDataAdapter.UpdateCommand.Parameters.Add("@pre", MySqlDbType.Int32, 10, "precio")
            _Conexion.TablaDataAdapter.UpdateCommand.Parameters.Add("@dias", MySqlDbType.VarChar, 50, "dias_clase")
            _Conexion.TablaDataAdapter.UpdateCommand.Parameters.Add("@tur", MySqlDbType.VarChar, 15, "turno")
            _Conexion.TablaDataAdapter.UpdateCommand.Parameters.Add("@empl", MySqlDbType.Int32, 11, "FK_empleados")
            _Conexion.TablaDataAdapter.UpdateCommand.Parameters.Add("@id", MySqlDbType.Int32, 0, "ID_cursos")

            '4. Guardar los cambios en la base de datos
            _Conexion.TablaDataAdapter.Update(_Conexion.GymcatDataSet.Tables(Tabla))
        End If

    End Sub

    Private Sub Borrar() Implements ICRUD.Borrar
        Dim fila As DataGridViewRow = dgvListadoCursos.CurrentRow
        _Conexion.idFila = fila.Cells(0).Value
        If (MessageBox.Show("¿Está seguro de eliminar este Curso?", "Borrar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) = DialogResult.Yes) Then
            _Conexion.GymcatDataSet.Tables(Tabla).Rows.Find(_Conexion.idFila).Delete()
            _Conexion.TablaDataAdapter.DeleteCommand = New MySqlCommand("DELETE FROM cursos WHERE ID_cursos = @id", _Conexion.miConexion)
            _Conexion.TablaDataAdapter.DeleteCommand.Parameters.Add("@id", SqlDbType.BigInt, 0, "ID_cursos")
            _Conexion.TablaDataAdapter.Update(_Conexion.GymcatDataSet.Tables(Tabla))
        End If
    End Sub

    Private Sub Buscar() Implements ICRUD.Buscar
        ' Obtén el valor seleccionado en el ComboBox
        Dim columnaSeleccionada As String = cbOpciones.SelectedItem.ToString()

        Select Case columnaSeleccionada
            Case "Nombre"
                _Conexion.vistaDatos.RowFilter = "nombre LIKE '" + tbBuscar.Text + "%'"
                'vistaDatos.RowFilter = columnaSeleccionada + " LIKE '" + tbBuscar.Text + "%'"
            Case "Horario"
                _Conexion.vistaDatos.RowFilter = "horario LIKE '" + tbBuscar.Text + "%'"
            Case "Dias de Clase"
                _Conexion.vistaDatos.RowFilter = "dias_clase LIKE '" + tbBuscar.Text + "%'"
            Case "Turno"
                _Conexion.vistaDatos.RowFilter = "turno LIKE '" + tbBuscar.Text + "%'"
            Case "Precio"
                _Conexion.vistaDatos.RowFilter = String.Format("CONVERT({0}, System.String) like '%{1}%'", "cantidad_inscriptos", tbBuscar.Text)
            Case "Instructor"
                _Conexion.vistaDatos.RowFilter = String.Format("CONVERT({0}, System.String) like '%{1}%'", "FK_empleados", tbBuscar.Text)
        End Select

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Agregar()
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Borrar()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Editar()
    End Sub

    Public Sub btnGuardar_Click()
        Guardar()
    End Sub

    Private Sub tbBuscar_TextChanged(sender As Object, e As EventArgs) Handles tbBuscar.TextChanged
        Buscar()
    End Sub

End Class
