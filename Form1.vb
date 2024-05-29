Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1

    Dim executeOnce As Boolean = False
    Dim currentplayer As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If executeOnce = False Then
            loadPlayer()
            executeOnce = True
        End If

        playerCB.Items.Clear()
        nameLB.Items.Clear()
        scoreLB.Items.Clear()

        For Index As Integer = 0 To playerList.Length() - 1
            playerCB.Items.Add(playerList(Index).name)
            searchPlayerCB.Items.Add(playerList(Index).name)
            nameLB.Items.Add(playerList(Index).name)
            scoreLB.Items.Add(playerList(Index).bestTime)
        Next

        NameLabel.ForeColor = Color.FromArgb(255, 114, 228)
        playerCB.ForeColor = Color.White
        playerCB.Text = ""

        nameLB.Hide()
        scoreLB.Hide()
        searchPlayerCB.Hide()
        showStatsBtn.Hide()
        sortByTimeBtn.Hide()
        sortByNameBtn.Hide()
        sortLabel.Hide()

    End Sub

    'quit game button
    Private Sub quitGame_Click(sender As Object, e As EventArgs) Handles quitGameBtn.Click
        Me.Hide()
        QuitGameMsgBox.Show()
    End Sub

    ' check if input in newNameTBox is correct
    Private Function estValide(text As String) As Boolean
        If Not String.IsNullOrWhiteSpace(text) Then
            Return True
        Else
            Return False
        End If

    End Function

    ' add new player to playerList if input is correct
    Private Sub addName_Click(sender As Object, e As EventArgs) Handles addNameBtn.Click
        If estValide(newNameTBox.Text) Then ' Verifie si le text es valide
            If Not playerExists(newNameTBox.Text) Then 'verifie se le nickname existe ou pas
                addPlayer(newNameTBox.Text)
                playerCB.Text = newNameTBox.Text
                playerCB.Items.Add(newNameTBox.Text)
            Else
                MsgBox("existing player")
            End If
        Else
            MsgBox("input error")
        End If
    End Sub

    ' start a game only if a player was chosen in playerCB
    Private Sub NewGameBtn_Click(sender As Object, e As EventArgs) Handles NewGameBtn.Click
        If Not estValide(playerCB.Text) Then
            NameLabel.ForeColor = Color.Red
            playerCB.ForeColor = Color.Red
            playerCB.Text = "Enter name"
        Else
            getCurrentIndex(playerCB.Text)
            Form1_Load(sender, e)
            Me.Hide()
            Sudoku3X3.Show()
        End If
    End Sub

    Private Sub playerCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles playerCB.SelectedIndexChanged
        playerCB.ForeColor = Color.White

    End Sub

    Private Sub scoreBtn_Click(sender As Object, e As EventArgs) Handles scoreBtn.Click
        homeBtn.FlatAppearance.BorderSize = 0
        scoreBtn.FlatAppearance.BorderSize = 1

        nameLB.Show()
        scoreLB.Show()
        searchPlayerCB.Show()
        showStatsBtn.Show()
        sortByTimeBtn.Show()
        sortByNameBtn.Show()
        sortLabel.Show()

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
        sortByTimeBtn.Hide()
        sortByNameBtn.Hide()
        sortLabel.Hide()
    End Sub

    Private Sub showStatsBtn_Click(sender As Object, e As EventArgs) Handles showStatsBtn.Click

        Me.Hide()

        stats.nameLabel.Text = playerList(currentPlayerIndex).name
        stats.bestTimeLb.Text = playerList(currentPlayerIndex).bestTime.ToString("m\mss\s")
        stats.totalTimeLb.Text = playerList(currentPlayerIndex).totalTime.ToString("m\mss\s")
        stats.nbGameLb.Text = playerList(currentPlayerIndex).nbGame

        stats.Show()
    End Sub

    Private Sub searchPlayerCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles searchPlayerCB.SelectedIndexChanged
        If searchPlayerCB IsNot Nothing Then
            getCurrentIndex(searchPlayerCB.Text)
            nameLB.SelectedIndex = currentPlayerIndex
        End If
    End Sub

    Private Sub nameLB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles nameLB.SelectedIndexChanged
        If nameLB.SelectedItems IsNot Nothing Then
            searchPlayerCB.Text = nameLB.Text

        End If
    End Sub

    Private Sub sortByNameBtn_Click(sender As Object, e As EventArgs) Handles sortByNameBtn.Click
        nameLB.Sorted = True
        scoreLB.Items.Clear()
        For Index As Integer = 0 To playerList.Length - 1
            getCurrentIndex(nameLB.Items(Index))
            scoreLB.Items.Add(playerList(currentPlayerIndex).bestTime)
        Next
    End Sub

    Private Sub sortByTimeBtn_Click(sender As Object, e As EventArgs) Handles sortByTimeBtn.Click

        Dim arr(scoreLB.Items.Count - 1) As Object

        scoreLB.Sorted = True
        scoreLB.Items.CopyTo(arr, 0)
        Array.Reverse(arr)
        scoreLB.Items.Clear()
        scoreLB.Sorted = False
        scoreLB.Items.AddRange(arr)

    End Sub
End Class
