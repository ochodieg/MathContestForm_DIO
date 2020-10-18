


Public Class Form1
    Dim num1 As Integer
    Dim num2 As Integer
    Dim answer As Integer
    Dim questions As Integer = 0I
    Dim correctAnswer As Integer = 0I

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click

        Me.Close()

    End Sub

    Private Sub resultButton_Click(sender As Object, e As EventArgs) Handles resultButton.Click

        MsgBox(correctAnswer & "/" & questions & "Correct answers")
    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click

        nameTextBox.Text = ""
        ageTextBox.Text = ""
        gradeTextBox.Text = ""
        firstnumTextBox.Text = ""
        secnumBox.Text = ""
        uranswerTextBox.Text = ""
        questions = 0
        correctAnswer = 0
        controlset()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Controlset()

    End Sub

    Sub Controlset()

        studentinfoBox.Enabled = True
        'addButton.Enabled = False
        'subtractButton.Enabled = False
        'multiplyButton.Enabled = False
        'divideButton.Enabled = False
        'firstnumTextBox.Enabled = False
        'secnumBox.Enabled = False
        'uranswerTextBox.Enabled = False
        'submitButton.Enabled = False
        'resultButton.Enabled = False
        optionsBox.Enabled = False
        functionGroupBox.Enabled = False
        numbersBox.Enabled = False




    End Sub


End Class
