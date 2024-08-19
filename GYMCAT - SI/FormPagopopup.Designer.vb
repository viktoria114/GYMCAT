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
		Label2 = New Label()
		btnGuardar = New Button()
		btnCancelar = New Button()
		Label8 = New Label()
		cbEstadoElemento = New ComboBox()
		Label10 = New Label()
		dtpNac = New DateTimePicker()
		GroupBox1 = New GroupBox()
		RichTextBox1 = New RichTextBox()
		CheckBox1 = New CheckBox()
		TabControl1 = New TabControl()
		TabPage2 = New TabPage()
		CheckedListBox1 = New CheckedListBox()
		ListBox1 = New ListBox()
		Panel2 = New Panel()
		DataGridView1 = New DataGridView()
		TextBox1 = New TextBox()
		Label3 = New Label()
		lbInscripciones = New Label()
		Panel1 = New Panel()
		GroupBox1.SuspendLayout()
		TabControl1.SuspendLayout()
		TabPage2.SuspendLayout()
		Panel2.SuspendLayout()
		CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
		Panel1.SuspendLayout()
		SuspendLayout()
		' 
		' Label2
		' 
		Label2.AutoSize = True
		Label2.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
		Label2.ForeColor = Color.WhiteSmoke
		Label2.Location = New Point(68, 20)
		Label2.Name = "Label2"
		Label2.Size = New Size(56, 17)
		Label2.TabIndex = 10
		Label2.Text = "Fecha:"
		' 
		' btnGuardar
		' 
		btnGuardar.BackColor = Color.FromArgb(CByte(239), CByte(41), CByte(84))
		btnGuardar.FlatStyle = FlatStyle.Popup
		btnGuardar.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
		btnGuardar.ForeColor = Color.WhiteSmoke
		btnGuardar.ImageAlign = ContentAlignment.MiddleRight
		btnGuardar.Location = New Point(873, 512)
		btnGuardar.Name = "btnGuardar"
		btnGuardar.Size = New Size(91, 44)
		btnGuardar.TabIndex = 16
		btnGuardar.Text = "Guardar"
		btnGuardar.UseVisualStyleBackColor = False
		' 
		' btnCancelar
		' 
		btnCancelar.BackColor = Color.FromArgb(CByte(239), CByte(41), CByte(84))
		btnCancelar.FlatStyle = FlatStyle.Popup
		btnCancelar.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
		btnCancelar.ForeColor = Color.WhiteSmoke
		btnCancelar.ImageAlign = ContentAlignment.MiddleRight
		btnCancelar.Location = New Point(873, 447)
		btnCancelar.Name = "btnCancelar"
		btnCancelar.Size = New Size(91, 44)
		btnCancelar.TabIndex = 17
		btnCancelar.Text = "Cancelar"
		btnCancelar.UseVisualStyleBackColor = False
		' 
		' Label8
		' 
		Label8.AutoSize = True
		Label8.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
		Label8.ForeColor = Color.WhiteSmoke
		Label8.Location = New Point(12, 49)
		Label8.Name = "Label8"
		Label8.Size = New Size(120, 17)
		Label8.TabIndex = 19
		Label8.Text = "Forma de Pago:"
		' 
		' cbEstadoElemento
		' 
		cbEstadoElemento.FormattingEnabled = True
		cbEstadoElemento.Items.AddRange(New Object() {"Transferencia", "Efectivo", "Tarjeta", "Cola °|°"})
		cbEstadoElemento.Location = New Point(128, 46)
		cbEstadoElemento.Name = "cbEstadoElemento"
		cbEstadoElemento.Size = New Size(183, 23)
		cbEstadoElemento.TabIndex = 24
		' 
		' Label10
		' 
		Label10.AutoSize = True
		Label10.Font = New Font("Cascadia Mono SemiBold", 14F, FontStyle.Bold)
		Label10.ForeColor = Color.WhiteSmoke
		Label10.Location = New Point(94, 20)
		Label10.Name = "Label10"
		Label10.Size = New Size(210, 25)
		Label10.TabIndex = 3
		Label10.Text = "Formulario de Pago"
		' 
		' dtpNac
		' 
		dtpNac.CalendarTitleBackColor = Color.FromArgb(CByte(239), CByte(41), CByte(84))
		dtpNac.Format = DateTimePickerFormat.Short
		dtpNac.Location = New Point(191, 17)
		dtpNac.MaxDate = New Date(2024, 8, 17, 0, 0, 0, 0)
		dtpNac.Name = "dtpNac"
		dtpNac.Size = New Size(120, 23)
		dtpNac.TabIndex = 37
		dtpNac.Value = New Date(2024, 8, 17, 0, 0, 0, 0)
		' 
		' GroupBox1
		' 
		GroupBox1.Controls.Add(RichTextBox1)
		GroupBox1.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
		GroupBox1.ForeColor = Color.White
		GroupBox1.Location = New Point(610, 435)
		GroupBox1.Name = "GroupBox1"
		GroupBox1.Size = New Size(257, 130)
		GroupBox1.TabIndex = 39
		GroupBox1.TabStop = False
		GroupBox1.Text = "   Detalles"
		' 
		' RichTextBox1
		' 
		RichTextBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
		RichTextBox1.Location = New Point(50, 17)
		RichTextBox1.Name = "RichTextBox1"
		RichTextBox1.Size = New Size(128, 95)
		RichTextBox1.TabIndex = 38
		RichTextBox1.Text = ""
		' 
		' CheckBox1
		' 
		CheckBox1.AutoSize = True
		CheckBox1.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
		CheckBox1.ForeColor = Color.White
		CheckBox1.Location = New Point(134, 18)
		CheckBox1.Name = "CheckBox1"
		CheckBox1.Size = New Size(51, 21)
		CheckBox1.TabIndex = 0
		CheckBox1.Text = "Hoy"
		CheckBox1.UseVisualStyleBackColor = True
		' 
		' TabControl1
		' 
		TabControl1.Controls.Add(TabPage2)
		TabControl1.Location = New Point(532, 12)
		TabControl1.Name = "TabControl1"
		TabControl1.SelectedIndex = 0
		TabControl1.Size = New Size(394, 372)
		TabControl1.TabIndex = 39
		' 
		' TabPage2
		' 
		TabPage2.BackColor = Color.FromArgb(CByte(33), CByte(31), CByte(45))
		TabPage2.Controls.Add(CheckedListBox1)
		TabPage2.Location = New Point(4, 24)
		TabPage2.Name = "TabPage2"
		TabPage2.Padding = New Padding(3)
		TabPage2.Size = New Size(386, 344)
		TabPage2.TabIndex = 1
		TabPage2.Text = "TabPage2"
		' 
		' CheckedListBox1
		' 
		CheckedListBox1.FormattingEnabled = True
		CheckedListBox1.IntegralHeight = False
		CheckedListBox1.Items.AddRange(New Object() {"f", "f", "f", "f", "f"})
		CheckedListBox1.Location = New Point(139, 192)
		CheckedListBox1.Name = "CheckedListBox1"
		CheckedListBox1.Size = New Size(166, 121)
		CheckedListBox1.TabIndex = 1
		' 
		' ListBox1
		' 
		ListBox1.FormattingEnabled = True
		ListBox1.ItemHeight = 15
		ListBox1.Items.AddRange(New Object() {"hola", "como", "tamos"})
		ListBox1.Location = New Point(32, 236)
		ListBox1.Name = "ListBox1"
		ListBox1.Size = New Size(153, 94)
		ListBox1.TabIndex = 0
		' 
		' Panel2
		' 
		Panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink
		Panel2.Controls.Add(lbInscripciones)
		Panel2.Controls.Add(DataGridView1)
		Panel2.Controls.Add(ListBox1)
		Panel2.Controls.Add(dtpNac)
		Panel2.Controls.Add(Label2)
		Panel2.Controls.Add(TextBox1)
		Panel2.Controls.Add(Label3)
		Panel2.Controls.Add(cbEstadoElemento)
		Panel2.Controls.Add(Label8)
		Panel2.Controls.Add(CheckBox1)
		Panel2.Dock = DockStyle.Top
		Panel2.Location = New Point(0, 0)
		Panel2.Name = "Panel2"
		Panel2.Size = New Size(426, 337)
		Panel2.TabIndex = 0
		' 
		' DataGridView1
		' 
		DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
		DataGridView1.Location = New Point(0, 104)
		DataGridView1.Name = "DataGridView1"
		DataGridView1.ReadOnly = True
		DataGridView1.Size = New Size(426, 103)
		DataGridView1.TabIndex = 38
		' 
		' TextBox1
		' 
		TextBox1.Location = New Point(128, 75)
		TextBox1.Name = "TextBox1"
		TextBox1.Size = New Size(183, 23)
		TextBox1.TabIndex = 7
		' 
		' Label3
		' 
		Label3.AutoSize = True
		Label3.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
		Label3.ForeColor = Color.WhiteSmoke
		Label3.Location = New Point(48, 76)
		Label3.Name = "Label3"
		Label3.Size = New Size(72, 17)
		Label3.TabIndex = 19
		Label3.Text = "Miembro:"
		' 
		' lbInscripciones
		' 
		lbInscripciones.AutoSize = True
		lbInscripciones.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
		lbInscripciones.ForeColor = Color.WhiteSmoke
		lbInscripciones.Location = New Point(12, 216)
		lbInscripciones.Name = "lbInscripciones"
		lbInscripciones.Size = New Size(120, 17)
		lbInscripciones.TabIndex = 19
		lbInscripciones.Text = "Inscripciones:"
		' 
		' Panel1
		' 
		Panel1.AutoScroll = True
		Panel1.Controls.Add(Panel2)
		Panel1.Location = New Point(45, 12)
		Panel1.Name = "Panel1"
		Panel1.Size = New Size(426, 521)
		Panel1.TabIndex = 40
		' 
		' FormPagopopup
		' 
		AutoScaleDimensions = New SizeF(7F, 15F)
		AutoScaleMode = AutoScaleMode.Font
		BackColor = Color.FromArgb(CByte(33), CByte(31), CByte(45))
		ClientSize = New Size(998, 609)
		Controls.Add(Panel1)
		Controls.Add(TabControl1)
		Controls.Add(GroupBox1)
		Controls.Add(btnCancelar)
		Controls.Add(btnGuardar)
		Controls.Add(Label10)
		Name = "FormPagopopup"
		Text = "FormPagospopup"
		GroupBox1.ResumeLayout(False)
		TabControl1.ResumeLayout(False)
		TabPage2.ResumeLayout(False)
		Panel2.ResumeLayout(False)
		Panel2.PerformLayout()
		CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
		Panel1.ResumeLayout(False)
		ResumeLayout(False)
		PerformLayout()
	End Sub
	Friend WithEvents Label2 As Label
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents cbEstadoElemento As ComboBox
	Friend WithEvents Label10 As Label
	Friend WithEvents dtpNac As DateTimePicker
	Friend WithEvents CheckBox1 As CheckBox
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents RichTextBox1 As RichTextBox
	Friend WithEvents TabControl1 As TabControl
	Friend WithEvents TabPage2 As TabPage
	Friend WithEvents Panel2 As Panel
	Friend WithEvents Panel1 As Panel
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents Label3 As Label
	Friend WithEvents ListBox1 As ListBox
	Friend WithEvents lbInscripciones As Label
	Friend WithEvents CheckedListBox1 As CheckedListBox
	Friend WithEvents DataGridView1 As DataGridView
End Class
