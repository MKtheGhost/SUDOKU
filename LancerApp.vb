Imports System.IO
Imports System.Reflection
Imports Microsoft.Office.Interop.Excel

Module dataManipulation
    Public Structure player
        Dim name As String
        Dim totalTime As TimeSpan
        Dim bestTime As TimeSpan
        Dim nbGame As Integer
    End Structure

    'list of players
    Public playerList() As player
    Public currentPlayerIndex As Integer

    'list of game and answers
    Public sudokuGameList = File.ReadAllLines("..\..\data\sudokuGame.txt")
    Public sudokuAnswerList = File.ReadAllLines("..\..\data\sudokuAnswer.txt")

    Public Sub loadPlayer()
        Dim nameList = File.ReadAllLines("..\..\data\playerName.txt")
        Dim totalTimeList = File.ReadAllLines("..\..\data\totalTime.txt")
        Dim bestTimeList = File.ReadAllLines("..\..\data\bestTime.txt")
        Dim nbGameList = File.ReadAllLines("..\..\data\nbGame.txt")

        ReDim playerList(nameList.Length - 1)

        For Index As Integer = 0 To nameList.Length - 1
            playerList(Index) = New player()
            playerList(Index).name = nameList(Index)
            playerList(Index).totalTime = TimeSpan.Parse(totalTimeList(Index))
            playerList(Index).bestTime = TimeSpan.Parse(bestTimeList(Index))
            playerList(Index).nbGame = Integer.Parse(nbGameList(Index))

        Next
    End Sub

    'add a new player to playerList
    Public Sub addPlayer(name As String)
        ReDim Preserve playerList(playerList.Length)
        playerList(playerList.Length - 1) = New player()
        playerList(playerList.Length - 1).name = name
        playerList(playerList.Length - 1).totalTime = New TimeSpan(0, 0, 0, 0)
        playerList(playerList.Length - 1).bestTime = New TimeSpan(0, 0, 0, 0)
        playerList(playerList.Length - 1).nbGame = 0

    End Sub

    'verify if a player s already registered
    Public Function playerExists(name As String) As Boolean
        For Index As Integer = 0 To playerList.Length - 1
            If playerList(Index).name = name Then
                Return True
            End If
        Next
        Return False
    End Function

    'get current player's index
    Public Sub getCurrentIndex(currentPlayer As String)
        For Index As Integer = 0 To playerList.Length - 1
            If currentPlayer = playerList(Index).name Then
                currentPlayerIndex = Index
                Exit For
            End If
        Next
    End Sub

    'update points to current player
    Public Sub addPoints(time As TimeSpan)
        playerList(currentPlayerIndex).totalTime += time
        'MsgBox(time.ToString("m\mss\s"))
        'MsgBox(playerList(currentPlayerIndex).totalTime.ToString("m\mss\s"))

        If time.CompareTo(playerList(currentPlayerIndex).bestTime) > 0 Then
            playerList(currentPlayerIndex).bestTime = time
            'MsgBox(playerList(currentPlayerIndex).bestTime.ToString("m\mss\s"))
        End If
        playerList(currentPlayerIndex).nbGame += 1

    End Sub

    'update data at the end of game
    Public Sub updateData()
        Dim nameWriter As New System.IO.StreamWriter("..\..\data\playerName.txt", False)
        Dim totalTimeWriter As New System.IO.StreamWriter("..\..\data\totalTime.txt", False)
        Dim bestTimeWriter As New System.IO.StreamWriter("..\..\data\bestTime.txt", False)
        Dim nbGameWriter As New System.IO.StreamWriter("..\..\data\nbGame.txt", False)

        For Index As Integer = 0 To playerList.Length - 1
            nameWriter.WriteLine(playerList(Index).name)
            totalTimeWriter.WriteLine(playerList(Index).totalTime)
            bestTimeWriter.WriteLine(playerList(Index).bestTime)
            nbGameWriter.WriteLine(playerList(Index).nbGame)
        Next

        nameWriter.Close()
        totalTimeWriter.Close()
        bestTimeWriter.Close()
        nbGameWriter.Close()

    End Sub

End Module
