Imports System.IO
Imports AxiomRandomizer.GameInformation
Public Class XMLTools
    Shared Sub ExportLocations(SentPath As String)
        If SentPath = My.Settings.XMLSaveLocation AndAlso My.Settings.XMLLimited Then
            LimitXMLCount(SentPath, My.Settings.XMLLimitCount)
        End If
        Dim SavedPath As String
        If SentPath.EndsWith(".xml") Then
            SavedPath = SentPath
        ElseIf SentPath.EndsWith(".exe") Then
            SavedPath = Path.GetDirectoryName(SentPath) & Path.DirectorySeparatorChar &
                My.Settings.PreviousSeed.ToString & ".xml"
        Else 'sent path should have directory already appended
            SavedPath = SentPath & My.Settings.PreviousSeed.ToString & ".xml"
        End If

        Dim writer As New System.Xml.Serialization.XmlSerializer(GetType(List(Of Location)))
        Dim file As New System.IO.StreamWriter(
            SavedPath)
        writer.Serialize(file, Randomizer.LocationInformation)
        file.Close()
    End Sub
    Shared Sub ImportLocations(SentPath As String)
        Dim reader As New System.Xml.Serialization.XmlSerializer(GetType(List(Of Location)))
        Dim file As New System.IO.StreamReader(
            SentPath)
        Randomizer.LocationInformation = reader.Deserialize(file)
        'reader.Deserialize(file, LocationInformation)
        file.Close()
    End Sub
    Shared Function GetXMLCount(SentPath As String)
        Dim CountofXLMFiles As Integer = 0
        Dim TempDirectory As New DirectoryInfo(SentPath)
        Dim FileList() As FileInfo = TempDirectory.GetFiles("*.xml", SearchOption.TopDirectoryOnly)
        For Each TempXML As FileInfo In FileList
            Dim TempLines As String() = IO.File.ReadAllLines(TempXML.FullName)
            If TempLines.Length > 2 Then
                If TempLines(1).StartsWith("<ArrayOfLocation ") Then
                    CountofXLMFiles += 1
                End If
            End If
        Next
        Return CountofXLMFiles
    End Function
    Shared Sub LimitXMLCount(SentPath As String, LimitCount As Integer)
        Dim CountofXLMFiles As Integer = 0
        Dim TempDirectory As New DirectoryInfo(SentPath)
        Dim FileList() As FileInfo = TempDirectory.GetFiles("*.xml", SearchOption.TopDirectoryOnly)
        Array.Sort(Of FileInfo) _
    (
    FileList,
    New Comparison(Of FileInfo) _
        (
        Function(f1 As FileInfo, f2 As FileInfo) File.GetCreationTime(f2.FullName).CompareTo(File.GetCreationTime(f1.FullName))
        )
    )
        Dim DeletionList As List(Of String) = New List(Of String)
        For Each TempXML As FileInfo In FileList
            Dim TempLines As String() = IO.File.ReadAllLines(TempXML.FullName)
            If TempLines.Length > 2 Then
                If TempLines(1).StartsWith("<ArrayOfLocation ") Then
                    CountofXLMFiles += 1
                    If CountofXLMFiles > LimitCount Then
                        DeletionList.Add(TempXML.FullName)
                    End If
                End If
            End If
        Next
        If DeletionList.Count > 0 Then
            For i As Integer = 0 To DeletionList.Count - 1
                File.Delete(DeletionList(i))
            Next
        End If
    End Sub
