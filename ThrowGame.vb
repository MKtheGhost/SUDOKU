Public Class ThrowGame
    Private Sub yesQuit_Click(sender As Object, e As EventArgs) Handles yesQuit.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub noQuit_Click(sender As Object, e As EventArgs) Handles noQuit.Click
        Sudoku1x1.Show()
        Me.Hide()
    End Sub
End Class