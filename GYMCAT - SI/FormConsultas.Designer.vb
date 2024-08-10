<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormConsultas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        DataGridView1 = New DataGridView()
        GroupBox1 = New GroupBox()
        Label1 = New Label()
        Panel1 = New Panel()
        btnGuardar = New Button()
        Splitter1 = New Splitter()
        rbMiembrosenCursos = New RadioButton()
        rbMiembrosconDeudas = New RadioButton()
        rbMejoresMiembros = New RadioButton()
        rbElementosenCursos = New RadioButton()
        ComboBox1 = New ComboBox()
        DateTimePicker1 = New DateTimePicker()
        ComboBox2 = New ComboBox()
        ComboBox3 = New ComboBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(28, 377)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(579, 260)
        DataGridView1.TabIndex = 0
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(DateTimePicker1)
        GroupBox1.Controls.Add(ComboBox3)
        GroupBox1.Controls.Add(ComboBox2)
        GroupBox1.Controls.Add(ComboBox1)
        GroupBox1.Controls.Add(btnGuardar)
        GroupBox1.Controls.Add(Panel1)
        GroupBox1.Font = New Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox1.ForeColor = Color.White
        GroupBox1.Location = New Point(28, 76)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(579, 281)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Elegir tipo de Consulta:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Cascadia Mono SemiBold", 20F, FontStyle.Bold)
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(27, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(159, 35)
        Label1.TabIndex = 12
        Label1.Text = "Consultas"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(rbElementosenCursos)
        Panel1.Controls.Add(rbMejoresMiembros)
        Panel1.Controls.Add(rbMiembrosconDeudas)
        Panel1.Controls.Add(rbMiembrosenCursos)
        Panel1.Location = New Point(29, 37)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(233, 218)
        Panel1.TabIndex = 0
        ' 
        ' btnGuardar
        ' 
        btnGuardar.BackColor = Color.FromArgb(CByte(239), CByte(41), CByte(84))
        btnGuardar.FlatStyle = FlatStyle.Popup
        btnGuardar.Font = New Font("Cascadia Mono SemiBold", 12F, FontStyle.Bold)
        btnGuardar.ForeColor = Color.WhiteSmoke
        btnGuardar.ImageAlign = ContentAlignment.MiddleRight
        btnGuardar.Location = New Point(281, 211)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(250, 44)
        btnGuardar.TabIndex = 33
        btnGuardar.Text = "Ejecutar consulta >"
        btnGuardar.UseVisualStyleBackColor = False
        ' 
        ' Splitter1
        ' 
        Splitter1.Location = New Point(0, 0)
        Splitter1.Name = "Splitter1"
        Splitter1.Size = New Size(3, 649)
        Splitter1.TabIndex = 13
        Splitter1.TabStop = False
        ' 
        ' rbMiembrosenCursos
        ' 
        rbMiembrosenCursos.AutoSize = True
        rbMiembrosenCursos.Location = New Point(23, 18)
        rbMiembrosenCursos.Name = "rbMiembrosenCursos"
        rbMiembrosenCursos.Size = New Size(151, 20)
        rbMiembrosenCursos.TabIndex = 0
        rbMiembrosenCursos.TabStop = True
        rbMiembrosenCursos.Text = "Miembros en Cursos"
        rbMiembrosenCursos.UseVisualStyleBackColor = True
        ' 
        ' rbMiembrosconDeudas
        ' 
        rbMiembrosconDeudas.AutoSize = True
        rbMiembrosconDeudas.Location = New Point(23, 53)
        rbMiembrosconDeudas.Name = "rbMiembrosconDeudas"
        rbMiembrosconDeudas.Size = New Size(158, 20)
        rbMiembrosconDeudas.TabIndex = 0
        rbMiembrosconDeudas.TabStop = True
        rbMiembrosconDeudas.Text = "Membresías a vencer"
        rbMiembrosconDeudas.UseVisualStyleBackColor = True
        ' 
        ' rbMejoresMiembros
        ' 
        rbMejoresMiembros.AutoSize = True
        rbMejoresMiembros.Location = New Point(23, 88)
        rbMejoresMiembros.Name = "rbMejoresMiembros"
        rbMejoresMiembros.Size = New Size(137, 20)
        rbMejoresMiembros.TabIndex = 0
        rbMejoresMiembros.TabStop = True
        rbMejoresMiembros.Text = "Mejores Miembros"
        rbMejoresMiembros.UseVisualStyleBackColor = True
        ' 
        ' rbElementosenCursos
        ' 
        rbElementosenCursos.AutoSize = True
        rbElementosenCursos.Location = New Point(23, 123)
        rbElementosenCursos.Name = "rbElementosenCursos"
        rbElementosenCursos.Size = New Size(158, 20)
        rbElementosenCursos.TabIndex = 0
        rbElementosenCursos.TabStop = True
        rbElementosenCursos.Text = "Elementos en Cursos"
        rbElementosenCursos.UseVisualStyleBackColor = True
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(281, 53)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(250, 24)
        ComboBox1.TabIndex = 34
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Format = DateTimePickerFormat.Short
        DateTimePicker1.Location = New Point(282, 89)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(249, 21)
        DateTimePicker1.TabIndex = 35
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(281, 123)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(250, 24)
        ComboBox2.TabIndex = 34
        ' 
        ' ComboBox3
        ' 
        ComboBox3.FormattingEnabled = True
        ComboBox3.Location = New Point(281, 159)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(250, 24)
        ComboBox3.TabIndex = 34
        ' 
        ' FormConsultas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(33), CByte(31), CByte(45))
        ClientSize = New Size(635, 649)
        Controls.Add(Splitter1)
        Controls.Add(Label1)
        Controls.Add(GroupBox1)
        Controls.Add(DataGridView1)
        Name = "FormConsultas"
        Text = "FormConsultas"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnGuardar As Button
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents rbElementosenCursos As RadioButton
    Friend WithEvents rbMejoresMiembros As RadioButton
    Friend WithEvents rbMiembrosconDeudas As RadioButton
    Friend WithEvents rbMiembrosenCursos As RadioButton
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
End Class
