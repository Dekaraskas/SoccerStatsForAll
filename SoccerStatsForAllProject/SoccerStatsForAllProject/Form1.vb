Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        ' Ustawienie wyglądu okna głównego
        With Me
            .Text = "Soccer Stats For All"
            .BackColor = Color.DarkGreen
            .ForeColor = Color.White
            .WindowState = FormWindowState.Maximized
            .Font = New Font("Segoe UI", 9)

        End With
    End Sub
End Class
