Public Class FormPagopopup

	Private Modo As String
	Private ListaInscripciones As List(Of DataGridViewRow)

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
		'	If ListaInscripciones IsNot Nothing AndAlso ListaInscripciones.Count > 0 Then
		'		For Each item In ListaInscripciones
		'			MsgBox(item.Cells(0).Value.ToString())
		'			lbInscripciones.Text += vbCrLf + "    - " + item.Cells(0).Value.ToString()
		'		Next
		'	Else
		'		MsgBox("La lista de inscripciones está vacía o es nula.")
		'	End If
	End Sub


End Class