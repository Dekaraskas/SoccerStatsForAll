Public Class AllControls ' Klasa trzymająca wszystkie kontrolki w programie

    Public Shared FlowMenuButtons As New FlowLayoutPanel With {.Location = New Point(10, 10), .Size = New Size(140, 400)} ' Flowlayoutpanel dla przyciskow menu
    Public Shared MenuButtons As New List(Of Button) ' Kolekcja list przyciskow menu
    Public Shared TitleLabel As New Label With {.Text = "No database in memory", .AutoSize = False, .Dock = DockStyle.Top, .TextAlign = ContentAlignment.TopCenter, .ForeColor = Color.Yellow, .Font = New Font("Segoe UI", 12)} ' Napis tytulowy
    Public Shared MenuLabel As New Label With {.Text = "Home", .AutoSize = False, .Dock = DockStyle.Top, .TextAlign = ContentAlignment.TopCenter} ' Napis z wybranym menu
    Public Shared GB As New List(Of GroupBox) ' Kolekcja list GB
    Public Shared FlowForGB As New FlowLayoutPanel With {.Location = New Point(150, 40), .Size = New Size(1100, 700)} ' Flowlayoutpanel dla GB

End Class