End Class
Public Class XMLEditor
    Shared Function WriteSettings(SeedNum As Long,
                                  Difficulty As Randomizer.DifficultySetting,
                                  OpenEribu1 As Boolean,
                                  OpenElsenova2 As Boolean,
                                  OpenAbsu3 As Boolean,
                                  DropDown As Boolean,
                                  Walls As Boolean,
                                  Illusion As Boolean,
                                  ObscuredItems As Boolean)
        Dim TextSettingsFolder = My.Settings.WorkingDecompileLocation & "OuterBeyond.EmbeddedContent.Content\Text\"
        'I will only implement this for english currently however there should later be translations for the languiages following after
        If System.IO.File.Exists(TextSettingsFolder & "UI_English.xml") Then
            GeneralTools.MakeWriteable(TextSettingsFolder & "UI_English.xml")
            Dim lines() As String = IO.File.ReadAllLines(TextSettingsFolder & "UI_English.xml")
            Dim LineCount As Integer = 0
            Dim DiscriptionString As String = "~This is a special mode with randomized items"
            'If MonstersRando Then
            'DiscriptionString += ", and monsters randomized.  "
            'Else
            'DiscriptionString += ".  "
            'End If
            DiscriptionString += "This has been generated on the " & Difficulty.ToString & " difficulty with the seed: " & SeedNum.ToString
            '_____Individual checks
            Dim OptionsString As String = "`The following options have been enabled: "
            If OpenEribu1 Then OptionsString += "Open Eribu, "
            If OpenElsenova2 Then OptionsString += "Open Elsenova, "
            If OpenAbsu3 Then OptionsString += "Open Absu, "
            If DropDown Then OptionsString += "Drop Down Change, "
            If Walls Then OptionsString += "1 Way Wall Change, "
            If Illusion Then OptionsString += "Illusion Removed, "

            OptionsString += " </THTextEntry>"
            For i As Integer = 0 To lines.Length - 1
                If lines(i).Contains("This is a special mode for competitive streamers who complete the game in a single sitting.") OrElse
                    lines(i).StartsWith("~") Then
                    lines(i) = DiscriptionString
                    LineCount += 1
                End If
                If lines(i).Contains("It eliminates dialogue, cutscenes, and randomized content, and provides an on-screen timer.</THTextEntry>") OrElse
                    lines(i).StartsWith("`") Then
                    lines(i) = OptionsString
                    LineCount += 1
                End If
            Next
            'It eliminates dialogue, cutscenes, and randomized content, and provides an on-screen timer.</THTextEntry>
            If LineCount < 2 Then
                If MessageBox.Show("Settings description incomplete, continue build?", "UI Edits Fail", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    Return True
                Else
                    Return False
                End If
            End If
            IO.File.WriteAllLines(TextSettingsFolder & "UI_English.xml", lines)
            Return True
        Else
            MessageBox.Show("UI text file not found, modification failed")
            Return False
        End If
        'French
        'German
        'Italian
        'Japanese
        'Portugese
        'Russian
        'Spanish
    End Function
    Shared Function MakeItemsTraceFace()
        Dim ItemSettingsXML = My.Settings.WorkingDecompileLocation & "OuterBeyond.EmbeddedContent.Content\XML\Items.xml"
        If System.IO.File.Exists(ItemSettingsXML) Then
            GeneralTools.MakeWriteable(ItemSettingsXML)
            Dim lines As List(Of String) = IO.File.ReadAllLines(ItemSettingsXML).ToList
            Dim LineCount As Integer = 0
            Do While LineCount < lines.Count
                If lines(LineCount).Contains("<mPickupAnimation>DataDisruptorPickup</mPickupAnimation>") Then
                    lines(LineCount) = lines(LineCount).Replace("DataDisruptorPickup", "ExitDrone")
                End If
                If lines(LineCount).Contains("<mIconAnimation>") Then
                    If lines(LineCount).Contains("GlitchBombDrop") OrElse
                       lines(LineCount).Contains("HealthDrop0") OrElse
                       lines(LineCount).Contains("HealthDrop1") OrElse
                       lines(LineCount - 1).Contains("<mPickupAnimation>") Then
                    Else
                        lines.Insert(LineCount, "    <mPickupAnimation>ExitDrone</mPickupAnimation> ")
                    End If
                End If
                If lines(LineCount).Contains("<mPulseVal>0.0</mPulseVal>") Then
                    lines.RemoveAt(LineCount)
                    Continue Do 'skips the plus 1 so the current line is re read
                End If
                LineCount += 1
            Loop
            IO.File.WriteAllLines(ItemSettingsXML, lines)
            Return True
        Else
            MessageBox.Show("UI text file not found, modification failed")
            Return False
        End If

    End Function
End Class
