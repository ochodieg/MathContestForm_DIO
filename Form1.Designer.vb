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
        Me.functionGroupBox = New System.Windows.Forms.GroupBox()
        Me.numbersBox = New System.Windows.Forms.GroupBox()
        Me.ageLabel = New System.Windows.Forms.Label()
        Me.gradeLabel = New System.Windows.Forms.Label()
        Me.addButton = New System.Windows.Forms.RadioButton()
        Me.subtractButton = New System.Windows.Forms.RadioButton()
        Me.multiplyButton = New System.Windows.Forms.RadioButton()
        Me.divideButton = New System.Windows.Forms.RadioButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.firstnumLabel = New System.Windows.Forms.Label()
        Me.secondLabel = New System.Windows.Forms.Label()
        Me.uranswerLabel = New System.Windows.Forms.Label()
        Me.studentinfoBox.SuspendLayout()
        Me.functionGroupBox.SuspendLayout()
        Me.numbersBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'nameTextBox
        '
        Me.nameTextBox.Location = New System.Drawing.Point(6, 73)
        Me.nameTextBox.Multiline = True
        Me.nameTextBox.Name = "nameTextBox"
        Me.nameTextBox.Size = New System.Drawing.Size(304, 42)
        Me.nameTextBox.TabIndex = 0
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = True
        Me.nameLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.nameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.nameLabel.Location = New System.Drawing.Point(6, 41)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(51, 20)
        Me.nameLabel.TabIndex = 1
        Me.nameLabel.Text = "Name"
        '
        'ageTextBox
        '
        Me.ageTextBox.Location = New System.Drawing.Point(316, 73)
        Me.ageTextBox.Multiline = True
        Me.ageTextBox.Name = "ageTextBox"
        Me.ageTextBox.Size = New System.Drawing.Size(91, 42)
        Me.ageTextBox.TabIndex = 2
        '
        'gradeTextBox
        '
        Me.gradeTextBox.Location = New System.Drawing.Point(413, 73)
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
        Me.studentinfoBox.Location = New System.Drawing.Point(12, 12)
        Me.studentinfoBox.Name = "studentinfoBox"
        Me.studentinfoBox.Size = New System.Drawing.Size(542, 169)
        Me.studentinfoBox.TabIndex = 4
        Me.studentinfoBox.TabStop = False
        Me.studentinfoBox.Text = "Student Info."
        '
        'functionGroupBox
        '
        Me.functionGroupBox.Controls.Add(Me.divideButton)
        Me.functionGroupBox.Controls.Add(Me.multiplyButton)
        Me.functionGroupBox.Controls.Add(Me.subtractButton)
        Me.functionGroupBox.Controls.Add(Me.addButton)
        Me.functionGroupBox.Location = New System.Drawing.Point(12, 205)
        Me.functionGroupBox.Name = "functionGroupBox"
        Me.functionGroupBox.Size = New System.Drawing.Size(168, 242)
        Me.functionGroupBox.TabIndex = 5
        Me.functionGroupBox.TabStop = False
        Me.functionGroupBox.Text = "Function Select"
        '
        'numbersBox
        '
        Me.numbersBox.Controls.Add(Me.uranswerLabel)
        Me.numbersBox.Controls.Add(Me.secondLabel)
        Me.numbersBox.Controls.Add(Me.firstnumLabel)
        Me.numbersBox.Controls.Add(Me.TextBox3)
        Me.numbersBox.Controls.Add(Me.TextBox2)
        Me.numbersBox.Controls.Add(Me.TextBox1)
        Me.numbersBox.Location = New System.Drawing.Point(199, 205)
        Me.numbersBox.Name = "numbersBox"
        Me.numbersBox.Size = New System.Drawing.Size(355, 242)
        Me.numbersBox.TabIndex = 6
        Me.numbersBox.TabStop = False
        Me.numbersBox.Text = "Number Input"
        '
        'ageLabel
        '
        Me.ageLabel.AutoSize = True
        Me.ageLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ageLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ageLabel.Location = New System.Drawing.Point(312, 41)
        Me.ageLabel.Name = "ageLabel"
        Me.ageLabel.Size = New System.Drawing.Size(38, 20)
        Me.ageLabel.TabIndex = 4
        Me.ageLabel.Text = "Age"
        '
        'gradeLabel
        '
        Me.gradeLabel.AutoSize = True
        Me.gradeLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.gradeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.gradeLabel.Location = New System.Drawing.Point(409, 41)
        Me.gradeLabel.Name = "gradeLabel"
        Me.gradeLabel.Size = New System.Drawing.Size(54, 20)
        Me.gradeLabel.TabIndex = 5
        Me.gradeLabel.Text = "Grade"
        '
        'addButton
        '
        Me.addButton.AutoSize = True
        Me.addButton.Location = New System.Drawing.Point(48, 41)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(63, 24)
        Me.addButton.TabIndex = 0
        Me.addButton.TabStop = True
        Me.addButton.Text = "Add"
        Me.addButton.UseVisualStyleBackColor = True
        '
        'subtractButton
        '
        Me.subtractButton.AutoSize = True
        Me.subtractButton.Location = New System.Drawing.Point(48, 91)
        Me.subtractButton.Name = "subtractButton"
        Me.subtractButton.Size = New System.Drawing.Size(95, 24)
        Me.subtractButton.TabIndex = 1
        Me.subtractButton.TabStop = True
        Me.subtractButton.Text = "Subtract"
        Me.subtractButton.UseVisualStyleBackColor = True
        '
        'multiplyButton
        '
        Me.multiplyButton.AutoSize = True
        Me.multiplyButton.Location = New System.Drawing.Point(48, 146)
        Me.multiplyButton.Name = "multiplyButton"
        Me.multiplyButton.Size = New System.Drawing.Size(86, 24)
        Me.multiplyButton.TabIndex = 2
        Me.multiplyButton.TabStop = True
        Me.multiplyButton.Text = "Multiply"
        Me.multiplyButton.UseVisualStyleBackColor = True
        '
        'divideButton
        '
        Me.divideButton.AutoSize = True
        Me.divideButton.Location = New System.Drawing.Point(48, 199)
        Me.divideButton.Name = "divideButton"
        Me.divideButton.Size = New System.Drawing.Size(77, 24)
        Me.divideButton.TabIndex = 3
        Me.divideButton.TabStop = True
        Me.divideButton.Text = "Divide"
        Me.divideButton.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(149, 40)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(190, 41)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(149, 108)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(190, 41)
        Me.TextBox2.TabIndex = 1
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(149, 175)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(190, 39)
        Me.TextBox3.TabIndex = 2
        '
        'firstnumLabel
        '
        Me.firstnumLabel.AutoSize = True
        Me.firstnumLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.firstnumLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.firstnumLabel.Location = New System.Drawing.Point(30, 56)
        Me.firstnumLabel.Name = "firstnumLabel"
        Me.firstnumLabel.Size = New System.Drawing.Size(100, 20)
        Me.firstnumLabel.TabIndex = 3
        Me.firstnumLabel.Text = "First Number"
        '
        'secondLabel
        '
        Me.secondLabel.AutoSize = True
        Me.secondLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.secondLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.secondLabel.Location = New System.Drawing.Point(6, 111)
        Me.secondLabel.Name = "secondLabel"
        Me.secondLabel.Size = New System.Drawing.Size(124, 20)
        Me.secondLabel.TabIndex = 4
        Me.secondLabel.Text = "Second Number"
        '
        'uranswerLabel
        '
        Me.uranswerLabel.AutoSize = True
        Me.uranswerLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.uranswerLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.uranswerLabel.Location = New System.Drawing.Point(30, 178)
        Me.uranswerLabel.Name = "uranswerLabel"
        Me.uranswerLabel.Size = New System.Drawing.Size(100, 20)
        Me.uranswerLabel.TabIndex = 5
        Me.uranswerLabel.Text = "Your Answer"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(898, 472)
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
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
End Class
