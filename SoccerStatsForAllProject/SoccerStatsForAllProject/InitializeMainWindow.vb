Public Class InitializeMainWindow ' Ta klasa jest uruchamiana przy starcie programu
    Public Shared Sub ActionsWhenStart()



        ' Stworzenie przycisków i dodanie ich do FlowMenuButtons w oknie głównym
        MenuButtons.CreateMenuButtons()



        ' Dodanie do okna głównego FlowMenuButtons
        Form1.Controls.Add(AllControls.FlowMenuButtons)

    End Sub
End Class
