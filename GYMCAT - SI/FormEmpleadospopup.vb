Public Class Formempleadospopup
    Private Sub FormempleadosPopup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If FormEmpleados._Conexion.esNuevo Then
            Me.Text = ("Nuevo Empleado")
            tbNombre.Text = ""
            tbApellido.Text = ""
            tbDNI.Text = ""
            dtpNac.Text = ""
            tbCargo.Text = ""
            tbTurno.Text = ""
            tbSueldo.Text = ""
            tbCorreo.Text = ""
            tbTelefono.Text = ""

        Else
            Dim fila As DataGridViewRow = FormEmpleados.dgvListadoEmpleados.CurrentRow
            Me.Text = ("Editar Empleado")
            FormEmpleados._Conexion.idFila = fila.Cells(0).Value
            tbNombre.Text = fila.Cells(1).Value
            tbApellido.Text = fila.Cells(2).Value
            dtpNac.Text = fila.Cells(3).Value
            tbDNI.Text = fila.Cells(7).Value
            tbSueldo.Text = fila.Cells(4).Value
            tbTurno.Text = fila.Cells(5).Value
            tbCargo.Text = fila.Cells(6).Value
            tbTelefono.Text = fila.Cells(8).Value
            tbCorreo.Text = fila.Cells(9).Value
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