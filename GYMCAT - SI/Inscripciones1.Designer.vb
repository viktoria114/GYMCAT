<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Inscripciones1
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
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        GroupBox2 = New GroupBox()
        cbOpciones2 = New ComboBox()
        dgvListadoMiembros = New DataGridView()
        tbBuscar = New TextBox()
        btnCursosMiembro = New Button()
        cbOpciones1 = New ComboBox()
        btnAgregar = New Button()
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        Label8 = New Label()
        lbDiasCurso = New Label()
        lbIncritosCurso = New Label()
        lbPrecioCurso = New Label()
        lbProfesorCurso = New Label()
        lbHorariosCurso = New Label()
        lbCursos = New Label()
        Label3 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label2 = New Label()
        GroupBox2.SuspendLayout()
        CType(dgvListadoMiembros, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(cbOpciones2)
        GroupBox2.Controls.Add(dgvListadoMiembros)
        GroupBox2.Controls.Add(tbBuscar)
        GroupBox2.Controls.Add(btnCursosMiembro)
        GroupBox2.Font = New Font("Cascadia Mono", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox2.ForeColor = Color.White
        GroupBox2.Location = New Point(27, 96)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(406, 456)
        GroupBox2.TabIndex = 5
        GroupBox2.TabStop = False
        GroupBox2.Text = "Listado de Miembros"
        ' 
        ' cbOpciones2
        ' 
        cbOpciones2.FormattingEnabled = True
        cbOpciones2.Items.AddRange(New Object() {"Nombre", "Apellido", "DNI"})
        cbOpciones2.Location = New Point(248, 40)
        cbOpciones2.Name = "cbOpciones2"
        cbOpciones2.Size = New Size(145, 24)
        cbOpciones2.TabIndex = 25
        ' 
        ' dgvListadoMiembros
        ' 
        dgvListadoMiembros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvListadoMiembros.BackgroundColor = SystemColors.ButtonShadow
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = SystemColors.Control
        DataGridViewCellStyle4.Font = New Font("Cascadia Mono", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle4.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = Color.Black
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        dgvListadoMiembros.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        dgvListadoMiembros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = SystemColors.Window
        DataGridViewCellStyle5.Font = New Font("Cascadia Mono", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle5.ForeColor = Color.White
        DataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.False
        dgvListadoMiembros.DefaultCellStyle = DataGridViewCellStyle5
        dgvListadoMiembros.Location = New Point(15, 89)
        dgvListadoMiembros.MultiSelect = False
        dgvListadoMiembros.Name = "dgvListadoMiembros"
        DataGridViewCellStyle6.ForeColor = Color.Black
        dgvListadoMiembros.RowsDefaultCellStyle = DataGridViewCellStyle6
        dgvListadoMiembros.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvListadoMiembros.Size = New Size(378, 308)
        dgvListadoMiembros.TabIndex = 6
        ' 
        ' tbBuscar
        ' 
        tbBuscar.Location = New Point(15, 42)
        tbBuscar.Name = "tbBuscar"
        tbBuscar.Size = New Size(215, 21)
        tbBuscar.TabIndex = 4
        ' 
        ' btnCursosMiembro
        ' 
        btnCursosMiembro.BackColor = Color.FromArgb(CByte(239), CByte(41), CByte(84))
        btnCursosMiembro.FlatStyle = FlatStyle.Popup
        btnCursosMiembro.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
        btnCursosMiembro.ForeColor = Color.White
        'btnCursosMiembro.Image = My.Resources.Resources.boton_editar
        btnCursosMiembro.ImageAlign = ContentAlignment.MiddleRight
        btnCursosMiembro.Location = New Point(15, 403)
        btnCursosMiembro.Name = "btnCursosMiembro"
        btnCursosMiembro.Size = New Size(378, 44)
        btnCursosMiembro.TabIndex = 8
        btnCursosMiembro.Text = "Info de Cursos Incripto"
        btnCursosMiembro.TextAlign = ContentAlignment.MiddleLeft
        btnCursosMiembro.UseVisualStyleBackColor = False
        ' 
        ' cbOpciones1
        ' 
        cbOpciones1.FormattingEnabled = True
        cbOpciones1.Location = New Point(72, 39)
        cbOpciones1.Name = "cbOpciones1"
        cbOpciones1.Size = New Size(214, 24)
        cbOpciones1.TabIndex = 5
        ' 
        ' btnAgregar
        ' 
        btnAgregar.BackColor = Color.FromArgb(CByte(239), CByte(41), CByte(84))
        btnAgregar.FlatStyle = FlatStyle.Popup
        btnAgregar.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
        btnAgregar.ForeColor = Color.WhiteSmoke
        ' btnAgregar.Image = My.Resources.Resources.agregar
        btnAgregar.ImageAlign = ContentAlignment.MiddleRight
        btnAgregar.Location = New Point(458, 499)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(349, 44)
        btnAgregar.TabIndex = 6
        btnAgregar.Text = "Agregar al curso"
        btnAgregar.TextAlign = ContentAlignment.MiddleLeft
        btnAgregar.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Cascadia Mono SemiBold", 20.0F, FontStyle.Bold)
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(27, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(223, 35)
        Label1.TabIndex = 11
        Label1.Text = "Inscripciones"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(lbDiasCurso)
        GroupBox1.Controls.Add(lbIncritosCurso)
        GroupBox1.Controls.Add(lbPrecioCurso)
        GroupBox1.Controls.Add(lbProfesorCurso)
        GroupBox1.Controls.Add(lbHorariosCurso)
        GroupBox1.Controls.Add(lbCursos)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(cbOpciones1)
        GroupBox1.Font = New Font("Cascadia Mono", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox1.ForeColor = Color.White
        GroupBox1.Location = New Point(458, 96)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(349, 397)
        GroupBox1.TabIndex = 7
        GroupBox1.TabStop = False
        GroupBox1.Text = "Cursos"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Cascadia Mono SemiBold", 14.0F)
        Label8.ForeColor = SystemColors.Control
        Label8.Location = New Point(54, 187)
        Label8.Name = "Label8"
        Label8.Size = New Size(133, 25)
        Label8.TabIndex = 25
        Label8.Text = "Inscriptos:"
        ' 
        ' lbDiasCurso
        ' 
        lbDiasCurso.AutoSize = True
        lbDiasCurso.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
        lbDiasCurso.ForeColor = SystemColors.Control
        lbDiasCurso.Location = New Point(232, 220)
        lbDiasCurso.Name = "lbDiasCurso"
        lbDiasCurso.Size = New Size(56, 17)
        lbDiasCurso.TabIndex = 24
        lbDiasCurso.Text = "******"
        ' 
        ' lbIncritosCurso
        ' 
        lbIncritosCurso.AutoSize = True
        lbIncritosCurso.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
        lbIncritosCurso.ForeColor = SystemColors.Control
        lbIncritosCurso.Location = New Point(232, 194)
        lbIncritosCurso.Name = "lbIncritosCurso"
        lbIncritosCurso.Size = New Size(56, 17)
        lbIncritosCurso.TabIndex = 23
        lbIncritosCurso.Text = "******"
        ' 
        ' lbPrecioCurso
        ' 
        lbPrecioCurso.AutoSize = True
        lbPrecioCurso.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
        lbPrecioCurso.ForeColor = SystemColors.Control
        lbPrecioCurso.Location = New Point(232, 145)
        lbPrecioCurso.Name = "lbPrecioCurso"
        lbPrecioCurso.Size = New Size(56, 17)
        lbPrecioCurso.TabIndex = 22
        lbPrecioCurso.Text = "******"
        ' 
        ' lbProfesorCurso
        ' 
        lbProfesorCurso.AutoSize = True
        lbProfesorCurso.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
        lbProfesorCurso.ForeColor = SystemColors.Control
        lbProfesorCurso.Location = New Point(232, 245)
        lbProfesorCurso.Name = "lbProfesorCurso"
        lbProfesorCurso.Size = New Size(56, 17)
        lbProfesorCurso.TabIndex = 21
        lbProfesorCurso.Text = "******"
        ' 
        ' lbHorariosCurso
        ' 
        lbHorariosCurso.AutoSize = True
        lbHorariosCurso.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
        lbHorariosCurso.ForeColor = SystemColors.Control
        lbHorariosCurso.Location = New Point(232, 121)
        lbHorariosCurso.Name = "lbHorariosCurso"
        lbHorariosCurso.Size = New Size(56, 17)
        lbHorariosCurso.TabIndex = 20
        lbHorariosCurso.Text = "******"
        ' 
        ' lbCursos
        ' 
        lbCursos.AutoSize = True
        lbCursos.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
        lbCursos.ForeColor = SystemColors.Control
        lbCursos.Location = New Point(232, 97)
        lbCursos.Name = "lbCursos"
        lbCursos.Size = New Size(56, 17)
        lbCursos.TabIndex = 19
        lbCursos.Text = "******"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Cascadia Mono SemiBold", 14.0F)
        Label3.ForeColor = SystemColors.Control
        Label3.Location = New Point(54, 237)
        Label3.Name = "Label3"
        Label3.Size = New Size(111, 25)
        Label3.TabIndex = 18
        Label3.Text = "Profesor:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Cascadia Mono SemiBold", 14.0F)
        Label7.ForeColor = SystemColors.Control
        Label7.Location = New Point(54, 212)
        Label7.Name = "Label7"
        Label7.Size = New Size(166, 25)
        Label7.TabIndex = 17
        Label7.Text = "Dias de clase:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Cascadia Mono SemiBold", 14.0F)
        Label6.ForeColor = SystemColors.Control
        Label6.Location = New Point(54, 137)
        Label6.Name = "Label6"
        Label6.Size = New Size(89, 25)
        Label6.TabIndex = 16
        Label6.Text = "Precio:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Cascadia Mono SemiBold", 14.0F)
        Label5.ForeColor = SystemColors.Control
        Label5.Location = New Point(54, 162)
        Label5.Name = "Label5"
        Label5.Size = New Size(133, 25)
        Label5.TabIndex = 15
        Label5.Text = "Cantidad de"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Cascadia Mono SemiBold", 14.0F)
        Label4.ForeColor = SystemColors.Control
        Label4.Location = New Point(54, 114)
        Label4.Name = "Label4"
        Label4.Size = New Size(111, 25)
        Label4.TabIndex = 14
        Label4.Text = "Horarios:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Cascadia Mono SemiBold", 14.0F)
        Label2.ForeColor = SystemColors.Control
        Label2.Location = New Point(54, 89)
        Label2.Name = "Label2"
        Label2.Size = New Size(78, 25)
        Label2.TabIndex = 12
        Label2.Text = "Curso:"
        ' 
        ' Inscripciones1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(33), CByte(31), CByte(45))
        ClientSize = New Size(832, 579)
        Controls.Add(GroupBox1)
        Controls.Add(Label1)
        Controls.Add(btnAgregar)
        Controls.Add(GroupBox2)
        Name = "Inscripciones1"
        Text = "Inscripciones1"
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(dgvListadoMiembros, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnCursosMiembro As Button
    Friend WithEvents tbBuscar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbOpciones1 As ComboBox
    Friend WithEvents dgvListadoMiembros As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbDiasCurso As Label
    Friend WithEvents lbIncritosCurso As Label
    Friend WithEvents lbPrecioCurso As Label
    Friend WithEvents lbProfesorCurso As Label
    Friend WithEvents lbHorariosCurso As Label
    Friend WithEvents lbCursos As Label
    Friend WithEvents cbOpciones2 As ComboBox
    Friend WithEvents Label8 As Label
End Class
