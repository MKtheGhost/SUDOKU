Public Class stats
    Private Sub returnBtn_Click(sender As Object, e As EventArgs) Handles returnBtn.Click
        Me.Hide()
        getCurrentIndex(Form1.searchPlayerCB.Text)
        Form1.Show()
    End Sub

    Private Sub stats_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getCurrentIndex(Form1.searchPlayerCB.Text)
        nameLabel.Text = Form1.searchPlayerCB.Text
        bestTimeLb.Text = playerList(currentPlayerIndex).bestTime.ToString("m\mss\s")
        totalTimeLb.Text = playerList(currentPlayerIndex).totalTime.ToString("m\mss\s")
        nbGameLb.Text = playerList(currentPlayerIndex).nbGame
    End Sub
End Class