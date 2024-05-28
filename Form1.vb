Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Dim playerList = File.ReadAllLines("..\..\playerName.txt")

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        playerCB.Items.AddRange(playerList)
        NameLabel.ForeColor = Color.FromArgb(255, 114, 228)
        playerCB.ForeColor = Color.White
        playerCB.Text = ""

        nameLB.Hide()
        scoreLB.Hide()
        searchPlayerCB.Hide()
        showStatsBtn.Hide()

    End Sub

    Private Sub quitGame_Click(sender As Object, e As EventArgs) Handles quitGameBtn.Click
        'Me.Hide()
        QuitGameMsgBox.Show()
    End Sub

    Private Function estValide() As Boolean
        If Not String.IsNullOrWhiteSpace(newNameTBox.Text) Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Sub addName_Click(sender As Object, e As EventArgs) Handles addNameBtn.Click
        If estValide() Then ' Verifie si le text es valide
            If Not Existent(newNameTBox.Text) Then 'verifie se le nickname existe ou pas
                Dim j As joeur
                j.nickName = newNameTBox.Text
                j.points = 0
                AjouterJoeur(j)
                My.Computer.FileSystem.WriteAllText("..\..\playerName.txt", Environment.NewLine + newNameTBox.Text, True)
                playerCB.Text = newNameTBox.Text
                playerCB.Items.Add(newNameTBox.Text)
            Else
                MsgBox("Personne deja existante")
            End If
        Else
            MsgBox("Erreur")
        End If
    End Sub

    Private Sub NewGameBtn_Click(sender As Object, e As EventArgs) Handles NewGameBtn.Click
        If playerCB.Text = "" Then
            NameLabel.ForeColor = Color.Red
            playerCB.ForeColor = Color.Red
            playerCB.Text = "Enter name"
        Else
            Form1_Load(sender, e)
            NewGame(playerCB)
            Me.Hide()
            Sudoku3X3.Show()
        End If
    End Sub

    Private Sub playerCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles playerCB.SelectedIndexChanged
        playerCB.ForeColor = Color.White

    End Sub

    Private Sub PlayerCB_TextChanged(sender As Object, e As EventArgs) Handles playerCB.TextChanged
        playerCB.DroppedDown = True
    End Sub



    Private Sub scoreBtn_Click(sender As Object, e As EventArgs) Handles scoreBtn.Click
        homeBtn.FlatAppearance.BorderSize = 0
        scoreBtn.FlatAppearance.BorderSize = 1

        nameLB.Show()
        scoreLB.Show()
        searchPlayerCB.Show()
        showStatsBtn.Show()

        sudokuTitle.Hide()
        NameLabel.Hide()
        playerCB.Hide()
        newPlayerLabel.Hide()
        newNameTBox.Hide()
        addNameBtn.Hide()
        NewGameBtn.Hide()
    End Sub

    Private Sub homeBtn_Click(sender As Object, e As EventArgs) Handles homeBtn.Click
        homeBtn.FlatAppearance.BorderSize = 1
        scoreBtn.FlatAppearance.BorderSize = 0
        sudokuTitle.Show()
        NameLabel.Show()
        playerCB.Show()
        newPlayerLabel.Show()
        newNameTBox.Show()
        addNameBtn.Show()
        NewGameBtn.Show()

        nameLB.Hide()
        scoreLB.Hide()
        searchPlayerCB.Hide()
        showStatsBtn.Hide()
    End Sub

    Private Sub showStatsBtn_Click(sender As Object, e As EventArgs) Handles showStatsBtn.Click
        Me.Hide()
        stats.Show()
    End Sub
End Class
