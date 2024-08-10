Public Class Formempleados2
    Private Sub Formempleados2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If FormEmpleados.esNuevo Then
            tbNombre.Text = ""
            tbApellido.Text = ""
            tbDNI.Text = ""
            tbFechaNac.Text = ""
            tbCargo.Text = ""
            tbTurno.Text = ""
            tbSueldo.Text = ""
            tbCorreo.Text = ""
            tbTelefono.Text = ""

        Else
            Dim fila As DataGridViewRow = FormEmpleados.dgvListadoEmpleados.CurrentRow
            FormEmpleados.idFila = fila.Cells(0).Value
            tbNombre.Text = fila.Cells(1).Value
            tbApellido.Text = fila.Cells(2).Value
            tbDNI.Text = fila.Cells(3).Value
            tbFechaNac = fila.Cells(4).Value
            tbSueldo = fila.Cells(5).Value
            tbTurno = fila.Cells(6).Value
            tbCargo = fila.Cells(7).Value
            tbTelefono = fila.Cells(8).Value
            tbCorreo = fila.Cells(9).Value
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        FormEmpleados.Guardar()
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

End Class