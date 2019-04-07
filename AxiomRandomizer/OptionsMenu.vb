Imports System.IO    'Files
Public Class OptionsMenu
    Private Sub OptionsMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & " Ver: " & My.Application.Info.Version.ToString
        LoadBasicOptionsTab()
        LoadFolderOptionsTab()
        LoadDebugOptionsTab()
        CurrentXMLCount = -1
        XMLTrimPending = False
    End Sub
    Private Sub OptionsMenu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If ButtonRandoExeChangeName.Text = "Save" Then
            If MessageBox.Show("Exiting now will not save the Random Exe name Continue?", "Save Pending", MessageBoxButtons.OKCancel) = DialogResult.Cancel Then
                e.Cancel = True
                Exit Sub
            End If
        End If
        If XMLTrimPending Then
            XMLTools.LimitXMLCount(My.Settings.XMLSaveLocation, My.Settings.XMLLimitCount)
        End If
        If Application.OpenForms().OfType(Of RandomMenu).Any Then
            RandomMenu.Show()
        End If
    End Sub
#Region "Basic Options"
    Dim XMLTrimPending As Boolean = False
    Dim CurrentXMLCount As Integer = -1
    Sub LoadBasicOptionsTab()
        RadioButtonSaveMenuSettings.Checked = My.Settings.SaveMenuSettings
        CheckBoxNewSeedGenerator.Checked = My.Settings.RandomSeedOnLaunch
        CheckBoxXMLLimit.Checked = My.Settings.XMLLimited
        CheckBoxDebug.Checked = My.Settings.DebugMode
        TrackBarXML.Value = My.Settings.XMLLimitCount
        LabelXML.Text = TrackBarXML.Value.ToString
        LabelXML.Enabled = CheckBoxXMLLimit.Checked
        CheckBoxSeperateCoat.Checked = My.Settings.SeperateLabCoats
        CheckBoxRandomizeFakeCoat.Checked = My.Settings.RandomizeFakeCoat
    End Sub
    Private Sub RadioButtonSaveMenuSettings_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonSaveMenuSettings.CheckedChanged
        My.Settings.SaveMenuSettings = RadioButtonSaveMenuSettings.Checked
    End Sub
    Private Sub CheckBoxNewSeedGenerator_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxNewSeedGenerator.CheckedChanged
        My.Settings.RandomSeedOnLaunch = CheckBoxNewSeedGenerator.Checked
    End Sub
    Private Sub CheckBoxXMLLimit_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxXMLLimit.CheckedChanged
        My.Settings.XMLLimited = CheckBoxXMLLimit.Checked
        If CheckBoxXMLLimit.Checked Then
            TrackBarXML.Enabled = True
            LabelXML.Enabled = True
            If CurrentXMLCount = -1 Then
                CurrentXMLCount = XMLTools.GetXMLCount(My.Settings.XMLSaveLocation)
            End If
            If CurrentXMLCount > TrackBarXML.Value Then
                If MessageBox.Show("Your XML folder currently has " & CurrentXMLCount & " XML files." & vbNewLine & "Would you like to set the limit to this value?",
                                 "Change XML Limit?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    TrackBarXML.Value = CurrentXMLCount
                Else
                    XMLTrimPending = True
                End If
            End If
        Else
            TrackBarXML.Enabled = False
            LabelXML.Enabled = False
        End If
    End Sub
    Private Sub TrackBarXML_ValueChanged(sender As Object, e As EventArgs) Handles TrackBarXML.ValueChanged
        LabelXML.Text = TrackBarXML.Value.ToString
        My.Settings.XMLLimitCount = TrackBarXML.Value
        If CurrentXMLCount = -1 Then
            CurrentXMLCount = XMLTools.GetXMLCount(My.Settings.XMLSaveLocation)
        End If
        If CurrentXMLCount > TrackBarXML.Value Then
            XMLTrimPending = True
        End If
    End Sub
    Private Sub CheckBoxDebug_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxDebug.CheckedChanged
        My.Settings.DebugMode = CheckBoxDebug.Checked
        RandomMenu.MenuHeight()
        LoadDebugOptionsTab()
    End Sub
    Private Sub CheckBoxSeperateCoat_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxSeperateCoat.CheckedChanged
        If CheckBoxSeperateCoat.Checked Then
            If Not My.Settings.SeperateLabCoats Then
                If My.Settings.xnbcliSavedPath = "" Then
                    Dim Result = MessageBox.Show("This option requires the xnbcli program" & vbNewLine &
                                "Do you need to download this program?", "xnbcli.exe check", MessageBoxButtons.YesNoCancel)
                    If Result = DialogResult.Cancel Then
                        CheckBoxSeperateCoat.Checked = False
                        Exit Sub
                    ElseIf Result = DialogResult.Yes Then
                        'https://github.com/LeonBlade/xnbcli/releases
                        '1.0.4 Latest release at time of writing
                        Process.Start("https://github.com/LeonBlade/xnbcli/releases")
                    End If
                    Dim TempDialog As New OpenFileDialog() With {.FileName = "xnbcli.exe"}
                    If TempDialog.ShowDialog = DialogResult.OK Then
                        If File.Exists(TempDialog.FileName) Then
                            My.Settings.xnbcliSavedPath = TempDialog.FileName
                            LoadFolderOptionsTab()
                            If Not PackUnpack.Graphics.CreateWhiteCoat() Then
                                'Message should be spwaned by Previous Function
                                CheckBoxSeperateCoat.Checked = False
                                Exit Sub
                            End If
                        Else
                            CheckBoxSeperateCoat.Checked = False
                            Exit Sub
                        End If
                    Else
                        CheckBoxSeperateCoat.Checked = False
                        Exit Sub
                    End If
                Else
                    If Not PackUnpack.Graphics.CreateWhiteCoat() Then
                        'Message should be spwaned by Previous Function
                        CheckBoxSeperateCoat.Checked = False
                        Exit Sub
                    End If
                End If
            End If
        Else
            If My.Settings.SeperateLabCoats Then
                'delete White coat /possibly randoed fake coat and return IL file
                PackUnpack.Graphics.RemoveWhiteCoat()
                PackUnpack.ModifyCodeLabCoat(My.Settings.VanillaDecompileLocation & Path.GetFileNameWithoutExtension(My.Settings.RandoExePath) & ".iL", False)
            End If
            CheckBoxRandomizeFakeCoat.Checked = False
        End If
        My.Settings.SeperateLabCoats = CheckBoxSeperateCoat.Checked
        CheckBoxRandomizeFakeCoat.Enabled = CheckBoxSeperateCoat.Checked
    End Sub

    Private Sub CheckBoxRandomizeFakeCoat_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxRandomizeFakeCoat.CheckedChanged
        My.Settings.RandomizeFakeCoat = CheckBoxRandomizeFakeCoat.Checked
    End Sub
    Private Sub ButtonResetSettings_Click(sender As Object, e As EventArgs) Handles ButtonResetSettings.Click
        My.Settings.Reset()
        My.Settings.Save()
        Me.Close()
    End Sub
    Private Sub ButtonClearDecompileFolders_Click(sender As Object, e As EventArgs) Handles ButtonClearDecompileFolders.Click
        GeneralTools.DeleteAllItems(My.Settings.VanillaDecompileLocation)
        GeneralTools.DeleteAllItems(My.Settings.WorkingDecompileLocation)
    End Sub
#End Region
#Region "Folder Options"
    Sub LoadFolderOptionsTab()
        TextBoxVanillaDecompile.Text = My.Settings.VanillaDecompileLocation
        TextBoxWorkingDecompile.Text = My.Settings.WorkingDecompileLocation
        TextBoxGameLocation.Text = My.Settings.ExeFilePath
        TextBoxRandomExeLocation.Text = Path.GetFileName(My.Settings.RandoExePath)
        TextBoxSaveFileLocation.Text = My.Settings.SaveFilePath
        TextBoxXMLSaveLocation.Text = My.Settings.XMLSaveLocation
        TextBoxIldasmLocation.Text = My.Settings.IldasmSavedPath
        TextBoxIlasmLocation.Text = My.Settings.IlasmSavedPath
        TextBoxXnbcliLocation.Text = My.Settings.xnbcliSavedPath
        If My.Settings.xnbcliSavedPath = "" Then
            Labelxnbcli.Visible = False
            TextBoxXnbcliLocation.Visible = False
            ButtonXnbcliLocation.Visible = False
        Else
            Labelxnbcli.Visible = True
            TextBoxXnbcliLocation.Visible = True
            ButtonXnbcliLocation.Visible = True
        End If
    End Sub
    Private Sub ButtonVanillaFolder_Click(sender As Object, e As EventArgs) Handles ButtonVanillaFolder.Click
        SaveFileDialog1.InitialDirectory = Path.GetDirectoryName(My.Settings.VanillaDecompileLocation)
        SaveFileDialog1.FileName = "Save Vanilla Files here..."
        SaveFileDialog1.Filter = "Vanilla Decompile Folder|*.*"
        If SaveFileDialog1.ShowDialog = DialogResult.OK Then
            If MessageBox.Show("Decompiled files will be moved.", "moving folder.", MessageBoxButtons.OKCancel) = DialogResult.OK Then
                GeneralTools.MoveAllItems(My.Settings.VanillaDecompileLocation, Path.GetDirectoryName(SaveFileDialog1.FileName))
                My.Settings.VanillaDecompileLocation = Path.GetDirectoryName(SaveFileDialog1.FileName) & Path.DirectorySeparatorChar
            End If
        End If
        LoadFolderOptionsTab()
    End Sub
    Private Sub ButtonWorkingFolder_Click(sender As Object, e As EventArgs) Handles ButtonWorkingFolder.Click
        SaveFileDialog1.InitialDirectory = Path.GetDirectoryName(My.Settings.WorkingDecompileLocation)
        SaveFileDialog1.FileName = "Save Working Files here..."
        SaveFileDialog1.Filter = "Working Decompile Folder|*.*"
        If SaveFileDialog1.ShowDialog = DialogResult.OK Then
            If MessageBox.Show("Decompiled files will be moved.", "moving folder.", MessageBoxButtons.OKCancel) = DialogResult.OK Then
                GeneralTools.MoveAllItems(My.Settings.WorkingDecompileLocation, Path.GetDirectoryName(SaveFileDialog1.FileName))
                My.Settings.WorkingDecompileLocation = Path.GetDirectoryName(SaveFileDialog1.FileName) & Path.DirectorySeparatorChar
            End If
        End If
        LoadFolderOptionsTab()
    End Sub
    Private Sub ButtonExeLocation_Click(sender As Object, e As EventArgs) Handles ButtonExeLocation.Click
        FileSelect.GetExeFile()
        LoadFolderOptionsTab()
    End Sub
    Private Sub ButtonRandoExeChangeName_Click(sender As Object, e As EventArgs) Handles ButtonRandoExeChangeName.Click
        If ButtonRandoExeChangeName.Text = "Change" Then
            ButtonRandoExeChangeName.Text = "Save"
            TextBoxRandomExeLocation.Enabled = True
        ElseIf ButtonRandoExeChangeName.Text = "Save" Then
            Dim TempRando As String
            If TextBoxRandomExeLocation.Text.EndsWith(".exe") Then
                TempRando = Path.GetDirectoryName(My.Settings.RandoExePath) & Path.DirectorySeparatorChar & TextBoxRandomExeLocation.Text
            Else
                TempRando = Path.GetDirectoryName(My.Settings.RandoExePath) & Path.DirectorySeparatorChar & TextBoxRandomExeLocation.Text & ".exe"
            End If
            If File.Exists(TempRando) Then
                File.Delete(TempRando)
            End If
            If File.Exists(My.Settings.RandoExePath) Then
                File.Move(My.Settings.RandoExePath, TempRando)
            End If
            'now we have to rename the il files
            'Vanilla Folder
            File.Move(My.Settings.VanillaDecompileLocation & Path.GetFileNameWithoutExtension(My.Settings.RandoExePath) & ".iL",
                      My.Settings.VanillaDecompileLocation & Path.GetFileNameWithoutExtension(TempRando) & ".iL")
            'Working Folder
            File.Move(My.Settings.WorkingDecompileLocation & Path.GetFileNameWithoutExtension(My.Settings.RandoExePath) & ".iL",
                      My.Settings.WorkingDecompileLocation & Path.GetFileNameWithoutExtension(TempRando) & ".iL")
            My.Settings.RandoExePath = TempRando
            MessageBox.Show("Future randomized exes will be saved to." & vbNewLine & My.Settings.RandoExePath)
            ButtonRandoExeChangeName.Text = "Change"
            TextBoxRandomExeLocation.Enabled = False
        End If
        LoadFolderOptionsTab()
    End Sub
    Private Sub ButtonRandoExe_Click(sender As Object, e As EventArgs) 'Handles ButtonRandoExe.Click
        SaveFileDialog1.InitialDirectory = Path.GetDirectoryName(My.Settings.RandoExePath)
        SaveFileDialog1.FileName = Path.GetFileName(My.Settings.RandoExePath)
        SaveFileDialog1.Filter = "Randomize.exe|*.exe"
        If SaveFileDialog1.ShowDialog = DialogResult.OK Then
            If File.Exists(Path.GetDirectoryName(SaveFileDialog1.FileName) & Path.DirectorySeparatorChar & "SDL2.dll") Then
                If File.Exists(SaveFileDialog1.FileName) Then
                    File.Delete(SaveFileDialog1.FileName)
                End If
                If File.Exists(My.Settings.RandoExePath) Then
                    File.Move(My.Settings.RandoExePath, SaveFileDialog1.FileName)
                End If
                My.Settings.RandoExePath = SaveFileDialog1.FileName
                MessageBox.Show("Future randomized exes will be named." & vbNewLine & Path.GetFileName(My.Settings.RandoExePath))
            Else
                MessageBox.Show("Critical files not found, selection canceled")
            End If
        End If
        LoadFolderOptionsTab()
    End Sub
    Private Sub ButtonSaveLocation_Click(sender As Object, e As EventArgs) Handles ButtonSaveLocation.Click
        FileSelect.GetSaveFile()
        LoadFolderOptionsTab()
    End Sub
    Private Sub ButtonXMLLocation_Click(sender As Object, e As EventArgs) Handles ButtonXMLLocation.Click
        SaveFileDialog1.InitialDirectory = My.Settings.XMLSaveLocation
        SaveFileDialog1.FileName = "Spoiler.xml"
        SaveFileDialog1.Filter = "xml Files|*.xml"
        If SaveFileDialog1.ShowDialog = DialogResult.OK Then
            My.Settings.XMLSaveLocation = Path.GetDirectoryName(SaveFileDialog1.FileName) & Path.DirectorySeparatorChar
            MessageBox.Show("Future Spoiler XML files will be stored here" & vbNewLine & My.Settings.XMLSaveLocation)
        End If
        LoadFolderOptionsTab()
        'TO DO Move exist XML files
    End Sub
    Private Sub ButtonIldasmLocation_Click(sender As Object, e As EventArgs) Handles ButtonIldasmLocation.Click
        SaveFileDialog1.InitialDirectory = Path.GetDirectoryName(My.Settings.IldasmSavedPath)
        SaveFileDialog1.FileName = Path.GetFileName(My.Settings.IldasmSavedPath)
        SaveFileDialog1.Filter = "ildasm.exe|*.*"
        If SaveFileDialog1.ShowDialog = DialogResult.OK Then
            If File.Exists(Path.GetDirectoryName(My.Settings.IldasmSavedPath) & Path.DirectorySeparatorChar & "coreclr.dll") Then
                If MessageBox.Show("This will also move the file ""coreclr.dll""" & vbNewLine & "Continue?", "DLL Required", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    'Exe First
                    If File.Exists(SaveFileDialog1.FileName) Then
                        File.Delete(SaveFileDialog1.FileName)
                    End If
                    File.Move(My.Settings.IldasmSavedPath, SaveFileDialog1.FileName)
                    'Then the DLL
                    Dim NewPath As String = Path.GetDirectoryName(SaveFileDialog1.FileName) & Path.DirectorySeparatorChar & "coreclr.dll"
                    If File.Exists(NewPath) Then
                        File.Delete(NewPath)
                    End If
                    File.Move(Path.GetDirectoryName(My.Settings.IldasmSavedPath) & Path.DirectorySeparatorChar & "coreclr.dll",
                          NewPath)
                    My.Settings.IldasmSavedPath = SaveFileDialog1.FileName
                End If
            Else
                MessageBox.Show("""coreclr.dll"" not found in existing Ildasm directory, a manual; download from github will be required")
                If File.Exists(SaveFileDialog1.FileName) Then
                    File.Delete(SaveFileDialog1.FileName)
                End If
                File.Move(My.Settings.IldasmSavedPath, SaveFileDialog1.FileName)
                My.Settings.IldasmSavedPath = SaveFileDialog1.FileName
            End If
            If MessageBox.Show("Would you like to move the ""ilasm.exe"" to this location as well?", "Move Other exe?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                'ilasm Exe First
                Dim NewPath As String = Path.GetDirectoryName(SaveFileDialog1.FileName) & Path.DirectorySeparatorChar & Path.GetFileName(My.Settings.IlasmSavedPath)
                If File.Exists(NewPath) Then
                    File.Delete(NewPath)
                End If
                File.Move(My.Settings.IlasmSavedPath, NewPath)
                My.Settings.IlasmSavedPath = NewPath
                'ilasm DLL now
                If File.Exists(Path.GetDirectoryName(My.Settings.IlasmSavedPath) & Path.DirectorySeparatorChar & "ildasmrc.dll") Then
                    NewPath = Path.GetDirectoryName(SaveFileDialog1.FileName) & Path.DirectorySeparatorChar & "ildasmrc.dll"
                    If File.Exists(NewPath) Then
                        File.Delete(NewPath)
                    End If
                    File.Move(Path.GetDirectoryName(My.Settings.IlasmSavedPath) & Path.DirectorySeparatorChar & "ildasmrc.dll", NewPath)
                Else
                    MessageBox.Show("""ildasmrc.dll"" not found in existing Ilasm directory, a manual; download from github will be required")
                End If
            End If
        End If
            LoadFolderOptionsTab()
    End Sub
    Private Sub ButtonIlasmLocation_Click(sender As Object, e As EventArgs) Handles ButtonIlasmLocation.Click
        SaveFileDialog1.InitialDirectory = Path.GetDirectoryName(My.Settings.IlasmSavedPath)
        SaveFileDialog1.FileName = Path.GetFileName(My.Settings.IlasmSavedPath)
        SaveFileDialog1.Filter = "ilasm.exe|*.*"
        If SaveFileDialog1.ShowDialog = DialogResult.OK Then
            If File.Exists(Path.GetDirectoryName(My.Settings.IlasmSavedPath) & Path.DirectorySeparatorChar & "ildasmrc.dll") Then
                If MessageBox.Show("This will also move the file ""ildasmrc.dll""" & vbNewLine & "Continue?", "DLL Required", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    'Exe First
                    If File.Exists(SaveFileDialog1.FileName) Then
                        File.Delete(SaveFileDialog1.FileName)
                    End If
                    File.Move(My.Settings.IlasmSavedPath, SaveFileDialog1.FileName)
                    'Then the DLL
                    If File.Exists(Path.GetDirectoryName(SaveFileDialog1.FileName) & Path.DirectorySeparatorChar & "ildasmrc.dll") Then
                        File.Delete(Path.GetDirectoryName(SaveFileDialog1.FileName) & Path.DirectorySeparatorChar & "ildasmrc.dll")
                    End If
                    File.Move(Path.GetDirectoryName(My.Settings.IlasmSavedPath) & Path.DirectorySeparatorChar & "ildasmrc.dll",
                          Path.GetDirectoryName(SaveFileDialog1.FileName) & Path.DirectorySeparatorChar & "ildasmrc.dll")
                    My.Settings.IlasmSavedPath = SaveFileDialog1.FileName
                End If
            Else
                MessageBox.Show("""ildasmrc.dll"" not found in existing Ilasm directory, a manual; download from github will be required")
                If File.Exists(SaveFileDialog1.FileName) Then
                    File.Delete(SaveFileDialog1.FileName)
                End If
                File.Move(My.Settings.IlasmSavedPath, SaveFileDialog1.FileName)
                My.Settings.IlasmSavedPath = SaveFileDialog1.FileName
            End If
        End If
        If MessageBox.Show("Would you like to move the ""ildasm.exe"" to this location as well?", "Move Other exe?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            'ildasm Exe First
            Dim NewPath As String = Path.GetDirectoryName(SaveFileDialog1.FileName) & Path.DirectorySeparatorChar & Path.GetFileName(My.Settings.IldasmSavedPath)
            If File.Exists(NewPath) Then
                File.Delete(NewPath)
            End If
            File.Move(My.Settings.IldasmSavedPath, NewPath)
            My.Settings.IldasmSavedPath = NewPath
            'coreclr DLL now
            If File.Exists(Path.GetDirectoryName(My.Settings.IldasmSavedPath) & Path.DirectorySeparatorChar & "coreclr.dll") Then
                NewPath = Path.GetDirectoryName(SaveFileDialog1.FileName) & Path.DirectorySeparatorChar & "coreclr.dll"
                If File.Exists(NewPath) Then
                    File.Delete(NewPath)
                End If
                File.Move(Path.GetDirectoryName(My.Settings.IldasmSavedPath) & Path.DirectorySeparatorChar & "coreclr.dll", NewPath)
            Else
                MessageBox.Show("""coreclr.dll"" not found in existing Ildasm directory, a manual; download from github will be required")
            End If
        End If
        LoadFolderOptionsTab()
    End Sub
    Private Sub ButtonXnbcliLocation_Click(sender As Object, e As EventArgs) Handles ButtonXnbcliLocation.Click
        Dim TempOpenFileDialog As OpenFileDialog = New OpenFileDialog With {
            .InitialDirectory = Path.GetDirectoryName(My.Settings.xnbcliSavedPath),
            .FileName = Path.GetFileName(My.Settings.xnbcliSavedPath),
            .Filter = "xnbcli.exe|*.exe"
        }
        If TempOpenFileDialog.ShowDialog = DialogResult.OK Then
            'Exe First
            If File.Exists(TempOpenFileDialog.FileName) Then
                My.Settings.xnbcliSavedPath = TempOpenFileDialog.FileName
            End If
        End If
        LoadFolderOptionsTab()
    End Sub
#End Region
#Region "Debug Options"
    Sub LoadDebugOptionsTab()
        If My.Settings.DebugMode Then
            If Not TabControl1.TabPages.Contains(TabPageDebugTab) Then
                TabControl1.TabPages.Add(TabPageDebugTab)
            End If
        Else
            If TabControl1.TabPages.Contains(TabPageDebugTab) Then
                TabControl1.TabPages.Remove(TabPageDebugTab)
            End If
        End If
    End Sub

    Private Sub ButtonAddWhiteCoatIL_Click(sender As Object, e As EventArgs) Handles ButtonAddWhiteCoatIL.Click
        PackUnpack.ModifyCodeLabCoat(My.Settings.VanillaDecompileLocation & Path.GetFileNameWithoutExtension(My.Settings.RandoExePath) & ".iL", True)
    End Sub

    Private Sub ButtonDelWhiteCoatIl_Click(sender As Object, e As EventArgs) Handles ButtonDelWhiteCoatIl.Click
        PackUnpack.ModifyCodeLabCoat(My.Settings.VanillaDecompileLocation & Path.GetFileNameWithoutExtension(My.Settings.RandoExePath) & ".iL", False)
    End Sub
#End Region
End Class