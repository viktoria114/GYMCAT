﻿Imports MySql.Data.MySqlClient

Public Class MDIPrincipal
    Private miConexion As MySqlConnection


    Sub hidesubmenu()
        PanelEmpleados.Visible = False
        PanelMembresias.Visible = False
    End Sub


    Sub colorearBoton(botonSeleccionado As Button)
        ' Recorre todos los controles de forma recursiva
        ResetearColores(Me)

        ' Cambia el color del botón principal seleccionado a rosa
        botonSeleccionado.BackColor = Color.FromArgb(239, 41, 84)
    End Sub

    ' Método recursivo para resetear los colores de los botones
    Sub ResetearColores(contenedor As Control)
        ' Recorre todos los controles dentro del contenedor
        For Each ctrl As Control In contenedor.Controls
            ' Si el control es un botón, restablece su color
            If TypeOf ctrl Is Button Then
                ctrl.BackColor = Color.FromArgb(35, 32, 39) ' Color original gris
            End If

            ' Si el control contiene otros controles (como un Panel), llamamos a la función recursiva
            If ctrl.HasChildren Then
                ResetearColores(ctrl)
            End If
        Next
    End Sub



    'Sub colorearboton(boton As Button)
    '	btnEmpleados.BackColor = Color.FromArgb(35, 32, 39)
    '	btnCursos.BackColor = Color.FromArgb(35, 32, 39)
    '	btnMembresias.BackColor = Color.FromArgb(35, 32, 39)
    '	btnFinanzas.BackColor = Color.FromArgb(35, 32, 39)
    '	btnInventario.BackColor = Color.FromArgb(35, 32, 39)
    '	BtnHorario.BackColor = Color.FromArgb(35, 32, 39)
    '	btnInscripciones.BackColor = Color.FromArgb(35, 32, 39)
    '	BtnIngresos.BackColor = Color.FromArgb(35, 32, 39)
    '	btnEgresos.BackColor = Color.FromArgb(35, 32, 39)
    '	boton.BackColor = Color.FromArgb(239, 84, 41)
    'End Sub

    Sub abrirform(formulario As Form)
        formulario.MdiParent = Me
        formulario.FormBorderStyle = FormBorderStyle.None
        formulario.Dock = DockStyle.Fill
        formulario.Show()
    End Sub


    Sub mostrar_submenu(submenu As Panel)
        If submenu.Visible = False Then
            submenu.Visible = True
        Else
            submenu.Visible = False
        End If
    End Sub

    Sub Openform(formhijo As Form)
        formhijo.MdiParent = Me
        formhijo.FormBorderStyle = FormBorderStyle.None
        formhijo.Dock = DockStyle.Fill
        formhijo.Show()
    End Sub

#Region "CONTROL DE BOTONES"

    Private Sub btnEmpleados_Click(sender As Object, e As EventArgs) Handles btnEmpleados.Click
        mostrar_submenu(PanelEmpleados)
        Panel4.Visible = False
        colorearBoton(btnEmpleados)
        FormEmpleados.BringToFront()
    End Sub

    Private Sub brnMembresias_Click(sender As Object, e As EventArgs) Handles btnMembresias.Click
        mostrar_submenu(PanelMembresias)
        Panel4.Visible = False
        colorearBoton(btnMembresias)
        CrudMiembros.BringToFront()
    End Sub

    Private Sub btnCursos_Click(sender As Object, e As EventArgs) Handles btnCursos.Click
        Panel4.Visible = False
        colorearBoton(btnCursos)
        FormCursos.BringToFront()
    End Sub

    Private Sub btnFinanzas_Click(sender As Object, e As EventArgs) Handles btnFinanzas.Click
        Panel4.Visible = False
        colorearBoton(btnFinanzas)
        FormFinanzas.BringToFront()

    End Sub

    Private Sub btnInscripciones_Click(sender As Object, e As EventArgs) Handles btnInscripciones.Click
        Panel4.Visible = False
        colorearBoton(btnInscripciones)
        FormInscripciones.BringToFront()
        FormInscripciones.CargarDatosForm()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles BtnHorario.Click
        Panel4.Visible = False
        colorearBoton(BtnHorario)
        Horarios.BringToFront()
    End Sub

    Private Sub btnInventario_Click(sender As Object, e As EventArgs) Handles btnInventario.Click
        Panel4.Visible = False
        colorearBoton(btnInventario)
        CrudElementos1.BringToFront()
    End Sub

    Private Sub btnConsultas_Click(sender As Object, e As EventArgs) Handles btnConsultas.Click
        Panel4.Visible = False
        colorearBoton(btnConsultas)
        FormConsultas.BringToFront()
        FormConsultas.CargarDatosForm()
    End Sub


    Private Sub MDIPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Login.Close()
    End Sub

#End Region

    Private Sub MDIPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        hidesubmenu()

        abrirform(FormEmpleados)
        abrirform(FormCursos)
        abrirform(CrudMiembros)
        abrirform(Horarios)
        abrirform(FormInscripciones)
        abrirform(CrudElementos1)
        abrirform(FormConsultas)
        abrirform(FormFinanzas)

        CargarUsuario()

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Login.Show()
        Hide()

    End Sub

    Sub CargarUsuario()
        Dim NombreCompleto As String
        Dim cargo As String
        Dim turno As String
        Dim NivelAcceso As Integer

        miConexion = New MySqlConnection("Server=localhost; Database=gymcat; Uid=root; Pwd=;")
        miConexion.Open()
        Dim consulta = "SELECT * FROM empleados, login where ID_empleados = FK_empleado and usuario = @usuario"
        Dim comando As New MySqlCommand(consulta, miConexion)
        comando.Parameters.AddWithValue("@usuario", Login.tbUsuario.Text)
        Dim lector = comando.ExecuteReader
        lector.Read()
        NombreCompleto = lector("nombre") & " " & lector("apellido")
        cargo = lector("cargo")
        turno = lector("turno")
        NivelAcceso = lector("nivel_acceso")

        Labelbienvenido.Text = "Bienvendo " & NombreCompleto & "!"

        Labelinfo.Text = "Información: " & vbCrLf & "Cargo: " & cargo & "              Turno: " & turno

        If NivelAcceso = 2 Then
            btnFinanzas.Hide()
        End If

        If NivelAcceso = 1 Then
            btnFinanzas.Hide()
            btnInventario.Hide()
            btnCursos.Hide()
            btnEmpleados.Hide()

        End If


    End Sub


End Class

