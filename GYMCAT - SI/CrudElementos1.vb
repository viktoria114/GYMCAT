Imports MySql.Data.MySqlClient

Public Class CrudElementos1
    Private miConexion As MySqlConnection
    Private ElementosDataAdapter As MySqlDataAdapter
    Private GymcatDataSet As DataSet
    Private vistaDatos As DataView
    Public esNuevo As Boolean
    Public idFila As Integer
    Private Sub CrudElementos1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        miConexion = New MySqlConnection()
        miConexion.ConnectionString = "Server=localhost; Database=gymcat; Uid=root; Pwd=;"
        ElementosDataAdapter = New MySqlDataAdapter()
        ElementosDataAdapter.SelectCommand = New MySqlCommand("SELECT * FROM `elementos deportivos`", miConexion)
        GymcatDataSet = New DataSet()
        GymcatDataSet.Tables.Add("TElementos")

        ElementosDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey  'para kos errores del id

        ElementosDataAdapter.Fill(GymcatDataSet.Tables("TElementos"))


        vistaDatos = GymcatDataSet.Tables("TElementos").DefaultView

        dgvListadoElementos.DataSource = vistaDatos
        dgvListadoElementos.Columns(0).Visible = False
        dgvListadoElementos.Columns(5).Width = 115
        dgvListadoElementos.Columns(9).Width = 200
        dgvListadoElementos.CurrentCell = dgvListadoElementos.Rows(0).Cells(1)
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        esNuevo = True
        CrudElementos2.ShowDialog()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        esNuevo = False
        CrudElementos2.ShowDialog()
    End Sub

    Public Sub btnGuardar_Click()
        Dim fila As DataRow
        Dim cmd As String

        If esNuevo Then
            '1. Crear una nueva fila 
            fila = GymcatDataSet.Tables("TElementos").NewRow
            '2. Rellenar la fila con información
            fila("nombre") = CrudElementos2.tbNombreElemento.Text
            fila("modelo") = CrudElementos2.tbModeloElemento.Text
            fila("precio") = CrudElementos2.tbPrecioElemento.Text
            fila("tipo") = CrudElementos2.tbTipoElemento.Text
            fila("fecha_compra") = CrudElementos2.tbFechaCompraElemento.Text
            fila("stock") = CrudElementos2.tbStockElemeto.Text
            fila("marca") = CrudElementos2.tbMarcaElemento.Text
            fila("estado") = CrudElementos2.cbEstadoElemento.Text
            fila("detalle") = CrudElementos2.tbDetalleElemento.Text

            '3. Agregar fila a la tabla del DataSet
            GymcatDataSet.Tables("TElementos").Rows.Add(fila)

            '4. Crear Comando para agregar a la BD la fila nueva cmd
            cmd = "INSERT INTO `elementos deportivos` (nombre, modelo, precio, tipo, fecha_compra, stock, marca, estado, detalle) VALUES (@nom, @mod, @pre, @tipo, @fe, @sto, @mar, @est, @det)"
            ElementosDataAdapter.InsertCommand = New MySqlCommand(cmd, miConexion)
            ElementosDataAdapter.InsertCommand.Parameters.Add("@nom", MySqlDbType.VarChar, 50, "nombre")
            ElementosDataAdapter.InsertCommand.Parameters.Add("@mod", MySqlDbType.VarChar, 50, "modelo")
            ElementosDataAdapter.InsertCommand.Parameters.Add("@pre", MySqlDbType.Int32, 20, "precio")
            ElementosDataAdapter.InsertCommand.Parameters.Add("@tipo", MySqlDbType.VarChar, 20, "tipo")
            ElementosDataAdapter.InsertCommand.Parameters.Add("@fe", MySqlDbType.Date, 10, "fecha_compra")
            ElementosDataAdapter.InsertCommand.Parameters.Add("@sto", MySqlDbType.Int32, 20, "stock")
            ElementosDataAdapter.InsertCommand.Parameters.Add("@mar", MySqlDbType.VarChar, 20, "marca")
            ElementosDataAdapter.InsertCommand.Parameters.Add("@est", MySqlDbType.VarChar, 20, "estado")
            ElementosDataAdapter.InsertCommand.Parameters.Add("@det", MySqlDbType.VarChar, 50, "detalle")

            '5. Guardar los cambios en la base de datos
            ElementosDataAdapter.Update(GymcatDataSet.Tables("TElementos"))

            '6. V1olver a cargar la tabla del dataset para obtener los ultimos cambios de la BD
            GymcatDataSet.Tables("TElementos").Clear()
            ElementosDataAdapter.Fill(GymcatDataSet.Tables("TElementos"))
        Else
            '1 seleccionar fila editar
            fila = GymcatDataSet.Tables("TElementos").Rows.Find(idFila)

            '2. Rellenar la fila con información
            fila("nombre") = CrudElementos2.tbNombreElemento.Text
            fila("modelo") = CrudElementos2.tbModeloElemento.Text
            fila("precio") = CrudElementos2.tbPrecioElemento.Text
            fila("tipo") = CrudElementos2.tbTipoElemento.Text
            fila("fecha_compra") = CrudElementos2.tbFechaCompraElemento.Text
            fila("stock") = CrudElementos2.tbStockElemeto.Text
            fila("marca") = CrudElementos2.tbMarcaElemento.Text
            fila("estado") = CrudElementos2.cbEstadoElemento.Text
            fila("detalle") = CrudElementos2.tbDetalleElemento.Text

            '3. Crear el comando para odificar la Fila
            cmd = "UPDATE `elementos deportivos` 
                   SET nombre=@nom, modelo=@mod, precio=@pre, precio=@pre, tipo=@tipo, fecha_compra=@fe, stock=@sto, marca=@mar, estado=@est, detalle=@det
                   WHERE ID_elementos_deportivos=@id"
            ElementosDataAdapter.UpdateCommand = New MySqlCommand(cmd, miConexion)
            ElementosDataAdapter.UpdateCommand.Parameters.Add("@nom", MySqlDbType.VarChar, 50, "nombre") 'NO OLVIDAR EL UPDATECOMMAND
            ElementosDataAdapter.UpdateCommand.Parameters.Add("@mod", MySqlDbType.VarChar, 50, "modelo")
            ElementosDataAdapter.UpdateCommand.Parameters.Add("@pre", MySqlDbType.Int32, 20, "precio")
            ElementosDataAdapter.UpdateCommand.Parameters.Add("@tipo", MySqlDbType.VarChar, 20, "tipo")
            ElementosDataAdapter.UpdateCommand.Parameters.Add("@fe", MySqlDbType.Date, 10, "fecha_compra")
            ElementosDataAdapter.UpdateCommand.Parameters.Add("@sto", MySqlDbType.Int32, 20, "stock")
            ElementosDataAdapter.UpdateCommand.Parameters.Add("@mar", MySqlDbType.VarChar, 20, "marca")
            ElementosDataAdapter.UpdateCommand.Parameters.Add("@est", MySqlDbType.VarChar, 20, "estado")
            ElementosDataAdapter.UpdateCommand.Parameters.Add("@det", MySqlDbType.VarChar, 50, "detalle")
            ElementosDataAdapter.UpdateCommand.Parameters.Add("@id", MySqlDbType.Int32, 0, "ID_elementos_deportivos")

            '4. Guardar los cambios en la base de datos
            ElementosDataAdapter.Update(GymcatDataSet.Tables("TElementos"))
        End If

    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Dim fila As DataGridViewRow = dgvListadoElementos.CurrentRow
        idFila = fila.Cells(0).Value
        If (MessageBox.Show("¿Está seguro de eliminar este Elemento?", "Borrar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) = DialogResult.Yes) Then
            GymcatDataSet.Tables("TElementos").Rows.Find(idFila).Delete()
            ElementosDataAdapter.DeleteCommand = New MySqlCommand("DELETE FROM `elementos deportivos` WHERE ID_elementos_deportivos = @id", miConexion)
            ElementosDataAdapter.DeleteCommand.Parameters.Add("@id", SqlDbType.BigInt, 0, "ID_elementos_deportivos")
            ElementosDataAdapter.Update(GymcatDataSet.Tables("TElementos"))
        End If
    End Sub

    Private Sub tbBuscar_TextChanged(sender As Object, e As EventArgs) Handles tbBuscar.TextChanged
        ' Obtén el valor seleccionado en el ComboBox
        Dim columnaSeleccionada As String = cbOpciones.SelectedItem.ToString()

        Select Case columnaSeleccionada
            Case "Nombre"
                vistaDatos.RowFilter = "nombre LIKE '" + tbBuscar.Text + "%'"
                'vistaDatos.RowFilter = columnaSeleccionada + " LIKE '" + tbBuscar.Text + "%'"
            Case "Modelo"
                vistaDatos.RowFilter = "modelo LIKE '" + tbBuscar.Text + "%'"
            Case "Tipo"
                vistaDatos.RowFilter = "tipo LIKE '" + tbBuscar.Text + "%'"
            Case "Marca"
                vistaDatos.RowFilter = "marca LIKE '" + tbBuscar.Text + "%'"
            Case "Estado"
                vistaDatos.RowFilter = "estado LIKE '" + tbBuscar.Text + "%'"
            Case "Precio"
                vistaDatos.RowFilter = String.Format("CONVERT({0}, System.String) like '%{1}%'", "precio", tbBuscar.Text)
            Case "Stock"
                vistaDatos.RowFilter = String.Format("CONVERT({0}, System.String) like '%{1}%'", "stock", tbBuscar.Text)
            Case "Fecha de Compra"
                vistaDatos.RowFilter = String.Format("CONVERT({0}, System.String) like '%{1}%'", "fecha_compra", tbBuscar.Text)
        End Select

    End Sub
End Class