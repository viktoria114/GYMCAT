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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        dgvResultados = New DataGridView()
        GroupBox1 = New GroupBox()
        dtpMemb = New DateTimePicker()
        cbCursos = New ComboBox()
        cbMejMiemb = New ComboBox()
        cbCurMiembro = New ComboBox()
        btnEjecutar = New Button()
        Panel1 = New Panel()
        rbElementosenCursos = New RadioButton()
        rbMejoresMiembros = New RadioButton()
        rbMiembrosconDeudas = New RadioButton()
        rbMiembrosenCursos = New RadioButton()
        Label1 = New Label()
        Splitter1 = New Splitter()
        CType(dgvResultados, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgvResultados
        ' 
        dgvResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvResultados.Location = New Point(28, 377)
        dgvResultados.Name = "dgvResultados"
        dgvResultados.Size = New Size(698, 260)
        dgvResultados.TabIndex = 0
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(dtpMemb)
        GroupBox1.Controls.Add(cbCursos)
        GroupBox1.Controls.Add(cbMejMiemb)
        GroupBox1.Controls.Add(cbCurMiembro)
        GroupBox1.Controls.Add(btnEjecutar)
        GroupBox1.Controls.Add(Panel1)
        GroupBox1.Font = New Font("Cascadia Mono", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox1.ForeColor = Color.White
        GroupBox1.Location = New Point(28, 76)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(648, 281)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Elegir tipo de Consulta:"
        ' 
        ' dtpMemb
        ' 
        dtpMemb.Format = DateTimePickerFormat.Short
        dtpMemb.Location = New Point(303, 87)
        dtpMemb.Name = "dtpMemb"
        dtpMemb.Size = New Size(287, 21)
        dtpMemb.TabIndex = 35
        ' 
        ' cbCursos
        ' 
        cbCursos.FormattingEnabled = True
        cbCursos.Location = New Point(302, 157)
        cbCursos.Name = "cbCursos"
        cbCursos.Size = New Size(288, 24)
        cbCursos.TabIndex = 34
        ' 
        ' cbMejMiemb
        ' 
        cbMejMiemb.FormattingEnabled = True
        cbMejMiemb.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        cbMejMiemb.Location = New Point(302, 121)
        cbMejMiemb.Name = "cbMejMiemb"
        cbMejMiemb.Size = New Size(288, 24)
        cbMejMiemb.TabIndex = 34
        ' 
        ' cbCurMiembro
        ' 
        cbCurMiembro.FormattingEnabled = True
        cbCurMiembro.Location = New Point(302, 51)
        cbCurMiembro.Name = "cbCurMiembro"
        cbCurMiembro.Size = New Size(288, 24)
        cbCurMiembro.TabIndex = 34
        ' 
        ' btnEjecutar
        ' 
        btnEjecutar.BackColor = Color.FromArgb(CByte(239), CByte(41), CByte(84))
        btnEjecutar.FlatStyle = FlatStyle.Popup
        btnEjecutar.Font = New Font("Cascadia Mono SemiBold", 12.0F, FontStyle.Bold)
        btnEjecutar.ForeColor = Color.WhiteSmoke
        btnEjecutar.Image = My.Resources.Resources.icono_flecha_derecha_grande
        btnEjecutar.ImageAlign = ContentAlignment.MiddleRight
        btnEjecutar.Location = New Point(302, 209)
        btnEjecutar.Name = "btnEjecutar"
        btnEjecutar.Padding = New Padding(10, 0, 25, 0)
        btnEjecutar.Size = New Size(288, 44)
        btnEjecutar.TabIndex = 33
        btnEjecutar.Text = "Ejecutar consulta"
        btnEjecutar.TextImageRelation = TextImageRelation.TextBeforeImage
        btnEjecutar.UseVisualStyleBackColor = False
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
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Cascadia Mono SemiBold", 20.0F, FontStyle.Bold)
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(27, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(159, 35)
        Label1.TabIndex = 12
        Label1.Text = "Consultas"
        ' 
        ' Splitter1
        ' 
        Splitter1.Location = New Point(0, 0)
        Splitter1.Name = "Splitter1"
        Splitter1.Size = New Size(3, 649)
        Splitter1.TabIndex = 13
        Splitter1.TabStop = False
        ' 
        ' FormConsultas
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(33), CByte(31), CByte(45))
        ClientSize = New Size(750, 649)
        Controls.Add(Splitter1)
        Controls.Add(Label1)
        Controls.Add(GroupBox1)
        Controls.Add(dgvResultados)
        Name = "FormConsultas"
        Text = "FormConsultas"
        CType(dgvResultados, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub


    Friend WithEvents dgvResultados As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnEjecutar As Button
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents rbElementosenCursos As RadioButton
    Friend WithEvents rbMejoresMiembros As RadioButton
    Friend WithEvents rbMiembrosconDeudas As RadioButton
    Friend WithEvents rbMiembrosenCursos As RadioButton
    Friend WithEvents cbCurMiembro As ComboBox
    Friend WithEvents dtpMemb As DateTimePicker
    Friend WithEvents cbMejMiemb As ComboBox
    Friend WithEvents cbCursos As ComboBox
End Class
