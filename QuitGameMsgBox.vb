Public Class QuitGameMsgBox
    Private Sub no_Click(sender As Object, e As EventArgs) Handles noQuit.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub yes_Click(sender As Object, e As EventArgs) Handles yesQuit.Click
        updateData()
        Application.Exit()
    End Sub
End Class