Imports MySql.Data.MySqlClient

Public Class FormCursos
    Implements CRUD
    Private myConexion As Conexion
    Private miConexion As MySqlConnection
    Private CursosDataAdapter As MySqlDataAdapter
    Private GymcatDataSet As DataSet
    Private vistaDatos As DataView
    Public esNuevo As Boolean
    Public idFila As Integer
    Public Tabla As String


    Private Sub FormCursos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim consulta As String = "SELECT * FROM cursos"
        Tabla = "TCursos"

        myConexion = New Conexion(consulta, Tabla)

        dgvListadoCursos.DataSource = myConexion.vistaDatos
        dgvListadoCursos.Columns(0).Visible = False
        dgvListadoCursos.Columns(4).Width = 115
        dgvListadoCursos.CurrentCell = dgvListadoCursos.Rows(0).Cells(1)

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


    Private Sub Agregar() Implements CRUD.Agregar
        esNuevo = True
        FormCursospopup.ShowDialog()
    End Sub

    Private Sub Editar() Implements CRUD.Editar
        esNuevo = False
        FormCursospopup.ShowDialog()
    End Sub

    Public Sub Guardar() Implements CRUD.Guardar
        Dim fila As DataRow
        Dim cmd As String

        If esNuevo Then
            '1. Crear una nueva fila 
            fila = GymcatDataSet.Tables("TCursos").NewRow
            '2. Rellenar la fila con información
            fila("nombre") = FormCursospopup.tbNombreCurso.Text
            fila("horario") = FormCursospopup.tbHorarioCurso.Text
            fila("precio") = FormCursospopup.tbPrecioCurso.Text
            fila("cantidad_inscriptos") = FormCursospopup.tbInscriptosCursos.Text
            fila("dias_clase") = FormCursospopup.tbDiasCurso.Text
            fila("FK_empleados") = FormCursospopup.tbIdTurno.Text
            fila("turno") = FormCursospopup.tbIdTurno.Text

            '3. Agregar fila a la tabla del DataSet
            GymcatDataSet.Tables("TCursos").Rows.Add(fila)

            '4. Crear Comando para agregar a la BD la fila nueva cmd
            cmd = "INSERT INTO cursos (nombre, horario, precio, cantidad_inscriptos, dias_clase, turno, FK_empleados) VALUES (@nom, @hor, @pre, @cant, @dias, @tur, @empl)"
            CursosDataAdapter.InsertCommand = New MySqlCommand(cmd, miConexion)
            CursosDataAdapter.InsertCommand.Parameters.Add("@nom", MySqlDbType.VarChar, 50, "nombre")
            CursosDataAdapter.InsertCommand.Parameters.Add("@hor", MySqlDbType.VarChar, 50, "horario")
            CursosDataAdapter.InsertCommand.Parameters.Add("@pre", MySqlDbType.Int32, 10, "precio")
            CursosDataAdapter.InsertCommand.Parameters.Add("@cant", MySqlDbType.Int32, 10, "cantidad_inscriptos")
            CursosDataAdapter.InsertCommand.Parameters.Add("@dias", MySqlDbType.VarChar, 50, "dias_clase")
            CursosDataAdapter.InsertCommand.Parameters.Add("@tur", MySqlDbType.VarChar, 15, "turno")
            CursosDataAdapter.InsertCommand.Parameters.Add("@empl", MySqlDbType.Int32, 11, "FK_empleados")

            '5. Guardar los cambios en la base de datos
            CursosDataAdapter.Update(GymcatDataSet.Tables("TCursos"))

            '6. V1olver a cargar la tabla del dataset para obtener los ultimos cambios de la BD
            GymcatDataSet.Tables("TCursos").Clear()
            CursosDataAdapter.Fill(GymcatDataSet.Tables("TCursos"))
        Else
            '1 seleccionar fila editar
            fila = GymcatDataSet.Tables("TCursos").Rows.Find(idFila)

            '2. Rellenar la fila con información
            fila("nombre") = FormCursospopup.tbNombreCurso.Text
            fila("horario") = FormCursospopup.tbHorarioCurso.Text
            fila("precio") = FormCursospopup.tbPrecioCurso.Text
            fila("cantidad_inscriptos") = FormCursospopup.tbInscriptosCursos.Text
            fila("dias_clase") = FormCursospopup.tbDiasCurso.Text
            fila("FK_empleados") = FormCursospopup.tbIdProfesor.Text
            fila("turno") = FormCursospopup.tbIdTurno.Text

            '3. Crear el comando para odificar la Fila
            cmd = "UPDATE cursos 
                   SET nombre=@nom, horario=@hor, precio=@pre, cantidad_inscriptos=@cant, dias_clase=@dias, FK_empleados=@empl, turno=@tur                                       
                   WHERE ID_cursos=@id"
            CursosDataAdapter.UpdateCommand = New MySqlCommand(cmd, miConexion)
            CursosDataAdapter.UpdateCommand.Parameters.Add("@nom", MySqlDbType.VarChar, 50, "nombre") 'NO OLVIDAR EL UPDATECOMMAND
            CursosDataAdapter.UpdateCommand.Parameters.Add("@hor", MySqlDbType.VarChar, 50, "horario")
            CursosDataAdapter.UpdateCommand.Parameters.Add("@pre", MySqlDbType.Int32, 10, "precio")
            CursosDataAdapter.UpdateCommand.Parameters.Add("@cant", MySqlDbType.Int32, 10, "cantidad_inscriptos")
            CursosDataAdapter.UpdateCommand.Parameters.Add("@dias", MySqlDbType.VarChar, 50, "dias_clase")
            CursosDataAdapter.UpdateCommand.Parameters.Add("@tur", MySqlDbType.VarChar, 15, "turno")
            CursosDataAdapter.UpdateCommand.Parameters.Add("@empl", MySqlDbType.Int32, 11, "FK_empleados")
            CursosDataAdapter.UpdateCommand.Parameters.Add("@id", MySqlDbType.Int32, 0, "ID_cursos")

            '4. Guardar los cambios en la base de datos
            CursosDataAdapter.Update(GymcatDataSet.Tables("TCursos"))
        End If

    End Sub

    Private Sub Borrar() Implements CRUD.Borrar
        Dim fila As DataGridViewRow = dgvListadoCursos.CurrentRow
        idFila = fila.Cells(0).Value
        If (MessageBox.Show("¿Está seguro de eliminar este Curso?", "Borrar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) = DialogResult.Yes) Then
            GymcatDataSet.Tables("TCursos").Rows.Find(idFila).Delete()
            CursosDataAdapter.DeleteCommand = New MySqlCommand("DELETE FROM cursos WHERE ID_cursos = @id", miConexion)
            CursosDataAdapter.DeleteCommand.Parameters.Add("@id", SqlDbType.BigInt, 0, "ID_cursos")
            CursosDataAdapter.Update(GymcatDataSet.Tables("TCursos"))
        End If
    End Sub

    Private Sub Buscar() Implements CRUD.Buscar
        ' Obtén el valor seleccionado en el ComboBox
        Dim columnaSeleccionada As String = cbOpciones.SelectedItem.ToString()

        Select Case columnaSeleccionada
            Case "Nombre"
                vistaDatos.RowFilter = "nombre LIKE '" + tbBuscar.Text + "%'"
                'vistaDatos.RowFilter = columnaSeleccionada + " LIKE '" + tbBuscar.Text + "%'"
            Case "Horario"
                vistaDatos.RowFilter = "horario LIKE '" + tbBuscar.Text + "%'"
            Case "Dias de Clase"
                vistaDatos.RowFilter = "dias_clase LIKE '" + tbBuscar.Text + "%'"
            Case "Turno"
                vistaDatos.RowFilter = "turno LIKE '" + tbBuscar.Text + "%'"
            Case "Precio"
                vistaDatos.RowFilter = String.Format("CONVERT({0}, System.String) like '%{1}%'", "precio", tbBuscar.Text)
            Case "Cantidad de Inscriptos"
                vistaDatos.RowFilter = String.Format("CONVERT({0}, System.String) like '%{1}%'", "cantidad_inscriptos", tbBuscar.Text)
            Case "Instructor"
                vistaDatos.RowFilter = String.Format("CONVERT({0}, System.String) like '%{1}%'", "FK_empleados", tbBuscar.Text)
        End Select

    End Sub


End Class
