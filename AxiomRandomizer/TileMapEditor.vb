Imports System.IO    'Files
Imports System.Environment 'appdata
Imports AxiomRandomizer.GameInformation
Public Class TileMapEditor
    Shared TileMapFolder As String
    Shared Function CheckTileMaps()
        TileMapFolder = My.Settings.WorkingDecompileLocation & "OuterBeyond.EmbeddedContent.Content\Art\TileMaps\"
        Return File.Exists(TileMapFolder & "Area1.tmx")
    End Function
    Shared Function WriteItems()
        TileMapFolder = My.Settings.WorkingDecompileLocation & "OuterBeyond.EmbeddedContent.Content\Art\TileMaps\"
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
            'if randomizer.monsterlist.count > 0 then
            '    messagebox.show("monsters changing " & regionplaced.tostring)
            '    make list of monster replacements for this area
            'dim spawnpairs as list(of keyvaluepair(of integer, integer)) = new list(of keyvaluepair(of integer, integer))
            '    for i as integer = 0 to randomizer.monsterlist.count - 1
            '        if randomizer.monsterlist(i).region = regionplaced then
            '            spawnpairs.add(new keyvaluepair(of integer, integer)(
            '            randomizer.getdefaultgid(regionplaced) +
            '            randomizer.getcreaturenumber(randomizer.monsterlist(i).vanilla),
            '            randomizer.getdefaultgid(regionplaced) +
            '            randomizer.getcreaturenumber(randomizer.monsterlist(i).spawns))) 'old,new
            '        end if
            '    next
            '    for i as integer = 0 to lines.length - 1
            '        if lines(i).contains("<object gid=") then
            '            for j as integer = 0 to spawnpairs.count - 1
            '                if lines(i).contains("<object gid=""" & spawnpairs(j).key.tostring) then
            '                    lines(i) = lines(i).replace("<object gid=""" & spawnpairs(j).key.tostring,
            '                                                                   "<object gid=""" & spawnpairs(j).value.tostring)
            '                end if
            '            next
            '        elseif lines(i).contains("<object id=") then
            '            for j as integer = 0 to spawnpairs.count - 1
            '                if lines(i).contains(" gid=""" & spawnpairs(j).key.tostring) then
            '                    lines(i) = lines(i).replace(" gid=""" & spawnpairs(j).key.tostring,
            '                                                                   " gid=""" & spawnpairs(j).value.tostring)
            '                end if
            '            next
            '        end if
            '    next
            'end if
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
        TileMapFolder = My.Settings.WorkingDecompileLocation & "OuterBeyond.EmbeddedContent.Content\Art\TileMaps\"
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
        TileMapFolder = My.Settings.WorkingDecompileLocation & "OuterBeyond.EmbeddedContent.Content\Art\TileMaps\"
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
    Shared Function OpenEribu(ApplyChange As Boolean)
        TileMapFolder = My.Settings.WorkingDecompileLocation & "OuterBeyond.EmbeddedContent.Content\Art\TileMaps\"
        If System.IO.File.Exists(TileMapFolder & "Area1.tmx") Then
            GeneralTools.MakeWriteable(TileMapFolder & "Area1.tmx")
            Dim lines() As String = IO.File.ReadAllLines(TileMapFolder & "Area1.tmx")
            Dim LineCount As Integer = 0
            If ApplyChange Then
                For i As Integer = 0 To lines.Length - 1
                    If lines(i).Contains("4,4,4,4,4,8,8,8,8,8,8,8,8,8,8,") Then
                        lines(i) = lines(i).Replace("4,4,4,4,4,8,8,8,8,8,8,8,8,8,8,", "0,4,4,4,4,8,8,8,8,8,8,8,8,8,8,")
                        LineCount += 1
                    ElseIf lines(i).Contains("0,4,4,4,4,8,8,8,8,8,8,8,8,8,8,") Then
                        LineCount += 1
                    End If
                    If lines(i).Contains("40,8,4,4,4,4,4,8,8,49,") Then
                        lines(i) = lines(i).Replace("40,8,4,4,4,4,4,8,8,49,", "40,8,0,0,4,4,4,8,8,49,")
                        LineCount += 1
                    ElseIf lines(i).Contains("40,8,0,0,4,4,4,8,8,49,") Then
                        LineCount += 1
                    End If
                    If lines(i).Contains("24,4,4,4,4,4,24,49,") Then
                        lines(i) = lines(i).Replace("24,4,4,4,4,4,24,49,", "24,0,0,4,4,4,24,49,")
                        LineCount += 1
                    ElseIf lines(i).Contains("24,0,0,4,4,4,24,49,") Then
                        LineCount += 1
                    End If
                    If lines(i).Contains("49,8,4,4,4,4,4,8,8,40,") Then
                        lines(i) = lines(i).Replace("49,8,4,4,4,4,4,8,8,40,", "49,8,0,0,4,4,4,8,8,40,")
                        LineCount += 1
                    ElseIf lines(i).Contains("49,8,0,0,4,4,4,8,8,40,") Then
                        LineCount += 1
                    End If
                    If i = lines.Length - 1 Then
                        If LineCount < 4 Then
                            If MessageBox.Show("Eribu opening incomplete, continue build?", "Drill Removal Fail", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                                Return True
                            Else
                                Return False
                            End If
                        End If
                    End If
                Next
            Else ' make sure to remove change
                For i As Integer = 0 To lines.Length - 1
                    If lines(i).Contains("0,4,4,4,4,8,8,8,8,8,8,8,8,8,8,") Then
                        lines(i) = lines(i).Replace("0,4,4,4,4,8,8,8,8,8,8,8,8,8,8,", "4,4,4,4,4,8,8,8,8,8,8,8,8,8,8,")
                        LineCount += 1
                    ElseIf lines(i).Contains("4,4,4,4,4,8,8,8,8,8,8,8,8,8,8,") Then
                        LineCount += 1
                    End If
                    If lines(i).Contains("40,8,0,0,4,4,4,8,8,49,") Then
                        lines(i) = lines(i).Replace("40,8,0,0,4,4,4,8,8,49,", "40,8,4,4,4,4,4,8,8,49,")
                        LineCount += 1
                    ElseIf lines(i).Contains("40,8,4,4,4,4,4,8,8,49,") Then
                        LineCount += 1
                    End If
                    If lines(i).Contains("24,4,4,4,0,0,24,49,") Then
                        lines(i) = lines(i).Replace("24,4,4,4,0,0,24,49,", "24,4,4,4,4,4,24,49,")
                        LineCount += 1
                    ElseIf lines(i).Contains("24,4,4,4,4,4,24,49,") Then
                        LineCount += 1
                    End If
                    If lines(i).Contains("49,8,0,0,4,4,4,8,8,40,") Then
                        lines(i) = lines(i).Replace("49,8,0,0,4,4,4,8,8,40,", "49,8,4,4,4,4,4,8,8,40,")
                        LineCount += 1
                    ElseIf lines(i).Contains("49,8,4,4,4,4,4,8,8,40,") Then
                        LineCount += 1
                    End If
                Next
                If LineCount < 4 Then
                    If MessageBox.Show("Eribu closure incomplete, continue build?", "Drill Addition Fail", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                        Return True
                    Else
                        Return False
                    End If
                End If
            End If
            IO.File.WriteAllLines(TileMapFolder & "Area1.tmx", lines)
            Return True
        Else
            MessageBox.Show("Map file not found, creation failed")
            Return False
        End If
    End Function
    Shared Function OpenElsenova(ApplyChange As Boolean)
        'Right Door
        ',235,1073742030,0,0,0,2147483661
        ',235,0,0,0,0,2147483661
        'Left Door
        '11,12,13,0,1073742030,235,0,0,0,0,
        '11,12,13,0,0,235,0,0,0,0,
        TileMapFolder = My.Settings.WorkingDecompileLocation & "OuterBeyond.EmbeddedContent.Content\Art\TileMaps\"
        If System.IO.File.Exists(TileMapFolder & "Area2.tmx") Then
            GeneralTools.MakeWriteable(TileMapFolder & "Area2.tmx")
            Dim lines() As String = IO.File.ReadAllLines(TileMapFolder & "Area2.tmx")
            Dim LineCount As Integer = 0
            If ApplyChange Then
                For i As Integer = 0 To lines.Length - 1
                    'Right Door
                    If lines(i).Contains(",235,0,0,0,0,2147483661") Then
                        lines(i) = lines(i).Replace(",235,0,0,0,0,2147483661", ",235,1073742030,0,0,0,2147483661")
                        LineCount += 1
                    ElseIf lines(i).Contains(",235,1073742030,0,0,0,2147483661") Then
                        LineCount += 1
                    End If
                    'Left Door
                    If lines(i).Contains("11,12,13,0,0,235,0,0,0,0,") Then
                        lines(i) = lines(i).Replace("11,12,13,0,0,235,0,0,0,0,", "11,12,13,0,1073742030,235,0,0,0,0,")
                        LineCount += 1
                    ElseIf lines(i).Contains("11,12,13,0,1073742030,235,0,0,0,0,") Then
                        LineCount += 1
                    End If
                    If i = lines.Length - 1 Then
                        If LineCount < 2 Then
                            If MessageBox.Show("Kilver door button addition incomplete, continue build?", "Button Stuck", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                                Return True
                            Else
                                Return False
                            End If
                        End If
                    End If
                Next
            Else ' make sure to remove change
                For i As Integer = 0 To lines.Length - 1
                    If lines(i).Contains(",235,1073742030,0,0,0,2147483661") Then
                        lines(i) = lines(i).Replace(",235,1073742030,0,0,0,2147483661", ",235,0,0,0,0,2147483661")
                        LineCount += 1
                    ElseIf lines(i).Contains(",235,0,0,0,0,2147483661") Then
                        LineCount += 1
                    End If
                    If lines(i).Contains("11,12,13,0,1073742030,235,0,0,0,0,") Then
                        lines(i) = lines(i).Replace("11,12,13,0,1073742030,235,0,0,0,0,", ",235,0,0,0,0,2147483661")
                        LineCount += 1
                    ElseIf lines(i).Contains(",235,0,0,0,0,2147483661") Then
                        LineCount += 1
                    End If
                    If i = lines.Length - 1 Then
                        If LineCount < 2 Then
                            If MessageBox.Show("Kilver door button removal incomplete, continue build?", "Button Stuck", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                                Return True
                            Else
                                Return False
                            End If
                        End If
                    End If
                Next
            End If
            IO.File.WriteAllLines(TileMapFolder & "Area2.tmx", lines)
            Return True
        Else
            MessageBox.Show("Map file not found, creation failed")
            Return False
        End If
    End Function
    Shared Function OpenAbsu(ApplyChange As Boolean)
        TileMapFolder = My.Settings.WorkingDecompileLocation & "OuterBeyond.EmbeddedContent.Content\Art\TileMaps\"
        If System.IO.File.Exists(TileMapFolder & "Area2.tmx") Then
            GeneralTools.MakeWriteable(TileMapFolder & "Area2.tmx")
            Dim lines() As String = IO.File.ReadAllLines(TileMapFolder & "Area2.tmx")
            Dim LineCount As Integer = 0
            If ApplyChange Then
                For i As Integer = 0 To lines.Length - 1
                    If lines(i).Contains(",0,645,0,645,0,545,546,") Then
                        lines(i) = lines(i).Replace(",0,645,0,645,0,545,546,", ",206,645,0,645,0,545,546,")
                        LineCount += 1
                    ElseIf lines(i).Contains(",206,645,0,645,0,545,546,") Then
                        LineCount += 1
                    End If
                    If i = lines.Length - 1 Then
                        If LineCount < 1 Then
                            If MessageBox.Show("Absu button relocation incomplete, continue build?", "Button Stuck", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                                Return True
                            Else
                                Return False
                            End If
                        End If
                    End If
                Next
            Else ' make sure to remove change
                For i As Integer = 0 To lines.Length - 1
                    If lines(i).Contains(",206,645,0,645,0,545,546,") Then
                        lines(i) = lines(i).Replace(",206,645,0,645,0,545,546,", ",0,645,0,645,0,545,546,")
                        LineCount += 1
                    ElseIf lines(i).Contains(",0,645,0,645,0,545,546,") Then
                        LineCount += 1
                    End If
                    If i = lines.Length - 1 Then
                        If LineCount < 1 Then
                            If MessageBox.Show("Absu button relocation incomplete, continue build?", "Button Stuck", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                                Return True
                            Else
                                Return False
                            End If
                        End If
                    End If
                Next
            End If
            IO.File.WriteAllLines(TileMapFolder & "Area2.tmx", lines)
            Return True
        Else
            MessageBox.Show("Map file not found, creation failed")
            Return False
        End If
    End Function
End Class
Public Class XMLEditor
    Shared Function WriteSettings(SeedNum As Long,
                                  Difficulty As Randomizer.DifficultySetting,
                                  OpenEribu1 As Boolean,
                                  OpenElsenova2 As Boolean,
                                  OpenAbsu3 As Boolean,
                                  DropDown As Boolean,
                                  Walls As Boolean,
                                  Illusion As Boolean)
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
End Class