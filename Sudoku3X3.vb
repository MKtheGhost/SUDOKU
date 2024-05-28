Imports System.IO
Imports System.Reflection.Emit

Public Class Sudoku3X3
    Dim sudokuArray(81) As TextBox
    Dim SelectedCell As Integer
    Dim sudokuGame As String
    Dim sudokuAnswer As String

    Dim WithEvents timerChronometre As New Timer()
    Dim tempsRestant As TimeSpan = TimeSpan.FromMinutes(7).Add(TimeSpan.FromSeconds(0))
    Private tempsEnregistre As TimeSpan

    Private Sub Sudoku3X3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        timerChronometre.Interval = 1000
        timerChronometre.Start()

        sudokuArray(1) = Case1_1
        sudokuArray(2) = Case1_2
        sudokuArray(3) = Case1_3
        sudokuArray(4) = Case1_4
        sudokuArray(5) = Case1_5
        sudokuArray(6) = Case1_6
        sudokuArray(7) = Case1_7
        sudokuArray(8) = Case1_8
        sudokuArray(9) = Case1_9
        sudokuArray(10) = Case2_1
        sudokuArray(11) = Case2_2
        sudokuArray(12) = Case2_3
        sudokuArray(13) = Case2_4
        sudokuArray(14) = Case2_5
        sudokuArray(15) = Case2_6
        sudokuArray(16) = Case2_7
        sudokuArray(17) = Case2_8
        sudokuArray(18) = Case2_9
        sudokuArray(19) = Case3_1
        sudokuArray(20) = Case3_2
        sudokuArray(21) = Case3_3
        sudokuArray(22) = Case3_4
        sudokuArray(23) = Case3_5
        sudokuArray(24) = Case3_6
        sudokuArray(25) = Case3_7
        sudokuArray(26) = Case3_8
        sudokuArray(27) = Case3_9
        sudokuArray(28) = Case4_1
        sudokuArray(29) = Case4_2
        sudokuArray(30) = Case4_3
        sudokuArray(31) = Case4_4
        sudokuArray(32) = Case4_5
        sudokuArray(33) = Case4_6
        sudokuArray(34) = Case4_7
        sudokuArray(35) = Case4_8
        sudokuArray(36) = Case4_9
        sudokuArray(37) = Case5_1
        sudokuArray(38) = Case5_2
        sudokuArray(39) = Case5_3
        sudokuArray(40) = Case5_4
        sudokuArray(41) = Case5_5
        sudokuArray(42) = Case5_6
        sudokuArray(43) = Case5_7
        sudokuArray(44) = Case5_8
        sudokuArray(45) = Case5_9
        sudokuArray(46) = Case6_1
        sudokuArray(47) = Case6_2
        sudokuArray(48) = Case6_3
        sudokuArray(49) = Case6_4
        sudokuArray(50) = Case6_5
        sudokuArray(51) = Case6_6
        sudokuArray(52) = Case6_7
        sudokuArray(53) = Case6_8
        sudokuArray(54) = Case6_9
        sudokuArray(55) = Case7_1
        sudokuArray(56) = Case7_2
        sudokuArray(57) = Case7_3
        sudokuArray(58) = Case7_4
        sudokuArray(59) = Case7_5
        sudokuArray(60) = Case7_6
        sudokuArray(61) = Case7_7
        sudokuArray(62) = Case7_8
        sudokuArray(63) = Case7_9
        sudokuArray(64) = Case8_1
        sudokuArray(65) = Case8_2
        sudokuArray(66) = Case8_3
        sudokuArray(67) = Case8_4
        sudokuArray(68) = Case8_5
        sudokuArray(69) = Case8_6
        sudokuArray(70) = Case8_7
        sudokuArray(71) = Case8_8
        sudokuArray(72) = Case8_9
        sudokuArray(73) = Case9_1
        sudokuArray(74) = Case9_2
        sudokuArray(75) = Case9_3
        sudokuArray(76) = Case9_4
        sudokuArray(77) = Case9_5
        sudokuArray(78) = Case9_6
        sudokuArray(79) = Case9_7
        sudokuArray(80) = Case9_8
        sudokuArray(81) = Case9_9

        ' Initialize the random-number generator
        Randomize()
        ' Generate random value between 0 and sudokuGame max index
        Dim randomGame As Integer = CInt(Int(sudokuGameList.Length * Rnd()))

        sudokuGame = sudokuGameList(randomGame)
        sudokuAnswer = sudokuAnswerList(randomGame)

        nameLabel.Text = playerList(currentPlayerIndex).name

        For Index As Integer = 1 To 81
            sudokuArray(Index).Tag = Index
            sudokuArray(Index).BackColor = Color.FromArgb(17, 17, 40)
            sudokuArray(Index).MaxLength = 1

            If sudokuGame(Index - 1) <> "0" Then
                sudokuArray(Index).Text = sudokuGame(Index - 1)
                sudokuArray(Index).BackColor = Color.FromArgb(255, 229, 121)
                sudokuArray(Index).ForeColor = Color.Black
                sudokuArray(Index).ReadOnly = True
            End If
        Next

    End Sub

    Private Sub giveUpButton_Click(sender As Object, e As EventArgs) Handles giveUpButton.Click
        Dim gameState As Boolean = False
        timerChronometre.Stop()
        For Index As Integer = 1 To sudokuGame.Length
            If sudokuArray(Index).Text <> sudokuAnswer(Index - 1) Then
                gameState = True
            End If
        Next

        If gameState = True Then
            addPoints(New TimeSpan(0, 0, 0, 0))
            Lose.Show()
        Else
            addPoints(tempsRestant)
            Win.Show()
        End If
        Me.Hide()
    End Sub

    Private Sub ClickArray(sender As Object, e As EventArgs) Handles Case1_1.Click, Case1_2.Click, Case1_3.Click, Case2_1.Click, Case2_2.Click, Case2_3.Click, Case3_1.Click, Case3_2.Click, Case3_3.Click, Case1_4.Click, Case1_5.Click, Case1_6.Click, Case2_4.Click, Case2_5.Click, Case2_6.Click, Case3_4.Click, Case3_5.Click, Case3_6.Click, Case1_7.Click, Case1_8.Click, Case1_9.Click, Case2_7.Click, Case2_8.Click, Case2_9.Click, Case3_7.Click, Case3_8.Click, Case3_9.Click, Case4_1.Click, Case4_2.Click, Case4_3.Click, Case5_1.Click, Case5_2.Click, Case5_3.Click, Case6_1.Click, Case6_2.Click, Case6_3.Click, Case4_4.Click, Case4_5.Click, Case4_6.Click, Case5_4.Click, Case5_5.Click, Case5_6.Click, Case6_4.Click, Case6_5.Click, Case6_6.Click, Case4_7.Click, Case4_8.Click, Case4_9.Click, Case5_7.Click, Case5_8.Click, Case5_9.Click, Case6_7.Click, Case6_8.Click, Case6_9.Click, Case7_2.Click, Case7_3.Click, Case8_1.Click, Case8_2.Click, Case8_3.Click, Case9_1.Click, Case9_2.Click, Case9_3.Click, Case7_4.Click, Case7_5.Click, Case7_6.Click, Case8_4.Click, Case8_5.Click, Case8_6.Click, Case9_4.Click, Case9_5.Click, Case9_6.Click, Case7_7.Click, Case7_8.Click, Case7_9.Click, Case8_7.Click, Case8_8.Click, Case8_9.Click, Case9_7.Click, Case9_8.Click, Case9_9.Click
        Sudoku3X3_Load(sender, e)
        Dim tempCase As TextBox
        tempCase = CType(sender, TextBox)
        SelectedCell = Val(tempCase.Tag)
        'selectedRow()
        'selectedColumm()
        tempCase.BackColor = Color.FromArgb(255, 114, 228)

    End Sub

    Sub selectedRow()
        Dim CellIndex = ((SelectedCell \ 9) * 9) + 1
        If SelectedCell - (9 * (SelectedCell \ 9)) = 0 Then CellIndex = SelectedCell - 8
        For Index = CellIndex To CellIndex + 8
            sudokuArray(Index).BackColor = Color.Gray
        Next
    End Sub

    Sub selectedColumm()

        Dim count As Integer = SelectedCell - (9 * (SelectedCell \ 9))
        If count = 0 Then count = 9
        While count <= 81
            sudokuArray(count).BackColor = Color.Gray
            count += 9
        End While
    End Sub

    Private Sub AfficherTempsRestant()
        ' Afficher la durée restante dans un format d'horloge
        timeLabel.Text = tempsRestant.ToString("m\mss\s")
    End Sub

    Private Sub EnregistrerTemps()
        MsgBox(tempsRestant)
    End Sub
    Private Sub timerChronometre_Tick(sender As Object, e As EventArgs) Handles timerChronometre.Tick
        ' Décrémenter la durée restante d'une seconde
        tempsRestant = tempsRestant.Subtract(TimeSpan.FromSeconds(1))
        ' Afficher la durée restante mise à jour
        AfficherTempsRestant()

        ' Vérifier si le temps est écoulé
        If tempsRestant.TotalSeconds <= 0 Then
            ' Arrêter le Timer
            timerChronometre.Stop()
            EnregistrerTemps()
            ' Effectuer l'action de fin de jeu

        End If
    End Sub
End Class