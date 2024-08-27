Imports MySql.Data.MySqlClient
Public Class Login
    Private miConexion As MySqlConnection
    Public nivelAcceso As Integer

    Public Sub CerrarMDI(mdi As MDIPrincipal)
        mdi.Close()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        miConexion = New MySqlConnection("Server=localhost; Database=gymcat; Uid=root; Pwd=;")

    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click

        Try
            miConexion.Open()

            Dim consulta = "SELECT * FROM login WHERE usuario = @usuario AND contraseña = @contraseña"
            Dim comando As New MySqlCommand(consulta, miConexion)
            comando.Parameters.AddWithValue("@usuario", tbUsuario.Text)
            comando.Parameters.AddWithValue("@contraseña", tbContraseña.Text)
            Dim lector = comando.ExecuteReader

            If lector.HasRows Then
                lector.Read()
                nivelAcceso = lector("nivel_acceso")
                MDIPrincipal.Show()
                Hide()

            Else
                MsgBox("Usuario o contraseña incorrectos!")

            End If


            MDIPrincipal.CargarUsuario()

        Catch ex As MySqlException
            MsgBox("La conexión con la Base de Datos fallo")
        Catch ex As Exception
            MsgBox("Ocurrió un error inesperado")
        Finally
            If miConexion.State = ConnectionState.Open Then
                miConexion.Close()
            End If
        End Try

    End Sub

    Private Sub PictureBoxHIDE_Click(sender As Object, e As EventArgs) Handles PictureBoxHIDE.Click
        tbContraseña.PasswordChar = "*"
        PictureBoxSHOW.BringToFront()
    End Sub

    Private Sub PictureBoxSHOW_Click(sender As Object, e As EventArgs) Handles PictureBoxSHOW.Click
        tbContraseña.PasswordChar = ""
        PictureBoxHIDE.BringToFront()

    End Sub


End Class