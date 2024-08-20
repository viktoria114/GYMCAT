Public Class Curso_Pago
	Public Property ID_Curso As Integer
	Public Property Nombre As String
	Public Property Precio As Integer
	Public Property Meses As Integer

	Public Sub New(id As Integer, nom As String, pre As Integer, mes As Integer)
		ID_Curso = id
		Nombre = nom
		Precio = pre
		Meses = mes
	End Sub


End Class
