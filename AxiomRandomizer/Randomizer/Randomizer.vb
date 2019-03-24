Imports AxiomRandomizer.GameInformation
Imports System.IO 'files
Public Class Randomizer
    'Uses the Super Metroid Randomizer as inspiration / template
    'https://github.com/Dessyreqt/smrandomizer

    Public Enum DifficultySetting
        Easy
        Normal
        Practice
        Rebuild
    End Enum
    Public Shared LocationInformation As List(Of Location)
    Public Shared ItemPool As List(Of ItemDrop)
    Public Shared PowerList As List(Of Powers)
    Public Shared MonsterList As List(Of MonsterSpawn)
    Public Shared RemovedMonsters As List(Of CreatureType)
    Public Shared Generator As System.Random
#Region "Locations"
    Shared Sub BuildLocations(Seed As Integer, Difficulty As DifficultySetting, Optional OpenEribu1 As Boolean = False, Optional OpenElseNova2 As Boolean = False, Optional OpenAbsu3 As Boolean = False)
        PowerList = New List(Of Powers)
        If Difficulty = DifficultySetting.Normal Then
            'Normal is the only that has logic for opened areas
            LocationInformation = NormalLocations.ResetLocations(OpenEribu1, OpenElseNova2, OpenAbsu3)
            ItemPool = NormalItems.ResetItemPool()
        ElseIf Difficulty = DifficultySetting.Easy Then
            LocationInformation = EasyLocations.ResetLocations()
            ItemPool = EasyItems.ResetItemPool()
        ElseIf Difficulty = DifficultySetting.Practice Then
            LocationInformation = PracticeLocations.ResetLocations() 'New List(Of Location) '
            ItemPool = PracticeItems.ResetItemPool() 'New List(Of ItemDrop) '
        ElseIf Difficulty = DifficultySetting.Rebuild Then
            MessageBox.Show("Application rebuilt from appdata.")
            Exit Sub
        End If
        RandomMenu.TextBoxDebug.Text = "New Seed: " & Seed.ToString & " Difficulty: " & Difficulty.ToString
        If OpenEribu1 Then
            RandomMenu.TextBoxDebug.Text += vbNewLine & "Eribu Open"
        Else
            RandomMenu.TextBoxDebug.Text += vbNewLine & "Eribu Closed"
        End If
        If OpenElseNova2 Then
            RandomMenu.TextBoxDebug.Text += vbNewLine & "ElseNova Open"
        Else
            RandomMenu.TextBoxDebug.Text += vbNewLine & "ElseNova Closed"
        End If
        If OpenAbsu3 Then
            RandomMenu.TextBoxDebug.Text += vbNewLine & "Absu Open"
        Else
            RandomMenu.TextBoxDebug.Text += vbNewLine & "Absu Closed"
        End If
        RandomMenu.TextBoxDebug.Text += vbNewLine & "Locations: " & LocationInformation.Count &
                                    vbNewLine & "Items: " & ItemPool.Count
        ApplyWeights(Seed)
        PlaceAssumedItems()
        'PlaceItems()
    End Sub
    Shared Sub ApplyWeights(Seed As Integer)
        Generator = New System.Random(Seed:=Seed)
        For Each TempLocation As Location In LocationInformation
            'positive numbers will stay on the location but with an added decimal places to break ties
            If TempLocation.Weight > 0 Then
                TempLocation.Weight += Generator.NextDouble()
            ElseIf TempLocation.Weight = 0 Then ' 0 will get a new number
                TempLocation.Weight = Generator.NextDouble()
            ElseIf TempLocation.Weight < 0 Then 'Negative Num
                TempLocation.Weight = (Generator.NextDouble() * (-1)) + TempLocation.Weight
            End If
        Next
        LocationInformation.Sort(Function(x, y) x.Weight.CompareTo(y.Weight))
        LocationInformation.Reverse()
        For Each TempItemDrop As ItemDrop In ItemPool
            '
            If TempItemDrop.Weight > 0 Then
                TempItemDrop.Weight += Generator.NextDouble()
            ElseIf TempItemDrop.Weight = 0 Then ' 0 will get a new number
                TempItemDrop.Weight = Generator.NextDouble()
            ElseIf TempItemDrop.Weight < 0 Then 'negative num
                TempItemDrop.Weight = (Generator.NextDouble() * (-1)) + TempItemDrop.Weight
            End If
        Next
        ItemPool.Sort(Function(x, y) x.Weight.CompareTo(y.Weight))
        ItemPool.Reverse()
        'MessageBox.Show("Weights Applied")
    End Sub
    Shared Function PlaceAssumedItems()
        Dim PlacementCount As Integer = 1
        'this has to be built to allow a resort of the item pool so it needs to be in a do while loop and start from 1 each loop..
        'this might be slightly more process intensive which is unfortunate but I want to place a random weapon first
        Do While PlacementCount <= ItemPool.Count - 1 'might need a -1 so not infinite ?????
            For i As Integer = 0 To ItemPool.Count - 1 'will go from the highest item to the lowest item.
                If ItemPool(i).Placed = False Then
                    If ItemPool(i).Name = "" Then
                        RandomMenu.TextBoxDebug.Text += vbNewLine & "Placing item: " & ItemPool(i).DropType.ToString
                    Else
                        RandomMenu.TextBoxDebug.Text += vbNewLine & "Placing item: " & ItemPool(i).Name
                    End If
                    For j As Integer = 0 To LocationInformation.Count - 1
                        If LocationInformation(j).RerollCount > 20 Then
                            RandomMenu.TextBoxDebug.Text += vbNewLine & "Infinite Loop Break"
                            If MessageBox.Show("Infinite Loop Break." & vbNewLine & "Would you like to make a log file?", "Seed Failure", MessageBoxButtons.YesNo) Then
                                Dim Logname As String = Split(RandomMenu.TextBoxDebug.Text, vbCrLf)(0)
                                Logname = Logname.Remove(0, 10) 'removes New Seed: from the string
                                Logname = Logname.Replace(":", "") 'Removes : to make the file name viable
                                Dim TempSaveDialog As SaveFileDialog = New SaveFileDialog With {.FileName = Logname & ".log"}
                                If TempSaveDialog.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                                    File.WriteAllText(TempSaveDialog.FileName, RandomMenu.TextBoxDebug.Text)
                                End If
                            End If
                            Return False
                        End If
                        If LocationInformation(j).Item = ItemType.Empty Then
                            If ItemPool(i).GivenPowers.Count > 0 Then
                                'this checks the default required powers to make it's not blocked
                                If LocationInformation(j).RequiredPowers.Contains(ItemPool(i).GivenPowers(0)) Then
                                    RandomMenu.TextBoxDebug.Text += vbNewLine & LocationInformation(j).Name & " Skipped due to required power " & ItemPool(i).GivenPowers(0).ToString
                                    LocationInformation(j).RerollCount += 1
                                    Continue For
                                Else
                                    'this checks the itererated powers to make it's not blocked
                                    If LocationInformation(j).AddedPowers.Contains(ItemPool(i).GivenPowers(0)) Then
                                        LocationInformation(j).RerollCount += 1
                                        RandomMenu.TextBoxDebug.Text += vbNewLine & LocationInformation(j).Name & " Skipped due to given power " & ItemPool(i).GivenPowers(0).ToString
                                        Continue For
                                    Else
                                        If LocationInformation(j).RequiredJump > GetJumpHeight(ItemPool(i)) Then
                                            LocationInformation(j).RerollCount += 1
                                            RandomMenu.TextBoxDebug.Text += vbNewLine & LocationInformation(j).Name & " Skipped due to jump height"
                                            Continue For
                                        Else
                                            IterateRestrictions(ItemPool(i).GivenPowers(0), LocationInformation(j).RequiredPowers)
                                            TotalAddedJump += ItemPool(i).JumpAdded
                                        End If
                                    End If
                                End If
                            End If
                            LocationInformation(j).Item = ItemPool(i).DropType
                            LocationInformation(j).ItemName = ItemPool(i).Name
                            LocationInformation(j).ItemWeight = ItemPool(i).Weight
                            LocationInformation(j).PlaceOrder = PlacementCount
                            LocationInformation(j).InGameItemID = ItemPool(i).GID + GetDefaultGID(LocationInformation(j).Region)
                            LocationInformation(j).PowersAttained = New List(Of Powers)
                            LocationInformation(j).PowersAttained.AddRange(PowerList)
                            ItemPool(i).Placed = True
                            If ItemPool(i).Name = "" Then
                                RandomMenu.TextBoxDebug.Text += vbNewLine & ItemPool(i).DropType.ToString & " Placed in: " & LocationInformation(j).Name
                            Else
                                RandomMenu.TextBoxDebug.Text += vbNewLine & ItemPool(i).Name & " Placed in: " & LocationInformation(j).Name
                            End If
                            If ItemPool(i).GivenPowers.Count > 0 Then
                                'If TempItem adds Powers.Damage then Clear all other Powers.Damage so the additional Powers of nova / kilvers are evident
                                GivePowers(ItemPool(i).GivenPowers(0))
                                If ItemPool(i).GivenPowers(0) = Powers.Damage OrElse
                                    ItemPool(i).GivenPowers(0) = Powers.Nova OrElse
                                    ItemPool(i).GivenPowers(0) = Powers.Kilver OrElse
                                    ItemPool(i).GivenPowers(0) = Powers.LongBeam Then
                                    Dim ClearPowerList As List(Of Powers) = New List(Of Powers)
                                    ClearPowerList.AddRange(ItemPool(i).GivenPowers)
                                    For Each TempPower As Powers In ClearPowerList
                                        StripPower(TempPower)
                                    Next
                                End If
                            End If
                            PlacementCount += 1
                            Exit For
                        End If
                    Next
                    'this will exit the for loop for the item so the logic can check for resorted weights.
                    Exit For
                End If
            Next
        Loop
        RandomMenu.TextBoxDebug.Text += vbNewLine & "Item placements complete"
        Return True
    End Function
    Shared TotalAddedJump As Integer = 0
    Shared Function GetJumpHeight(TestedItem As ItemDrop)
        If TestedItem.JumpAdded > 0 Then
            Dim TestReturn As Integer = 14 - TestedItem.JumpAdded - TotalAddedJump
            If TestReturn > 4 Then
                Return TestReturn
            Else
                Return 4
            End If
        Else
            Return 13
        End If
    End Function
    Shared Sub GivePowers(TestedPower As Powers)
        'This just checks the first power because only the first power is used for new logic.
        If Not PowerList.Contains(TestedPower) Then
            PowerList.Add(TestedPower)
        End If
    End Sub
    Shared Sub IterateRestrictions(RestrictedPower As Powers, ExendedRestrictions As List(Of Powers))
        For j As Integer = 0 To LocationInformation.Count - 1
            If LocationInformation(j).Item = ItemType.Empty Then
                If LocationInformation(j).RequiredPowers.Contains(RestrictedPower) Then
                    For i As Integer = 0 To ExendedRestrictions.Count - 1
                        If Not LocationInformation(j).AddedPowers.Contains(ExendedRestrictions(i)) Then
                            LocationInformation(j).AddedPowers.Add(ExendedRestrictions(i))
                        End If
                    Next
                ElseIf LocationInformation(j).AddedPowers.Contains(RestrictedPower) Then
                    For i As Integer = 0 To ExendedRestrictions.Count - 1
                        If Not LocationInformation(j).AddedPowers.Contains(ExendedRestrictions(i)) Then
                            LocationInformation(j).AddedPowers.Add(ExendedRestrictions(i))
                        End If
                    Next
                End If
            End If
        Next
    End Sub
    Shared Sub StripPower(PowertoStrip As Powers)
        For j As Integer = 0 To ItemPool.Count - 1
            If ItemPool(j).GivenPowers.Count > 0 Then
                If ItemPool(j).GivenPowers.Contains(PowertoStrip) Then
                    ItemPool(j).GivenPowers.Remove(PowertoStrip)
                    If ItemPool(j).GivenPowers.Count = 0 Then
                        ItemPool(j).Weight -= Math.Floor(ItemPool(j).Weight) ' powerless items have weight 0-1
                    Else
                        If PowertoStrip = Powers.Damage Then
                            If Not ItemPool(j).GivenPowers(0) = Powers.Nova Then
                                ItemPool(j).Weight -= 1
                            End If
                        ElseIf PowertoStrip = Powers.Nova Then
                            If ItemPool(j).GivenPowers(0) = Powers.Kilver Then
                                ItemPool(j).Weight -= 1
                            End If
                        ElseIf PowertoStrip = Powers.Kilver Then
                            If Not ItemPool(j).GivenPowers(0) = Powers.LongBeam Then
                                ItemPool(j).Weight -= Math.Floor(ItemPool(j).Weight) + 1 'Sets it to be an optional item
                            End If
                            'elseIf PowertoStrip = Powers.LongBeam Then
                        End If
                        End If
                End If
            End If
        Next
        ItemPool.Sort(Function(x, y) x.Weight.CompareTo(y.Weight))
        ItemPool.Reverse()
    End Sub
    Shared Function GetDefaultGID(AreaCheck As Area) As Integer
        If AreaCheck = Area.Eribu Then
            Return 513
        ElseIf AreaCheck = Area.Absu Then
            Return 2561
        ElseIf AreaCheck = Area.Zi Then
            Return 2049
        ElseIf AreaCheck = Area.Kur Then
            Return 2649
        ElseIf AreaCheck = Area.Indi Then
            Return 1669
        ElseIf AreaCheck = Area.UkkinNa Then
            Return 2049
        ElseIf AreaCheck = Area.Edin Then
            Return 2589
        ElseIf AreaCheck = Area.EKurMah Then
            Return 2049
        ElseIf AreaCheck = Area.MarUru Then
            Return 4681
        End If
        Return -1
    End Function
    Shared Function GetAddedLine(AreaCheck As Area) As Integer
        ' </objectgroup> line
        If AreaCheck = Area.Eribu Then
            Return 3132
        ElseIf AreaCheck = Area.Absu Then
            Return 4924
        ElseIf AreaCheck = Area.Zi Then
            Return 4987
        ElseIf AreaCheck = Area.Kur Then
            Return 4777
        ElseIf AreaCheck = Area.Indi Then
            Return 2718
        ElseIf AreaCheck = Area.UkkinNa Then 'normal
            Return 6175
        ElseIf AreaCheck = Area.Edin Then
            Return 4369
        ElseIf AreaCheck = Area.EKurMah Then
            Return 3739
        ElseIf AreaCheck = Area.MarUru Then
            Return 11956
        End If
        Return -1
    End Function
    Shared Function GetCreatureNumber(SpawnedCharacter As CreatureType)
        Dim SpawnedInt As Integer = CInt(SpawnedCharacter)
        If SpawnedInt = 0 Then
            Return 1
        ElseIf SpawnedInt < 14 Then
            Return (SpawnedInt + 4)
        ElseIf SpawnedInt < 27 Then
            Return (SpawnedInt + 5)
        ElseIf SpawnedInt < 31 Then
            Return (SpawnedInt + 102)
        ElseIf SpawnedInt < 45 Then
            Return (SpawnedInt + 103)
        ElseIf SpawnedInt < 58 Then
            Return (SpawnedInt + 104)
        ElseIf SpawnedInt < 68 Then
            Return (SpawnedInt + 105)
        ElseIf SpawnedInt < 74 Then
            Return (SpawnedInt + 106)
        ElseIf SpawnedInt < 80 Then
            Return (SpawnedInt + 108)
        Else
            Return -1
        End If
    End Function


