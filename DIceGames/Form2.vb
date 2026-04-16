Imports System.ComponentModel
Imports System.Diagnostics.Eventing.Reader

Public Class Form2
    Dim incorrect As Integer
    Dim correct As Integer
    Dim prediction As String
    Dim BooleanPrediction As Boolean
    Dim DiceEO As String
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form2_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Application.Exit()
    End Sub

    Private Sub btnRoll_Click(sender As Object, e As EventArgs) Handles btnRoll.Click
        Dim rndNum As New Random
        Dim num As Integer

        num = rndNum.Next(1, 7)

        If BooleanPrediction = False Then
            Exit Sub
        End If

        If num = 1 Then
            picDice.Image = My.Resources.dice_1
            DiceEO = "Odd"
        ElseIf num = 2 Then
            picDice.Image = My.Resources.dice_2
            DiceEO = "Even"
        ElseIf num = 3 Then
            picDice.Image = My.Resources.dice_3
            DiceEO = "Odd"
        ElseIf num = 4 Then
            picDice.Image = My.Resources.dice_4
            DiceEO = "Even"
        ElseIf num = 5 Then
            picDice.Image = My.Resources.dice_5
            DiceEO = "Odd"
        ElseIf num = 6 Then
            picDice.Image = My.Resources.dice_6
            DiceEO = "Even"
        End If

        If prediction = "Even" And DiceEO = "Even" Then
            MsgBox("you got it correct")
            correct += 1
            lblCorrect.Text = "Correct: " & correct
        ElseIf prediction = "Odd" And DiceEO = "Odd" Then
            MsgBox("you got it correct")
            correct += 1
            lblCorrect.Text = "Correct: " & correct

        ElseIf prediction = "Odd" And DiceEO = "Even" Or prediction = "Even" And DiceEO = "Odd" Then
            incorrect = incorrect + 1
            MsgBox("you got it incorrect")
        End If

        If incorrect >= 1 Then
            lblIncorrect.Text = "Incorrect: " & incorrect
        End If
    End Sub

    Private Sub optEven_CheckedChanged(sender As Object, e As EventArgs) Handles optEven.CheckedChanged
        If optEven.Checked Then
            BooleanPrediction = True
            prediction = "Even"
        End If
    End Sub

    Private Sub optOdd_CheckedChanged(sender As Object, e As EventArgs) Handles optOdd.CheckedChanged
        If optOdd.Checked Then
            BooleanPrediction = True
            prediction = "Odd"
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Hide()
        Form1.Show()
        incorrect = 0
        correct = 0
        prediction = " "
        BooleanPrediction = False
        optEven.Checked = False
        optEven.Checked = False
        DiceEO = " "
        lblCorrect.Text = "Correct: "
        lblIncorrect.Text = "Incorrect: "
        picDice.Image = My.Resources.blank
    End Sub
End Class