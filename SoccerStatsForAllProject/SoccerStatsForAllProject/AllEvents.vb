' Wersja pliku: 1

Public Class AllEvents ' Ta klasa przechowuje wywołania wszelkich zdarzeń w programie

    Public Shared Sub MenuButtonsEventsClass() ' Ta metoda ustawia akcje na przyciskach menu, kiedy zostaną kliknięte

        For x As Integer = 0 To AllControls.MenuButtons.Count - 1

            AddHandler AllControls.MenuButtons(x).Click, AddressOf MenuButtonClicked ' Dodaje zdarzenia, gdy zostanie kliknięty przycisk menu
        Next

    End Sub

    Private Shared Sub MenuButtonClicked(sender As Object, e As EventArgs) ' Wykonuje zdarzenie kliknięcia danego przycisku menu

        Dim WhichButton As Button = sender ' Ktory przycisk zostal klikniety
        MessageBox.Show(WhichButton.Text)
    End Sub
End Class
