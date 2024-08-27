<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIPrincipal
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
        components = New ComponentModel.Container()
        ToolTip = New ToolTip(components)
        Button11 = New Button()
        PanelLateral = New Panel()
        btnConsultas = New Button()
        btnFinanzas = New Button()
        btnInventario = New Button()
        btnCursos = New Button()
        PanelMembresias = New Panel()
        btnInscripciones = New Button()
        btnMembresias = New Button()
        PanelEmpleados = New Panel()
        BtnHorario = New Button()
        btnEmpleados = New Button()
        PanelLogo = New Panel()
        PictureBox1 = New PictureBox()
        Panel4 = New Panel()
        Labelinfo = New Label()
        Labelbienvenido = New Label()
        PanelLateral.SuspendLayout()
        PanelMembresias.SuspendLayout()
        PanelEmpleados.SuspendLayout()
        PanelLogo.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button11
        ' 
        Button11.Dock = DockStyle.Bottom
        Button11.FlatAppearance.BorderSize = 0
        Button11.FlatStyle = FlatStyle.Flat
        Button11.ForeColor = SystemColors.Control
        Button11.Image = My.Resources.Resources.icono_pink_salir
        Button11.ImageAlign = ContentAlignment.MiddleLeft
        Button11.Location = New Point(0, 656)
        Button11.Name = "Button11"
        Button11.Padding = New Padding(35, 0, 0, 0)
        Button11.Size = New Size(191, 49)
        Button11.TabIndex = 11
        Button11.Text = "Cerrar Sesion"
        ToolTip.SetToolTip(Button11, "puto el que lea")
        Button11.UseVisualStyleBackColor = True
        ' 
        ' PanelLateral
        ' 
        PanelLateral.AutoScroll = True
        PanelLateral.BackColor = Color.FromArgb(CByte(11), CByte(7), CByte(17))
        PanelLateral.Controls.Add(btnConsultas)
        PanelLateral.Controls.Add(btnFinanzas)
        PanelLateral.Controls.Add(btnInventario)
        PanelLateral.Controls.Add(Button11)
        PanelLateral.Controls.Add(btnCursos)
        PanelLateral.Controls.Add(PanelMembresias)
        PanelLateral.Controls.Add(btnMembresias)
        PanelLateral.Controls.Add(PanelEmpleados)
        PanelLateral.Controls.Add(btnEmpleados)
        PanelLateral.Controls.Add(PanelLogo)
        PanelLateral.Dock = DockStyle.Left
        PanelLateral.Location = New Point(0, 0)
        PanelLateral.Name = "PanelLateral"
        PanelLateral.Size = New Size(191, 705)
        PanelLateral.TabIndex = 9
        ' 
        ' btnConsultas
        ' 
        btnConsultas.Dock = DockStyle.Top
        btnConsultas.FlatAppearance.BorderSize = 0
        btnConsultas.FlatStyle = FlatStyle.Flat
        btnConsultas.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        btnConsultas.ForeColor = SystemColors.Control
        btnConsultas.Location = New Point(0, 404)
        btnConsultas.Name = "btnConsultas"
        btnConsultas.Padding = New Padding(10, 0, 0, 0)
        btnConsultas.Size = New Size(191, 40)
        btnConsultas.TabIndex = 15
        btnConsultas.Text = "Consultas"
        btnConsultas.TextAlign = ContentAlignment.MiddleLeft
        btnConsultas.UseVisualStyleBackColor = True
        ' 
        ' btnFinanzas
        ' 
        btnFinanzas.Dock = DockStyle.Top
        btnFinanzas.FlatAppearance.BorderSize = 0
        btnFinanzas.FlatStyle = FlatStyle.Flat
        btnFinanzas.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        btnFinanzas.ForeColor = SystemColors.Control
        btnFinanzas.Location = New Point(0, 364)
        btnFinanzas.Name = "btnFinanzas"
        btnFinanzas.Padding = New Padding(10, 0, 0, 0)
        btnFinanzas.Size = New Size(191, 40)
        btnFinanzas.TabIndex = 13
        btnFinanzas.Text = "Finanzas"
        btnFinanzas.TextAlign = ContentAlignment.MiddleLeft
        btnFinanzas.UseVisualStyleBackColor = True
        ' 
        ' btnInventario
        ' 
        btnInventario.Dock = DockStyle.Top
        btnInventario.FlatAppearance.BorderSize = 0
        btnInventario.FlatStyle = FlatStyle.Flat
        btnInventario.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        btnInventario.ForeColor = SystemColors.Control
        btnInventario.Location = New Point(0, 324)
        btnInventario.Name = "btnInventario"
        btnInventario.Padding = New Padding(10, 0, 0, 0)
        btnInventario.Size = New Size(191, 40)
        btnInventario.TabIndex = 12
        btnInventario.Text = "Inventario"
        btnInventario.TextAlign = ContentAlignment.MiddleLeft
        btnInventario.UseVisualStyleBackColor = True
        ' 
        ' btnCursos
        ' 
        btnCursos.Dock = DockStyle.Top
        btnCursos.FlatAppearance.BorderSize = 0
        btnCursos.FlatStyle = FlatStyle.Flat
        btnCursos.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        btnCursos.ForeColor = SystemColors.Control
        btnCursos.Location = New Point(0, 284)
        btnCursos.Name = "btnCursos"
        btnCursos.Padding = New Padding(10, 0, 0, 0)
        btnCursos.Size = New Size(191, 40)
        btnCursos.TabIndex = 5
        btnCursos.Text = "Cursos"
        btnCursos.TextAlign = ContentAlignment.MiddleLeft
        btnCursos.UseVisualStyleBackColor = True
        ' 
        ' PanelMembresias
        ' 
        PanelMembresias.BackColor = Color.FromArgb(CByte(11), CByte(7), CByte(17))
        PanelMembresias.Controls.Add(btnInscripciones)
        PanelMembresias.Dock = DockStyle.Top
        PanelMembresias.Location = New Point(0, 252)
        PanelMembresias.Name = "PanelMembresias"
        PanelMembresias.Size = New Size(191, 32)
        PanelMembresias.TabIndex = 4
        ' 
        ' btnInscripciones
        ' 
        btnInscripciones.BackColor = Color.FromArgb(CByte(35), CByte(32), CByte(39))
        btnInscripciones.Dock = DockStyle.Top
        btnInscripciones.FlatAppearance.BorderSize = 0
        btnInscripciones.FlatStyle = FlatStyle.Flat
        btnInscripciones.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        btnInscripciones.ForeColor = SystemColors.Control
        btnInscripciones.Location = New Point(0, 0)
        btnInscripciones.Name = "btnInscripciones"
        btnInscripciones.Padding = New Padding(30, 0, 0, 0)
        btnInscripciones.Size = New Size(191, 30)
        btnInscripciones.TabIndex = 1
        btnInscripciones.Text = "Inscripciones"
        btnInscripciones.TextAlign = ContentAlignment.MiddleLeft
        btnInscripciones.UseVisualStyleBackColor = False
        ' 
        ' btnMembresias
        ' 
        btnMembresias.Dock = DockStyle.Top
        btnMembresias.FlatAppearance.BorderSize = 0
        btnMembresias.FlatStyle = FlatStyle.Flat
        btnMembresias.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        btnMembresias.ForeColor = SystemColors.Control
        btnMembresias.Location = New Point(0, 212)
        btnMembresias.Name = "btnMembresias"
        btnMembresias.Padding = New Padding(10, 0, 0, 0)
        btnMembresias.Size = New Size(191, 40)
        btnMembresias.TabIndex = 3
        btnMembresias.Text = "Membresias"
        btnMembresias.TextAlign = ContentAlignment.MiddleLeft
        btnMembresias.UseVisualStyleBackColor = True
        ' 
        ' PanelEmpleados
        ' 
        PanelEmpleados.Controls.Add(BtnHorario)
        PanelEmpleados.Dock = DockStyle.Top
        PanelEmpleados.Location = New Point(0, 180)
        PanelEmpleados.Name = "PanelEmpleados"
        PanelEmpleados.Size = New Size(191, 32)
        PanelEmpleados.TabIndex = 2
        ' 
        ' BtnHorario
        ' 
        BtnHorario.BackColor = Color.FromArgb(CByte(35), CByte(32), CByte(39))
        BtnHorario.Dock = DockStyle.Top
        BtnHorario.FlatAppearance.BorderSize = 0
        BtnHorario.FlatStyle = FlatStyle.Flat
        BtnHorario.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        BtnHorario.ForeColor = SystemColors.Control
        BtnHorario.Location = New Point(0, 0)
        BtnHorario.Name = "BtnHorario"
        BtnHorario.Padding = New Padding(30, 0, 0, 0)
        BtnHorario.Size = New Size(191, 30)
        BtnHorario.TabIndex = 0
        BtnHorario.Text = "Horario"
        BtnHorario.TextAlign = ContentAlignment.MiddleLeft
        BtnHorario.UseVisualStyleBackColor = False
        ' 
        ' btnEmpleados
        ' 
        btnEmpleados.Dock = DockStyle.Top
        btnEmpleados.FlatAppearance.BorderSize = 0
        btnEmpleados.FlatStyle = FlatStyle.Flat
        btnEmpleados.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        btnEmpleados.ForeColor = SystemColors.Control
        btnEmpleados.Location = New Point(0, 140)
        btnEmpleados.Name = "btnEmpleados"
        btnEmpleados.Padding = New Padding(10, 0, 0, 0)
        btnEmpleados.Size = New Size(191, 40)
        btnEmpleados.TabIndex = 1
        btnEmpleados.Text = "Empleados"
        btnEmpleados.TextAlign = ContentAlignment.MiddleLeft
        btnEmpleados.UseVisualStyleBackColor = True
        ' 
        ' PanelLogo
        ' 
        PanelLogo.Controls.Add(PictureBox1)
        PanelLogo.Dock = DockStyle.Top
        PanelLogo.Location = New Point(0, 0)
        PanelLogo.Name = "PanelLogo"
        PanelLogo.Size = New Size(191, 140)
        PanelLogo.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.logo_nombre_imagen_GYMCAT
        PictureBox1.Location = New Point(31, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(118, 110)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(33), CByte(31), CByte(45))
        Panel4.Controls.Add(Labelinfo)
        Panel4.Controls.Add(Labelbienvenido)
        Panel4.Dock = DockStyle.Fill
        Panel4.Location = New Point(191, 0)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(826, 705)
        Panel4.TabIndex = 15
        ' 
        ' Labelinfo
        ' 
        Labelinfo.AutoSize = True
        Labelinfo.Font = New Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Labelinfo.ForeColor = SystemColors.Control
        Labelinfo.Location = New Point(39, 106)
        Labelinfo.Name = "Labelinfo"
        Labelinfo.Size = New Size(118, 21)
        Labelinfo.TabIndex = 0
        Labelinfo.Text = "Información:"
        ' 
        ' Labelbienvenido
        ' 
        Labelbienvenido.AutoSize = True
        Labelbienvenido.Font = New Font("Cascadia Mono SemiBold", 20F, FontStyle.Bold)
        Labelbienvenido.ForeColor = SystemColors.Control
        Labelbienvenido.Location = New Point(39, 48)
        Labelbienvenido.Name = "Labelbienvenido"
        Labelbienvenido.Size = New Size(191, 35)
        Labelbienvenido.TabIndex = 0
        Labelbienvenido.Text = "Bienvenido "
        ' 
        ' MDIPrincipal
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1017, 705)
        Controls.Add(Panel4)
        Controls.Add(PanelLateral)
        IsMdiContainer = True
        Margin = New Padding(4, 3, 4, 3)
        MinimumSize = New Size(650, 450)
        Name = "MDIPrincipal"
        Text = "Gym Cat Sistema de Gestión"
        PanelLateral.ResumeLayout(False)
        PanelMembresias.ResumeLayout(False)
        PanelEmpleados.ResumeLayout(False)
        PanelLogo.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        ResumeLayout(False)

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
	Friend WithEvents PanelLateral As Panel
	Friend WithEvents PanelLogo As Panel
	Friend WithEvents btnEmpleados As Button
	Friend WithEvents btnCursos As Button
	Friend WithEvents PanelMembresias As Panel
	Friend WithEvents btnMembresias As Button
	Friend WithEvents PanelEmpleados As Panel
	Friend WithEvents BtnHorario As Button
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents btnInscripciones As Button
	Friend WithEvents Button11 As Button
	Friend WithEvents Panel4 As Panel
	Friend WithEvents btnFinanzas As Button
	Friend WithEvents btnInventario As Button
    Friend WithEvents Labelinfo As Label
    Friend WithEvents Labelbienvenido As Label
    Friend WithEvents btnConsultas As Button

End Class
