<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCgpaResults
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        Course = New DataGridViewTextBoxColumn()
        Grade = New DataGridViewTextBoxColumn()
        GradePoint = New DataGridViewTextBoxColumn()
        Label2 = New Label()
        Label3 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Comic Sans MS", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(154, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(493, 67)
        Label1.TabIndex = 0
        Label1.Text = "CGPA CALCULATOR"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.ControlLightLight
        DataGridView1.BorderStyle = BorderStyle.Fixed3D
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Course, Grade, GradePoint})
        DataGridView1.Location = New Point(154, 182)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(493, 150)
        DataGridView1.TabIndex = 1
        ' 
        ' Course
        ' 
        Course.HeaderText = "Course"
        Course.Name = "Course"
        Course.ReadOnly = True
        Course.Width = 150
        ' 
        ' Grade
        ' 
        Grade.HeaderText = "Grade"
        Grade.Name = "Grade"
        Grade.ReadOnly = True
        Grade.Width = 150
        ' 
        ' GradePoint
        ' 
        GradePoint.HeaderText = "Grade Point"
        GradePoint.Name = "GradePoint"
        GradePoint.ReadOnly = True
        GradePoint.Width = 150
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(169, 402)
        Label2.Name = "Label2"
        Label2.Size = New Size(104, 32)
        Label2.TabIndex = 2
        Label2.Text = "CGPA = "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(270, 402)
        Label3.Name = "Label3"
        Label3.Size = New Size(45, 32)
        Label3.TabIndex = 3
        Label3.Text = "3.0"
        ' 
        ' frmCgpaResults
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 609)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(DataGridView1)
        Controls.Add(Label1)
        Name = "frmCgpaResults"
        Text = "CGPA Calculator"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Course As DataGridViewTextBoxColumn
    Friend WithEvents Grade As DataGridViewTextBoxColumn
    Friend WithEvents GradePoint As DataGridViewTextBoxColumn
End Class
