Imports System.Text.RegularExpressions 'Text Replace
Imports System.IO    'Files
Public Class RandomMenu
#Region "Form Startup"
    Private Sub RandomMenu_LoadRandomMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & " Ver: " & My.Application.Info.Version.ToString
        FileSelect.Close()
        AddDifficulties()
        CheckLastSeed()
        CheckRandoExe()
        MenuHeight()
        If My.Settings.SaveMenuSettings Then LoadSavedSettings()
    End Sub
    Shared Sub AddDifficulties()
        RandomMenu.ComboBoxDifficulties.Items.AddRange(System.Enum.GetNames(GetType(Randomizer.DifficultySetting)))
        RandomMenu.ComboBoxDifficulties.SelectedIndex = 0
    End Sub
    Sub CheckLastSeed()
        If My.Settings.RandomSeedOnLaunch Then
            TextBoxSeed.Text = GetRandomNumber().ToString
        Else
            If My.Settings.PreviousSeed = "" Then
                My.Settings.PreviousSeed = GetRandomNumber().ToString
            End If
            TextBoxSeed.Text = My.Settings.PreviousSeed
        End If
    End Sub
    Sub CheckRandoExe()
        If My.Settings.RandoExePath = "" Then
            OpenRandomizedGameToolStripMenuItem.Enabled = False
        Else
            If File.Exists(My.Settings.RandoExePath) Then
                OpenRandomizedGameToolStripMenuItem.Enabled = True
            Else
                OpenRandomizedGameToolStripMenuItem.Enabled = False
            End If
        End If
    End Sub
    Shared Sub MenuHeight()
        If Application.OpenForms().OfType(Of RandomMenu).Any Then
            If My.Settings.MapGeneration = "Custom" Then
                If My.Settings.DebugMode Then
                    RandomMenu.Height = 650
                    RandomMenu.TextBoxDebug.Visible = True
                Else
                    RandomMenu.Height = 300
                    RandomMenu.TextBoxDebug.Visible = False
                End If
            Else
                If My.Settings.DebugMode Then
                    RandomMenu.Height = 650
                    RandomMenu.TextBoxDebug.Visible = True
                Else
                    RandomMenu.Height = 225
                    RandomMenu.TextBoxDebug.Visible = False
                End If
            End If
        End If
    End Sub
    Sub LoadSavedSettings()
        ComboBoxDifficulties.SelectedIndex = ComboBoxDifficulties.Items.IndexOf(My.Settings.MenuSavedDifficulty)
        If My.Settings.MenuSavedMapOptions = "Default" Then
            RadioButtonDefaultMap.Checked = True
        ElseIf My.Settings.MenuSavedMapOptions = "Custom" Then
            RadioButtonCustomMap.Checked = True
        ElseIf My.Settings.MenuSavedMapOptions = "Vanilla" Then
            RadioButtonVanillaMap.Checked = True
        End If
        CheckBoxWalls.Checked = My.Settings.MenuSavedUkkin_Na1Way
        CheckBoxIllusion.Checked = My.Settings.MenuSavedIllusionDelete
        CheckBoxDropDown.Checked = My.Settings.MenuSavedZi1Way
        CheckBoxOpenEribu.Checked = My.Settings.MenuSavedOpenEribu
        CheckBoxOpenElsenova.Checked = My.Settings.MenuSavedOpenElsenova
        CheckBoxOpenAbsu.Checked = My.Settings.MenuSavedOpenAbsu
        TrackBarBatchSize.Value = My.Settings.MenuSavedBatchSize
    End Sub
    Private Sub RandomMenu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        My.Settings.PreviousSeed = TextBoxSeed.Text
        If My.Settings.SaveMenuSettings Then SaveMenuSettings()
    End Sub
    Sub SaveMenuSettings()
        My.Settings.MenuSavedDifficulty = ComboBoxDifficulties.SelectedItem.ToString
        If RadioButtonDefaultMap.Checked Then
            My.Settings.MenuSavedMapOptions = "Default"
        ElseIf RadioButtonCustomMap.Checked Then
            My.Settings.MenuSavedMapOptions = "Custom"
        ElseIf RadioButtonVanillaMap.Checked Then
            My.Settings.MenuSavedMapOptions = "Vanilla"
        End If
        My.Settings.MenuSavedUkkin_Na1Way = CheckBoxWalls.Checked
        My.Settings.MenuSavedIllusionDelete = CheckBoxIllusion.Checked
        My.Settings.MenuSavedZi1Way = CheckBoxDropDown.Checked
        My.Settings.MenuSavedOpenEribu = CheckBoxOpenEribu.Checked
        My.Settings.MenuSavedOpenElsenova = CheckBoxOpenElsenova.Checked
        My.Settings.MenuSavedOpenAbsu = CheckBoxOpenAbsu.Checked
        My.Settings.MenuSavedBatchSize = TrackBarBatchSize.Value
    End Sub
