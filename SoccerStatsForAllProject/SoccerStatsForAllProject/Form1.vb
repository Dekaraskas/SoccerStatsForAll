﻿Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        With Me

            .Text = "Simple Stats"
            .BackColor = Color.DarkGreen
            .ForeColor = Color.White
            .WindowState = FormWindowState.Maximized
            .Font = New Font("Segoe UI", 9)

        End With
    End Sub
End Class
