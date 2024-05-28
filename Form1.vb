Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Dim playerList = File.ReadAllLines("..\..\playerName.txt")

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        playerCB.Items.AddRange(playerList)


        NameLabel.ForeColor = Color.FromArgb(255, 114, 228)
        playerCB.ForeColor = Color.White
        playerCB.Text = ""

    End Sub

    Private Sub quitGame_Click(sender As Object, e As EventArgs) Handles quitGameBtn.Click
        Me.Hide()
        QuitGameMsgBox.Show()
    End Sub

    Private Sub addName_Click(sender As Object, e As EventArgs) Handles addNameBtn.Click
        If newNameTBox.Text <> "" Then
            My.Computer.FileSystem.WriteAllText("..\..\playerName.txt", Environment.NewLine + newNameTBox.Text, True)
            playerCB.Items.Add(newNameTBox.Text)
            playerCB.Text = newNameTBox.Text
        End If
    End Sub

    Private Sub NewGameBtn_Click(sender As Object, e As EventArgs) Handles NewGameBtn.Click
        If playerCB.Text = "" Then
            NameLabel.ForeColor = Color.Red
            playerCB.ForeColor = Color.Red
            playerCB.Text = "Enter name"
        Else
            Form1_Load(sender, e)
            Me.Hide()
            Sudoku3X3.Show()
        End If
    End Sub

    Private Sub playerCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles playerCB.SelectedIndexChanged
        playerCB.ForeColor = Color.White

    End Sub
End Class
