Imports MySql.Data.MySqlClient

Public Class FormEmpleados
    Implements CRUD
    Public miConexion As MySqlConnection
    Public EmpleadosDataAdapter As MySqlDataAdapter
    Public GymcatDataSet As DataSet
    Public vistaDatos As DataView
    Public esNuevo As Boolean
    Public idFila As Integer

    Public Sub FormEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        miConexion = New MySqlConnection()
        miConexion.ConnectionString = "Server=localhost; Database=gymcat; Uid=root; Pwd=;"
        EmpleadosDataAdapter = New MySqlDataAdapter()
        EmpleadosDataAdapter.SelectCommand = New MySqlCommand("SELECT * FROM empleados", miConexion)
        GymcatDataSet = New DataSet()
        GymcatDataSet.Tables.Add("TEmpleados")

        EmpleadosDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey  'para kos errores del id

        EmpleadosDataAdapter.Fill(GymcatDataSet.Tables("TEmpleados"))


        vistaDatos = GymcatDataSet.Tables("TEmpleados").DefaultView

        dgvListadoEmpleados.DataSource = vistaDatos
        dgvListadoEmpleados.Columns(0).Visible = False
        dgvListadoEmpleados.Columns(4).Width = 115
        dgvListadoEmpleados.CurrentCell = dgvListadoEmpleados.Rows(0).Cells(1)

    End Sub
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Agregar()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Editar()
    End Sub

    Public Sub Guardar() Implements CRUD.Guardar
        Dim fila As DataRow
        Dim cmd As String

        If esNuevo Then
            '1. Crear una nueva fila 
            fila = GymcatDataSet.Tables("TEmpleados").NewRow
            '2. Rellenar la fila con información
            fila("nombre") = Formempleados2.tbNombre.Text
            fila("apellido") = Formempleados2.tbApellido.Text
            fila("DNI") = Formempleados2.tbDNI.Text
            fila("fecha_nacimiento") = Formempleados2.tbFechaNac.Text
            fila("telefono") = Formempleados2.tbTelefono.Text
            fila("correo") = Formempleados2.tbCorreo.Text
            fila("sueldo") = Formempleados2.tbSueldo.Text
            fila("turno") = Formempleados2.tbTurno.Text
            fila("cargo") = Formempleados2.tbCargo.Text

            '3. Agregar fila a la tabla del DataSet
            GymcatDataSet.Tables("TEmpleados").Rows.Add(fila)

            '4. Crear Comando para agregar a la BD la fila nueva cmd
            cmd = "INSERT INTO empleados (nombre, apellido, DNI, fecha_nacimiento, telefono, correo, sueldo, turno, cargo) VALUES (@nom, @ape, @dni, @nac, @tel, @cor, @suel, @tur, @carg)"
            EmpleadosDataAdapter.InsertCommand = New MySqlCommand(cmd, miConexion)
            EmpleadosDataAdapter.InsertCommand.Parameters.Add("@nom", MySqlDbType.VarChar, 50, "nombre")
            EmpleadosDataAdapter.InsertCommand.Parameters.Add("@ape", MySqlDbType.VarChar, 50, "apellido")
            EmpleadosDataAdapter.InsertCommand.Parameters.Add("@dni", MySqlDbType.Int32, 20, "DNI")
            EmpleadosDataAdapter.InsertCommand.Parameters.Add("@nac", MySqlDbType.Date, 20, "fecha_nacimiento")
            EmpleadosDataAdapter.InsertCommand.Parameters.Add("@tel", MySqlDbType.Int32, 50, "telefono")
            EmpleadosDataAdapter.InsertCommand.Parameters.Add("@cor", MySqlDbType.VarChar, 50, "correo")
            EmpleadosDataAdapter.InsertCommand.Parameters.Add("@suel", MySqlDbType.Int32, 20, "sueldo")
            EmpleadosDataAdapter.InsertCommand.Parameters.Add("@tur", MySqlDbType.VarChar, 50, "turno")
            EmpleadosDataAdapter.InsertCommand.Parameters.Add("@carg", MySqlDbType.VarChar, 50, "cargo")

            '5. Guardar los cambios en la base de datos
            EmpleadosDataAdapter.Update(GymcatDataSet.Tables("TEmpleados"))

            '6. V1olver a cargar la tabla del dataset para obtener los ultimos cambios de la BD
            GymcatDataSet.Tables("TEmpleados").Clear()
            EmpleadosDataAdapter.Fill(GymcatDataSet.Tables("TEmpleados"))
        Else
            '1 seleccionar fila editar
            fila = GymcatDataSet.Tables("TEmpleados").Rows.Find(idFila)

            '2. Rellenar la fila con información
            fila("nombre") = Formempleados2.tbNombre.Text
            fila("apellido") = Formempleados2.tbApellido.Text
            fila("DNI") = Formempleados2.tbDNI.Text
            fila("fecha_nacimiento") = Formempleados2.tbFechaNac.Text
            fila("telefono") = Formempleados2.tbTelefono.Text
            fila("correo") = Formempleados2.tbCorreo.Text
            fila("sueldo") = Formempleados2.tbSueldo.Text
            fila("turno") = Formempleados2.tbTurno.Text
            fila("cargo") = Formempleados2.tbCargo.Text

            '3. Crear el comando para odificar la Fila
            cmd = "UPDATE empleados 
                   SET nombre=@nom, apellido=@ape, DNI=@dni, fecha_nacimiento=@nac, telefono=@tel, correo=@cor, sueldo=@suel ,turno=@tur , cargo=@carg
                   WHERE ID_empleados=@id"
            EmpleadosDataAdapter.UpdateCommand = New MySqlCommand(cmd, miConexion)
            EmpleadosDataAdapter.UpdateCommand.Parameters.Add("@nom", MySqlDbType.VarChar, 50, "nombre")
            EmpleadosDataAdapter.UpdateCommand.Parameters.Add("@ape", MySqlDbType.VarChar, 50, "apellido")
            EmpleadosDataAdapter.UpdateCommand.Parameters.Add("@dni", MySqlDbType.Int32, 20, "DNI")
            EmpleadosDataAdapter.UpdateCommand.Parameters.Add("@nac", MySqlDbType.Date, 20, "fecha_nacimiento")
            EmpleadosDataAdapter.UpdateCommand.Parameters.Add("@tel", MySqlDbType.Int32, 50, "telefono")
            EmpleadosDataAdapter.UpdateCommand.Parameters.Add("@cor", MySqlDbType.VarChar, 50, "correo")
            EmpleadosDataAdapter.UpdateCommand.Parameters.Add("@suel", MySqlDbType.Int32, 20, "sueldo")
            EmpleadosDataAdapter.UpdateCommand.Parameters.Add("@tur", MySqlDbType.VarChar, 50, "turno")
            EmpleadosDataAdapter.UpdateCommand.Parameters.Add("@carg", MySqlDbType.VarChar, 50, "cargo")

            '4. Guardar los cambios en la base de datos
            EmpleadosDataAdapter.Update(GymcatDataSet.Tables("TEmpleados"))
        End If

    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Borrar()
    End Sub

    Private Sub tbBuscar_TextChanged(sender As Object, e As EventArgs) Handles tbBuscar.TextChanged
        Buscar()
    End Sub

    Public Sub Agregar() Implements CRUD.Agregar
        esNuevo = True
        Formempleados2.ShowDialog()
    End Sub

    Public Sub Editar() Implements CRUD.Editar
        esNuevo = False
        Formempleados2.ShowDialog()
    End Sub

    Public Sub Borrar() Implements CRUD.Borrar
        Dim fila As DataGridViewRow = dgvListadoEmpleados.CurrentRow
        idFila = fila.Cells(0).Value
        If (MessageBox.Show("¿Está seguro de eliminar este Empleado?", "Borrar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) = DialogResult.Yes) Then
            GymcatDataSet.Tables("TEmpleados").Rows.Find(idFila).Delete()
            EmpleadosDataAdapter.DeleteCommand = New MySqlCommand("DELETE FROM empleados WHERE ID_empleados = @id", miConexion)
            EmpleadosDataAdapter.DeleteCommand.Parameters.Add("@id", SqlDbType.BigInt, 0, "ID_empleados")
            EmpleadosDataAdapter.Update(GymcatDataSet.Tables("TEmpleados"))
        End If
    End Sub

    Public Sub Buscar() Implements CRUD.Buscar
        ' Obtén el valor seleccionado en el ComboBox
        Dim columnaSeleccionada As String = cbOpciones.SelectedItem.ToString()

        Select Case columnaSeleccionada
            Case "Nombre"
                vistaDatos.RowFilter = "nombre LIKE '" + tbBuscar.Text + "%'"
                'vistaDatos.RowFilter = columnaSeleccionada + " LIKE '" + tbBuscar.Text + "%'"
            Case "Apellido"
                vistaDatos.RowFilter = "apellido LIKE '" + tbBuscar.Text + "%'"
            Case "Fecha de Nacimiento"
                vistaDatos.RowFilter = String.Format("CONVERT({0}, System.String) like '%{1}%'", "fecha_nacimiento", tbBuscar.Text)
            Case "Sueldo"
                vistaDatos.RowFilter = String.Format("CONVERT({0}, System.String) like '%{1}%'", "sueldo", tbBuscar.Text)
            Case "Turno"
                vistaDatos.RowFilter = "turno LIKE '" + tbBuscar.Text + "%'"
            Case "Cargo"
                vistaDatos.RowFilter = "cargo LIKE '" + tbBuscar.Text + "%'"
            Case "DNI"
                vistaDatos.RowFilter = String.Format("CONVERT({0}, System.String) like '%{1}%'", "DNI", tbBuscar.Text)
            Case "Teléfono"
                vistaDatos.RowFilter = String.Format("CONVERT({0}, System.String) like '%{1}%'", "telefono  ", tbBuscar.Text)
            Case "Correo"
                vistaDatos.RowFilter = "correo LIKE '" + tbBuscar.Text + "%'"
        End Select
    End Sub
End Class
