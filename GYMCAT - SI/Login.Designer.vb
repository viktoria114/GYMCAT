﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Label1 = New Label()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        tbUsuario = New TextBox()
        tbContraseña = New TextBox()
        btnIngresar = New Button()
        PictureBoxSHOW = New PictureBox()
        PictureBoxHIDE = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBoxSHOW, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBoxHIDE, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Cascadia Mono SemiBold", 11.25F, FontStyle.Bold)
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(78, 204)
        Label1.Name = "Label1"
        Label1.Size = New Size(81, 20)
        Label1.TabIndex = 2
        Label1.Text = "Usuario:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Cascadia Mono SemiBold", 11.25F, FontStyle.Bold)
        Label2.ForeColor = SystemColors.Control
        Label2.Location = New Point(51, 246)
        Label2.Name = "Label2"
        Label2.Size = New Size(108, 20)
        Label2.TabIndex = 2
        Label2.Text = "Contraseña:"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.GYMCAT_logo
        PictureBox1.Location = New Point(93, 33)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(170, 130)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' tbUsuario
        ' 
        tbUsuario.Font = New Font("Cascadia Mono SemiBold", 11.25F, FontStyle.Bold)
        tbUsuario.Location = New Point(165, 201)
        tbUsuario.Name = "tbUsuario"
        tbUsuario.Size = New Size(156, 25)
        tbUsuario.TabIndex = 4
        tbUsuario.Text = "venteveo"
        ' 
        ' tbContraseña
        ' 
        tbContraseña.Font = New Font("Cascadia Mono SemiBold", 11.25F, FontStyle.Bold)
        tbContraseña.Location = New Point(165, 241)
        tbContraseña.Name = "tbContraseña"
        tbContraseña.PasswordChar = "*"c
        tbContraseña.Size = New Size(156, 25)
        tbContraseña.TabIndex = 5
        tbContraseña.Text = "123"
        ' 
        ' btnIngresar
        ' 
        btnIngresar.BackColor = Color.FromArgb(CByte(239), CByte(41), CByte(84))
        btnIngresar.FlatAppearance.BorderSize = 0
        btnIngresar.FlatStyle = FlatStyle.Popup
        btnIngresar.Font = New Font("Cascadia Mono SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnIngresar.Location = New Point(110, 327)
        btnIngresar.Name = "btnIngresar"
        btnIngresar.Size = New Size(141, 52)
        btnIngresar.TabIndex = 6
        btnIngresar.Text = "Ingresar"
        btnIngresar.UseVisualStyleBackColor = False
        ' 
        ' PictureBoxSHOW
        ' 
        PictureBoxSHOW.Image = My.Resources.Resources.view_show_icon_124811
        PictureBoxSHOW.Location = New Point(298, 244)
        PictureBoxSHOW.Name = "PictureBoxSHOW"
        PictureBoxSHOW.Size = New Size(22, 20)
        PictureBoxSHOW.SizeMode = PictureBoxSizeMode.Zoom
        PictureBoxSHOW.TabIndex = 8
        PictureBoxSHOW.TabStop = False
        ' 
        ' PictureBoxHIDE
        ' 
        PictureBoxHIDE.Image = My.Resources.Resources.view_hide_icon_124813
        PictureBoxHIDE.Location = New Point(298, 244)
        PictureBoxHIDE.Name = "PictureBoxHIDE"
        PictureBoxHIDE.Size = New Size(22, 20)
        PictureBoxHIDE.SizeMode = PictureBoxSizeMode.Zoom
        PictureBoxHIDE.TabIndex = 9
        PictureBoxHIDE.TabStop = False
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(33), CByte(31), CByte(45))
        ClientSize = New Size(364, 411)
        Controls.Add(PictureBoxSHOW)
        Controls.Add(btnIngresar)
        Controls.Add(tbContraseña)
        Controls.Add(tbUsuario)
        Controls.Add(PictureBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBoxHIDE)
        MaximumSize = New Size(380, 450)
        MinimumSize = New Size(380, 450)
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBoxSHOW, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBoxHIDE, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents tbUsuario As TextBox
	Friend WithEvents tbContraseña As TextBox
	Friend WithEvents btnIngresar As Button
	Friend WithEvents PictureBoxSHOW As PictureBox
    Friend WithEvents PictureBoxHIDE As PictureBox
End Class
