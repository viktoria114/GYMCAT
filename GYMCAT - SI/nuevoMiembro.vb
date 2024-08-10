Public Class nuevoMiembro
    Private Sub nuevoMiembro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If CrudMiembros.esNuevo Then
            Me.Text = ("Nuevo Miembro")
            tbNombre.Text = ""
            tbApellido.Text = ""
            tbDNI.Text = ""
            tbEdad.Text = ""
            tbFechaIns.Text = ""
            tbDuraMem.Text = ""
            tbCurIns.Text = ""
            tbCostoTotal.Text = ""
            tbDeudor.Text = ""
            tbTelef.Text = ""
            tbCorreo.Text = ""
            tbPuntos.Text = ""
        Else
            Dim fila As DataGridViewRow = CrudMiembros.dgvListadoMiembros.CurrentRow
            Me.Text = ("Editar Miembro")
            CrudMiembros.idFila = fila.Cells(0).Value
            tbNombre.Text = fila.Cells(1).Value
            tbApellido.Text = fila.Cells(2).Value
            tbDNI.Text = fila.Cells(3).Value
            tbEdad.Text = fila.Cells(4).Value
            tbFechaIns.Text = fila.Cells(5).Value
            tbDuraMem.Text = fila.Cells(6).Value
            tbCurIns.Text = fila.Cells(7).Value
            tbCostoTotal.Text = fila.Cells(8).Value
            tbDeudor.Text = fila.Cells(9).Value
            tbTelef.Text = fila.Cells(10).Value
            tbCorreo.Text = fila.Cells(11).Value
            tbPuntos.Text = fila.Cells(12).Value
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        CrudMiembros.Guardar()
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class

