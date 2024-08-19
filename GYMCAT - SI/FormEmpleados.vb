Imports MySql.Data.MySqlClient

Public Class FormEmpleados
    Implements ICRUD
    Public _Conexion As Conexion
    Public Tabla As String

    Public Sub FormEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim consulta As String = "SELECT * FROM empleados"
        Tabla = "TEmpleados"

        _Conexion = New Conexion(consulta, Tabla)

        dgvListadoEmpleados.DataSource = _Conexion.vistaDatos
        dgvListadoEmpleados.Columns(0).Visible = False
        dgvListadoEmpleados.Columns(4).Width = 115
        dgvListadoEmpleados.CurrentCell = dgvListadoEmpleados.Rows(0).Cells(1)

    End Sub

    Private Sub Agregar() Implements ICRUD.Agregar
        _Conexion.esNuevo = True
        Formempleadospopup.ShowDialog()
    End Sub

    Private Sub Editar() Implements ICRUD.Editar
        _Conexion.esNuevo = False
        Formempleadospopup.ShowDialog()
    End Sub

    Public Sub Guardar() Implements ICRUD.Guardar
        Dim fila As DataRow
        Dim cmd As String

        If _Conexion.esNuevo Then
            '1. Crear una nueva fila 
            fila = _Conexion.GymcatDataSet.Tables(Tabla).NewRow
            '2. Rellenar la fila con información
            fila("nombre") = Formempleadospopup.tbNombre.Text
            fila("apellido") = Formempleadospopup.tbApellido.Text
            fila("DNI") = Formempleadospopup.tbDNI.Text
            fila("fecha_nacimiento") = Formempleadospopup.dtpNac.Text
            fila("telefono") = Formempleadospopup.tbTelefono.Text
            fila("correo") = Formempleadospopup.tbCorreo.Text
            fila("sueldo") = Formempleadospopup.tbSueldo.Text
            fila("turno") = Formempleadospopup.tbTurno.Text
            fila("cargo") = Formempleadospopup.tbCargo.Text
            '3. Agregar fila a la tabla del DataSet
            _Conexion.GymcatDataSet.Tables(Tabla).Rows.Add(fila)
            '4. Crear Comando para agregar a la BD la fila nueva cmd
            cmd = "INSERT INTO empleados (nombre, apellido, DNI, fecha_nacimiento, telefono, correo, sueldo, turno, cargo) VALUES (@nom, @ape, @dni, @nac, @tel, @cor, @suel, @tur, @carg)"
            _Conexion.TablaDataAdapter.InsertCommand = New MySqlCommand(cmd, _Conexion.miConexion)
            _Conexion.TablaDataAdapter.InsertCommand.Parameters.Add("@nom", MySqlDbType.VarChar, 50, "nombre")
            _Conexion.TablaDataAdapter.InsertCommand.Parameters.Add("@ape", MySqlDbType.VarChar, 50, "apellido")
            _Conexion.TablaDataAdapter.InsertCommand.Parameters.Add("@dni", MySqlDbType.Int32, 20, "DNI")
            _Conexion.TablaDataAdapter.InsertCommand.Parameters.Add("@nac", MySqlDbType.Date, 20, "fecha_nacimiento")
            _Conexion.TablaDataAdapter.InsertCommand.Parameters.Add("@tel", MySqlDbType.Int32, 50, "telefono")
            _Conexion.TablaDataAdapter.InsertCommand.Parameters.Add("@cor", MySqlDbType.VarChar, 50, "correo")
            _Conexion.TablaDataAdapter.InsertCommand.Parameters.Add("@suel", MySqlDbType.Int32, 20, "sueldo")
            _Conexion.TablaDataAdapter.InsertCommand.Parameters.Add("@tur", MySqlDbType.VarChar, 50, "turno")
            _Conexion.TablaDataAdapter.InsertCommand.Parameters.Add("@carg", MySqlDbType.VarChar, 50, "cargo")

            '5. Guardar los cambios en la base de datos
            _Conexion.TablaDataAdapter.Update(_Conexion.GymcatDataSet.Tables(Tabla))

            '6. V1olver a cargar la tabla del dataset para obtener los ultimos cambios de la BD
            _Conexion.GymcatDataSet.Tables(Tabla).Clear()
            _Conexion.TablaDataAdapter.Fill(_Conexion.GymcatDataSet.Tables(Tabla))
        Else
            '1 seleccionar fila editar
            fila = _Conexion.GymcatDataSet.Tables(Tabla).Rows.Find(_Conexion.idFila)
            '2. Rellenar la fila con información
            fila("nombre") = Formempleadospopup.tbNombre.Text
            fila("apellido") = Formempleadospopup.tbApellido.Text
            fila("DNI") = Formempleadospopup.tbDNI.Text
            fila("fecha_nacimiento") = Formempleadospopup.dtpNac.Text
            fila("telefono") = Formempleadospopup.tbTelefono.Text
            fila("correo") = Formempleadospopup.tbCorreo.Text
            fila("sueldo") = Formempleadospopup.tbSueldo.Text
            fila("turno") = Formempleadospopup.tbTurno.Text
            fila("cargo") = Formempleadospopup.tbCargo.Text
            '3. Crear el comando para odificar la Fila
            cmd = "UPDATE empleados 
                   SET nombre=@nom, apellido=@ape, DNI=@dni, fecha_nacimiento=@nac, telefono=@tel, correo=@cor, sueldo=@suel ,turno=@tur , cargo=@carg
                   WHERE ID_empleados=@id"
            _Conexion.TablaDataAdapter.UpdateCommand = New MySqlCommand(cmd, _Conexion.miConexion)
            _Conexion.TablaDataAdapter.UpdateCommand.Parameters.Add("@nom", MySqlDbType.VarChar, 50, "nombre")
            _Conexion.TablaDataAdapter.UpdateCommand.Parameters.Add("@ape", MySqlDbType.VarChar, 50, "apellido")
            _Conexion.TablaDataAdapter.UpdateCommand.Parameters.Add("@dni", MySqlDbType.Int32, 20, "DNI")
            _Conexion.TablaDataAdapter.UpdateCommand.Parameters.Add("@nac", MySqlDbType.Date, 20, "fecha_nacimiento")
            _Conexion.TablaDataAdapter.UpdateCommand.Parameters.Add("@tel", MySqlDbType.Int32, 50, "telefono")
            _Conexion.TablaDataAdapter.UpdateCommand.Parameters.Add("@cor", MySqlDbType.VarChar, 50, "correo")
            _Conexion.TablaDataAdapter.UpdateCommand.Parameters.Add("@suel", MySqlDbType.Int32, 20, "sueldo")
            _Conexion.TablaDataAdapter.UpdateCommand.Parameters.Add("@tur", MySqlDbType.VarChar, 50, "turno")
            _Conexion.TablaDataAdapter.UpdateCommand.Parameters.Add("@carg", MySqlDbType.VarChar, 50, "cargo")
            _Conexion.TablaDataAdapter.UpdateCommand.Parameters.Add("@id", MySqlDbType.Int32, 0, "ID_empleados")

            '4. Guardar los cambios en la base de datos
            _Conexion.TablaDataAdapter.Update(_Conexion.GymcatDataSet.Tables(Tabla))
        End If

    End Sub

    Private Sub Borrar() Implements ICRUD.Borrar
        Dim fila As DataGridViewRow = dgvListadoEmpleados.CurrentRow
        _Conexion.idFila = fila.Cells(0).Value
        If (MessageBox.Show("¿Está seguro de eliminar este Empleado?", "Borrar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) = DialogResult.Yes) Then
            _Conexion.GymcatDataSet.Tables(Tabla).Rows.Find(_Conexion.idFila).Delete()
            _Conexion.TablaDataAdapter.DeleteCommand = New MySqlCommand("DELETE FROM empleados WHERE ID_empleados = @id", _Conexion.miConexion)
            _Conexion.TablaDataAdapter.DeleteCommand.Parameters.Add("@id", SqlDbType.BigInt, 0, "ID_empleados")
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
            Case "Apellido"
                _Conexion.vistaDatos.RowFilter = "apellido LIKE '" + tbBuscar.Text + "%'"
            Case "Fecha de Nacimiento"
                _Conexion.vistaDatos.RowFilter = String.Format("CONVERT({0}, System.String) like '%{1}%'", "fecha_nacimiento", tbBuscar.Text)
            Case "Sueldo"
                _Conexion.vistaDatos.RowFilter = String.Format("CONVERT({0}, System.String) like '%{1}%'", "sueldo", tbBuscar.Text)
            Case "Turno"
                _Conexion.vistaDatos.RowFilter = "turno LIKE '" + tbBuscar.Text + "%'"
            Case "Cargo"
                _Conexion.vistaDatos.RowFilter = "cargo LIKE '" + tbBuscar.Text + "%'"
            Case "DNI"
                _Conexion.vistaDatos.RowFilter = String.Format("CONVERT({0}, System.String) like '%{1}%'", "DNI", tbBuscar.Text)
            Case "Teléfono"
                _Conexion.vistaDatos.RowFilter = String.Format("CONVERT({0}, System.String) like '%{1}%'", "telefono  ", tbBuscar.Text)
            Case "Correo"
                _Conexion.vistaDatos.RowFilter = "correo LIKE '" + tbBuscar.Text + "%'"
        End Select

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Agregar()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Editar()
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Borrar()
    End Sub

    Private Sub tbBuscar_TextChanged(sender As Object, e As EventArgs) Handles tbBuscar.TextChanged
        Buscar()
    End Sub
End Class
