Public Class frmCalculatorInput

    Private intAddCourseCount As Integer = 1

    Private Sub btnAddCourse_Click(sender As Object, e As EventArgs) Handles btnAddCourse.Click

        'Creating new textbox for course and grade
        Dim newCourseTextBox As New TextBox()
        Dim newGradeComboBox As New ComboBox()



        'Setting Properties of textboxes
        newCourseTextBox.Name = "txtCourse1" & intAddCourseCount + 1
        newCourseTextBox.AutoSize = False
        'newCourseTextBox.Top = intAddCourseCount * 35
        newCourseTextBox.Size = New Size(392, 29)
        newCourseTextBox.Font = New Font("Segoe UI", 12)
        'newCourseTextBox.Location = New Point(108, 22 + (85 * intAddCourseCount))
        newCourseTextBox.Location = New Point(10, intAddCourseCount * 35)

        'Setting properties for comboBoxes(Select box)
        newGradeComboBox.Name = "cmbGrade" & intAddCourseCount + 1
        newGradeComboBox.AutoSize = False
        newGradeComboBox.Size = New Size(392, 23)
        newGradeComboBox.Font = New Font("Segoe UI", 12)
        newGradeComboBox.Location = New Point(108, 53 + (85 * intAddCourseCount))




        'Add to panel
        pnlContainer.Controls.Add(newCourseTextBox)
        'pnlContainer.Controls.Add(newGradeComboBox)


        'Increement
        intAddCourseCount += 1






    End Sub


End Class
