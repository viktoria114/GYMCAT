<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Horarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Horarios))
        Label1 = New Label()
        MonthCalendar1 = New MonthCalendar()
        Cajita = New TabControl()
        TabPage1 = New TabPage()
        CursosMañana = New GroupBox()
        LabelCursoMañana = New Label()
        empleados1 = New Label()
        TabPage2 = New TabPage()
        CursosTarde = New GroupBox()
        LabelCursosTarde = New Label()
        Label3 = New Label()
        TabPage3 = New TabPage()
        CursosNoche = New GroupBox()
        LabelCursosNoche = New Label()
        Label4 = New Label()
        Label2 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Cajita.SuspendLayout()
        TabPage1.SuspendLayout()
        CursosMañana.SuspendLayout()
        TabPage2.SuspendLayout()
        CursosTarde.SuspendLayout()
        TabPage3.SuspendLayout()
        CursosNoche.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Cascadia Mono SemiBold", 20F, FontStyle.Bold)
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(27, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(143, 35)
        Label1.TabIndex = 12
        Label1.Text = "Horario!"
        ' 
        ' MonthCalendar1
        ' 
        MonthCalendar1.BackColor = SystemColors.Control
        MonthCalendar1.Font = New Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        MonthCalendar1.Location = New Point(564, 46)
        MonthCalendar1.MaxSelectionCount = 1
        MonthCalendar1.Name = "MonthCalendar1"
        MonthCalendar1.ShowToday = False
        MonthCalendar1.TabIndex = 13
        ' 
        ' Cajita
        ' 
        Cajita.Controls.Add(TabPage1)
        Cajita.Controls.Add(TabPage2)
        Cajita.Controls.Add(TabPage3)
        Cajita.Font = New Font("Cascadia Mono", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Cajita.Location = New Point(26, 213)
        Cajita.Name = "Cajita"
        Cajita.SelectedIndex = 0
        Cajita.Size = New Size(786, 335)
        Cajita.TabIndex = 16
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(CursosMañana)
        TabPage1.Controls.Add(empleados1)
        TabPage1.Location = New Point(4, 29)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(778, 302)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Mañana"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' CursosMañana
        ' 
        CursosMañana.Controls.Add(LabelCursoMañana)
        CursosMañana.Location = New Point(306, 12)
        CursosMañana.Name = "CursosMañana"
        CursosMañana.Size = New Size(507, 284)
        CursosMañana.TabIndex = 1
        CursosMañana.TabStop = False
        CursosMañana.Text = "Cursos"
        ' 
        ' LabelCursoMañana
        ' 
        LabelCursoMañana.AutoSize = True
        LabelCursoMañana.Location = New Point(6, 30)
        LabelCursoMañana.Name = "LabelCursoMañana"
        LabelCursoMañana.Size = New Size(18, 20)
        LabelCursoMañana.TabIndex = 2
        LabelCursoMañana.Text = "."
        ' 
        ' empleados1
        ' 
        empleados1.AutoSize = True
        empleados1.Location = New Point(6, 12)
        empleados1.Name = "empleados1"
        empleados1.Size = New Size(99, 20)
        empleados1.TabIndex = 0
        empleados1.Text = "Empleados:"
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(CursosTarde)
        TabPage2.Controls.Add(Label3)
        TabPage2.Location = New Point(4, 29)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(778, 302)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Tarde"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' CursosTarde
        ' 
        CursosTarde.Controls.Add(LabelCursosTarde)
        CursosTarde.Location = New Point(306, 12)
        CursosTarde.Name = "CursosTarde"
        CursosTarde.Size = New Size(507, 284)
        CursosTarde.TabIndex = 2
        CursosTarde.TabStop = False
        CursosTarde.Text = "Cursos"
        ' 
        ' LabelCursosTarde
        ' 
        LabelCursosTarde.AutoSize = True
        LabelCursosTarde.Location = New Point(6, 30)
        LabelCursosTarde.Name = "LabelCursosTarde"
        LabelCursosTarde.Size = New Size(18, 20)
        LabelCursosTarde.TabIndex = 3
        LabelCursosTarde.Text = "."
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(6, 12)
        Label3.Name = "Label3"
        Label3.Size = New Size(99, 20)
        Label3.TabIndex = 1
        Label3.Text = "Empleados:"
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(CursosNoche)
        TabPage3.Controls.Add(Label4)
        TabPage3.Location = New Point(4, 29)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(778, 302)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Noche"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' CursosNoche
        ' 
        CursosNoche.Controls.Add(LabelCursosNoche)
        CursosNoche.Location = New Point(306, 12)
        CursosNoche.Name = "CursosNoche"
        CursosNoche.Size = New Size(507, 284)
        CursosNoche.TabIndex = 3
        CursosNoche.TabStop = False
        CursosNoche.Text = "Cursos"
        ' 
        ' LabelCursosNoche
        ' 
        LabelCursosNoche.AutoSize = True
        LabelCursosNoche.Location = New Point(6, 30)
        LabelCursosNoche.Name = "LabelCursosNoche"
        LabelCursosNoche.Size = New Size(18, 20)
        LabelCursosNoche.TabIndex = 3
        LabelCursosNoche.Text = "."
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(6, 12)
        Label4.Name = "Label4"
        Label4.Size = New Size(99, 20)
        Label4.TabIndex = 2
        Label4.Text = "Empleados:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Cascadia Mono", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ButtonFace
        Label2.Location = New Point(30, 78)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 20)
        Label2.TabIndex = 17
        Label2.Text = "Label2"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Cascadia Mono", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.ButtonFace
        Label5.Location = New Point(30, 115)
        Label5.Name = "Label5"
        Label5.Size = New Size(360, 20)
        Label5.TabIndex = 18
        Label5.Text = "Mañana: 6am - 2pm  Tarde: 2pm - 10pm   "
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Cascadia Mono", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = SystemColors.ButtonFace
        Label6.Location = New Point(379, 115)
        Label6.Name = "Label6"
        Label6.Size = New Size(162, 20)
        Label6.TabIndex = 19
        Label6.Text = "Noche: 10pm - 6am"
        ' 
        ' Horarios
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(33), CByte(31), CByte(45))
        ClientSize = New Size(844, 584)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label2)
        Controls.Add(Cajita)
        Controls.Add(MonthCalendar1)
        Controls.Add(Label1)
        Name = "Horarios"
        Text = resources.GetString("$this.Text")
        Cajita.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        CursosMañana.ResumeLayout(False)
        CursosMañana.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        CursosTarde.ResumeLayout(False)
        CursosTarde.PerformLayout()
        TabPage3.ResumeLayout(False)
        TabPage3.PerformLayout()
        CursosNoche.ResumeLayout(False)
        CursosNoche.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents Cajita As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents empleados1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CursosMañana As GroupBox
    Friend WithEvents CursosTarde As GroupBox
    Friend WithEvents CursosNoche As GroupBox
    Friend WithEvents LabelCursoMañana As Label
    Friend WithEvents LabelCursosTarde As Label
    Friend WithEvents LabelCursosNoche As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
