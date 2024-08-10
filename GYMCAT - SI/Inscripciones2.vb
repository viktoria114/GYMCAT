Imports MySql.Data.MySqlClient

Public Class Inscripciones2
    Private miConexion As MySqlConnection
    Private IncripcionesDataAdapter As MySqlDataAdapter
    Private GymcatDataSet As DataSet
    Private vistaDatos As DataView
    Public idFila As Integer
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = "'" + Inscripciones1.nombre + "'"
        miConexion = New MySqlConnection()
        miConexion.ConnectionString = "Server=localhost; Database=gymcat; Uid=root; Pwd=;"
        IncripcionesDataAdapter = New MySqlDataAdapter()

        Dim consulta = "SELECT miembros_cursos.ID_inscripción, cursos.nombre, miembros_cursos.fecha_inscripcion FROM cursos, miembros_cursos, miembros WHERE miembros_cursos.FK_cursos = cursos.ID_cursos and miembros_cursos.FK_miembros =@num"
        Dim comando As New MySqlCommand(consulta, miConexion)
        comando.Parameters.AddWithValue("@num", Inscripciones1.numero)

        IncripcionesDataAdapter.SelectCommand = comando
        'IncripcionesDataAdapter.SelectCommand = New MySqlCommand("SELECT cursos.nombre FROM cursos, miembros_cursos, miembros WHERE miembros_cursos.FK_cursos = cursos.ID_cursos and miembros_cursos.FK_miembros =1", miConexion)
        'IncripcionesDataAdapter.Parameters.AddWithValue("@num", Form1.numero)
        GymcatDataSet = New DataSet()
        GymcatDataSet.Tables.Add("TInscripciones")
        IncripcionesDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey  'para kos errores del id
        IncripcionesDataAdapter.Fill(GymcatDataSet.Tables("TInscripciones"))
        vistaDatos = GymcatDataSet.Tables("TInscripciones").DefaultView

        dgvListadoIncripciones.DataSource = vistaDatos

    End Sub

    Private Sub btnDesincribir_Click(sender As Object, e As EventArgs) Handles btnDesincribir.Click
        Dim fila As DataGridViewRow = dgvListadoIncripciones.CurrentRow
        idFila = fila.Cells(0).Value
        If (MessageBox.Show("¿Está seguro de Desincribir el miembro del Curso?", "Desincribir miembro", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) = DialogResult.Yes) Then
            GymcatDataSet.Tables("TInscripciones").Rows.Find(idFila).Delete()
            IncripcionesDataAdapter.DeleteCommand = New MySqlCommand("DELETE FROM `miembros_cursos` WHERE ID_inscripción = @id", miConexion)
            IncripcionesDataAdapter.DeleteCommand.Parameters.Add("@id", SqlDbType.BigInt, 0, "ID_inscripción")
            IncripcionesDataAdapter.Update(GymcatDataSet.Tables("TInscripciones"))
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

End Class