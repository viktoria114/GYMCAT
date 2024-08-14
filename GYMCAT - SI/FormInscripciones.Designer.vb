<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormInscripciones
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
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        btnInscribir = New Button()
        btnDesinscribir = New Button()
        GroupBox1 = New GroupBox()
        dgvCursosInscritos = New DataGridView()
        GroupBox2 = New GroupBox()
        dgvCursosDisponibles = New DataGridView()
        lbProfesorCurso = New Label()
        lbDiasCurso = New Label()
        lbPrecioCurso = New Label()
        lbHorariosCurso = New Label()
        lbCursos = New Label()
        cbOpciones = New ComboBox()
        dgvListadoMiembros = New DataGridView()
        tbBuscar = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        GroupBox1.SuspendLayout()
        CType(dgvCursosInscritos, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        CType(dgvCursosDisponibles, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvListadoMiembros, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnInscribir
        ' 
        btnInscribir.Enabled = False
        btnInscribir.Location = New Point(358, 339)
        btnInscribir.Name = "btnInscribir"
        btnInscribir.Size = New Size(108, 44)
        btnInscribir.TabIndex = 2
        btnInscribir.Text = "<< Inscribir"
        btnInscribir.UseVisualStyleBackColor = True
        ' 
        ' btnDesinscribir
        ' 
        btnDesinscribir.Enabled = False
        btnDesinscribir.Location = New Point(358, 389)
        btnDesinscribir.Name = "btnDesinscribir"
        btnDesinscribir.Size = New Size(108, 44)
        btnDesinscribir.TabIndex = 2
        btnDesinscribir.Text = "Desinscribir >>"
        btnDesinscribir.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(dgvCursosInscritos)
        GroupBox1.Font = New Font("Cascadia Mono", 9F)
        GroupBox1.ForeColor = SystemColors.ButtonHighlight
        GroupBox1.Location = New Point(27, 280)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(325, 238)
        GroupBox1.TabIndex = 3
        GroupBox1.TabStop = False
        GroupBox1.Text = "Cursos Inscritos"
        ' 
        ' dgvCursosInscritos
        ' 
        dgvCursosInscritos.AllowUserToAddRows = False
        dgvCursosInscritos.AllowUserToDeleteRows = False
        dgvCursosInscritos.AllowUserToResizeRows = False
        dgvCursosInscritos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Window
        DataGridViewCellStyle1.Font = New Font("Cascadia Mono", 9F)
        DataGridViewCellStyle1.ForeColor = SystemColors.ButtonHighlight
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False
        dgvCursosInscritos.DefaultCellStyle = DataGridViewCellStyle1
        dgvCursosInscritos.Location = New Point(11, 20)
        dgvCursosInscritos.MultiSelect = False
        dgvCursosInscritos.Name = "dgvCursosInscritos"
        dgvCursosInscritos.ReadOnly = True
        dgvCursosInscritos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvCursosInscritos.Size = New Size(308, 206)
        dgvCursosInscritos.TabIndex = 0
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(dgvCursosDisponibles)
        GroupBox2.Font = New Font("Cascadia Mono", 9F)
        GroupBox2.ForeColor = SystemColors.ButtonHighlight
        GroupBox2.Location = New Point(472, 280)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(320, 238)
        GroupBox2.TabIndex = 3
        GroupBox2.TabStop = False
        GroupBox2.Text = "Cursos Disponibes"
        ' 
        ' dgvCursosDisponibles
        ' 
        dgvCursosDisponibles.AllowUserToAddRows = False
        dgvCursosDisponibles.AllowUserToDeleteRows = False
        dgvCursosDisponibles.AllowUserToResizeRows = False
        dgvCursosDisponibles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Cascadia Mono", 9F)
        DataGridViewCellStyle2.ForeColor = SystemColors.ButtonHighlight
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvCursosDisponibles.DefaultCellStyle = DataGridViewCellStyle2
        dgvCursosDisponibles.Location = New Point(6, 20)
        dgvCursosDisponibles.MultiSelect = False
        dgvCursosDisponibles.Name = "dgvCursosDisponibles"
        dgvCursosDisponibles.ReadOnly = True
        dgvCursosDisponibles.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvCursosDisponibles.Size = New Size(308, 206)
        dgvCursosDisponibles.TabIndex = 0
        ' 
        ' lbProfesorCurso
        ' 
        lbProfesorCurso.AutoSize = True
        lbProfesorCurso.Font = New Font("Cascadia Mono SemiBold", 14F)
        lbProfesorCurso.ForeColor = SystemColors.Control
        lbProfesorCurso.Location = New Point(300, 551)
        lbProfesorCurso.Name = "lbProfesorCurso"
        lbProfesorCurso.Size = New Size(111, 25)
        lbProfesorCurso.TabIndex = 31
        lbProfesorCurso.Text = "Profesor:"
        ' 
        ' lbDiasCurso
        ' 
        lbDiasCurso.AutoSize = True
        lbDiasCurso.Font = New Font("Cascadia Mono SemiBold", 14F)
        lbDiasCurso.ForeColor = SystemColors.Control
        lbDiasCurso.Location = New Point(300, 521)
        lbDiasCurso.Name = "lbDiasCurso"
        lbDiasCurso.Size = New Size(166, 25)
        lbDiasCurso.TabIndex = 30
        lbDiasCurso.Text = "Dias de clase:"
        ' 
        ' lbPrecioCurso
        ' 
        lbPrecioCurso.AutoSize = True
        lbPrecioCurso.Font = New Font("Cascadia Mono SemiBold", 14F)
        lbPrecioCurso.ForeColor = SystemColors.Control
        lbPrecioCurso.Location = New Point(38, 581)
        lbPrecioCurso.Name = "lbPrecioCurso"
        lbPrecioCurso.Size = New Size(89, 25)
        lbPrecioCurso.TabIndex = 29
        lbPrecioCurso.Text = "Precio:"
        ' 
        ' lbHorariosCurso
        ' 
        lbHorariosCurso.AutoSize = True
        lbHorariosCurso.Font = New Font("Cascadia Mono SemiBold", 14F)
        lbHorariosCurso.ForeColor = SystemColors.Control
        lbHorariosCurso.Location = New Point(38, 551)
        lbHorariosCurso.Name = "lbHorariosCurso"
        lbHorariosCurso.Size = New Size(111, 25)
        lbHorariosCurso.TabIndex = 27
        lbHorariosCurso.Text = "Horarios:"
        ' 
        ' lbCursos
        ' 
        lbCursos.AutoSize = True
        lbCursos.Font = New Font("Cascadia Mono SemiBold", 14F)
        lbCursos.ForeColor = SystemColors.Control
        lbCursos.Location = New Point(38, 521)
        lbCursos.Name = "lbCursos"
        lbCursos.Size = New Size(78, 25)
        lbCursos.TabIndex = 26
        lbCursos.Text = "Curso:"
        ' 
        ' cbOpciones
        ' 
        cbOpciones.FormattingEnabled = True
        cbOpciones.Items.AddRange(New Object() {"Nombre", "Apellido", "DNI"})
        cbOpciones.Location = New Point(530, 48)
        cbOpciones.Name = "cbOpciones"
        cbOpciones.Size = New Size(176, 23)
        cbOpciones.TabIndex = 25
        ' 
        ' dgvListadoMiembros
        ' 
        dgvListadoMiembros.AllowUserToAddRows = False
        dgvListadoMiembros.AllowUserToDeleteRows = False
        dgvListadoMiembros.AllowUserToResizeRows = False
        dgvListadoMiembros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvListadoMiembros.BackgroundColor = SystemColors.ButtonShadow
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = Color.Black
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgvListadoMiembros.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgvListadoMiembros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvListadoMiembros.Location = New Point(27, 91)
        dgvListadoMiembros.MultiSelect = False
        dgvListadoMiembros.Name = "dgvListadoMiembros"
        dgvListadoMiembros.ReadOnly = True
        DataGridViewCellStyle4.ForeColor = Color.Black
        dgvListadoMiembros.RowsDefaultCellStyle = DataGridViewCellStyle4
        dgvListadoMiembros.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvListadoMiembros.Size = New Size(765, 183)
        dgvListadoMiembros.TabIndex = 6
        ' 
        ' tbBuscar
        ' 
        tbBuscar.Location = New Point(82, 48)
        tbBuscar.Name = "tbBuscar"
        tbBuscar.Size = New Size(442, 23)
        tbBuscar.TabIndex = 4
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(358, 289)
        Button1.Name = "Button1"
        Button1.Size = New Size(108, 44)
        Button1.TabIndex = 2
        Button1.Text = "Modificar Inscripciones"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(358, 439)
        Button2.Name = "Button2"
        Button2.Size = New Size(108, 44)
        Button2.TabIndex = 2
        Button2.Text = "Modificar Inscripciones"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' FormInscripciones
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(33), CByte(31), CByte(45))
        ClientSize = New Size(824, 626)
        Controls.Add(dgvListadoMiembros)
        Controls.Add(cbOpciones)
        Controls.Add(tbBuscar)
        Controls.Add(lbProfesorCurso)
        Controls.Add(lbDiasCurso)
        Controls.Add(lbPrecioCurso)
        Controls.Add(lbHorariosCurso)
        Controls.Add(lbCursos)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(btnDesinscribir)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(btnInscribir)
        Name = "FormInscripciones"
        Text = "Form2"
        GroupBox1.ResumeLayout(False)
        CType(dgvCursosInscritos, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        CType(dgvCursosDisponibles, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvListadoMiembros, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub


    Friend WithEvents btnInscribir As Button
	Friend WithEvents btnDesinscribir As Button
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents GroupBox2 As GroupBox
	Friend WithEvents dgvCursosDisponibles As DataGridView
	Friend WithEvents lbProfesorCurso As Label
	Friend WithEvents lbDiasCurso As Label
	Friend WithEvents lbPrecioCurso As Label
	Friend WithEvents lbHorariosCurso As Label
	Friend WithEvents lbCursos As Label
	Friend WithEvents cbOpciones As ComboBox
	Friend WithEvents dgvListadoMiembros As DataGridView
	Friend WithEvents tbBuscar As TextBox
	Friend WithEvents dgvCursosInscritos As DataGridView
	Friend WithEvents Button1 As Button
	Friend WithEvents Button2 As Button
End Class
