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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ageLabel = New System.Windows.Forms.Label()
        Me.gradeLabel = New System.Windows.Forms.Label()
        Me.addButton = New System.Windows.Forms.RadioButton()
        Me.subtractButton = New System.Windows.Forms.RadioButton()
        Me.multiplyButton = New System.Windows.Forms.RadioButton()
        Me.divideButton = New System.Windows.Forms.RadioButton()
        Me.studentinfoBox.SuspendLayout()
        Me.functionGroupBox.SuspendLayout()
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
        Me.functionGroupBox.Location = New System.Drawing.Point(18, 205)
        Me.functionGroupBox.Name = "functionGroupBox"
        Me.functionGroupBox.Size = New System.Drawing.Size(212, 242)
        Me.functionGroupBox.TabIndex = 5
        Me.functionGroupBox.TabStop = False
        Me.functionGroupBox.Text = "Function Select"
        '
        'GroupBox3
        '
        Me.GroupBox3.Location = New System.Drawing.Point(262, 205)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(292, 242)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GroupBox3"
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(898, 472)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.functionGroupBox)
        Me.Controls.Add(Me.studentinfoBox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.studentinfoBox.ResumeLayout(False)
        Me.studentinfoBox.PerformLayout()
        Me.functionGroupBox.ResumeLayout(False)
        Me.functionGroupBox.PerformLayout()
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
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents divideButton As RadioButton
    Friend WithEvents multiplyButton As RadioButton
    Friend WithEvents subtractButton As RadioButton
    Friend WithEvents addButton As RadioButton
End Class
