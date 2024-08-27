<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPagopopup
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar usando el Diseñador de Windows Forms.  
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		btnPagar = New Button()
		btnImprimir = New Button()
		Label10 = New Label()
		dgvFactura = New DataGridView()
		colDescripción = New DataGridViewTextBoxColumn()
		colMonto = New DataGridViewTextBoxColumn()
		colMeses = New DataGridViewTextBoxColumn()
		dtpFechaMov = New DateTimePicker()
		Label2 = New Label()
		cbFormaPago = New ComboBox()
		Label8 = New Label()
		lbTitulo = New Label()
		gbInfoPago = New GroupBox()
		tbConcepto = New TextBox()
		tbMonto = New TextBox()
		Label12 = New Label()
		Label11 = New Label()
		Label7 = New Label()
		Label9 = New Label()
		cbMeses = New ComboBox()
		PanelBotones = New Panel()
		Panel1 = New Panel()
		PanelMeses = New Panel()
		gbInfoMiembro = New GroupBox()
		cbDeudor = New CheckBox()
		tbIDUltimoPago = New TextBox()
		Label5 = New Label()
		Label6 = New Label()
		Label1 = New Label()
		Label4 = New Label()
		dtpVencimiento = New DateTimePicker()
		dtpUltimoPago = New DateTimePicker()
		PanelSelectorMiembro = New Panel()
		cbMiembros = New ComboBox()
		Label3 = New Label()
		CType(dgvFactura, ComponentModel.ISupportInitialize).BeginInit()
		gbInfoPago.SuspendLayout()
		PanelBotones.SuspendLayout()
		Panel1.SuspendLayout()
		PanelMeses.SuspendLayout()
		gbInfoMiembro.SuspendLayout()
		PanelSelectorMiembro.SuspendLayout()
		SuspendLayout()
		' 
		' btnPagar
		' 
		btnPagar.BackColor = Color.FromArgb(CByte(239), CByte(41), CByte(84))
		btnPagar.FlatStyle = FlatStyle.Popup
		btnPagar.Font = New Font("Cascadia Mono SemiBold", 12F, FontStyle.Bold)
		btnPagar.ForeColor = Color.WhiteSmoke
		btnPagar.ImageAlign = ContentAlignment.MiddleRight
		btnPagar.Location = New Point(62, 6)
		btnPagar.Name = "btnPagar"
		btnPagar.Size = New Size(114, 59)
		btnPagar.TabIndex = 16
		btnPagar.Text = "Pagar"
		btnPagar.UseVisualStyleBackColor = False
		' 
		' btnImprimir
		' 
		btnImprimir.BackColor = Color.FromArgb(CByte(239), CByte(41), CByte(84))
		btnImprimir.FlatStyle = FlatStyle.Popup
		btnImprimir.Font = New Font("Cascadia Mono SemiBold", 12F, FontStyle.Bold)
		btnImprimir.ForeColor = Color.WhiteSmoke
		btnImprimir.ImageAlign = ContentAlignment.MiddleRight
		btnImprimir.Location = New Point(240, 6)
		btnImprimir.Name = "btnImprimir"
		btnImprimir.Size = New Size(114, 59)
		btnImprimir.TabIndex = 17
		btnImprimir.Text = "Imprimir"
		btnImprimir.UseVisualStyleBackColor = False
		' 
		' Label10
		' 
		Label10.AutoSize = True
		Label10.Font = New Font("Cascadia Mono SemiBold", 20F, FontStyle.Bold)
		Label10.ForeColor = Color.WhiteSmoke
		Label10.Location = New Point(27, 21)
		Label10.Name = "Label10"
		Label10.Size = New Size(303, 35)
		Label10.TabIndex = 3
		Label10.Text = "Formulario de Pago"
		' 
		' dgvFactura
		' 
		dgvFactura.AllowUserToAddRows = False
		dgvFactura.AllowUserToDeleteRows = False
		dgvFactura.AllowUserToResizeRows = False
		dgvFactura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
		dgvFactura.Columns.AddRange(New DataGridViewColumn() {colDescripción, colMonto, colMeses})
		dgvFactura.Location = New Point(506, 114)
		dgvFactura.MultiSelect = False
		dgvFactura.Name = "dgvFactura"
		dgvFactura.ReadOnly = True
		dgvFactura.Size = New Size(392, 329)
		dgvFactura.TabIndex = 38
		' 
		' colDescripción
		' 
		colDescripción.HeaderText = "Descripción"
		colDescripción.Name = "colDescripción"
		colDescripción.ReadOnly = True
		' 
		' colMonto
		' 
		colMonto.HeaderText = "Monto"
		colMonto.Name = "colMonto"
		colMonto.ReadOnly = True
		' 
		' colMeses
		' 
		colMeses.HeaderText = "Cantidad de Meses"
		colMeses.Name = "colMeses"
		colMeses.ReadOnly = True
		' 
		' dtpFechaMov
		' 
		dtpFechaMov.CalendarTitleBackColor = Color.FromArgb(CByte(239), CByte(41), CByte(84))
		dtpFechaMov.Format = DateTimePickerFormat.Short
		dtpFechaMov.Location = New Point(187, 20)
		dtpFechaMov.Name = "dtpFechaMov"
		dtpFechaMov.Size = New Size(185, 21)
		dtpFechaMov.TabIndex = 37
		dtpFechaMov.Value = New Date(2024, 8, 17, 0, 0, 0, 0)
		' 
		' Label2
		' 
		Label2.AutoSize = True
		Label2.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
		Label2.ForeColor = Color.WhiteSmoke
		Label2.Location = New Point(126, 22)
		Label2.Name = "Label2"
		Label2.Size = New Size(56, 17)
		Label2.TabIndex = 10
		Label2.Text = "Fecha:"
		' 
		' cbFormaPago
		' 
		cbFormaPago.AutoCompleteSource = AutoCompleteSource.CustomSource
		cbFormaPago.FormattingEnabled = True
		cbFormaPago.Items.AddRange(New Object() {"Transferencia", "Efectivo", "Tarjeta"})
		cbFormaPago.Location = New Point(187, 47)
		cbFormaPago.Name = "cbFormaPago"
		cbFormaPago.Size = New Size(185, 24)
		cbFormaPago.TabIndex = 24
		' 
		' Label8
		' 
		Label8.AutoSize = True
		Label8.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
		Label8.ForeColor = Color.WhiteSmoke
		Label8.Location = New Point(62, 49)
		Label8.Name = "Label8"
		Label8.Size = New Size(120, 17)
		Label8.TabIndex = 19
		Label8.Text = "Forma de Pago:"
		' 
		' lbTitulo
		' 
		lbTitulo.AutoSize = True
		lbTitulo.Font = New Font("Cascadia Mono SemiBold", 14F, FontStyle.Bold)
		lbTitulo.ForeColor = Color.WhiteSmoke
		lbTitulo.Location = New Point(27, 68)
		lbTitulo.Name = "lbTitulo"
		lbTitulo.Size = New Size(78, 25)
		lbTitulo.TabIndex = 41
		lbTitulo.Text = "titulo"
		' 
		' gbInfoPago
		' 
		gbInfoPago.Controls.Add(tbConcepto)
		gbInfoPago.Controls.Add(tbMonto)
		gbInfoPago.Controls.Add(Label12)
		gbInfoPago.Controls.Add(Label2)
		gbInfoPago.Controls.Add(Label11)
		gbInfoPago.Controls.Add(Label8)
		gbInfoPago.Controls.Add(cbFormaPago)
		gbInfoPago.Controls.Add(dtpFechaMov)
		gbInfoPago.Dock = DockStyle.Top
		gbInfoPago.Font = New Font("Cascadia Mono", 9F)
		gbInfoPago.ForeColor = Color.White
		gbInfoPago.Location = New Point(0, 0)
		gbInfoPago.Name = "gbInfoPago"
		gbInfoPago.Size = New Size(429, 151)
		gbInfoPago.TabIndex = 42
		gbInfoPago.TabStop = False
		gbInfoPago.Text = "Detalles"
		' 
		' tbConcepto
		' 
		tbConcepto.Location = New Point(187, 115)
		tbConcepto.Name = "tbConcepto"
		tbConcepto.ScrollBars = ScrollBars.Vertical
		tbConcepto.Size = New Size(185, 21)
		tbConcepto.TabIndex = 38
		' 
		' tbMonto
		' 
		tbMonto.Location = New Point(187, 86)
		tbMonto.Name = "tbMonto"
		tbMonto.Size = New Size(185, 21)
		tbMonto.TabIndex = 38
		' 
		' Label12
		' 
		Label12.AutoSize = True
		Label12.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
		Label12.ForeColor = Color.WhiteSmoke
		Label12.Location = New Point(126, 88)
		Label12.Name = "Label12"
		Label12.Size = New Size(56, 17)
		Label12.TabIndex = 10
		Label12.Text = "Monto:"
		' 
		' Label11
		' 
		Label11.AutoSize = True
		Label11.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
		Label11.ForeColor = Color.WhiteSmoke
		Label11.Location = New Point(102, 115)
		Label11.Name = "Label11"
		Label11.Size = New Size(80, 17)
		Label11.TabIndex = 19
		Label11.Text = "Concepto:"
		' 
		' Label7
		' 
		Label7.AutoSize = True
		Label7.Font = New Font("Cascadia Mono SemiBold", 14F, FontStyle.Bold)
		Label7.ForeColor = Color.WhiteSmoke
		Label7.Location = New Point(506, 68)
		Label7.Name = "Label7"
		Label7.Size = New Size(89, 25)
		Label7.TabIndex = 44
		Label7.Text = "Factura"
		' 
		' Label9
		' 
		Label9.AutoSize = True
		Label9.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
		Label9.ForeColor = Color.WhiteSmoke
		Label9.Location = New Point(121, 12)
		Label9.Name = "Label9"
		Label9.Size = New Size(56, 17)
		Label9.TabIndex = 19
		Label9.Text = "Meses:"
		' 
		' cbMeses
		' 
		cbMeses.FormattingEnabled = True
		cbMeses.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
		cbMeses.Location = New Point(183, 9)
		cbMeses.Name = "cbMeses"
		cbMeses.Size = New Size(120, 23)
		cbMeses.TabIndex = 24
		' 
		' PanelBotones
		' 
		PanelBotones.AutoScroll = True
		PanelBotones.AutoSizeMode = AutoSizeMode.GrowAndShrink
		PanelBotones.Controls.Add(Panel1)
		PanelBotones.Controls.Add(PanelMeses)
		PanelBotones.Controls.Add(gbInfoMiembro)
		PanelBotones.Controls.Add(PanelSelectorMiembro)
		PanelBotones.Controls.Add(gbInfoPago)
		PanelBotones.Location = New Point(27, 96)
		PanelBotones.Name = "PanelBotones"
		PanelBotones.Size = New Size(429, 436)
		PanelBotones.TabIndex = 45
		' 
		' Panel1
		' 
		Panel1.AutoSize = True
		Panel1.Controls.Add(btnPagar)
		Panel1.Controls.Add(btnImprimir)
		Panel1.Dock = DockStyle.Top
		Panel1.Location = New Point(0, 368)
		Panel1.Name = "Panel1"
		Panel1.Size = New Size(429, 68)
		Panel1.TabIndex = 48
		' 
		' PanelMeses
		' 
		PanelMeses.AutoSize = True
		PanelMeses.Controls.Add(cbMeses)
		PanelMeses.Controls.Add(Label9)
		PanelMeses.Dock = DockStyle.Top
		PanelMeses.Location = New Point(0, 333)
		PanelMeses.Name = "PanelMeses"
		PanelMeses.Size = New Size(429, 35)
		PanelMeses.TabIndex = 46
		' 
		' gbInfoMiembro
		' 
		gbInfoMiembro.Controls.Add(cbDeudor)
		gbInfoMiembro.Controls.Add(tbIDUltimoPago)
		gbInfoMiembro.Controls.Add(Label5)
		gbInfoMiembro.Controls.Add(Label6)
		gbInfoMiembro.Controls.Add(Label1)
		gbInfoMiembro.Controls.Add(Label4)
		gbInfoMiembro.Controls.Add(dtpVencimiento)
		gbInfoMiembro.Controls.Add(dtpUltimoPago)
		gbInfoMiembro.Dock = DockStyle.Top
		gbInfoMiembro.Font = New Font("Cascadia Mono", 9F)
		gbInfoMiembro.ForeColor = Color.White
		gbInfoMiembro.Location = New Point(0, 187)
		gbInfoMiembro.Name = "gbInfoMiembro"
		gbInfoMiembro.Size = New Size(429, 146)
		gbInfoMiembro.TabIndex = 45
		gbInfoMiembro.TabStop = False
		gbInfoMiembro.Text = "Información del Miembro"
		' 
		' cbDeudor
		' 
		cbDeudor.AutoSize = True
		cbDeudor.Font = New Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		cbDeudor.ForeColor = Color.White
		cbDeudor.Location = New Point(189, 81)
		cbDeudor.Name = "cbDeudor"
		cbDeudor.Size = New Size(68, 20)
		cbDeudor.TabIndex = 39
		cbDeudor.Text = " Si/No"
		cbDeudor.UseVisualStyleBackColor = True
		' 
		' tbIDUltimoPago
		' 
		tbIDUltimoPago.Location = New Point(189, 26)
		tbIDUltimoPago.Name = "tbIDUltimoPago"
		tbIDUltimoPago.Size = New Size(183, 21)
		tbIDUltimoPago.TabIndex = 38
		' 
		' Label5
		' 
		Label5.AutoSize = True
		Label5.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
		Label5.ForeColor = Color.WhiteSmoke
		Label5.Location = New Point(54, 30)
		Label5.Name = "Label5"
		Label5.Size = New Size(128, 17)
		Label5.TabIndex = 10
		Label5.Text = "ID último pago:"
		' 
		' Label6
		' 
		Label6.AutoSize = True
		Label6.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
		Label6.ForeColor = Color.WhiteSmoke
		Label6.Location = New Point(6, 110)
		Label6.Name = "Label6"
		Label6.Size = New Size(176, 17)
		Label6.TabIndex = 10
		Label6.Text = "Fecha de vencimiento:"
		' 
		' Label1
		' 
		Label1.AutoSize = True
		Label1.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
		Label1.ForeColor = Color.WhiteSmoke
		Label1.Location = New Point(30, 57)
		Label1.Name = "Label1"
		Label1.Size = New Size(152, 17)
		Label1.TabIndex = 10
		Label1.Text = "Fecha último pago:"
		' 
		' Label4
		' 
		Label4.AutoSize = True
		Label4.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
		Label4.ForeColor = Color.WhiteSmoke
		Label4.Location = New Point(118, 84)
		Label4.Name = "Label4"
		Label4.Size = New Size(64, 17)
		Label4.TabIndex = 19
		Label4.Text = "Deudor:"
		' 
		' dtpVencimiento
		' 
		dtpVencimiento.CalendarTitleBackColor = Color.FromArgb(CByte(239), CByte(41), CByte(84))
		dtpVencimiento.Format = DateTimePickerFormat.Short
		dtpVencimiento.Location = New Point(189, 107)
		dtpVencimiento.Name = "dtpVencimiento"
		dtpVencimiento.Size = New Size(183, 21)
		dtpVencimiento.TabIndex = 37
		dtpVencimiento.Value = New Date(2024, 8, 17, 0, 0, 0, 0)
		' 
		' dtpUltimoPago
		' 
		dtpUltimoPago.CalendarTitleBackColor = Color.FromArgb(CByte(239), CByte(41), CByte(84))
		dtpUltimoPago.Format = DateTimePickerFormat.Short
		dtpUltimoPago.Location = New Point(189, 54)
		dtpUltimoPago.Name = "dtpUltimoPago"
		dtpUltimoPago.Size = New Size(183, 21)
		dtpUltimoPago.TabIndex = 37
		dtpUltimoPago.Value = New Date(2024, 8, 17, 0, 0, 0, 0)
		' 
		' PanelSelectorMiembro
		' 
		PanelSelectorMiembro.Controls.Add(cbMiembros)
		PanelSelectorMiembro.Controls.Add(Label3)
		PanelSelectorMiembro.Dock = DockStyle.Top
		PanelSelectorMiembro.Location = New Point(0, 151)
		PanelSelectorMiembro.Name = "PanelSelectorMiembro"
		PanelSelectorMiembro.Size = New Size(429, 36)
		PanelSelectorMiembro.TabIndex = 44
		' 
		' cbMiembros
		' 
		cbMiembros.FormattingEnabled = True
		cbMiembros.Items.AddRange(New Object() {"Transferencia", "Efectivo", "Tarjeta", "Cola °|°"})
		cbMiembros.Location = New Point(118, 6)
		cbMiembros.Name = "cbMiembros"
		cbMiembros.Size = New Size(264, 23)
		cbMiembros.TabIndex = 24
		' 
		' Label3
		' 
		Label3.AutoSize = True
		Label3.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
		Label3.ForeColor = Color.WhiteSmoke
		Label3.Location = New Point(40, 9)
		Label3.Name = "Label3"
		Label3.Size = New Size(72, 17)
		Label3.TabIndex = 19
		Label3.Text = "Miembro:"
		' 
		' FormPagopopup
		' 
		AutoScaleDimensions = New SizeF(7F, 15F)
		AutoScaleMode = AutoScaleMode.Font
		AutoSizeMode = AutoSizeMode.GrowAndShrink
		BackColor = Color.FromArgb(CByte(33), CByte(31), CByte(45))
		ClientSize = New Size(964, 565)
		Controls.Add(PanelBotones)
		Controls.Add(Label7)
		Controls.Add(lbTitulo)
		Controls.Add(dgvFactura)
		Controls.Add(Label10)
		Name = "FormPagopopup"
		Text = "FormPagospopup"
		CType(dgvFactura, ComponentModel.ISupportInitialize).EndInit()
		gbInfoPago.ResumeLayout(False)
		gbInfoPago.PerformLayout()
		PanelBotones.ResumeLayout(False)
		PanelBotones.PerformLayout()
		Panel1.ResumeLayout(False)
		PanelMeses.ResumeLayout(False)
		PanelMeses.PerformLayout()
		gbInfoMiembro.ResumeLayout(False)
		gbInfoMiembro.PerformLayout()
		PanelSelectorMiembro.ResumeLayout(False)
		PanelSelectorMiembro.PerformLayout()
		ResumeLayout(False)
		PerformLayout()
	End Sub
	Friend WithEvents btnPagar As Button
    Friend WithEvents btnImprimir As Button
	Friend WithEvents Label10 As Label
    Friend WithEvents dgvFactura As DataGridView
    Friend WithEvents dtpFechaMov As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents cbFormaPago As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents lbTitulo As Label
    Friend WithEvents gbInfoPago As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cbMeses As ComboBox
	Friend WithEvents PanelBotones As Panel
	Friend WithEvents gbInfoMiembro As GroupBox
	Friend WithEvents cbDeudor As CheckBox
	Friend WithEvents tbIDUltimoPago As TextBox
	Friend WithEvents Label5 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents dtpVencimiento As DateTimePicker
	Friend WithEvents dtpUltimoPago As DateTimePicker
    Friend WithEvents colDescripción As DataGridViewTextBoxColumn
    Friend WithEvents colMonto As DataGridViewTextBoxColumn
    Friend WithEvents colMeses As DataGridViewTextBoxColumn
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents tbMonto As TextBox
    Friend WithEvents tbConcepto As TextBox
    Friend WithEvents PanelSelectorMiembro As Panel
    Friend WithEvents cbMiembros As ComboBox
    Friend WithEvents Label3 As Label
	Friend WithEvents PanelMeses As Panel
	Friend WithEvents Panel1 As Panel
End Class
