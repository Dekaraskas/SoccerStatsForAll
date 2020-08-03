Imports System.Drawing.Text

Public Class InitializeTeams

    ' ListView dla listy drużyn
    Public Shared TeamList As New ListView

    Public Shared CriteriaFlow As New FlowLayoutPanel With {.AutoSize = True, .Dock = DockStyle.Top}

    ' LabelCountry
    Public Shared LabelCountry As New Label With {.Text = "Country:", .TextAlign = ContentAlignment.MiddleCenter}

    ' ComboBox with Countries
    Public Shared CBCountry As New ComboBox

    ' Wybrany kraj
    Public Shared SelectedCountry As Integer = 0 ' Wybrano wszystkie kraje
    Public Shared Sub Load() ' Ta metoda wczytuje menu Teams

        MiscMethods.ClearGB() ' Czyszczenie GB

        ' Nadanie nazw GB
        AllControls.GB(0).Text = "Team List"
        AllControls.GB(1).Text = "Team Details"


        ' Dodanie ListView "TeamList" do GB(0)
        AllControls.GB(0).Controls.Add(TeamList)

        ' Dodanie LabelCountry do CriteriaFlow
        CriteriaFlow.Controls.Add(LabelCountry)


        ' Ustawienie wyglądu CBCountry
        MiscMethods.SetAppearanceOfComboBox(CBCountry)

        ' Dodanie CBContry do CriteriaFlow
        CriteriaFlow.Controls.Add(CBCountry)

        ' Fodanie Criteria Flow do GB(0)
        AllControls.GB(0).Controls.Add(CriteriaFlow)



        ' Wyczyszczenie CBCountry

        CBCountry.Items.Clear()




        ' Wypełnienie CBCountry nazwami krajów

        ' Pierwszy element CBCountry to "All", wyświetla wszystkie drużyny


        CBCountry.Items.Add("All")

        For x As Integer = 0 To Collections.Countries.Count - 1

            CBCountry.Items.Add(Collections.Countries(x).CountryName)

        Next


        ' Zaznacznie "All"
        CBCountry.SelectedIndex = 0




        ' Wywołanie funkcji wypełniającej TeamList


        FillingTeamList()











        ' Ustawienie wyglądu TeamList

        MiscMethods.SetAppearanceofListView(TeamList)


        ' Wywołanie zdarzenia kliknięcia w nazwę drużyny w TeamList


        AddHandler TeamList.SelectedIndexChanged, AddressOf TeamListTeamClicked

        ' Zdarzenie dla zmiany kraju w CBCountry

        AddHandler CBCountry.SelectedIndexChanged, AddressOf CBCountryChanged




    End Sub


    ' Zdarzenie dla zmiany kraju w CBCountry
    Private Shared Sub CBCountryChanged(sender As Object, e As EventArgs)

        If CBCountry.SelectedIndex > -1 Then
            SelectedCountry = CBCountry.SelectedIndex

            FillingTeamList()

        End If
    End Sub


    ' Zdarzenie dla kliknięcia drużyny w TeamList
    Private Shared Sub TeamListTeamClicked(sender As Object, e As EventArgs)
        If TeamList.SelectedIndices.Count > 0 Then

            'MessageBox.Show(TeamList.Items(TeamList.SelectedIndices(0)).Tag.ToString)

            AllControls.GB(1).Text = "Team Details - " + Collections.Teams(TeamList.Items(TeamList.SelectedIndices(0)).Tag).TeamName
        End If
    End Sub


    Private Shared Sub FillingTeamList() ' Funkcja ta wypełnia TeamList

        ' Usunięcie zawartości TeamList
        TeamList.Clear()


        ' Dodanie kolumn do TeamList

        TeamList.Columns.Add("Team Name")
        TeamList.Columns.Add("Country")
        TeamList.Columns.Add("Coach")
        ' Wypełnienie TeamList drużynami i krajami

        ' Warunek gdy wybrano wszystkie kraje
        If SelectedCountry = 0 Then

            For x As Integer = 0 To Collections.Teams.Count - 1

                TeamList.Items.Add(Collections.Teams(x).TeamName)
                TeamList.Items(x).Tag = x
                TeamList.Items(x).SubItems.Add(Collections.Countries(Collections.Teams(x).TeamCountryID).CountryName)

                CoachesToTeamList(x)


            Next

        End If


        ' Warunek gdy wybrano jakiś kraj

        Dim Counter As Integer = -1 ' Licznik odniesień do drużyn
        If SelectedCountry > 0 Then


            For x As Integer = 0 To Collections.Teams.Count - 1

                If Collections.Teams(x).TeamCountryID = SelectedCountry - 1 Then

                    Counter += 1

                    TeamList.Items.Add(Collections.Teams(x).TeamName)
                    TeamList.Items(Counter).Tag = x
                    TeamList.Items(Counter).SubItems.Add(Collections.Countries(SelectedCountry - 1).CountryName)
                    CoachesToTeamList(Counter)
                End If
            Next


        End If
    End Sub

    Public Shared Sub CoachesToTeamList(y As Integer)


        ' Dodanie trenerów drużyn do TeamList

        Dim GetCoachesFirstName = From Coach In Collections.Coaches
                                  Where Coach.CoachTeamID = TeamList.Items(y).Tag
                                  Select Coach.CoachFirstNane




        Dim GetCoachesSurname = From Coach In Collections.Coaches
                                Where Coach.CoachTeamID = TeamList.Items(y).Tag
                                Select Coach.CoachSurname

        TeamList.Items(y).SubItems.Add(GetCoachesFirstName(0) + " " + GetCoachesSurname(0))
    End Sub
End Class
