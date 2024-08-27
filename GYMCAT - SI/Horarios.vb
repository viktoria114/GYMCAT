Imports MySql.Data.MySqlClient

Public Class Horarios
    Public miConexion As MySqlConnection
    Public NombreCompleto As String
    Public empleadosLista As String
    Public CursoLista As String
    Public CursoCompleto As String

    Private Sub Horarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = "Hoy es " + Format(Now, "dddd, dd") + " de " + Format(Now, "MMMM") + "!"
        EmpleadosHoy()
        CursosHoy()
    End Sub

    Private Sub MonthCalendar1_DateSelected(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateSelected
        Label2.Text = "Es " + Format(MonthCalendar1.SelectionRange.Start, "dddd, dd") + " de " + Format(MonthCalendar1.SelectionRange.Start, "MMMM") + "!"
        CursosHoy()
    End Sub

    Private Sub TabControl1_Selecting(sender As Object, e As TabControlCancelEventArgs) Handles Cajita.Selecting

        EmpleadosHoy()
        CursosHoy()

    End Sub

    Sub EmpleadosHoy()
        miConexion = New MySqlConnection("Server=localhost; Database=gymcat; Uid=root; Pwd=;")
        miConexion.Open()
        Dim consulta = "SELECT * FROM empleados WHERE turno = @turno"
        Dim comando As New MySqlCommand(consulta, miConexion)

        comando.Parameters.AddWithValue("@turno", Cajita.SelectedTab.Text)

        Dim lector = comando.ExecuteReader

        empleadosLista = "Empleados:" + vbCrLf

        If lector.HasRows Then
            While lector.Read()
                NombreCompleto = lector("nombre") + " " + lector("apellido") + ", " + lector("cargo")
                empleadosLista &= NombreCompleto + vbCrLf
            End While

        Else
            empleadosLista = "No hay empleados para este turno"
        End If

        empleados1.Text = empleadosLista
        Label3.Text = empleadosLista
        Label4.Text = empleadosLista


        lector.Close()
        miConexion.Close()
    End Sub

    Sub CursosHoy()
        miConexion = New MySqlConnection("Server=localhost; Database=gymcat; Uid=root; Pwd=;")
        miConexion.Open()
        Dim consulta = "SELECT * FROM cursos WHERE dias_clase LIKE '%" + Format(MonthCalendar1.SelectionRange.Start, "dddd") + "%' and turno = @turno"

        Dim comando As New MySqlCommand(consulta, miConexion)
        comando.Parameters.AddWithValue("@turno", Cajita.SelectedTab.Text)

        Dim lector = comando.ExecuteReader

        CursoLista = "Cursos:" + vbCrLf

        If lector.HasRows Then
            While lector.Read()
                CursoCompleto = lector("nombre") + ", " + lector("horario")
                CursoLista &= CursoCompleto + vbCrLf
            End While

        Else
            CursoLista = "No hay cursos para este turno"
        End If

        LabelCursoMañana.Text = CursoLista
        LabelCursosTarde.Text = CursoLista
        LabelCursosNoche.Text = CursoLista

        lector.Close()
        miConexion.Close()
    End Sub

End Class