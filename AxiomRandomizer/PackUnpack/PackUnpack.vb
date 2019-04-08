Imports System.IO    'Files
Imports System.Environment 'appdata
Public Class PackUnpack
    'ILAsm and ILDAsm provided by https://github.com/dotnet/coreclr under MIT License
    'https://ci.dot.net/job/dotnet_coreclr/job/master/job/release_windows_nt/lastSuccessfulBuild/artifact/bin/Product/Windows_NT.x64.Release/ <- download link
    'Exes versions 2.1.40
#Region "Unpacking"
    Shared Function UnpacktoAppdata(ExeFilePath As String,
                                 Optional SaveChange As Boolean = True,
                                 Optional LabCoatChange As Boolean = True,
                                 Optional TileWakeChange As Boolean = True,
                                 Optional BackgroundChange As Boolean = True,
                                 Optional AxiomDisruptChange As Boolean = True,
                                 Optional AxiomTranceChange As Boolean = True)
        Dim UnpackFolder As String
        If My.Settings.VanillaDecompileLocation = "" Then
            UnpackFolder = GetFolderPath(SpecialFolder.ApplicationData) & "\AxiomRandomizer\"
            GeneralTools.FolderCheck(UnpackFolder)
            UnpackFolder += "VanillaFiles" & Path.DirectorySeparatorChar
            My.Settings.VanillaDecompileLocation = UnpackFolder
        Else
            UnpackFolder = My.Settings.VanillaDecompileLocation
        End If
        'to initalize settings
        If My.Settings.WorkingDecompileLocation = "" Then
            My.Settings.WorkingDecompileLocation = GetFolderPath(SpecialFolder.ApplicationData) & "\AxiomRandomizer\" & "WorkingFiles" & Path.DirectorySeparatorChar
        End If
        GeneralTools.FolderCheck(UnpackFolder)
        UnpackFolder += Path.GetFileNameWithoutExtension(My.Settings.RandoExePath) & ".iL"
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
        Process.Start(IldasmPath, Path.GetFileName(ExeFilePath) & " /out=""" & UnpackFolder & """").WaitForExit()
        If File.Exists(UnpackFolder) Then
            If File.Exists(Path.GetDirectoryName(UnpackFolder) &
                       Path.DirectorySeparatorChar &
                       "OuterBeyond.EmbeddedContent.Content.zip") Then
                GeneralTools.UnZip(Path.GetDirectoryName(UnpackFolder) &
                               Path.DirectorySeparatorChar &
                               "OuterBeyond.EmbeddedContent.Content.zip")
                ModifyCode(UnpackFolder, SaveChange, LabCoatChange, TileWakeChange, BackgroundChange, AxiomDisruptChange, AxiomTranceChange)
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
                Process.Start("""" & Path.GetDirectoryName(UnpackFolder) & """")
                Return True
            End If
        Else
            If MessageBox.Show("Game Dump Unsuccessful." & vbNewLine &
                            "Would you like to make a batch file?",
                            "Failed Dump", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Return DecompileBatch(ExeFilePath, IldasmPath, UnpackFolder)
            Else
                File.Delete(Path.GetDirectoryName(Application.ExecutablePath) &
                               Path.DirectorySeparatorChar &
                               Path.GetFileName(ExeFilePath))
                Return False
            End If
        End If
    End Function
    Shared Sub ModifyCode(IlFile As String,
                                 Optional SaveChange As Boolean = True,
                                 Optional LabCoatChange As Boolean = True,
                                 Optional TileWakeChange As Boolean = True,
                                 Optional BackgroundChange As Boolean = True,
                                 Optional AxiomDisruptChange As Boolean = True,
                                 Optional AxiomTranceChange As Boolean = True)
        Dim lines() As String = IO.File.ReadAllLines(IlFile)
        If My.Settings.SteamVersion Then
            For i As Integer = 0 To lines.Length - 1
                Dim LeaderboardRemoved As Boolean = False
                'This removes Leaderboard Uploads
                If lines(i) = "    IL_003d:  brtrue.s   IL_0042" Then
                    lines(i) = "    IL_003d:  br   IL_0042"
                    LeaderboardRemoved = True
                    '
                    'changes save files from .sav to .save
                ElseIf lines(i).Contains(""".sav""") Then
                    If SaveChange Then
                        lines(i) = lines(i).Replace(""".sav""", """.save""")
                    End If
                    '
                    'Changes Initial Sprite to Labcoat
                ElseIf lines(i) = "    IL_00bc:  ldstr      ""Trace""" Then
                    If LabCoatChange Then
                        lines(i) = "    IL_00bc:  ldstr      ""TraceCoat"""
                    End If
                ElseIf lines(i) = "    IL_00d7:  ldstr      ""TraceUnarmed""" Then
                    If LabCoatChange Then
                        lines(i) = "    IL_00d7:  ldstr      ""TraceCoat"""
                    End If
                ElseIf lines(i) = "    IL_01a9:  ldstr      ""TraceUnarmedLeotard""" Then
                    If LabCoatChange Then
                        lines(i) = "    IL_01a9:  ldstr      ""TraceLeotard"""
                    End If
                    '
                    'Waking Up Tiles by default
                ElseIf lines(i) = "    IL_033b:  ldstr      ""DataDisruptor""" Then
                    If TileWakeChange Then
                        lines(i) = "    IL_033b:  ldstr      ""DummDisruptor"""
                    End If
                ElseIf lines(i) = "    IL_0345:  brfalse.s  IL_035f" Then
                    If TileWakeChange Then
                        lines(i) = "    IL_0345:  brtrue.s  IL_035f"
                    End If
                    '
                    'Waking Up Background by default
                ElseIf lines(i) = "    IL_00dd:  ldstr      ""DataDisruptor""" Then
                    If BackgroundChange Then
                        lines(i) = "    IL_00dd:  ldstr      ""DummDisruptor"""
                    End If
                ElseIf lines(i) = "    IL_00e7:  brfalse.s  IL_012e" Then
                    If BackgroundChange Then
                        lines(i) = "    IL_00e7:  brtrue.s  IL_012e"
                    End If
                    '
                    'Waking Up Glitches by default - To Be Found
                    '
                    'Remove World Wakeup from Picking up axiom disruptor
                ElseIf lines(i) = "    IL_0015:  ldstr      ""DataDisruptor""" Then
                    If AxiomDisruptChange Then
                        lines(i) = "    IL_0015:  ldstr      ""DummDisruptor"""
                    End If
                    '
                    'Remove Temp Trace Sprite when picking up the Axiom Disruptor.
                ElseIf lines(i) = "    IL_01c6:  ldstr      ""DataDisruptor""" Then
                    If AxiomTranceChange Then
                        lines(i) = "    IL_01c6:  ldstr      ""DummDisruptor"""
                    End If
                End If
                If i = lines.Length - 1 Then
                    If Not LeaderboardRemoved Then
                        MessageBox.Show("Error Removing Leaderboard Uploads")
                    End If
                End If
            Next
        Else 'Epic Version
            For i As Integer = 0 To lines.Length - 1
                Dim LeaderboardRemoved As Boolean = False
                '
                'changes save files from .sav to .save
                If lines(i).Contains(""".sav""") Then
                    If SaveChange Then
                        lines(i) = lines(i).Replace(""".sav""", """.save""")
                    End If
                    '
                    'Changes Initial Sprite to Labcoat
                ElseIf lines(i) = "    IL_00bc:  ldstr      ""Trace""" Then
                    If LabCoatChange Then
                        lines(i) = "    IL_00bc:  ldstr      ""TraceCoat"""
                    End If
                ElseIf lines(i) = "    IL_00d7:  ldstr      ""TraceUnarmed""" Then
                    If LabCoatChange Then
                        lines(i) = "    IL_00d7:  ldstr      ""TraceCoat"""
                    End If
                ElseIf lines(i) = "    IL_01a9:  ldstr      ""TraceUnarmedLeotard""" Then
                    If LabCoatChange Then
                        lines(i) = "    IL_01a9:  ldstr      ""TraceLeotard"""
                    End If
                    '
                    'Waking Up Tiles by default
                ElseIf lines(i) = "    IL_0337:  ldstr      ""DataDisruptor""" Then
                    If TileWakeChange Then
                        lines(i) = "    IL_0337:  ldstr      ""DummDisruptor"""
                    End If
                ElseIf lines(i) = "    IL_0341:  brfalse.s  IL_035b" Then
                    If TileWakeChange Then
                        lines(i) = "    IL_0341:  brtrue.s  IL_035b"
                    End If
                    '
                    'Waking Up Background by default
                ElseIf lines(i) = "    IL_00dd:  ldstr      ""DataDisruptor""" Then
                    If BackgroundChange Then
                        lines(i) = "    IL_00dd:  ldstr      ""DummDisruptor"""
                    End If
                ElseIf lines(i) = "    IL_00e7:  brfalse.s  IL_012e" Then
                    If BackgroundChange Then
                        lines(i) = "    IL_00e7:  brtrue.s  IL_012e"
                    End If
                    '
                    'Waking Up Glitches by default - To Be Found

                    'Remove World Wakeup from Picking up axiom disruptor
                ElseIf lines(i) = "    IL_0015:  ldstr      ""DataDisruptor""" Then
                    If AxiomDisruptChange Then
                        lines(i) = "    IL_0015:  ldstr      ""DummDisruptor"""
                    End If
                    '
                    'Remove Temp Trace Sprite when picking up the Axiom Disruptor.
                ElseIf lines(i) = "    IL_01c7:  ldstr      ""DataDisruptor""" Then
                    If AxiomTranceChange Then
                        lines(i) = "    IL_01c7:  ldstr      ""DummDisruptor"""
                    End If
                End If
            Next
        End If
        IO.File.WriteAllLines(IlFile, lines)
    End Sub
    Shared Function ModifyCodeLabCoat(IlFile As String, AddWhiteCoat As Boolean)
        Dim lines() As String = IO.File.ReadAllLines(IlFile)
        For i As Integer = 0 To lines.Length - 1
            'Makes "Glitch Tele" give white coat rather than default coat
            If AddWhiteCoat Then
                If lines(i) = "    IL_0094:  ldnull" Then
                    If lines(i - 1).Contains("TraceCoat") Then
                        lines(i) = "    IL_0094:  ldstr      ""White"""
                        IO.File.WriteAllLines(IlFile, lines)
                        Return True
                    End If
                ElseIf lines(i) = "    IL_0094:  ldstr      ""White""" Then
                        Return True
                End If
            Else
                If lines(i) = "    IL_0094:  ldstr      ""White""" Then
                    lines(i) = "    IL_0094:  ldnull"
                    IO.File.WriteAllLines(IlFile, lines)
                    Return True
                ElseIf lines(i) = "    IL_0094:  ldnull" Then
                    If lines(i - 1).Contains("TraceCoat") Then
                        Return True
                    End If
                End If
            End If
        Next
        MessageBox.Show("File Not Edited!")
        Return False
    End Function
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
        Dim WorkingPath As String = My.Settings.WorkingDecompileLocation
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
        Process.Start(IlasmPath, """" & WorkingPath & Path.GetFileNameWithoutExtension(My.Settings.RandoExePath) & ".iL" & """").WaitForExit()
        My.Settings.RandoExePath = My.Settings.RandoExePath
        'MessageBox.Show("Click OK when command dialog closes")
        If File.Exists(WorkingPath & Path.GetFileNameWithoutExtension(My.Settings.RandoExePath) & ".exe") Then
            File.Copy(WorkingPath & Path.GetFileNameWithoutExtension(My.Settings.RandoExePath) & ".exe",
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
        If My.Settings.WorkingDecompileLocation = "" Then
            My.Settings.WorkingDecompileLocation = GetFolderPath(SpecialFolder.ApplicationData) & "\AxiomRandomizer\" & "WorkingFiles" & Path.DirectorySeparatorChar
        End If
        If Directory.Exists(My.Settings.WorkingDecompileLocation) Then
            GeneralTools.DeleteAllItems(My.Settings.WorkingDecompileLocation)
        End If
        My.Computer.FileSystem.CopyDirectory(My.Settings.VanillaDecompileLocation, My.Settings.WorkingDecompileLocation, True)
    End Sub
    Shared Function DecompileBatch(ExeFilePath, IldasmFilePath, DecompileLocation)
        Dim BatchFile(22) As String
        BatchFile(0) = "ildasm """ & ExeFilePath & """ /out=""" & DecompileLocation & """"
        BatchFile(1) = ""
        BatchFile(2) = "@echo off"
        BatchFile(3) = "setlocal"
        BatchFile(4) = "cd /d %~dp0"
        BatchFile(5) = "Call :UnZipFile """ & Path.GetDirectoryName(DecompileLocation) &
                                        Path.DirectorySeparatorChar & "OuterBeyond.EmbeddedContent.Content"" """ &
                                        Path.GetDirectoryName(DecompileLocation) & Path.DirectorySeparatorChar &
                                        "OuterBeyond.EmbeddedContent.Content.zip"""
        BatchFile(6) = "exit /b"
        BatchFile(7) = ""
        BatchFile(8) = ":UnZipFile <ExtractTo> <newzipfile>"
        BatchFile(9) = "set vbs=""%temp%\_.vbs"""
        BatchFile(10) = "if exist %vbs% del /f /q %vbs%"
        BatchFile(11) = ">%vbs%  echo Set fso = CreateObject(""Scripting.FileSystemObject"")"
        BatchFile(12) = ">>%vbs% echo If NOT fso.FolderExists(%1) Then"
        BatchFile(13) = ">>%vbs% echo fso.CreateFolder(%1)"
        BatchFile(14) = ">>%vbs% echo End If"
        BatchFile(15) = ">>%vbs% echo set objShell = CreateObject(""Shell.Application"")"
        BatchFile(16) = ">>%vbs% echo set FilesInZip=objShell.NameSpace(%2).items"
        BatchFile(17) = ">>%vbs% echo objShell.NameSpace(%1).CopyHere(FilesInZip)"
        BatchFile(18) = ">>%vbs% echo Set fso = Nothing"
        BatchFile(19) = ">>%vbs% echo Set objShell = Nothing"
        BatchFile(20) = "cscript //nologo %vbs%"
        BatchFile(21) = "if exist %vbs% del /f /q %vbs%"
        BatchFile(22) = "START """ & Application.ExecutablePath & """"
        Dim DecompileFile As String = Path.GetDirectoryName(IldasmFilePath) & Path.DirectorySeparatorChar & "Decompile.bat"
        IO.File.WriteAllLines(DecompileFile, BatchFile)
        If File.Exists(DecompileFile) Then
            MessageBox.Show("Run Decompile.bat")
            Process.Start("""" & Path.GetDirectoryName(DecompileFile) & """")
            My.Settings.ManualDecompilePending = True
            Application.Exit()
            Return True
        Else
            Return False
        End If
    End Function
#Region "Graphics"
    Public Class Graphics
        Shared Function CreateWhiteCoat()
            If Not My.Settings.xnbcliSavedPath = "" AndAlso File.Exists(My.Settings.xnbcliSavedPath) Then
                'exe is located we must find the Base Trace Texture
                Dim VanillaCoatPackedFile As String = Path.GetDirectoryName(My.Settings.ExeFilePath) & "\Content\Art\Sprites\Packed\TraceCoatTexture.xnb"
                Dim WhiteCoatPackedFile As String = Path.GetDirectoryName(My.Settings.ExeFilePath) & "\Content\Art\Sprites\Packed\TraceCoatTexture_White.xnb"
                Dim VanillaCoatJsonFile As String = Path.GetDirectoryName(My.Settings.ExeFilePath) & "\Content\Art\Sprites\Packed\TraceCoatTexture.json"
                Dim WhiteCoatJsonFile As String = Path.GetDirectoryName(My.Settings.ExeFilePath) & "\Content\Art\Sprites\Packed\TraceCoatTexture_White.json"
                Dim VanillaCoatSpritePNG As String = Path.GetDirectoryName(My.Settings.ExeFilePath) & "\Content\Art\Sprites\Packed\TraceCoatTexture.png"
                Dim WhiteCoatSpritePNG As String = Path.GetDirectoryName(My.Settings.ExeFilePath) & "\Content\Art\Sprites\Packed\TraceCoatTexture_White.png"
                If File.Exists(VanillaCoatPackedFile) Then
                    If Not File.Exists(VanillaCoatPackedFile & ".bak") Then
                        File.Copy(VanillaCoatPackedFile, VanillaCoatPackedFile & ".bak")
                    End If
                    Try
                        If File.Exists(WhiteCoatPackedFile) Then
                            If File.Exists(My.Settings.VanillaDecompileLocation & Path.GetFileNameWithoutExtension(My.Settings.RandoExePath) & ".iL") Then
                                If ModifyCodeLabCoat(My.Settings.VanillaDecompileLocation & Path.GetFileNameWithoutExtension(My.Settings.RandoExePath) & ".iL", True) Then
                                    'Message box to spawn from previous function to allow greater error reporting.
                                    MessageBox.Show("Extraction Complete!")
                                    Return True
                                End If
                            Else
                                MessageBox.Show("Il File not Found!", "Extract Fialed")
                                Return False
                            End If
                        End If
                        Process.Start(My.Settings.xnbcliSavedPath, "unpack """ & VanillaCoatPackedFile & """").WaitForExit() 'this should create a png and json in the packed folder
                        If File.Exists(WhiteCoatJsonFile) Then File.Delete(WhiteCoatJsonFile)
                        File.Move(VanillaCoatJsonFile, WhiteCoatJsonFile)
                        If File.Exists(WhiteCoatSpritePNG) Then File.Delete(WhiteCoatSpritePNG)
                        File.Move(VanillaCoatSpritePNG, WhiteCoatSpritePNG)
                        Dim JsonLines As String() = File.ReadAllLines(WhiteCoatJsonFile)
                        For i As Integer = 0 To JsonLines.Count - 1
                            If JsonLines(i).Contains("TraceCoatTexture.png") Then
                                JsonLines(i) = JsonLines(i).Replace("TraceCoatTexture.png", "TraceCoatTexture_White.png")
                            End If
                        Next
                        File.WriteAllLines(WhiteCoatJsonFile, JsonLines)
                        Process.Start(My.Settings.xnbcliSavedPath, "pack """ & WhiteCoatJsonFile & """").WaitForExit() 'this should create a xnb in the packed folder
                        File.Delete(WhiteCoatJsonFile)
                        File.Delete(WhiteCoatSpritePNG)
                        If File.Exists(My.Settings.VanillaDecompileLocation & Path.GetFileNameWithoutExtension(My.Settings.RandoExePath) & ".iL") Then
                            If ModifyCodeLabCoat(My.Settings.VanillaDecompileLocation & Path.GetFileNameWithoutExtension(My.Settings.RandoExePath) & ".iL", True) Then
                                'Message box to spawn from previous function to allow greater error reporting.
                                MessageBox.Show("Extraction Complete!")
                                Return True
                            End If
                        Else
                            MessageBox.Show("Il File not Found!", "Extract Fialed")
                        End If
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                Else
                    MessageBox.Show("Base Texture File ""TraceCoatTexture.xnb"" not Found!", "Extract Fialed")
                End If
            Else
                MessageBox.Show("""xnbcli.exe"" not found!", "Extract Fialed")
            End If
            Return False
        End Function
        Shared Function RemoveWhiteCoat()
            Dim VanillaCoatPackedFile As String = Path.GetDirectoryName(My.Settings.ExeFilePath) & "\Content\Art\Sprites\Packed\TraceCoatTexture.xnb"
            Dim WhiteCoatPackedFile As String = Path.GetDirectoryName(My.Settings.ExeFilePath) & "\Content\Art\Sprites\Packed\TraceCoatTexture_White.xnb"
            If File.Exists(VanillaCoatPackedFile & ".bak") Then
                File.Delete(VanillaCoatPackedFile)
                File.Delete(WhiteCoatPackedFile)
                File.Copy(VanillaCoatPackedFile & ".bak", VanillaCoatPackedFile)
            Else
                MessageBox.Show("Backup texture file not found.  Manually restore/reinstall game files!", "Backup Failure!")
            End If
            Return False
        End Function
        Shared Sub RandomizeFakeCoat(Seed As Integer)
            'Random Color Selection
            Dim Generator As System.Random = New System.Random(Seed:=Seed)
            Dim NewColorRGB(2) As Byte ' 3 bytes for rgb
            Do
                Generator.NextBytes(NewColorRGB)
                If Color.FromArgb(NewColorRGB(0), NewColorRGB(1), NewColorRGB(2)).GetBrightness < 0.3 Then
                    Continue Do
                End If
                Exit Do
            Loop
            Dim NewLightColor As Color = Color.FromArgb(NewColorRGB(0), NewColorRGB(1), NewColorRGB(2))
            Dim NewDarkColor As Color = ControlPaint.Dark(NewLightColor, 0.25)
            My.Settings.CurrentLightColor = NewLightColor
            My.Settings.CurrentDarkColor = NewDarkColor
            PaintFakeCoat()
        End Sub
        Shared Sub PaintFakeCoat()
            'lets do an inital check for the backup so it exits if there is no backup file
            Dim VanillaCoatPackedFile As String = Path.GetDirectoryName(My.Settings.ExeFilePath) & "\Content\Art\Sprites\Packed\TraceCoatTexture.xnb"
            Dim VanillaCoatJsonFile As String = Path.GetDirectoryName(My.Settings.ExeFilePath) & "\Content\Art\Sprites\Packed\TraceCoatTexture.json"
            Dim VanillaCoatSpritePNG As String = Path.GetDirectoryName(My.Settings.ExeFilePath) & "\Content\Art\Sprites\Packed\TraceCoatTexture.png"
            If File.Exists(VanillaCoatPackedFile & ".bak") Then
                If Not My.Settings.xnbcliSavedPath = "" AndAlso File.Exists(My.Settings.xnbcliSavedPath) Then
                    File.Copy(VanillaCoatPackedFile & ".bak", VanillaCoatPackedFile, True)
                    Process.Start(My.Settings.xnbcliSavedPath, "unpack """ & VanillaCoatPackedFile & """").WaitForExit() 'this should create a png and json in the packed folder
                    'Now we want to edit the png file and save it
                    If File.Exists(VanillaCoatSpritePNG & "Copy") Then File.Delete(VanillaCoatSpritePNG & "Copy")
                    File.Move(VanillaCoatSpritePNG, VanillaCoatSpritePNG & "Copy")
                    Dim TempImage As Bitmap = New Bitmap(VanillaCoatSpritePNG & "Copy")
                    '
                    'Exist Color Calibration
                    '
                    'Light Color First
                    Dim CalibrateRedLight As Byte = 223
                    Dim CalibrateGreenLight As Byte = 215
                    Dim CalibrateBlueLight As Byte = 201
                    'Darker Color Next
                    Dim CalibrateRedDark As Byte = 127
                    Dim CalibrateGreenDark As Byte = 115
                    Dim CalibrateBlueDark As Byte = 105
                    'Color Replacement Method ----
                    For x As Integer = 0 To TempImage.Width - 1
                        For y As Integer = 0 To TempImage.Height - 1
                            Dim red As Byte = TempImage.GetPixel(x, y).R
                            Dim green As Byte = TempImage.GetPixel(x, y).G
                            Dim blue As Byte = TempImage.GetPixel(x, y).B
                            If red = CalibrateRedLight AndAlso
                               green = CalibrateGreenLight AndAlso
                               blue = CalibrateBlueLight Then 'Light Replace
                                TempImage.SetPixel(x, y, My.Settings.CurrentLightColor)
                            ElseIf red = CalibrateRedDark AndAlso
                               green = CalibrateGreenDark AndAlso
                               blue = CalibrateBlueDark Then ' Dark Replace
                                TempImage.SetPixel(x, y, My.Settings.CurrentDarkColor)
                            End If
                        Next
                    Next
                    TempImage.Save(VanillaCoatSpritePNG, System.Drawing.Imaging.ImageFormat.Png)
                    TempImage.Dispose()
                    Process.Start(My.Settings.xnbcliSavedPath, "pack """ & VanillaCoatJsonFile & """").WaitForExit() 'this should create a xnb in the packed folder
                    File.Delete(VanillaCoatSpritePNG)
                    File.Delete(VanillaCoatSpritePNG & "Copy")
                    File.Delete(VanillaCoatJsonFile)
                Else
                    MessageBox.Show("xnbcli exe not found.  Texture left untouched", "Saftey exit")
                End If
            Else
                MessageBox.Show("Backup texture file not found.  Texture left untouched", "Saftey exit")
            End If

        End Sub
    End Class
#End Region
End Class