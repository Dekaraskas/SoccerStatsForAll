' Wersja pliku: 1
Public Class MiscMethods ' Klasa trzymająca różne metody

    Public Shared Sub ClearMenuButtons() ' Metoda ta odznacza wszystkie przyciski na żółto
        For x As Integer = 0 To AllControls.MenuButtons.Count - 1

            AllControls.MenuButtons(x).ForeColor = Color.Yellow
        Next
    End Sub

End Class
