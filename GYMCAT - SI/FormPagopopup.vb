Imports MySql.Data.MySqlClient

Public Class FormPagopopup

    Private Modo As String
    Private ListaInscripciones As List(Of DataGridViewRow)
    Private miConexion As New MySqlConnection("Server=localhost; Database=gymcat; Uid=root; Pwd=;")

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Public Sub New(Lista As List(Of DataGridViewRow))
        InitializeComponent()
        ListaInscripciones = Lista
        Modo = "Inscipcion"
    End Sub


    Private Sub FormPagopopup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        miConexion.Open()
        Dim consulta = "SELECT * FROM ingresos order by ID_ingresos DESC"
        Dim comando As New MySqlCommand(consulta, miConexion)
        Dim lector = comando.ExecuteReader
        lector.Read()
        Dim IDMovActual As Int32 = lector("ID_ingresos") + 1
        lbTitulo.Text = "Couta de Miembro, ID " + Convert.ToString(IDMovActual)
        miConexion.Close()

        dtpFechaMov.Text = Today

        cbMiembros.Items.Clear()
        MiembrosActualizar()



        '	If ListaInscripciones IsNot Nothing AndAlso ListaInscripciones.Count > 0 Then
        '		For Each item In ListaInscripciones
        '			MsgBox(item.Cells(0).Value.ToString())
        '			lbInscripciones.Text += vbCrLf + "    - " + item.Cells(0).Value.ToString()
        '		Next
        '	Else
        '		MsgBox("La lista de inscripciones está vacía o es nula.")
        '	End If
    End Sub

    Private Sub btnPagar_Click(sender As Object, e As EventArgs) Handles btnPagar.Click

    End Sub

    Sub MiembrosActualizar()
        miConexion.Open()
        Dim consulta = "SELECT * FROM miembros"
        Dim comando As New MySqlCommand(consulta, miConexion)
        Dim lector = comando.ExecuteReader
        Dim Miembros1 As String

        If lector.HasRows Then
            While lector.Read()
                Miembros1 = lector("nombre") + " " + lector("apellido") + ", " + Convert.ToString(lector("DNI"))
                cbMiembros.Items.Add(Miembros1)
            End While
        End If

    End Sub


End Class