#End Region
#Region "Form Controls"
    Private Sub ButtonRandomSeed_Click(sender As Object, e As EventArgs) Handles ButtonRandomSeed.Click
        TextBoxSeed.Text = GetRandomNumber().ToString
    End Sub
    Function GetRandomNumber() As Integer
        Randomize()
        If Rnd() > 0.5 Then
            Return CInt(Rnd() * Integer.MaxValue)
        Else
            Return CInt(-(Rnd() * Integer.MaxValue))
        End If

    End Function
    Private Sub CheckBoxWalls_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxWalls.CheckedChanged
        If CheckBoxWalls.Checked = False AndAlso RadioButtonCustomMap.Checked Then
            MessageBox.Show("Diabling this may increase the chance of soft-locking in Ukkin-Na")
        End If
    End Sub
    Private Sub CheckBoxDropDown_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxDropDown.CheckedChanged
        If CheckBoxDropDown.Checked = False AndAlso RadioButtonCustomMap.Checked Then
            MessageBox.Show("Diabling this may increase the chance of soft-locking in Zi")
        End If
    End Sub
    Private Sub ButtonBuild_Click(sender As Object, e As EventArgs) Handles ButtonBuild.Click
        Dim SelectedDifficulty As Randomizer.DifficultySetting =
        DirectCast([Enum].Parse(GetType(Randomizer.DifficultySetting),
                                ComboBoxDifficulties.SelectedItem.ToString),
                                Randomizer.DifficultySetting)
        If Not SelectedDifficulty = Randomizer.DifficultySetting.Rebuild Then
            PackUnpack.CopyToWorking()
            If TileMapEditor.CheckTileMaps() Then
                My.Settings.PreviousSeed = TextBoxSeed.Text
                Randomizer.BuildLocations(CLng(TextBoxSeed.Text), SelectedDifficulty, CheckBoxOpenEribu.Checked, CheckBoxOpenElsenova.Checked, CheckBoxOpenAbsu.Checked)
                'If CheckBoxMonsters.Checked Then
                'Randomizer.ShuffleMonsters(CLng(TextBoxSeed.Text), SelectedDifficulty)
                'Else
                'Randomizer.MonsterList = New List(Of GameInformation.MonsterSpawn)
                'End If
                TileMapEditor.WriteItems()
                TileMapEditor.OneWayDropDown(CheckBoxDropDown.Checked)
                TileMapEditor.OneWayWalls(CheckBoxWalls.Checked)
                TileMapEditor.RemoveIllusion(CheckBoxIllusion.Checked)
                TileMapEditor.OpenEribu(CheckBoxOpenEribu.Checked)
                TileMapEditor.OpenElsenova(CheckBoxOpenElsenova.Checked)
                TileMapEditor.OpenAbsu(CheckBoxOpenAbsu.Checked)
                XMLTools.ExportLocations(My.Settings.XMLSaveLocation)
                XMLEditor.WriteSettings(CLng(TextBoxSeed.Text),
                                        SelectedDifficulty,
                                        CheckBoxOpenEribu.Checked,
                                        CheckBoxOpenElsenova.Checked,
                                        CheckBoxOpenAbsu.Checked,
                                        CheckBoxDropDown.Checked,
                                        CheckBoxWalls.Checked,
                                        CheckBoxIllusion.Checked)
            Else
                MessageBox.Show("Error With Tile Map")
            End If
        End If
        PackUnpack.BuildFromAppdata(My.Settings.ExeFilePath)
        CheckRandoExe()
        MessageBox.Show("Build complete.")
    End Sub
    Private Sub ButtonSpoiler_Click(sender As Object, e As EventArgs) Handles ButtonSpoiler.Click
        My.Settings.PreviousSeed = TextBoxSeed.Text
        Dim SelectedDifficulty As Randomizer.DifficultySetting =
            DirectCast([Enum].Parse(GetType(Randomizer.DifficultySetting),
                                    ComboBoxDifficulties.SelectedItem.ToString),
                                    Randomizer.DifficultySetting)
        Randomizer.BuildLocations(CLng(TextBoxSeed.Text), SelectedDifficulty, CheckBoxOpenElsenova.Checked, CheckBoxOpenEribu.Checked, CheckBoxOpenAbsu.Checked)
        SpoilerForm.Show()
    End Sub
    Private Sub TextBoxSeed_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSeed.TextChanged
        'THis can have bad data pasted in still TO FIX
        Dim SentTextBox As TextBox = CType(sender, TextBox)
        Dim CursorPosition As Integer = SentTextBox.SelectionStart
        SentTextBox.Text = Regex.Replace(SentTextBox.Text, "[^\d-]", "")
        If InStrRev(SentTextBox.Text, "-") > 1 Then
            SentTextBox.Text = Regex.Replace(SentTextBox.Text, "[-]", "")
        End If
        If SentTextBox.Text.Length > 0 AndAlso
            SentTextBox.Text <> "-" AndAlso
         CLng(SentTextBox.Text) > Integer.MaxValue OrElse
         CLng(SentTextBox.Text) < Integer.MinValue Then
            SentTextBox.Text = SentTextBox.Text.Substring(0, SentTextBox.Text.Length - 1)
        End If
        SentTextBox.SelectionStart = CursorPosition
    End Sub
    Private Sub TrackBarBatchSize_Scroll(sender As Object, e As EventArgs) Handles TrackBarBatchSize.Scroll
        LabelBatchSize.Text = "Batch Size: " & TrackBarBatchSize.Value
    End Sub
    Public Shared BatchList As List(Of GameInformation.Location)
    Private Sub ButtonGenerateBatch_Click(sender As Object, e As EventArgs) Handles ButtonGenerateBatch.Click
        Dim SelectedDifficulty As Randomizer.DifficultySetting =
    DirectCast([Enum].Parse(GetType(Randomizer.DifficultySetting),
                            ComboBoxDifficulties.SelectedItem.ToString),
                            Randomizer.DifficultySetting)
        'first one we do out of the loop so we can pair the name locations and vanilla order for future locations
        Randomizer.BuildLocations(GetRandomNumber(), SelectedDifficulty, CheckBoxOpenElsenova.Checked, CheckBoxOpenEribu.Checked, CheckBoxOpenAbsu.Checked)
        Randomizer.LocationInformation.Sort(Function(x, y) x.VanillaPlacement.CompareTo(y.VanillaPlacement))
        Randomizer.LocationInformation.Reverse()
        BatchList = New List(Of GameInformation.Location)
        For i As Integer = 0 To Randomizer.LocationInformation.Count - 1
            Dim TempItemList As New List(Of GameInformation.ItemType)
            TempItemList.Add(Randomizer.LocationInformation(i).Item)
            Dim CurrentBatch As New GameInformation.Location With {
                .Name = Randomizer.LocationInformation(i).Name,
                .Vanilla = Randomizer.LocationInformation(i).Vanilla,
                .VanillaPlacement = Randomizer.LocationInformation(i).VanillaPlacement,
                .Region = Randomizer.LocationInformation(i).Region,
                .RequiredPowers = Randomizer.LocationInformation(i).RequiredPowers,
                .PlacedItems = TempItemList
            }
            BatchList.Add(CurrentBatch)
        Next
        BatchList.Sort(Function(x, y) x.VanillaPlacement.CompareTo(y.VanillaPlacement))
        BatchList.Reverse()
        For I As Integer = 1 To TrackBarBatchSize.Value - 1
            Randomizer.BuildLocations(GetRandomNumber(), SelectedDifficulty, CheckBoxOpenElsenova.Checked, CheckBoxOpenEribu.Checked, CheckBoxOpenAbsu.Checked)
            Randomizer.LocationInformation.Sort(Function(x, y) x.VanillaPlacement.CompareTo(y.VanillaPlacement))
            Randomizer.LocationInformation.Reverse()
            For J As Integer = 0 To Randomizer.LocationInformation.Count - 1
                BatchList(J).PlacedItems.Add(Randomizer.LocationInformation(J).Item)
            Next
        Next
        BatchMenu.Show()
    End Sub
