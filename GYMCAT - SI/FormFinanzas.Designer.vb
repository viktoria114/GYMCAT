<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormFinanzas
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
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

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle13 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As DataGridViewCellStyle = New DataGridViewCellStyle()
        dgvListadoFinanzas = New DataGridView()
        GroupBox2 = New GroupBox()
        Label2 = New Label()
        cbMostrar = New ComboBox()
        btnAgregar = New Button()
        btnBorrar = New Button()
        btnEditar = New Button()
        Label1 = New Label()
        CType(dgvListadoFinanzas, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgvListadoFinanzas
        ' 
        dgvListadoFinanzas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvListadoFinanzas.BackgroundColor = SystemColors.ButtonShadow
        DataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = SystemColors.Control
        DataGridViewCellStyle13.Font = New Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle13.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle13.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = Color.Black
        DataGridViewCellStyle13.WrapMode = DataGridViewTriState.True
        dgvListadoFinanzas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
        dgvListadoFinanzas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = SystemColors.Window
        DataGridViewCellStyle14.Font = New Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle14.ForeColor = Color.White
        DataGridViewCellStyle14.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = DataGridViewTriState.False
        dgvListadoFinanzas.DefaultCellStyle = DataGridViewCellStyle14
        dgvListadoFinanzas.Location = New Point(19, 64)
        dgvListadoFinanzas.MultiSelect = False
        dgvListadoFinanzas.Name = "dgvListadoFinanzas"
        dgvListadoFinanzas.ReadOnly = True
        DataGridViewCellStyle15.ForeColor = Color.Black
        dgvListadoFinanzas.RowsDefaultCellStyle = DataGridViewCellStyle15
        dgvListadoFinanzas.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvListadoFinanzas.Size = New Size(739, 379)
        dgvListadoFinanzas.TabIndex = 3
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Controls.Add(cbMostrar)
        GroupBox2.Controls.Add(dgvListadoFinanzas)
        GroupBox2.Font = New Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox2.ForeColor = Color.White
        GroupBox2.Location = New Point(27, 158)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(785, 456)
        GroupBox2.TabIndex = 5
        GroupBox2.TabStop = False
        GroupBox2.Text = "Listado de Movimientos"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(19, 28)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 16)
        Label2.TabIndex = 6
        Label2.Text = "Mostrar:"
        ' 
        ' cbMostrar
        ' 
        cbMostrar.FormattingEnabled = True
        cbMostrar.Items.AddRange(New Object() {"Ingresos", "Egresos", "Todos"})
        cbMostrar.Location = New Point(84, 24)
        cbMostrar.Name = "cbMostrar"
        cbMostrar.Size = New Size(99, 24)
        cbMostrar.TabIndex = 5
        cbMostrar.Text = "Nombre"
        ' 
        ' btnAgregar
        ' 
        btnAgregar.BackColor = Color.FromArgb(CByte(239), CByte(41), CByte(84))
        btnAgregar.FlatStyle = FlatStyle.Popup
        btnAgregar.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
        btnAgregar.ForeColor = Color.WhiteSmoke
        btnAgregar.Image = My.Resources.Resources.icono_item_agregar
        btnAgregar.ImageAlign = ContentAlignment.MiddleRight
        btnAgregar.Location = New Point(27, 84)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(101, 44)
        btnAgregar.TabIndex = 6
        btnAgregar.Text = "Agregar"
        btnAgregar.TextAlign = ContentAlignment.MiddleLeft
        btnAgregar.UseVisualStyleBackColor = False
        ' 
        ' btnBorrar
        ' 
        btnBorrar.BackColor = Color.FromArgb(CByte(239), CByte(41), CByte(84))
        btnBorrar.FlatStyle = FlatStyle.Popup
        btnBorrar.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
        btnBorrar.ForeColor = Color.White
        btnBorrar.Image = My.Resources.Resources.icono_item_eliminar
        btnBorrar.ImageAlign = ContentAlignment.MiddleRight
        btnBorrar.Location = New Point(241, 84)
        btnBorrar.Name = "btnBorrar"
        btnBorrar.Size = New Size(101, 44)
        btnBorrar.TabIndex = 7
        btnBorrar.Text = "Eliminar"
        btnBorrar.TextAlign = ContentAlignment.MiddleLeft
        btnBorrar.UseVisualStyleBackColor = False
        ' 
        ' btnEditar
        ' 
        btnEditar.BackColor = Color.FromArgb(CByte(239), CByte(41), CByte(84))
        btnEditar.FlatStyle = FlatStyle.Popup
        btnEditar.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
        btnEditar.ForeColor = Color.White
        btnEditar.Image = My.Resources.Resources.icono_item_editar
        btnEditar.ImageAlign = ContentAlignment.MiddleRight
        btnEditar.Location = New Point(134, 84)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(101, 44)
        btnEditar.TabIndex = 8
        btnEditar.Text = "Editar"
        btnEditar.TextAlign = ContentAlignment.MiddleLeft
        btnEditar.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Cascadia Mono SemiBold", 20F, FontStyle.Bold)
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(27, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(143, 35)
        Label1.TabIndex = 11
        Label1.Text = "Finanzas"
        ' 
        ' FormFinanzas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(33), CByte(31), CByte(45))
        ClientSize = New Size(824, 626)
        Controls.Add(Label1)
        Controls.Add(btnEditar)
        Controls.Add(btnBorrar)
        Controls.Add(btnAgregar)
        Controls.Add(GroupBox2)
        Name = "FormFinanzas"
        Text = "FormFinanzas"
        CType(dgvListadoFinanzas, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

	End Sub
	Friend WithEvents GroupBox2 As GroupBox
	Friend WithEvents btnAgregar As Button
	Friend WithEvents btnBorrar As Button
	Friend WithEvents btnEditar As Button
	Friend WithEvents Label1 As Label
	Friend WithEvents cbMostrar As ComboBox
	Public WithEvents dgvListadoFinanzas As DataGridView
	Friend WithEvents Label2 As Label
End Class