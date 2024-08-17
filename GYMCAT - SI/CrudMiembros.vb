Imports MySql.Data.MySqlClient

Public Class CrudMiembros
    Implements CRUD
    Public _Conexion As Conexion
    Public Tabla As String
    'Private miConexion As MySqlConnection

    Private Sub CrudMiembros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim consulta As String = "SELECT * FROM miembros"
        Tabla = "TMiembros"

        _Conexion = New Conexion(consulta, Tabla)

        dgvListadoMiembros.DataSource = _Conexion.vistaDatos
        dgvListadoMiembros.Columns(0).Visible = False
        dgvListadoMiembros.Columns(4).Width = 115
        dgvListadoMiembros.CurrentCell = dgvListadoMiembros.Rows(0).Cells(1)
    End Sub

    Private Sub Agregar() Implements CRUD.Agregar
        _Conexion.esNuevo = True
        nuevoMiembro.ShowDialog()
    End Sub

    Private Sub Editar() Implements CRUD.Editar
        _Conexion.esNuevo = False
        nuevoMiembro.ShowDialog()
    End Sub
    Public Sub Guardar() Implements CRUD.Guardar
        Dim fila As DataRow
        Dim cmd As String

        If _Conexion.esNuevo Then
            '1. Crear una nueva fila 
            fila = _Conexion.GymcatDataSet.Tables(Tabla).NewRow
            '2. Rellenar la fila con información
            fila("nombre") = nuevoMiembro.tbNombre.Text
            fila("apellido") = nuevoMiembro.tbApellido.Text
            fila("DNI") = nuevoMiembro.tbDNI.Text
            fila("edad") = nuevoMiembro.tbEdad.Text
            fila("fecha_inscripcion") = nuevoMiembro.tbFechaIns.Text
            fila("duracion_membresia") = nuevoMiembro.tbDuraMem.Text
            fila("costo_total") = nuevoMiembro.tbCostoTotal.Text
            fila("deudor") = nuevoMiembro.cbDeudor.Checked
            fila("telefono") = nuevoMiembro.tbTelef.Text
            fila("correo") = nuevoMiembro.tbCorreo.Text
            fila("puntos") = nuevoMiembro.tbPuntos.Text

            '3. Agregar fila a la tabla del DataSet
            _Conexion.GymcatDataSet.Tables(Tabla).Rows.Add(fila)

            '4. Crear Comando para agregar a la BD la fila nueva cmd
            cmd = "INSERT INTO miembros (DNI, nombre, apellido, edad, fecha_inscripcion, duracion_membresia, costo_total, deudor, telefono, correo, puntos) VALUES (@dni, @nom, @ape, @edad, @fec, @dur, @cos, @deu, @tel, @cor, @pun)"
            _Conexion.TablaDataAdapter.InsertCommand = New MySqlCommand(cmd, _Conexion.miConexion)
            _Conexion.TablaDataAdapter.InsertCommand.Parameters.Add("@dni", MySqlDbType.Int32, 10, "DNI")
            _Conexion.TablaDataAdapter.InsertCommand.Parameters.Add("@nom", MySqlDbType.VarChar, 45, "nombre")
            _Conexion.TablaDataAdapter.InsertCommand.Parameters.Add("@ape", MySqlDbType.VarChar, 45, "apellido")
            _Conexion.TablaDataAdapter.InsertCommand.Parameters.Add("@edad", MySqlDbType.Int32, 5, "edad")
            _Conexion.TablaDataAdapter.InsertCommand.Parameters.Add("@fec", MySqlDbType.Date, 0, "fecha_inscripcion")
            _Conexion.TablaDataAdapter.InsertCommand.Parameters.Add("@dur", MySqlDbType.VarChar, 20, "duracion_membresia")
            _Conexion.TablaDataAdapter.InsertCommand.Parameters.Add("@cos", MySqlDbType.Int32, 20, "costo_total")
            _Conexion.TablaDataAdapter.InsertCommand.Parameters.Add("@deu", MySqlDbType.Int32, 10, "deudor")
            _Conexion.TablaDataAdapter.InsertCommand.Parameters.Add("@tel", MySqlDbType.VarChar, 40, "telefono")
            _Conexion.TablaDataAdapter.InsertCommand.Parameters.Add("@cor", MySqlDbType.VarChar, 50, "correo")
            _Conexion.TablaDataAdapter.InsertCommand.Parameters.Add("@pun", MySqlDbType.Int32, 50, "puntos")

            '5. Guardar los cambios en la base de datos
            _Conexion.TablaDataAdapter.Update(_Conexion.GymcatDataSet.Tables(Tabla))

            '6. Volver a cargar la tabla del dataset para obtener los ultimos cambios de la BD
            _Conexion.GymcatDataSet.Tables(Tabla).Clear()
            _Conexion.TablaDataAdapter.Fill(_Conexion.GymcatDataSet.Tables(Tabla))
        Else
            '1 seleccionar fila editar
            fila = _Conexion.GymcatDataSet.Tables(Tabla).Rows.Find(_Conexion.idFila)

            '2. Rellenar la fila con información
            fila("nombre") = nuevoMiembro.tbNombre.Text
            fila("apellido") = nuevoMiembro.tbApellido.Text
            fila("DNI") = nuevoMiembro.tbDNI.Text
            fila("edad") = nuevoMiembro.tbEdad.Text
            fila("fecha_inscripcion") = nuevoMiembro.tbFechaIns.Text
            fila("duracion_membresia") = nuevoMiembro.tbDuraMem.Text
            fila("costo_total") = nuevoMiembro.tbCostoTotal.Text
            fila("deudor") = nuevoMiembro.cbDeudor.Checked
            fila("telefono") = nuevoMiembro.tbTelef.Text
            fila("correo") = nuevoMiembro.tbCorreo.Text
            fila("puntos") = nuevoMiembro.tbPuntos.Text

            '3. Crear el comando para modificar la Fila
            cmd = "UPDATE miembros 
                   SET nombre=@nom, apellido=@ape, edad=@edad, fecha_inscripcion=@fec, duracion_membresia=@dur, costo_total=@cos, deudor=@deu, telefono=@tel, correo=@cor, puntos=@pun
                   WHERE DNI=@dni"
            _Conexion.TablaDataAdapter.UpdateCommand = New MySqlCommand(cmd, _Conexion.miConexion)
            _Conexion.TablaDataAdapter.UpdateCommand.Parameters.Add("@nom", MySqlDbType.VarChar, 45, "nombre")
            _Conexion.TablaDataAdapter.UpdateCommand.Parameters.Add("@ape", MySqlDbType.VarChar, 45, "apellido")
            _Conexion.TablaDataAdapter.UpdateCommand.Parameters.Add("@edad", MySqlDbType.Int32, 5, "edad")
            _Conexion.TablaDataAdapter.UpdateCommand.Parameters.Add("@fec", MySqlDbType.Date, 0, "fecha_inscripcion")
            _Conexion.TablaDataAdapter.UpdateCommand.Parameters.Add("@dur", MySqlDbType.VarChar, 20, "duracion_membresia")
            _Conexion.TablaDataAdapter.UpdateCommand.Parameters.Add("@cos", MySqlDbType.Int32, 20, "costo_total")
            _Conexion.TablaDataAdapter.UpdateCommand.Parameters.Add("@deu", MySqlDbType.Int32, 10, "deudor")
            _Conexion.TablaDataAdapter.UpdateCommand.Parameters.Add("@tel", MySqlDbType.VarChar, 40, "telefono")
            _Conexion.TablaDataAdapter.UpdateCommand.Parameters.Add("@cor", MySqlDbType.VarChar, 50, "correo")
            _Conexion.TablaDataAdapter.UpdateCommand.Parameters.Add("@pun", MySqlDbType.Int32, 50, "puntos")
            _Conexion.TablaDataAdapter.UpdateCommand.Parameters.Add("@dni", MySqlDbType.Int32, 10, "DNI")

            '4. Guardar los cambios en la base de datos
            _Conexion.TablaDataAdapter.Update(_Conexion.GymcatDataSet.Tables(Tabla))
        End If
    End Sub

    Private Sub Borrar() Implements CRUD.Borrar
        Dim fila = dgvListadoMiembros.CurrentRow
        _Conexion.idFila = fila.Cells(0).Value
        If MessageBox.Show("¿Está seguro de eliminar este Miembro?", "Borrar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) = DialogResult.Yes Then
            _Conexion.GymcatDataSet.Tables(Tabla).Rows.Find(_Conexion.idFila).Delete()
            _Conexion.TablaDataAdapter.DeleteCommand = New MySqlCommand("DELETE FROM miembros WHERE DNI = @dni", _Conexion.miConexion)
            _Conexion.TablaDataAdapter.DeleteCommand.Parameters.Add("@dni", SqlDbType.BigInt, 0, "DNI")
            _Conexion.TablaDataAdapter.Update(_Conexion.GymcatDataSet.Tables(Tabla))
        End If
    End Sub

    Private Sub Buscar() Implements CRUD.Buscar
        ' Obtén el valor seleccionado en el ComboBox
        Dim columnaSeleccionada = cbBuscar.SelectedItem.ToString

        Select Case columnaSeleccionada
            Case "Nombre"
                _Conexion.vistaDatos.RowFilter = "nombre LIKE '" + tbBuscar.Text + "%'"
            Case "Apellido"
                _Conexion.vistaDatos.RowFilter = "apellido LIKE '" + tbBuscar.Text + "%'"
            Case "DNI"
                _Conexion.vistaDatos.RowFilter = String.Format("CONVERT({0}, System.String) like '%{1}%'", "DNI", tbBuscar.Text)
            Case "Edad"
                _Conexion.vistaDatos.RowFilter = String.Format("CONVERT({0}, System.String) like '%{1}%'", "edad", tbBuscar.Text)
            Case "Telefono"
                _Conexion.vistaDatos.RowFilter = String.Format("CONVERT({0}, System.String) like '%{1}%'", "telefono", tbBuscar.Text)
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
    Private Sub tbBuscar_TextChanged(sender As Object, e As EventArgs)
        Buscar()
    End Sub

End Class
