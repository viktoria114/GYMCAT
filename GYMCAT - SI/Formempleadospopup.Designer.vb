<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formempleadospopup
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
        Label7 = New Label()
        tbCargo = New TextBox()
        btnCancelar = New Button()
        btnGuardar = New Button()
        Label6 = New Label()
        tbTurno = New TextBox()
        Label5 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label2 = New Label()
        tbSueldo = New TextBox()
        tbDNI = New TextBox()
        tbApellido = New TextBox()
        Label1 = New Label()
        tbNombre = New TextBox()
        tbTelefono = New TextBox()
        Label8 = New Label()
        tbCorreo = New TextBox()
        Label9 = New Label()
        dtpNac = New DateTimePicker()
        SuspendLayout()
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
        Label7.ForeColor = Color.WhiteSmoke
        Label7.Location = New Point(134, 197)
        Label7.Name = "Label7"
        Label7.Size = New Size(56, 17)
        Label7.TabIndex = 35
        Label7.Text = "Cargo:"
        ' 
        ' tbCargo
        ' 
        tbCargo.Location = New Point(196, 196)
        tbCargo.Name = "tbCargo"
        tbCargo.Size = New Size(183, 23)
        tbCargo.TabIndex = 34
        ' 
        ' btnCancelar
        ' 
        btnCancelar.BackColor = Color.FromArgb(CByte(239), CByte(41), CByte(84))
        btnCancelar.FlatStyle = FlatStyle.Popup
        btnCancelar.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
        btnCancelar.ForeColor = Color.WhiteSmoke
        btnCancelar.ImageAlign = ContentAlignment.MiddleRight
        btnCancelar.Location = New Point(243, 302)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(91, 44)
        btnCancelar.TabIndex = 33
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = False
        ' 
        ' btnGuardar
        ' 
        btnGuardar.BackColor = Color.FromArgb(CByte(239), CByte(41), CByte(84))
        btnGuardar.FlatStyle = FlatStyle.Popup
        btnGuardar.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
        btnGuardar.ForeColor = Color.WhiteSmoke
        btnGuardar.ImageAlign = ContentAlignment.MiddleRight
        btnGuardar.Location = New Point(72, 302)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(91, 44)
        btnGuardar.TabIndex = 32
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
        Label6.ForeColor = Color.WhiteSmoke
        Label6.Location = New Point(134, 168)
        Label6.Name = "Label6"
        Label6.Size = New Size(56, 17)
        Label6.TabIndex = 31
        Label6.Text = "Turno:"
        ' 
        ' tbTurno
        ' 
        tbTurno.Location = New Point(196, 167)
        tbTurno.Name = "tbTurno"
        tbTurno.Size = New Size(183, 23)
        tbTurno.TabIndex = 30
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
        Label5.ForeColor = Color.WhiteSmoke
        Label5.Location = New Point(126, 139)
        Label5.Name = "Label5"
        Label5.Size = New Size(64, 17)
        Label5.TabIndex = 29
        Label5.Text = "Sueldo:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
        Label3.ForeColor = Color.WhiteSmoke
        Label3.Location = New Point(150, 81)
        Label3.Name = "Label3"
        Label3.Size = New Size(40, 17)
        Label3.TabIndex = 28
        Label3.Text = "DNI:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
        Label4.ForeColor = Color.WhiteSmoke
        Label4.Location = New Point(22, 110)
        Label4.Name = "Label4"
        Label4.Size = New Size(168, 17)
        Label4.TabIndex = 27
        Label4.Text = "Fecha de Nacimiento:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
        Label2.ForeColor = Color.WhiteSmoke
        Label2.Location = New Point(110, 52)
        Label2.Name = "Label2"
        Label2.Size = New Size(80, 17)
        Label2.TabIndex = 26
        Label2.Text = "Apellido:"
        ' 
        ' tbSueldo
        ' 
        tbSueldo.Location = New Point(196, 138)
        tbSueldo.Name = "tbSueldo"
        tbSueldo.Size = New Size(183, 23)
        tbSueldo.TabIndex = 25
        ' 
        ' tbDNI
        ' 
        tbDNI.Location = New Point(196, 80)
        tbDNI.Name = "tbDNI"
        tbDNI.Size = New Size(183, 23)
        tbDNI.TabIndex = 23
        ' 
        ' tbApellido
        ' 
        tbApellido.Location = New Point(196, 51)
        tbApellido.Name = "tbApellido"
        tbApellido.Size = New Size(183, 23)
        tbApellido.TabIndex = 22
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
        Label1.ForeColor = Color.WhiteSmoke
        Label1.Location = New Point(126, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 17)
        Label1.TabIndex = 21
        Label1.Text = "Nombre:"
        ' 
        ' tbNombre
        ' 
        tbNombre.Location = New Point(196, 22)
        tbNombre.Name = "tbNombre"
        tbNombre.Size = New Size(183, 23)
        tbNombre.TabIndex = 20
        ' 
        ' tbTelefono
        ' 
        tbTelefono.Location = New Point(196, 225)
        tbTelefono.Name = "tbTelefono"
        tbTelefono.Size = New Size(183, 23)
        tbTelefono.TabIndex = 30
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
        Label8.ForeColor = Color.WhiteSmoke
        Label8.Location = New Point(110, 223)
        Label8.Name = "Label8"
        Label8.Size = New Size(80, 17)
        Label8.TabIndex = 31
        Label8.Text = "Teléfono:"
        ' 
        ' tbCorreo
        ' 
        tbCorreo.Location = New Point(196, 254)
        tbCorreo.Name = "tbCorreo"
        tbCorreo.Size = New Size(183, 23)
        tbCorreo.TabIndex = 34
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
        Label9.ForeColor = Color.WhiteSmoke
        Label9.Location = New Point(126, 252)
        Label9.Name = "Label9"
        Label9.Size = New Size(64, 17)
        Label9.TabIndex = 35
        Label9.Text = "Correo:"
        ' 
        ' dtpNac
        ' 
        dtpNac.Format = DateTimePickerFormat.Short
        dtpNac.Location = New Point(196, 109)
        dtpNac.MaxDate = New Date(2024, 8, 17, 0, 0, 0, 0)
        dtpNac.Name = "dtpNac"
        dtpNac.Size = New Size(183, 23)
        dtpNac.TabIndex = 36
        dtpNac.Value = New Date(2024, 8, 17, 0, 0, 0, 0)
        ' 
        ' Formempleados2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(33), CByte(31), CByte(45))
        ClientSize = New Size(420, 387)
        Controls.Add(dtpNac)
        Controls.Add(Label9)
        Controls.Add(Label7)
        Controls.Add(tbCorreo)
        Controls.Add(tbCargo)
        Controls.Add(btnCancelar)
        Controls.Add(Label8)
        Controls.Add(btnGuardar)
        Controls.Add(tbTelefono)
        Controls.Add(Label6)
        Controls.Add(tbTurno)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(tbSueldo)
        Controls.Add(tbDNI)
        Controls.Add(tbApellido)
        Controls.Add(Label1)
        Controls.Add(tbNombre)
        Name = "Formempleados2"
        Text = "Formempleados2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents tbCargo As TextBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents tbTurno As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbSueldo As TextBox
    Friend WithEvents tbDNI As TextBox
    Friend WithEvents tbApellido As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbNombre As TextBox
    Friend WithEvents tbTelefono As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents tbCorreo As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents dtpNac As DateTimePicker
End Class
