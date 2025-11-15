<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CourseInput
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CourseInput))
        dgvCourses = New DataGridView()
        course = New DataGridViewTextBoxColumn()
        grade = New DataGridViewTextBoxColumn()
        credit = New DataGridViewTextBoxColumn()
        GradePoint = New DataGridViewTextBoxColumn()
        btnCourseReset = New Button()
        btnCalulate = New Button()
        btnAddCourse = New Button()
        Panel1 = New Panel()
        Label2 = New Label()
        Label1 = New Label()
        lblCouseName = New Label()
        cmbGrade = New ComboBox()
        txtCredit = New TextBox()
        txtCourse = New TextBox()
        lblTitle = New Label()
        btnPreviousCourse = New Button()
        btnNextCourse = New Button()
        btnDelete = New Button()
        gbShowCgpa = New GroupBox()
        btnExit = New Button()
        btnBack = New Button()
        dgvDisplayCourses = New DataGridView()
        DataGridViewTextBoxColumn1 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn2 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn3 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn4 = New DataGridViewTextBoxColumn()
        Button1 = New Button()
        gbGPA = New GroupBox()
        gbHomePage = New GroupBox()
        Label3 = New Label()
        btnCloseApp = New Button()
        btnCalculateUsingGPA = New Button()
        btnCalculateUsingGrade = New Button()
        btnCGPACalculate2 = New Button()
        btnExitApplication = New Button()
        dgvGPA = New DataGridView()
        level = New DataGridViewTextBoxColumn()
        semester = New DataGridViewTextBoxColumn()
        gpa = New DataGridViewTextBoxColumn()
        totalCreditHrs = New DataGridViewTextBoxColumn()
        btnGPAReset = New Button()
        btnAddGPA = New Button()
        Panel2 = New Panel()
        rBtnSemester2 = New RadioButton()
        rBtnSemester1 = New RadioButton()
        Label8 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        cmbLevel = New ComboBox()
        txtGPA = New TextBox()
        txtTotalCreditHrs = New TextBox()
        Label4 = New Label()
        btnGpaDelete = New Button()
        btnGpaPrevious = New Button()
        btnGpaNext = New Button()
        btnHome = New Button()
        btnExitApp = New Button()
        TabPage2 = New TabPage()
        lblCgpaResults2 = New Label()
        lblDiplomaClass = New Label()
        TabPage1 = New TabPage()
        lblCgpaResults = New Label()
        lblDegreeClass = New Label()
        TabControl1 = New TabControl()
        DataGridViewTextBoxColumn8 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn7 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn6 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn5 = New DataGridViewTextBoxColumn()
        dgvDisplayGPA = New DataGridView()
        CType(dgvCourses, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        gbShowCgpa.SuspendLayout()
        CType(dgvDisplayCourses, ComponentModel.ISupportInitialize).BeginInit()
        gbGPA.SuspendLayout()
        gbHomePage.SuspendLayout()
        CType(dgvGPA, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        TabPage2.SuspendLayout()
        TabPage1.SuspendLayout()
        TabControl1.SuspendLayout()
        CType(dgvDisplayGPA, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvCourses
        ' 
        dgvCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCourses.Columns.AddRange(New DataGridViewColumn() {course, grade, credit, GradePoint})
        dgvCourses.Location = New Point(103, 571)
        dgvCourses.Name = "dgvCourses"
        dgvCourses.Size = New Size(604, 150)
        dgvCourses.TabIndex = 9
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
        ' btnCourseReset
        ' 
        btnCourseReset.Location = New Point(298, 440)
        btnCourseReset.Name = "btnCourseReset"
        btnCourseReset.Size = New Size(204, 36)
        btnCourseReset.TabIndex = 6
        btnCourseReset.Text = "Reset"
        btnCourseReset.UseVisualStyleBackColor = True
        ' 
        ' btnCalulate
        ' 
        btnCalulate.Location = New Point(194, 484)
        btnCalulate.Name = "btnCalulate"
        btnCalulate.Size = New Size(416, 45)
        btnCalulate.TabIndex = 7
        btnCalulate.Text = "Calculate CGPA"
        btnCalulate.UseVisualStyleBackColor = True
        ' 
        ' btnAddCourse
        ' 
        btnAddCourse.Location = New Point(268, 344)
        btnAddCourse.Name = "btnAddCourse"
        btnAddCourse.Size = New Size(268, 48)
        btnAddCourse.TabIndex = 8
        btnAddCourse.Text = "Add Course"
        btnAddCourse.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Azure
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(lblCouseName)
        Panel1.Controls.Add(cmbGrade)
        Panel1.Controls.Add(txtCredit)
        Panel1.Controls.Add(txtCourse)
        Panel1.Location = New Point(178, 160)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(444, 168)
        Panel1.TabIndex = 5
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
        cmbGrade.Items.AddRange(New Object() {"A", "B+", "B", "B-", "C+", "C", "C-", "D", "F", "X"})
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
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe Print", 39.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(157, 35)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(487, 94)
        lblTitle.TabIndex = 4
        lblTitle.Text = "CGPA Calculator"
        ' 
        ' btnPreviousCourse
        ' 
        btnPreviousCourse.Location = New Point(178, 344)
        btnPreviousCourse.Name = "btnPreviousCourse"
        btnPreviousCourse.Size = New Size(75, 132)
        btnPreviousCourse.TabIndex = 10
        btnPreviousCourse.Text = "<<" & vbCrLf & "Previous"
        btnPreviousCourse.UseVisualStyleBackColor = True
        ' 
        ' btnNextCourse
        ' 
        btnNextCourse.Location = New Point(547, 344)
        btnNextCourse.Name = "btnNextCourse"
        btnNextCourse.Size = New Size(75, 132)
        btnNextCourse.TabIndex = 10
        btnNextCourse.Text = ">>" & vbCrLf & "Next"
        btnNextCourse.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(298, 399)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(204, 35)
        btnDelete.TabIndex = 11
        btnDelete.Text = "Delete Course"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' gbShowCgpa
        ' 
        gbShowCgpa.Controls.Add(dgvDisplayGPA)
        gbShowCgpa.Controls.Add(TabControl1)
        gbShowCgpa.Controls.Add(btnExit)
        gbShowCgpa.Controls.Add(btnBack)
        gbShowCgpa.Controls.Add(dgvDisplayCourses)
        gbShowCgpa.Location = New Point(12, 132)
        gbShowCgpa.Name = "gbShowCgpa"
        gbShowCgpa.Size = New Size(776, 774)
        gbShowCgpa.TabIndex = 12
        gbShowCgpa.TabStop = False
        gbShowCgpa.Visible = False
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(391, 699)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(111, 39)
        btnExit.TabIndex = 12
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(274, 699)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(111, 39)
        btnBack.TabIndex = 12
        btnBack.Text = "Go Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' dgvDisplayCourses
        ' 
        dgvDisplayCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDisplayCourses.Columns.AddRange(New DataGridViewColumn() {DataGridViewTextBoxColumn1, DataGridViewTextBoxColumn2, DataGridViewTextBoxColumn3, DataGridViewTextBoxColumn4})
        dgvDisplayCourses.Location = New Point(86, 31)
        dgvDisplayCourses.Name = "dgvDisplayCourses"
        dgvDisplayCourses.ReadOnly = True
        dgvDisplayCourses.Size = New Size(604, 217)
        dgvDisplayCourses.TabIndex = 10
        ' 
        ' DataGridViewTextBoxColumn1
        ' 
        DataGridViewTextBoxColumn1.HeaderText = "Course"
        DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        DataGridViewTextBoxColumn1.ReadOnly = True
        DataGridViewTextBoxColumn1.Width = 140
        ' 
        ' DataGridViewTextBoxColumn2
        ' 
        DataGridViewTextBoxColumn2.HeaderText = "Grade"
        DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        DataGridViewTextBoxColumn2.ReadOnly = True
        DataGridViewTextBoxColumn2.Width = 140
        ' 
        ' DataGridViewTextBoxColumn3
        ' 
        DataGridViewTextBoxColumn3.HeaderText = "Credit Hours"
        DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        DataGridViewTextBoxColumn3.ReadOnly = True
        DataGridViewTextBoxColumn3.Width = 140
        ' 
        ' DataGridViewTextBoxColumn4
        ' 
        DataGridViewTextBoxColumn4.HeaderText = "Grade Point"
        DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        DataGridViewTextBoxColumn4.ReadOnly = True
        DataGridViewTextBoxColumn4.Width = 140
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Lavender
        Button1.Location = New Point(759, 12)
        Button1.Name = "Button1"
        Button1.Size = New Size(29, 23)
        Button1.TabIndex = 13
        Button1.Text = "?"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' gbGPA
        ' 
        gbGPA.Controls.Add(btnCGPACalculate2)
        gbGPA.Controls.Add(btnExitApplication)
        gbGPA.Controls.Add(dgvGPA)
        gbGPA.Controls.Add(btnGPAReset)
        gbGPA.Controls.Add(btnAddGPA)
        gbGPA.Controls.Add(Panel2)
        gbGPA.Controls.Add(Label4)
        gbGPA.Controls.Add(btnGpaDelete)
        gbGPA.Controls.Add(btnGpaPrevious)
        gbGPA.Controls.Add(btnGpaNext)
        gbGPA.Location = New Point(12, 35)
        gbGPA.Name = "gbGPA"
        gbGPA.Size = New Size(776, 871)
        gbGPA.TabIndex = 6
        gbGPA.TabStop = False
        gbGPA.Visible = False
        ' 
        ' gbHomePage
        ' 
        gbHomePage.Controls.Add(Label3)
        gbHomePage.Controls.Add(btnCloseApp)
        gbHomePage.Controls.Add(btnCalculateUsingGPA)
        gbHomePage.Controls.Add(btnCalculateUsingGrade)
        gbHomePage.Location = New Point(12, 41)
        gbHomePage.Name = "gbHomePage"
        gbHomePage.Size = New Size(776, 865)
        gbHomePage.TabIndex = 14
        gbHomePage.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe Print", 39.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(145, 11)
        Label3.Name = "Label3"
        Label3.Size = New Size(487, 94)
        Label3.TabIndex = 5
        Label3.Text = "CGPA Calculator"
        ' 
        ' btnCloseApp
        ' 
        btnCloseApp.BackColor = Color.MintCream
        btnCloseApp.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCloseApp.Location = New Point(632, 688)
        btnCloseApp.Name = "btnCloseApp"
        btnCloseApp.Size = New Size(87, 36)
        btnCloseApp.TabIndex = 1
        btnCloseApp.Text = "Close"
        btnCloseApp.UseVisualStyleBackColor = False
        ' 
        ' btnCalculateUsingGPA
        ' 
        btnCalculateUsingGPA.BackColor = Color.PaleTurquoise
        btnCalculateUsingGPA.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCalculateUsingGPA.Location = New Point(245, 327)
        btnCalculateUsingGPA.Name = "btnCalculateUsingGPA"
        btnCalculateUsingGPA.Size = New Size(286, 58)
        btnCalculateUsingGPA.TabIndex = 0
        btnCalculateUsingGPA.Text = "Caluclate Using GPA"
        btnCalculateUsingGPA.UseVisualStyleBackColor = False
        ' 
        ' btnCalculateUsingGrade
        ' 
        btnCalculateUsingGrade.BackColor = Color.PaleTurquoise
        btnCalculateUsingGrade.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCalculateUsingGrade.Location = New Point(245, 394)
        btnCalculateUsingGrade.Name = "btnCalculateUsingGrade"
        btnCalculateUsingGrade.Size = New Size(286, 58)
        btnCalculateUsingGrade.TabIndex = 0
        btnCalculateUsingGrade.Text = "Caluclate Using Grade"
        btnCalculateUsingGrade.UseVisualStyleBackColor = False
        ' 
        ' btnCGPACalculate2
        ' 
        btnCGPACalculate2.Location = New Point(182, 458)
        btnCGPACalculate2.Name = "btnCGPACalculate2"
        btnCGPACalculate2.Size = New Size(416, 66)
        btnCGPACalculate2.TabIndex = 13
        btnCGPACalculate2.Text = "Calculate CGPA"
        btnCGPACalculate2.UseVisualStyleBackColor = True
        ' 
        ' btnExitApplication
        ' 
        btnExitApplication.BackColor = Color.MintCream
        btnExitApplication.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnExitApplication.Location = New Point(608, 790)
        btnExitApplication.Name = "btnExitApplication"
        btnExitApplication.Size = New Size(87, 36)
        btnExitApplication.TabIndex = 12
        btnExitApplication.Text = "Exit"
        btnExitApplication.UseVisualStyleBackColor = False
        ' 
        ' dgvGPA
        ' 
        dgvGPA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvGPA.Columns.AddRange(New DataGridViewColumn() {level, semester, gpa, totalCreditHrs})
        dgvGPA.Location = New Point(87, 545)
        dgvGPA.Name = "dgvGPA"
        dgvGPA.Size = New Size(603, 150)
        dgvGPA.TabIndex = 11
        ' 
        ' level
        ' 
        level.HeaderText = "Level"
        level.Name = "level"
        level.ReadOnly = True
        level.Width = 140
        ' 
        ' semester
        ' 
        semester.HeaderText = "Semester"
        semester.Name = "semester"
        semester.ReadOnly = True
        semester.Width = 140
        ' 
        ' gpa
        ' 
        gpa.HeaderText = "GPA"
        gpa.Name = "gpa"
        gpa.ReadOnly = True
        gpa.Width = 140
        ' 
        ' totalCreditHrs
        ' 
        totalCreditHrs.HeaderText = "Total Credit Hours"
        totalCreditHrs.Name = "totalCreditHrs"
        totalCreditHrs.ReadOnly = True
        totalCreditHrs.Width = 140
        ' 
        ' btnGPAReset
        ' 
        btnGPAReset.Location = New Point(391, 393)
        btnGPAReset.Name = "btnGPAReset"
        btnGPAReset.Size = New Size(99, 57)
        btnGPAReset.TabIndex = 8
        btnGPAReset.Text = "Reset"
        btnGPAReset.UseVisualStyleBackColor = True
        ' 
        ' btnAddGPA
        ' 
        btnAddGPA.Location = New Point(180, 336)
        btnAddGPA.Name = "btnAddGPA"
        btnAddGPA.Size = New Size(416, 51)
        btnAddGPA.TabIndex = 10
        btnAddGPA.Text = "Add GPA"
        btnAddGPA.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Azure
        Panel2.Controls.Add(rBtnSemester2)
        Panel2.Controls.Add(rBtnSemester1)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(cmbLevel)
        Panel2.Controls.Add(txtGPA)
        Panel2.Controls.Add(txtTotalCreditHrs)
        Panel2.Location = New Point(139, 119)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(499, 205)
        Panel2.TabIndex = 7
        ' 
        ' rBtnSemester2
        ' 
        rBtnSemester2.AutoSize = True
        rBtnSemester2.Location = New Point(304, 59)
        rBtnSemester2.Name = "rBtnSemester2"
        rBtnSemester2.Size = New Size(96, 19)
        rBtnSemester2.TabIndex = 12
        rBtnSemester2.TabStop = True
        rBtnSemester2.Text = "2nd Semester"
        rBtnSemester2.UseVisualStyleBackColor = True
        ' 
        ' rBtnSemester1
        ' 
        rBtnSemester1.AutoSize = True
        rBtnSemester1.Location = New Point(164, 59)
        rBtnSemester1.Name = "rBtnSemester1"
        rBtnSemester1.Size = New Size(91, 19)
        rBtnSemester1.TabIndex = 12
        rBtnSemester1.TabStop = True
        rBtnSemester1.Text = "1st Semester"
        rBtnSemester1.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(16, 59)
        Label8.Name = "Label8"
        Label8.Size = New Size(79, 21)
        Label8.TabIndex = 2
        Label8.Text = "Semester"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(16, 99)
        Label5.Name = "Label5"
        Label5.Size = New Size(40, 21)
        Label5.TabIndex = 2
        Label5.Text = "GPA"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(16, 19)
        Label6.Name = "Label6"
        Label6.Size = New Size(48, 21)
        Label6.TabIndex = 2
        Label6.Text = "Level"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(16, 139)
        Label7.Name = "Label7"
        Label7.Size = New Size(142, 21)
        Label7.TabIndex = 2
        Label7.Text = "Total Credit Hours"
        ' 
        ' cmbLevel
        ' 
        cmbLevel.AutoCompleteCustomSource.AddRange(New String() {"A", "B+", "B", "B-", "C+", "C", "C-", "D", "E", "F"})
        cmbLevel.FormattingEnabled = True
        cmbLevel.Items.AddRange(New Object() {"100", "200", "300", "400"})
        cmbLevel.Location = New Point(164, 19)
        cmbLevel.Name = "cmbLevel"
        cmbLevel.Size = New Size(314, 23)
        cmbLevel.TabIndex = 3
        ' 
        ' txtGPA
        ' 
        txtGPA.Location = New Point(164, 95)
        txtGPA.Multiline = True
        txtGPA.Name = "txtGPA"
        txtGPA.Size = New Size(314, 29)
        txtGPA.TabIndex = 2
        ' 
        ' txtTotalCreditHrs
        ' 
        txtTotalCreditHrs.Location = New Point(164, 137)
        txtTotalCreditHrs.Multiline = True
        txtTotalCreditHrs.Name = "txtTotalCreditHrs"
        txtTotalCreditHrs.Size = New Size(314, 29)
        txtTotalCreditHrs.TabIndex = 2
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe Print", 39.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(145, 12)
        Label4.Name = "Label4"
        Label4.Size = New Size(487, 94)
        Label4.TabIndex = 6
        Label4.Text = "CGPA Calculator"
        ' 
        ' btnGpaDelete
        ' 
        btnGpaDelete.Location = New Point(286, 393)
        btnGpaDelete.Name = "btnGpaDelete"
        btnGpaDelete.Size = New Size(99, 57)
        btnGpaDelete.TabIndex = 15
        btnGpaDelete.Text = "Delete"
        btnGpaDelete.UseVisualStyleBackColor = True
        ' 
        ' btnGpaPrevious
        ' 
        btnGpaPrevious.Location = New Point(192, 397)
        btnGpaPrevious.Name = "btnGpaPrevious"
        btnGpaPrevious.Size = New Size(75, 49)
        btnGpaPrevious.TabIndex = 16
        btnGpaPrevious.Text = "<<" & vbCrLf & "Previous"
        btnGpaPrevious.UseVisualStyleBackColor = True
        ' 
        ' btnGpaNext
        ' 
        btnGpaNext.Location = New Point(510, 397)
        btnGpaNext.Name = "btnGpaNext"
        btnGpaNext.Size = New Size(75, 49)
        btnGpaNext.TabIndex = 16
        btnGpaNext.Text = ">>" & vbCrLf & "Next"
        btnGpaNext.UseVisualStyleBackColor = True
        ' 
        ' btnHome
        ' 
        btnHome.BackColor = Color.Azure
        btnHome.Image = CType(resources.GetObject("btnHome.Image"), Image)
        btnHome.Location = New Point(12, 12)
        btnHome.Name = "btnHome"
        btnHome.Size = New Size(75, 23)
        btnHome.TabIndex = 15
        btnHome.Text = "Home"
        btnHome.UseVisualStyleBackColor = False
        ' 
        ' btnExitApp
        ' 
        btnExitApp.BackColor = Color.MintCream
        btnExitApp.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnExitApp.Location = New Point(620, 802)
        btnExitApp.Name = "btnExitApp"
        btnExitApp.Size = New Size(87, 36)
        btnExitApp.TabIndex = 16
        btnExitApp.Text = "Exit"
        btnExitApp.UseVisualStyleBackColor = False
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(lblDiplomaClass)
        TabPage2.Controls.Add(lblCgpaResults2)
        TabPage2.Location = New Point(4, 29)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(596, 329)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Diploma"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' lblCgpaResults2
        ' 
        lblCgpaResults2.AutoSize = True
        lblCgpaResults2.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCgpaResults2.Location = New Point(26, 26)
        lblCgpaResults2.Name = "lblCgpaResults2"
        lblCgpaResults2.Size = New Size(119, 30)
        lblCgpaResults2.TabIndex = 12
        lblCgpaResults2.Text = "Your CGPA:"
        ' 
        ' lblDiplomaClass
        ' 
        lblDiplomaClass.AutoSize = True
        lblDiplomaClass.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDiplomaClass.Location = New Point(26, 65)
        lblDiplomaClass.Name = "lblDiplomaClass"
        lblDiplomaClass.Size = New Size(178, 30)
        lblDiplomaClass.TabIndex = 12
        lblDiplomaClass.Text = "Class of Diploma:"
        ' 
        ' TabPage1
        ' 
        TabPage1.AutoScroll = True
        TabPage1.Controls.Add(lblDegreeClass)
        TabPage1.Controls.Add(lblCgpaResults)
        TabPage1.Location = New Point(4, 29)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(596, 329)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Degree"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' lblCgpaResults
        ' 
        lblCgpaResults.AutoSize = True
        lblCgpaResults.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCgpaResults.Location = New Point(27, 26)
        lblCgpaResults.Name = "lblCgpaResults"
        lblCgpaResults.Size = New Size(119, 30)
        lblCgpaResults.TabIndex = 11
        lblCgpaResults.Text = "Your CGPA:"
        ' 
        ' lblDegreeClass
        ' 
        lblDegreeClass.AutoSize = True
        lblDegreeClass.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDegreeClass.Location = New Point(27, 65)
        lblDegreeClass.Name = "lblDegreeClass"
        lblDegreeClass.Size = New Size(172, 30)
        lblDegreeClass.TabIndex = 11
        lblDegreeClass.Text = "Class of Degree: "
        ' 
        ' TabControl1
        ' 
        TabControl1.CausesValidation = False
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TabControl1.Location = New Point(86, 302)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(604, 362)
        TabControl1.TabIndex = 13
        ' 
        ' DataGridViewTextBoxColumn8
        ' 
        DataGridViewTextBoxColumn8.HeaderText = "Total Credit Hours"
        DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        DataGridViewTextBoxColumn8.ReadOnly = True
        DataGridViewTextBoxColumn8.Width = 140
        ' 
        ' DataGridViewTextBoxColumn7
        ' 
        DataGridViewTextBoxColumn7.HeaderText = "GPA"
        DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        DataGridViewTextBoxColumn7.ReadOnly = True
        DataGridViewTextBoxColumn7.Width = 140
        ' 
        ' DataGridViewTextBoxColumn6
        ' 
        DataGridViewTextBoxColumn6.HeaderText = "Semester"
        DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        DataGridViewTextBoxColumn6.ReadOnly = True
        DataGridViewTextBoxColumn6.Width = 140
        ' 
        ' DataGridViewTextBoxColumn5
        ' 
        DataGridViewTextBoxColumn5.HeaderText = "Level"
        DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        DataGridViewTextBoxColumn5.ReadOnly = True
        DataGridViewTextBoxColumn5.Width = 140
        ' 
        ' dgvDisplayGPA
        ' 
        dgvDisplayGPA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDisplayGPA.Columns.AddRange(New DataGridViewColumn() {DataGridViewTextBoxColumn5, DataGridViewTextBoxColumn6, DataGridViewTextBoxColumn7, DataGridViewTextBoxColumn8})
        dgvDisplayGPA.Location = New Point(86, 31)
        dgvDisplayGPA.Name = "dgvDisplayGPA"
        dgvDisplayGPA.ReadOnly = True
        dgvDisplayGPA.Size = New Size(604, 217)
        dgvDisplayGPA.TabIndex = 14
        dgvDisplayGPA.Visible = False
        ' 
        ' CourseInput
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightCyan
        ClientSize = New Size(800, 918)
        Controls.Add(gbHomePage)
        Controls.Add(gbGPA)
        Controls.Add(gbShowCgpa)
        Controls.Add(btnDelete)
        Controls.Add(btnNextCourse)
        Controls.Add(btnPreviousCourse)
        Controls.Add(dgvCourses)
        Controls.Add(btnCourseReset)
        Controls.Add(btnCalulate)
        Controls.Add(btnAddCourse)
        Controls.Add(Panel1)
        Controls.Add(lblTitle)
        Controls.Add(btnExitApp)
        Controls.Add(btnHome)
        Controls.Add(Button1)
        Name = "CourseInput"
        Text = "CourseInput"
        CType(dgvCourses, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        gbShowCgpa.ResumeLayout(False)
        CType(dgvDisplayCourses, ComponentModel.ISupportInitialize).EndInit()
        gbGPA.ResumeLayout(False)
        gbGPA.PerformLayout()
        gbHomePage.ResumeLayout(False)
        gbHomePage.PerformLayout()
        CType(dgvGPA, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabControl1.ResumeLayout(False)
        CType(dgvDisplayGPA, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvCourses As DataGridView
    Friend WithEvents course As DataGridViewTextBoxColumn
    Friend WithEvents grade As DataGridViewTextBoxColumn
    Friend WithEvents credit As DataGridViewTextBoxColumn
    Friend WithEvents GradePoint As DataGridViewTextBoxColumn
    Friend WithEvents btnCourseReset As Button
    Friend WithEvents btnCalulate As Button
    Friend WithEvents btnAddCourse As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblCouseName As Label
    Friend WithEvents cmbGrade As ComboBox
    Friend WithEvents txtCredit As TextBox
    Friend WithEvents txtCourse As TextBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnPreviousCourse As Button
    Friend WithEvents btnNextCourse As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents gbShowCgpa As GroupBox
    Friend WithEvents dgvDisplayCourses As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents btnExit As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents btnExitApp As Button
    Friend WithEvents gbGPA As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dgvGPA As DataGridView
    Friend WithEvents btnGPAReset As Button
    Friend WithEvents btnAddGPA As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbLevel As ComboBox
    Friend WithEvents txtGPA As TextBox
    Friend WithEvents txtTotalCreditHrs As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents rBtnSemester2 As RadioButton
    Friend WithEvents rBtnSemester1 As RadioButton
    Friend WithEvents btnExitApplication As Button
    Friend WithEvents btnCGPACalculate2 As Button
    Friend WithEvents level As DataGridViewTextBoxColumn
    Friend WithEvents semester As DataGridViewTextBoxColumn
    Friend WithEvents gpa As DataGridViewTextBoxColumn
    Friend WithEvents totalCreditHrs As DataGridViewTextBoxColumn
    Friend WithEvents btnGpaPrevious As Button
    Friend WithEvents btnGpaDelete As Button
    Friend WithEvents btnGpaNext As Button
    Friend WithEvents gbHomePage As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCloseApp As Button
    Friend WithEvents btnCalculateUsingGrade As Button
    Friend WithEvents btnCalculateUsingGPA As Button
    Friend WithEvents dgvDisplayGPA As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents lblDegreeClass As Label
    Friend WithEvents lblCgpaResults As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents lblDiplomaClass As Label
    Friend WithEvents lblCgpaResults2 As Label
End Class
