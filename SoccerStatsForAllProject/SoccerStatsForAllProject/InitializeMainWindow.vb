Public Class InitializeMainWindow ' Ta klasa jest uruchamiana przy starcie programu
    Public Shared Sub ActionsWhenStart()



        ' Stworzenie przycisków i dodanie ich do FlowMenuButtons w oknie głównym
        MenuButtons.CreateMenuButtons()



        ' Dodanie do okna głównego FlowMenuButtons
        Form1.Controls.Add(AllControls.FlowMenuButtons)


        ' Wyświetlenie napisu tytułowego zawierającego aktualnie otwartą bazę danych
        Form1.Controls.Add(AllControls.TitleLabel)

    End Sub
End Class
