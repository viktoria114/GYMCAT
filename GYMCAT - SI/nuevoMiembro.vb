Public Class nuevoMiembro
    Private Sub nuevoMiembro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If CrudMiembros._Conexion.esNuevo Then
            Me.Text = ("Nuevo Miembro")
            tbNombre.Text = ""
            tbApellido.Text = ""
            tbDNI.Text = ""
            tbEdad.Text = ""
            dtpInscripcion.Text = Today
            cbDuracMemb.Text = ""
            tbCostoTotal.Text = "15000"
            tbTelef.Text = ""
            tbCorreo.Text = ""
            tbPuntos.Text = "0"
        Else
            Dim fila As DataGridViewRow = CrudMiembros.dgvListadoMiembros.CurrentRow
            Me.Text = ("Editar Miembro")
            CrudMiembros._Conexion.idFila = fila.Cells(0).Value
            tbNombre.Text = fila.Cells(2).Value
            tbApellido.Text = fila.Cells(3).Value
            tbDNI.Text = fila.Cells(1).Value
            tbEdad.Text = fila.Cells(4).Value
            dtpInscripcion.Text = fila.Cells(5).Value
            cbDuracMemb.Text = fila.Cells(6).Value
            tbCostoTotal.Text = fila.Cells(7).Value
            cbDeudor.Checked = fila.Cells(8).Value
            tbTelef.Text = fila.Cells(9).Value
            tbCorreo.Text = fila.Cells(10).Value
            tbPuntos.Text = fila.Cells(11).Value
        End If

        AddHandler cbDuracMemb.SelectedIndexChanged, AddressOf CalcularCostoTotal
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        CrudMiembros.Guardar()
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub CalcularCostoTotal(sender As Object, e As EventArgs) Handles cbDuracMemb.SelectedIndexChanged
        Dim duracion As Integer
        Dim costoPorMes = 15000

        ' Convierte la duración seleccionada a un número entero
        If Integer.TryParse(cbDuracMemb.Text, duracion) Then
            ' Calcula el costo total
            tbCostoTotal.Text = (duracion * costoPorMes).ToString
        End If
    End Sub
End Class