#End Region
#Region "Map Options"
    Private Sub ComboBoxDifficulties_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxDifficulties.SelectedIndexChanged
        If RadioButtonDefaultMap.Checked Then
            DefaultMapOptionsFromDifficulty()
        End If
    End Sub
    Private Sub RadioButtonDefaultMap_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonDefaultMap.CheckedChanged
        If RadioButtonDefaultMap.Checked Then
            CheckBoxWalls.Enabled = False
            CheckBoxIllusion.Enabled = False
            CheckBoxDropDown.Enabled = False
            CheckBoxOpenEribu.Enabled = False
            CheckBoxOpenElsenova.Enabled = False
            CheckBoxOpenAbsu.Enabled = False
            DefaultMapOptionsFromDifficulty()
        End If
        'Make this setting enumerated somehow... TO FIX
        My.Settings.MapGeneration = "Default"
        MenuHeight()
    End Sub
    Private Sub RadioButtonCustomMap_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonCustomMap.CheckedChanged
        If RadioButtonCustomMap.Checked Then
            CheckBoxWalls.Enabled = True
            CheckBoxIllusion.Enabled = True
            CheckBoxDropDown.Enabled = True
            CheckBoxOpenEribu.Enabled = True
            CheckBoxOpenElsenova.Enabled = True
            CheckBoxOpenAbsu.Enabled = True
        End If
        My.Settings.MapGeneration = "Custom"
        MenuHeight()
    End Sub
    Private Sub RadioButtonVanillaMap_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonVanillaMap.CheckedChanged
        If RadioButtonVanillaMap.Checked Then
            CheckBoxWalls.Enabled = False
            CheckBoxIllusion.Enabled = False
            CheckBoxDropDown.Enabled = False
            CheckBoxOpenEribu.Enabled = False
            CheckBoxOpenElsenova.Enabled = False
            CheckBoxOpenAbsu.Enabled = False
            'Unchecks
            CheckBoxWalls.Checked = False
            CheckBoxIllusion.Checked = False
            CheckBoxDropDown.Checked = False
            CheckBoxOpenEribu.Checked = False
            CheckBoxOpenElsenova.Checked = False
            CheckBoxOpenAbsu.Checked = False
        End If
        My.Settings.MapGeneration = "Vanilla"
        MenuHeight()
    End Sub
    Sub DefaultMapOptionsFromDifficulty()
        If ComboBoxDifficulties.Items.Count > 0 Then
            Dim SelectedDifficulty As Randomizer.DifficultySetting =
