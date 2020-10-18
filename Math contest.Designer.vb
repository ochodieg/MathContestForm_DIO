<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.nameTextBox = New System.Windows.Forms.TextBox()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.ageTextBox = New System.Windows.Forms.TextBox()
        Me.gradeTextBox = New System.Windows.Forms.TextBox()
        Me.studentinfoBox = New System.Windows.Forms.GroupBox()
        Me.gradeLabel = New System.Windows.Forms.Label()
        Me.ageLabel = New System.Windows.Forms.Label()
        Me.functionGroupBox = New System.Windows.Forms.GroupBox()
        Me.divideButton = New System.Windows.Forms.RadioButton()
        Me.multiplyButton = New System.Windows.Forms.RadioButton()
        Me.subtractButton = New System.Windows.Forms.RadioButton()
        Me.addButton = New System.Windows.Forms.RadioButton()
        Me.numbersBox = New System.Windows.Forms.GroupBox()
        Me.uranswerLabel = New System.Windows.Forms.Label()
        Me.secondLabel = New System.Windows.Forms.Label()
        Me.firstnumLabel = New System.Windows.Forms.Label()
        Me.uranswerTextBox = New System.Windows.Forms.TextBox()
        Me.secnumBox = New System.Windows.Forms.TextBox()
        Me.firstnumTextBox = New System.Windows.Forms.TextBox()
        Me.optionsBox = New System.Windows.Forms.GroupBox()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.resultButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.submitButton = New System.Windows.Forms.Button()
        Me.studentinfoBox.SuspendLayout()
        Me.functionGroupBox.SuspendLayout()
        Me.numbersBox.SuspendLayout()
        Me.optionsBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'nameTextBox
        '
        Me.nameTextBox.Location = New System.Drawing.Point(6, 73)
        Me.nameTextBox.Multiline = True
        Me.nameTextBox.Name = "nameTextBox"
        Me.nameTextBox.Size = New System.Drawing.Size(349, 42)
        Me.nameTextBox.TabIndex = 0
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = True
        Me.nameLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.nameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.nameLabel.Location = New System.Drawing.Point(6, 41)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(51, 20)
        Me.nameLabel.TabIndex = 1
        Me.nameLabel.Text = "Name"
        '
        'ageTextBox
        '
        Me.ageTextBox.Location = New System.Drawing.Point(380, 73)
        Me.ageTextBox.Multiline = True
        Me.ageTextBox.Name = "ageTextBox"
        Me.ageTextBox.Size = New System.Drawing.Size(91, 42)
        Me.ageTextBox.TabIndex = 2
        '
        'gradeTextBox
        '
        Me.gradeTextBox.Location = New System.Drawing.Point(492, 73)
        Me.gradeTextBox.Multiline = True
        Me.gradeTextBox.Name = "gradeTextBox"
        Me.gradeTextBox.Size = New System.Drawing.Size(91, 42)
        Me.gradeTextBox.TabIndex = 3
        '
        'studentinfoBox
        '
        Me.studentinfoBox.Controls.Add(Me.gradeLabel)
        Me.studentinfoBox.Controls.Add(Me.ageLabel)
        Me.studentinfoBox.Controls.Add(Me.gradeTextBox)
        Me.studentinfoBox.Controls.Add(Me.nameLabel)
        Me.studentinfoBox.Controls.Add(Me.ageTextBox)
        Me.studentinfoBox.Controls.Add(Me.nameTextBox)
        Me.studentinfoBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentinfoBox.Location = New System.Drawing.Point(12, 12)
        Me.studentinfoBox.Name = "studentinfoBox"
        Me.studentinfoBox.Size = New System.Drawing.Size(609, 169)
        Me.studentinfoBox.TabIndex = 4
        Me.studentinfoBox.TabStop = False
        Me.studentinfoBox.Text = "Student Info."
        '
        'gradeLabel
        '
        Me.gradeLabel.AutoSize = True
        Me.gradeLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.gradeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gradeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.gradeLabel.Location = New System.Drawing.Point(488, 41)
        Me.gradeLabel.Name = "gradeLabel"
        Me.gradeLabel.Size = New System.Drawing.Size(54, 20)
        Me.gradeLabel.TabIndex = 5
        Me.gradeLabel.Text = "Grade"
        '
        'ageLabel
        '
        Me.ageLabel.AutoSize = True
        Me.ageLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ageLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ageLabel.Location = New System.Drawing.Point(376, 41)
        Me.ageLabel.Name = "ageLabel"
        Me.ageLabel.Size = New System.Drawing.Size(38, 20)
        Me.ageLabel.TabIndex = 4
        Me.ageLabel.Text = "Age"
        '
        'functionGroupBox
        '
        Me.functionGroupBox.Controls.Add(Me.divideButton)
        Me.functionGroupBox.Controls.Add(Me.multiplyButton)
        Me.functionGroupBox.Controls.Add(Me.subtractButton)
        Me.functionGroupBox.Controls.Add(Me.addButton)
        Me.functionGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.functionGroupBox.Location = New System.Drawing.Point(12, 205)
        Me.functionGroupBox.Name = "functionGroupBox"
        Me.functionGroupBox.Size = New System.Drawing.Size(184, 242)
        Me.functionGroupBox.TabIndex = 5
        Me.functionGroupBox.TabStop = False
        Me.functionGroupBox.Text = "Function Select"
        '
        'divideButton
        '
        Me.divideButton.AutoSize = True
        Me.divideButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.divideButton.Location = New System.Drawing.Point(48, 190)
        Me.divideButton.Name = "divideButton"
        Me.divideButton.Size = New System.Drawing.Size(77, 24)
        Me.divideButton.TabIndex = 3
        Me.divideButton.TabStop = True
        Me.divideButton.Text = "Divide"
        Me.divideButton.UseVisualStyleBackColor = True
        '
        'multiplyButton
        '
        Me.multiplyButton.AutoSize = True
        Me.multiplyButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.multiplyButton.Location = New System.Drawing.Point(48, 160)
        Me.multiplyButton.Name = "multiplyButton"
        Me.multiplyButton.Size = New System.Drawing.Size(86, 24)
        Me.multiplyButton.TabIndex = 2
        Me.multiplyButton.TabStop = True
        Me.multiplyButton.Text = "Multiply"
        Me.multiplyButton.UseVisualStyleBackColor = True
        '
        'subtractButton
        '
        Me.subtractButton.AutoSize = True
        Me.subtractButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subtractButton.Location = New System.Drawing.Point(48, 93)
        Me.subtractButton.Name = "subtractButton"
        Me.subtractButton.Size = New System.Drawing.Size(95, 24)
        Me.subtractButton.TabIndex = 1
        Me.subtractButton.TabStop = True
        Me.subtractButton.Text = "Subtract"
        Me.subtractButton.UseVisualStyleBackColor = True
        '
        'addButton
        '
        Me.addButton.AutoSize = True
        Me.addButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addButton.Location = New System.Drawing.Point(48, 63)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(63, 24)
        Me.addButton.TabIndex = 0
        Me.addButton.TabStop = True
        Me.addButton.Text = "Add"
        Me.addButton.UseVisualStyleBackColor = True
        '
        'numbersBox
        '
        Me.numbersBox.Controls.Add(Me.uranswerLabel)
        Me.numbersBox.Controls.Add(Me.secondLabel)
        Me.numbersBox.Controls.Add(Me.firstnumLabel)
        Me.numbersBox.Controls.Add(Me.uranswerTextBox)
        Me.numbersBox.Controls.Add(Me.secnumBox)
        Me.numbersBox.Controls.Add(Me.firstnumTextBox)
        Me.numbersBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numbersBox.Location = New System.Drawing.Point(214, 205)
        Me.numbersBox.Name = "numbersBox"
        Me.numbersBox.Size = New System.Drawing.Size(407, 242)
        Me.numbersBox.TabIndex = 6
        Me.numbersBox.TabStop = False
        Me.numbersBox.Text = "Number Input"
        '
        'uranswerLabel
        '
        Me.uranswerLabel.AutoSize = True
        Me.uranswerLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.uranswerLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uranswerLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.uranswerLabel.Location = New System.Drawing.Point(39, 194)
        Me.uranswerLabel.Name = "uranswerLabel"
        Me.uranswerLabel.Size = New System.Drawing.Size(100, 20)
        Me.uranswerLabel.TabIndex = 5
        Me.uranswerLabel.Text = "Your Answer"
        '
        'secondLabel
        '
        Me.secondLabel.AutoSize = True
        Me.secondLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.secondLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.secondLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.secondLabel.Location = New System.Drawing.Point(15, 121)
        Me.secondLabel.Name = "secondLabel"
        Me.secondLabel.Size = New System.Drawing.Size(124, 20)
        Me.secondLabel.TabIndex = 4
        Me.secondLabel.Text = "Second Number"
        '
        'firstnumLabel
        '
        Me.firstnumLabel.AutoSize = True
        Me.firstnumLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.firstnumLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstnumLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.firstnumLabel.Location = New System.Drawing.Point(39, 56)
        Me.firstnumLabel.Name = "firstnumLabel"
        Me.firstnumLabel.Size = New System.Drawing.Size(100, 20)
        Me.firstnumLabel.TabIndex = 3
        Me.firstnumLabel.Text = "First Number"
        '
        'uranswerTextBox
        '
        Me.uranswerTextBox.Location = New System.Drawing.Point(178, 184)
        Me.uranswerTextBox.Multiline = True
        Me.uranswerTextBox.Name = "uranswerTextBox"
        Me.uranswerTextBox.Size = New System.Drawing.Size(203, 39)
        Me.uranswerTextBox.TabIndex = 2
        '
        'secnumBox
        '
        Me.secnumBox.Location = New System.Drawing.Point(178, 111)
        Me.secnumBox.Multiline = True
        Me.secnumBox.Name = "secnumBox"
        Me.secnumBox.Size = New System.Drawing.Size(203, 41)
        Me.secnumBox.TabIndex = 1
        '
        'firstnumTextBox
        '
        Me.firstnumTextBox.Location = New System.Drawing.Point(178, 46)
        Me.firstnumTextBox.Multiline = True
        Me.firstnumTextBox.Name = "firstnumTextBox"
        Me.firstnumTextBox.Size = New System.Drawing.Size(203, 41)
        Me.firstnumTextBox.TabIndex = 0
        '
        'optionsBox
        '
        Me.optionsBox.Controls.Add(Me.exitButton)
        Me.optionsBox.Controls.Add(Me.resultButton)
        Me.optionsBox.Controls.Add(Me.clearButton)
        Me.optionsBox.Controls.Add(Me.submitButton)
        Me.optionsBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optionsBox.Location = New System.Drawing.Point(637, 12)
        Me.optionsBox.Name = "optionsBox"
        Me.optionsBox.Size = New System.Drawing.Size(227, 434)
        Me.optionsBox.TabIndex = 7
        Me.optionsBox.TabStop = False
        Me.optionsBox.Text = "Options"
        '
        'exitButton
        '
        Me.exitButton.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.exitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitButton.Location = New System.Drawing.Point(58, 323)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(116, 57)
        Me.exitButton.TabIndex = 3
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = False
        '
        'resultButton
        '
        Me.resultButton.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.resultButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resultButton.Location = New System.Drawing.Point(58, 231)
        Me.resultButton.Name = "resultButton"
        Me.resultButton.Size = New System.Drawing.Size(116, 57)
        Me.resultButton.TabIndex = 2
        Me.resultButton.Text = "Result"
        Me.resultButton.UseVisualStyleBackColor = False
        '
        'clearButton
        '
        Me.clearButton.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.clearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearButton.Location = New System.Drawing.Point(58, 143)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(116, 54)
        Me.clearButton.TabIndex = 1
        Me.clearButton.Text = "Clear"
        Me.clearButton.UseVisualStyleBackColor = False
        '
        'submitButton
        '
        Me.submitButton.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.submitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submitButton.Location = New System.Drawing.Point(58, 61)
        Me.submitButton.Name = "submitButton"
        Me.submitButton.Size = New System.Drawing.Size(116, 51)
        Me.submitButton.TabIndex = 0
        Me.submitButton.Text = "Submit"
        Me.submitButton.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(898, 472)
        Me.Controls.Add(Me.optionsBox)
        Me.Controls.Add(Me.numbersBox)
        Me.Controls.Add(Me.functionGroupBox)
        Me.Controls.Add(Me.studentinfoBox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.studentinfoBox.ResumeLayout(False)
        Me.studentinfoBox.PerformLayout()
        Me.functionGroupBox.ResumeLayout(False)
        Me.functionGroupBox.PerformLayout()
        Me.numbersBox.ResumeLayout(False)
        Me.numbersBox.PerformLayout()
        Me.optionsBox.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents nameTextBox As TextBox
    Friend WithEvents nameLabel As Label
    Friend WithEvents ageTextBox As TextBox
    Friend WithEvents gradeTextBox As TextBox
    Friend WithEvents studentinfoBox As GroupBox
    Friend WithEvents gradeLabel As Label
    Friend WithEvents ageLabel As Label
    Friend WithEvents functionGroupBox As GroupBox
    Friend WithEvents numbersBox As GroupBox
    Friend WithEvents divideButton As RadioButton
    Friend WithEvents multiplyButton As RadioButton
    Friend WithEvents subtractButton As RadioButton
    Friend WithEvents addButton As RadioButton
    Friend WithEvents uranswerLabel As Label
    Friend WithEvents secondLabel As Label
    Friend WithEvents firstnumLabel As Label
    Friend WithEvents uranswerTextBox As TextBox
    Friend WithEvents secnumBox As TextBox
    Friend WithEvents firstnumTextBox As TextBox
    Friend WithEvents optionsBox As GroupBox
    Friend WithEvents exitButton As Button
    Friend WithEvents resultButton As Button
    Friend WithEvents clearButton As Button
    Friend WithEvents submitButton As Button
End Class
