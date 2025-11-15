Imports Microsoft.VisualBasic.Devices

Public Class cgpaCalcusVersion3
    'Variable for Calculating CGPA using Course
    Private intCoursesRowCounter As Integer = 0 'for the previoius and next button
    Private boolIsAddCourse As Boolean = True

    'Variable for Calculating CGPA using GPA
    Private boolIsAddGPA As Boolean = True
    Private intGpaRowCounter As Integer = 0





    ' === Function to get grade points based on letter grade ===
    Private Function GetGradePoint(ByVal grade As String) As Double
        Select Case grade.ToUpper()
            Case "A"
                Return 12.0
            Case "B+"
                Return 10.5
            Case "B"
                Return 9.0
            Case "B-"
                Return 7.5
            Case "C+"
                Return 6.0
            Case "C"
                Return 4.5
            Case "C-"
                Return 3.0
            Case "D"
                Return 1.5
            Case "F"
                Return 0.0
            Case "X"
                Return 0.0
            Case Else
                Return 0.0
        End Select
    End Function

    'Degree cgpa classification
    Function DegreeClassification(ByVal dblCgpa As Double) As String
        Select Case dblCgpa
            Case > 4.0
                Return "Invalid"
            Case >= 3.6
                Return "First Class"
            Case >= 3.0
                Return "Second Class Upper"
            Case >= 2.5
                Return "Second Class Lower"
            Case >= 2.0
                Return "Third Class"
            Case >= 1.0
                Return "Pass"
            Case < 1.0
                Return "Fail"
            Case Else
                Return "Invalid"
        End Select
    End Function

    'Diploma cgpa classification
    Function DiplomaClassification(ByVal dblCgpa As Double) As String
        Select Case dblCgpa
            Case > 4.0
                Return "Invalid"
            Case >= 3.5
                Return "Distinction"
            Case >= 2.5
                Return "Credit"
            Case >= 1.0
                Return "Pass"
            Case < 1.0
                Return "Fail"
            Case Else
                Return "Invalid"
        End Select
    End Function


    Private Sub cgpaCalcusVersion3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvCourses.AllowUserToAddRows = False
        dgvGPA.AllowUserToAddRows = False
        txtCourse.Focus()
    End Sub


    Private Sub btnAddCourse_Click(sender As Object, e As EventArgs)
        Dim course = txtCourse.Text.Trim
        Dim credit As Double
        Dim grade = cmbGrade.Text.ToUpper

        If grade <> "A" And grade <> "B+" And grade <> "B" And grade <> "B-" And grade <> "C+" And grade <> "C" And grade <> "C-" And grade <> "D" And grade <> "F" And grade <> "X" Then
            MessageBox.Show("Please enter the apporiate grade!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Validate inputs
        If course = "" Or Not Double.TryParse(txtCredit.Text, credit) Or credit <= 0 Or grade = "" Then
            MessageBox.Show("Please fill all fields correctly!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Get grade point
        Dim gradePoint = GetGradePoint(grade)


        If boolIsAddCourse = True Then
            ' Add to DataGridView
            dgvCourses.Rows.Add(course, grade, credit, gradePoint)

            'Counting the number of courses entered
            intCoursesRowCounter += 1

            ' Clear inputs
            txtCourse.Clear()
            txtCredit.Clear()
            cmbGrade.Text = ""
            cmbGrade.SelectedIndex = -1


        Else
            'Edit Course in dataGridView

            'Getting a row from the datagrid
            Dim specificRow As DataGridViewRow
            Dim intEditIndex = intCoursesRowCounter

            specificRow = dgvCourses.Rows(intEditIndex)
            specificRow.Cells("course").Value = course
            specificRow.Cells("credit").Value = credit
            specificRow.Cells("grade").Value = grade
            specificRow.Cells("gradePoint").Value = GetGradePoint(grade)

            'Acquiring data from the grid and displaying to text boxes
            specificRow = dgvCourses.Rows(intEditIndex)
            txtCourse.Text = specificRow.Cells("course").Value
            txtCredit.Text = specificRow.Cells("credit").Value
            cmbGrade.Text = specificRow.Cells("grade").Value

            MessageBox.Show("Editted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)


        End If


    End Sub

    Private Sub btnCalulate_Click(sender As Object, e As EventArgs)

        If dgvCourses.Rows.Count = 0 Then
            MessageBox.Show("Please add at least one course!", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        gbShowCgpa.Visible = True
        dgvDisplayGPA.Visible = False
        dgvDisplayCourses.Visible = True

        'populating display courses grid
        dgvDisplayCourses.Rows.Clear()

        For Each row As DataGridViewRow In dgvCourses.Rows
            Dim strCourse As String = row.Cells("course").Value
            Dim strGrade As String = row.Cells("grade").Value
            Dim dblCreditHrs = Val(row.Cells("Credit").Value)
            Dim dblGradePoint = Val(row.Cells("GradePoint").Value)

            dgvDisplayCourses.Rows.Add(strCourse, strGrade, dblCreditHrs, dblGradePoint)

        Next

        Dim totalCreditsHrs As Double = 0
        Dim totalGradePoints As Double = 0

        ' Loop through the rows to calculate total
        For Each row As DataGridViewRow In dgvCourses.Rows
            Dim creditHrs = Val(row.Cells("Credit").Value)
            Dim gradePoint = Val(row.Cells("GradePoint").Value)
            totalCreditsHrs += creditHrs
            totalGradePoints += gradePoint
        Next

        ' Compute CGPA
        Dim dblcgpa = totalGradePoints / totalCreditsHrs
        lblCgpaResults.Text = "Your CGPA: " & Math.Round(dblcgpa, 2).ToString
        lblCgpaResults2.Text = "Your CGPA: " & Math.Round(dblcgpa, 2).ToString

        lblDegreeClass.Text = "Class of Degree: " & DegreeClassification(dblcgpa)
        lblDiplomaClass.Text = "Class of Diploma: " & DiplomaClassification(dblcgpa)

    End Sub

    Private Sub btnCourseReset_Click(sender As Object, e As EventArgs)

        Dim confirmReset = MessageBox.Show("Are you sure you want to reset", "Confirm Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirmReset = DialogResult.Yes Then
            txtCourse.Clear()
            txtCredit.Clear()
            cmbGrade.SelectedIndex = -1
            dgvCourses.Rows.Clear()
        Else
            Exit Sub
        End If


    End Sub

    Private Sub btnPreviousCourse_Click(sender As Object, e As EventArgs)

        If dgvCourses.Rows.Count <= 0 Or intCoursesRowCounter = 0 Then
            Exit Sub
        End If

        'updating Add course button
        btnAddCourse.Text = "Edit Course"
        boolIsAddCourse = False

        'Getting a row from the datagrid
        Dim specificRow As DataGridViewRow
        Dim intPreviousIndex = intCoursesRowCounter - 1


        If dgvCourses.Rows.Count >= 1 Then
            specificRow = dgvCourses.Rows(intPreviousIndex)
            txtCourse.Text = specificRow.Cells("course").Value
            txtCredit.Text = specificRow.Cells("credit").Value
            cmbGrade.Text = specificRow.Cells("grade").Value
        End If

        'Updating row Counter
        intCoursesRowCounter -= 1


    End Sub

    Private Sub btnNextCourse_Click(sender As Object, e As EventArgs)

        If dgvCourses.Rows.Count <= 0 Or intCoursesRowCounter = dgvCourses.Rows.Count Or intCoursesRowCounter < 0 Then
            Exit Sub
        End If

        'Getting a row from the datagrid
        Dim specificRow As DataGridViewRow
        Dim intNextIndex As Integer


        If dgvCourses.Rows.Count >= 1 Then

            If dgvCourses.Rows.Count = intCoursesRowCounter + 1 Then
                txtCourse.Clear()
                txtCredit.Clear()
                cmbGrade.SelectedIndex = -1

                'updating add course button
                btnAddCourse.Text = "Add Course"
                boolIsAddCourse = True

                'Updating row Counter
                intCoursesRowCounter = intCoursesRowCounter + 1

                Exit Sub

            Else
                'updating index for the fetching specific data from grid
                intNextIndex = intCoursesRowCounter + 1

            End If

            'Acquiring data from the grid and displaying to text boxes
            specificRow = dgvCourses.Rows(intNextIndex)
            txtCourse.Text = specificRow.Cells("course").Value
            txtCredit.Text = specificRow.Cells("credit").Value
            cmbGrade.Text = specificRow.Cells("grade").Value
        End If

        'Updating row Counter
        intCoursesRowCounter += 1

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs)
        If dgvCourses.Rows.Count <= 0 Or intCoursesRowCounter = dgvCourses.Rows.Count Or intCoursesRowCounter < 0 Or txtCourse.Text = "" Or txtCredit.Text = "" Then
            MessageBox.Show("Invalid Command", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim confirmDelete = MessageBox.Show("Are you sure you want to delete", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        Dim intDeleteIndex = intCoursesRowCounter

        If confirmDelete = DialogResult.Yes Then

            dgvCourses.Rows.RemoveAt(intDeleteIndex)

            btnAddCourse.Text = "Add Course"
            boolIsAddCourse = True

            'updating row counting
            intCoursesRowCounter = dgvCourses.Rows.Count

            txtCourse.Clear()
            txtCredit.Clear()
            cmbGrade.SelectedIndex = -1
        Else
            Exit Sub
        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        gbShowCgpa.Visible = False
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click, btnExitApplication.Click, btnCloseApp.Click

        Dim result = MessageBox.Show("Are you sure you want to exit", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Close()
        End If
    End Sub

    Private Sub btnCalculateUsingGrade_Click(sender As Object, e As EventArgs) Handles btnCalculateUsingGrade.Click
        gbShowCgpa.Visible = False
        gbGPA.Visible = False
        gbCourse.Visible = True
    End Sub

    Private Sub btnCaluculateUsingGPA_Click(sender As Object, e As EventArgs) Handles btnCalculateUsingGPA.Click
        gbCourse.Visible = False
        gbShowCgpa.Visible = False
        gbGPA.Visible = True
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        gbShowCgpa.Visible = False
        gbGPA.Visible = False
        gbCourse.Visible = False
    End Sub

    Private Sub btnAddGPA_Click(sender As Object, e As EventArgs) Handles btnAddGPA.Click

        If txtGPA.Text = "" Or cmbLevel.Text = "" Or txtTotalCreditHrs.Text = "" Then
            MessageBox.Show("All fields are required", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbLevel.Focus()
            Exit Sub
        End If

        Dim strLevel As String = cmbLevel.Text
        Dim strSemester As String
        Dim dblGpa As Double = CDbl(txtGPA.Text)
        Dim intTotalCreditHrs As Integer = CInt(txtTotalCreditHrs.Text)


        'Validation
        If rBtnSemester1.Checked = True Then
            strSemester = "1st Semester"
        ElseIf rBtnSemester2.Checked = True Then
            strSemester = "2nd Semester"
        Else
            MessageBox.Show("Please select a semester", "Semester Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbLevel.Focus()
            Exit Sub
        End If

        If strLevel <> "100" And strLevel <> "200" And strLevel <> "300" And strLevel <> "400" Then
            MessageBox.Show("Please select the appropriate level", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbLevel.Focus()
            Exit Sub
        End If

        If intTotalCreditHrs <= 0 Or dblGpa < 0 Or dblGpa > 4.0 Then
            MessageBox.Show("Please fill all fields correctly!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbLevel.Focus()
            Exit Sub
        End If


        If boolIsAddGPA = True Then

            For Each row As DataGridViewRow In dgvGPA.Rows
                Dim semester = row.Cells("semester").Value
                Dim level = row.Cells("level").Value

                If semester = strSemester And level = strLevel Then
                    MessageBox.Show("You have already entered GPA for this semester!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtGPA.Text = dblGpa
                    txtTotalCreditHrs.Text = intTotalCreditHrs
                    cmbLevel.Focus()
                    Exit Sub
                End If

            Next

            ' Add to DataGridView
            dgvGPA.Rows.Add(strLevel, strSemester, dblGpa, intTotalCreditHrs)

            'Counting the number of courses entered
            intGpaRowCounter += 1

            ' Clear inputs
            txtGPA.Clear()
            txtTotalCreditHrs.Clear()
            cmbLevel.Text = ""
            cmbLevel.SelectedIndex = -1
            rBtnSemester1.Checked = False
            rBtnSemester2.Checked = False


        Else
            'Edit GPA in dataGridView

            'Getting a row from the datagrid
            Dim specificRow As DataGridViewRow
            Dim intEditIndex = intGpaRowCounter

            specificRow = dgvCourses.Rows(intEditIndex)
            specificRow.Cells("course").Value = course
            specificRow.Cells("credit").Value = credit
            specificRow.Cells("grade").Value = grade
            specificRow.Cells("gradePoint").Value = 1

            'Acquiring data from the grid and displaying to text boxes
            specificRow = dgvCourses.Rows(intEditIndex)
            txtCourse.Text = specificRow.Cells("course").Value
            txtCredit.Text = specificRow.Cells("credit").Value
            cmbGrade.Text = specificRow.Cells("grade").Value

            MessageBox.Show("Editted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)


        End If
    End Sub

    Private Sub btnGPAReset_Click(sender As Object, e As EventArgs) Handles btnGPAReset.Click
        If dgvGPA.Rows.Count = 0 Then Exit Sub

        Dim confirmReset As DialogResult = MessageBox.Show("Are you sure you want to reset", "Confirm Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirmReset = DialogResult.Yes Then
            txtGPA.Clear()
            txtTotalCreditHrs.Clear()
            cmbLevel.SelectedIndex = -1
            rBtnSemester1.Checked = False
            rBtnSemester2.Checked = False
            dgvGPA.Rows.Clear()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnCGPACalculate2_Click_1(sender As Object, e As EventArgs) Handles btnCGPACalculate2.Click
        If dgvGPA.Rows.Count = 0 Then
            MessageBox.Show("Please add at least one GPA!", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        gbGPA.Visible = False
        gbShowCgpa.Visible = True
        dgvDisplayGPA.Visible = True
        dgvDisplayCourses.Visible = False

        'populating display courses grid
        dgvDisplayGPA.Rows.Clear()

        For Each row As DataGridViewRow In dgvGPA.Rows
            Dim strLevel As String = row.Cells("level").Value
            Dim strSemester As String = row.Cells("semester").Value
            Dim dblGPA As Double = Val(row.Cells("gpa").Value)
            Dim intTotalCreditHrs As Integer = Val(row.Cells("totalCreditHrs").Value)

            dgvDisplayGPA.Rows.Add(strLevel, strSemester, dblGPA, intTotalCreditHrs)

        Next

        Dim dblResult1 As Double = 0
        Dim dblResult2 As Double = 0

        ' Loop through the rows to calculate total
        For Each row As DataGridViewRow In dgvGPA.Rows
            Dim gpa = Val(row.Cells("gpa").Value)
            Dim creditHrs = Val(row.Cells("totalCreditHrs").Value)
            dblResult1 = (gpa * creditHrs) + dblResult1
            dblResult2 += creditHrs
        Next

        ' Compute CGPA
        Dim dblcgpa As Double = dblResult1 / dblResult2
        lblCgpaResults.Text = "Your CGPA: " & Math.Round(dblcgpa, 2).ToString
        lblCgpaResults2.Text = "Your CGPA: " & Math.Round(dblcgpa, 2).ToString

        If dgvGPA.Rows.Count <= 4 Then
            lblDegreeClass.Text = "Class of Degree: " & DegreeClassification(dblcgpa)
            lblDiplomaClass.Text = "Class of Diploma: " & DiplomaClassification(dblcgpa)
        Else
            lblDegreeClass.Text = "You can't be a Diploma Student"
            lblDiplomaClass.Text = "You entered GPA's for more than 4 semesters"
        End If
    End Sub

    Private Sub btnGpaPrevious_Click(sender As Object, e As EventArgs) Handles btnGpaPrevious.Click
        If dgvGPA.Rows.Count <= 0 Or intGpaRowCounter = 0 Then
            Exit Sub
        End If

        'updating Add course button
        btnAddGPA.Text = "Edit GPA"
        boolIsAddGPA = False

        'Getting a row from the datagrid
        Dim specificRow As DataGridViewRow
        Dim intPreviousIndex As Integer = (intGpaRowCounter - 1)


        If dgvGPA.Rows.Count >= 1 Then
            specificRow = dgvGPA.Rows(intPreviousIndex)
            txtGPA.Text = specificRow.Cells("gpa").Value
            txtTotalCreditHrs.Text = specificRow.Cells("totalCreditHrs").Value
            cmbLevel.Text = specificRow.Cells("level").Value

            If specificRow.Cells("semester").Value = "1st Semester" Then
                rBtnSemester1.Checked = True
                rBtnSemester2.Checked = False
            ElseIf specificRow.Cells("semester").Value = "2nd Semester" Then
                rBtnSemester2.Checked = True
                rBtnSemester1.Checked = False
            End If

        End If

        'Updating row Counter
        intGpaRowCounter -= 1
    End Sub

    Private Sub btnGpaNext_Click(sender As Object, e As EventArgs) Handles btnGpaNext.Click

        If dgvGPA.Rows.Count <= 0 Or intGpaRowCounter = dgvGPA.Rows.Count Or intGpaRowCounter < 0 Then
            Exit Sub
        End If

        'Getting a row from the datagrid
        Dim specificRow As DataGridViewRow
        Dim intNextIndex As Integer


        If dgvGPA.Rows.Count >= 1 Then

            If dgvGPA.Rows.Count = intGpaRowCounter + 1 Then
                txtGPA.Clear()
                txtTotalCreditHrs.Clear()
                cmbLevel.SelectedIndex = -1
                rBtnSemester1.Checked = False
                rBtnSemester2.Checked = False

                'updating add course button
                btnAddGPA.Text = "Add Course"
                boolIsAddGPA = True

                'Updating row Counter
                intGpaRowCounter = intGpaRowCounter + 1

                Exit Sub

            Else
                'updating index for the fetching specific data from grid
                intNextIndex = intGpaRowCounter + 1

            End If

            'Acquiring data from the grid and displaying to text boxes
            specificRow = dgvGPA.Rows(intNextIndex)
            txtGPA.Text = specificRow.Cells("gpa").Value
            txtTotalCreditHrs.Text = specificRow.Cells("totalCreditHrs").Value
            cmbLevel.Text = specificRow.Cells("level").Value

            If specificRow.Cells("semester").Value = "1st Semester" Then
                rBtnSemester1.Checked = True
                rBtnSemester2.Checked = False
            ElseIf specificRow.Cells("semester").Value = "2nd Semester" Then
                rBtnSemester2.Checked = True
                rBtnSemester1.Checked = False
            End If
        End If

        'Updating row Counter
        'intGpaRowCounter += 1
    End Sub

    Private Sub btnGpaDelete_Click(sender As Object, e As EventArgs) Handles btnGpaDelete.Click
        If dgvGPA.Rows.Count <= 0 Or intGpaRowCounter = dgvGPA.Rows.Count Or intGpaRowCounter < 0 Or txtGPA.Text = "" Or txtTotalCreditHrs.Text = "" Then
            MessageBox.Show("Invalid Command", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim confirmDelete As DialogResult = MessageBox.Show("Are you sure you want to delete", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        Dim intDeleteIndex As Integer = intGpaRowCounter

        If confirmDelete = DialogResult.Yes Then

            dgvGPA.Rows.RemoveAt(intDeleteIndex)

            btnAddGPA.Text = "Add Course"
            boolIsAddGPA = True

            'updating row counting
            intGpaRowCounter = dgvGPA.Rows.Count

            txtGPA.Clear()
            txtTotalCreditHrs.Clear()
            cmbLevel.SelectedIndex = -1
            rBtnSemester1.Checked = False
            rBtnSemester2.Checked = False

        Else
            Exit Sub
        End If
    End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    gbHomePage.Visible = True
    'End Sub


End Class