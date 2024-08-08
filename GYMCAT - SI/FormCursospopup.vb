﻿Public Class FormCursospopup
    Public esnuevo2 As Boolean
    Private Sub FormCursospopup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        esnuevo2 = FormCursos.esNuevo
        MsgBox(FormCursos.esNuevo)
        If FormCursos.esNuevo Then
            tbNombreCurso.Text = ""
            tbHorarioCurso.Text = ""
            tbPrecioCurso.Text = ""
            tbInscriptosCursos.Text = ""
            tbDiasCurso.Text = ""
            tbIdTurno.Text = ""
        Else
            Dim fila As DataGridViewRow = FormCursos.dgvListadoCursos.CurrentRow
            FormCursos.idFila = fila.Cells(0).Value
            tbNombreCurso.Text = fila.Cells(1).Value
            tbHorarioCurso.Text = fila.Cells(2).Value
            tbPrecioCurso.Text = fila.Cells(3).Value
            tbInscriptosCursos.Text = fila.Cells(4).Value
            tbDiasCurso.Text = fila.Cells(5).Value
            tbIdProfesor.Text = fila.Cells(6).Value
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        FormCursos.btnGuardar_Click()
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class