<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inscripciones2
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Label1 = New Label()
        btnDesincribir = New Button()
        btnSalir = New Button()
        dgvListadoIncripciones = New DataGridView()
        Label2 = New Label()
        CType(dgvListadoIncripciones, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
        Label1.ForeColor = Color.WhiteSmoke
        Label1.Location = New Point(12, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(256, 17)
        Label1.TabIndex = 3
        Label1.Text = "Cursos a los que esta incripto "
        ' 
        ' btnDesincribir
        ' 
        btnDesincribir.BackColor = Color.FromArgb(CByte(239), CByte(41), CByte(84))
        btnDesincribir.FlatStyle = FlatStyle.Popup
        btnDesincribir.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
        btnDesincribir.ForeColor = Color.WhiteSmoke
        btnDesincribir.ImageAlign = ContentAlignment.MiddleRight
        btnDesincribir.Location = New Point(47, 314)
        btnDesincribir.Name = "btnDesincribir"
        btnDesincribir.Size = New Size(138, 44)
        btnDesincribir.TabIndex = 16
        btnDesincribir.Text = "Desincribir del curso"
        btnDesincribir.UseVisualStyleBackColor = False
        ' 
        ' btnSalir
        ' 
        btnSalir.BackColor = Color.FromArgb(CByte(239), CByte(41), CByte(84))
        btnSalir.FlatStyle = FlatStyle.Popup
        btnSalir.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
        btnSalir.ForeColor = Color.WhiteSmoke
        btnSalir.ImageAlign = ContentAlignment.MiddleRight
        btnSalir.Location = New Point(256, 314)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(91, 44)
        btnSalir.TabIndex = 17
        btnSalir.Text = "Salir"
        btnSalir.UseVisualStyleBackColor = False
        ' 
        ' dgvListadoIncripciones
        ' 
        dgvListadoIncripciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvListadoIncripciones.BackgroundColor = SystemColors.ButtonShadow
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9.0F)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = Color.Black
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvListadoIncripciones.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvListadoIncripciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvListadoIncripciones.Location = New Point(26, 62)
        dgvListadoIncripciones.MultiSelect = False
        dgvListadoIncripciones.Name = "dgvListadoIncripciones"
        DataGridViewCellStyle2.ForeColor = Color.Black
        dgvListadoIncripciones.RowsDefaultCellStyle = DataGridViewCellStyle2
        dgvListadoIncripciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvListadoIncripciones.Size = New Size(350, 234)
        dgvListadoIncripciones.TabIndex = 18
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
        Label2.ForeColor = Color.WhiteSmoke
        Label2.Location = New Point(266, 34)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 17)
        Label2.TabIndex = 19
        Label2.Text = "******"
        ' 
        ' Inscripciones2
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(33), CByte(31), CByte(45))
        ClientSize = New Size(399, 380)
        Controls.Add(Label2)
        Controls.Add(dgvListadoIncripciones)
        Controls.Add(btnSalir)
        Controls.Add(btnDesincribir)
        Controls.Add(Label1)
        Name = "Inscripciones2"
        Text = "Inscripciones2"
        CType(dgvListadoIncripciones, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents btnDesincribir As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents dgvListadoIncripciones As DataGridView
    Friend WithEvents Label2 As Label
End Class