DirectCast([Enum].Parse(GetType(Randomizer.DifficultySetting),
                        ComboBoxDifficulties.SelectedItem.ToString),
                        Randomizer.DifficultySetting)
            If SelectedDifficulty = Randomizer.DifficultySetting.Easy Then
                CheckBoxWalls.Checked = True
                CheckBoxIllusion.Checked = True
                CheckBoxDropDown.Checked = True
                CheckBoxOpenEribu.Checked = False
                CheckBoxOpenElsenova.Checked = False
                CheckBoxOpenAbsu.Checked = False
            ElseIf SelectedDifficulty = Randomizer.DifficultySetting.Normal Then
                CheckBoxWalls.Checked = True
                CheckBoxIllusion.Checked = True
                CheckBoxDropDown.Checked = True
                CheckBoxOpenEribu.Checked = True
                CheckBoxOpenElsenova.Checked = True
                CheckBoxOpenAbsu.Checked = True
            ElseIf SelectedDifficulty = Randomizer.DifficultySetting.Practice Then
                CheckBoxWalls.Checked = True
                CheckBoxIllusion.Checked = True
                CheckBoxDropDown.Checked = True
                CheckBoxOpenEribu.Checked = False
                CheckBoxOpenElsenova.Checked = False
                CheckBoxOpenAbsu.Checked = False
            ElseIf SelectedDifficulty = Randomizer.DifficultySetting.Rebuild Then
                CheckBoxWalls.Checked = False
                CheckBoxIllusion.Checked = False
                CheckBoxDropDown.Checked = False
                CheckBoxOpenEribu.Checked = False
                CheckBoxOpenElsenova.Checked = False
                CheckBoxOpenAbsu.Checked = False
            End If
        End If
    End Sub
#End Region
#Region "Toolstrip"
    Private Sub OpenRandomizedGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenRandomizedGameToolStripMenuItem.Click
        'messageBox.Show("""" & My.Settings.RandoExePath & """")
        If File.Exists(My.Settings.RandoExePath) Then
            'For some reason this always opens the Randomized exe

            'Process.Start("""" & My.Settings.RandoExePath & """")
            'Me.Close()

            Process.Start("""" & Path.GetDirectoryName(My.Settings.RandoExePath) & """")
            Me.Close()
        Else
            MessageBox.Show("File Not Found")
        End If
    End Sub
    Private Sub OpenBaseGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenBaseGameToolStripMenuItem.Click
        If File.Exists(My.Settings.ExeFilePath) Then
            Process.Start("""" & My.Settings.ExeFilePath & """")
            Me.Close()
        Else
            MessageBox.Show("File Not Found")
        End If
    End Sub
    Private Sub OptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OptionsToolStripMenuItem.Click
        Me.Hide()
        OptionsMenu.Show()
    End Sub
    Private Sub SelectExeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectExeToolStripMenuItem.Click
        Me.Hide()
        FileSelect.Show()
    End Sub
    Private Sub ThankTheDevsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThankTheDevsToolStripMenuItem.Click
        CreditsForm.Show()
    End Sub
    Private Sub ReportAnIssueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportAnIssueToolStripMenuItem.Click
        Process.Start("https://github.com/pozzum/AxiomRandomizer/issues")
    End Sub
#End Region
End Class