Public Class Collections ' Kolekcje z bazą danych

    Public Shared Teams As New List(Of TeamsClass) ' Kolekcja druzyn
    Public Shared Matches As New List(Of MatchesClass) ' Kolekcja meczow
    Public Shared Players As New List(Of PlayersClass) ' Kolekcja pilkarzy

End Class

Public Class TeamsClass

    Public Property TeamID As Integer
    Public Property TeamName As String
End Class


Public Class MatchesClass


End Class

Public Class PlayersClass



End Class