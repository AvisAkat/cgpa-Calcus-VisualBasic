<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cgpaCalcusVersion2
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
        lblTitle = New Label()
        Panel1 = New Panel()
        Label2 = New Label()
        Label1 = New Label()
        lblCouseName = New Label()
        cmbGrade = New ComboBox()
        txtCredit = New TextBox()
        txtCourse = New TextBox()
        btnAddCourse = New Button()
        btnCourseReset = New Button()
        btnCalulate = New Button()
        dgvCourses = New DataGridView()
        course = New DataGridViewTextBoxColumn()
        grade = New DataGridViewTextBoxColumn()
        credit = New DataGridViewTextBoxColumn()
        GradePoint = New DataGridViewTextBoxColumn()
        lblCgpaResults = New Label()
        Panel1.SuspendLayout()
        CType(dgvCourses, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe Print", 39.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(157, 20)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(487, 94)
        lblTitle.TabIndex = 0
        lblTitle.Text = "CGPA Calculator"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(lblCouseName)
        Panel1.Controls.Add(cmbGrade)
        Panel1.Controls.Add(txtCredit)
        Panel1.Controls.Add(txtCourse)
        Panel1.Location = New Point(178, 145)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(444, 168)
        Panel1.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(16, 105)
        Label2.Name = "Label2"
        Label2.Size = New Size(55, 21)
        Label2.TabIndex = 2
        Label2.Text = "Credit"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(16, 63)
        Label1.Name = "Label1"
        Label1.Size = New Size(54, 21)
        Label1.TabIndex = 2
        Label1.Text = "Grade"
        ' 
        ' lblCouseName
        ' 
        lblCouseName.AutoSize = True
        lblCouseName.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCouseName.Location = New Point(16, 23)
        lblCouseName.Name = "lblCouseName"
        lblCouseName.Size = New Size(61, 21)
        lblCouseName.TabIndex = 2
        lblCouseName.Text = "Course"
        ' 
        ' cmbGrade
        ' 
        cmbGrade.AutoCompleteCustomSource.AddRange(New String() {"A", "B+", "B", "B-", "C+", "C", "C-", "D", "E", "F"})
        cmbGrade.FormattingEnabled = True
        cmbGrade.Items.AddRange(New Object() {"A", "B+", "B", "B-", "C+", "C", "C-", "D", "E", "F"})
        cmbGrade.Location = New Point(106, 61)
        cmbGrade.Name = "cmbGrade"
        cmbGrade.Size = New Size(326, 23)
        cmbGrade.TabIndex = 3
        ' 
        ' txtCredit
        ' 
        txtCredit.Location = New Point(106, 100)
        txtCredit.Multiline = True
        txtCredit.Name = "txtCredit"
        txtCredit.Size = New Size(326, 29)
        txtCredit.TabIndex = 2
        ' 
        ' txtCourse
        ' 
        txtCourse.Location = New Point(106, 19)
        txtCourse.Multiline = True
        txtCourse.Name = "txtCourse"
        txtCourse.Size = New Size(326, 29)
        txtCourse.TabIndex = 2
        ' 
        ' btnAddCourse
        ' 
        btnAddCourse.Location = New Point(194, 351)
        btnAddCourse.Name = "btnAddCourse"
        btnAddCourse.Size = New Size(204, 36)
        btnAddCourse.TabIndex = 2
        btnAddCourse.Text = "Add Course"
        btnAddCourse.UseVisualStyleBackColor = True
        ' 
        ' btnCourseReset
        ' 
        btnCourseReset.Location = New Point(406, 351)
        btnCourseReset.Name = "btnCourseReset"
        btnCourseReset.Size = New Size(204, 36)
        btnCourseReset.TabIndex = 2
        btnCourseReset.Text = "Reset"
        btnCourseReset.UseVisualStyleBackColor = True
        ' 
        ' btnCalulate
        ' 
        btnCalulate.Location = New Point(194, 402)
        btnCalulate.Name = "btnCalulate"
        btnCalulate.Size = New Size(416, 45)
        btnCalulate.TabIndex = 2
        btnCalulate.Text = "Calculate CGPA"
        btnCalulate.UseVisualStyleBackColor = True
        ' 
        ' dgvCourses
        ' 
        dgvCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCourses.Columns.AddRange(New DataGridViewColumn() {course, grade, credit, GradePoint})
        dgvCourses.Location = New Point(99, 489)
        dgvCourses.Name = "dgvCourses"
        dgvCourses.Size = New Size(603, 150)
        dgvCourses.TabIndex = 3
        ' 
        ' course
        ' 
        course.HeaderText = "Course"
        course.Name = "course"
        course.ReadOnly = True
        course.Width = 140
        ' 
        ' grade
        ' 
        grade.HeaderText = "Grade"
        grade.Name = "grade"
        grade.ReadOnly = True
        grade.Width = 140
        ' 
        ' credit
        ' 
        credit.HeaderText = "Credit Hours"
        credit.Name = "credit"
        credit.ReadOnly = True
        credit.Width = 140
        ' 
        ' GradePoint
        ' 
        GradePoint.HeaderText = "Grade Point"
        GradePoint.Name = "GradePoint"
        GradePoint.ReadOnly = True
        GradePoint.Width = 140
        ' 
        ' lblCgpaResults
        ' 
        lblCgpaResults.AutoSize = True
        lblCgpaResults.Location = New Point(190, 676)
        lblCgpaResults.Name = "lblCgpaResults"
        lblCgpaResults.Size = New Size(46, 15)
        lblCgpaResults.TabIndex = 4
        lblCgpaResults.Text = "             "
        ' 
        ' cgpaCalcusVersion2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 772)
        Controls.Add(lblCgpaResults)
        Controls.Add(dgvCourses)
        Controls.Add(btnCourseReset)
        Controls.Add(btnCalulate)
        Controls.Add(btnAddCourse)
        Controls.Add(Panel1)
        Controls.Add(lblTitle)
        Name = "cgpaCalcusVersion2"
        Text = "cgpaCalcusVersion2"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(dgvCourses, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cmbGrade As ComboBox
    Friend WithEvents txtCredit As TextBox
    Friend WithEvents txtCourse As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblCouseName As Label
    Friend WithEvents btnAddCourse As Button
    Friend WithEvents btnCourseReset As Button
    Friend WithEvents btnCalulate As Button
    Friend WithEvents dgvCourses As DataGridView
    Friend WithEvents course As DataGridViewTextBoxColumn
    Friend WithEvents grade As DataGridViewTextBoxColumn
    Friend WithEvents credit As DataGridViewTextBoxColumn
    Friend WithEvents GradePoint As DataGridViewTextBoxColumn
    Friend WithEvents lblCgpaResults As Label
End Class
