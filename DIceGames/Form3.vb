Imports System.ComponentModel

Public Class Form3
    Dim rndNum As New Random
    Dim playerScore As Integer
    Dim CPUScore As Integer
    Dim PlayerDice As Integer
    Dim CPUDice As Integer
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form3_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Application.Exit()
    End Sub

    Private Sub btnRoll_Click(sender As Object, e As EventArgs) Handles btnRoll.Click
        PlayerDice = rndNum.Next(1, 7)
        If PlayerDice = 1 Then
            picPLAYER.Image = My.Resources.dice_1
        ElseIf PlayerDice = 2 Then
            picPLAYER.Image = My.Resources.dice_2
        ElseIf PlayerDice = 3 Then
            picPLAYER.Image = My.Resources.dice_3
        ElseIf PlayerDice = 4 Then
            picPLAYER.Image = My.Resources.dice_4
        ElseIf PlayerDice = 5 Then
            picPLAYER.Image = My.Resources.dice_5
        ElseIf PlayerDice = 6 Then
            picPLAYER.Image = My.Resources.dice_6
        End If

        CPUDice = rndNum.Next(1, 7)
        If CPUDice = 1 Then
            picCPU.Image = My.Resources.dice_1
        ElseIf CPUDice = 2 Then
            picCPU.Image = My.Resources.dice_2
        ElseIf CPUDice = 3 Then
            picCPU.Image = My.Resources.dice_3
        ElseIf CPUDice = 4 Then
            picCPU.Image = My.Resources.dice_4
        ElseIf CPUDice = 5 Then
            picCPU.Image = My.Resources.dice_5
        ElseIf CPUDice = 6 Then
            picCPU.Image = My.Resources.dice_6
        End If

        If CPUDice > PlayerDice Then
            MsgBox("CPU Wins")
            CPUScore = CPUScore + 1
            lblCPUScore.Text = "CPU: " & CPUScore
        ElseIf PlayerDice > CPUDice Then
            MsgBox("Player Wins")
            playerScore = playerScore + 1
            lblPlayerScore.Text = "Player: " & playerScore
        ElseIf PlayerDice = CPUDice Then
            MsgBox("Tied, no points awarded")
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Hide()
        Form1.Show()
        playerScore = 0
        CPUScore = 0
        CPUDice = 0
        PlayerDice = 0
        lblPlayerScore.Text = "Player: "
        lblCPUScore.Text = "CPU: "
        picCPU.Image = My.Resources.blank
        picPLAYER.Image = My.Resources.blank
    End Sub
End Class