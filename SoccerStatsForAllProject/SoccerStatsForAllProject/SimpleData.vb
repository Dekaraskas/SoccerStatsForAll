Public Class SimpleData ' Klasa ta zawiera przykładowe dane
    Public Shared Sub Load()

        With Collections.Teams

            .Add(New TeamsClass With {.TeamID = 0, .TeamName = "Bayern"})
            .Add(New TeamsClass With {.TeamID = 1, .TeamName = "Dortmund"})
            .Add(New TeamsClass With {.TeamID = 2, .TeamName = "Leverkusen"})
            .Add(New TeamsClass With {.TeamID = 3, .TeamName = "Schalke"})
            .Add(New TeamsClass With {.TeamID = 4, .TeamName = "Lipsk"})
            .Add(New TeamsClass With {.TeamID = 5, .TeamName = "Hoffenheim"})
        End With





    End Sub
End Class
