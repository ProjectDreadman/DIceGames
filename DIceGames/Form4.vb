Imports System.ComponentModel

Public Class Form4
    Dim PlayerGuess As Integer
    Dim dice As Integer
    Dim rndNum As New Random
    Dim GuessNum As Integer = 3
    Dim win As Integer
    Dim lose As Integer
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblGuesses.Text = "Guesses: " & GuessNum
        optGoAway.Checked = True
    End Sub

    Private Sub Form4_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Application.Exit()
    End Sub

    Private Sub lblGuess1_CheckedChanged(sender As Object, e As EventArgs) Handles lblGuess1.CheckedChanged
        If lblGuess1.Checked Then
            PlayerGuess = 1
        End If
    End Sub

    Private Sub lblGuess2_CheckedChanged(sender As Object, e As EventArgs) Handles lblGuess2.CheckedChanged
        If lblGuess2.Checked Then
            PlayerGuess = 2
        End If
    End Sub

    Private Sub lblGuess3_CheckedChanged(sender As Object, e As EventArgs) Handles lblGuess3.CheckedChanged
        If lblGuess3.Checked Then
            PlayerGuess = 3
        End If
    End Sub

    Private Sub lblGuess4_CheckedChanged(sender As Object, e As EventArgs) Handles lblGuess4.CheckedChanged
        If lblGuess4.Checked Then
            PlayerGuess = 4
        End If
    End Sub

    Private Sub lblGuess5_CheckedChanged(sender As Object, e As EventArgs) Handles lblGuess5.CheckedChanged
        If lblGuess5.Checked Then
            PlayerGuess = 5
        End If
    End Sub

    Private Sub lblGuess6_CheckedChanged(sender As Object, e As EventArgs) Handles lblGuess6.CheckedChanged
        If lblGuess6.Checked Then
            PlayerGuess = 6
        End If
    End Sub

    Private Sub btnRoll_Click(sender As Object, e As EventArgs) Handles btnRoll.Click
        dice = rndNum.Next(1, 7)

        If dice = 1 Then
            picDIce.Image = My.Resources.dice_1
        ElseIf dice = 2 Then
            picDIce.Image = My.Resources.dice_2
        ElseIf dice = 3 Then
            picDIce.Image = My.Resources.dice_3
        ElseIf dice = 4 Then
            picDIce.Image = My.Resources.dice_4
        ElseIf dice = 5 Then
            picDIce.Image = My.Resources.dice_5
        ElseIf dice = 6 Then
            picDIce.Image = My.Resources.dice_6
        End If

        If PlayerGuess > dice Or PlayerGuess < dice Then
            MsgBox("you got it incorret")
            GuessNum = GuessNum - 1
            lblGuesses.Text = "Guesses: " & GuessNum
            lose = lose + 1
            lblLosses.Text = "Loss: " & lose
        ElseIf PlayerGuess = dice Then
            MsgBox("you got it correct")
            GuessNum = 3
            lblGuesses.Text = "Guesses: " & GuessNum
            win = win + 1
            lblWin.Text = "Win: " & win
        End If

        If GuessNum = 0 Then
            MsgBox("YOU LOSE, you will now be sent back to the home menu")
            Me.Hide()
            Form1.Show()
            PlayerGuess = 1
            dice = 0
            GuessNum = 3
            lblGuesses.Text = "Guesses: " & GuessNum
            picDIce.Image = My.Resources.blank
            win = 0
            lose = 0
            lblWin.Text = "Win: "
            lblLosses.Text = "Loss: "
        End If

        If GuessNum <= -1 Then
            Me.Hide()
            Form1.Show()
            PlayerGuess = 1
            dice = 0
            GuessNum = 3
            lblGuesses.Text = "Guesses: " & GuessNum
            picDIce.Image = My.Resources.blank
            win = 0
            lose = 0
            lblWin.Text = "Win: "
            lblLosses.Text = "Loss: "
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Hide()
        Form1.Show()
        PlayerGuess = 1
        dice = 0
        GuessNum = 3
        lblGuesses.Text = "Guesses: " & GuessNum
        picDIce.Image = My.Resources.blank
        win = 0
        lose = 0
        lblWin.Text = "Win: "
        lblLosses.Text = "Loss: "
    End Sub
End Class