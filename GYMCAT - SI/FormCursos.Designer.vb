<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCursos
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
        Dim DataGridViewCellStyle40 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle41 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle42 As DataGridViewCellStyle = New DataGridViewCellStyle()
        dgvListadoCursos = New DataGridView()
        GroupBox2 = New GroupBox()
        cbOpciones = New ComboBox()
        tbBuscar = New TextBox()
        btnAgregar = New Button()
        btnBorrar = New Button()
        btnEditar = New Button()
        Label1 = New Label()
        CType(dgvListadoCursos, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgvListadoCursos
        ' 
        dgvListadoCursos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvListadoCursos.BackgroundColor = SystemColors.ButtonShadow
        DataGridViewCellStyle40.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle40.BackColor = SystemColors.Control
        DataGridViewCellStyle40.Font = New Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle40.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle40.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle40.SelectionForeColor = Color.Black
        DataGridViewCellStyle40.WrapMode = DataGridViewTriState.True
        dgvListadoCursos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle40
        dgvListadoCursos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle41.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle41.BackColor = SystemColors.Window
        DataGridViewCellStyle41.Font = New Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle41.ForeColor = Color.White
        DataGridViewCellStyle41.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle41.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle41.WrapMode = DataGridViewTriState.False
        dgvListadoCursos.DefaultCellStyle = DataGridViewCellStyle41
        dgvListadoCursos.Location = New Point(19, 64)
        dgvListadoCursos.MultiSelect = False
        dgvListadoCursos.Name = "dgvListadoCursos"
        dgvListadoCursos.ReadOnly = True
        DataGridViewCellStyle42.ForeColor = Color.Black
        dgvListadoCursos.RowsDefaultCellStyle = DataGridViewCellStyle42
        dgvListadoCursos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvListadoCursos.Size = New Size(739, 379)
        dgvListadoCursos.TabIndex = 3
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(cbOpciones)
        GroupBox2.Controls.Add(tbBuscar)
        GroupBox2.Controls.Add(dgvListadoCursos)
        GroupBox2.Font = New Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox2.ForeColor = Color.White
        GroupBox2.Location = New Point(27, 158)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(779, 456)
        GroupBox2.TabIndex = 5
        GroupBox2.TabStop = False
        GroupBox2.Text = "Listado de Cursos"
        ' 
        ' cbOpciones
        ' 
        cbOpciones.FormattingEnabled = True
        cbOpciones.Items.AddRange(New Object() {"Nombre", "Horario", "Precio", "Cantidad de Inscriptos", "Dias de Clase", "Turno", "Instructor"})
        cbOpciones.Location = New Point(440, 27)
        cbOpciones.Name = "cbOpciones"
        cbOpciones.Size = New Size(214, 24)
        cbOpciones.TabIndex = 5
        cbOpciones.Text = "Nombre"
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
        btnAgregar.BackColor = Color.FromArgb(CByte(239), CByte(41), CByte(84))
        btnAgregar.FlatStyle = FlatStyle.Popup
        btnAgregar.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
        btnAgregar.ForeColor = Color.WhiteSmoke
        btnAgregar.Image = My.Resources.Resources.agregar
        btnAgregar.ImageAlign = ContentAlignment.MiddleRight
        btnAgregar.Location = New Point(27, 84)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(101, 44)
        btnAgregar.TabIndex = 6
        btnAgregar.Text = "Agregar"
        btnAgregar.TextAlign = ContentAlignment.MiddleLeft
        btnAgregar.UseVisualStyleBackColor = False
        ' 
        ' btnBorrar
        ' 
        btnBorrar.BackColor = Color.FromArgb(CByte(239), CByte(41), CByte(84))
        btnBorrar.FlatStyle = FlatStyle.Popup
        btnBorrar.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
        btnBorrar.ForeColor = Color.White
        btnBorrar.Image = My.Resources.Resources.agregar__1__removebg_preview
        btnBorrar.ImageAlign = ContentAlignment.MiddleRight
        btnBorrar.Location = New Point(241, 84)
        btnBorrar.Name = "btnBorrar"
        btnBorrar.Size = New Size(101, 44)
        btnBorrar.TabIndex = 7
        btnBorrar.Text = "Eliminar"
        btnBorrar.TextAlign = ContentAlignment.MiddleLeft
        btnBorrar.UseVisualStyleBackColor = False
        ' 
        ' btnEditar
        ' 
        btnEditar.BackColor = Color.FromArgb(CByte(239), CByte(41), CByte(84))
        btnEditar.FlatStyle = FlatStyle.Popup
        btnEditar.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
        btnEditar.ForeColor = Color.White
        btnEditar.Image = My.Resources.Resources.boton_editar
        btnEditar.ImageAlign = ContentAlignment.MiddleRight
        btnEditar.Location = New Point(134, 84)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(101, 44)
        btnEditar.TabIndex = 8
        btnEditar.Text = "Editar"
        btnEditar.TextAlign = ContentAlignment.MiddleLeft
        btnEditar.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Cascadia Mono SemiBold", 20F, FontStyle.Bold)
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(27, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(111, 35)
        Label1.TabIndex = 11
        Label1.Text = "Cursos"
        ' 
        ' FormCursos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(33), CByte(31), CByte(45))
        ClientSize = New Size(818, 626)
        Controls.Add(Label1)
        Controls.Add(btnEditar)
        Controls.Add(btnBorrar)
        Controls.Add(btnAgregar)
        Controls.Add(GroupBox2)
        Name = "FormCursos"
        Text = "FormCursos"
        CType(dgvListadoCursos, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Friend WithEvents dgvListadoCursos As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnBorrar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents tbBuscar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbOpciones As ComboBox
End Class
