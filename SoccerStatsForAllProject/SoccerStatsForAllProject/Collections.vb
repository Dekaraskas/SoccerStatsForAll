Public Class Collections ' Kolekcje z bazą danych

    Public Shared Teams As New List(Of TeamsClass) ' Kolekcja druzyn
    Public Shared Matches As New List(Of MatchesClass) ' Kolekcja meczow
    Public Shared Players As New List(Of PlayersClass) ' Kolekcja pilkarzy
    Public Shared Countries As New List(Of CountriesClass) ' Kolekcja krajów
    Public Shared Coaches As New List(Of CoachesClass) ' Kolekcja trenerów

End Class

Public Class CoachesClass

    Public Property CoachID As Integer
    Public Property CoachFirstNane As String
    Public Property CoachSurname As String
    Public Property CoachTeamID As Integer
End Class

Public Class TeamsClass

    Public Property TeamID As Integer
    Public Property TeamName As String
    Public Property TeamCountryID As Integer
End Class


Public Class MatchesClass


End Class

Public Class PlayersClass



End Class


Public Class CountriesClass
    Public Property CountryID As Integer
    Public Property CountryName As String
End Class