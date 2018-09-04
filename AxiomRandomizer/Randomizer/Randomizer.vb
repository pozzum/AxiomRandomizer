Imports AxiomRandomizer.GameInformation
Imports System.IO 'files
Public Class Randomizer
    'Uses the Super Metroid Randomizer as inspiration / template
    'https://github.com/Dessyreqt/smrandomizer

    Public Enum DifficultySetting
        Normal
        Practice
    End Enum
    Public Shared LocationInformation As List(Of Location)
    Public Shared ItemPool As List(Of ItemDrop)
    Public Shared PowerList As List(Of Powers)

    Shared Sub BuildLocations(Seed As Long, Difficulty As DifficultySetting)

        PowerList = New List(Of Powers)
        If Difficulty = DifficultySetting.Normal Then
            LocationInformation = NormalLocations.ResetLocations()
            ItemPool = NormalItems.ResetItemPool()
            MessageBox.Show("Locations: " & LocationInformation.Count & vbNewLine &
                            "Items: " & ItemPool.Count)
            ApplyWeights(Seed)
            PlaceItems()
        ElseIf Difficulty = DifficultySetting.Practice Then
            LocationInformation = PracticeLocations.ResetLocations() 'New List(Of Location) '
            ItemPool = PracticeItems.ResetItemPool() 'New List(Of ItemDrop) '
            MessageBox.Show("Locations: " & LocationInformation.Count & vbNewLine &
                            "Items: " & ItemPool.Count)
            ApplyWeights(Seed)
            PlaceItems()
        End If
    End Sub
    Shared Sub ApplyWeights(Seed As Integer)
        Dim Generator As System.Random = New System.Random(Seed:=Seed)
        For Each TempLocation As Location In LocationInformation
            If TempLocation.Weight = 0 Then
                TempLocation.Weight = Generator.NextDouble()
            ElseIf TempLocation.Weight < 0 Then
                TempLocation.Weight = Generator.NextDouble() * Math.Abs(TempLocation.Weight)
            End If
        Next
        LocationInformation.Sort(Function(x, y) x.Weight.CompareTo(y.Weight))
        LocationInformation.Reverse()
        For Each TempItemDrop As ItemDrop In ItemPool
            If TempItemDrop.Weight = 0 Then
                TempItemDrop.Weight = Generator.NextDouble()
            ElseIf TempItemDrop.Weight < 0 Then
                TempItemDrop.Weight = Generator.NextDouble() * Math.Abs(TempItemDrop.Weight)
            End If
        Next
        ItemPool.Sort(Function(x, y) x.Weight.CompareTo(y.Weight))
        ItemPool.Reverse()
        'MessageBox.Show("Weights Applied")
    End Sub
    Shared Function PlaceItems()
        'MessageBox.Show("Start")
        Dim NextLocation As Integer = 0
        Dim PlacementCount As Integer = 1
        For Each TempLocation In LocationInformation
            If CanAttain(TempLocation) Then
                NextLocation = LocationInformation.IndexOf(TempLocation)
            End If
        Next
        Do While PlacementCount < LocationInformation.Count
            For i As Integer = 0 To ItemPool.Count - 1
                If ItemPool(i).Placed = False Then
                    Dim LocationTest As Integer = GetNextLocation(ItemPool(i), NextLocation)
                    If Not LocationTest = -1 Then
                        If ItemPool(i).WallRestrict Then
                            If Not LocationInformation(NextLocation).RequiredPowers.Contains(Powers.LabCoat) Then
                                Continue For
                            End If
                        End If
                        LocationInformation(NextLocation).Item = ItemPool(i).DropType
                        LocationInformation(NextLocation).ItemName = ItemPool(i).Name
                        LocationInformation(NextLocation).ItemWeight = ItemPool(i).Weight
                        LocationInformation(NextLocation).PlaceOrder = PlacementCount
                        LocationInformation(NextLocation).InGameItemID = ItemPool(i).GID + GetDefaultGID(LocationInformation(NextLocation).Region)
                        GivePowers(ItemPool(i).GivenPowers)
                        LocationInformation(NextLocation).PowersAttained = PowerList
                        'MessageBox.Show(PlacementCount & vbNewLine &
                        'ItemPool(i).DropType.ToString & vbNewLine &
                        'LocationInformation(NextLocation).Name)
                        ItemPool(i).Placed = True
                        NextLocation = LocationTest
                        PlacementCount += 1
                        Exit For
                    End If
                End If
                If i = ItemPool.Count - 1 Then 'Issue with Wall restricted item being the next progression
                    'Get next wall restricted item
                    For J As Integer = 0 To ItemPool.Count - 1
                        If ItemPool(J).Placed = False AndAlso
                                ItemPool(J).WallRestrict = True Then
                            For K As Integer = 0 To LocationInformation.Count - 1
                                If LocationInformation(K).RequiredPowers.Contains(Powers.LabCoat) Then
                                    'Find old item and unplace it as long as it doesn't give powers
                                    If LocationInformation(K).ItemName = "" Then
                                        MessageBox.Show(LocationInformation(K).Item.ToString)
                                        Continue For
                                    Else
                                        MessageBox.Show("Unplacing Item")
                                        UnplaceItem(LocationInformation(K).ItemName)
                                        LocationInformation(K).Item = ItemPool(J).DropType
                                        LocationInformation(K).ItemName = ItemPool(J).Name
                                        LocationInformation(K).ItemWeight = ItemPool(J).Weight
                                        LocationInformation(K).PlaceOrder = PlacementCount
                                        LocationInformation(K).InGameItemID = ItemPool(J).GID + GetDefaultGID(LocationInformation(NextLocation).Region)
                                        GivePowers(ItemPool(J).GivenPowers)
                                        ItemPool(J).Placed = True
                                        Continue Do
                                    End If
                                End If
                            Next
                        End If
                    Next
                    Dim message As String = "Could not complete item placement" & vbNewLine &
                                     PlacementCount & " Items placed" & vbNewLine
                    For j As Integer = 0 To PowerList.Count - 1
                        message += PowerList(j).ToString & vbNewLine
                    Next
                    MessageBox.Show(message)
                    Return False
                End If
            Next
        Loop
        For i As Integer = 0 To ItemPool.Count - 1
            If ItemPool(i).Placed = False Then
                For j As Integer = 0 To LocationInformation.Count - 1
                    If LocationInformation(j).Item = ItemType.Empty Then
                        LocationInformation(j).Item = ItemPool(i).DropType
                        LocationInformation(j).ItemName = ItemPool(i).Name
                        LocationInformation(j).PlaceOrder = PlacementCount
                        LocationInformation(NextLocation).ItemWeight = ItemPool(i).Weight
                        LocationInformation(NextLocation).InGameItemID = ItemPool(i).GID + GetDefaultGID(LocationInformation(NextLocation).Region)
                        ItemPool(i).Placed = True
                    End If
                Next
            End If
        Next
        Return True
    End Function
    Shared Sub GivePowers(TestedList As List(Of Powers))
        If TestedList.Count > 0 Then
            For i As Integer = 0 To TestedList.Count - 1
                If Not PowerList.Contains(TestedList(i)) Then
                    PowerList.Add(TestedList(i))
                End If
            Next
        End If
    End Sub

    Shared Function CanAttain(CheckedLocation As Location, Optional NewItem As ItemDrop = Nothing) As Boolean
        Dim NewPowerList As List(Of Powers) = New List(Of Powers)
        NewPowerList.AddRange(PowerList)
        If NewItem IsNot Nothing Then
            NewPowerList.AddRange(NewItem.GivenPowers)
        End If
        For Each ReqPower As Powers In CheckedLocation.RequiredPowers
            If Not NewPowerList.Contains(ReqPower) Then
                Return False
            End If
        Next
        If CheckedLocation.PowerOptions.Count = 0 AndAlso
                CheckedLocation.GroupedPowers.Count = 0 Then
            Return True
        End If
        For i As Integer = 0 To CheckedLocation.PowerOptions.Count - 1
            If NewPowerList.Contains(CheckedLocation.PowerOptions(i)) Then
                Return True
            End If
        Next
        For i As Integer = 0 To CheckedLocation.GroupedPowers.Count - 1
            If Not NewPowerList.Contains(CheckedLocation.GroupedPowers(i)) Then
                Return False
            End If
        Next

        'Already Passed Reqs and has all Optionals
        Return True
    End Function

    Shared Function GetNextLocation(TestedItem As ItemDrop, TestedIndex As Integer) As Integer
        For Each TempLocation In LocationInformation
            If TempLocation.Item = ItemType.Empty Then
                If CanAttain(TempLocation, TestedItem) Then
                    If Not LocationInformation.IndexOf(TempLocation) = TestedIndex Then
                        Return LocationInformation.IndexOf(TempLocation)
                    End If
                End If
            End If
        Next
        Return -1
    End Function
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
    Shared Sub UnplaceItem(ItemName As String)
        For i As Integer = 0 To ItemPool.Count - 1
            If ItemPool(i).Name = ItemName Then
                ItemPool(i).Placed = False
            End If
        Next
    End Sub
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

    Shared Sub ExportLocations(SentPath As String)
        Dim SavedPath As String
        If SentPath.EndsWith(".xml") Then
            SavedPath = SentPath
        ElseIf SentPath.EndsWith(".exe") Then
            SavedPath = Path.GetDirectoryName(SentPath) & Path.DirectorySeparatorChar &
                My.Settings.PreviousSeed.ToString & ".xml"
        Else
            SavedPath = SentPath & Path.DirectorySeparatorChar &
               My.Settings.PreviousSeed.ToString & ".xml"
        End If
        Dim writer As New System.Xml.Serialization.XmlSerializer(GetType(List(Of Location)))
        Dim file As New System.IO.StreamWriter(
            SavedPath)
        writer.Serialize(file, LocationInformation)
        file.Close()
    End Sub
    Shared Sub ImportLocations(SentPath As String)
        Dim reader As New System.Xml.Serialization.XmlSerializer(GetType(List(Of Location)))
        Dim file As New System.IO.StreamReader(
            SentPath)
        LocationInformation = reader.Deserialize(file)
        'reader.Deserialize(file, LocationInformation)
        file.Close()
    End Sub
End Class
