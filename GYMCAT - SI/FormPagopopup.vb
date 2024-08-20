Imports System.Reflection.Metadata
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Relational


Imports iText.Kernel.Pdf
Imports iText.Layout
Imports iText.Layout.Element
Imports iText.Layout.Properties
Imports iText.Kernel.Font
Imports iText.IO.Image
Imports iText.Kernel.Colors
Imports iText.IO.Font.Constants


Public Class FormPagopopup

	Private _Conexion As Conexion
	'Private lector As MySqlDataReader
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

		_Conexion = New Conexion()
		_Conexion.miConexion.Open()
		Dim comando As New MySqlCommand("SELECT * FROM ingresos order by ID_ingresos DESC", _Conexion.miConexion)

		Dim lector = comando.ExecuteReader
		lector.Read()
		Dim IDMovActual As Int32 = lector("ID_ingresos") + 1
		lbTitulo.Text = "Couta de Miembro, ID " + IDMovActual.ToString
		lector.Close()
		miConexion.Close()

		dtpFechaMov.Text = Today

		cbMiembros.Items.Clear()
		MiembrosActualizar()





		' If ListaInscripciones IsNot Nothing AndAlso ListaInscripciones.Count > 0 Then
		' For Each item In ListaInscripciones
		' MsgBox(item.Cells(0).Value.ToString())
		' lbInscripciones.Text += vbCrLf + " - " + item.Cells(0).Value.ToString()
		' Next
		' Else
		' MsgBox("La lista de inscripciones está vacía o es nula.")
		' End If
	End Sub

	Private Sub btnPagar_Click(sender As Object, e As EventArgs) Handles btnPagar.Click

	End Sub

	Sub MiembrosActualizar()
		miConexion.Open()
		_Conexion.TablaDataAdapter = New MySqlDataAdapter()
		_Conexion.TablaDataAdapter.SelectCommand = New MySqlCommand("SELECT ID_miembro,CONCAT(nombre,' ',apellido,' - ',DNI) AS 'nmiembro',edad,fecha_inscripcion,duracion_membresia FROM miembros", miConexion)

		_Conexion.GymcatDataSet = New DataSet()
		_Conexion.GymcatDataSet.Tables.Add("TMiembros")
		_Conexion.TablaDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey
		_Conexion.TablaDataAdapter.Fill(_Conexion.GymcatDataSet.Tables("TMiembros"))

		cbMiembros.DataSource = _Conexion.GymcatDataSet.Tables("TMiembros").DefaultView
		cbMiembros.DisplayMember = "nmiembro"
		cbMiembros.ValueMember = "ID_miembro"


	End Sub

	Private Sub cbMiembros_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMiembros.SelectedIndexChanged
		tbIDUltimoPago.Text = ""
		dtpUltimoPago.Text = ""
		cbDeudor.Checked = False
		dtpVencimiento.Text = ""

		If miConexion.State = ConnectionState.Closed Then
			miConexion.Open()
		End If

		Dim consulta = "SELECT *, DATE_ADD(m.fecha_inscripcion, INTERVAL m.duracion_membresia MONTH) AS 'fecha_vencimiento'
		FROM miembros_mes_ingresos mi, miembros m, ingresos i WHERE m.ID_miembro = mi.FK_miembros
		AND i.ID_ingresos = mi.FK_ingresos AND m.ID_miembro = @ID AND i.fecha_pago = (SELECT MAX(i2.fecha_pago) FROM ingresos i2 
		JOIN miembros_mes_ingresos mi2 ON i2.ID_ingresos = mi2.FK_ingresos WHERE mi2.FK_miembros = m.ID_miembro);"

		Dim comando As New MySqlCommand(consulta, miConexion)
		comando.Parameters.AddWithValue("@ID", cbMiembros.SelectedValue)

		Dim lector = comando.ExecuteReader()

		While lector.Read()

			If lector.HasRows Then
				Dim a As Integer = lector("ID_ingresos")
				MsgBox(a)
				If lector("ID_ingresos").ToString = "" Then
					tbIDUltimoPago.Text = "No esixten pagos anteriores"
				Else
					tbIDUltimoPago.Text = lector("ID_ingresos")
				End If

				dtpUltimoPago.Text = lector("fecha_pago")
				cbDeudor.Checked = Convert.ToBoolean(lector("deudor"))
				dtpVencimiento.Text = lector("fecha_vencimiento")
			Else
				MsgBox("No se encontraron datos.")
			End If
		End While
		lector.Close()
		miConexion.Close()
	End Sub

	Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
		Dim pdfWriter As New PdfWriter("C:\Users\Usuario\Desktop\GYMCAT_Factura.pdf")
		Dim pdfDoc As New PdfDocument(pdfWriter)
		Dim document As New Document(pdfDoc)

		' Agregar una fuente estándar
		Dim font As PdfFont = PdfFontFactory.CreateFont(StandardFonts.HELVETICA)

		' Agregar el título
		Dim titulo As New Paragraph("FACTURA DE PAGO - GYMCAT")
		titulo.SetFont(font).SetFontSize(20).SetTextAlignment(TextAlignment.CENTER)
		document.Add(titulo)

		Dim linea As LineSeparator = New LineSeparator(New SolidLine())
		document.Add(linea)

		' Agregar el logo del gimnasio
		Dim imagen As New Image(ImageDataFactory.Create("C:\Users\Usuario\Desktop\logo-gymcat.png"))
		imagen.ScaleAbsolute(200, 51)
		imagen.SetFixedPosition(40, 695)
		document.Add(imagen)

		' Información del gimnasio
		Dim infoGym As New Paragraph("GYMCAT S.A." & vbCrLf & "Dirección: Calle Falsa 123" & vbCrLf & "Teléfono: (123) 4567890")
		infoGym.SetFont(font).SetFontSize(12).SetMarginTop(20).SetMarginLeft(235)
		document.Add(infoGym)

		' Información del cliente/miembro
		Dim cliente As New Paragraph("Miembro: " & tbApellidoNombre.Text & vbCrLf & "DNI: " & tbDNI.Text & vbCrLf & "Correo: " & tbCorreo.Text)
		cliente.SetFont(font).SetFontSize(12).SetMarginTop(20)
		document.Add(cliente)

		' Fecha y forma de pago
		Dim pagoInfo As New Paragraph("Fecha: " & dtpFechaMov.Text & vbCrLf & "Forma de pago: " & cbFormaPago.Text)
		pagoInfo.SetFont(font).SetFontSize(12).SetMarginTop(20)
		document.Add(pagoInfo)

		' Tabla de detalles de los cursos
		Dim table As New Table(3) ' Columnas: Curso, Costo, Descripción
		table.SetWidth(UnitValue.CreatePercentValue(100))

		' Agregar las cabeceras de columna
		table.AddHeaderCell(New Cell().SetBackgroundColor(ColorConstants.LIGHT_GRAY).Add(New Paragraph("Curso").SetTextAlignment(TextAlignment.CENTER).SetBold()))
		table.AddHeaderCell(New Cell().SetBackgroundColor(ColorConstants.LIGHT_GRAY).Add(New Paragraph("Costo").SetTextAlignment(TextAlignment.CENTER).SetBold()))
		table.AddHeaderCell(New Cell().SetBackgroundColor(ColorConstants.LIGHT_GRAY).Add(New Paragraph("Descripción").SetTextAlignment(TextAlignment.CENTER).SetBold()))

		' Agregar las filas de datos
		For Each row As DataGridViewRow In ListaInscripciones
			table.AddCell(New Cell().Add(New Paragraph(row.Cells("NombreCurso").Value.ToString()).SetTextAlignment(TextAlignment.CENTER)))
			table.AddCell(New Cell().Add(New Paragraph(Convert.ToDecimal(row.Cells("Costo").Value).ToString("C")).SetTextAlignment(TextAlignment.CENTER)))
			table.AddCell(New Cell().Add(New Paragraph(row.Cells("Descripcion").Value.ToString()).SetTextAlignment(TextAlignment.CENTER)))
		Next

		document.Add(table)

		' Agregar el total
		Dim total As Decimal = ListaInscripciones.Sum(Function(r) Convert.ToDecimal(r.Cells("Costo").Value))
		Dim ptotal As New Paragraph("Total: " & total.ToString("C"))
		ptotal.SetFont(font).SetFontSize(15).SetFontColor(ColorConstants.RED).SetTextAlignment(TextAlignment.RIGHT).SetMarginTop(20)
		document.Add(ptotal)

		document.Close()
	End Sub


	'Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
	'	Dim pdfWriter As New PdfWriter("C:\Users\Usuario\Desktop\demo.pdf")
	'	Dim pdfDoc As New PdfDocument(pdfWriter)
	'	Dim document As New Document(pdfDoc)

	'	' Agregar una fuente estándar
	'	Dim font As PdfFont = PdfFontFactory.CreateFont(StandardFonts.HELVETICA)

	'	' Agregar el título
	'	Dim titulo As New Paragraph("FACTURA")
	'	titulo.SetFont(font).SetFontSize(20).SetTextAlignment(TextAlignment.CENTER)
	'	document.Add(titulo)

	'	Dim linea As LineSeparator = New LineSeparator(New SolidLine())
	'	document.Add(linea)

	'	Dim imagen As New Image(ImageDataFactory.Create("C:\Users\Usuario\Desktop\logo-unlar-small.png"))
	'	imagen.ScaleAbsolute(200, 51)
	'	imagen.SetFixedPosition(40, 695)
	'	document.Add(imagen)

	'	' Información del vendedor
	'	Dim vendedor As New Paragraph("Programación II S.A." & vbCrLf & "Luis M. de la Fuente" & vbCrLf & "Teléfono: (380) 4457000")
	'	vendedor.SetFont(font).SetFontSize(12).SetMarginTop(20).SetMarginLeft(235)
	'	document.Add(vendedor)

	'	' Información del cliente
	'	Dim cliente As New Paragraph("Cliente: " & tbApellidoNombre.Text & "        DNI: " & tbDNI.Text)
	'	cliente.SetFont(font).SetFontSize(12).SetMarginTop(20)
	'	document.Add(cliente)

	'	Dim table As New Table(tablaDetalle.Columns.Count - 2)
	'	table.SetWidth(UnitValue.CreatePercentValue(100))

	'	' Agregar las cabeceras de columna
	'	For i As Integer = 2 To tablaDetalle.Columns.Count - 1
	'		table.AddHeaderCell(New Cell().SetBackgroundColor(ColorConstants.LIGHT_GRAY).Add(New Paragraph(tablaDetalle.Columns(i).ColumnName).SetTextAlignment(TextAlignment.CENTER).SetBold()))
	'	Next

	'	' Agregar las filas de datos
	'	For Each row As DataRow In tablaDetalle.Rows
	'		For i As Integer = 2 To tablaDetalle.Columns.Count - 1
	'			table.AddCell(New Cell().Add(New Paragraph(row(i).ToString()).SetTextAlignment(TextAlignment.CENTER)))
	'		Next
	'	Next

	'	document.Add(table)

	'	' Agregar el total
	'	Dim ptotal As New Paragraph("Total: " & total.ToString("C"))
	'	ptotal.SetFont(font).SetFontSize(15).SetFontColor(ColorConstants.RED).SetTextAlignment(TextAlignment.RIGHT).SetMarginTop(20)
	'	document.Add(ptotal)

	'	document.Close()
	'End Sub

End Class