#End Region
#Region "Monsters"
    Shared Sub ShuffleMonsters(Seed As Integer, Difficulty As DifficultySetting)
        If Difficulty = DifficultySetting.Normal Then
            MonsterList = NormalMonsters.ResetMonsters()
            RemovedMonsters = NormalMonsters.BannedMonsters()
        ElseIf Difficulty = DifficultySetting.Practice Then
            MonsterList = NormalMonsters.ResetMonsters()
            RemovedMonsters = NormalMonsters.BannedMonsters()
        End If
        For i As Integer = 0 To MonsterList.Count - 1
            Dim attempt As Integer = 0
            Do While attempt < 10
                Dim TempSpawn As CreatureType = DirectCast([Enum].Parse(GetType(CreatureType),
                                    Generator.Next(79)), CreatureType)
                If Not RemovedMonsters.Contains(TempSpawn) Then
                    MonsterList(i).Spawns = TempSpawn
                End If
                attempt += 1
                If attempt = 9 Then
                    MonsterList(i).Spawns = MonsterList(i).Vanilla
                End If
            Loop
            'If MonsterList(i).Region = Area.Indi Then
            'MessageBox.Show(MonsterList(i).Vanilla.ToString & " Replaced by " & MonsterList(i).Spawns.ToString)
            'End If
        Next
    End Sub
#End Region
End Class
