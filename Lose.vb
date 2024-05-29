Imports ProjetSAE.dataManipulation

Public Class Lose
    Private Sub OKBtn_Click(sender As Object, e As EventArgs) Handles OKBtn.Click
        Me.Hide()
        Form1.nameLB.Items.Clear()
        Form1.scoreLB.Items.Clear()

        For Index As Integer = 0 To playerList.Length() - 1
            Form1.nameLB.Items.Add(playerList(Index).name)
            Form1.scoreLB.Items.Add(playerList(Index).bestTime)
        Next

        Form1.Show()
    End Sub

    Private Sub Lose_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class