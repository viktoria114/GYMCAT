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
        DataGridView1 = New DataGridView()
        dtpFechaMov = New DateTimePicker()
        Label2 = New Label()
        Label3 = New Label()
        cbEstadoElemento = New ComboBox()
        Label8 = New Label()
        lbTitulo = New Label()
        GroupBox1 = New GroupBox()
        cbMiembros = New ComboBox()
        GroupBox2 = New GroupBox()
        cbDeudor = New CheckBox()
        TextBox1 = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        Label1 = New Label()
        Label4 = New Label()
        DateTimePicker2 = New DateTimePicker()
        DateTimePicker1 = New DateTimePicker()
        Label7 = New Label()
        Label9 = New Label()
        ComboBox2 = New ComboBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnPagar
        ' 
        btnPagar.BackColor = Color.FromArgb(CByte(239), CByte(41), CByte(84))
        btnPagar.FlatStyle = FlatStyle.Popup
        btnPagar.Font = New Font("Cascadia Mono SemiBold", 12F, FontStyle.Bold)
        btnPagar.ForeColor = Color.WhiteSmoke
        btnPagar.ImageAlign = ContentAlignment.MiddleRight
        btnPagar.Location = New Point(446, 483)
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
        btnImprimir.Location = New Point(566, 483)
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
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(506, 114)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.Size = New Size(533, 329)
        DataGridView1.TabIndex = 38
        ' 
        ' dtpFechaMov
        ' 
        dtpFechaMov.CalendarTitleBackColor = Color.FromArgb(CByte(239), CByte(41), CByte(84))
        dtpFechaMov.Format = DateTimePickerFormat.Short
        dtpFechaMov.Location = New Point(189, 27)
        dtpFechaMov.Name = "dtpFechaMov"
        dtpFechaMov.Size = New Size(183, 21)
        dtpFechaMov.TabIndex = 37
        dtpFechaMov.Value = New Date(2024, 8, 17, 0, 0, 0, 0)
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
        Label2.ForeColor = Color.WhiteSmoke
        Label2.Location = New Point(126, 29)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 17)
        Label2.TabIndex = 10
        Label2.Text = "Fecha:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
        Label3.ForeColor = Color.WhiteSmoke
        Label3.Location = New Point(64, 248)
        Label3.Name = "Label3"
        Label3.Size = New Size(72, 17)
        Label3.TabIndex = 19
        Label3.Text = "Miembro:"
        ' 
        ' cbEstadoElemento
        ' 
        cbEstadoElemento.FormattingEnabled = True
        cbEstadoElemento.Items.AddRange(New Object() {"Transferencia", "Efectivo", "Tarjeta"})
        cbEstadoElemento.Location = New Point(187, 54)
        cbEstadoElemento.Name = "cbEstadoElemento"
        cbEstadoElemento.Size = New Size(185, 24)
        cbEstadoElemento.TabIndex = 24
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
        Label8.ForeColor = Color.WhiteSmoke
        Label8.Location = New Point(62, 56)
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
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(cbEstadoElemento)
        GroupBox1.Controls.Add(dtpFechaMov)
        GroupBox1.Font = New Font("Cascadia Mono", 9F)
        GroupBox1.ForeColor = Color.White
        GroupBox1.Location = New Point(34, 114)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(405, 103)
        GroupBox1.TabIndex = 42
        GroupBox1.TabStop = False
        GroupBox1.Text = "Detalles"
        ' 
        ' cbMiembros
        ' 
        cbMiembros.FormattingEnabled = True
        cbMiembros.Items.AddRange(New Object() {"Transferencia", "Efectivo", "Tarjeta", "Cola °|°"})
        cbMiembros.Location = New Point(142, 248)
        cbMiembros.Name = "cbMiembros"
        cbMiembros.Size = New Size(264, 23)
        cbMiembros.TabIndex = 24
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(cbDeudor)
        GroupBox2.Controls.Add(TextBox1)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(Label1)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(DateTimePicker2)
        GroupBox2.Controls.Add(DateTimePicker1)
        GroupBox2.Font = New Font("Cascadia Mono", 9F)
        GroupBox2.ForeColor = Color.White
        GroupBox2.Location = New Point(34, 292)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(405, 151)
        GroupBox2.TabIndex = 43
        GroupBox2.TabStop = False
        GroupBox2.Text = "Información del Miembro"
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
        ' TextBox1
        ' 
        TextBox1.Location = New Point(189, 26)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(183, 21)
        TextBox1.TabIndex = 38
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
        ' DateTimePicker2
        ' 
        DateTimePicker2.CalendarTitleBackColor = Color.FromArgb(CByte(239), CByte(41), CByte(84))
        DateTimePicker2.Format = DateTimePickerFormat.Short
        DateTimePicker2.Location = New Point(189, 107)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(183, 21)
        DateTimePicker2.TabIndex = 37
        DateTimePicker2.Value = New Date(2024, 8, 17, 0, 0, 0, 0)
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CalendarTitleBackColor = Color.FromArgb(CByte(239), CByte(41), CByte(84))
        DateTimePicker1.Format = DateTimePickerFormat.Short
        DateTimePicker1.Location = New Point(189, 54)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(183, 21)
        DateTimePicker1.TabIndex = 37
        DateTimePicker1.Value = New Date(2024, 8, 17, 0, 0, 0, 0)
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
        Label9.Location = New Point(224, 505)
        Label9.Name = "Label9"
        Label9.Size = New Size(56, 17)
        Label9.TabIndex = 19
        Label9.Text = "Meses:"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        ComboBox2.Location = New Point(286, 504)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(120, 23)
        ComboBox2.TabIndex = 24
        ' 
        ' FormPagopopup
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(33), CByte(31), CByte(45))
        ClientSize = New Size(1081, 587)
        Controls.Add(Label7)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(ComboBox2)
        Controls.Add(cbMiembros)
        Controls.Add(lbTitulo)
        Controls.Add(DataGridView1)
        Controls.Add(Label9)
        Controls.Add(btnImprimir)
        Controls.Add(Label3)
        Controls.Add(btnPagar)
        Controls.Add(Label10)
        Name = "FormPagopopup"
        Text = "FormPagospopup"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnPagar As Button
    Friend WithEvents btnImprimir As Button
	Friend WithEvents Label10 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents dtpFechaMov As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cbEstadoElemento As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents lbTitulo As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbMiembros As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cbDeudor As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents ComboBox2 As ComboBox
End Class
