<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CrudElementos2
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
        tbNombreElemento = New TextBox()
        Label1 = New Label()
        tbModeloElemento = New TextBox()
        tbTipoElemento = New TextBox()
        tbPrecioElemento = New TextBox()
        tbFechaCompraElemento = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        tbStockElemeto = New TextBox()
        btnGuardar = New Button()
        btnCancelar = New Button()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        tbDetalleElemento = New TextBox()
        tbMarcaElemento = New TextBox()
        cbEstadoElemento = New ComboBox()
        SuspendLayout()
        ' 
        ' tbNombreElemento
        ' 
        tbNombreElemento.Location = New Point(193, 33)
        tbNombreElemento.Name = "tbNombreElemento"
        tbNombreElemento.Size = New Size(183, 23)
        tbNombreElemento.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
        Label1.ForeColor = Color.WhiteSmoke
        Label1.Location = New Point(35, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(152, 17)
        Label1.TabIndex = 3
        Label1.Text = "Nombre del Elemto:"
        ' 
        ' tbModeloElemento
        ' 
        tbModeloElemento.Location = New Point(193, 62)
        tbModeloElemento.Name = "tbModeloElemento"
        tbModeloElemento.Size = New Size(183, 23)
        tbModeloElemento.TabIndex = 4
        ' 
        ' tbTipoElemento
        ' 
        tbTipoElemento.Location = New Point(193, 120)
        tbTipoElemento.Name = "tbTipoElemento"
        tbTipoElemento.Size = New Size(183, 23)
        tbTipoElemento.TabIndex = 6
        ' 
        ' tbPrecioElemento
        ' 
        tbPrecioElemento.Location = New Point(193, 91)
        tbPrecioElemento.Name = "tbPrecioElemento"
        tbPrecioElemento.Size = New Size(183, 23)
        tbPrecioElemento.TabIndex = 5
        ' 
        ' tbFechaCompraElemento
        ' 
        tbFechaCompraElemento.Location = New Point(193, 149)
        tbFechaCompraElemento.Name = "tbFechaCompraElemento"
        tbFechaCompraElemento.Size = New Size(183, 23)
        tbFechaCompraElemento.TabIndex = 7
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
        Label2.ForeColor = Color.WhiteSmoke
        Label2.Location = New Point(123, 63)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 17)
        Label2.TabIndex = 10
        Label2.Text = "Modelo:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
        Label3.ForeColor = Color.WhiteSmoke
        Label3.Location = New Point(123, 92)
        Label3.Name = "Label3"
        Label3.Size = New Size(64, 17)
        Label3.TabIndex = 12
        Label3.Text = "Precio:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
        Label4.ForeColor = Color.WhiteSmoke
        Label4.Location = New Point(139, 121)
        Label4.Name = "Label4"
        Label4.Size = New Size(48, 17)
        Label4.TabIndex = 11
        Label4.Text = "Tipo:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
        Label5.ForeColor = Color.WhiteSmoke
        Label5.Location = New Point(51, 150)
        Label5.Name = "Label5"
        Label5.Size = New Size(136, 17)
        Label5.TabIndex = 13
        Label5.Text = "Fecha de Compra:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
        Label6.ForeColor = Color.WhiteSmoke
        Label6.Location = New Point(131, 178)
        Label6.Name = "Label6"
        Label6.Size = New Size(56, 17)
        Label6.TabIndex = 15
        Label6.Text = "Stock:"
        ' 
        ' tbStockElemeto
        ' 
        tbStockElemeto.Location = New Point(193, 178)
        tbStockElemeto.Name = "tbStockElemeto"
        tbStockElemeto.Size = New Size(183, 23)
        tbStockElemeto.TabIndex = 14
        ' 
        ' btnGuardar
        ' 
        btnGuardar.BackColor = Color.FromArgb(CByte(239), CByte(41), CByte(84))
        btnGuardar.FlatStyle = FlatStyle.Popup
        btnGuardar.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
        btnGuardar.ForeColor = Color.WhiteSmoke
        btnGuardar.ImageAlign = ContentAlignment.MiddleRight
        btnGuardar.Location = New Point(70, 327)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(91, 44)
        btnGuardar.TabIndex = 16
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = False
        ' 
        ' btnCancelar
        ' 
        btnCancelar.BackColor = Color.FromArgb(CByte(239), CByte(41), CByte(84))
        btnCancelar.FlatStyle = FlatStyle.Popup
        btnCancelar.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
        btnCancelar.ForeColor = Color.WhiteSmoke
        btnCancelar.ImageAlign = ContentAlignment.MiddleRight
        btnCancelar.Location = New Point(241, 327)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(91, 44)
        btnCancelar.TabIndex = 17
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
        Label7.ForeColor = Color.WhiteSmoke
        Label7.Location = New Point(131, 208)
        Label7.Name = "Label7"
        Label7.Size = New Size(56, 17)
        Label7.TabIndex = 18
        Label7.Text = "Marca:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
        Label8.ForeColor = Color.WhiteSmoke
        Label8.Location = New Point(123, 237)
        Label8.Name = "Label8"
        Label8.Size = New Size(64, 17)
        Label8.TabIndex = 19
        Label8.Text = "Estado:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
        Label9.ForeColor = Color.WhiteSmoke
        Label9.Location = New Point(115, 266)
        Label9.Name = "Label9"
        Label9.Size = New Size(72, 17)
        Label9.TabIndex = 20
        Label9.Text = "Detalle:"
        ' 
        ' tbDetalleElemento
        ' 
        tbDetalleElemento.Location = New Point(193, 265)
        tbDetalleElemento.Name = "tbDetalleElemento"
        tbDetalleElemento.Size = New Size(183, 23)
        tbDetalleElemento.TabIndex = 23
        ' 
        ' tbMarcaElemento
        ' 
        tbMarcaElemento.Location = New Point(193, 207)
        tbMarcaElemento.Name = "tbMarcaElemento"
        tbMarcaElemento.Size = New Size(183, 23)
        tbMarcaElemento.TabIndex = 21
        ' 
        ' cbEstadoElemento
        ' 
        cbEstadoElemento.FormattingEnabled = True
        cbEstadoElemento.Items.AddRange(New Object() {"Nuevo", "Bueno", "Desgastado", "Deporable", "Defectuoso*"})
        cbEstadoElemento.Location = New Point(193, 236)
        cbEstadoElemento.Name = "cbEstadoElemento"
        cbEstadoElemento.Size = New Size(183, 23)
        cbEstadoElemento.TabIndex = 24
        cbEstadoElemento.Text = "Nuevo"
        ' 
        ' CrudElementos2
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(33), CByte(31), CByte(45))
        ClientSize = New Size(399, 432)
        Controls.Add(cbEstadoElemento)
        Controls.Add(tbDetalleElemento)
        Controls.Add(tbMarcaElemento)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(btnCancelar)
        Controls.Add(btnGuardar)
        Controls.Add(Label6)
        Controls.Add(tbStockElemeto)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(tbFechaCompraElemento)
        Controls.Add(tbTipoElemento)
        Controls.Add(tbPrecioElemento)
        Controls.Add(tbModeloElemento)
        Controls.Add(Label1)
        Controls.Add(tbNombreElemento)
        Name = "CrudElementos2"
        Text = "CrudElementos2"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents tbNombreElemento As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbModeloElemento As TextBox
    Friend WithEvents tbTipoElemento As TextBox
    Friend WithEvents tbPrecioElemento As TextBox
    Friend WithEvents tbFechaCompraElemento As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents tbStockElemeto As TextBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents tbDetalleElemento As TextBox
    Friend WithEvents tbMarcaElemento As TextBox
    Friend WithEvents cbEstadoElemento As ComboBox
End Class
