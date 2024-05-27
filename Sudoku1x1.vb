Public Class Sudoku1x1
    Dim sudokuArray(9) As TextBox
    Private Sub giveUpButton_Click(sender As Object, e As EventArgs) Handles giveUpButton.Click
        ThrowGame.Show()
        Me.Hide()
    End Sub

    Private Sub Sudoku1x1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sudokuArray(1) = Case1_1
        sudokuArray(2) = Case1_2
        sudokuArray(3) = Case1_3
        sudokuArray(4) = Case1_4
        sudokuArray(5) = Case1_5
        sudokuArray(6) = Case1_6
        sudokuArray(7) = Case1_7
        sudokuArray(8) = Case1_8
        sudokuArray(9) = Case1_9
    End Sub
End Class