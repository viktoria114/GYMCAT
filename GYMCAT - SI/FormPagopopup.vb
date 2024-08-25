﻿Imports System.Reflection.Metadata
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Relational


Imports System.Data.Common
Imports System.Globalization
Imports iText.IO.Font.Constants
Imports iText.IO.Image
Imports iText.Kernel.Colors
Imports iText.Kernel.Font
Imports iText.Kernel.Pdf
Imports iText.Kernel.Pdf.Canvas.Draw
Imports iText.Layout
Imports iText.Layout.Element
Imports iText.Layout.Properties


Public Class FormPagopopup

    Private _Conexion As Conexion
    Private Modo As String
    Private ListaInscripciones As New List(Of Curso_Pago)
    Private miConexion As New MySqlConnection("Server=localhost; Database=gymcat; Uid=root; Pwd=;")
    Private Nombre_Miembro As String
    Private DNI_Miembro As String
    Private Correo_Miembro As String


    Public Sub New(DNI_miembro1 As Integer, modo1 As String)
        InitializeComponent()
        Modo = modo1
        DNI_Miembro = DNI_miembro1
    End Sub

    Public Sub New(Lista As List(Of Curso_Pago))
        InitializeComponent()
        For Each n As Curso_Pago In Lista
            ListaInscripciones.Add(New Curso_Pago(n.ID_Curso, n.Nombre, n.Precio, n.Meses))
        Next
        Modo = "Inscipcion"
    End Sub


    Private Sub FormPagopopup_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        _Conexion = New Conexion()
        _Conexion.miConexion.Open()
        Dim comando As New MySqlCommand("SELECT * FROM ingresos order by ID_ingresos DESC", _Conexion.miConexion)

        Dim lector = comando.ExecuteReader
        lector.Read()
        Dim IDMovActual As Int32 = lector("ID_ingresos") + 1

        Select Case Modo
            Case "Cuota"
                lbTitulo.Text = "Couta de Miembro, ID " + IDMovActual.ToString
                lector.Close()

                Dim comando1 As New MySqlCommand("SELECT * FROM miembros WHERE dni = @dni", _Conexion.miConexion)
                comando1.Parameters.AddWithValue("@dni", DNI_Miembro)

                Dim lector1 = comando1.ExecuteReader
                lector1.Read()

                dtpFechaMov.Text = Today

                cbMiembros.Text = lector1("nombre") + " " + lector1("apellido") + ", " + lector1("DNI").ToString
                cbMiembros.Enabled = False

                Cuota()

                lector.Close()
                lector1.Close()


                'cbMiembros.Items.Clear()

                'miConexion.Open()
                '_Conexion.TablaDataAdapter = New MySqlDataAdapter()
                '_Conexion.TablaDataAdapter.SelectCommand = New MySqlCommand("SELECT ID_miembro,CONCAT(nombre,' ',apellido,' - ',DNI) AS 'Nmiembro',edad,fecha_inscripcion,duracion_membresia FROM miembros", miConexion)

                '_Conexion.GymcatDataSet = New DataSet()
                '_Conexion.GymcatDataSet.Tables.Add("TMiembros")
                '_Conexion.TablaDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey
                '_Conexion.TablaDataAdapter.Fill(_Conexion.GymcatDataSet.Tables("TMiembros"))

                'cbMiembros.DataSource = _Conexion.GymcatDataSet.Tables("TMiembros").DefaultView
                'cbMiembros.DisplayMember = "Nmiembro"
                'cbMiembros.ValueMember = "ID_miembro"

            Case "Inscripcion"

            Case "Membresia"

        End Select


        miConexion.Close()



    End Sub

    Private Sub btnPagar_Click(sender As Object, e As EventArgs) Handles btnPagar.Click
        If cbMeses.Text = "" Then
            MsgBox("Elegir cantidad de meses!")
        Else
            Select Case Modo
                Case "Cuota"




                Case "Inscripcion"

                Case "Membresia"

            End Select
        End If

    End Sub

    'Sub MiembrosActualizar()



    'End Sub

    Private Sub Cuota()
        tbIDUltimoPago.Text = ""
        dtpUltimoPago.Text = ""
        cbDeudor.Checked = False
        dtpVencimiento.Text = ""

        tbIDUltimoPago.Enabled = False
        dtpUltimoPago.Enabled = False
        cbDeudor.Enabled = False
        dtpVencimiento.Enabled = False

        If miConexion.State = ConnectionState.Closed Then
            miConexion.Open()
        End If

        Dim consulta = "SELECT *, DATE_ADD(m.fecha_inscripcion, INTERVAL m.duracion_membresia MONTH) AS 'fecha_vencimiento'
		FROM miembros_mes_ingresos mi, miembros m, ingresos i WHERE m.ID_miembro = mi.FK_miembros
		AND i.ID_ingresos = mi.FK_ingresos AND m.DNI = @DNI AND i.fecha_pago = (SELECT MAX(i2.fecha_pago) FROM ingresos i2 
		JOIN miembros_mes_ingresos mi2 ON i2.ID_ingresos = mi2.FK_ingresos WHERE mi2.FK_miembros = m.ID_miembro);"
        Dim comando As New MySqlCommand(consulta, miConexion)
        comando.Parameters.AddWithValue("@DNI", DNI_Miembro)

        Dim lector = comando.ExecuteReader()

        While lector.Read
            If lector.HasRows Then
                tbIDUltimoPago.Text = lector("ID_ingresos")
                dtpUltimoPago.Text = lector("fecha_pago")
                cbDeudor.Checked = Convert.ToBoolean(lector("deudor"))
                dtpVencimiento.Text = lector("fecha_vencimiento")
                Nombre_Miembro = lector("nombre") + " " + lector("apellido")
                'DNI_Miembro = lector("DNI")
                Correo_Miembro = lector("correo")
            Else
                MsgBox("No se encontraron datos.")
            End If

        End While
        lector.Close()
        miConexion.Close()
    End Sub

    Private Sub cbMeses_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMeses.SelectedIndexChanged
        dgvFactura.Rows.Clear()

        Dim total As Decimal = 0
        Dim precio As Integer = 15000 * cbMeses.Text

        Dim n As Integer = dgvFactura.Rows.Add()
        dgvFactura.Rows(n).Cells(0).Value = "Membresia"
        dgvFactura.Rows(n).Cells(1).Value = precio.ToString
        dgvFactura.Rows(n).Cells(2).Value = "*" + cbMeses.Text + " mes/es"

        cursos()

        miConexion.Open()
        Dim comando As New MySqlCommand("SELECT costo_total FROM miembros
					WHERE miembros.DNI = @dni
                                        ", _Conexion.miConexion)
        comando.Parameters.AddWithValue("@dni", DNI_Miembro)

        Dim lector = comando.ExecuteReader
        lector.Read()

        precio = lector("costo_total") * cbMeses.Text

        dgvFactura.Rows.Add()
        n = dgvFactura.Rows.Add()
        dgvFactura.Rows(n).Cells(0).Value = "Total"
        dgvFactura.Rows(n).Cells(1).Value = precio.ToString
        dgvFactura.Rows(n).Cells(2).Value = "*" + cbMeses.Text + " mes/es"

        lector.Close()
        miConexion.Close()

    End Sub

    Sub cursos()
        miConexion.Open()
        Dim comando As New MySqlCommand("SELECT cursos.nombre, cursos.precio FROM miembros
					INNER JOIN miembros_cursos ON miembros.ID_miembro = miembros_cursos.FK_miembros
                    INNER JOIN cursos ON cursos.ID_cursos = miembros_cursos.FK_cursos
					WHERE miembros.DNI = @dni
                                        ", _Conexion.miConexion)
        comando.Parameters.AddWithValue("@dni", DNI_Miembro)

        Dim lector = comando.ExecuteReader
        Dim precio As Integer

        If lector.HasRows Then

            While lector.Read()
                Dim n As Integer = dgvFactura.Rows.Add()
                dgvFactura.Rows(n).Cells(0).Value = lector("nombre")
                precio = lector("precio") * cbMeses.Text
                dgvFactura.Rows(n).Cells(1).Value = precio.ToString
                dgvFactura.Rows(n).Cells(2).Value = "*" + cbMeses.Text + " mes/es"
            End While
        End If

        lector.Close()
        miConexion.Close()
    End Sub

    'Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
    '	Dim pdfWriter As New PdfWriter("C:\Users\Gaming\Desktop\GYMCAT_Factura.pdf")
    '	Dim pdfDoc As New PdfDocument(pdfWriter)
    '	Dim document As New iText.Layout.Document(pdfDoc)

    '	' Agregar una fuente estándar
    '	Dim font As PdfFont = PdfFontFactory.CreateFont(StandardFonts.HELVETICA)

    '	' Agregar el título
    '	Dim titulo As New Paragraph("FACTURA DE PAGO DE CUOTA - GYMCAT")
    '	titulo.SetFont(font).SetFontSize(20).SetTextAlignment(TextAlignment.CENTER)
    '	document.Add(titulo)

    '	Dim linea As LineSeparator = New LineSeparator(New SolidLine())
    '	document.Add(linea)

    '	' Agregar el logo del gimnasio
    '	Dim imagen As New Image(ImageDataFactory.Create("C:\Users\Gaming\Documents\GitHub\GYMCAT\GYMCAT - SI\Resources\image-removebg-preview (1).png"))
    '	imagen.ScaleAbsolute(66, 70)
    '	imagen.SetFixedPosition(40, 695)
    '	document.Add(imagen)

    '	' Información del gimnasio
    '	Dim infoGym As New Paragraph("GYMCAT S.A." & vbCrLf & "Dirección: Calle Falsa 123" & vbCrLf & "Teléfono: (123) 4567890")
    '	infoGym.SetFont(font).SetFontSize(12).SetMarginTop(16).SetMarginLeft(80)
    '	document.Add(infoGym)

    '	' Fecha y forma de pago
    '	Dim pagoInfo As New Paragraph("Fecha: " & dtpFechaMov.Text & vbCrLf & "Forma de pago: " & cbFormaPago.Text)
    '	pagoInfo.SetFont(font).SetFontSize(12).SetMarginTop(20)
    '	document.Add(pagoInfo)

    '	' Información del cliente/miembro
    '	Dim cliente As New Paragraph("Miembro: " + Nombre_Miembro + vbCrLf + "DNI: " + DNI_Miebro + vbCrLf + "Correo: " + Correo_Miembro)
    '	cliente.SetFont(font).SetFontSize(12).SetMarginTop(20)
    '	document.Add(cliente)

    '	' Tabla de detalles de los cursos
    '	Dim table As New iText.Layout.Element.Table(UnitValue.CreatePercentArray(New Single() {3, 1, 1, 1})) ' Ajustar proporciones de columnas
    '	table.SetWidth(UnitValue.CreatePercentValue(80)) ' Reducir el tamaño de la tabla

    '	' Agregar las cabeceras de columna
    '	table.AddHeaderCell(New Cell().SetBackgroundColor(ColorConstants.LIGHT_GRAY).Add(New Paragraph("Curso").SetTextAlignment(TextAlignment.CENTER).SetBold()))
    '	table.AddHeaderCell(New Cell().SetBackgroundColor(ColorConstants.LIGHT_GRAY).Add(New Paragraph("Cantidad de meses").SetTextAlignment(TextAlignment.CENTER).SetBold()))
    '	table.AddHeaderCell(New Cell().SetBackgroundColor(ColorConstants.LIGHT_GRAY).Add(New Paragraph("Costo").SetTextAlignment(TextAlignment.CENTER).SetBold()))
    '	table.AddHeaderCell(New Cell().SetBackgroundColor(ColorConstants.LIGHT_GRAY).Add(New Paragraph("Total").SetTextAlignment(TextAlignment.CENTER).SetBold()))

    '	' Agregar las filas de datos
    '	Dim total As Decimal = 0
    '	For Each row As Curso_Pago In ListaInscripciones
    '		Dim cantidadMeses As Integer = row.Meses
    '		Dim costoPorMes As Decimal = Convert.ToDecimal(row.Precio)
    '		Dim totalPorCurso As Decimal = cantidadMeses * costoPorMes

    '		table.AddCell(New Cell().Add(New Paragraph(row.Nombre).SetTextAlignment(TextAlignment.CENTER)))
    '		table.AddCell(New Cell().Add(New Paragraph(cantidadMeses.ToString()).SetTextAlignment(TextAlignment.CENTER)))
    '		table.AddCell(New Cell().Add(New Paragraph(costoPorMes.ToString("C")).SetTextAlignment(TextAlignment.CENTER)))
    '		table.AddCell(New Cell().Add(New Paragraph(totalPorCurso.ToString("C")).SetTextAlignment(TextAlignment.CENTER)))

    '		total += totalPorCurso
    '	Next
    '	document.Add(table)

    '	'Agregar el total
    '	Dim ptotal As New Paragraph("Total: " & total.ToString("C"))
    '	ptotal.SetFont(font).SetFontSize(15).SetFontColor(ColorConstants.RED).SetTextAlignment(TextAlignment.RIGHT).SetMarginTop(20)
    '	document.Add(ptotal)

    '	document.Close()
    '	MsgBox("Factura generada exitosamente.")
    'End Sub


    '	Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
    '		Dim pdfWriter As New PdfWriter("C:\Users\Gaming\Desktop\GYMCAT_Factura.pdf")
    '		Dim pdfDoc As New PdfDocument(pdfWriter)
    '		Dim document As New iText.Layout.Document(pdfDoc)

    '		' Agregar una fuente estándar
    '		Dim font As PdfFont = PdfFontFactory.CreateFont(StandardFonts.HELVETICA)

    '		' Agregar el título
    '		Dim titulo As New Paragraph("FACTURA DE PAGO DE CUOTA - GYMCAT")
    '		titulo.SetFont(font).SetFontSize(20).SetTextAlignment(TextAlignment.CENTER)
    '		document.Add(titulo)

    '		Dim linea As LineSeparator = New LineSeparator(New SolidLine())
    '		document.Add(linea)

    '		' Agregar el logo del gimnasio
    '		Dim imagen As New Image(ImageDataFactory.Create("C:\Users\Gaming\Documents\GitHub\GYMCAT\GYMCAT - SI\Resources\image-removebg-preview (1).png"))
    '		imagen.ScaleAbsolute(66, 70)
    '		imagen.SetFixedPosition(40, 695)
    '		document.Add(imagen)

    '		' Información del gimnasio
    '		Dim infoGym As New Paragraph("GYMCAT S.A." & vbCrLf & "Dirección: Calle Falsa 123" & vbCrLf & "Teléfono: (123) 4567890")
    '		infoGym.SetFont(font).SetFontSize(12).SetMarginTop(16).SetMarginLeft(80)
    '		document.Add(infoGym)

    '		' Fecha y forma de pago
    '		Dim pagoInfo As New Paragraph("Fecha: " & dtpFechaMov.Text & vbCrLf & "Forma de pago: " & cbFormaPago.Text)
    '		pagoInfo.SetFont(font).SetFontSize(12).SetMarginTop(20)
    '		document.Add(pagoInfo)

    '		' Información del cliente/miembro
    '		Dim cliente As New Paragraph("INFORMACION DE MIEMBRO:" + vbCrLf + "Miembro: " + Nombre_Miembro + vbCrLf + "DNI: " + DNI_Miebro + vbCrLf + "Correo: " + Correo_Miembro)
    '		cliente.SetFont(font).SetFontSize(12).SetMarginTop(20)
    '		document.Add(cliente)

    '		' Definir el ancho de las columnas
    '		Dim columnWidths As Single() = {300, 100} ' Columna Curso más ancha, Columna Costo más estrecha

    '		' Tabla de detalles de los cursos
    '		Dim table As New iText.Layout.Element.Table(UnitValue.CreatePercentArray(columnWidths)) ' Usar el constructor que acepta los anchos de columnas
    '		table.SetWidth(UnitValue.CreatePercentValue(80)) ' Reduzca el ancho de la tabla

    '		' Agregar las cabeceras de columna
    '		table.AddHeaderCell(New Cell().SetBackgroundColor(ColorConstants.LIGHT_GRAY).Add(New Paragraph("Curso").SetTextAlignment(TextAlignment.CENTER).SetBold()))
    '		table.AddHeaderCell(New Cell().SetBackgroundColor(ColorConstants.LIGHT_GRAY).Add(New Paragraph("Costo").SetTextAlignment(TextAlignment.CENTER).SetBold()))

    '		' Agregar las filas de datos
    '		For Each row As Curso_Pago In ListaInscripciones
    '			table.AddCell(New Cell().Add(New Paragraph(row.Nombre).SetTextAlignment(TextAlignment.CENTER)))
    '			table.AddCell(New Cell().Add(New Paragraph(Convert.ToDecimal(row.Precio).ToString("C")).SetTextAlignment(TextAlignment.CENTER)))
    '		Next
    '		document.Add(table)

    '		' Agregar el total
    '		Dim total As Decimal = ListaInscripciones.Sum(Function(r) Convert.ToDecimal(r.Precio))
    '		Dim ptotal As New Paragraph("Total: " & total.ToString("C"))
    '		ptotal.SetFont(font).SetFontSize(15).SetFontColor(ColorConstants.RED).SetTextAlignment(TextAlignment.RIGHT).SetMarginTop(20)
    '		document.Add(ptotal)

    '		document.Close()
    '		MsgBox("Factura generada correctamente")
    '	End Sub

    '  cbMiembros.


End Class