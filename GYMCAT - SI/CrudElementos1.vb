﻿Imports MySql.Data.MySqlClient

Public Class CrudElementos1
    Implements CRUD
    Public _Conexion As Conexion
    Public Tabla As String

    Private Sub CrudElementos1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim consulta As String = "SELECT * FROM `elementos deportivos`"
        Tabla = "TElementos"

        _Conexion = New Conexion(consulta, Tabla)

        dgvListadoElementos.DataSource = _Conexion.vistaDatos
        dgvListadoElementos.Columns(0).Visible = False
        dgvListadoElementos.Columns(5).Width = 115
        dgvListadoElementos.Columns(9).Width = 200
        dgvListadoElementos.CurrentCell = dgvListadoElementos.Rows(0).Cells(1)
    End Sub

    Public Sub Agregar() Implements CRUD.Agregar
        _Conexion.esNuevo = True
        CrudElementos2.ShowDialog()
    End Sub

    Public Sub Editar() Implements CRUD.Editar
        _Conexion.esNuevo = False
        CrudElementos2.ShowDialog()
    End Sub

    Public Sub Guardar() Implements CRUD.Guardar
        Dim fila As DataRow
        Dim cmd As String

        If _Conexion.esNuevo Then
            '1. Crear una nueva fila 
            fila = _Conexion.GymcatDataSet.Tables(Tabla).NewRow
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
            _Conexion.GymcatDataSet.Tables(Tabla).Rows.Add(fila)

            '4. Crear Comando para agregar a la BD la fila nueva cmd
            cmd = "INSERT INTO `elementos deportivos` (nombre, modelo, precio, tipo, fecha_compra, stock, marca, estado, detalle) VALUES (@nom, @mod, @pre, @tipo, @fe, @sto, @mar, @est, @det)"
            _Conexion.XDataAdapter.InsertCommand = New MySqlCommand(cmd, _Conexion.miConexion)
            _Conexion.XDataAdapter.InsertCommand.Parameters.Add("@nom", MySqlDbType.VarChar, 50, "nombre")
            _Conexion.XDataAdapter.InsertCommand.Parameters.Add("@mod", MySqlDbType.VarChar, 50, "modelo")
            _Conexion.XDataAdapter.InsertCommand.Parameters.Add("@pre", MySqlDbType.Int32, 20, "precio")
            _Conexion.XDataAdapter.InsertCommand.Parameters.Add("@tipo", MySqlDbType.VarChar, 20, "tipo")
            _Conexion.XDataAdapter.InsertCommand.Parameters.Add("@fe", MySqlDbType.Date, 10, "fecha_compra")
            _Conexion.XDataAdapter.InsertCommand.Parameters.Add("@sto", MySqlDbType.Int32, 20, "stock")
            _Conexion.XDataAdapter.InsertCommand.Parameters.Add("@mar", MySqlDbType.VarChar, 20, "marca")
            _Conexion.XDataAdapter.InsertCommand.Parameters.Add("@est", MySqlDbType.VarChar, 20, "estado")
            _Conexion.XDataAdapter.InsertCommand.Parameters.Add("@det", MySqlDbType.VarChar, 50, "detalle")

            '5. Guardar los cambios en la base de datos
            _Conexion.XDataAdapter.Update(_Conexion.GymcatDataSet.Tables(Tabla))

            '6. V1olver a cargar la tabla del dataset para obtener los ultimos cambios de la BD
            _Conexion.GymcatDataSet.Tables(Tabla).Clear()
            _Conexion.XDataAdapter.Fill(_Conexion.GymcatDataSet.Tables(Tabla))
        Else
            '1 seleccionar fila editar
            fila = _Conexion.GymcatDataSet.Tables(Tabla).Rows.Find(_Conexion.idFila)

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
            _Conexion.XDataAdapter.UpdateCommand = New MySqlCommand(cmd, _Conexion.miConexion)
            _Conexion.XDataAdapter.UpdateCommand.Parameters.Add("@nom", MySqlDbType.VarChar, 50, "nombre") 'NO OLVIDAR EL UPDATECOMMAND
            _Conexion.XDataAdapter.UpdateCommand.Parameters.Add("@mod", MySqlDbType.VarChar, 50, "modelo")
            _Conexion.XDataAdapter.UpdateCommand.Parameters.Add("@pre", MySqlDbType.Int32, 20, "precio")
            _Conexion.XDataAdapter.UpdateCommand.Parameters.Add("@tipo", MySqlDbType.VarChar, 20, "tipo")
            _Conexion.XDataAdapter.UpdateCommand.Parameters.Add("@fe", MySqlDbType.Date, 10, "fecha_compra")
            _Conexion.XDataAdapter.UpdateCommand.Parameters.Add("@sto", MySqlDbType.Int32, 20, "stock")
            _Conexion.XDataAdapter.UpdateCommand.Parameters.Add("@mar", MySqlDbType.VarChar, 20, "marca")
            _Conexion.XDataAdapter.UpdateCommand.Parameters.Add("@est", MySqlDbType.VarChar, 20, "estado")
            _Conexion.XDataAdapter.UpdateCommand.Parameters.Add("@det", MySqlDbType.VarChar, 50, "detalle")
            _Conexion.XDataAdapter.UpdateCommand.Parameters.Add("@id", MySqlDbType.Int32, 0, "ID_elementos_deportivos")

            '4. Guardar los cambios en la base de datos
            _Conexion.XDataAdapter.Update(_Conexion.GymcatDataSet.Tables(Tabla))
        End If
    End Sub

    Public Sub Borrar() Implements CRUD.Borrar
        Dim fila As DataGridViewRow = dgvListadoElementos.CurrentRow
        _Conexion.idFila = fila.Cells(0).Value
        If (MessageBox.Show("¿Está seguro de eliminar este Elemento?", "Borrar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) = DialogResult.Yes) Then
            _Conexion.GymcatDataSet.Tables(Tabla).Rows.Find(_Conexion.idFila).Delete()
            _Conexion.XDataAdapter.DeleteCommand = New MySqlCommand("DELETE FROM `elementos deportivos` WHERE ID_elementos_deportivos = @id", _Conexion.miConexion)
            _Conexion.XDataAdapter.DeleteCommand.Parameters.Add("@id", SqlDbType.BigInt, 0, "ID_elementos_deportivos")
            _Conexion.XDataAdapter.Update(_Conexion.GymcatDataSet.Tables(Tabla))
        End If
    End Sub

    Public Sub Buscar() Implements CRUD.Buscar
        ' Obtén el valor seleccionado en el ComboBox
        Dim columnaSeleccionada As String = cbOpciones.SelectedItem.ToString()

        Select Case columnaSeleccionada
            Case "Nombre"
                _Conexion.vistaDatos.RowFilter = "nombre LIKE '" + tbBuscar.Text + "%'"
                'vistaDatos.RowFilter = columnaSeleccionada + " LIKE '" + tbBuscar.Text + "%'"
            Case "Modelo"
                _Conexion.vistaDatos.RowFilter = "modelo LIKE '" + tbBuscar.Text + "%'"
            Case "Tipo"
                _Conexion.vistaDatos.RowFilter = "tipo LIKE '" + tbBuscar.Text + "%'"
            Case "Marca"
                _Conexion.vistaDatos.RowFilter = "marca LIKE '" + tbBuscar.Text + "%'"
            Case "Estado"
                _Conexion.vistaDatos.RowFilter = "estado LIKE '" + tbBuscar.Text + "%'"
            Case "Precio"
                _Conexion.vistaDatos.RowFilter = String.Format("CONVERT({0}, System.String) like '%{1}%'", "precio", tbBuscar.Text)
            Case "Stock"
                _Conexion.vistaDatos.RowFilter = String.Format("CONVERT({0}, System.String) like '%{1}%'", "stock", tbBuscar.Text)
            Case "Fecha de Compra"
                _Conexion.vistaDatos.RowFilter = String.Format("CONVERT({0}, System.String) like '%{1}%'", "fecha_compra", tbBuscar.Text)
        End Select
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Agregar()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Editar()
    End Sub

    Public Sub btnGuardar_Click()
        Guardar()
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Borrar()
    End Sub

    Private Sub tbBuscar_TextChanged(sender As Object, e As EventArgs) Handles tbBuscar.TextChanged
        Buscar()
    End Sub
End Class