Imports System.IO

Module Module1
    Public Structure joeur
        Dim nickName As String
        Dim points As Double
    End Structure

    Public tab As joeur()
    Private cpt As Integer = 0
    Private dataList As List(Of String)
    Public loggedPlayer As Integer


    Public Sub AjouterJoeur(j As joeur)
        'redim si plein
        If tab.Length = cpt Then
            ReDim tab(cpt + 2)
        Else
            tab(cpt) = j
            cpt += 1
        End If

    End Sub

    Public Function Existent(nickName As String) As Boolean
        For i As Integer = 0 To cpt < i
            If tab(i).nickName = nickName Then
                Return True
            End If
        Next
        Return False
    End Function

    Public Sub NewGame(player As ComboBox)
        For i As Integer = 0 To cpt < i
            If tab(i).nickName = player.Text Then
                loggedPlayer = i
            Else
                'player n'est pas dans la base
            End If
        Next
    End Sub

    Public Sub AjouterPoints(tempsEnregistre As TimeSpan)
        Dim points As Double = tempsEnregistre.TotalMinutes
        tab(loggedPlayer).points = points
    End Sub
    Public Sub main()
        'preparation des données
        'dataList = File.ReadAllLines("..\..\playerName.txt").ToList()
        ReDim tab(0)

        'lancement interactions utilisateur
        Application.Run(Form1)
    End Sub
End Module
