Imports System.IO    'Files
Imports System.Environment 'appdata
Public Class PackUnpack
    'ILAsm and ILDAsm provided by https://github.com/dotnet/coreclr under MIT License
    'https://ci.dot.net/job/dotnet_coreclr/job/master/job/release_windows_nt/lastSuccessfulBuild/artifact/bin/Product/Windows_NT.x64.Release/<- download link
    'Exes versions 2.1.40
    Shared IlFileName As String = "RandomAV.iL" '"AxiomVergeRandomizer.iL"
    Shared VanillFolder As String = "VanillaFiles"
    Shared WorkingFolder As String = "WorkingFiles"
#Region "Unpacking"
    Shared Function UnpacktoAppdata(ExeFilePath)
        Dim UnpackFolder As String = GetFolderPath(SpecialFolder.ApplicationData) & "\AxiomRandomizer\"
        GeneralTools.FolderCheck(UnpackFolder)
        UnpackFolder += VanillFolder & Path.DirectorySeparatorChar
        GeneralTools.FolderCheck(UnpackFolder)
        UnpackFolder += IlFileName
        Dim IldasmPath As String = GetUnpackerPath()
        If IldasmPath = "" Then
            If MessageBox.Show("Ildasm.exe not Found!" & vbNewLine &
                            "Browse to exe location?", "Decompile not possible!", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Dim TempFileDialog As OpenFileDialog = New OpenFileDialog
                TempFileDialog.FileName = "Ildasm.exe"
                TempFileDialog.Filter = "Ildasm.exe|Ildasm.exe"
                If TempFileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                    IldasmPath = TempFileDialog.FileName
                Else
                    Return False
                End If
            Else
                Return False
            End If
        End If
        File.Copy(ExeFilePath, Path.GetDirectoryName(Application.ExecutablePath) &
                               Path.DirectorySeparatorChar &
                               Path.GetFileName(ExeFilePath), True)
        If File.Exists(Path.GetDirectoryName(Application.ExecutablePath) &
                               Path.DirectorySeparatorChar &
                               Path.GetFileName(ExeFilePath)) = False Then
            MessageBox.Show("Error Copying File")
            Return False
        End If
        Process.Start(IldasmPath, Path.GetFileName(ExeFilePath) & " /out=" & UnpackFolder).WaitForExit()
        'Threading.Thread.Sleep(250)
        If File.Exists(UnpackFolder) Then
            'Threading.Thread.Sleep(500)
            If File.Exists(Path.GetDirectoryName(UnpackFolder) &
                       Path.DirectorySeparatorChar &
                       "OuterBeyond.EmbeddedContent.Content.zip") Then
                GeneralTools.UnZip(Path.GetDirectoryName(UnpackFolder) &
                               Path.DirectorySeparatorChar &
                               "OuterBeyond.EmbeddedContent.Content.zip")
                RemoveLeaderboard(UnpackFolder)
                MessageBox.Show("Game Successfully Dumped to app data")
                File.Delete(Path.GetDirectoryName(Application.ExecutablePath) &
                               Path.DirectorySeparatorChar &
                               Path.GetFileName(ExeFilePath))
                Return True
            Else
                MessageBox.Show("Game Successfully Dumped to app data" & vbNewLine &
                                "Content Unzip failed, please manually unzip folder")
                File.Delete(Path.GetDirectoryName(Application.ExecutablePath) &
                               Path.DirectorySeparatorChar &
                               Path.GetFileName(ExeFilePath))
                Process.Start(Path.GetDirectoryName(UnpackFolder))
                Return True
            End If
        Else
            If MessageBox.Show("Game Dump Unsuccessful." & vbNewLine &
                            "Would you like to make a script file?",
                            "Failed Dump", MessageBoxButtons.YesNo) = DialogResult.Yes Then

                Return True
            Else
                File.Delete(Path.GetDirectoryName(Application.ExecutablePath) &
                               Path.DirectorySeparatorChar &
                               Path.GetFileName(ExeFilePath))
                Return False
            End If
        End If
    End Function
    Shared Sub RemoveLeaderboard(IlFile As String)
        Dim lines() As String = IO.File.ReadAllLines(IlFile)
        For i As Integer = 0 To lines.Length - 1
            If lines(i) = "    IL_003d:  brtrue.s   IL_0042" Then
                lines(i) = "    IL_003d:  br   IL_0042"
                Exit For
            End If
            If i = lines.Length - 1 Then
                MessageBox.Show("Error Removing Leaderboard Uploads")
            End If
        Next
        IO.File.WriteAllLines(IlFile, lines)
    End Sub
    Shared Function GetUnpackerPath() As String
        If My.Settings.IldasmSavedPath <> "" Then
            If File.Exists(My.Settings.IldasmSavedPath) Then
                Return My.Settings.IldasmSavedPath
            End If
        End If
        If File.Exists(Path.GetDirectoryName(Application.ExecutablePath) &
                       Path.DirectorySeparatorChar & "ildasm.exe") Then
            My.Settings.IldasmSavedPath = Path.GetDirectoryName(Application.ExecutablePath) &
                       Path.DirectorySeparatorChar & "ildasm.exe"
            Return My.Settings.IldasmSavedPath
        End If
        If File.Exists(Path.GetDirectoryName(Application.ExecutablePath) &
                       Path.DirectorySeparatorChar & "PackUnpack\ildasm.exe") Then
            My.Settings.IldasmSavedPath = Path.GetDirectoryName(Application.ExecutablePath) &
                       Path.DirectorySeparatorChar & "PackUnpack\ildasm.exe"
            Return My.Settings.IldasmSavedPath
        End If
        If File.Exists(GetFolderPath(SpecialFolder.ApplicationData) &
                       Path.DirectorySeparatorChar & "AxiomRandomizer\PackUnpack\ildasm.exe") Then
            My.Settings.IldasmSavedPath = GetFolderPath(SpecialFolder.ApplicationData) &
                       Path.DirectorySeparatorChar & "AxiomRandomizer\PackUnpack\ildasm.exe"
            Return My.Settings.IldasmSavedPath
        End If
        Return ""
    End Function
#End Region
#Region "Rebuilding"
    Shared Function BuildFromAppdata(ExeFilePath)
        Dim WorkingPath As String = GetFolderPath(SpecialFolder.ApplicationData) & "\AxiomRandomizer\" & WorkingFolder & Path.DirectorySeparatorChar
        GeneralTools.Zip(WorkingPath & "OuterBeyond.EmbeddedContent.Content\")
        'MessageBox.Show("Click OK if zipping is complete")
        Dim IlasmPath As String = GetpackerPath()
        If IlasmPath = "" Then
            If MessageBox.Show("ilasm.exe not Found!" & vbNewLine &
                            "Browse to exe location?", "Decompile not possible!", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Dim TempFileDialog As OpenFileDialog = New OpenFileDialog
                TempFileDialog.FileName = "ilasm.exe"
                TempFileDialog.Filter = "ilasm.exe|ilasm.exe"
                If TempFileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                    IlasmPath = TempFileDialog.FileName
                Else
                    Return False
                End If
            Else
                Return False
            End If
        End If
        'MessageBox.Show(IlasmPath)
        'MessageBox.Show(WorkingPath & IlFileName)
        Process.Start(IlasmPath, WorkingPath & IlFileName).WaitForExit()
        My.Settings.RandoExePath = Path.GetDirectoryName(ExeFilePath) & Path.DirectorySeparatorChar & Path.GetFileNameWithoutExtension(IlFileName) & ".exe"
        'MessageBox.Show("Click OK when command dialog closes")
        If File.Exists(WorkingPath & Path.GetFileNameWithoutExtension(IlFileName) & ".exe") Then
            File.Copy(WorkingPath & Path.GetFileNameWithoutExtension(IlFileName) & ".exe",
                        My.Settings.RandoExePath, True)
            Return True
        Else
            Return False
        End If
    End Function
    Shared Function GetpackerPath() As String
        If My.Settings.IlasmSavedPath <> "" Then
            If File.Exists(My.Settings.IlasmSavedPath) Then
                Return My.Settings.IlasmSavedPath
            End If
        End If
        If File.Exists(Path.GetDirectoryName(Application.ExecutablePath) &
                       Path.DirectorySeparatorChar & "ilasm.exe") Then
            My.Settings.IlasmSavedPath = Path.GetDirectoryName(Application.ExecutablePath) &
                       Path.DirectorySeparatorChar & "ilasm.exe"
            Return My.Settings.IlasmSavedPath
        End If
        If File.Exists(Path.GetDirectoryName(Application.ExecutablePath) &
                       Path.DirectorySeparatorChar & "PackUnpack\ilasm.exe") Then
            My.Settings.IlasmSavedPath = Path.GetDirectoryName(Application.ExecutablePath) &
                       Path.DirectorySeparatorChar & "PackUnpack\ilasm.exe"
            Return My.Settings.IlasmSavedPath
        End If
        If File.Exists(GetFolderPath(SpecialFolder.ApplicationData) &
                       Path.DirectorySeparatorChar & "AxiomRandomizer\PackUnpack\ilasm.exe") Then
            My.Settings.IlasmSavedPath = GetFolderPath(SpecialFolder.ApplicationData) &
                       Path.DirectorySeparatorChar & "AxiomRandomizer\PackUnpack\ilasm.exe"
            Return My.Settings.IlasmSavedPath
        End If
        Return ""
    End Function
#End Region
    Shared Sub CopyToWorking()
        Dim UnpackFolder As String = GetFolderPath(SpecialFolder.ApplicationData) & "\AxiomRandomizer\" & VanillFolder & Path.DirectorySeparatorChar
        Dim WorkingPath As String = GetFolderPath(SpecialFolder.ApplicationData) & "\AxiomRandomizer\" & WorkingFolder & Path.DirectorySeparatorChar
        If Directory.Exists(WorkingPath) Then
            GeneralTools.DeleteAllItems(WorkingPath)
        End If
        My.Computer.FileSystem.CopyDirectory(UnpackFolder, WorkingPath, True)
    End Sub
End Class
