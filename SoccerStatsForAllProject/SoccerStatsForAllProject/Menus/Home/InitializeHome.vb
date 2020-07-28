' Wersja pliku: 1
Public Class InitializeHome
    Public Shared Sub Load() ' Ta metoda wczytuje menu Home

        ' W menu Home wyświetlane jest 6 GroupBoxów o nazwach: League Table, Fixture, Results, Top Scorers, Assists, Last Transfers

        MiscMethods.ClearGB() ' Czyszczenie GB

        ' Nadanie nazw GB

        AllControls.GB(0).Text = "League Table"
        AllControls.GB(1).Text = "Fixture"
        AllControls.GB(2).Text = "Results"
        AllControls.GB(3).Text = "Top Scorers"
        AllControls.GB(4).Text = "Assists"
        AllControls.GB(5).Text = "Last Transfers"
    End Sub
End Class
