Public Class stats
    Private Sub returnBtn_Click(sender As Object, e As EventArgs) Handles returnBtn.Click
        Me.Hide()
        getCurrentIndex(Form1.searchPlayerCB.Text)
        Form1.Show()
    End Sub

    Private Sub stats_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class