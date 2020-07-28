' Wersja pliku: 1
Public Class AllControls ' Klasa trzymająca wszystkie kontrolki w programie

    Public Shared FlowMenuButtons As New FlowLayoutPanel With {.Location = New Point(10, 10), .Size = New Size(140, 400)} ' Flowlayoutpanel dla przyciskow menu
    ' FlowMenuButtons trzyma wszystkie przyciski menu w celu ich grupowania, porządkowania i estetycznego wyświetlania

    Public Shared MenuButtons As New List(Of Button) ' Kolekcja list przyciskow menu
    ' Kolekcja List, która trzyma przyciski menu (na przykład Home, Teams, Players)

    Public Shared TitleLabel As New Label With {.Text = "No database in memory", .AutoSize = False, .Dock = DockStyle.Top, .TextAlign = ContentAlignment.TopCenter, .ForeColor = Color.Yellow, .Font = New Font("Segoe UI", 12)} ' Napis tytulowy
    ' Napis tytułowy, który wyświetla nazwę aktualnie otwartej bazy danych oraz jej ściężkę w strukturze plików

    Public Shared MenuLabel As New Label With {.Text = "Home", .AutoSize = False, .Dock = DockStyle.Top, .TextAlign = ContentAlignment.TopCenter} ' Napis z wybranym menu
    ' Poniżej TitleLabel znajduje się napis, który zawiera aktualnie wyświetlane menu. Przy starcie programu jest to "Home"

    Public Shared GB As New List(Of GroupBox) ' Kolekcja list GB
    ' Kolekcja GroupBoxów, która zawiera te kontrolki wyświetlane dla każdego menu


    Public Shared FlowForGB As New FlowLayoutPanel With {.Location = New Point(150, 40), .Size = New Size(1100, 700)} ' Flowlayoutpanel dla GB
    ' FlowForGB zawiera powyższe GroupBoxy i wyświetla je na ekranie
    ' Powyższe kontrolki określają podstawowy interfejs użytkownika
End Class
