Public Class SpoilerForm
    Private Sub SpoilerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & " Ver: " & My.Application.Info.Version.ToString
        ToolStripMenuItem1.Text = "Seed: " & My.Settings.PreviousSeed
        LoadLocations()
    End Sub
    Sub LoadLocations()
        DataGridView1.Rows.Clear()
        For i As Integer = 0 To Randomizer.LocationInformation.Count - 1
            DataGridView1.Rows.Add(Randomizer.LocationInformation(i).PlaceOrder,
                                   Randomizer.LocationInformation(i).Item.ToString,
                                   Randomizer.LocationInformation(i).ItemName,
                                   Randomizer.LocationInformation(i).ItemWeight,
                                   Randomizer.LocationInformation(i).Name,
                                   Randomizer.LocationInformation(i).Region.ToString,
                                   Randomizer.LocationInformation(i).Vanilla.ToString,
                                   Randomizer.LocationInformation(i).VanillaPlacement,
                                   Randomizer.LocationInformation(i).Weight,
                                   Randomizer.LocationInformation(i).RerollCount)
        Next
    End Sub

    Private Sub ExportLocationsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportLocationsToolStripMenuItem.Click
        SaveFileDialog1.FileName = My.Settings.PreviousSeed & ".xml"
        If SaveFileDialog1.ShowDialog = DialogResult.OK Then
            Randomizer.ExportLocations(SaveFileDialog1.FileName)
        End If
    End Sub

    Private Sub ImportLocationsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportLocationsToolStripMenuItem.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Randomizer.ImportLocations(OpenFileDialog1.FileName)
            ToolStripMenuItem1.Text = "Seed: Loaded File"
            LoadLocations()
        End If
    End Sub
End Class