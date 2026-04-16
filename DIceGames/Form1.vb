Imports System.ComponentModel
Imports System.Linq.Expressions

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Application.Exit()
    End Sub

    Private Sub btnDiceGames1_Click(sender As Object, e As EventArgs) Handles btnDiceGames1.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub btnDiceGames2_Click(sender As Object, e As EventArgs) Handles btnDiceGames2.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub btnDiceGames3_Click(sender As Object, e As EventArgs) Handles btnDiceGames3.Click
        Me.Hide()
        Form4.Show()
    End Sub
End Class
