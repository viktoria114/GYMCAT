<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormEmpleados
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
        dgvListadoEmpleados = New DataGridView()
        GroupBox2 = New GroupBox()
        cbOpciones = New ComboBox()
        tbBuscar = New TextBox()
        btnAgregar = New Button()
        btnBorrar = New Button()
        btnEditar = New Button()
        Label1 = New Label()
        CType(dgvListadoEmpleados, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgvListadoEmpleados
        ' 
        dgvListadoEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvListadoEmpleados.BackgroundColor = SystemColors.ButtonShadow
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = SystemColors.Control
        DataGridViewCellStyle4.Font = New Font("Cascadia Mono", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle4.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = Color.Black
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        dgvListadoEmpleados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        dgvListadoEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = SystemColors.Window
        DataGridViewCellStyle5.Font = New Font("Cascadia Mono", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle5.ForeColor = Color.White
        DataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.False
        dgvListadoEmpleados.DefaultCellStyle = DataGridViewCellStyle5
        dgvListadoEmpleados.Location = New Point(19, 64)
        dgvListadoEmpleados.MultiSelect = False
        dgvListadoEmpleados.Name = "dgvListadoEmpleados"
        DataGridViewCellStyle6.ForeColor = Color.Black
        dgvListadoEmpleados.RowsDefaultCellStyle = DataGridViewCellStyle6
        dgvListadoEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvListadoEmpleados.Size = New Size(739, 379)
        dgvListadoEmpleados.TabIndex = 3
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(cbOpciones)
        GroupBox2.Controls.Add(tbBuscar)
        GroupBox2.Controls.Add(dgvListadoEmpleados)
        GroupBox2.Font = New Font("Cascadia Mono", 9.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        GroupBox2.ForeColor = Color.White
        GroupBox2.Location = New Point(27, 158)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(779, 456)
        GroupBox2.TabIndex = 5
        GroupBox2.TabStop = False
        GroupBox2.Text = "Listado de Empleados"
        ' 
        ' cbOpciones
        ' 
        cbOpciones.FormattingEnabled = True
        cbOpciones.Items.AddRange(New Object() {"Nombre", "Apellido", "DNI", "Fecha de Nacimiento", "Sueldo", "Cargo", "Turno", "Teléfono", "Correo"})
        cbOpciones.Location = New Point(440, 27)
        cbOpciones.Name = "cbOpciones"
        cbOpciones.Size = New Size(214, 24)
        cbOpciones.TabIndex = 5
        ' 
        ' tbBuscar
        ' 
        tbBuscar.Location = New Point(60, 27)
        tbBuscar.Name = "tbBuscar"
        tbBuscar.Size = New Size(374, 21)
        tbBuscar.TabIndex = 4
        ' 
        ' btnAgregar
        ' 
        btnAgregar.BackColor = Color.FromArgb(239, 41, 84)
        btnAgregar.FlatStyle = FlatStyle.Popup
        btnAgregar.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
        btnAgregar.ForeColor = Color.White
        btnAgregar.ImageAlign = ContentAlignment.MiddleRight
        btnAgregar.Location = New Point(27, 91)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(91, 44)
        btnAgregar.TabIndex = 6
        btnAgregar.Text = "Agregar"
        btnAgregar.TextAlign = ContentAlignment.MiddleLeft
        btnAgregar.UseVisualStyleBackColor = False
        ' 
        ' btnBorrar
        ' 
        btnBorrar.BackColor = Color.FromArgb(239, 41, 84)
        btnBorrar.FlatStyle = FlatStyle.Popup
        btnBorrar.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
        btnBorrar.ForeColor = Color.White
        btnBorrar.ImageAlign = ContentAlignment.MiddleRight
        btnBorrar.Location = New Point(237, 91)
        btnBorrar.Name = "btnBorrar"
        btnBorrar.Size = New Size(91, 44)
        btnBorrar.TabIndex = 7
        btnBorrar.Text = "Eliminar"
        btnBorrar.TextAlign = ContentAlignment.MiddleLeft
        btnBorrar.UseVisualStyleBackColor = False
        ' 
        ' btnEditar
        ' 
        btnEditar.BackColor = Color.FromArgb(239, 41, 84)
        btnEditar.FlatStyle = FlatStyle.Popup
        btnEditar.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
        btnEditar.ForeColor = Color.White
        btnEditar.ImageAlign = ContentAlignment.MiddleRight
        btnEditar.Location = New Point(134, 91)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(91, 44)
        btnEditar.TabIndex = 8
        btnEditar.Text = "Editar"
        btnEditar.TextAlign = ContentAlignment.MiddleLeft
        btnEditar.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Cascadia Mono SemiBold", 20.0F, FontStyle.Bold)
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(27, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(159, 35)
        Label1.TabIndex = 11
        Label1.Text = "Empleados"
        ' 
        ' FormEmpleados
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(33, 31, 45)
        ClientSize = New Size(818, 626)
        Controls.Add(Label1)
        Controls.Add(btnEditar)
        Controls.Add(btnBorrar)
        Controls.Add(btnAgregar)
        Controls.Add(GroupBox2)
        Name = "FormEmpleados"
        Text = "FormEmpleados"
        CType(dgvListadoEmpleados, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Friend WithEvents dgvListadoEmpleados As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnBorrar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents tbBuscar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbOpciones As ComboBox
End Class
