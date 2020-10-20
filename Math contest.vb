Option Strict On 'wont compile with this on - TJR
Option Explicit On
Option Compare Text
'Ivan Ochoa
'RCET 0265
'Fall 2020
'Math Contest Form
'https://github.com/ochodieg/MathContestForm_DIO

Public Class Form1 'Bad name - TJR
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
        controlSet()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        controlSet()

    End Sub

    Sub controlSet()
        'sub sets intial controls position when sub is started
        studentinfoBox.Enabled = True
        addButton.Enabled = False
        subtractButton.Enabled = False
        multiplyButton.Enabled = False
        divideButton.Enabled = False
        firstnumTextBox.Enabled = False
        secnumBox.Enabled = False
        uranswerTextBox.Enabled = False
        submitButton.Enabled = False
        resultButton.Enabled = False
        'optionsBox.Enabled = False
        'functionGroupBox.Enabled = False
        'numbersBox.Enabled = False
    End Sub

    Sub controlReset()

        If gradeTextBox.Text > 4 Then
            addButton.Enabled = True 'enable all or none - TJR
            subtractButton.Enabled = True
            multiplyButton.Enabled = True
            divideButton.Enabled = True

        ElseIf gradeTextBox.Text = 1 Then
            addButton.Enabled = True
            subtractButton.Enabled = False
            multiplyButton.Enabled = False
            divideButton.Enabled = False

        ElseIf gradeTextBox.Text = 2 Then
            addButton.Enabled = True
            subtractButton.Enabled = True
            multiplyButton.Enabled = False
            divideButton.Enabled = False


        ElseIf gradeTextBox.Text = 3 Then
            addButton.Enabled = True
            subtractButton.Enabled = True
            multiplyButton.Enabled = True
            divideButton.Enabled = False


        End If

        studentinfoBox.Enabled = False
        firstnumTextBox.Enabled = True
        secnumBox.Enabled = True
        uranswerTextBox.Enabled = True
        submitButton.Enabled = True
        resultButton.Enabled = True

    End Sub

    Private Sub submitButton_Click(sender As Object, e As EventArgs) Handles submitButton.Click

        If addButton.Checked = True Then
            answer = CInt(num1) + CInt(num2) ' Already integers no need to convert to integer -TJR

        ElseIf subtractButton.Checked = True Then
            answer = CInt(num1) - CInt(num2)

        ElseIf multiplyButton.Checked = True Then
            answer = CInt(num1) * CInt(num2)

        ElseIf divideButton.Checked = True Then
            answer = CInt(num1) / CInt(num2)
        End If

        Try

            If Not uranswerTextBox.Text = Nothing Then

                If uranswerTextBox.Text = answer Then

                    MsgBox("correct")
                    correctAnswer += 1
                    questions += 1
                    uranswerTextBox.Clear()

                Else

                    MsgBox("incorrect")
                    uranswerTextBox.Clear()

                End If

            End If

        Catch ex As Exception

            MsgBox("Numericals only my dood")

        End Try

        infotext()

        If Accumulatemessage("", False) <> "" Then

            AlertUser(Accumulatemessage("", False))

        End If


        Randomize()
        num1 = CInt((10 * Rnd()) + 1)

        Randomize()
        num2 = CInt((10 * Rnd()) + 1)

        firstnumTextBox.Text = num1
        secnumBox.Text = num2
        uranswerTextBox.Text = ""
        uranswerTextBox.Select()
        resultButton.Enabled = True
    End Sub
    Sub infotext()

        Dim problem As Boolean = False
        If nameTextBox.Text = "" Then

            Accumulatemessage("You must enter name.", False)
            nameTextBox.Focus()
            problem = False

        End If

        Try

            If ageTextBox.Text = "" Then

                Accumulatemessage("You must enter age.", False)
                ageTextBox.Focus()
                problem = False

            ElseIf ageTextBox.Text > 4 And ageTextBox.Text < 12 Then

            Else

                Accumulatemessage("Ages 5 to 11 only.", False)
                ageTextBox.Focus()
                problem = False


            End If

            If gradeTextBox.Text = "" Then
                Accumulatemessage("You must enter grade.", False)
                gradeTextBox.Focus()
                problem = False

            ElseIf gradeTextBox.Text > 0 And gradeTextBox.Text < 6 Then
                controlReset()


            Else
                Accumulatemessage("grades 1 to 5 only.", False)
                gradeTextBox.Focus()
                problem = False

            End If

        Catch ex As Exception

            MsgBox("Numericals only.")

        End Try

    End Sub

    Function Accumulatemessage(ByVal newMessage As String, ByVal clear As Boolean) As String

        Static message As String

        If clear Then

            message = ""

        ElseIf newMessage <> "" Then

            message &= newMessage & vbNewLine

        End If

        Return message

    End Function

    Sub AlertUser(ByVal messege As String)

        MsgBox(messege)

        Accumulatemessage("", True)

    End Sub


    Private Sub CurrentMathProblemGroupBox_Enter(sender As Object, e As EventArgs) Handles _
 firstnumTextBox.TextChanged, secnumBox.TextChanged, uranswerTextBox.TextChanged

        Dim userMessage As String = ""
        Dim answer As Boolean
        answer = False

        If uranswerLabel.Text <> "" Then

            Try
                answer = True

            Catch ex As Exception

                MsgBox("Please Give Answer")

            End Try

        End If

        If userMessage <> "" Then

            MsgBox(userMessage)

        End If

    End Sub

    Private Sub GradeTextBox_TextChanged(sender As Object, e As EventArgs) Handles gradeTextBox.TextChanged

        If Me.gradeTextBox.Text <> String.Empty Then

            submitButton.Enabled = True

        Else
            submitButton.Enabled = False

        End If

    End Sub

    Private Sub AgeTextBox_TextChanged(sender As Object, e As EventArgs) Handles ageTextBox.TextChanged
        If Me.ageTextBox.Text <> String.Empty Then

            submitButton.Enabled = True

        Else

            submitButton.Enabled = False

        End If

    End Sub

    Private Sub NameTextBox_TextChanged(sender As Object, e As EventArgs) Handles nameTextBox.TextChanged
        If Me.nameTextBox.Text <> String.Empty Then

            submitButton.Enabled = True
        Else
            submitButton.Enabled = False

        End If

    End Sub

End Class

'submit button disabled until all text boxes evaluate ok
'able to run with empty text boxes
'summary not working
'only "add" ever enables

