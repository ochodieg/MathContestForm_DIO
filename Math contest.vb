


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


End Class
