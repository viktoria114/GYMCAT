<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CrudMiembros
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        dgvListadoMiembros = New DataGridView()
        cbBuscar = New ComboBox()
        tbBuscar = New TextBox()
        PictureBox1 = New PictureBox()
        btnAgregar = New Button()
        btnEditar = New Button()
        btnBorrar = New Button()
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        btnPagoCuota = New Button()
        CType(dgvListadoMiembros, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgvListadoMiembros
        ' 
        dgvListadoMiembros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.Desktop
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvListadoMiembros.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvListadoMiembros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = Color.White
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvListadoMiembros.DefaultCellStyle = DataGridViewCellStyle2
        dgvListadoMiembros.Location = New Point(19, 64)
        dgvListadoMiembros.MultiSelect = False
        dgvListadoMiembros.Name = "dgvListadoMiembros"
        dgvListadoMiembros.ReadOnly = True
        DataGridViewCellStyle3.ForeColor = Color.Black
        dgvListadoMiembros.RowsDefaultCellStyle = DataGridViewCellStyle3
        dgvListadoMiembros.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvListadoMiembros.Size = New Size(739, 377)
        dgvListadoMiembros.TabIndex = 3
        ' 
        ' cbBuscar
        ' 
        cbBuscar.FormattingEnabled = True
        cbBuscar.Items.AddRange(New Object() {"Nombre", "Apellido", "DNI", "Edad", "Telefono", "Correo"})
        cbBuscar.Location = New Point(440, 27)
        cbBuscar.Name = "cbBuscar"
        cbBuscar.Size = New Size(214, 24)
        cbBuscar.TabIndex = 6
        ' 
        ' tbBuscar
        ' 
        tbBuscar.Location = New Point(60, 27)
        tbBuscar.Name = "tbBuscar"
        tbBuscar.Size = New Size(374, 21)
        tbBuscar.TabIndex = 4
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.file
        PictureBox1.Location = New Point(16, 18)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(35, 38)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' btnAgregar
        ' 
        btnAgregar.BackColor = Color.FromArgb(CByte(239), CByte(41), CByte(84))
        btnAgregar.FlatStyle = FlatStyle.Popup
        btnAgregar.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
        btnAgregar.ForeColor = SystemColors.ButtonFace
        btnAgregar.Image = My.Resources.Resources.icono_user_agregar
        btnAgregar.ImageAlign = ContentAlignment.MiddleRight
        btnAgregar.Location = New Point(27, 84)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(101, 44)
        btnAgregar.TabIndex = 5
        btnAgregar.Text = "Agregar"
        btnAgregar.TextAlign = ContentAlignment.MiddleLeft
        btnAgregar.UseVisualStyleBackColor = False
        ' 
        ' btnEditar
        ' 
        btnEditar.BackColor = Color.FromArgb(CByte(239), CByte(41), CByte(84))
        btnEditar.FlatStyle = FlatStyle.Popup
        btnEditar.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
        btnEditar.ForeColor = SystemColors.ButtonFace
        btnEditar.Image = My.Resources.Resources.icono_user_editar
        btnEditar.ImageAlign = ContentAlignment.MiddleRight
        btnEditar.Location = New Point(134, 84)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(101, 44)
        btnEditar.TabIndex = 5
        btnEditar.Text = "Editar"
        btnEditar.TextAlign = ContentAlignment.MiddleLeft
        btnEditar.UseVisualStyleBackColor = False
        ' 
        ' btnBorrar
        ' 
        btnBorrar.BackColor = Color.FromArgb(CByte(239), CByte(41), CByte(84))
        btnBorrar.FlatStyle = FlatStyle.Popup
        btnBorrar.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
        btnBorrar.ForeColor = SystemColors.ButtonFace
        btnBorrar.Image = My.Resources.Resources.icono_user_eliminar
        btnBorrar.ImageAlign = ContentAlignment.MiddleRight
        btnBorrar.Location = New Point(241, 84)
        btnBorrar.Name = "btnBorrar"
        btnBorrar.Size = New Size(101, 44)
        btnBorrar.TabIndex = 5
        btnBorrar.Text = "Eliminar"
        btnBorrar.TextAlign = ContentAlignment.MiddleLeft
        btnBorrar.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Cascadia Mono SemiBold", 20F, FontStyle.Bold)
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(27, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(143, 35)
        Label1.TabIndex = 16
        Label1.Text = "Miembros"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(dgvListadoMiembros)
        GroupBox1.Controls.Add(cbBuscar)
        GroupBox1.Controls.Add(tbBuscar)
        GroupBox1.Controls.Add(PictureBox1)
        GroupBox1.Font = New Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox1.ForeColor = Color.White
        GroupBox1.Location = New Point(27, 158)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(779, 456)
        GroupBox1.TabIndex = 12
        GroupBox1.TabStop = False
        GroupBox1.Text = "Listado de Miembros"
        ' 
        ' btnPagoCuota
        ' 
        btnPagoCuota.BackColor = Color.FromArgb(CByte(239), CByte(41), CByte(84))
        btnPagoCuota.FlatStyle = FlatStyle.Popup
        btnPagoCuota.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
        btnPagoCuota.ForeColor = SystemColors.ButtonFace
        btnPagoCuota.Image = My.Resources.Resources.icono_flecha_derecha
        btnPagoCuota.ImageAlign = ContentAlignment.MiddleRight
        btnPagoCuota.Location = New Point(638, 84)
        btnPagoCuota.Name = "btnPagoCuota"
        btnPagoCuota.Size = New Size(147, 44)
        btnPagoCuota.TabIndex = 5
        btnPagoCuota.Text = "Pagar Cuota"
        btnPagoCuota.TextAlign = ContentAlignment.MiddleLeft
        btnPagoCuota.UseVisualStyleBackColor = False
        ' 
        ' CrudMiembros
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(33), CByte(31), CByte(45))
        ClientSize = New Size(833, 646)
        Controls.Add(Label1)
        Controls.Add(GroupBox1)
        Controls.Add(btnPagoCuota)
        Controls.Add(btnBorrar)
        Controls.Add(btnEditar)
        Controls.Add(btnAgregar)
        Name = "CrudMiembros"
        Text = "CrudMiembros"
        CType(dgvListadoMiembros, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents dgvListadoMiembros As DataGridView
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnBorrar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cbBuscar As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tbBuscar As TextBox
    Friend WithEvents btnPagoCuota As Button

End Class

