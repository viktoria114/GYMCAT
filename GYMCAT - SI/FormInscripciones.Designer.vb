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
		btnGuardar = New Button()
		btnCancelar = New Button()
		GroupBox3 = New GroupBox()
		lbDesinscripciones = New Label()
		Label2 = New Label()
		lbInscripciones = New Label()
		GroupBox1.SuspendLayout()
		CType(dgvCursosInscritos, ComponentModel.ISupportInitialize).BeginInit()
		GroupBox2.SuspendLayout()
		CType(dgvCursosDisponibles, ComponentModel.ISupportInitialize).BeginInit()
		CType(dgvListadoMiembros, ComponentModel.ISupportInitialize).BeginInit()
		GroupBox3.SuspendLayout()
		SuspendLayout()
		' 
		' btnInscribir
		' 
		btnInscribir.BackColor = Color.FromArgb(CByte(239), CByte(41), CByte(84))
		btnInscribir.FlatStyle = FlatStyle.Popup
		btnInscribir.Font = New Font("Cascadia Mono SemiBold", 12F, FontStyle.Bold)
		btnInscribir.ForeColor = SystemColors.Control
		btnInscribir.Image = My.Resources.Resources.avance_rapido__3___1_
		btnInscribir.ImageAlign = ContentAlignment.MiddleLeft
		btnInscribir.Location = New Point(330, 329)
		btnInscribir.Name = "btnInscribir"
		btnInscribir.Padding = New Padding(5, 0, 0, 0)
		btnInscribir.Size = New Size(165, 41)
		btnInscribir.TabIndex = 2
		btnInscribir.Text = " Inscribir"
		btnInscribir.UseVisualStyleBackColor = False
		' 
		' btnDesinscribir
		' 
		btnDesinscribir.BackColor = Color.FromArgb(CByte(239), CByte(41), CByte(84))
		btnDesinscribir.FlatStyle = FlatStyle.Popup
		btnDesinscribir.Font = New Font("Cascadia Mono SemiBold", 12F, FontStyle.Bold)
		btnDesinscribir.ForeColor = SystemColors.Control
		btnDesinscribir.Image = My.Resources.Resources.avance_rapido__3_
		btnDesinscribir.ImageAlign = ContentAlignment.MiddleLeft
		btnDesinscribir.Location = New Point(330, 378)
		btnDesinscribir.Name = "btnDesinscribir"
		btnDesinscribir.Padding = New Padding(5, 0, 0, 0)
		btnDesinscribir.Size = New Size(165, 41)
		btnDesinscribir.TabIndex = 2
		btnDesinscribir.Text = "  Desinscribir"
		btnDesinscribir.UseVisualStyleBackColor = False
		' 
		' GroupBox1
		' 
		GroupBox1.Controls.Add(dgvCursosInscritos)
		GroupBox1.Font = New Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		GroupBox1.ForeColor = SystemColors.ButtonHighlight
		GroupBox1.Location = New Point(30, 319)
		GroupBox1.Name = "GroupBox1"
		GroupBox1.Size = New Size(294, 199)
		GroupBox1.TabIndex = 3
		GroupBox1.TabStop = False
		GroupBox1.Text = "Cursos Inscritos"
		' 
		' dgvCursosInscritos
		' 
		dgvCursosInscritos.AllowUserToAddRows = False
		dgvCursosInscritos.AllowUserToDeleteRows = False
		dgvCursosInscritos.AllowUserToOrderColumns = True
		dgvCursosInscritos.AllowUserToResizeRows = False
		dgvCursosInscritos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
		dgvCursosInscritos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
		dgvCursosInscritos.Location = New Point(6, 20)
		dgvCursosInscritos.MultiSelect = False
		dgvCursosInscritos.Name = "dgvCursosInscritos"
		dgvCursosInscritos.ReadOnly = True
		DataGridViewCellStyle1.ForeColor = SystemColors.ControlText
		dgvCursosInscritos.RowsDefaultCellStyle = DataGridViewCellStyle1
		dgvCursosInscritos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
		dgvCursosInscritos.Size = New Size(282, 173)
		dgvCursosInscritos.TabIndex = 0
		' 
		' GroupBox2
		' 
		GroupBox2.Controls.Add(dgvCursosDisponibles)
		GroupBox2.Font = New Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		GroupBox2.ForeColor = SystemColors.ButtonHighlight
		GroupBox2.Location = New Point(501, 319)
		GroupBox2.Name = "GroupBox2"
		GroupBox2.Size = New Size(294, 199)
		GroupBox2.TabIndex = 3
		GroupBox2.TabStop = False
		GroupBox2.Text = "Cursos Disponibes"
		' 
		' dgvCursosDisponibles
		' 
		dgvCursosDisponibles.AllowUserToAddRows = False
		dgvCursosDisponibles.AllowUserToDeleteRows = False
		dgvCursosDisponibles.AllowUserToResizeRows = False
		dgvCursosDisponibles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
		dgvCursosDisponibles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
		dgvCursosDisponibles.Location = New Point(6, 20)
		dgvCursosDisponibles.MultiSelect = False
		dgvCursosDisponibles.Name = "dgvCursosDisponibles"
		dgvCursosDisponibles.ReadOnly = True
		DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
		dgvCursosDisponibles.RowsDefaultCellStyle = DataGridViewCellStyle2
		dgvCursosDisponibles.SelectionMode = DataGridViewSelectionMode.FullRowSelect
		dgvCursosDisponibles.Size = New Size(282, 173)
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
		lbProfesorCurso.Visible = False
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
		lbDiasCurso.Visible = False
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
		lbPrecioCurso.Visible = False
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
		lbHorariosCurso.Visible = False
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
		lbCursos.Visible = False
		' 
		' cbOpciones
		' 
		cbOpciones.FormattingEnabled = True
		cbOpciones.Items.AddRange(New Object() {"Nombre", "Apellido", "DNI"})
		cbOpciones.Location = New Point(606, 94)
		cbOpciones.Name = "cbOpciones"
		cbOpciones.Size = New Size(186, 23)
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
		dgvListadoMiembros.Location = New Point(30, 123)
		dgvListadoMiembros.MultiSelect = False
		dgvListadoMiembros.Name = "dgvListadoMiembros"
		dgvListadoMiembros.ReadOnly = True
		DataGridViewCellStyle4.ForeColor = Color.Black
		dgvListadoMiembros.RowsDefaultCellStyle = DataGridViewCellStyle4
		dgvListadoMiembros.SelectionMode = DataGridViewSelectionMode.FullRowSelect
		dgvListadoMiembros.Size = New Size(570, 190)
		dgvListadoMiembros.TabIndex = 6
		' 
		' tbBuscar
		' 
		tbBuscar.Location = New Point(30, 94)
		tbBuscar.Name = "tbBuscar"
		tbBuscar.Size = New Size(570, 23)
		tbBuscar.TabIndex = 4
		' 
		' btnGuardar
		' 
		btnGuardar.BackColor = Color.FromArgb(CByte(239), CByte(41), CByte(84))
		btnGuardar.Enabled = False
		btnGuardar.FlatStyle = FlatStyle.Popup
		btnGuardar.Font = New Font("Cascadia Mono SemiBold", 12F, FontStyle.Bold)
		btnGuardar.ForeColor = SystemColors.Control
		btnGuardar.Image = My.Resources.Resources.boton_guardar__3_
		btnGuardar.ImageAlign = ContentAlignment.MiddleLeft
		btnGuardar.Location = New Point(330, 476)
		btnGuardar.Name = "btnGuardar"
		btnGuardar.Padding = New Padding(5, 0, 0, 0)
		btnGuardar.Size = New Size(165, 41)
		btnGuardar.TabIndex = 2
		btnGuardar.Text = " Guardar"
		btnGuardar.UseVisualStyleBackColor = False
		' 
		' btnCancelar
		' 
		btnCancelar.BackColor = Color.FromArgb(CByte(239), CByte(41), CByte(84))
		btnCancelar.Enabled = False
		btnCancelar.FlatStyle = FlatStyle.Popup
		btnCancelar.Font = New Font("Cascadia Mono SemiBold", 12F, FontStyle.Bold)
		btnCancelar.ForeColor = SystemColors.Control
		btnCancelar.Image = My.Resources.Resources.agregar__1__removebg_preview
		btnCancelar.ImageAlign = ContentAlignment.MiddleLeft
		btnCancelar.Location = New Point(330, 427)
		btnCancelar.Name = "btnCancelar"
		btnCancelar.Padding = New Padding(5, 0, 0, 0)
		btnCancelar.Size = New Size(165, 41)
		btnCancelar.TabIndex = 2
		btnCancelar.Text = " Cancelar"
		btnCancelar.UseVisualStyleBackColor = False
		' 
		' GroupBox3
		' 
		GroupBox3.Controls.Add(lbDesinscripciones)
		GroupBox3.Controls.Add(Label2)
		GroupBox3.Controls.Add(lbInscripciones)
		GroupBox3.Font = New Font("Cascadia Mono SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		GroupBox3.ForeColor = SystemColors.ButtonHighlight
		GroupBox3.Location = New Point(606, 123)
		GroupBox3.Name = "GroupBox3"
		GroupBox3.Size = New Size(186, 190)
		GroupBox3.TabIndex = 3
		GroupBox3.TabStop = False
		GroupBox3.Text = "Cambios sin Guardar"
		' 
		' lbDesinscripciones
		' 
		lbDesinscripciones.AutoSize = True
		lbDesinscripciones.Dock = DockStyle.Top
		lbDesinscripciones.Font = New Font("Cascadia Mono SemiBold", 10F)
		lbDesinscripciones.ForeColor = SystemColors.Control
		lbDesinscripciones.Location = New Point(3, 35)
		lbDesinscripciones.Name = "lbDesinscripciones"
		lbDesinscripciones.Size = New Size(144, 18)
		lbDesinscripciones.TabIndex = 27
		lbDesinscripciones.Text = "Desinscripciones:"
		lbDesinscripciones.Visible = False
		' 
		' Label2
		' 
		Label2.AutoSize = True
		Label2.Location = New Point(596, -258)
		Label2.Name = "Label2"
		Label2.Size = New Size(49, 16)
		Label2.TabIndex = 0
		Label2.Text = "Label1"
		' 
		' lbInscripciones
		' 
		lbInscripciones.AutoSize = True
		lbInscripciones.Dock = DockStyle.Top
		lbInscripciones.Font = New Font("Cascadia Mono SemiBold", 10F)
		lbInscripciones.ForeColor = SystemColors.Control
		lbInscripciones.Location = New Point(3, 17)
		lbInscripciones.Name = "lbInscripciones"
		lbInscripciones.Size = New Size(120, 18)
		lbInscripciones.TabIndex = 26
		lbInscripciones.Text = "Inscripciones:"
		lbInscripciones.Visible = False
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
		Controls.Add(GroupBox3)
		Controls.Add(GroupBox2)
		Controls.Add(GroupBox1)
		Controls.Add(btnDesinscribir)
		Controls.Add(btnCancelar)
		Controls.Add(btnGuardar)
		Controls.Add(btnInscribir)
		Name = "FormInscripciones"
		Text = "Form2"
		GroupBox1.ResumeLayout(False)
		CType(dgvCursosInscritos, ComponentModel.ISupportInitialize).EndInit()
		GroupBox2.ResumeLayout(False)
		CType(dgvCursosDisponibles, ComponentModel.ISupportInitialize).EndInit()
		CType(dgvListadoMiembros, ComponentModel.ISupportInitialize).EndInit()
		GroupBox3.ResumeLayout(False)
		GroupBox3.PerformLayout()
		ResumeLayout(False)
		PerformLayout()
	End Sub


	Friend WithEvents btnInscribir As Button
	Friend WithEvents btnDesinscribir As Button
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents GroupBox2 As GroupBox
	Friend WithEvents lbProfesorCurso As Label
	Friend WithEvents lbDiasCurso As Label
	Friend WithEvents lbPrecioCurso As Label
	Friend WithEvents lbHorariosCurso As Label
	Friend WithEvents lbCursos As Label
	Friend WithEvents cbOpciones As ComboBox
	Friend WithEvents dgvListadoMiembros As DataGridView
	Friend WithEvents tbBuscar As TextBox
	Friend WithEvents btnGuardar As Button
	Friend WithEvents btnCancelar As Button
	Friend WithEvents dgvCursosDisponibles As DataGridView
	Friend WithEvents dgvCursosInscritos As DataGridView
	Friend WithEvents GroupBox3 As GroupBox
	Friend WithEvents lbDesinscripciones As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents lbInscripciones As Label
End Class
