Public Class SimpleData ' Klasa ta zawiera przykładowe dane
    Public Shared Sub Load()

        With Collections.Teams

            .Add(New TeamsClass With {.TeamID = 0, .TeamName = "Bayern", .TeamCountryID = 0})
            .Add(New TeamsClass With {.TeamID = 1, .TeamName = "Barcelona", .TeamCountryID = 2})
            .Add(New TeamsClass With {.TeamID = 2, .TeamName = "Liverpool", .TeamCountryID = 1})
            .Add(New TeamsClass With {.TeamID = 3, .TeamName = "Chelsea", .TeamCountryID = 1})
            .Add(New TeamsClass With {.TeamID = 4, .TeamName = "Juventus", .TeamCountryID = 3})
            .Add(New TeamsClass With {.TeamID = 5, .TeamName = "Paris SG", .TeamCountryID = 4})
        End With


        With Collections.Countries

            .Add(New CountriesClass With {.CountryID = 0, .CountryName = "Germany"})
            .Add(New CountriesClass With {.CountryID = 1, .CountryName = "England"})
            .Add(New CountriesClass With {.CountryID = 2, .CountryName = "Spain"})
            .Add(New CountriesClass With {.CountryID = 3, .CountryName = "Italy"})
            .Add(New CountriesClass With {.CountryID = 4, .CountryName = "France"})
        End With

        With Collections.Coaches


            .Add(New CoachesClass With {.CoachID = 0, .CoachFirstNane = "Hansi", .CoachSurname = "Flick", .CoachTeamID = 0})
            .Add(New CoachesClass With {.CoachID = 1, .CoachFirstNane = "Juergen", .CoachSurname = "Klopp", .CoachTeamID = 2})
        End With
    End Sub
End Class
