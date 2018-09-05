Imports System.IO    'Files
Imports System.Environment 'appdata
Imports AxiomRandomizer.GameInformation
Public Class TileMapEditor
    Shared TileMapFolder As String
    Shared Function CheckTileMaps()
        TileMapFolder = GetFolderPath(SpecialFolder.ApplicationData) & "\AxiomRandomizer\WorkingFiles\OuterBeyond.EmbeddedContent.Content\Art\TileMaps\"
        Return File.Exists(TileMapFolder & "Area1.tmx")
    End Function
    Shared Function WriteItems()
        TileMapFolder = GetFolderPath(SpecialFolder.ApplicationData) & "\AxiomRandomizer\WorkingFiles\OuterBeyond.EmbeddedContent.Content\Art\TileMaps\"
        If WriteRegion("Area1.tmx", Area.Eribu) AndAlso
           WriteRegion("Area2.tmx", Area.Absu) AndAlso
           WriteRegion("Area3.tmx", Area.Zi) AndAlso
           WriteRegion("Area4.tmx", Area.Kur) AndAlso
           WriteRegion("Area5.tmx", Area.Indi) AndAlso
           WriteRegion("Area6Normal.tmx", Area.UkkinNa) AndAlso
           WriteRegion("Area7.tmx", Area.Edin) AndAlso
           WriteRegion("Area8.tmx", Area.EKurMah) AndAlso
           WriteRegion("Area9.tmx", Area.MarUru) Then
            Return True
        Else
            Return False
        End If
    End Function
    Shared Function WriteRegion(FileName As String, RegionPlaced As Area)
        If System.IO.File.Exists(TileMapFolder & FileName) Then
            GeneralTools.MakeWriteable(TileMapFolder & FileName)
            Dim lines() As String = IO.File.ReadAllLines(TileMapFolder & FileName)
            Dim NewLines As List(Of String) = New List(Of String)
            'Make the first pass monster replacements
            If Randomizer.MonsterList.Count > 0 Then
                'MessageBox.Show("Monsters Changing " & RegionPlaced.ToString)
                'Make List of Monster Replacements for this area
                Dim SpawnPairs As List(Of KeyValuePair(Of Integer, Integer)) = New List(Of KeyValuePair(Of Integer, Integer))
                For i As Integer = 0 To Randomizer.MonsterList.Count - 1
                    If Randomizer.MonsterList(i).Region = RegionPlaced Then
                        SpawnPairs.Add(New KeyValuePair(Of Integer, Integer)(
                                       Randomizer.GetDefaultGID(RegionPlaced) +
                                       Randomizer.GetCreatureNumber(Randomizer.MonsterList(i).Vanilla),
                                       Randomizer.GetDefaultGID(RegionPlaced) +
                                       Randomizer.GetCreatureNumber(Randomizer.MonsterList(i).Spawns))) 'OLD,NEW
                    End If
                Next
                For i As Integer = 0 To lines.Length - 1
                    If lines(i).Contains("<object gid=") Then
                        For j As Integer = 0 To SpawnPairs.Count - 1
                            If lines(i).Contains("<object gid=""" & SpawnPairs(j).Key.ToString) Then
                                lines(i) = lines(i).Replace("<object gid=""" & SpawnPairs(j).Key.ToString,
                                                            "<object gid=""" & SpawnPairs(j).Value.ToString)
                            End If
                        Next
                    ElseIf lines(i).Contains("<object id=") Then
                        For j As Integer = 0 To SpawnPairs.Count - 1
                            If lines(i).Contains(" gid=""" & SpawnPairs(j).Key.ToString) Then
                                lines(i) = lines(i).Replace(" gid=""" & SpawnPairs(j).Key.ToString,
                                                            " gid=""" & SpawnPairs(j).Value.ToString)
                            End If
                        Next
                    End If
                Next
            End If

            For Each Templocation As Location In Randomizer.LocationInformation
                If Templocation.Region = RegionPlaced Then
                    If Templocation.AddedDrop = False Then
                        If Templocation.ItemName = "" Then

                            lines(Templocation.LineNumber1 - 1) = "  <object name=""" & Templocation.Item.ToString &
                                                                    """ gid=""" & Templocation.InGameItemID &
                                                                    """ x=""" & Templocation.XLocation &
                                                                    """ y=""" & Templocation.YLocation & """/>"
                        Else

                            lines(Templocation.LineNumber1 - 1) = "  <object name=""" & Templocation.ItemName &
                                                                    """ gid=""" & Templocation.InGameItemID &
                                                                    """ x=""" & Templocation.XLocation &
                                                                    """ y=""" & Templocation.YLocation & """/>"
                        End If
                    Else
                        If Templocation.ItemName = "" Then

                            NewLines.Add("  <object name=""" & Templocation.Item.ToString &
                                                                    """ gid=""" & Templocation.InGameItemID &
                                                                    """ x=""" & Templocation.XLocation &
                                                                    """ y=""" & Templocation.YLocation & """/>")
                        Else
                            NewLines.Add("  <object name=""" & Templocation.ItemName &
                                                                    """ gid=""" & Templocation.InGameItemID &
                                                                    """ x=""" & Templocation.XLocation &
                                                                    """ y=""" & Templocation.YLocation & """/>")
                        End If
                    End If
                End If
            Next
            'Adding New Items
            If NewLines.Count > 0 Then
                Dim OldLineLength As Integer = lines.Length - 1
                ReDim Preserve lines((lines.Length - 1) + NewLines.Count)
                Dim NewLinesStart As Integer = Randomizer.GetAddedLine(RegionPlaced)
                For i As Integer = OldLineLength To NewLinesStart Step -1
                    lines(i + NewLines.Count) = lines(i)
                Next
                For i As Integer = 0 To NewLines.Count - 1
                    lines(NewLinesStart + i) = NewLines(i)
                Next
            End If
            IO.File.WriteAllLines(TileMapFolder & FileName, lines)
            'MessageBox.Show(FileName & " Edited")
        Else
            MsgBox(FileName & " Error")
            Return False
        End If
        Return True
    End Function
    Shared Function OneWayDropDown(ApplyChange As Boolean)
        TileMapFolder = GetFolderPath(SpecialFolder.ApplicationData) & "\AxiomRandomizer\WorkingFiles\OuterBeyond.EmbeddedContent.Content\Art\TileMaps\"
        If System.IO.File.Exists(TileMapFolder & "Area3.tmx") Then
            GeneralTools.MakeWriteable(TileMapFolder & "Area3.tmx")
            Dim lines() As String = IO.File.ReadAllLines(TileMapFolder & "Area3.tmx")
            Dim LineCount As Integer = 0
            If ApplyChange Then
                For i As Integer = 0 To lines.Length - 1
                    If lines(i).Contains("0,0,0,0,0,0,0,0,104,104,0,0") Then
                        lines(i) = lines(i).Replace("0,0,0,0,0,0,0,0,104,104,0,0", "0,0,104,104,0,0,0,0,104,104,0,0")
                        LineCount += 1
                    ElseIf lines(i).Contains("0,0,104,104,0,0,0,0,104,104,0,0") Then
                        LineCount += 1
                    ElseIf lines(i).Contains("0,0,0,0,0,0,0,0,136,136,0,0") Then
                        lines(i) = lines(i).Replace("0,0,0,0,0,0,0,0,136,136,0,0", "0,0,136,136,0,0,0,0,136,136,0,0")
                        LineCount += 1
                    ElseIf lines(i).Contains("0,0,136,136,0,0,0,0,136,136,0,0") Then
                        LineCount += 1
                    ElseIf lines(i).Contains("3,0,0,0,0,0,0,0,0,97,99,0,0,0") Then
                        lines(i) = lines(i).Replace("3,0,0,0,0,0,0,0,0,97,99,0,0,0", "3,0,0,97,99,0,0,0,0,97,99,0,0,0")
                        LineCount += 1
                    ElseIf lines(i).Contains("3,0,0,97,99,0,0,0,0,97,99,0,0,0") Then
                        LineCount += 1
                    ElseIf lines(i).Contains("1,0,0,0,0,0,0,0,0,0,0,0,0,0,33,33,0,0,0,33,") Then
                        lines(i) = lines(i).Replace("1,0,0,0,0,0,0,0,0,0,0,0,0,0,33,33,0,0,0,33,", "1,0,0,0,0,0,0,0,33,33,0,0,0,0,33,33,0,0,0,33,")
                        LineCount += 1
                    ElseIf lines(i).Contains("1,0,0,0,0,0,0,0,33,33,0,0,0,0,33,33,0,0,0,33,") Then
                        LineCount += 1
                    End If

                    If i = lines.Length - 1 Then
                        If LineCount < 10 Then
                            If MessageBox.Show("Zi Dropdown incomplete, continue build?", "Platform Build Fail", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                                Return True
                            Else
                                Return False
                            End If
                        End If
                    End If
                Next
            Else ' make sure to remove change
                For i As Integer = 0 To lines.Length - 1
                    If lines(i).Contains("0,0,104,104,0,0,0,0,104,104,0,0") Then
                        lines(i) = lines(i).Replace("0,0,104,104,0,0,0,0,104,104,0,0", "0,0,0,0,0,0,0,0,104,104,0,0")
                        LineCount += 1
                    ElseIf lines(i).Contains("0,0,0,0,0,0,0,0,104,104,0,0") Then
                        LineCount += 1
                    ElseIf lines(i).Contains("0,0,136,136,0,0,0,0,136,136,0,0") Then
                        lines(i) = lines(i).Replace("0,0,136,136,0,0,0,0,136,136,0,0", "0,0,0,0,0,0,0,0,136,136,0,0")
                        LineCount += 1
                    ElseIf lines(i).Contains("0,0,0,0,0,0,0,0,136,136,0,0") Then
                        LineCount += 1
                    ElseIf lines(i).Contains("3,0,0,97,99,0,0,0,0,97,99,0,0,0") Then
                        lines(i) = lines(i).Replace("3,0,0,97,99,0,0,0,0,97,99,0,0,0", "3,0,0,0,0,0,0,0,0,97,99,0,0,0")
                        LineCount += 1
                    ElseIf lines(i).Contains("3,0,0,0,0,0,0,0,0,97,99,0,0,0") Then
                        LineCount += 1
                    ElseIf lines(i).Contains("1,0,0,0,0,0,0,0,33,33,0,0,0,0,33,33,0,0,0,33,") Then
                        lines(i) = lines(i).Replace("1,0,0,0,0,0,0,0,33,33,0,0,0,0,33,33,0,0,0,33,", "1,0,0,0,0,0,0,0,0,0,0,0,0,0,33,33,0,0,0,33,")
                        LineCount += 1
                    ElseIf lines(i).Contains("1,0,0,0,0,0,0,0,0,0,0,0,0,0,33,33,0,0,0,33,") Then
                        LineCount += 1
                    End If
                    If i = lines.Length - 1 Then
                        If LineCount < 10 Then
                            If MessageBox.Show("Zi Dropdown incomplete, continue build?", "Platform Build Fail", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                                Return True
                            Else
                                Return False
                            End If
                        End If
                    End If
                Next
            End If
            IO.File.WriteAllLines(TileMapFolder & "Area3.tmx", lines)
            Return True
        Else
            MessageBox.Show("Map file not found, creation failed")
            Return False
        End If
    End Function
    Shared Function OneWayWalls(ApplyChange As Boolean)
        TileMapFolder = GetFolderPath(SpecialFolder.ApplicationData) & "\AxiomRandomizer\WorkingFiles\OuterBeyond.EmbeddedContent.Content\Art\TileMaps\"
        If System.IO.File.Exists(TileMapFolder & "Area6Normal.tmx") Then
            GeneralTools.MakeWriteable(TileMapFolder & "Area6Normal.tmx")
            Dim lines() As String = IO.File.ReadAllLines(TileMapFolder & "Area6Normal.tmx")
            Dim LineCount As Integer = 0
            If ApplyChange Then
                For i As Integer = 0 To lines.Length - 1
                    If lines(i).Contains("43,44,45,0,0,0,0,0,0,0,1,1,1,4") Then
                        lines(i) = lines(i).Replace("43,44,45,0,0,0,0,0,0,0,1,1,1,4", "43,44,45,0,0,0,0,0,0,0,0,0,0,4")
                        LineCount += 1
                    ElseIf lines(i).Contains("43,44,45,0,0,0,0,0,0,0,0,0,0,4") Then
                        LineCount += 1
                    End If
                    If lines(i).Contains("43,44,45,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,4,1,1,1,") Then
                        lines(i) = lines(i).Replace("43,44,45,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,4,1,1,1,",
                                                    "43,44,45,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,4,0,0,0,")
                        LineCount += 1
                    ElseIf lines(i).Contains("43,44,45,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,4,0,0,0,") Then
                        LineCount += 1
                    End If
                    If lines(i).Contains("76,77,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,3,1,1,") Then
                        lines(i) = lines(i).Replace("76,77,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,3,1,1,",
                                                    "76,77,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,")
                        LineCount += 1
                    ElseIf lines(i).Contains("76,77,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,") Then
                        LineCount += 1
                    End If
                    If lines(i).Contains("75,76,77,0,0,0,0,0,0,0,1,3,1,1") Then
                        lines(i) = lines(i).Replace("75,76,77,0,0,0,0,0,0,0,1,3,1,1",
                                                    "75,76,77,0,0,0,0,0,0,0,0,0,0,1")
                        LineCount += 1
                    ElseIf lines(i).Contains("75,76,77,0,0,0,0,0,0,0,0,0,0,1") Then
                        LineCount += 1
                    End If
                    If i = lines.Length - 1 Then
                        If LineCount < 4 Then
                            If MessageBox.Show("Ukkin-Na wall edits incomplete, continue build?", "Platform Build Fail", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                                Return True
                            Else
                                Return False
                            End If
                        End If
                    End If
                Next
            Else ' make sure to remove change
                For i As Integer = 0 To lines.Length - 1
                    If lines(i).Contains("43,44,45,0,0,0,0,0,0,0,0,0,0,4") Then
                        lines(i) = lines(i).Replace("43,44,45,0,0,0,0,0,0,0,0,0,0,4", "43,44,45,0,0,0,0,0,0,0,1,1,1,4")
                        LineCount += 1
                    ElseIf lines(i).Contains("43,44,45,0,0,0,0,0,0,0,1,1,1,4") Then
                        LineCount += 1
                    End If
                    If lines(i).Contains("43,44,45,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,4,0,0,0,") Then
                        lines(i) = lines(i).Replace("43,44,45,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,4,0,0,0,",
                                                    "43,44,45,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,4,1,1,1,")
                        LineCount += 1
                    ElseIf lines(i).Contains("43,44,45,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,4,1,1,1,") Then
                        LineCount += 1
                    End If
                    If lines(i).Contains("76,77,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,") Then
                        lines(i) = lines(i).Replace("76,77,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,",
                                                    "76,77,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,3,1,1,")
                        LineCount += 1
                    ElseIf lines(i).Contains("76,77,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,3,1,1,") Then
                        LineCount += 1
                    End If
                    If lines(i).Contains("75,76,77,0,0,0,0,0,0,0,0,0,0,1") Then
                        lines(i) = lines(i).Replace("75,76,77,0,0,0,0,0,0,0,0,0,0,1",
                                                    "75,76,77,0,0,0,0,0,0,0,1,3,1,1")
                        LineCount += 1
                    ElseIf lines(i).Contains("75,76,77,0,0,0,0,0,0,0,1,3,1,1") Then
                        LineCount += 1
                    End If
                    If i = lines.Length - 1 Then
                        If LineCount < 4 Then
                            If MessageBox.Show("Ukkin-Na wall edits incomplete, continue build?", "Platform Build Fail", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                                Return True
                            Else
                                Return False
                            End If
                        End If
                    End If
                Next
            End If
            IO.File.WriteAllLines(TileMapFolder & "Area6Normal.tmx", lines)
            Return True
        Else
            MessageBox.Show("Map file not found, creation failed")
            Return False
        End If
    End Function
    Shared Sub RemoveIllusion(ApplyChange As Boolean)
        GeneralTools.MakeWriteable(TileMapFolder & "Area6.tmx")
        File.Copy(TileMapFolder & "Area6Normal.tmx", TileMapFolder & "Area6.tmx", True)
    End Sub

End Class
