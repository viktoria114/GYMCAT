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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormInscripciones))
		Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
		Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
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
		GroupBox1.SuspendLayout()
		CType(dgvCursosInscritos, ComponentModel.ISupportInitialize).BeginInit()
		GroupBox2.SuspendLayout()
		CType(dgvCursosDisponibles, ComponentModel.ISupportInitialize).BeginInit()
		CType(dgvListadoMiembros, ComponentModel.ISupportInitialize).BeginInit()
		SuspendLayout()
		' 
		' btnInscribir
		' 
		btnInscribir.BackColor = Color.FromArgb(CByte(239), CByte(41), CByte(84))
		btnInscribir.FlatStyle = FlatStyle.Popup
		btnInscribir.Font = New Font("Cascadia Mono SemiBold", 12F, FontStyle.Bold)
		btnInscribir.ForeColor = SystemColors.Control
		btnInscribir.Image = CType(resources.GetObject("btnInscribir.Image"), Image)
		btnInscribir.ImageAlign = ContentAlignment.MiddleLeft
		btnInscribir.Location = New Point(358, 327)
		btnInscribir.Name = "btnInscribir"
		btnInscribir.Padding = New Padding(5, 0, 0, 0)
		btnInscribir.Size = New Size(166, 41)
		btnInscribir.TabIndex = 2
		btnInscribir.Text = "Inscribir"
		btnInscribir.UseVisualStyleBackColor = False
		' 
		' btnDesinscribir
		' 
		btnDesinscribir.BackColor = Color.FromArgb(CByte(239), CByte(41), CByte(84))
		btnDesinscribir.FlatStyle = FlatStyle.Popup
		btnDesinscribir.Font = New Font("Cascadia Mono SemiBold", 12F, FontStyle.Bold)
		btnDesinscribir.ForeColor = SystemColors.Control
		btnDesinscribir.Image = CType(resources.GetObject("btnDesinscribir.Image"), Image)
		btnDesinscribir.ImageAlign = ContentAlignment.MiddleLeft
		btnDesinscribir.Location = New Point(358, 375)
		btnDesinscribir.Name = "btnDesinscribir"
		btnDesinscribir.Padding = New Padding(5, 0, 0, 0)
		btnDesinscribir.Size = New Size(166, 41)
		btnDesinscribir.TabIndex = 2
		btnDesinscribir.Text = "  Desinscribir"
		btnDesinscribir.UseVisualStyleBackColor = False
		' 
		' GroupBox1
		' 
		GroupBox1.Controls.Add(dgvCursosInscritos)
		GroupBox1.Font = New Font("Cascadia Mono", 9F)
		GroupBox1.ForeColor = SystemColors.ButtonHighlight
		GroupBox1.Location = New Point(27, 270)
		GroupBox1.Name = "GroupBox1"
		GroupBox1.Size = New Size(325, 248)
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
		dgvCursosInscritos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
		dgvCursosInscritos.Location = New Point(6, 20)
		dgvCursosInscritos.Name = "dgvCursosInscritos"
		dgvCursosInscritos.ReadOnly = True
		dgvCursosInscritos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
		dgvCursosInscritos.Size = New Size(313, 222)
		dgvCursosInscritos.TabIndex = 0
		' 
		' GroupBox2
		' 
		GroupBox2.Controls.Add(dgvCursosDisponibles)
		GroupBox2.Font = New Font("Cascadia Mono", 9F)
		GroupBox2.ForeColor = SystemColors.ButtonHighlight
		GroupBox2.Location = New Point(530, 270)
		GroupBox2.Name = "GroupBox2"
		GroupBox2.Size = New Size(262, 248)
		GroupBox2.TabIndex = 3
		GroupBox2.TabStop = False
		GroupBox2.Text = "Cursos Disponibes"
		' 
		' dgvCursosDisponibles
		' 
		dgvCursosDisponibles.AllowDrop = True
		dgvCursosDisponibles.AllowUserToAddRows = False
		dgvCursosDisponibles.AllowUserToDeleteRows = False
		dgvCursosDisponibles.AllowUserToOrderColumns = True
		dgvCursosDisponibles.AllowUserToResizeRows = False
		dgvCursosDisponibles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
		dgvCursosDisponibles.Location = New Point(6, 20)
		dgvCursosDisponibles.Name = "dgvCursosDisponibles"
		dgvCursosDisponibles.SelectionMode = DataGridViewSelectionMode.FullRowSelect
		dgvCursosDisponibles.Size = New Size(250, 222)
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
		DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle1.BackColor = SystemColors.Control
		DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F)
		DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
		DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
		DataGridViewCellStyle1.SelectionForeColor = Color.Black
		DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
		dgvListadoMiembros.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
		dgvListadoMiembros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
		dgvListadoMiembros.Location = New Point(27, 91)
		dgvListadoMiembros.MultiSelect = False
		dgvListadoMiembros.Name = "dgvListadoMiembros"
		dgvListadoMiembros.ReadOnly = True
		DataGridViewCellStyle2.ForeColor = Color.Black
		dgvListadoMiembros.RowsDefaultCellStyle = DataGridViewCellStyle2
		dgvListadoMiembros.SelectionMode = DataGridViewSelectionMode.FullRowSelect
		dgvListadoMiembros.Size = New Size(765, 173)
		dgvListadoMiembros.TabIndex = 6
		' 
		' tbBuscar
		' 
		tbBuscar.Location = New Point(82, 48)
		tbBuscar.Name = "tbBuscar"
		tbBuscar.Size = New Size(442, 23)
		tbBuscar.TabIndex = 4
		' 
		' btnGuardar
		' 
		btnGuardar.BackColor = Color.FromArgb(CByte(239), CByte(41), CByte(84))
		btnGuardar.Enabled = False
		btnGuardar.FlatStyle = FlatStyle.Popup
		btnGuardar.Font = New Font("Cascadia Mono SemiBold", 12F, FontStyle.Bold)
		btnGuardar.ForeColor = SystemColors.Control
		btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), Image)
		btnGuardar.ImageAlign = ContentAlignment.MiddleLeft
		btnGuardar.Location = New Point(358, 471)
		btnGuardar.Name = "btnGuardar"
		btnGuardar.Padding = New Padding(5, 0, 0, 0)
		btnGuardar.Size = New Size(166, 41)
		btnGuardar.TabIndex = 2
		btnGuardar.Text = "Guardar"
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
		btnCancelar.Location = New Point(358, 423)
		btnCancelar.Name = "btnCancelar"
		btnCancelar.Padding = New Padding(5, 0, 0, 0)
		btnCancelar.Size = New Size(166, 41)
		btnCancelar.TabIndex = 2
		btnCancelar.Text = "Cancelar"
		btnCancelar.UseVisualStyleBackColor = False
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
End Class
