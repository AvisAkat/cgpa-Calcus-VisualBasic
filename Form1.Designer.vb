<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCalculatorInput
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Label1 = New Label()
        txtCourse1 = New TextBox()
        lblCourse1 = New Label()
        lblGrade1 = New Label()
        cmbGrade1 = New ComboBox()
        btnAddCourse = New Button()
        Button2 = New Button()
        pnlContainer = New Panel()
        pnlContainer.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Comic Sans MS", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(154, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(493, 67)
        Label1.TabIndex = 1
        Label1.Text = "CGPA CALCULATOR"
        ' 
        ' txtCourse1
        ' 
        txtCourse1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtCourse1.Location = New Point(108, 25)
        txtCourse1.Multiline = True
        txtCourse1.Name = "txtCourse1"
        txtCourse1.Size = New Size(392, 27)
        txtCourse1.TabIndex = 2
        ' 
        ' lblCourse1
        ' 
        lblCourse1.AutoSize = True
        lblCourse1.Font = New Font("Comic Sans MS", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblCourse1.Location = New Point(24, 26)
        lblCourse1.Name = "lblCourse1"
        lblCourse1.Size = New Size(65, 24)
        lblCourse1.TabIndex = 3
        lblCourse1.Text = "Course"
        ' 
        ' lblGrade1
        ' 
        lblGrade1.AutoSize = True
        lblGrade1.Font = New Font("Comic Sans MS", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblGrade1.Location = New Point(24, 56)
        lblGrade1.Name = "lblGrade1"
        lblGrade1.Size = New Size(59, 24)
        lblGrade1.TabIndex = 3
        lblGrade1.Text = "Grade"
        ' 
        ' cmbGrade1
        ' 
        cmbGrade1.FormattingEnabled = True
        cmbGrade1.Items.AddRange(New Object() {"A", "B+", "B", "B-", "C+", "C", "C-", "D", "E", "F"})
        cmbGrade1.Location = New Point(108, 57)
        cmbGrade1.Name = "cmbGrade1"
        cmbGrade1.Size = New Size(392, 23)
        cmbGrade1.TabIndex = 5
        ' 
        ' btnAddCourse
        ' 
        btnAddCourse.Location = New Point(325, 717)
        btnAddCourse.Name = "btnAddCourse"
        btnAddCourse.Size = New Size(153, 42)
        btnAddCourse.TabIndex = 6
        btnAddCourse.Text = "Add Course"
        btnAddCourse.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(220, 775)
        Button2.Name = "Button2"
        Button2.Size = New Size(361, 38)
        Button2.TabIndex = 7
        Button2.Text = "Calculate"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' pnlContainer
        ' 
        pnlContainer.AutoScroll = True
        pnlContainer.AutoSizeMode = AutoSizeMode.GrowAndShrink
        pnlContainer.Controls.Add(lblCourse1)
        pnlContainer.Controls.Add(txtCourse1)
        pnlContainer.Controls.Add(lblGrade1)
        pnlContainer.Controls.Add(cmbGrade1)
        pnlContainer.Location = New Point(138, 126)
        pnlContainer.Name = "pnlContainer"
        pnlContainer.Size = New Size(525, 534)
        pnlContainer.TabIndex = 8
        ' 
        ' frmCalculatorInput
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 938)
        Controls.Add(pnlContainer)
        Controls.Add(Button2)
        Controls.Add(btnAddCourse)
        Controls.Add(Label1)
        Name = "frmCalculatorInput"
        Text = "CGPA Calculator"
        pnlContainer.ResumeLayout(False)
        pnlContainer.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtCourse1 As TextBox
    Friend WithEvents lblCourse1 As Label
    Friend WithEvents lblGrade1 As Label
    Friend WithEvents cmbGrade1 As ComboBox
    Friend WithEvents btnAddCourse As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents pnlContainer As Panel

End Class
