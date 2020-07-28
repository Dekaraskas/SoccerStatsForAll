' Wersja pliku: 1
Public Class InitializeMainWindow ' Ta klasa jest uruchamiana przy starcie programu
    Public Shared Sub ActionsWhenStart()



        ' Stworzenie przycisków i dodanie ich do FlowMenuButtons w oknie głównym
        MenuButtons.CreateMenuButtons()



        ' Dodanie do okna głównego FlowMenuButtons
        Form1.Controls.Add(AllControls.FlowMenuButtons)

        ' Wyświetlenie napisu z nazwą otwartego menu pod napisem tytułowym
        Form1.Controls.Add(AllControls.MenuLabel)

        ' Wyświetlenie napisu tytułowego zawierającego aktualnie otwartą bazę danych
        Form1.Controls.Add(AllControls.TitleLabel)

        ' Dodanie do okna głównego FlowForGB, który trzyma GroupBoxy z danymi
        Form1.Controls.Add(AllControls.FlowForGB)

        ' Ustawienie zdarzeń dla przycisków menu
        AllEvents.MenuButtonsEventsClass()


    End Sub
End Class
