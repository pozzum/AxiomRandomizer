Imports System.Text.RegularExpressions 'Text Replace
Imports System.IO    'Files
Public Class RandomMenu
#Region "Form Startup"
    Private Sub RandomMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & " Ver: " & My.Application.Info.Version.ToString
        FileSelect.Close()
        AddDifficulties()
        CheckLastSeed()
        CheckRandoExe()
        TextBoxExeLocation.Text = My.Settings.ExeFilePath
    End Sub
    Shared Sub AddDifficulties()
        RandomMenu.ComboBoxDifficulties.Items.AddRange(System.Enum.GetNames(GetType(Randomizer.DifficultySetting)))
        RandomMenu.ComboBoxDifficulties.SelectedIndex = 0
    End Sub
    Shared Sub SetExePath()
        RandomMenu.TextBoxExeLocation.Text = My.Settings.ExeFilePath
    End Sub
    Sub CheckLastSeed()
        If My.Settings.PreviousSeed = "" Then
            My.Settings.PreviousSeed = GetRandomNumber()
        End If
        TextBoxSeed.Text = My.Settings.PreviousSeed
    End Sub
    Sub CheckRandoExe()
        If My.Settings.RandoExePath = "" Then
            ButtonOpenRando.Enabled = False
        Else
            If File.Exists(My.Settings.RandoExePath) Then
                ButtonOpenRando.Enabled = True
            Else
                ButtonOpenRando.Enabled = False
            End If
        End If
    End Sub
#End Region
#Region "Form Controls"
    Private Sub ButtonRandomSeed_Click(sender As Object, e As EventArgs) Handles ButtonRandomSeed.Click
        TextBoxSeed.Text = GetRandomNumber()
    End Sub
    Function GetRandomNumber() As Long
        Randomize()
        Return CLng((Rnd() * Integer.MaxValue)).ToString
    End Function
    Private Sub ButtonFileSelect_Click(sender As Object, e As EventArgs) Handles ButtonFileSelect.Click
        Me.Hide()
        FileSelect.ShowDialog()
    End Sub
    Private Sub CheckBoxWalls_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxWalls.CheckedChanged
        If CheckBoxWalls.Checked = False Then
            MessageBox.Show("Diabling this may increase the chance of soft-locking in Ukkin-Na")
        End If
    End Sub
    Private Sub CheckBoxDropDown_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxDropDown.CheckedChanged
        If CheckBoxDropDown.Checked = False Then
            MessageBox.Show("Diabling this may increase the chance of soft-locking in Zi")
        End If
    End Sub
    Private Sub ButtonBuild_Click(sender As Object, e As EventArgs) Handles ButtonBuild.Click
        PackUnpack.CopyToWorking()
        If TileMapEditor.CheckTileMaps() Then
            My.Settings.PreviousSeed = TextBoxSeed.Text
            Dim SelectedDifficulty As Randomizer.DifficultySetting =
        DirectCast([Enum].Parse(GetType(Randomizer.DifficultySetting),
                                ComboBoxDifficulties.SelectedItem.ToString),
                                Randomizer.DifficultySetting)
            Randomizer.BuildLocations(CLng(TextBoxSeed.Text), SelectedDifficulty)
            TileMapEditor.WriteItems()
            TileMapEditor.OneWayDropDown(CheckBoxDropDown.Checked)
            TileMapEditor.OneWayWalls(CheckBoxWalls.Checked)
            TileMapEditor.RemoveIllusion(CheckBoxIllusion.Checked)
            PackUnpack.BuildFromAppdata(My.Settings.ExeFilePath)
            Randomizer.ExportLocations(My.Settings.ExeFilePath)
            CheckRandoExe()
        Else
            MessageBox.Show("Error With Tile Map")
        End If
    End Sub
    Private Sub ButtonSpoiler_Click(sender As Object, e As EventArgs) Handles ButtonSpoiler.Click
        My.Settings.PreviousSeed = TextBoxSeed.Text
        Dim SelectedDifficulty As Randomizer.DifficultySetting =
            DirectCast([Enum].Parse(GetType(Randomizer.DifficultySetting),
                                    ComboBoxDifficulties.SelectedItem.ToString),
                                    Randomizer.DifficultySetting)
        Randomizer.BuildLocations(CLng(TextBoxSeed.Text), SelectedDifficulty)
        SpoilerForm.Show()
    End Sub

    Private Sub TextBoxSeed_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSeed.TextChanged
        Dim SentTextBox As TextBox = CType(sender, TextBox)
        Dim CursorPosition As Integer = SentTextBox.SelectionStart
        SentTextBox.Text = Regex.Replace(SentTextBox.Text, "[^0-9]", "")
        If SentTextBox.Text > Integer.MaxValue Then
            SentTextBox.Text = SentTextBox.Text.Substring(0, SentTextBox.Text.Length - 1)
        End If
        SentTextBox.SelectionStart = CursorPosition
    End Sub

    Private Sub ButtonOpenBaseGame_Click(sender As Object, e As EventArgs) Handles ButtonOpenBaseGame.Click
        If File.Exists(My.Settings.ExeFilePath) Then
            Process.Start(My.Settings.ExeFilePath)
            Me.Close()
        Else
            MessageBox.Show("File Not Found")
        End If
    End Sub

    Private Sub ButtonOpenRando_Click(sender As Object, e As EventArgs) Handles ButtonOpenRando.Click
        'MessageBox.Show(My.Settings.RandoExePath)
        If File.Exists(My.Settings.RandoExePath) Then
            'Dim TempProcess As ProcessStartInfo = New ProcessStartInfo With {
            '.FileName = "CMD",
            '.Arguments = "/K ""H:\Steam\steamapps\common\Axiom Verge\RandomAV.bat"""}
            Process.Start(Path.GetDirectoryName(My.Settings.RandoExePath))
            'Dim StartInfo As ProcessStartInfo = New ProcessStartInfo()
            'StartInfo.FileName = My.Settings.RandoExePath
            ' TempProcess.StartInfo = StartInfo
            'TempProcess.Start()
            Me.Close()
        Else
            MessageBox.Show("File Not Found")
        End If
    End Sub

    Private Sub LabelDonate_Click(sender As Object, e As EventArgs) Handles LabelDonate.DoubleClick
        Process.Start("http://paypal.me/pozzum")
    End Sub
#End Region
End Class