﻿' Wersja pliku: 1
Public Class MiscMethods ' Klasa trzymająca różne metody

    Public Shared Sub ClearMenuButtons() ' Metoda ta odznacza wszystkie przyciski na żółto
        For x As Integer = 0 To AllControls.MenuButtons.Count - 1

            AllControls.MenuButtons(x).ForeColor = Color.Yellow
        Next
    End Sub

    Public Shared Sub ClearGB() ' Metoda ta czyści wszystkie GB

        For x As Integer = 0 To 5

            AllControls.GB(x).Text = "" ' Usunięcie nazwy GB
            AllControls.GB(x).Controls.Clear() ' Usunięcie wszystkich kontrolek z GB

        Next
    End Sub

    Public Shared Sub CommonGB() ' Wspólne czynności do pracy z GB, wywoływane przy starcie programu


        For x As Integer = 0 To 5

            AllControls.GB.Add(New GroupBox)

            With AllControls.GB(x)
                .BackColor = Color.DarkGreen
                .ForeColor = Color.White
                .Size = New Size(400, 200)


            End With

        Next

    End Sub


    Public Shared Sub ShowingGB() ' Wyświetlenie GB na ekranie

        For x As Integer = 0 To 5

            AllControls.FlowForGB.Controls.Add(AllControls.GB(x))

        Next

    End Sub
End Class