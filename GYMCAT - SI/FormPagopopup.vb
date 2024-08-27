Imports System.Reflection.Metadata
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
Imports DocumentFormat.OpenXml.Vml
Imports Org.BouncyCastle.Asn1.Cmp


Public Class FormPagopopup

	Private _Conexion As Conexion
	Private Modo As String
	Private ListaInscripciones As New List(Of Curso_Pago)
	Private miConexion As New MySqlConnection("Server=localhost; Database=gymcat; Uid=root; Pwd=;")
	Private Nombre_Miembro As String
	Private DNI_Miembro As String
	Private Correo_Miembro As String
	Private Tabla As String
	Private total As Decimal
	Public TablaDataAdapter As MySqlDataAdapter
	Public GymcatDataSet As DataSet
	Public IDMovActual As Integer
	Public IdMiembro As Integer
	Public TipoMov As String
	Public NomCompleto As String

	Public Sub New(DNI_miembro1 As Integer, modo1 As String)
		InitializeComponent()
		Modo = modo1
		DNI_Miembro = DNI_miembro1
	End Sub

	Public Sub New(TipoMov1 As String)
		InitializeComponent()
		Modo = "Generico"
		btnPagar.Text = "Guardar"
		If TipoMov1 = "Ingresos" Then
			TipoMov = "Ingreso"
			If FormFinanzas._Conexion.esNuevo Then
				Me.Text = ("Nuevo Ingreso")
				dtpFechaMov.Text = ""
				cbFormaPago.Text = ""
				total = 0
				tbConcepto.Text = ""
				'fila("concepto") = modo + DNI_Miembro + " por " + cbMeses.Text + " mes/es"
			Else
				Dim fila As DataGridViewRow = FormFinanzas.dgvListadoFinanzas.CurrentRow
				Me.Text = ("Editar Empleado")
				FormFinanzas._Conexion.idFila = fila.Cells(0).Value
				dtpFechaMov.Text = fila.Cells(1).Value
				cbFormaPago.Text = fila.Cells(2).Value
				tbMonto.Text = fila.Cells(3).Value.ToString()
				tbConcepto.Text = fila.Cells(4).Value
			End If
		End If
		If TipoMov1 = "Egresos" Then
			TipoMov = "Egreso"
			If FormFinanzas._Conexion.esNuevo Then
				Me.Text = ("Nuevo Gasto")
				dtpFechaMov.Text = ""
				cbFormaPago.Text = ""
				total = 0
				tbConcepto.Text = ""
				'fila("concepto") = modo + DNI_Miembro + " por " + cbMeses.Text + " mes/es"
			Else
				Dim fila As DataGridViewRow = FormFinanzas.dgvListadoFinanzas.CurrentRow
				Me.Text = ("Editar Egreso")
				FormFinanzas._Conexion.idFila = fila.Cells(0).Value
				dtpFechaMov.Text = fila.Cells(1).Value
				tbMonto.Text = fila.Cells(2).Value.ToString()
				cbFormaPago.Text = fila.Cells(3).Value
				tbConcepto.Text = fila.Cells(4).Value
			End If
		End If
	End Sub

	Public Sub New(Lista As List(Of Curso_Pago), dni As String)
		InitializeComponent()
		DNI_Miembro = dni
		For Each n As Curso_Pago In Lista
			ListaInscripciones.Add(New Curso_Pago(n.ID_Curso, n.Nombre, n.Precio, n.Meses))
		Next
		Modo = "Inscripcion"
		Me.Width = 500
		Me.Height = 400
	End Sub


	Private Sub FormPagopopup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		gbInfoPago.Height = 83
		_Conexion = New Conexion()
		_Conexion.miConexion.Open()
		Dim comando As New MySqlCommand("SELECT * FROM ingresos order by ID_ingresos DESC", _Conexion.miConexion)

		Dim lector = comando.ExecuteReader
		lector.Read()
		IDMovActual = lector("ID_ingresos") + 1
		lector.Close()

		Dim comando1 As New MySqlCommand("SELECT * FROM miembros WHERE dni = @dni", _Conexion.miConexion)
		comando1.Parameters.AddWithValue("@dni", DNI_Miembro)

		Dim lector1 = comando1.ExecuteReader
		lector1.Read()
		If lector1.HasRows Then
			IdMiembro = lector1("ID_miembro")
			NomCompleto = lector1("nombre") + " " + lector1("apellido") + ", " + lector1("DNI").ToString
		End If
		lector1.Close()
		Me.Width = 930
		Me.Height = 585
		'gbInfoPago.Height = 103
		'btnPagar.Location = New Point(446, 483)
		'btnImprimir.Location = New Point(566, 483)
		'Me.Height = 626
		'Me.Width = 969
		'PanelBotones.Height = 455

		Select Case Modo
			Case "Cuota"
				lbTitulo.Text = "Couta de Miembro, ID " + IDMovActual.ToString

				cbMiembros.Enabled = False
				dtpFechaMov.Text = Today
				cbMiembros.Text = NomCompleto

				Cuota()

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
				cbMiembros.Items.Add(NomCompleto)
				cbMiembros.Enabled = False

				Cuota()

			Case "Membresia"

				gbInfoMiembro.Hide()

				lbTitulo.Text = "Membresia de nuevo Miembro, ID " + IDMovActual.ToString
				lector.Close()
				dtpFechaMov.Enabled = False
				dtpFechaMov.Text = nuevoMiembro.dtpInscripcion.Text
				cbMiembros.Text = nuevoMiembro.tbNombre.Text + " " + nuevoMiembro.tbApellido.Text + ", " + nuevoMiembro.tbDNI.Text
				cbMiembros.Enabled = False

				cbMeses.Text = nuevoMiembro.cbDuracMemb.Text
				cbMeses.Enabled = False

			Case "Generico"
				gbInfoPago.Height = 151
				gbInfoMiembro.Hide()
				PanelSelectorMiembro.Hide()
				PanelMeses.Hide()
				Label7.Hide()
				dgvFactura.Hide()
				'btnPagar.Location = New Point(82, 314)
				'btnImprimir.Location = New Point(214, 314)
				'Me.Height = 478
				'Me.Width = 475
				'PanelBotones.Height = 190

				lbTitulo.Text = "Nuevo " + TipoMov + ", ID " + IDMovActual.ToString
		End Select


		miConexion.Close()



	End Sub

	Private Sub btnPagar_Click(sender As Object, e As EventArgs) Handles btnPagar.Click

		Select Case Modo
			Case "Generico"
				If TipoMov = "Ingreso" Then
					FormFinanzas.GuardarIngresos()
				ElseIf TipoMov = "Egreso" Then
					FormFinanzas.GuardarEgresos()
				End If
				Me.Close()
			Case "Cuota"
				If cbMeses.Text = "" Then
					MsgBox("Elegir cantidad de meses!")
				Else
					ActualizarIngresos("Cuota de Miembro")

					Dim comando2 As New MySqlCommand("SELECT * FROM miembros WHERE dni = @dni", _Conexion.miConexion)
					comando2.Parameters.AddWithValue("@dni", DNI_Miembro)

					_Conexion.miConexion.Open()

					Dim lector2 = comando2.ExecuteReader
					lector2.Read()
					Dim durmem As Integer = lector2("duracion_membresia") + cbMeses.Text

					_Conexion.miConexion.Close()

					Dim comando3 As New MySqlCommand("UPDATE miembros SET duracion_membresia = @mem WHERE dni = @dni", _Conexion.miConexion)
					comando3.Parameters.AddWithValue("@dni", DNI_Miembro)
					comando3.Parameters.AddWithValue("@mem", durmem)

					_Conexion.miConexion.Open()
					comando3.ExecuteNonQuery()
					_Conexion.miConexion.Close()

					Me.Close()
					FormFinanzas.actualizardvg()
					actualizarMiembroMesIngreso()

				End If

			Case "Inscripcion"

			Case "Membresia"
				If cbMeses.Text = "" Then
					MsgBox("Elegir cantidad de meses!")
				Else

					ActualizarIngresos("Membresia de nuevo Miembro")
					Me.Close()
					FormFinanzas.actualizardvg()
					actualizarMiembroMesIngreso()
				End If
		End Select


	End Sub

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

		Dim precio As Integer = 15000 * cbMeses.Text

		Dim n = dgvFactura.Rows.Add
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

		total = lector("costo_total") * cbMeses.Text

		dgvFactura.Rows.Add()
		n = dgvFactura.Rows.Add
		dgvFactura.Rows(n).Cells(0).Value = "Total"
		dgvFactura.Rows(n).Cells(1).Value = total.ToString
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

	Sub ActualizarIngresos(modo As String)
		Tabla = "TIngresos"
		Dim consulta As String = "SELECT * FROM ingresos"

		_Conexion = New Conexion(consulta, Tabla)

		Dim fila As DataRow
		Dim cmd As String

		'1. Crear una nueva fila 
		fila = _Conexion.GymcatDataSet.Tables(Tabla).NewRow
		'2. Rellenar la fila con información
		fila("fecha_pago") = dtpFechaMov.Text
		fila("forma_pago") = cbFormaPago.Text
		fila("monto") = total
		fila("concepto") = modo + DNI_Miembro + " por " + cbMeses.Text + " mes/es"

		'3. Agregar fila a la tabla del DataSet
		_Conexion.GymcatDataSet.Tables(Tabla).Rows.Add(fila)

		'4. Crear Comando para agregar a la BD la fila nueva cmd
		cmd = "INSERT INTO ingresos (fecha_pago, forma_pago, monto, concepto) VALUES (@fecha, @forma, @mon, @con)"
		_Conexion.TablaDataAdapter.InsertCommand = New MySqlCommand(cmd, _Conexion.miConexion)
		_Conexion.TablaDataAdapter.InsertCommand.Parameters.Add("@fecha", MySqlDbType.Date, 20, "fecha_pago")
		_Conexion.TablaDataAdapter.InsertCommand.Parameters.Add("@forma", MySqlDbType.VarChar, 20, "forma_pago")
		_Conexion.TablaDataAdapter.InsertCommand.Parameters.Add("@mon", MySqlDbType.Int32, 50, "monto")
		_Conexion.TablaDataAdapter.InsertCommand.Parameters.Add("@con", MySqlDbType.VarChar, 250, "concepto")

		'5. Guardar los cambios en la base de datos
		_Conexion.TablaDataAdapter.Update(_Conexion.GymcatDataSet.Tables(Tabla))
	End Sub

	Sub actualizarMiembroMesIngreso()

		Dim comando As New MySqlCommand("SELECT * FROM mes WHERE mes = @mes", _Conexion.miConexion)
		comando.Parameters.AddWithValue("@mes", Format(Now, "MMMM"))

		_Conexion.miConexion.Open()

		Dim lector = comando.ExecuteReader
		lector.Read()
		Dim mesactual As Integer = lector("ID_mes")

		_Conexion.miConexion.Close()


		Tabla = "TMiembroMesIngreso"
		_Conexion = New Conexion("SELECT * FROM miembros_mes_ingresos", Tabla)

		Dim fila As DataRow
		Dim cmd As String

		fila = _Conexion.GymcatDataSet.Tables(Tabla).NewRow
		fila("FK_miembros") = IdMiembro
		fila("FK_mes") = mesactual
		fila("FK_ingresos") = IDMovActual

		_Conexion.GymcatDataSet.Tables(Tabla).Rows.Add(fila)

		cmd = "INSERT INTO miembros_mes_ingresos (FK_miembros, FK_mes, FK_ingresos) VALUES (@miem, @mes, @ing)"
		_Conexion.TablaDataAdapter.InsertCommand = New MySqlCommand(cmd, _Conexion.miConexion)
		_Conexion.TablaDataAdapter.InsertCommand.Parameters.Add("@miem", MySqlDbType.Int32, 20, "FK_miembros")
		_Conexion.TablaDataAdapter.InsertCommand.Parameters.Add("@mes", MySqlDbType.Int32, 20, "FK_mes")
		_Conexion.TablaDataAdapter.InsertCommand.Parameters.Add("@ing", MySqlDbType.Int32, 20, "FK_ingresos")

		_Conexion.TablaDataAdapter.Update(_Conexion.GymcatDataSet.Tables(Tabla))
	End Sub

	Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
		gbInfoMiembro.Show()
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