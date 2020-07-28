' Wersja pliku: 1
Public Class MenuButtons ' Ta klasa zawiera metody, które służą do pracy z przyciskami menu


    Public Shared Sub CreateMenuButtons()
        ' Ta funkcja ustawia zawartość i wygląd przycisków menu


        With AllControls.MenuButtons
            .Add(New Button With {.Text = "Home"}) ' Pierwszy przycisk Home
            .Add(New Button With {.Text = "Fixture"})
            .Add(New Button With {.Text = "Results"})
            .Add(New Button With {.Text = "Teams"})
            .Add(New Button With {.Text = "Players"})
            .Add(New Button With {.Text = "Edit Panel"})
        End With
        ' Dodane nazwy przycisków


        ' Wspólne działania dla przycisków, ustawienie wyglądu

        For x As Integer = 0 To AllControls.MenuButtons.Count - 1

            With AllControls.MenuButtons(x)
                .BackColor = Color.Black
                .ForeColor = Color.Yellow
                .Size = New Size(120, 30)

            End With

            AllControls.FlowMenuButtons.Controls.Add(AllControls.MenuButtons(x)) ' Wyswietlenie przyciskow menu
            ' Dodanie przycisków menu do FlowMenuButtons
        Next

    End Sub

End Class
