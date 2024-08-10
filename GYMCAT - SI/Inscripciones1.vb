Imports MySql.Data.MySqlClient

Public Class Inscripciones1
    Private miConexion As MySqlConnection
    Private IncripcionesDataAdapter As MySqlDataAdapter
    Private GymcatDataSet As DataSet
    Private vistaDatos1 As DataView
    Private vistaDatos2 As DataView
    Private vistaDatos3 As DataView
    Public esNuevo As Boolean
    Public idFila As Integer
    Public numero As Integer
    Public nombre As String

    'Public Fila As DataGridViewRow
    Private Sub Inscripciones2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        miConexion = New MySqlConnection()
        miConexion.ConnectionString = "Server=localhost; Database=gymcat; Uid=root; Pwd=;"
        IncripcionesDataAdapter = New MySqlDataAdapter()

        IncripcionesDataAdapter.SelectCommand = New MySqlCommand("SELECT ID_miembro, nombre, apellido, DNI FROM miembros", miConexion)
        GymcatDataSet = New DataSet()
        GymcatDataSet.Tables.Add("TMiembros")
        IncripcionesDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey  'para kos errores del id
        IncripcionesDataAdapter.Fill(GymcatDataSet.Tables("TMiembros"))
        vistaDatos1 = GymcatDataSet.Tables("TMiembros").DefaultView

        dgvListadoMiembros.DataSource = vistaDatos1
        dgvListadoMiembros.Columns(0).Visible = False
        dgvListadoMiembros.CurrentCell = dgvListadoMiembros.Rows(0).Cells(1)

        IncripcionesDataAdapter.SelectCommand = New MySqlCommand("SELECT * FROM miembros_cursos", miConexion)
        GymcatDataSet.Tables.Add("TInscripciones")
        IncripcionesDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey  'para kos errores del id
        IncripcionesDataAdapter.Fill(GymcatDataSet.Tables("TInscripciones"))
        vistaDatos2 = GymcatDataSet.Tables("TInscripciones").DefaultView

        miConexion.Open()
        Dim cmd As String = "SELECT * FROM cursos"
        IncripcionesDataAdapter.SelectCommand = New MySqlCommand(cmd, miConexion)
        Dim Reader As MySqlDataReader = IncripcionesDataAdapter.SelectCommand.ExecuteReader()

        While Reader.Read()
            cbOpciones1.Items.Add(Reader("nombre").ToString())
        End While
        miConexion.Close()




    End Sub

    Private Sub cbOpciones_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbOpciones1.SelectionChangeCommitted

        miConexion.Open()
        Dim cmd = "SELECT * FROM cursos where nombre='" + cbOpciones1.SelectedItem.ToString + "'"
        Dim comando As New MySqlCommand(cmd, miConexion)
        Dim lector = comando.ExecuteReader
        lector.Read()


        'While Reader.Read()
        '    cbOpciones.Items.Add(Reader("nombre").ToString())
        'End While

        lbCursos.Text = lector("nombre")
        lbHorariosCurso.Text = lector("horario")
        lbPrecioCurso.Text = lector("precio")
        lbIncritosCurso.Text = lector("cantidad_inscriptos")
        lbDiasCurso.Text = lector("dias_clase")
        lbProfesorCurso.Text = lector("FK_empleados")

        miConexion.Close()
    End Sub

    Private Sub tbBuscar_TextChanged(sender As Object, e As EventArgs) Handles tbBuscar.TextChanged
        ' Obtén el valor seleccionado en el ComboBox
        Dim columnaSeleccionada As String = cbOpciones2.SelectedItem.ToString()

        Select Case columnaSeleccionada
            Case "Nombre"
                vistaDatos1.RowFilter = "nombre LIKE '" + tbBuscar.Text + "%'"
                'vistaDatos.RowFilter = columnaSeleccionada + " LIKE '" + tbBuscar.Text + "%'"
            Case "Apellido"
                vistaDatos1.RowFilter = "apellido LIKE '" + tbBuscar.Text + "%'"
            Case "DNI"
                vistaDatos1.RowFilter = String.Format("CONVERT({0}, System.String) like '%{1}%'", "DNI", tbBuscar.Text)
        End Select

    End Sub

    Private Sub btnCursosMiembro_Click(sender As Object, e As EventArgs) Handles btnCursosMiembro.Click
        Dim fila As DataGridViewRow = dgvListadoMiembros.CurrentRow
        numero = fila.Cells(0).Value
        nombre = fila.Cells(1).Value
        Inscripciones2.ShowDialog()

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim fila As DataRow
        Dim fila2 As DataGridViewRow = dgvListadoMiembros.CurrentRow
        'fila = dgvListadoMiembros.CurrentRow
        Dim cmd As String
        If (MessageBox.Show("¿Quiere agregar el miembro a este Curso?", "Agregar Miembro", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) = DialogResult.Yes) Then

            miConexion.Open()
            cmd = "SELECT * FROM cursos where nombre='" + cbOpciones1.SelectedItem.ToString + "'"
            Dim comando As New MySqlCommand(cmd, miConexion)
            Dim lector = comando.ExecuteReader
            lector.Read()


            '1. Crear una nueva fila 
            fila = GymcatDataSet.Tables("TInscripciones").NewRow
            '2. Rellenar la fila con información
            fila("FK_miembros") = fila2.Cells(0).Value
            fila("FK_cursos") = lector("ID_cursos")
            fila("Fecha_Inscripcion") = Today

            miConexion.Close()

            '3. Agregar fila a la tabla del DataSet
            GymcatDataSet.Tables("TInscripciones").Rows.Add(fila)

            '4. Crear Comando para agregar a la BD la fila nueva cmd
            cmd = "INSERT INTO miembros_cursos (FK_miembros, FK_cursos, Fecha_Inscripcion) VALUES (@miem, @cur, @fe)"
            IncripcionesDataAdapter.InsertCommand = New MySqlCommand(cmd, miConexion)
            IncripcionesDataAdapter.InsertCommand.Parameters.Add("@miem", MySqlDbType.Int32, 11, "FK_miembros")
            IncripcionesDataAdapter.InsertCommand.Parameters.Add("@cur", MySqlDbType.Int32, 11, "FK_cursos")
            IncripcionesDataAdapter.InsertCommand.Parameters.Add("@fe", MySqlDbType.Date, 10, "Fecha_Inscripcion")

            '5. Guardar los cambios en la base de datos
            IncripcionesDataAdapter.Update(GymcatDataSet.Tables("TInscripciones"))

            '6. V1olver a cargar la tabla del dataset para obtener los ultimos cambios de la BD
            GymcatDataSet.Tables("TInscripciones").Clear()
            'IncripcionesDataAdapter.Fill(GymcatDataSet.Tables("TInscripciones"))
        End If
    End Sub
End Class