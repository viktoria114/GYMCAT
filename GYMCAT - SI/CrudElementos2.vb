Public Class CrudElementos2
    Private Sub CrudElementos2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If CrudElementos1._Conexion.esNuevo Then
            Me.Text = ("Nuevo Elemento")
            tbNombreElemento.Text = ""
            tbModeloElemento.Text = ""
            tbPrecioElemento.Text = ""
            tbTipoElemento.Text = ""
            tbFechaCompraElemento.Text = ""
            tbStockElemeto.Text = ""
            tbMarcaElemento.Text = ""
            cbEstadoElemento.Text = ""
            tbDetalleElemento.Text = ""
        Else
            Dim fila As DataGridViewRow = CrudElementos1.dgvListadoElementos.CurrentRow
            Me.Text = ("Editar Elemento")
            CrudElementos1._Conexion.idFila = fila.Cells(0).Value
            tbNombreElemento.Text = fila.Cells(1).Value
            tbModeloElemento.Text = fila.Cells(2).Value
            tbPrecioElemento.Text = fila.Cells(3).Value
            tbTipoElemento.Text = fila.Cells(4).Value
            tbFechaCompraElemento.Text = fila.Cells(5).Value
            tbStockElemeto.Text = fila.Cells(6).Value
            tbMarcaElemento.Text = fila.Cells(7).Value
            cbEstadoElemento.Text = fila.Cells(8).Value
            tbDetalleElemento.Text = fila.Cells(9).Value
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        CrudElementos1.btnGuardar_Click()
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

End Class