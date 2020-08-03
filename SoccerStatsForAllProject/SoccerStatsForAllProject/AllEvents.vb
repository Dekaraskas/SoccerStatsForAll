' Wersja pliku: 1

Public Class AllEvents ' Ta klasa przechowuje wywołania wszelkich zdarzeń w programie

    Public Shared Sub MenuButtonsEventsClass() ' Ta metoda ustawia akcje na przyciskach menu, kiedy zostaną kliknięte

        For x As Integer = 0 To AllControls.MenuButtons.Count - 1

            AddHandler AllControls.MenuButtons(x).Click, AddressOf MenuButtonClicked ' Dodaje zdarzenia, gdy zostanie kliknięty przycisk menu
        Next

    End Sub

    Private Shared Sub MenuButtonClicked(sender As Object, e As EventArgs) ' Wykonuje zdarzenie kliknięcia danego przycisku menu

        Dim WhichButton As Button = sender ' Ktory przycisk zostal klikniety

        MiscMethods.ClearMenuButtons() ' Odznacza wszystkie przyciski






        WhichButton.ForeColor = Color.Red ' Ustawienie koloru przycisku, ktory zostal klikniety
        AllControls.MenuLabel.Text = WhichButton.Text ' Zmienia MenuLabel na wybrane menu

        If WhichButton.Text = "Home" Then
            InitializeHome.Load() ' Przejście do czynności wyświetlenia menu Home

        End If


        If WhichButton.Text = "Teams" Then
            InitializeTeams.Load() ' Przejście do czynności wyświetlania menu Teams
        End If
    End Sub
End Class
