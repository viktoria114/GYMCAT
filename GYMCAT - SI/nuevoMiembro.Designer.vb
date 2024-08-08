<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class nuevoMiembro
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
        tbNombre = New TextBox()
        Label3 = New Label()
        tbApellido = New TextBox()
        Label4 = New Label()
        tbDNI = New TextBox()
        Label5 = New Label()
        tbEdad = New TextBox()
        Label6 = New Label()
        tbFechaIns = New TextBox()
        Label7 = New Label()
        tbDuraMem = New TextBox()
        Label8 = New Label()
        tbCurIns = New TextBox()
        Label1 = New Label()
        tbTelef = New TextBox()
        Label2 = New Label()
        tbCorreo = New TextBox()
        Label9 = New Label()
        btnGuardar = New Button()
        btnCancelar = New Button()
        tbCostoTotal = New TextBox()
        Label10 = New Label()
        tbDeudor = New TextBox()
        Label11 = New Label()
        tbPuntos = New TextBox()
        Label12 = New Label()
        SuspendLayout()
        ' 
        ' tbNombre
        ' 
        tbNombre.Location = New Point(171, 23)
        tbNombre.Name = "tbNombre"
        tbNombre.Size = New Size(192, 23)
        tbNombre.TabIndex = 0
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
        Label3.ForeColor = SystemColors.ButtonFace
        Label3.Location = New Point(110, 26)
        Label3.Name = "Label3"
        Label3.Size = New Size(56, 17)
        Label3.TabIndex = 1
        Label3.Text = "Nombre"
        ' 
        ' tbApellido
        ' 
        tbApellido.Location = New Point(171, 52)
        tbApellido.Name = "tbApellido"
        tbApellido.Size = New Size(192, 23)
        tbApellido.TabIndex = 0
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
        Label4.ForeColor = SystemColors.ButtonFace
        Label4.Location = New Point(94, 55)
        Label4.Name = "Label4"
        Label4.Size = New Size(72, 17)
        Label4.TabIndex = 1
        Label4.Text = "Apellido"
        ' 
        ' tbDNI
        ' 
        tbDNI.Location = New Point(171, 81)
        tbDNI.Name = "tbDNI"
        tbDNI.Size = New Size(192, 23)
        tbDNI.TabIndex = 0
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
        Label5.ForeColor = SystemColors.ButtonFace
        Label5.Location = New Point(134, 84)
        Label5.Name = "Label5"
        Label5.Size = New Size(32, 17)
        Label5.TabIndex = 1
        Label5.Text = "DNI"
        ' 
        ' tbEdad
        ' 
        tbEdad.Location = New Point(171, 110)
        tbEdad.Name = "tbEdad"
        tbEdad.Size = New Size(192, 23)
        tbEdad.TabIndex = 0
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
        Label6.ForeColor = SystemColors.ButtonFace
        Label6.Location = New Point(126, 113)
        Label6.Name = "Label6"
        Label6.Size = New Size(40, 17)
        Label6.TabIndex = 1
        Label6.Text = "Edad"
        ' 
        ' tbFechaIns
        ' 
        tbFechaIns.Location = New Point(171, 139)
        tbFechaIns.Name = "tbFechaIns"
        tbFechaIns.Size = New Size(192, 23)
        tbFechaIns.TabIndex = 0
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
        Label7.ForeColor = SystemColors.ButtonFace
        Label7.Location = New Point(22, 142)
        Label7.Name = "Label7"
        Label7.Size = New Size(144, 17)
        Label7.TabIndex = 1
        Label7.Text = "Fecha Inscripcion"
        ' 
        ' tbDuraMem
        ' 
        tbDuraMem.Location = New Point(171, 168)
        tbDuraMem.Name = "tbDuraMem"
        tbDuraMem.Size = New Size(192, 23)
        tbDuraMem.TabIndex = 0
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
        Label8.ForeColor = SystemColors.ButtonFace
        Label8.Location = New Point(14, 171)
        Label8.Name = "Label8"
        Label8.Size = New Size(152, 17)
        Label8.TabIndex = 1
        Label8.Text = "Duracion Membresia"
        ' 
        ' tbCurIns
        ' 
        tbCurIns.Location = New Point(171, 197)
        tbCurIns.Name = "tbCurIns"
        tbCurIns.Size = New Size(192, 23)
        tbCurIns.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
        Label1.ForeColor = SystemColors.ButtonFace
        Label1.Location = New Point(38, 200)
        Label1.Name = "Label1"
        Label1.Size = New Size(128, 17)
        Label1.TabIndex = 1
        Label1.Text = "Cursos Inscrito"
        ' 
        ' tbTelef
        ' 
        tbTelef.Location = New Point(171, 226)
        tbTelef.Name = "tbTelef"
        tbTelef.Size = New Size(192, 23)
        tbTelef.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
        Label2.ForeColor = SystemColors.ButtonFace
        Label2.Location = New Point(94, 229)
        Label2.Name = "Label2"
        Label2.Size = New Size(72, 17)
        Label2.TabIndex = 1
        Label2.Text = "Telefono"
        ' 
        ' tbCorreo
        ' 
        tbCorreo.Location = New Point(171, 255)
        tbCorreo.Name = "tbCorreo"
        tbCorreo.Size = New Size(192, 23)
        tbCorreo.TabIndex = 0
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
        Label9.ForeColor = SystemColors.ButtonFace
        Label9.Location = New Point(110, 258)
        Label9.Name = "Label9"
        Label9.Size = New Size(56, 17)
        Label9.TabIndex = 1
        Label9.Text = "Correo"
        ' 
        ' btnGuardar
        ' 
        btnGuardar.BackColor = Color.FromArgb(CByte(239), CByte(41), CByte(84))
        btnGuardar.FlatStyle = FlatStyle.Popup
        btnGuardar.Font = New Font("Cascadia Mono", 12.0F)
        btnGuardar.ForeColor = SystemColors.ButtonFace
        btnGuardar.ImageAlign = ContentAlignment.MiddleRight
        btnGuardar.Location = New Point(67, 392)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(147, 50)
        btnGuardar.TabIndex = 6
        btnGuardar.Text = "Guardar"
        btnGuardar.TextAlign = ContentAlignment.MiddleLeft
        btnGuardar.UseVisualStyleBackColor = False
        ' 
        ' btnCancelar
        ' 
        btnCancelar.BackColor = Color.FromArgb(CByte(239), CByte(41), CByte(84))
        btnCancelar.FlatStyle = FlatStyle.Popup
        btnCancelar.Font = New Font("Cascadia Mono", 12.0F)
        btnCancelar.ForeColor = SystemColors.ButtonFace
        btnCancelar.ImageAlign = ContentAlignment.MiddleRight
        btnCancelar.Location = New Point(252, 392)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(147, 50)
        btnCancelar.TabIndex = 7
        btnCancelar.Text = "Cancelar"
        btnCancelar.TextAlign = ContentAlignment.MiddleLeft
        btnCancelar.UseVisualStyleBackColor = False
        ' 
        ' tbCostoTotal
        ' 
        tbCostoTotal.Location = New Point(171, 284)
        tbCostoTotal.Name = "tbCostoTotal"
        tbCostoTotal.Size = New Size(192, 23)
        tbCostoTotal.TabIndex = 0
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
        Label10.ForeColor = SystemColors.ButtonFace
        Label10.Location = New Point(70, 287)
        Label10.Name = "Label10"
        Label10.Size = New Size(96, 17)
        Label10.TabIndex = 1
        Label10.Text = "Costo Total"
        ' 
        ' tbDeudor
        ' 
        tbDeudor.Location = New Point(171, 313)
        tbDeudor.Name = "tbDeudor"
        tbDeudor.Size = New Size(192, 23)
        tbDeudor.TabIndex = 0
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
        Label11.ForeColor = SystemColors.ButtonFace
        Label11.Location = New Point(110, 316)
        Label11.Name = "Label11"
        Label11.Size = New Size(56, 17)
        Label11.TabIndex = 1
        Label11.Text = "Deudor"
        ' 
        ' tbPuntos
        ' 
        tbPuntos.Location = New Point(171, 342)
        tbPuntos.Name = "tbPuntos"
        tbPuntos.Size = New Size(192, 23)
        tbPuntos.TabIndex = 0
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
        Label12.ForeColor = SystemColors.ButtonFace
        Label12.Location = New Point(110, 345)
        Label12.Name = "Label12"
        Label12.Size = New Size(56, 17)
        Label12.TabIndex = 1
        Label12.Text = "Puntos"
        ' 
        ' nuevoMiembro
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(33), CByte(31), CByte(45))
        ClientSize = New Size(431, 484)
        Controls.Add(btnCancelar)
        Controls.Add(btnGuardar)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(tbPuntos)
        Controls.Add(tbDeudor)
        Controls.Add(tbCostoTotal)
        Controls.Add(tbCorreo)
        Controls.Add(tbTelef)
        Controls.Add(tbCurIns)
        Controls.Add(tbDuraMem)
        Controls.Add(tbFechaIns)
        Controls.Add(tbEdad)
        Controls.Add(tbDNI)
        Controls.Add(tbApellido)
        Controls.Add(tbNombre)
        Name = "nuevoMiembro"
        Text = "AÑADIR"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents tbNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbApellido As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbDNI As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbEdad As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tbFechaIns As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tbDuraMem As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents tbCurIns As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbTelef As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbCorreo As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents tbCostoTotal As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents tbDeudor As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents tbPuntos As TextBox
    Friend WithEvents Label12 As Label
End Class
