Public Class cgpaCalcusVersion2


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
            Case Else
                Return 0.0
        End Select
    End Function


    Private Sub cgpaCalcusVersion2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Set up the DataGridView columns
        'dgvCourses.Columns.Add("Course", "Course")
        'dgvCourses.Columns.Add("Credit", "Credit Hours")
        'dgvCourses.Columns.Add("Grade", "Grade")
        'dgvCourses.Columns.Add("GradePoint", "Grade Point")

        ' Make DataGridView read-only
        ' gvCourses.ReadOnly = True
        dgvCourses.AllowUserToAddRows = False


    End Sub

    Private Sub btnAddCourse_Click(sender As Object, e As EventArgs) Handles btnAddCourse.Click
        Dim course As String = txtCourse.Text.Trim()
        Dim credit As Double
        Dim grade As String = cmbGrade.Text

        ' Validate inputs
        If course = "" Or Not Double.TryParse(txtCredit.Text, credit) Or credit <= 0 Or grade = "" Then
            MessageBox.Show("Please fill all fields correctly!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Get grade point
        Dim gradePoint As Double = GetGradePoint(grade)

        ' Add to DataGridView
        dgvCourses.Rows.Add(course, credit, grade, gradePoint)

        ' Clear inputs
        txtCourse.Clear()
        txtCredit.Clear()
        cmbGrade.SelectedIndex = -1
    End Sub

    Private Sub btnCalulate_Click(sender As Object, e As EventArgs) Handles btnCalulate.Click

        Dim totalCreditsHrs As Double = 0
        Dim totalGradePoints As Double = 0

        If dgvCourses.Rows.Count = 0 Then
            MessageBox.Show("Please add at least one course!", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        ' Loop through the rows to calculate total
        For Each row As DataGridViewRow In dgvCourses.Rows
            Dim creditHrs As Double = Val(row.Cells("Credit").Value)
            Dim gradePoint As Double = Val(row.Cells("GradePoint").Value)
            totalCreditsHrs += creditHrs
            totalGradePoints += gradePoint
        Next

        ' Compute CGPA
        Dim cgpa As Double = totalGradePoints / totalCreditsHrs
        lblCgpaResults.Text = "Your CGPA: " & Math.Round(cgpa, 2).ToString()

    End Sub

    Private Sub btnCourseReset_Click(sender As Object, e As EventArgs) Handles btnCourseReset.Click

        txtCourse.Clear()
        txtCredit.Clear()
        cmbGrade.SelectedIndex = -1
        dgvCourses.Rows.Clear()
        lblCgpaResults.Text = "Your CGPA: "
    End Sub
End Class