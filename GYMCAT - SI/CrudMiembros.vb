Imports MySql.Data.MySqlClient

Public Class CrudMiembros
    Implements CRUD
    Private miConexion As MySqlConnection
    Private miembrosDataAdapter As MySqlDataAdapter
    Private gymcatDataSet As DataSet
    Private vistaDatos As DataView
    Public esNuevo As Boolean
    Public idFila As Integer

    Private Sub CrudMiembros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        miConexion = New MySqlConnection()
        miConexion.ConnectionString = "Server=localhost;database=gymcat;user id=root;password=; port=3306;"
        miembrosDataAdapter = New MySqlDataAdapter()
        miembrosDataAdapter.SelectCommand = New MySqlCommand("SELECT * FROM miembros", miConexion)
        gymcatDataSet = New DataSet()
        gymcatDataSet.Tables.Add("TMiembros")

        miembrosDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey  'para los errores del id

        miembrosDataAdapter.Fill(gymcatDataSet.Tables("TMiembros"))

        vistaDatos = gymcatDataSet.Tables("TMiembros").DefaultView

        dgvListadoMiembros.DataSource = vistaDatos
        dgvListadoMiembros.Columns(0).Visible = False
        dgvListadoMiembros.Columns(4).Width = 115
        dgvListadoMiembros.CurrentCell = dgvListadoMiembros.Rows(0).Cells(1)
    End Sub


    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
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

    Private Sub Agregar() Implements CRUD.Agregar
        esNuevo = True
        nuevoMiembro.ShowDialog()
    End Sub

    Private Sub Editar() Implements CRUD.Editar
        esNuevo = False
        nuevoMiembro.ShowDialog()
    End Sub
    Public Sub Guardar() Implements CRUD.Guardar
        Dim fila As DataRow
        Dim cmd As String

        If esNuevo Then
            '1. Crear una nueva fila 
            fila = gymcatDataSet.Tables("TMiembros").NewRow
            '2. Rellenar la fila con información
            fila("nombre") = nuevoMiembro.tbNombre.Text
            fila("apellido") = nuevoMiembro.tbApellido.Text
            fila("DNI") = nuevoMiembro.tbDNI.Text
            fila("edad") = nuevoMiembro.tbEdad.Text
            fila("fecha_inscripcion") = nuevoMiembro.tbFechaIns.Text
            fila("duracion_membresia") = nuevoMiembro.tbDuraMem.Text
            fila("cursos_inscritos") = nuevoMiembro.tbCurIns.Text
            fila("costo_total") = nuevoMiembro.tbCostoTotal.Text
            fila("deudor") = nuevoMiembro.tbDeudor.Text
            fila("telefono") = nuevoMiembro.tbTelef.Text
            fila("correo") = nuevoMiembro.tbCorreo.Text
            fila("puntos") = nuevoMiembro.tbPuntos.Text

            '3. Agregar fila a la tabla del DataSet
            gymcatDataSet.Tables("TMiembros").Rows.Add(fila)

            '4. Crear Comando para agregar a la BD la fila nueva cmd
            cmd = "INSERT INTO miembros (DNI, nombre, apellido, edad, fecha_inscripcion, duracion_membresia, cursos_inscritos, costo_total, deudor, telefono, correo, puntos) VALUES (@dni, @nom, @ape, @edad, @fec, @dur, @cur, @cos, @deu, @tel, @cor, @pun)"
            miembrosDataAdapter.InsertCommand = New MySqlCommand(cmd, miConexion)
            miembrosDataAdapter.InsertCommand.Parameters.Add("@dni", MySqlDbType.Int32, 10, "DNI")
            miembrosDataAdapter.InsertCommand.Parameters.Add("@nom", MySqlDbType.VarChar, 45, "nombre")
            miembrosDataAdapter.InsertCommand.Parameters.Add("@ape", MySqlDbType.VarChar, 45, "apellido")
            miembrosDataAdapter.InsertCommand.Parameters.Add("@edad", MySqlDbType.Int32, 5, "edad")
            miembrosDataAdapter.InsertCommand.Parameters.Add("@fec", MySqlDbType.Date, 0, "fecha_inscripcion")
            miembrosDataAdapter.InsertCommand.Parameters.Add("@dur", MySqlDbType.VarChar, 20, "duracion_membresia")
            miembrosDataAdapter.InsertCommand.Parameters.Add("@cur", MySqlDbType.Int32, 5, "cursos_inscritos")
            miembrosDataAdapter.InsertCommand.Parameters.Add("@cos", MySqlDbType.Int32, 20, "costo_total")
            miembrosDataAdapter.InsertCommand.Parameters.Add("@deu", MySqlDbType.Int32, 10, "deudor")
            miembrosDataAdapter.InsertCommand.Parameters.Add("@tel", MySqlDbType.VarChar, 40, "telefono")
            miembrosDataAdapter.InsertCommand.Parameters.Add("@cor", MySqlDbType.VarChar, 50, "correo")
            miembrosDataAdapter.InsertCommand.Parameters.Add("@pun", MySqlDbType.Int32, 50, "puntos")

            '5. Guardar los cambios en la base de datos
            miembrosDataAdapter.Update(gymcatDataSet.Tables("TMiembros"))

            '6. Volver a cargar la tabla del dataset para obtener los ultimos cambios de la BD
            gymcatDataSet.Tables("TMiembros").Clear()
            miembrosDataAdapter.Fill(gymcatDataSet.Tables("TMiembros"))
        Else
            '1 seleccionar fila editar
            fila = gymcatDataSet.Tables("TMiembros").Rows.Find(idFila)

            '2. Rellenar la fila con información
            fila("nombre") = nuevoMiembro.tbNombre.Text
            fila("apellido") = nuevoMiembro.tbApellido.Text
            fila("DNI") = nuevoMiembro.tbDNI.Text
            fila("edad") = nuevoMiembro.tbEdad.Text
            fila("fecha_inscripcion") = nuevoMiembro.tbFechaIns.Text
            fila("duracion_membresia") = nuevoMiembro.tbDuraMem.Text
            fila("cursos_inscritos") = nuevoMiembro.tbCurIns.Text
            fila("costo_total") = nuevoMiembro.tbCostoTotal.Text
            fila("deudor") = nuevoMiembro.tbDeudor.Text
            fila("telefono") = nuevoMiembro.tbTelef.Text
            fila("correo") = nuevoMiembro.tbCorreo.Text
            fila("puntos") = nuevoMiembro.tbPuntos.Text

            '3. Crear el comando para modificar la Fila
            cmd = "UPDATE miembros 
                   SET nombre=@nom, apellido=@ape, edad=@edad, fecha_inscripcion=@fec, duracion_membresia=@dur, cursos_inscritos=@cur, costo_total=@cos, deudor=@deu, telefono=@tel, correo=@cor, puntos=@pun
                   WHERE DNI=@dni"
            miembrosDataAdapter.UpdateCommand = New MySqlCommand(cmd, miConexion)
            miembrosDataAdapter.UpdateCommand.Parameters.Add("@nom", MySqlDbType.VarChar, 45, "nombre")
            miembrosDataAdapter.UpdateCommand.Parameters.Add("@ape", MySqlDbType.VarChar, 45, "apellido")
            miembrosDataAdapter.UpdateCommand.Parameters.Add("@edad", MySqlDbType.Int32, 5, "edad")
            miembrosDataAdapter.UpdateCommand.Parameters.Add("@fec", MySqlDbType.Date, 0, "fecha_inscripcion")
            miembrosDataAdapter.UpdateCommand.Parameters.Add("@dur", MySqlDbType.VarChar, 20, "duracion_membresia")
            miembrosDataAdapter.UpdateCommand.Parameters.Add("@cur", MySqlDbType.Int32, 5, "cursos_inscritos")
            miembrosDataAdapter.UpdateCommand.Parameters.Add("@cos", MySqlDbType.Int32, 20, "costo_total")
            miembrosDataAdapter.UpdateCommand.Parameters.Add("@deu", MySqlDbType.Int32, 10, "deudor")
            miembrosDataAdapter.UpdateCommand.Parameters.Add("@tel", MySqlDbType.VarChar, 40, "telefono")
            miembrosDataAdapter.UpdateCommand.Parameters.Add("@cor", MySqlDbType.VarChar, 50, "correo")
            miembrosDataAdapter.UpdateCommand.Parameters.Add("@pun", MySqlDbType.Int32, 50, "puntos")
            miembrosDataAdapter.UpdateCommand.Parameters.Add("@dni", MySqlDbType.Int32, 10, "DNI")

            '4. Guardar los cambios en la base de datos
            miembrosDataAdapter.Update(gymcatDataSet.Tables("TMiembros"))
        End If
    End Sub

    Private Sub Borrar() Implements CRUD.Borrar
        Dim fila = dgvListadoMiembros.CurrentRow
        idFila = fila.Cells(0).Value
        If MessageBox.Show("¿Está seguro de eliminar este Miembro?", "Borrar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) = DialogResult.Yes Then
            gymcatDataSet.Tables("TMiembros").Rows.Find(idFila).Delete()
            miembrosDataAdapter.DeleteCommand = New MySqlCommand("DELETE FROM miembros WHERE DNI = @dni", miConexion)
            miembrosDataAdapter.DeleteCommand.Parameters.Add("@dni", SqlDbType.BigInt, 0, "DNI")
            miembrosDataAdapter.Update(gymcatDataSet.Tables("TMiembros"))
        End If
    End Sub

    Private Sub Buscar() Implements CRUD.Buscar
        ' Obtén el valor seleccionado en el ComboBox
        Dim columnaSeleccionada = cbBuscar.SelectedItem.ToString

        Select Case columnaSeleccionada
            Case "Nombre"
                vistaDatos.RowFilter = "nombre LIKE '" + tbBuscar.Text + "%'"
            Case "Apellido"
                vistaDatos.RowFilter = "apellido LIKE '" + tbBuscar.Text + "%'"
            Case "DNI"
                vistaDatos.RowFilter = String.Format("CONVERT({0}, System.String) like '%{1}%'", "DNI", tbBuscar.Text)
            Case "Edad"
                vistaDatos.RowFilter = String.Format("CONVERT({0}, System.String) like '%{1}%'", "edad", tbBuscar.Text)
            Case "Telefono"
                vistaDatos.RowFilter = String.Format("CONVERT({0}, System.String) like '%{1}%'", "telefono", tbBuscar.Text)
            Case "Correo"
                vistaDatos.RowFilter = "correo LIKE '" + tbBuscar.Text + "%'"
        End Select
    End Sub
End Class
