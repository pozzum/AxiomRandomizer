Namespace GameInformation
    'Uses the Super Metroid Randomizer as inspiration / template
    'https://github.com/Dessyreqt/smrandomizer
#Region "Classes"
    Public Enum Area
        Eribu 'Area1
        Absu 'Area2
        Zi 'Area3
        Kur 'Area4
        Indi 'Area5
        UkkinNa 'Area6
        Edin 'Area7
        EKurMah 'Area8
        MarUru 'Area9
    End Enum
    Public Class Location
        Public Name As String
        Public Vanilla As ItemType
        Public VanillaPlacement As Integer
        Public Region As Area
        Public LineNumber1 As Integer
        Public XLocation As Integer
        Public YLocation As Integer
        Public RequiredPowers As List(Of Powers)
        Public RequiredJump As Integer = 4 'Default Jump Height
        Public AddedJump As Integer = 0 'Allows us to add additional jump
        Public AddedPowers As List(Of Powers)
        Public MapOptionPowers As List(Of Powers)
        Public Weight As Double
        Public Item As ItemType
        Public PlacedItems As List(Of ItemType)
        Public ItemName As String = "" 'Required for nodes to save
        Public PlaceOrder As Integer
        Public RerollCount As Integer = 0
        Public ItemWeight As Double
        Public InGameItemID As Integer
        Public AddedDrop As Boolean = False
        Public PowersAttained As List(Of Powers)
    End Class
#End Region
#Region "Difficulty Classes"
    Public Class EasyLocations
        Public Shared Function ResetLocations(Optional OpenEribu1 As Boolean = False, Optional OpenAbsu2 As Boolean = False)
            Dim Locations As List(Of Location)
            Locations = New List(Of Location)

            Dim TempLocation As Location
#Region "Start Progression"
            'Eribu
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Left From Start"
            TempLocation.Vanilla = ItemType.DataDisruptor
            TempLocation.VanillaPlacement = 1
            TempLocation.Region = Area.Eribu
            TempLocation.LineNumber1 = 2923
            TempLocation.XLocation = 4064
            TempLocation.YLocation = 3184
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Red Ruins"
            TempLocation.Vanilla = ItemType.Nova
            TempLocation.VanillaPlacement = 2
            TempLocation.Region = Area.Eribu
            TempLocation.LineNumber1 = 2937
            TempLocation.XLocation = 8880
            TempLocation.YLocation = 1232
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
#End Region
#Region "Nova Progression"
            'Eribu
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Red Stalagmites"
            TempLocation.Vanilla = ItemType.SizeNode
            TempLocation.VanillaPlacement = 3
            TempLocation.Region = Area.Eribu
            TempLocation.LineNumber1 = 3035
            TempLocation.XLocation = 5024
            TempLocation.YLocation = 2096
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "After Xedur"
            TempLocation.Vanilla = ItemType.Drill
            TempLocation.VanillaPlacement = 4
            TempLocation.Region = Area.Eribu
            TempLocation.LineNumber1 = 2945
            TempLocation.XLocation = 8960
            TempLocation.YLocation = 2672
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
#End Region
#Region "Drill Progression"
            'Eribu
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Drilled Under Xedur"
            TempLocation.Vanilla = ItemType.PowerNode
            TempLocation.VanillaPlacement = 5
            TempLocation.Region = Area.Eribu
            TempLocation.LineNumber1 = 2938
            TempLocation.XLocation = 8016
            TempLocation.YLocation = 2928
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Upper Left Platforms"
            TempLocation.Vanilla = ItemType.MultiDisruptor
            TempLocation.VanillaPlacement = 6
            TempLocation.Region = Area.Eribu
            TempLocation.LineNumber1 = 3025
            TempLocation.XLocation = 5504
            TempLocation.YLocation = 1472
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Entering Absu"
            TempLocation.Vanilla = ItemType.HealthNode
            TempLocation.VanillaPlacement = 7
            TempLocation.Region = Area.Eribu
            TempLocation.LineNumber1 = 3000
            TempLocation.XLocation = 8384
            TempLocation.YLocation = 5072
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            'Absu
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Drilled Shaft"
            TempLocation.Vanilla = ItemType.HealthNodeFragment
            TempLocation.VanillaPlacement = 8
            TempLocation.Region = Area.Absu
            TempLocation.LineNumber1 = 5277
            TempLocation.XLocation = 2032
            TempLocation.YLocation = 1744
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Elsenova"
            TempLocation.Vanilla = ItemType.Kilver
            TempLocation.VanillaPlacement = 9
            TempLocation.Region = Area.Absu
            TempLocation.LineNumber1 = 5137
            TempLocation.XLocation = 4064
            TempLocation.YLocation = 2304
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
#End Region
#Region "Kilver Progression"
            'Absu
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Behind Kilver Door"
            TempLocation.Vanilla = ItemType.HealthNodeFragment
            TempLocation.VanillaPlacement = 10
            TempLocation.Region = Area.Absu
            TempLocation.LineNumber1 = 5279
            TempLocation.XLocation = 3104
            TempLocation.YLocation = 1056
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "After Telal"
            TempLocation.Vanilla = ItemType.AddressDisruptor1
            TempLocation.VanillaPlacement = 11
            TempLocation.Region = Area.Absu
            TempLocation.LineNumber1 = 5325
            TempLocation.XLocation = 6608
            TempLocation.YLocation = 1808
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.AddedPowers.AddRange({Powers.Glitch1, Powers.Grapple, Powers.LongBeam})
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
#End Region
#Region "Address Disruptor 1 Progression"
            'Eribu
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Guarded by Ghouls"
            TempLocation.Vanilla = ItemType.HealthNodeFragment
            TempLocation.VanillaPlacement = 12
            TempLocation.Region = Area.Eribu
            TempLocation.LineNumber1 = 3026
            TempLocation.XLocation = 7040
            TempLocation.YLocation = 4944
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch1})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            'Absu
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Far Left Hallway"
            TempLocation.Vanilla = ItemType.PowerNodeFragment
            TempLocation.VanillaPlacement = 13
            TempLocation.Region = Area.Absu
            TempLocation.LineNumber1 = 5415
            TempLocation.XLocation = 176
            TempLocation.YLocation = 2112
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch1})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Middle of Lower Shaft"
            TempLocation.Vanilla = ItemType.HealthNode
            TempLocation.VanillaPlacement = 14
            TempLocation.Region = Area.Absu
            TempLocation.LineNumber1 = 5242
            TempLocation.XLocation = 7392
            TempLocation.YLocation = 2176
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch1})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Purple Corrupted Diatom"
            TempLocation.Vanilla = ItemType.SizeNode
            TempLocation.VanillaPlacement = 15
            TempLocation.Region = Area.Absu
            TempLocation.LineNumber1 = 5320
            TempLocation.XLocation = 7344
            TempLocation.YLocation = 2816
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch1})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Pink Vines"
            TempLocation.Vanilla = ItemType.Lore
            TempLocation.VanillaPlacement = 16
            TempLocation.Region = Area.Absu
            TempLocation.LineNumber1 = 5410
            TempLocation.XLocation = 6464
            TempLocation.YLocation = 3088
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch1})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Green Squid Room"
            TempLocation.Vanilla = ItemType.Lore
            TempLocation.VanillaPlacement = 17
            TempLocation.Region = Area.Absu
            TempLocation.LineNumber1 = 5411
            TempLocation.XLocation = 9072
            TempLocation.YLocation = 2592
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch1})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Remote Detonation"
            TempLocation.Vanilla = ItemType.HealthNodeFragment
            TempLocation.VanillaPlacement = 18
            TempLocation.Region = Area.Absu
            TempLocation.LineNumber1 = 5278
            TempLocation.XLocation = 10512
            TempLocation.YLocation = 2912
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch1})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Exit to Zi"
            TempLocation.Vanilla = ItemType.PowerNode
            TempLocation.VanillaPlacement = 19
            TempLocation.Region = Area.Absu
            TempLocation.LineNumber1 = 5158
            TempLocation.XLocation = 11824
            TempLocation.YLocation = 3488
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch1})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            'Kur
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Below Cavern"
            TempLocation.Vanilla = ItemType.HighJump
            TempLocation.VanillaPlacement = 20
            TempLocation.Region = Area.Kur
            TempLocation.LineNumber1 = 4673
            TempLocation.XLocation = 2640
            TempLocation.YLocation = 6704
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch1})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
#End Region
#Region "High Jump Progression"
            'Zi
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Above Ruggs"
            TempLocation.Vanilla = ItemType.HealthNodeFragment
            TempLocation.VanillaPlacement = 21
            TempLocation.Region = Area.Zi
            TempLocation.LineNumber1 = 4908
            TempLocation.XLocation = 2480
            TempLocation.YLocation = 2864
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch1, Powers.HighJump})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "High Jump Bypass"
            TempLocation.Vanilla = ItemType.Lore
            TempLocation.VanillaPlacement = 22
            TempLocation.Region = Area.Zi
            TempLocation.LineNumber1 = 4940
            TempLocation.XLocation = 3776
            TempLocation.YLocation = 864
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch1, Powers.HighJump})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "After Uruku"
            TempLocation.Vanilla = ItemType.GlitchTeleport
            TempLocation.VanillaPlacement = 23
            TempLocation.Region = Area.Zi
            TempLocation.LineNumber1 = 4896
            TempLocation.XLocation = 6000
            TempLocation.YLocation = 480
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch1, Powers.HighJump})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            'Kur
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Hidden in Cavern"
            TempLocation.Vanilla = ItemType.FireWall
            TempLocation.VanillaPlacement = 24
            TempLocation.Region = Area.Kur
            TempLocation.LineNumber1 = 4906
            TempLocation.XLocation = 1952
            TempLocation.YLocation = 6128
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch1, Powers.HighJump})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
#End Region
#Region "Modified Lab Coat Progression"
            'Absu
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Jail Cell"
            TempLocation.Vanilla = ItemType.Lore
            TempLocation.VanillaPlacement = 25
            TempLocation.Region = Area.Absu
            TempLocation.LineNumber1 = 5414
            TempLocation.XLocation = 3424
            TempLocation.YLocation = 2960
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch1, Powers.HighJump, Powers.LabCoat})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Lowest Room"
            TempLocation.Vanilla = ItemType.Lore
            TempLocation.VanillaPlacement = 26
            TempLocation.Region = Area.Absu
            TempLocation.LineNumber1 = 5408
            TempLocation.XLocation = 3520
            TempLocation.YLocation = 4016
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch1, Powers.HighJump, Powers.LabCoat})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Green Fungus Secret"
            TempLocation.Vanilla = ItemType.RangeNode
            TempLocation.VanillaPlacement = 27
            TempLocation.Region = Area.Absu
            TempLocation.LineNumber1 = 5324
            TempLocation.XLocation = 8400
            TempLocation.YLocation = 3152
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch1, Powers.HighJump, Powers.LabCoat})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            'Zi
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Center Steam Room"
            TempLocation.Vanilla = ItemType.RangeNode
            TempLocation.VanillaPlacement = 28
            TempLocation.Region = Area.Zi
            TempLocation.LineNumber1 = 4907
            TempLocation.XLocation = 1472
            TempLocation.YLocation = 3120
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch1, Powers.HighJump, Powers.LabCoat})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Steam Secret"
            TempLocation.Vanilla = ItemType.TendrilsTop
            TempLocation.VanillaPlacement = 29
            TempLocation.Region = Area.Zi
            TempLocation.LineNumber1 = 4592
            TempLocation.XLocation = 1184
            TempLocation.YLocation = 2592
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch1, Powers.HighJump, Powers.LabCoat})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Filtration Preview"
            TempLocation.Vanilla = ItemType.HealthNodeFragment
            TempLocation.VanillaPlacement = 30
            TempLocation.Region = Area.Zi
            TempLocation.LineNumber1 = 4897
            TempLocation.XLocation = 4560
            TempLocation.YLocation = 1280
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch1, Powers.HighJump, Powers.LabCoat})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "High Jump Access"
            TempLocation.Vanilla = ItemType.SizeNode
            TempLocation.VanillaPlacement = 31
            TempLocation.Region = Area.Zi
            TempLocation.LineNumber1 = 4906
            TempLocation.XLocation = 4032
            TempLocation.YLocation = 2224
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch1, Powers.HighJump, Powers.LabCoat})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Boss Room"
            TempLocation.Vanilla = ItemType.HealthNode
            TempLocation.VanillaPlacement = 32
            TempLocation.Region = Area.Zi
            TempLocation.LineNumber1 = 4893
            TempLocation.XLocation = 4736
            TempLocation.YLocation = 336
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch1, Powers.HighJump, Powers.LabCoat})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            'Kur
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Near Indi Exit"
            TempLocation.Vanilla = ItemType.PowerNode 'PowerNode3
            TempLocation.VanillaPlacement = 33
            TempLocation.Region = Area.Kur
            TempLocation.LineNumber1 = 4719
            TempLocation.XLocation = 240
            TempLocation.YLocation = 5840
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch1, Powers.HighJump, Powers.LabCoat})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Wall Blocked Slope Room"
            TempLocation.Vanilla = ItemType.DroneGun
            TempLocation.VanillaPlacement = 34
            TempLocation.Region = Area.Kur
            TempLocation.LineNumber1 = 4782
            TempLocation.XLocation = 3104
            TempLocation.YLocation = 3456
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch1, Powers.HighJump, Powers.LabCoat})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
#End Region
#Region "Drone Progression"
            'Absu
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Drone by Skeleton"
            TempLocation.Vanilla = ItemType.Lore
            TempLocation.VanillaPlacement = 35
            TempLocation.Region = Area.Absu
            TempLocation.LineNumber1 = 5409
            TempLocation.XLocation = 1200
            TempLocation.YLocation = 2576
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch1, Powers.HighJump, Powers.LabCoat, Powers.Drone})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Attic Left"
            TempLocation.Vanilla = ItemType.PowerNodeFragment
            TempLocation.VanillaPlacement = 36
            TempLocation.Region = Area.Absu
            TempLocation.LineNumber1 = 5357
            TempLocation.XLocation = 3600
            TempLocation.YLocation = 576
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch1, Powers.HighJump, Powers.LabCoat, Powers.Drone})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Chasm Tunnel"
            TempLocation.Vanilla = ItemType.Lore
            TempLocation.VanillaPlacement = 37
            TempLocation.Region = Area.Absu
            TempLocation.LineNumber1 = 5413
            TempLocation.XLocation = 9232
            TempLocation.YLocation = 3472
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch1, Powers.HighJump, Powers.LabCoat, Powers.Drone})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Boss Secret"
            TempLocation.Vanilla = ItemType.HealthNodeFragment
            TempLocation.VanillaPlacement = 38
            TempLocation.Region = Area.Absu
            TempLocation.LineNumber1 = 5358
            TempLocation.XLocation = 8400
            TempLocation.YLocation = 128
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch1, Powers.HighJump, Powers.LabCoat, Powers.Drone})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            'Zi
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Bottom Arterial Shaft"
            TempLocation.Vanilla = ItemType.HealthNodeFragment
            TempLocation.VanillaPlacement = 39
            TempLocation.Region = Area.Zi
            TempLocation.LineNumber1 = 4949
            TempLocation.XLocation = 5040
            TempLocation.YLocation = 2656
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch1, Powers.HighJump, Powers.LabCoat, Powers.Drone})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Veruska Secret"
            TempLocation.Vanilla = ItemType.PasswordTool
            TempLocation.VanillaPlacement = 40
            TempLocation.Region = Area.Zi
            TempLocation.LineNumber1 = 4909
            TempLocation.XLocation = 4064
            TempLocation.YLocation = 3408
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch1, Powers.HighJump, Powers.LabCoat, Powers.Drone})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Veruska Basement"
            TempLocation.Vanilla = ItemType.Lore
            TempLocation.VanillaPlacement = 41
            TempLocation.Region = Area.Zi
            TempLocation.LineNumber1 = 4939
            TempLocation.XLocation = 5168
            TempLocation.YLocation = 3488
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch1, Powers.HighJump, Powers.LabCoat, Powers.Drone})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Maintenance Secret"
            TempLocation.Vanilla = ItemType.Lore
            TempLocation.VanillaPlacement = 42
            TempLocation.Region = Area.Zi
            TempLocation.LineNumber1 = 4941
            TempLocation.XLocation = 816
            TempLocation.YLocation = 1552
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch1, Powers.HighJump, Powers.LabCoat, Powers.Drone})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Maintenance Tunnel"
            TempLocation.Vanilla = ItemType.Voranj
            TempLocation.VanillaPlacement = 43
            TempLocation.Region = Area.Zi
            TempLocation.LineNumber1 = 4911
            TempLocation.XLocation = 2160
            TempLocation.YLocation = 1840
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch1, Powers.HighJump, Powers.LabCoat, Powers.Drone})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            'Kur
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Drilled High Jump"
            TempLocation.Vanilla = ItemType.HealthNodeFragment
            TempLocation.VanillaPlacement = 44
            TempLocation.Region = Area.Kur
            TempLocation.LineNumber1 = 4803
            TempLocation.XLocation = 2816
            TempLocation.YLocation = 5872
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch1, Powers.HighJump, Powers.LabCoat, Powers.Drone})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Thorn Maze Secret"
            TempLocation.Vanilla = ItemType.VerticalSpread
            TempLocation.VanillaPlacement = 45
            TempLocation.Region = Area.Kur
            TempLocation.LineNumber1 = 4957
            TempLocation.XLocation = 2640
            TempLocation.YLocation = 4208
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch1, Powers.HighJump, Powers.LabCoat, Powers.Drone})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Grappled Mountain Slope"
            TempLocation.Vanilla = ItemType.HealthNodeFragment
            TempLocation.VanillaPlacement = 46
            TempLocation.Region = Area.Kur
            TempLocation.LineNumber1 = 4785
            TempLocation.XLocation = 1728
            TempLocation.YLocation = 3184
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch1, Powers.HighJump, Powers.LabCoat, Powers.Drone})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Drone Runs"
            TempLocation.Vanilla = ItemType.AddressDisruptor2
            TempLocation.VanillaPlacement = 47
            TempLocation.Region = Area.Kur
            TempLocation.LineNumber1 = 4931
            TempLocation.XLocation = 704
            TempLocation.YLocation = 6704
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch1, Powers.HighJump, Powers.LabCoat, Powers.Drone})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            'Indi
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Near Eribu"
            TempLocation.Vanilla = ItemType.Lore
            TempLocation.VanillaPlacement = 48
            TempLocation.Region = Area.Indi
            TempLocation.LineNumber1 = 2580
            TempLocation.XLocation = 128
            TempLocation.YLocation = 608
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch1, Powers.HighJump, Powers.LabCoat, Powers.Drone})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
#End Region
#Region "Address Disruptor 2 Progression"
            'Absu
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Upper Attic"
            TempLocation.Vanilla = ItemType.PowerNodeFragment
            TempLocation.VanillaPlacement = 49
            TempLocation.Region = Area.Absu
            TempLocation.LineNumber1 = 5355
            TempLocation.XLocation = 4544
            TempLocation.YLocation = 480
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch2, Powers.HighJump, Powers.LabCoat, Powers.Drone})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Right Attic"
            TempLocation.Vanilla = ItemType.PowerNodeFragment
            TempLocation.VanillaPlacement = 50
            TempLocation.Region = Area.Absu
            TempLocation.LineNumber1 = 5354
            TempLocation.XLocation = 5152
            TempLocation.YLocation = 448
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch2, Powers.HighJump, Powers.LabCoat, Powers.Drone})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Lower Right Corrupted"
            TempLocation.Vanilla = ItemType.InertialPulse
            TempLocation.VanillaPlacement = 51
            TempLocation.Region = Area.Absu
            TempLocation.LineNumber1 = 5359
            TempLocation.XLocation = 11744
            TempLocation.YLocation = 2304
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch2, Powers.HighJump, Powers.LabCoat, Powers.Drone})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            'Zi
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Eye Stalk Secret"
            TempLocation.Vanilla = ItemType.PowerNodeFragment
            TempLocation.VanillaPlacement = 52
            TempLocation.Region = Area.Zi
            TempLocation.LineNumber1 = 4910
            TempLocation.XLocation = 240
            TempLocation.YLocation = 2336
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch2, Powers.HighJump, Powers.LabCoat, Powers.Drone})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            'Kur
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Above Lair"
            TempLocation.Vanilla = ItemType.HealthNodeFragment
            TempLocation.VanillaPlacement = 53
            TempLocation.Region = Area.Kur
            TempLocation.LineNumber1 = 4791
            TempLocation.XLocation = 3120
            TempLocation.YLocation = 4320
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch2, Powers.HighJump, Powers.LabCoat, Powers.Drone})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Lair Secret"
            TempLocation.Vanilla = ItemType.HealthNode
            TempLocation.VanillaPlacement = 54
            TempLocation.Region = Area.Kur
            TempLocation.LineNumber1 = 4846
            TempLocation.XLocation = 4544
            TempLocation.YLocation = 3200
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch2, Powers.HighJump, Powers.LabCoat, Powers.Drone})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Climb out of the Pit"
            TempLocation.Vanilla = ItemType.Grapple
            TempLocation.VanillaPlacement = 55
            TempLocation.Region = Area.Kur
            TempLocation.LineNumber1 = 4781
            TempLocation.XLocation = 8048
            TempLocation.YLocation = 2016
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch2, Powers.HighJump, Powers.LabCoat, Powers.Drone})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
#End Region
#Region "Grapple Progression"
            'Eribu
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Under Water"
            TempLocation.Vanilla = ItemType.HealthNodeFragment
            TempLocation.VanillaPlacement = 56
            TempLocation.Region = Area.Eribu
            TempLocation.LineNumber1 = 3058
            TempLocation.XLocation = 2272
            TempLocation.YLocation = 3136
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch2, Powers.HighJump, Powers.LabCoat, Powers.Drone, Powers.Grapple})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            'Zi
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Filtration Up High"
            TempLocation.Vanilla = ItemType.PowerNodeFragment
            TempLocation.VanillaPlacement = 57
            TempLocation.Region = Area.Zi
            TempLocation.LineNumber1 = 4948
            TempLocation.XLocation = 5632
            TempLocation.YLocation = 128
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch2, Powers.HighJump, Powers.LabCoat, Powers.Drone, Powers.Grapple})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            'Kur
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Stalagmite Maze"
            TempLocation.Vanilla = ItemType.TetheredCharge
            TempLocation.VanillaPlacement = 58
            TempLocation.Region = Area.Kur
            TempLocation.LineNumber1 = 4975
            TempLocation.XLocation = 4560
            TempLocation.YLocation = 6656
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch2, Powers.HighJump, Powers.LabCoat, Powers.Drone, Powers.Grapple})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Hidden Ice Crags"
            TempLocation.Vanilla = ItemType.Lore
            TempLocation.VanillaPlacement = 59
            TempLocation.Region = Area.Kur
            TempLocation.LineNumber1 = 4953
            TempLocation.XLocation = 4192
            TempLocation.YLocation = 2304
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch2, Powers.HighJump, Powers.LabCoat, Powers.Drone, Powers.Grapple})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Hidden Stalagmite"
            TempLocation.Vanilla = ItemType.HealthNodeFragment
            TempLocation.VanillaPlacement = 60
            TempLocation.Region = Area.Kur
            TempLocation.LineNumber1 = 4911
            TempLocation.XLocation = 4576
            TempLocation.YLocation = 2096
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch2, Powers.HighJump, Powers.LabCoat, Powers.Drone, Powers.Grapple})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Above Grapple"
            TempLocation.Vanilla = ItemType.HealthNodeFragment
            TempLocation.VanillaPlacement = 61
            TempLocation.Region = Area.Kur
            TempLocation.LineNumber1 = 4853
            TempLocation.XLocation = 7984
            TempLocation.YLocation = 1680
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch2, Powers.HighJump, Powers.LabCoat, Powers.Drone, Powers.Grapple})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Crumbling Blocks"
            TempLocation.Vanilla = ItemType.PowerNode
            TempLocation.VanillaPlacement = 62
            TempLocation.Region = Area.Kur
            TempLocation.LineNumber1 = 4847
            TempLocation.XLocation = 7760
            TempLocation.YLocation = 1264
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch2, Powers.HighJump, Powers.LabCoat, Powers.Drone, Powers.Grapple})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "High Up Ice Crags"
            TempLocation.Vanilla = ItemType.Lore
            TempLocation.VanillaPlacement = 63
            TempLocation.Region = Area.Kur
            TempLocation.LineNumber1 = 4952
            TempLocation.XLocation = 2016
            TempLocation.YLocation = 1632
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch2, Powers.HighJump, Powers.LabCoat, Powers.Drone, Powers.Grapple})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Higher Up Ice Crags"
            TempLocation.Vanilla = ItemType.PowerNodeFragment
            TempLocation.VanillaPlacement = 64
            TempLocation.Region = Area.Kur
            TempLocation.LineNumber1 = 4958
            TempLocation.XLocation = 2176
            TempLocation.YLocation = 1440
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch2, Powers.HighJump, Powers.LabCoat, Powers.Drone, Powers.Grapple})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Above Stalagmites"
            TempLocation.Vanilla = ItemType.Reflect
            TempLocation.VanillaPlacement = 65
            TempLocation.Region = Area.Kur
            TempLocation.LineNumber1 = 4929
            TempLocation.XLocation = 5504
            TempLocation.YLocation = 1472
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch2, Powers.HighJump, Powers.LabCoat, Powers.Drone, Powers.Grapple})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Ice Crag Ruins"
            TempLocation.Vanilla = ItemType.EnhancedLaunch
            TempLocation.VanillaPlacement = 66
            TempLocation.Region = Area.Kur
            TempLocation.LineNumber1 = 4928
            TempLocation.XLocation = 5024
            TempLocation.YLocation = 1792
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch2, Powers.HighJump, Powers.LabCoat, Powers.Drone, Powers.Grapple})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
#End Region
#Region "Enhanced Drone Launch Progression"
            'Ukkin-Na
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Above Insanity"
            TempLocation.Vanilla = ItemType.BlackCoat
            TempLocation.VanillaPlacement = 67
            TempLocation.Region = Area.UkkinNa
            TempLocation.LineNumber1 = 6147
            TempLocation.XLocation = 3616
            TempLocation.YLocation = 2672
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch2, Powers.HighJump, Powers.LabCoat, Powers.Drone, Powers.Grapple, Powers.EnhancedLaunch})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
#End Region
#Region "Trenchcoat Progression"
            'Absu
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Below Corruption"
            TempLocation.Vanilla = ItemType.RangeNode
            TempLocation.VanillaPlacement = 68
            TempLocation.Region = Area.Absu
            TempLocation.LineNumber1 = 5412
            TempLocation.XLocation = 3488
            TempLocation.YLocation = 3152
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch2, Powers.HighJump, Powers.TrenchCoat, Powers.Drone, Powers.Grapple, Powers.EnhancedLaunch})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Lava Secret"
            TempLocation.Vanilla = ItemType.PowerNodeFragment
            TempLocation.VanillaPlacement = 69
            TempLocation.Region = Area.Absu
            TempLocation.LineNumber1 = 5423
            TempLocation.XLocation = 10800
            TempLocation.YLocation = 3744
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch2, Powers.HighJump, Powers.TrenchCoat, Powers.Drone, Powers.Grapple, Powers.EnhancedLaunch})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            'Kur
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Top of Kur"
            TempLocation.Vanilla = ItemType.Lore
            TempLocation.VanillaPlacement = 70
            TempLocation.Region = Area.Kur
            TempLocation.LineNumber1 = 4956
            TempLocation.XLocation = 3424
            TempLocation.YLocation = 576
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch2, Powers.HighJump, Powers.TrenchCoat, Powers.Drone, Powers.Grapple, Powers.EnhancedLaunch})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            'Indi
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Exit to Indi"
            TempLocation.Vanilla = ItemType.PowerNodeFragment
            TempLocation.VanillaPlacement = 71
            TempLocation.Region = Area.Eribu
            TempLocation.LineNumber1 = 3085
            TempLocation.XLocation = 8464
            TempLocation.YLocation = 4416
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch2, Powers.HighJump, Powers.TrenchCoat, Powers.Drone, Powers.Grapple, Powers.EnhancedLaunch})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Near Edin"
            TempLocation.Vanilla = ItemType.Lore
            TempLocation.VanillaPlacement = 72
            TempLocation.Region = Area.Indi
            TempLocation.LineNumber1 = 2578
            TempLocation.XLocation = 11344
            TempLocation.YLocation = 336
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch2, Powers.HighJump, Powers.TrenchCoat, Powers.Drone, Powers.Grapple, Powers.EnhancedLaunch})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            'Ukkin-Na
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Hidden Maddness"
            TempLocation.Vanilla = ItemType.Lore
            TempLocation.VanillaPlacement = 73
            TempLocation.Region = Area.UkkinNa
            TempLocation.LineNumber1 = 6164
            TempLocation.XLocation = 2928
            TempLocation.YLocation = 4256
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch2, Powers.HighJump, Powers.TrenchCoat, Powers.Drone, Powers.Grapple, Powers.EnhancedLaunch})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Wall Blocked Insanity"
            TempLocation.Vanilla = ItemType.PowerNodeFragment
            TempLocation.VanillaPlacement = 74
            TempLocation.Region = Area.UkkinNa
            TempLocation.LineNumber1 = 6167
            TempLocation.XLocation = 3456
            TempLocation.YLocation = 3456
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch2, Powers.HighJump, Powers.TrenchCoat, Powers.Drone, Powers.Grapple, Powers.EnhancedLaunch})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Hidden Psychosis"
            TempLocation.Vanilla = ItemType.PowerNodeFragment
            TempLocation.VanillaPlacement = 75
            TempLocation.Region = Area.UkkinNa
            TempLocation.LineNumber1 = 6168
            TempLocation.XLocation = 4528
            TempLocation.YLocation = 2080
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch2, Powers.HighJump, Powers.TrenchCoat, Powers.Drone, Powers.Grapple, Powers.EnhancedLaunch})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Below Pep talk"
            TempLocation.Vanilla = ItemType.HealthNodeFragment
            TempLocation.VanillaPlacement = 76
            TempLocation.Region = Area.UkkinNa
            TempLocation.LineNumber1 = 6140
            TempLocation.XLocation = 3744
            TempLocation.YLocation = 1568
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch2, Powers.HighJump, Powers.TrenchCoat, Powers.Drone, Powers.Grapple, Powers.EnhancedLaunch})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Right of Ophelia"
            TempLocation.Vanilla = ItemType.HealthNode
            TempLocation.VanillaPlacement = 77
            TempLocation.Region = Area.UkkinNa
            TempLocation.LineNumber1 = 6137
            TempLocation.XLocation = 1648
            TempLocation.YLocation = 2208
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch2, Powers.HighJump, Powers.TrenchCoat, Powers.Drone, Powers.Grapple, Powers.EnhancedLaunch})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Above Ophelia"
            TempLocation.Vanilla = ItemType.Lore
            TempLocation.VanillaPlacement = 78
            TempLocation.Region = Area.UkkinNa
            TempLocation.LineNumber1 = 6163
            TempLocation.XLocation = 1312
            TempLocation.YLocation = 1648
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch2, Powers.HighJump, Powers.TrenchCoat, Powers.Drone, Powers.Grapple, Powers.EnhancedLaunch})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Drop Below Ophelia"
            TempLocation.Vanilla = ItemType.Lore
            TempLocation.VanillaPlacement = 79
            TempLocation.Region = Area.UkkinNa
            TempLocation.LineNumber1 = 6162
            TempLocation.XLocation = 1664
            TempLocation.YLocation = 4384
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch2, Powers.HighJump, Powers.TrenchCoat, Powers.Drone, Powers.Grapple, Powers.EnhancedLaunch})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Above Waiter"
            TempLocation.Vanilla = ItemType.HealthNodeFragment
            TempLocation.VanillaPlacement = 80
            TempLocation.Region = Area.UkkinNa
            TempLocation.LineNumber1 = 6145
            TempLocation.XLocation = 1728
            TempLocation.YLocation = 4608
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch2, Powers.HighJump, Powers.TrenchCoat, Powers.Drone, Powers.Grapple, Powers.EnhancedLaunch})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            'Edin
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Hangar Entrance"
            TempLocation.Vanilla = ItemType.Lore
            TempLocation.VanillaPlacement = 81
            TempLocation.Region = Area.Edin
            TempLocation.LineNumber1 = 4362
            TempLocation.XLocation = 6160
            TempLocation.YLocation = 3200
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch2, Powers.HighJump, Powers.TrenchCoat, Powers.Drone, Powers.Grapple, Powers.EnhancedLaunch})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Western Hangar Entrance"
            TempLocation.Vanilla = ItemType.Lore
            TempLocation.VanillaPlacement = 82
            TempLocation.Region = Area.Edin
            TempLocation.LineNumber1 = 4361
            TempLocation.XLocation = 5584
            TempLocation.YLocation = 2928
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch2, Powers.HighJump, Powers.TrenchCoat, Powers.Drone, Powers.Grapple, Powers.EnhancedLaunch})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Above Clone Entrance"
            TempLocation.Vanilla = ItemType.HealthNodeFragment
            TempLocation.VanillaPlacement = 83
            TempLocation.Region = Area.Edin
            TempLocation.LineNumber1 = 4367
            TempLocation.XLocation = 5456
            TempLocation.YLocation = 2160
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch2, Powers.HighJump, Powers.TrenchCoat, Powers.Drone, Powers.Grapple, Powers.EnhancedLaunch})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Hangar Foyer"
            TempLocation.Vanilla = ItemType.DistortionField
            TempLocation.VanillaPlacement = 84
            TempLocation.Region = Area.Edin
            TempLocation.LineNumber1 = 4330
            TempLocation.XLocation = 6000
            TempLocation.YLocation = 1872
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch2, Powers.HighJump, Powers.TrenchCoat, Powers.Drone, Powers.Grapple, Powers.EnhancedLaunch, Powers.DroneTeleport})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Rusalki Bodies"
            TempLocation.Vanilla = ItemType.GlitchBomb
            TempLocation.VanillaPlacement = 85
            TempLocation.Region = Area.Edin
            TempLocation.LineNumber1 = 4326
            TempLocation.XLocation = 7456
            TempLocation.YLocation = 3696
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch2, Powers.HighJump, Powers.TrenchCoat, Powers.Drone, Powers.Grapple, Powers.EnhancedLaunch})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.AddedPowers.AddRange({Powers.RedCoat})
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
#End Region
#Region "Address Bombs Progression"
            'Eribu
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Reflector Room"
            TempLocation.Vanilla = ItemType.HealthNode
            TempLocation.VanillaPlacement = 86
            TempLocation.Region = Area.Eribu
            TempLocation.LineNumber1 = 3087
            TempLocation.XLocation = 7904
            TempLocation.YLocation = 704
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch3, Powers.HighJump, Powers.TrenchCoat, Powers.Drone, Powers.Grapple, Powers.EnhancedLaunch})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Main Shaft Glitch Bomb"
            TempLocation.Vanilla = ItemType.LightningGun
            TempLocation.VanillaPlacement = 87
            TempLocation.Region = Area.Eribu
            TempLocation.LineNumber1 = 3086
            TempLocation.XLocation = 6000
            TempLocation.YLocation = 3744
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch3, Powers.HighJump, Powers.TrenchCoat, Powers.Drone, Powers.Grapple, Powers.EnhancedLaunch})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            'Absu
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Lower Attic"
            TempLocation.Vanilla = ItemType.PowerNodeFragment
            TempLocation.VanillaPlacement = 88
            TempLocation.Region = Area.Absu
            TempLocation.LineNumber1 = 5356
            TempLocation.XLocation = 4080
            TempLocation.YLocation = 736
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch3, Powers.HighJump, Powers.TrenchCoat, Powers.Drone, Powers.Grapple, Powers.EnhancedLaunch})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            'Edin
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Hangar Attic"
            TempLocation.Vanilla = ItemType.PowerNode
            TempLocation.VanillaPlacement = 89
            TempLocation.Region = Area.Edin
            TempLocation.LineNumber1 = 4366
            TempLocation.XLocation = 6960
            TempLocation.YLocation = 3216
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch3, Powers.HighJump, Powers.TrenchCoat, Powers.Drone, Powers.Grapple, Powers.EnhancedLaunch})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Hangar Attic Second"
            TempLocation.Vanilla = ItemType.HealthNode
            TempLocation.VanillaPlacement = 90
            TempLocation.Region = Area.Edin
            TempLocation.LineNumber1 = 4335
            TempLocation.XLocation = 6928
            TempLocation.YLocation = 3216
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch3, Powers.HighJump, Powers.TrenchCoat, Powers.Drone, Powers.Grapple, Powers.EnhancedLaunch})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Hidden Tunnel West"
            TempLocation.Vanilla = ItemType.RangeNode
            TempLocation.VanillaPlacement = 91
            TempLocation.Region = Area.Edin
            TempLocation.LineNumber1 = 4329
            TempLocation.XLocation = 4688
            TempLocation.YLocation = 3744
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch3, Powers.HighJump, Powers.TrenchCoat, Powers.Drone, Powers.Grapple, Powers.EnhancedLaunch})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "West Tower Base"
            TempLocation.Vanilla = ItemType.Shards
            TempLocation.VanillaPlacement = 92
            TempLocation.Region = Area.Edin
            TempLocation.LineNumber1 = 4341
            TempLocation.XLocation = 3392
            TempLocation.YLocation = 3632
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch3, Powers.HighJump, Powers.TrenchCoat, Powers.Drone, Powers.Grapple, Powers.EnhancedLaunch})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "West Tower Secret"
            TempLocation.Vanilla = ItemType.Lore
            TempLocation.VanillaPlacement = 93
            TempLocation.Region = Area.Edin
            TempLocation.LineNumber1 = 4357
            TempLocation.XLocation = 4192
            TempLocation.YLocation = 2880
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch3, Powers.HighJump, Powers.TrenchCoat, Powers.Drone, Powers.Grapple, Powers.EnhancedLaunch})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "After Ukhu"
            TempLocation.Vanilla = ItemType.DroneTeleport
            TempLocation.VanillaPlacement = 94
            TempLocation.Region = Area.Edin
            TempLocation.LineNumber1 = 4328
            TempLocation.XLocation = 2240
            TempLocation.YLocation = 1248
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch3, Powers.HighJump, Powers.TrenchCoat, Powers.Drone, Powers.Grapple, Powers.EnhancedLaunch})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
#End Region
#Region "Drone Teleport Progression"
            'Eribu
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Room Above Spawn Location"
            TempLocation.Vanilla = ItemType.Lore
            TempLocation.VanillaPlacement = 95
            TempLocation.Region = Area.Eribu
            TempLocation.LineNumber1 = 3088
            TempLocation.XLocation = 5040
            TempLocation.YLocation = 2640
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch3, Powers.HighJump, Powers.TrenchCoat, Powers.Drone, Powers.Grapple, Powers.EnhancedLaunch, Powers.DroneTeleport})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            'Absu
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Bottom Left Main Shaft"
            TempLocation.Vanilla = ItemType.DataGrenade
            TempLocation.VanillaPlacement = 96
            TempLocation.Region = Area.Absu
            TempLocation.LineNumber1 = 5353
            TempLocation.XLocation = 1680
            TempLocation.YLocation = 3120
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch3, Powers.HighJump, Powers.TrenchCoat, Powers.Drone, Powers.Grapple, Powers.EnhancedLaunch, Powers.DroneTeleport})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            'Ukkin-Na
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "High Above Pop Talk"
            TempLocation.Vanilla = ItemType.HealthNodeFragment
            TempLocation.VanillaPlacement = 97
            TempLocation.Region = Area.UkkinNa
            TempLocation.LineNumber1 = 6165
            TempLocation.XLocation = 4672
            TempLocation.YLocation = 272
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch3, Powers.HighJump, Powers.TrenchCoat, Powers.Drone, Powers.Grapple, Powers.EnhancedLaunch, Powers.DroneTeleport})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            'Edin
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Below Ukhu"
            TempLocation.Vanilla = ItemType.Lore
            TempLocation.VanillaPlacement = 98
            TempLocation.Region = Area.Edin
            TempLocation.LineNumber1 = 4356
            TempLocation.XLocation = 3472
            TempLocation.YLocation = 1824
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch3, Powers.HighJump, Powers.TrenchCoat, Powers.Drone, Powers.Grapple, Powers.EnhancedLaunch, Powers.DroneTeleport})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "West Tower West Secret"
            TempLocation.Vanilla = ItemType.HealthNode
            TempLocation.VanillaPlacement = 99
            TempLocation.Region = Area.Edin
            TempLocation.LineNumber1 = 4342
            TempLocation.XLocation = 2464
            TempLocation.YLocation = 2384
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch3, Powers.HighJump, Powers.TrenchCoat, Powers.Drone, Powers.Grapple, Powers.EnhancedLaunch, Powers.DroneTeleport})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Above West Tower"
            TempLocation.Vanilla = ItemType.PowerNodeFragment
            TempLocation.VanillaPlacement = 100
            TempLocation.Region = Area.Edin
            TempLocation.LineNumber1 = 4363
            TempLocation.XLocation = 3424
            TempLocation.YLocation = 2112
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch3, Powers.HighJump, Powers.TrenchCoat, Powers.Drone, Powers.Grapple, Powers.EnhancedLaunch, Powers.DroneTeleport})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Suspended Room"
            TempLocation.Vanilla = ItemType.TendrilsBottom
            TempLocation.VanillaPlacement = 101
            TempLocation.Region = Area.Edin
            TempLocation.LineNumber1 = 4343
            TempLocation.XLocation = 2000
            TempLocation.YLocation = 3088
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch3, Powers.HighJump, Powers.TrenchCoat, Powers.Drone, Powers.Grapple, Powers.EnhancedLaunch, Powers.DroneTeleport})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Open Air Grapple"
            TempLocation.Vanilla = ItemType.HealthNodeFragment
            TempLocation.VanillaPlacement = 102
            TempLocation.Region = Area.Edin
            TempLocation.LineNumber1 = 4368
            TempLocation.XLocation = 528
            TempLocation.YLocation = 3264
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch3, Powers.HighJump, Powers.TrenchCoat, Powers.Drone, Powers.Grapple, Powers.EnhancedLaunch, Powers.DroneTeleport})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            'E-Kur-Mah
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Drilled In Entrance"
            TempLocation.Vanilla = ItemType.Lore
            TempLocation.VanillaPlacement = 103
            TempLocation.Region = Area.EKurMah
            TempLocation.LineNumber1 = 3682
            TempLocation.XLocation = 1136
            TempLocation.YLocation = 1168
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch3, Powers.HighJump, Powers.TrenchCoat, Powers.Drone, Powers.Grapple, Powers.EnhancedLaunch, Powers.DroneTeleport})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Secondary Key Chamber"
            TempLocation.Vanilla = ItemType.Lore
            TempLocation.VanillaPlacement = 104
            TempLocation.Region = Area.EKurMah
            TempLocation.LineNumber1 = 3683
            TempLocation.XLocation = 3744
            TempLocation.YLocation = 960
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch3, Powers.HighJump, Powers.TrenchCoat, Powers.Drone, Powers.Grapple, Powers.EnhancedLaunch, Powers.DroneTeleport})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Primary Key Chamber"
            TempLocation.Vanilla = ItemType.BreachSuppressor
            TempLocation.VanillaPlacement = 105
            TempLocation.Region = Area.EKurMah
            TempLocation.LineNumber1 = 3658
            TempLocation.XLocation = 3296
            TempLocation.YLocation = 672
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch3, Powers.HighJump, Powers.TrenchCoat, Powers.Drone, Powers.Grapple, Powers.EnhancedLaunch, Powers.DroneTeleport})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
#End Region
#Region "Sudran Key Progression"
            'E-Kur-Mah
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Behind Seal"
            TempLocation.Vanilla = ItemType.PowerNode
            TempLocation.VanillaPlacement = 106
            TempLocation.Region = Area.EKurMah
            TempLocation.LineNumber1 = 3723
            TempLocation.XLocation = 1040
            TempLocation.YLocation = 512
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch3, Powers.HighJump, Powers.TrenchCoat, Powers.Drone, Powers.Grapple, Powers.EnhancedLaunch, Powers.DroneTeleport, Powers.Key})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Verdan Cavern"
            TempLocation.Vanilla = ItemType.HealthNodeFragment
            TempLocation.VanillaPlacement = 107
            TempLocation.Region = Area.EKurMah
            TempLocation.LineNumber1 = 3659
            TempLocation.XLocation = 2848
            TempLocation.YLocation = 4896
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch3, Powers.HighJump, Powers.TrenchCoat, Powers.Drone, Powers.Grapple, Powers.EnhancedLaunch, Powers.DroneTeleport, Powers.Key})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Basement"
            TempLocation.Vanilla = ItemType.RedCoat
            TempLocation.VanillaPlacement = 108
            TempLocation.Region = Area.EKurMah
            TempLocation.LineNumber1 = 3661
            TempLocation.XLocation = 1664
            TempLocation.YLocation = 5600
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch3, Powers.HighJump, Powers.TrenchCoat, Powers.Drone, Powers.Grapple, Powers.EnhancedLaunch, Powers.DroneTeleport, Powers.Key})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
#End Region
#Region "Red Coat Progression"
            'Kur
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Mountain Slope"
            TempLocation.Vanilla = ItemType.IonBeam
            TempLocation.VanillaPlacement = 109
            TempLocation.Region = Area.Kur
            TempLocation.LineNumber1 = 4959
            TempLocation.XLocation = 2128
            TempLocation.YLocation = 3376
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch3, Powers.HighJump, Powers.RedCoat, Powers.Drone, Powers.Grapple, Powers.EnhancedLaunch, Powers.DroneTeleport, Powers.Key})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            'Ukkin-Na
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Below Madness"
            TempLocation.Vanilla = ItemType.PowerNodeFragment
            TempLocation.VanillaPlacement = 110
            TempLocation.Region = Area.UkkinNa
            TempLocation.LineNumber1 = 6148
            TempLocation.XLocation = 4208
            TempLocation.YLocation = 4816
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch3, Powers.HighJump, Powers.RedCoat, Powers.Drone, Powers.Grapple, Powers.EnhancedLaunch, Powers.DroneTeleport, Powers.Key})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            'E-Kur-Mah
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "RedCoat Exhibition"
            TempLocation.Vanilla = ItemType.PowerNodeFragment
            TempLocation.VanillaPlacement = 111
            TempLocation.Region = Area.EKurMah
            TempLocation.LineNumber1 = 3705
            TempLocation.XLocation = 1984
            TempLocation.YLocation = 5936
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch3, Powers.HighJump, Powers.RedCoat, Powers.Drone, Powers.Grapple, Powers.EnhancedLaunch, Powers.DroneTeleport, Powers.Key})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            'Mar-Uru
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "After Sentinel"
            TempLocation.Vanilla = ItemType.HealthNode
            TempLocation.VanillaPlacement = 112
            TempLocation.Region = Area.MarUru
            TempLocation.LineNumber1 = 11944
            TempLocation.XLocation = 1520
            TempLocation.YLocation = 5312
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch3, Powers.HighJump, Powers.RedCoat, Powers.Drone, Powers.Grapple, Powers.EnhancedLaunch, Powers.DroneTeleport, Powers.Key})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Glitch Room Primary"
            TempLocation.Vanilla = ItemType.PowerNodeFragment
            TempLocation.VanillaPlacement = 113
            TempLocation.Region = Area.MarUru
            TempLocation.LineNumber1 = 11945
            TempLocation.XLocation = 2624
            TempLocation.YLocation = 5408
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch3, Powers.HighJump, Powers.RedCoat, Powers.Drone, Powers.Grapple, Powers.EnhancedLaunch, Powers.DroneTeleport, Powers.Key})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Glitch Room Below"
            TempLocation.Vanilla = ItemType.Lore
            TempLocation.VanillaPlacement = 114
            TempLocation.Region = Area.MarUru
            TempLocation.LineNumber1 = 11946
            TempLocation.XLocation = 2544
            TempLocation.YLocation = 5632
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch3, Powers.HighJump, Powers.RedCoat, Powers.Drone, Powers.Grapple, Powers.EnhancedLaunch, Powers.DroneTeleport, Powers.Key})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Glitch Room Hidden"
            TempLocation.Vanilla = ItemType.PowerNodeFragment
            TempLocation.VanillaPlacement = 115
            TempLocation.Region = Area.MarUru
            TempLocation.LineNumber1 = 11946
            TempLocation.XLocation = 2768
            TempLocation.YLocation = 5632
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch3, Powers.HighJump, Powers.RedCoat, Powers.Drone, Powers.Grapple, Powers.EnhancedLaunch, Powers.DroneTeleport, Powers.Key})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Hybrid Room"
            TempLocation.Vanilla = ItemType.SizeNode
            TempLocation.VanillaPlacement = 116
            TempLocation.Region = Area.MarUru
            TempLocation.LineNumber1 = 11947
            TempLocation.XLocation = 3072
            TempLocation.YLocation = 4320
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch3, Powers.HighJump, Powers.RedCoat, Powers.Drone, Powers.Grapple, Powers.EnhancedLaunch, Powers.DroneTeleport, Powers.Key})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Above Save Room"
            TempLocation.Vanilla = ItemType.Lore
            TempLocation.VanillaPlacement = 117
            TempLocation.Region = Area.MarUru
            TempLocation.LineNumber1 = 11952
            TempLocation.XLocation = 1696
            TempLocation.YLocation = 3744
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch3, Powers.HighJump, Powers.RedCoat, Powers.Drone, Powers.Grapple, Powers.EnhancedLaunch, Powers.DroneTeleport, Powers.Key})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Hidden Left of Save"
            TempLocation.Vanilla = ItemType.Scythe
            TempLocation.VanillaPlacement = 118
            TempLocation.Region = Area.MarUru
            TempLocation.LineNumber1 = 11953
            TempLocation.XLocation = 1200
            TempLocation.YLocation = 4224
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch3, Powers.HighJump, Powers.RedCoat, Powers.Drone, Powers.Grapple, Powers.EnhancedLaunch, Powers.DroneTeleport, Powers.Key})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Final Shaft"
            TempLocation.Vanilla = ItemType.Lore
            TempLocation.VanillaPlacement = 119
            TempLocation.Region = Area.MarUru
            TempLocation.LineNumber1 = 11951
            TempLocation.XLocation = 2016
            TempLocation.YLocation = 2496
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch3, Powers.HighJump, Powers.RedCoat, Powers.Drone, Powers.Grapple, Powers.EnhancedLaunch, Powers.DroneTeleport, Powers.Key})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Basement Shaft"
            TempLocation.Vanilla = ItemType.Lore
            TempLocation.VanillaPlacement = 124
            TempLocation.Region = Area.EKurMah
            TempLocation.LineNumber1 = 3688
            TempLocation.XLocation = 3520
            TempLocation.YLocation = 2288
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch3, Powers.HighJump, Powers.RedCoat, Powers.Drone, Powers.Grapple, Powers.EnhancedLaunch, Powers.DroneTeleport, Powers.Key})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
#End Region
#Region "Password Progression"
            'Eribu
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Lower Left Password"
            TempLocation.Vanilla = ItemType.WallTrace
            TempLocation.VanillaPlacement = 120
            TempLocation.Region = Area.Eribu
            TempLocation.LineNumber1 = 3131
            TempLocation.XLocation = 6576
            TempLocation.YLocation = 4384
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch3, Powers.HighJump, Powers.RedCoat, Powers.Drone, Powers.Grapple, Powers.EnhancedLaunch, Powers.DroneTeleport, Powers.Key, Powers.Passwords})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Behind Laser Wall Password"
            TempLocation.Vanilla = ItemType.PowerNodeFragment
            TempLocation.VanillaPlacement = 121
            TempLocation.Region = Area.Eribu
            TempLocation.LineNumber1 = 3057
            TempLocation.XLocation = 4064
            TempLocation.YLocation = 1552
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch3, Powers.HighJump, Powers.RedCoat, Powers.Drone, Powers.Grapple, Powers.EnhancedLaunch, Powers.DroneTeleport, Powers.Key, Powers.Passwords})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Far Left Password"
            TempLocation.Vanilla = ItemType.FlameThrower
            TempLocation.VanillaPlacement = 122
            TempLocation.Region = Area.Eribu
            TempLocation.LineNumber1 = 3130
            TempLocation.XLocation = 2144
            TempLocation.YLocation = 1776
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch3, Powers.HighJump, Powers.RedCoat, Powers.Drone, Powers.Grapple, Powers.EnhancedLaunch, Powers.DroneTeleport, Powers.Key, Powers.Passwords})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            'E-Kur-Mah
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Passworded Verdan Cavern"
            TempLocation.Vanilla = ItemType.Swim
            TempLocation.VanillaPlacement = 123
            TempLocation.Region = Area.EKurMah
            TempLocation.LineNumber1 = 3660
            TempLocation.XLocation = 1544
            TempLocation.YLocation = 4432
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch3, Powers.HighJump, Powers.RedCoat, Powers.Drone, Powers.Grapple, Powers.EnhancedLaunch, Powers.DroneTeleport, Powers.Key, Powers.Passwords})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
#End Region
            Return Locations
        End Function
    End Class
    Public Class NormalLocations
        Public Shared Function ResetLocations(Optional OpenEribu1 As Boolean = False, Optional OpenElsenova2 As Boolean = False, Optional OpenAbsu3 As Boolean = False)
            Dim Locations As List(Of Location)
            Locations = New List(Of Location)
            Dim TempLocation As Location
#Region "Area 1 - Eribu"
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Left From Start"
            TempLocation.Vanilla = ItemType.DataDisruptor
            TempLocation.VanillaPlacement = 1
            TempLocation.Region = Area.Eribu
            TempLocation.LineNumber1 = 2923
            TempLocation.XLocation = 4064
            TempLocation.YLocation = 3184
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Red Ruins"
            TempLocation.Vanilla = ItemType.Nova
            TempLocation.VanillaPlacement = 2
            TempLocation.Region = Area.Eribu
            TempLocation.LineNumber1 = 2937
            TempLocation.XLocation = 8880
            TempLocation.YLocation = 1232
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Red Stalagmites"
            TempLocation.Vanilla = ItemType.SizeNode
            TempLocation.VanillaPlacement = 3
            TempLocation.Region = Area.Eribu
            TempLocation.LineNumber1 = 3035
            TempLocation.XLocation = 5024
            TempLocation.YLocation = 2096
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "After Xedur"
            TempLocation.Vanilla = ItemType.Drill
            TempLocation.VanillaPlacement = 4
            TempLocation.Region = Area.Eribu
            TempLocation.LineNumber1 = 2945
            TempLocation.XLocation = 8960
            TempLocation.YLocation = 2672
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Entering Absu"
            TempLocation.Vanilla = ItemType.HealthNode
            TempLocation.VanillaPlacement = 7
            TempLocation.Region = Area.Eribu
            TempLocation.LineNumber1 = 3000
            TempLocation.XLocation = 8384
            TempLocation.YLocation = 5072
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova})
            If Not OpenEribu1 Then TempLocation.RequiredPowers.AddRange({Powers.Drill})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Drilled Under Xedur"
            TempLocation.Vanilla = ItemType.PowerNode
            TempLocation.VanillaPlacement = 5
            TempLocation.Region = Area.Eribu
            TempLocation.LineNumber1 = 2938
            TempLocation.XLocation = 8016
            TempLocation.YLocation = 2928
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Upper Left Platforms"
            TempLocation.Vanilla = ItemType.MultiDisruptor
            TempLocation.VanillaPlacement = 6
            TempLocation.Region = Area.Eribu
            TempLocation.LineNumber1 = 3025
            TempLocation.XLocation = 5504
            TempLocation.YLocation = 1472
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Guarded by Ghouls"
            TempLocation.Vanilla = ItemType.HealthNodeFragment
            TempLocation.VanillaPlacement = 12
            TempLocation.Region = Area.Eribu
            TempLocation.LineNumber1 = 3026
            TempLocation.XLocation = 7040
            TempLocation.YLocation = 4944
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage})
            If Not OpenEribu1 Then TempLocation.RequiredPowers.AddRange({Powers.Drill})
            TempLocation.RequiredJump = 6
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Lower Left Password"
            TempLocation.Vanilla = ItemType.WallTrace
            TempLocation.VanillaPlacement = 120
            TempLocation.Region = Area.Eribu
            TempLocation.LineNumber1 = 3131
            TempLocation.XLocation = 6576
            TempLocation.YLocation = 4384
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Passwords})
            If Not OpenEribu1 Then TempLocation.RequiredPowers.AddRange({Powers.Drill})
            TempLocation.RequiredJump = 6
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Under Water"
            TempLocation.Vanilla = ItemType.HealthNodeFragment
            TempLocation.VanillaPlacement = 56
            TempLocation.Region = Area.Eribu
            TempLocation.LineNumber1 = 3058
            TempLocation.XLocation = 2272
            TempLocation.YLocation = 3136
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Drill, Powers.Drone, Powers.Glitch2})
            TempLocation.RequiredJump = 6
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Exit to Indi"
            TempLocation.Vanilla = ItemType.PowerNodeFragment
            TempLocation.VanillaPlacement = 71
            TempLocation.Region = Area.Eribu
            TempLocation.LineNumber1 = 3085
            TempLocation.XLocation = 8464
            TempLocation.YLocation = 4416
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.LabCoat, Powers.Drone, Powers.DroneTeleport})
            If Not OpenEribu1 Then TempLocation.RequiredPowers.AddRange({Powers.Drill})
            TempLocation.RequiredJump = 6
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            'TempLocation.GroupedPowers.AddRange({Powers.TrenchCoat, Powers.Grapple})
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Reflector Room"
            TempLocation.Vanilla = ItemType.HealthNode
            TempLocation.VanillaPlacement = 86
            TempLocation.Region = Area.Eribu
            TempLocation.LineNumber1 = 3087
            TempLocation.XLocation = 7904
            TempLocation.YLocation = 704
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Glitch3})
            TempLocation.RequiredJump = 9
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Room Above Spawn Location"
            TempLocation.Vanilla = ItemType.Lore
            TempLocation.VanillaPlacement = 95
            TempLocation.Region = Area.Eribu
            TempLocation.LineNumber1 = 3088
            TempLocation.XLocation = 5040
            TempLocation.YLocation = 2640
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Drill, Powers.LabCoat, Powers.Drone, Powers.DroneTeleport})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Behind Laser Wall Password"
            TempLocation.Vanilla = ItemType.PowerNodeFragment
            TempLocation.VanillaPlacement = 121
            TempLocation.Region = Area.Eribu
            TempLocation.LineNumber1 = 3057
            TempLocation.XLocation = 4064
            TempLocation.YLocation = 1552
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Drill, Powers.Nova, Powers.Passwords})
            TempLocation.RequiredJump = 9
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Main Shaft Glitch Bomb"
            TempLocation.Vanilla = ItemType.LightningGun
            TempLocation.VanillaPlacement = 87
            TempLocation.Region = Area.Eribu
            TempLocation.LineNumber1 = 3086
            TempLocation.XLocation = 6000
            TempLocation.YLocation = 3744
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Glitch3, Powers.Drone, Powers.DroneTeleport})
            If Not OpenEribu1 Then TempLocation.RequiredPowers.AddRange({Powers.Drill})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Far Left Password"
            TempLocation.Vanilla = ItemType.FlameThrower
            TempLocation.VanillaPlacement = 122
            TempLocation.Region = Area.Eribu
            TempLocation.LineNumber1 = 3130
            TempLocation.XLocation = 2144
            TempLocation.YLocation = 1776
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Drill, Powers.Passwords, Powers.Drone, Powers.DroneTeleport, Powers.Glitch2})
            TempLocation.RequiredJump = 12
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
#End Region
#Region "Area 2 - Absu"
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Elsenova"
            TempLocation.Vanilla = ItemType.Kilver
            TempLocation.VanillaPlacement = 9
            TempLocation.Region = Area.Absu
            TempLocation.LineNumber1 = 5137
            TempLocation.XLocation = 4064
            TempLocation.YLocation = 2304
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Drill})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Drilled Shaft"
            TempLocation.Vanilla = ItemType.HealthNodeFragment
            TempLocation.VanillaPlacement = 8
            TempLocation.Region = Area.Absu
            TempLocation.LineNumber1 = 5277
            TempLocation.XLocation = 2032
            TempLocation.YLocation = 1744
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Drill})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "After Telal"
            TempLocation.Vanilla = ItemType.AddressDisruptor1
            TempLocation.VanillaPlacement = 11
            TempLocation.Region = Area.Absu
            TempLocation.LineNumber1 = 5325
            TempLocation.XLocation = 6608
            TempLocation.YLocation = 1808
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage})
            If Not OpenEribu1 Then TempLocation.RequiredPowers.AddRange({Powers.Drill})
            If Not OpenElsenova2 Then TempLocation.RequiredPowers.AddRange({Powers.Kilver})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Below Corruption"
            TempLocation.Vanilla = ItemType.RangeNode
            TempLocation.VanillaPlacement = 68
            TempLocation.Region = Area.Absu
            TempLocation.LineNumber1 = 5412
            TempLocation.XLocation = 3488
            TempLocation.YLocation = 3152
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Glitch2, Powers.TrenchCoat, Powers.Drone})
            If Not OpenEribu1 Then TempLocation.RequiredPowers.AddRange({Powers.Drill})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Drone by Skeleton"
            TempLocation.Vanilla = ItemType.Lore
            TempLocation.VanillaPlacement = 35
            TempLocation.Region = Area.Absu
            TempLocation.LineNumber1 = 5409
            TempLocation.XLocation = 1200
            TempLocation.YLocation = 2576
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Drone})
            If Not OpenEribu1 Then TempLocation.RequiredPowers.AddRange({Powers.Drill})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Attic Left"
            TempLocation.Vanilla = ItemType.PowerNodeFragment
            TempLocation.VanillaPlacement = 36
            TempLocation.Region = Area.Absu
            TempLocation.LineNumber1 = 5357
            TempLocation.XLocation = 3600
            TempLocation.YLocation = 576
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Drill})
            TempLocation.RequiredJump = 9
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Bottom Left Main Shaft"
            TempLocation.Vanilla = ItemType.DataGrenade
            TempLocation.VanillaPlacement = 96
            TempLocation.Region = Area.Absu
            TempLocation.LineNumber1 = 5353
            TempLocation.XLocation = 1680
            TempLocation.YLocation = 3120
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.TrenchCoat, Powers.Drone, Powers.DroneTeleport})
            If Not OpenEribu1 Then TempLocation.RequiredPowers.AddRange({Powers.Drill})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Behind Kilver Door"
            TempLocation.Vanilla = ItemType.HealthNodeFragment
            TempLocation.VanillaPlacement = 10
            TempLocation.Region = Area.Absu
            TempLocation.LineNumber1 = 5279
            TempLocation.XLocation = 3104
            TempLocation.YLocation = 1056
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Kilver})
            If Not OpenEribu1 Then TempLocation.RequiredPowers.AddRange({Powers.Drill})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Middle of Lower Shaft"
            TempLocation.Vanilla = ItemType.HealthNode
            TempLocation.VanillaPlacement = 14
            TempLocation.Region = Area.Absu
            TempLocation.LineNumber1 = 5242
            TempLocation.XLocation = 7392
            TempLocation.YLocation = 2176
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage})
            If Not OpenEribu1 Then TempLocation.RequiredPowers.AddRange({Powers.Drill})
            If Not OpenAbsu3 Then TempLocation.RequiredPowers.AddRange({Powers.Glitch1})
            If Not OpenElsenova2 Then TempLocation.RequiredPowers.AddRange({Powers.Kilver})
            TempLocation.RequiredJump = 4
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Exit to Zi"
            TempLocation.Vanilla = ItemType.PowerNode
            TempLocation.VanillaPlacement = 19
            TempLocation.Region = Area.Absu
            TempLocation.LineNumber1 = 5158
            TempLocation.XLocation = 11824
            TempLocation.YLocation = 3488
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Drill})
            If Not OpenAbsu3 Then TempLocation.RequiredPowers.AddRange({Powers.Glitch1})
            If Not OpenElsenova2 Then TempLocation.RequiredPowers.AddRange({Powers.Kilver})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Jail Cell"
            TempLocation.Vanilla = ItemType.Lore
            TempLocation.VanillaPlacement = 25
            TempLocation.Region = Area.Absu
            TempLocation.LineNumber1 = 5414
            TempLocation.XLocation = 3424
            TempLocation.YLocation = 2960
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.LabCoat})
            If Not OpenEribu1 Then TempLocation.RequiredPowers.AddRange({Powers.Drill})
            If Not OpenElsenova2 Then TempLocation.RequiredPowers.AddRange({Powers.Kilver})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Green Squid Room"
            TempLocation.Vanilla = ItemType.Lore
            TempLocation.VanillaPlacement = 17
            TempLocation.Region = Area.Absu
            TempLocation.LineNumber1 = 5411
            TempLocation.XLocation = 9072
            TempLocation.YLocation = 2592
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Drill})
            If Not OpenAbsu3 Then TempLocation.RequiredPowers.AddRange({Powers.Glitch1})
            If Not OpenElsenova2 Then TempLocation.RequiredPowers.AddRange({Powers.Kilver})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Pink Vines"
            TempLocation.Vanilla = ItemType.Lore
            TempLocation.VanillaPlacement = 16
            TempLocation.Region = Area.Absu
            TempLocation.LineNumber1 = 5410
            TempLocation.XLocation = 6464
            TempLocation.YLocation = 3088
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Drill})
            If Not OpenAbsu3 Then TempLocation.RequiredPowers.AddRange({Powers.Glitch1})
            If Not OpenElsenova2 Then TempLocation.RequiredPowers.AddRange({Powers.Kilver})
            TempLocation.RequiredJump = 6
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.AddedPowers.AddRange({Powers.Glitch1, Powers.Grapple})
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Lowest Room"
            TempLocation.Vanilla = ItemType.Lore
            TempLocation.VanillaPlacement = 26
            TempLocation.Region = Area.Absu
            TempLocation.LineNumber1 = 5408
            TempLocation.XLocation = 3520
            TempLocation.YLocation = 4016
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.LabCoat})
            If Not OpenEribu1 Then TempLocation.RequiredPowers.AddRange({Powers.Drill})
            If Not OpenElsenova2 Then TempLocation.RequiredPowers.AddRange({Powers.Kilver})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Lower Right Corrupted"
            TempLocation.Vanilla = ItemType.InertialPulse
            TempLocation.VanillaPlacement = 51
            TempLocation.Region = Area.Absu
            TempLocation.LineNumber1 = 5359
            TempLocation.XLocation = 11744
            TempLocation.YLocation = 2304
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Drill, Powers.Glitch2})
            If Not OpenElsenova2 Then TempLocation.RequiredPowers.AddRange({Powers.Kilver})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Purple Corrupted Diatom"
            TempLocation.Vanilla = ItemType.SizeNode
            TempLocation.VanillaPlacement = 15
            TempLocation.Region = Area.Absu
            TempLocation.LineNumber1 = 5320
            TempLocation.XLocation = 7344
            TempLocation.YLocation = 2816
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Drill})
            If Not OpenAbsu3 Then TempLocation.RequiredPowers.AddRange({Powers.Glitch1})
            If Not OpenElsenova2 Then TempLocation.RequiredPowers.AddRange({Powers.Kilver})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Remote Detonation"
            TempLocation.Vanilla = ItemType.HealthNodeFragment
            TempLocation.VanillaPlacement = 18
            TempLocation.Region = Area.Absu
            TempLocation.LineNumber1 = 5278
            TempLocation.XLocation = 10512
            TempLocation.YLocation = 2912
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Drill, Powers.Glitch1})
            If Not OpenElsenova2 Then TempLocation.RequiredPowers.AddRange({Powers.Kilver})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Far Left Hallway"
            TempLocation.Vanilla = ItemType.PowerNodeFragment
            TempLocation.VanillaPlacement = 13
            TempLocation.Region = Area.Absu
            TempLocation.LineNumber1 = 5415
            TempLocation.XLocation = 176
            TempLocation.YLocation = 2112
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Glitch1})
            If Not OpenEribu1 Then TempLocation.RequiredPowers.AddRange({Powers.Drill})
            If Not OpenElsenova2 Then TempLocation.RequiredPowers.AddRange({Powers.Kilver})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Upper Attic"
            TempLocation.Vanilla = ItemType.PowerNodeFragment 'PowerNodeFragment5
            TempLocation.VanillaPlacement = 49
            TempLocation.Region = Area.Absu
            TempLocation.LineNumber1 = 5355
            TempLocation.XLocation = 4544
            TempLocation.YLocation = 480
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Glitch2})
            If Not OpenEribu1 Then TempLocation.RequiredPowers.AddRange({Powers.Drill})
            If Not OpenElsenova2 Then TempLocation.RequiredPowers.AddRange({Powers.Kilver})
            TempLocation.RequiredJump = 9
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.AddedPowers.AddRange({Powers.Grapple})
            TempLocation.MapOptionPowers = New List(Of Powers)
            TempLocation.MapOptionPowers.AddRange({Powers.HighJump, Powers.TrenchCoat})
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Lava Secret"
            TempLocation.Vanilla = ItemType.PowerNodeFragment
            TempLocation.VanillaPlacement = 69
            TempLocation.Region = Area.Absu
            TempLocation.LineNumber1 = 5423
            TempLocation.XLocation = 10800
            TempLocation.YLocation = 3744
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.TrenchCoat})
            If Not OpenEribu1 Then TempLocation.RequiredPowers.AddRange({Powers.Drill})
            If Not OpenElsenova2 Then TempLocation.RequiredPowers.AddRange({Powers.Kilver})
            TempLocation.RequiredJump = 6
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Chasm Tunnel"
            TempLocation.Vanilla = ItemType.Lore
            TempLocation.VanillaPlacement = 37
            TempLocation.Region = Area.Absu
            TempLocation.LineNumber1 = 5413
            TempLocation.XLocation = 9232
            TempLocation.YLocation = 3472
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Drone})
            If Not OpenEribu1 Then TempLocation.RequiredPowers.AddRange({Powers.Drill})
            If Not OpenAbsu3 Then TempLocation.RequiredPowers.AddRange({Powers.Glitch1})
            If Not OpenElsenova2 Then TempLocation.RequiredPowers.AddRange({Powers.Kilver})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Green Fungus Secret"
            TempLocation.Vanilla = ItemType.RangeNode
            TempLocation.VanillaPlacement = 27
            TempLocation.Region = Area.Absu
            TempLocation.LineNumber1 = 5324
            TempLocation.XLocation = 8400
            TempLocation.YLocation = 3152
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.LabCoat})
            If Not OpenEribu1 Then TempLocation.RequiredPowers.AddRange({Powers.Drill})
            If Not OpenAbsu3 Then TempLocation.RequiredPowers.AddRange({Powers.Glitch1})
            If Not OpenElsenova2 Then TempLocation.RequiredPowers.AddRange({Powers.Kilver})
            TempLocation.RequiredJump = 6
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Lower Attic"
            TempLocation.Vanilla = ItemType.PowerNodeFragment 'PowerNodeFragment4
            TempLocation.VanillaPlacement = 88
            TempLocation.Region = Area.Absu
            TempLocation.LineNumber1 = 5356
            TempLocation.XLocation = 4080
            TempLocation.YLocation = 736
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Glitch3})
            If Not OpenEribu1 Then TempLocation.RequiredPowers.AddRange({Powers.Drill})
            If Not OpenAbsu3 Then TempLocation.RequiredPowers.AddRange({Powers.Glitch1})
            TempLocation.RequiredJump = 9
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Right Attic"
            TempLocation.Vanilla = ItemType.PowerNodeFragment
            TempLocation.VanillaPlacement = 50
            TempLocation.Region = Area.Absu
            TempLocation.LineNumber1 = 5354
            TempLocation.XLocation = 5152
            TempLocation.YLocation = 448
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Glitch2})
            If Not OpenEribu1 Then TempLocation.RequiredPowers.AddRange({Powers.Drill})
            TempLocation.RequiredJump = 12
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Boss Secret"
            TempLocation.Vanilla = ItemType.HealthNodeFragment
            TempLocation.VanillaPlacement = 38
            TempLocation.Region = Area.Absu
            TempLocation.LineNumber1 = 5358
            TempLocation.XLocation = 8400
            TempLocation.YLocation = 128
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.LabCoat, Powers.Grapple})
            If Not OpenEribu1 Then TempLocation.RequiredPowers.AddRange({Powers.Drill})
            If Not OpenAbsu3 Then TempLocation.RequiredPowers.AddRange({Powers.Glitch1})
            If Not OpenElsenova2 Then TempLocation.RequiredPowers.AddRange({Powers.Kilver})
            TempLocation.RequiredJump = 9
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
#End Region
#Region "Area 3 - Zi"
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "After Uruku"
            TempLocation.Vanilla = ItemType.GlitchTeleport
            TempLocation.VanillaPlacement = 23
            TempLocation.Region = Area.Zi
            TempLocation.LineNumber1 = 4896
            TempLocation.XLocation = 6000
            TempLocation.YLocation = 480
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Glitch1})
            If Not OpenEribu1 Then TempLocation.RequiredPowers.AddRange({Powers.Drill})
            If Not OpenAbsu3 Then TempLocation.RequiredPowers.AddRange({Powers.Glitch1})
            If Not OpenElsenova2 Then TempLocation.RequiredPowers.AddRange({Powers.Kilver})
            TempLocation.RequiredJump = 6
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Bottom Arterial Shaft"
            TempLocation.Vanilla = ItemType.HealthNodeFragment
            TempLocation.VanillaPlacement = 39
            TempLocation.Region = Area.Zi
            TempLocation.LineNumber1 = 4949
            TempLocation.XLocation = 5040
            TempLocation.YLocation = 2656
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Drone})
            If Not OpenEribu1 Then TempLocation.RequiredPowers.AddRange({Powers.Drill})
            If Not OpenAbsu3 Then TempLocation.RequiredPowers.AddRange({Powers.Glitch1})
            If Not OpenElsenova2 Then TempLocation.RequiredPowers.AddRange({Powers.Kilver})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "High Jump Bypass"
            TempLocation.Vanilla = ItemType.Lore
            TempLocation.VanillaPlacement = 22
            TempLocation.Region = Area.Zi
            TempLocation.LineNumber1 = 4940
            TempLocation.XLocation = 3776
            TempLocation.YLocation = 864
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Drill})
            If Not OpenAbsu3 Then TempLocation.RequiredPowers.AddRange({Powers.Glitch1})
            If Not OpenElsenova2 Then TempLocation.RequiredPowers.AddRange({Powers.Kilver})
            TempLocation.RequiredJump = 6
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Veruska Basement"
            TempLocation.Vanilla = ItemType.Lore
            TempLocation.VanillaPlacement = 41
            TempLocation.Region = Area.Zi
            TempLocation.LineNumber1 = 4939
            TempLocation.XLocation = 5168
            TempLocation.YLocation = 3488
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Drone})
            If Not OpenEribu1 Then TempLocation.RequiredPowers.AddRange({Powers.Drill})
            If Not OpenAbsu3 Then TempLocation.RequiredPowers.AddRange({Powers.Glitch1})
            If Not OpenElsenova2 Then TempLocation.RequiredPowers.AddRange({Powers.Kilver})
            TempLocation.RequiredJump = 6
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Eye Stalk Secret"
            TempLocation.Vanilla = ItemType.PowerNodeFragment
            TempLocation.VanillaPlacement = 52
            TempLocation.Region = Area.Zi
            TempLocation.LineNumber1 = 4910
            TempLocation.XLocation = 240
            TempLocation.YLocation = 2336
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Glitch2})
            If Not OpenEribu1 Then TempLocation.RequiredPowers.AddRange({Powers.Drill})
            If Not OpenAbsu3 Then TempLocation.RequiredPowers.AddRange({Powers.Glitch1})
            If Not OpenElsenova2 Then TempLocation.RequiredPowers.AddRange({Powers.Kilver})
            TempLocation.RequiredJump = 6
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Veruska Secret"
            TempLocation.Vanilla = ItemType.PasswordTool
            TempLocation.VanillaPlacement = 40
            TempLocation.Region = Area.Zi
            TempLocation.LineNumber1 = 4909
            TempLocation.XLocation = 4064
            TempLocation.YLocation = 3408
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Drone})
            If Not OpenEribu1 Then TempLocation.RequiredPowers.AddRange({Powers.Drill})
            If Not OpenAbsu3 Then TempLocation.RequiredPowers.AddRange({Powers.Glitch1})
            If Not OpenElsenova2 Then TempLocation.RequiredPowers.AddRange({Powers.Kilver})
            TempLocation.RequiredJump = 6
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Above Ruggs"
            TempLocation.Vanilla = ItemType.HealthNodeFragment
            TempLocation.VanillaPlacement = 21
            TempLocation.Region = Area.Zi
            TempLocation.LineNumber1 = 4908
            TempLocation.XLocation = 2480
            TempLocation.YLocation = 2864
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Drill})
            If Not OpenAbsu3 Then TempLocation.RequiredPowers.AddRange({Powers.Glitch1})
            If Not OpenElsenova2 Then TempLocation.RequiredPowers.AddRange({Powers.Kilver})
            TempLocation.RequiredJump = 6
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "High Jump Access"
            TempLocation.Vanilla = ItemType.SizeNode
            TempLocation.VanillaPlacement = 31
            TempLocation.Region = Area.Zi
            TempLocation.LineNumber1 = 4906
            TempLocation.XLocation = 4032
            TempLocation.YLocation = 2224
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Drill, Powers.Kilver})
            If Not OpenEribu1 Then TempLocation.RequiredPowers.AddRange({Powers.Drill})
            If Not OpenAbsu3 Then TempLocation.RequiredPowers.AddRange({Powers.Glitch1})
            TempLocation.RequiredJump = 6
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Steam Secret"
            TempLocation.Vanilla = ItemType.TendrilsTop
            TempLocation.VanillaPlacement = 29
            TempLocation.Region = Area.Zi
            TempLocation.LineNumber1 = 4592
            TempLocation.XLocation = 1184
            TempLocation.YLocation = 2592
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage})
            If Not OpenEribu1 Then TempLocation.RequiredPowers.AddRange({Powers.Drill})
            If Not OpenAbsu3 Then TempLocation.RequiredPowers.AddRange({Powers.Glitch1})
            If Not OpenElsenova2 Then TempLocation.RequiredPowers.AddRange({Powers.Kilver})
            TempLocation.RequiredJump = 6
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Boss Room"
            TempLocation.Vanilla = ItemType.HealthNode
            TempLocation.VanillaPlacement = 32
            TempLocation.Region = Area.Zi
            TempLocation.LineNumber1 = 4893
            TempLocation.XLocation = 4736
            TempLocation.YLocation = 336
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.LabCoat})
            If Not OpenEribu1 Then TempLocation.RequiredPowers.AddRange({Powers.Drill})
            If Not OpenAbsu3 Then TempLocation.RequiredPowers.AddRange({Powers.Glitch1})
            If Not OpenElsenova2 Then TempLocation.RequiredPowers.AddRange({Powers.Kilver})
            TempLocation.RequiredJump = 6
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Maintenance Secret"
            TempLocation.Vanilla = ItemType.Lore
            TempLocation.VanillaPlacement = 42
            TempLocation.Region = Area.Zi
            TempLocation.LineNumber1 = 4941
            TempLocation.XLocation = 816
            TempLocation.YLocation = 1552
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Drone})
            If Not OpenEribu1 Then TempLocation.RequiredPowers.AddRange({Powers.Drill})
            If Not OpenAbsu3 Then TempLocation.RequiredPowers.AddRange({Powers.Glitch1})
            If Not OpenElsenova2 Then TempLocation.RequiredPowers.AddRange({Powers.Kilver})
            TempLocation.RequiredJump = 6
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Maintenance Tunnel"
            TempLocation.Vanilla = ItemType.Voranj
            TempLocation.VanillaPlacement = 43
            TempLocation.Region = Area.Zi
            TempLocation.LineNumber1 = 4911
            TempLocation.XLocation = 2160
            TempLocation.YLocation = 1840
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Drone})
            If Not OpenEribu1 Then TempLocation.RequiredPowers.AddRange({Powers.Drill})
            If Not OpenAbsu3 Then TempLocation.RequiredPowers.AddRange({Powers.Glitch1})
            If Not OpenElsenova2 Then TempLocation.RequiredPowers.AddRange({Powers.Kilver})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Center Steam Room"
            TempLocation.Vanilla = ItemType.RangeNode
            TempLocation.VanillaPlacement = 28
            TempLocation.Region = Area.Zi
            TempLocation.LineNumber1 = 4907
            TempLocation.XLocation = 1472
            TempLocation.YLocation = 3120
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.LabCoat})
            If Not OpenEribu1 Then TempLocation.RequiredPowers.AddRange({Powers.Drill})
            If Not OpenAbsu3 Then TempLocation.RequiredPowers.AddRange({Powers.Glitch1})
            If Not OpenElsenova2 Then TempLocation.RequiredPowers.AddRange({Powers.Kilver})
            TempLocation.RequiredJump = 6
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Filtration Preview"
            TempLocation.Vanilla = ItemType.HealthNodeFragment
            TempLocation.VanillaPlacement = 30
            TempLocation.Region = Area.Zi
            TempLocation.LineNumber1 = 4897
            TempLocation.XLocation = 4560
            TempLocation.YLocation = 1280
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.LabCoat})
            If Not OpenEribu1 Then TempLocation.RequiredPowers.AddRange({Powers.Drill})
            If Not OpenAbsu3 Then TempLocation.RequiredPowers.AddRange({Powers.Glitch1})
            If Not OpenElsenova2 Then TempLocation.RequiredPowers.AddRange({Powers.Kilver})
            TempLocation.RequiredJump = 6
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Filtration Up High"
            TempLocation.Vanilla = ItemType.PowerNodeFragment 'PowerNodeFragment1
            TempLocation.VanillaPlacement = 57
            TempLocation.Region = Area.Zi
            TempLocation.LineNumber1 = 4948
            TempLocation.XLocation = 5632
            TempLocation.YLocation = 128
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Glitch1, Powers.Grapple})
            If Not OpenEribu1 Then TempLocation.RequiredPowers.AddRange({Powers.Drill})
            If Not OpenElsenova2 Then TempLocation.RequiredPowers.AddRange({Powers.Kilver})
            TempLocation.RequiredJump = 12
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
#End Region
#Region "Area 4 - Kur"
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Below Cavern"
            TempLocation.Vanilla = ItemType.HighJump
            TempLocation.VanillaPlacement = 20
            TempLocation.Region = Area.Kur
            TempLocation.LineNumber1 = 4673
            TempLocation.XLocation = 2640
            TempLocation.YLocation = 6704
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage})
            If Not OpenEribu1 Then TempLocation.RequiredPowers.AddRange({Powers.Drill})
            If Not OpenAbsu3 Then TempLocation.RequiredPowers.AddRange({Powers.Glitch1})
            If Not OpenElsenova2 Then TempLocation.RequiredPowers.AddRange({Powers.Kilver})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Drone Runs"
            TempLocation.Vanilla = ItemType.AddressDisruptor2
            TempLocation.VanillaPlacement = 47
            TempLocation.Region = Area.Kur
            TempLocation.LineNumber1 = 4931
            TempLocation.XLocation = 704
            TempLocation.YLocation = 6704
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Drone, Powers.LabCoat})
            If Not OpenEribu1 Then TempLocation.RequiredPowers.AddRange({Powers.Drill})
            If Not OpenAbsu3 Then TempLocation.RequiredPowers.AddRange({Powers.Glitch1})
            If Not OpenElsenova2 Then TempLocation.RequiredPowers.AddRange({Powers.Kilver})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Hidden in Cavern"
            TempLocation.Vanilla = ItemType.FireWall
            TempLocation.VanillaPlacement = 24
            TempLocation.Region = Area.Kur
            TempLocation.LineNumber1 = 4906
            TempLocation.XLocation = 1952
            TempLocation.YLocation = 6128
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Drill})
            If Not OpenEribu1 Then TempLocation.RequiredPowers.AddRange({Powers.Drill})
            If Not OpenAbsu3 Then TempLocation.RequiredPowers.AddRange({Powers.Glitch1})
            If Not OpenElsenova2 Then TempLocation.RequiredPowers.AddRange({Powers.Kilver})
            TempLocation.RequiredJump = 6
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Drilled High Jump" 'To Be Changed...
            TempLocation.Vanilla = ItemType.HealthNodeFragment 'HealthNodeFragment10
            TempLocation.VanillaPlacement = 44
            TempLocation.Region = Area.Kur
            TempLocation.LineNumber1 = 4803
            TempLocation.XLocation = 2816
            TempLocation.YLocation = 5872
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.RedCoat})
            If Not OpenEribu1 Then TempLocation.RequiredPowers.AddRange({Powers.Drill})
            If Not OpenAbsu3 Then TempLocation.RequiredPowers.AddRange({Powers.Glitch1})
            If Not OpenElsenova2 Then TempLocation.RequiredPowers.AddRange({Powers.Kilver})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Mountain Slope"
            TempLocation.Vanilla = ItemType.IonBeam
            TempLocation.VanillaPlacement = 109
            TempLocation.Region = Area.Kur
            TempLocation.LineNumber1 = 4959
            TempLocation.XLocation = 2128
            TempLocation.YLocation = 3376
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.RedCoat}) 'Double Check Height Req
            If Not OpenEribu1 Then TempLocation.RequiredPowers.AddRange({Powers.Drill})
            If Not OpenAbsu3 Then TempLocation.RequiredPowers.AddRange({Powers.Glitch1})
            If Not OpenElsenova2 Then TempLocation.RequiredPowers.AddRange({Powers.Kilver})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Near Indi Exit"
            TempLocation.Vanilla = ItemType.PowerNode
            TempLocation.VanillaPlacement = 33
            TempLocation.Region = Area.Kur
            TempLocation.LineNumber1 = 4719
            TempLocation.XLocation = 240
            TempLocation.YLocation = 5840
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Drill, Powers.LabCoat})
            If Not OpenAbsu3 Then TempLocation.RequiredPowers.AddRange({Powers.Glitch1})
            If Not OpenElsenova2 Then TempLocation.RequiredPowers.AddRange({Powers.Kilver})
            TempLocation.RequiredJump = 6
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Wall Blocked Slope Room"
            TempLocation.Vanilla = ItemType.DroneGun
            TempLocation.VanillaPlacement = 34
            TempLocation.Region = Area.Kur
            TempLocation.LineNumber1 = 4782
            TempLocation.XLocation = 3104
            TempLocation.YLocation = 3456
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Drill, Powers.LabCoat})
            If Not OpenAbsu3 Then TempLocation.RequiredPowers.AddRange({Powers.Glitch1})
            If Not OpenElsenova2 Then TempLocation.RequiredPowers.AddRange({Powers.Kilver})
            TempLocation.RequiredJump = 6
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Thorn Maze Secret"
            TempLocation.Vanilla = ItemType.VerticalSpread
            TempLocation.VanillaPlacement = 45
            TempLocation.Region = Area.Kur
            TempLocation.LineNumber1 = 4957
            TempLocation.XLocation = 2640
            TempLocation.YLocation = 4208
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Drill, Powers.LabCoat, Powers.Drone})
            If Not OpenAbsu3 Then TempLocation.RequiredPowers.AddRange({Powers.Glitch1})
            If Not OpenElsenova2 Then TempLocation.RequiredPowers.AddRange({Powers.Kilver})
            TempLocation.RequiredJump = 6
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Lair Secret"
            TempLocation.Vanilla = ItemType.HealthNode 'HealthNode4
            TempLocation.VanillaPlacement = 54
            TempLocation.Region = Area.Kur
            TempLocation.LineNumber1 = 4846
            TempLocation.XLocation = 4544
            TempLocation.YLocation = 3200
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Drill, Powers.LabCoat})
            If Not OpenAbsu3 Then TempLocation.RequiredPowers.AddRange({Powers.Glitch1})
            If Not OpenElsenova2 Then TempLocation.RequiredPowers.AddRange({Powers.Kilver})
            TempLocation.RequiredJump = 8
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Above Grapple"
            TempLocation.Vanilla = ItemType.HealthNodeFragment 'HealthNodeFragment11
            TempLocation.VanillaPlacement = 61
            TempLocation.Region = Area.Kur
            TempLocation.LineNumber1 = 4853
            TempLocation.XLocation = 7984
            TempLocation.YLocation = 1680
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Drill, Powers.LabCoat}) 'Grapple / Drone Req? 
            If Not OpenAbsu3 Then TempLocation.RequiredPowers.AddRange({Powers.Glitch1})
            If Not OpenElsenova2 Then TempLocation.RequiredPowers.AddRange({Powers.Kilver})
            TempLocation.RequiredJump = 8
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Climb out of the Pit"
            TempLocation.Vanilla = ItemType.Grapple
            TempLocation.VanillaPlacement = 55
            TempLocation.Region = Area.Kur
            TempLocation.LineNumber1 = 4781
            TempLocation.XLocation = 8048
            TempLocation.YLocation = 2016
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Drill, Powers.LabCoat, Powers.Drone})
            If Not OpenAbsu3 Then TempLocation.RequiredPowers.AddRange({Powers.Glitch1})
            If Not OpenElsenova2 Then TempLocation.RequiredPowers.AddRange({Powers.Kilver})
            TempLocation.RequiredJump = 6
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Grappled Mountain Slope"
            TempLocation.Vanilla = ItemType.HealthNodeFragment 'HealthNodeFragment8
            TempLocation.VanillaPlacement = 46
            TempLocation.Region = Area.Kur
            TempLocation.LineNumber1 = 4785
            TempLocation.XLocation = 1728
            TempLocation.YLocation = 3184
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Drill, Powers.LabCoat, Powers.Grapple})
            If Not OpenAbsu3 Then TempLocation.RequiredPowers.AddRange({Powers.Glitch1})
            If Not OpenElsenova2 Then TempLocation.RequiredPowers.AddRange({Powers.Kilver})
            TempLocation.RequiredJump = 6
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Above Lair"
            TempLocation.Vanilla = ItemType.HealthNodeFragment 'HealthNodeFragment9
            TempLocation.VanillaPlacement = 53
            TempLocation.Region = Area.Kur
            TempLocation.LineNumber1 = 4791
            TempLocation.XLocation = 3120
            TempLocation.YLocation = 4320
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Drill, Powers.LabCoat, Powers.Drone, Powers.Glitch2})
            If Not OpenElsenova2 Then TempLocation.RequiredPowers.AddRange({Powers.Kilver})
            TempLocation.RequiredJump = 6
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            '3-10-2019
            TempLocation = New Location()
            TempLocation.Name = "Crumbling Blocks"
            TempLocation.Vanilla = ItemType.PowerNode 'PowerNode4
            TempLocation.VanillaPlacement = 62
            TempLocation.Region = Area.Kur
            TempLocation.LineNumber1 = 4847
            TempLocation.XLocation = 7760
            TempLocation.YLocation = 1264
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Drill, Powers.LabCoat, Powers.Grapple})
            If Not OpenElsenova2 Then TempLocation.RequiredPowers.AddRange({Powers.Kilver})
            If Not OpenAbsu3 Then TempLocation.RequiredPowers.AddRange({Powers.Glitch1})
            TempLocation.RequiredJump = 6
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Stalagmite Maze"
            TempLocation.Vanilla = ItemType.TetheredCharge
            TempLocation.VanillaPlacement = 58
            TempLocation.Region = Area.Kur
            TempLocation.LineNumber1 = 4975
            TempLocation.XLocation = 4560
            TempLocation.YLocation = 6656
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.HighJump, Powers.LabCoat, Powers.Grapple, Powers.Glitch1, Powers.FatBeam, Powers.Drone}) 'Patience Young Skywalker
            If Not OpenElsenova2 Then TempLocation.RequiredPowers.AddRange({Powers.Kilver})
            If Not OpenEribu1 Then TempLocation.RequiredPowers.AddRange({Powers.Drill})
            TempLocation.RequiredJump = 8
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Hidden Ice Crags"
            TempLocation.Vanilla = ItemType.Lore 'Note13
            TempLocation.VanillaPlacement = 59
            TempLocation.Region = Area.Kur
            TempLocation.LineNumber1 = 4953
            TempLocation.XLocation = 4192
            TempLocation.YLocation = 2304
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Drill, Powers.LabCoat, Powers.Grapple, Powers.Drone})
            If Not OpenElsenova2 Then TempLocation.RequiredPowers.AddRange({Powers.Kilver})
            If Not OpenAbsu3 Then TempLocation.RequiredPowers.AddRange({Powers.Glitch1})
            TempLocation.RequiredJump = 6
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Above Stalagmites"
            TempLocation.Vanilla = ItemType.Reflect
            TempLocation.VanillaPlacement = 65
            TempLocation.Region = Area.Kur
            TempLocation.LineNumber1 = 4929
            TempLocation.XLocation = 5504
            TempLocation.YLocation = 1472
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Drill, Powers.LabCoat, Powers.Grapple, Powers.Drone})
            If Not OpenElsenova2 Then TempLocation.RequiredPowers.AddRange({Powers.Kilver})
            If Not OpenAbsu3 Then TempLocation.RequiredPowers.AddRange({Powers.Glitch1})
            TempLocation.RequiredJump = 6
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Ice Crag Ruins"
            TempLocation.Vanilla = ItemType.EnhancedLaunch
            TempLocation.VanillaPlacement = 66
            TempLocation.Region = Area.Kur
            TempLocation.LineNumber1 = 4928
            TempLocation.XLocation = 5024
            TempLocation.YLocation = 1792
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Drill, Powers.LabCoat, Powers.Grapple, Powers.Drone})
            If Not OpenAbsu3 Then TempLocation.RequiredPowers.AddRange({Powers.Glitch1})
            If Not OpenElsenova2 Then TempLocation.RequiredPowers.AddRange({Powers.Kilver})
            TempLocation.RequiredJump = 6
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Hidden Stalagmite"
            TempLocation.Vanilla = ItemType.HealthNodeFragment 'HealthNodeFragment12
            TempLocation.VanillaPlacement = 60
            TempLocation.Region = Area.Kur
            TempLocation.LineNumber1 = 4911
            TempLocation.XLocation = 4576
            TempLocation.YLocation = 2096
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Drill, Powers.LabCoat, Powers.Grapple, Powers.Drone})
            If Not OpenAbsu3 Then TempLocation.RequiredPowers.AddRange({Powers.Glitch1})
            If Not OpenElsenova2 Then TempLocation.RequiredPowers.AddRange({Powers.Kilver})
            TempLocation.RequiredJump = 6
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "High Up Ice Crags"
            TempLocation.Vanilla = ItemType.Lore
            TempLocation.VanillaPlacement = 63
            TempLocation.Region = Area.Kur
            TempLocation.LineNumber1 = 4952
            TempLocation.XLocation = 2016
            TempLocation.YLocation = 1632
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Drill, Powers.Glitch1, Powers.LabCoat, Powers.Grapple})
            If Not OpenElsenova2 Then TempLocation.RequiredPowers.AddRange({Powers.Kilver})
            TempLocation.RequiredJump = 8
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Higher Up Ice Crags"
            TempLocation.Vanilla = ItemType.PowerNodeFragment
            TempLocation.VanillaPlacement = 64
            TempLocation.Region = Area.Kur
            TempLocation.LineNumber1 = 4958
            TempLocation.XLocation = 2176
            TempLocation.YLocation = 1440
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Drill, Powers.Glitch1, Powers.LabCoat, Powers.Grapple})
            If Not OpenElsenova2 Then TempLocation.RequiredPowers.AddRange({Powers.Kilver})
            TempLocation.RequiredJump = 8
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Top of Kur"
            TempLocation.Vanilla = ItemType.Lore 'Note12
            TempLocation.VanillaPlacement = 70
            TempLocation.Region = Area.Kur
            TempLocation.LineNumber1 = 4956
            TempLocation.XLocation = 3424
            TempLocation.YLocation = 576
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Drill, Powers.LabCoat, Powers.Grapple, Powers.Drone, Powers.EnhancedLaunch, Powers.DroneTeleport}) 'perhaps could be trimmed down
            If Not OpenElsenova2 Then TempLocation.RequiredPowers.AddRange({Powers.Kilver})
            TempLocation.RequiredJump = 8
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
#End Region
#Region "Area 5 - Indi"
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Near Eribu"
            TempLocation.Vanilla = ItemType.Lore
            TempLocation.VanillaPlacement = 48
            TempLocation.Region = Area.Indi
            TempLocation.LineNumber1 = 2580
            TempLocation.XLocation = 128
            TempLocation.YLocation = 608
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Drone})
            If Not OpenEribu1 Then TempLocation.RequiredPowers.AddRange({Powers.Drill})
            If Not OpenAbsu3 Then TempLocation.RequiredPowers.AddRange({Powers.Glitch1})
            If Not OpenElsenova2 Then TempLocation.RequiredPowers.AddRange({Powers.Kilver})
            TempLocation.RequiredJump = 7
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Near Edin"
            TempLocation.Vanilla = ItemType.Lore
            TempLocation.VanillaPlacement = 72
            TempLocation.Region = Area.Indi
            TempLocation.LineNumber1 = 2578
            TempLocation.XLocation = 11344
            TempLocation.YLocation = 336
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.LabCoat, Powers.TrenchCoat})
            If Not OpenEribu1 Then TempLocation.RequiredPowers.AddRange({Powers.Drill})
            If Not OpenAbsu3 Then TempLocation.RequiredPowers.AddRange({Powers.Glitch1})
            If Not OpenElsenova2 Then TempLocation.RequiredPowers.AddRange({Powers.Kilver})
            TempLocation.RequiredJump = 9 'Potentially a 7
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
#End Region
#Region "Area 6 - Ukkin-Na"
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Above Ophelia"
            TempLocation.Vanilla = ItemType.Lore 'Note8
            TempLocation.VanillaPlacement = 78
            TempLocation.Region = Area.UkkinNa
            TempLocation.LineNumber1 = 6163
            TempLocation.XLocation = 1312
            TempLocation.YLocation = 1648
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Glitch1, Powers.Glitch2, Powers.LabCoat})
            If Not OpenEribu1 Then TempLocation.RequiredPowers.AddRange({Powers.Drill})
            TempLocation.RequiredJump = 8
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Above Insanity"
            TempLocation.Vanilla = ItemType.BlackCoat
            TempLocation.VanillaPlacement = 67
            TempLocation.Region = Area.UkkinNa
            TempLocation.LineNumber1 = 6147
            TempLocation.XLocation = 3616
            TempLocation.YLocation = 2672
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Glitch1, Powers.Glitch2, Powers.TrenchCoat})
            If Not OpenEribu1 Then TempLocation.RequiredPowers.AddRange({Powers.Drill})
            TempLocation.RequiredJump = 6
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Above Waiter"
            TempLocation.Vanilla = ItemType.HealthNodeFragment
            TempLocation.VanillaPlacement = 80
            TempLocation.Region = Area.UkkinNa
            TempLocation.LineNumber1 = 6145
            TempLocation.XLocation = 1728
            TempLocation.YLocation = 4608
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.LabCoat, Powers.Glitch1, Powers.Glitch2})
            If Not OpenEribu1 Then TempLocation.RequiredPowers.AddRange({Powers.Drill})
            TempLocation.RequiredJump = 9
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Right of Ophelia"
            TempLocation.Vanilla = ItemType.HealthNode
            TempLocation.VanillaPlacement = 77
            TempLocation.Region = Area.UkkinNa
            TempLocation.LineNumber1 = 6137
            TempLocation.XLocation = 1648
            TempLocation.YLocation = 2208
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Glitch1, Powers.Glitch2, Powers.TrenchCoat})
            If Not OpenEribu1 Then TempLocation.RequiredPowers.AddRange({Powers.Drill})
            TempLocation.RequiredJump = 6
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Hidden Psychosis"
            TempLocation.Vanilla = ItemType.PowerNodeFragment 'PowerNodeFragment13
            TempLocation.VanillaPlacement = 75
            TempLocation.Region = Area.UkkinNa
            TempLocation.LineNumber1 = 6168
            TempLocation.XLocation = 4528
            TempLocation.YLocation = 2080
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.LabCoat, Powers.Glitch1, Powers.Glitch2, Powers.Drone})
            If Not OpenEribu1 Then TempLocation.RequiredPowers.AddRange({Powers.Drill})
            TempLocation.RequiredJump = 6
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Wall Blocked Insanity"
            TempLocation.Vanilla = ItemType.PowerNodeFragment 'PowerNodeFragment15
            TempLocation.VanillaPlacement = 74
            TempLocation.Region = Area.UkkinNa
            TempLocation.LineNumber1 = 6167
            TempLocation.XLocation = 3456
            TempLocation.YLocation = 3456
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.LabCoat, Powers.Glitch1, Powers.Glitch2, Powers.TrenchCoat})
            If Not OpenEribu1 Then TempLocation.RequiredPowers.AddRange({Powers.Drill})
            TempLocation.RequiredJump = 6
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Hidden Maddness"
            TempLocation.Vanilla = ItemType.Lore 'Note22
            TempLocation.VanillaPlacement = 73
            TempLocation.Region = Area.UkkinNa
            TempLocation.LineNumber1 = 6164
            TempLocation.XLocation = 2928
            TempLocation.YLocation = 4256
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.LabCoat, Powers.Glitch1, Powers.Glitch2, Powers.TrenchCoat, Powers.Drone})
            If Not OpenEribu1 Then TempLocation.RequiredPowers.AddRange({Powers.Drill})
            TempLocation.RequiredJump = 6
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Drop Below Ophelia"
            TempLocation.Vanilla = ItemType.Lore 'Note23
            TempLocation.VanillaPlacement = 79
            TempLocation.Region = Area.UkkinNa
            TempLocation.LineNumber1 = 6162
            TempLocation.XLocation = 1664
            TempLocation.YLocation = 4384
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.LabCoat, Powers.Glitch1, Powers.Glitch2, Powers.TrenchCoat})
            If Not OpenEribu1 Then TempLocation.RequiredPowers.AddRange({Powers.Drill})
            TempLocation.RequiredJump = 6
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Below Madness"
            TempLocation.Vanilla = ItemType.PowerNodeFragment 'PowerNodeFragment10
            TempLocation.VanillaPlacement = 110
            TempLocation.Region = Area.UkkinNa
            TempLocation.LineNumber1 = 6148
            TempLocation.XLocation = 4208
            TempLocation.YLocation = 4816
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Drill, Powers.LabCoat, Powers.Glitch1, Powers.Glitch2, Powers.TrenchCoat})
            If Not OpenEribu1 Then TempLocation.RequiredPowers.AddRange({Powers.Drill})
            TempLocation.RequiredJump = 6
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Below Pep talk"
            TempLocation.Vanilla = ItemType.HealthNodeFragment 'HealthNodeFragment16
            TempLocation.VanillaPlacement = 76
            TempLocation.Region = Area.UkkinNa
            TempLocation.LineNumber1 = 6140
            TempLocation.XLocation = 3744
            TempLocation.YLocation = 1568
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.LabCoat, Powers.TrenchCoat, Powers.Glitch1, Powers.Glitch2, Powers.Drone})
            If Not OpenEribu1 Then TempLocation.RequiredPowers.AddRange({Powers.Drill})
            TempLocation.RequiredJump = 6
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "High Above Pop Talk"
            TempLocation.Vanilla = ItemType.HealthNodeFragment
            TempLocation.VanillaPlacement = 97
            TempLocation.Region = Area.UkkinNa
            TempLocation.LineNumber1 = 6165
            TempLocation.XLocation = 4672
            TempLocation.YLocation = 272
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.LabCoat, Powers.Glitch1, Powers.Glitch2, Powers.Drone, Powers.EnhancedLaunch, Powers.DroneTeleport})
            If Not OpenEribu1 Then TempLocation.RequiredPowers.AddRange({Powers.Drill})
            TempLocation.RequiredJump = 6
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
#End Region
#Region "Area 7 - Edin"
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Rusalki Bodies"
            TempLocation.Vanilla = ItemType.GlitchBomb
            TempLocation.VanillaPlacement = 85
            TempLocation.Region = Area.Edin
            TempLocation.LineNumber1 = 4326
            TempLocation.XLocation = 7456
            TempLocation.YLocation = 3696
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.LabCoat, Powers.TrenchCoat})
            If Not OpenEribu1 Then TempLocation.RequiredPowers.AddRange({Powers.Drill})
            TempLocation.RequiredJump = 8 '6 + trench to make it through the red gate
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Hangar Entrance"
            TempLocation.Vanilla = ItemType.Lore 'Note18
            TempLocation.VanillaPlacement = 81
            TempLocation.Region = Area.Edin
            TempLocation.LineNumber1 = 4362
            TempLocation.XLocation = 6160
            TempLocation.YLocation = 3200
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Drill, Powers.LabCoat, Powers.TrenchCoat})
            TempLocation.RequiredJump = 8 '6 + trench to make it through the red gate
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Western Hangar Entrance"
            TempLocation.Vanilla = ItemType.Lore 'Note27
            TempLocation.VanillaPlacement = 82
            TempLocation.Region = Area.Edin
            TempLocation.LineNumber1 = 4361
            TempLocation.XLocation = 5584
            TempLocation.YLocation = 2928
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Drill, Powers.LabCoat, Powers.TrenchCoat})
            TempLocation.RequiredJump = 8 '6 + trench to make it through the red gate
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "West Tower Secret"
            TempLocation.Vanilla = ItemType.Lore 'Note5
            TempLocation.VanillaPlacement = 93
            TempLocation.Region = Area.Edin
            TempLocation.LineNumber1 = 4357
            TempLocation.XLocation = 4192
            TempLocation.YLocation = 2880
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.LabCoat, Powers.TrenchCoat})
            If Not OpenEribu1 Then TempLocation.RequiredPowers.AddRange({Powers.Drill})
            TempLocation.RequiredJump = 8 '6 + trench to make it  through the lvl 3 glitch
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Above Clone Entrance"
            TempLocation.Vanilla = ItemType.HealthNodeFragment
            TempLocation.VanillaPlacement = 83
            TempLocation.Region = Area.Edin
            TempLocation.LineNumber1 = 4367
            TempLocation.XLocation = 5456
            TempLocation.YLocation = 2160
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.LabCoat, Powers.TrenchCoat, Powers.Grapple, Powers.Drone, Powers.EnhancedLaunch})
            If Not OpenEribu1 Then TempLocation.RequiredPowers.AddRange({Powers.Drill})
            TempLocation.RequiredJump = 8 '6 + trench to make it through the red gate
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "After Ukhu"
            TempLocation.Vanilla = ItemType.DroneTeleport
            TempLocation.VanillaPlacement = 94
            TempLocation.Region = Area.Edin
            TempLocation.LineNumber1 = 4328
            TempLocation.XLocation = 2240
            TempLocation.YLocation = 1248
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Drill, Powers.HighJump, Powers.LabCoat, Powers.TrenchCoat, Powers.Drone})
            If Not OpenEribu1 Then TempLocation.RequiredPowers.AddRange({Powers.Drill})
            TempLocation.RequiredJump = 8 '6 + trench to make it through the lvl 3 glitch
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Below Ukhu"
            TempLocation.Vanilla = ItemType.Lore 'Note4
            TempLocation.VanillaPlacement = 98
            TempLocation.Region = Area.Edin
            TempLocation.LineNumber1 = 4356
            TempLocation.XLocation = 3472
            TempLocation.YLocation = 1824
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.LabCoat, Powers.TrenchCoat, Powers.Drone, Powers.DroneTeleport})
            If Not OpenEribu1 Then TempLocation.RequiredPowers.AddRange({Powers.Drill})
            TempLocation.RequiredJump = 8 '6 + trench to make it through the lvl 3 glitch
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Hidden Tunnel West"
            TempLocation.Vanilla = ItemType.RangeNode 'RangeNode3
            TempLocation.VanillaPlacement = 91
            TempLocation.Region = Area.Edin
            TempLocation.LineNumber1 = 4329
            TempLocation.XLocation = 4688
            TempLocation.YLocation = 3744
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.LabCoat, Powers.TrenchCoat, Powers.Drone})
            If Not OpenEribu1 Then TempLocation.RequiredPowers.AddRange({Powers.Drill})
            TempLocation.RequiredJump = 8 '6 + trench to make it through the lvl 3 glitch
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "West Tower West Secret"
            TempLocation.Vanilla = ItemType.HealthNode 'HealthNode7
            TempLocation.VanillaPlacement = 99
            TempLocation.Region = Area.Edin
            TempLocation.LineNumber1 = 4342
            TempLocation.XLocation = 2464
            TempLocation.YLocation = 2384
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.LabCoat, Powers.TrenchCoat, Powers.Drone, Powers.DroneTeleport})
            If Not OpenEribu1 Then TempLocation.RequiredPowers.AddRange({Powers.Drill})
            TempLocation.RequiredJump = 8 '6 + trench to make it through the lvl 3 glitch
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Above West Tower"
            TempLocation.Vanilla = ItemType.PowerNodeFragment 'PowerNodeFragment17
            TempLocation.VanillaPlacement = 100
            TempLocation.Region = Area.Edin
            TempLocation.LineNumber1 = 4363
            TempLocation.XLocation = 3424
            TempLocation.YLocation = 2112
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.LabCoat, Powers.TrenchCoat, Powers.Drone, Powers.DroneTeleport})
            If Not OpenEribu1 Then TempLocation.RequiredPowers.AddRange({Powers.Drill})
            TempLocation.RequiredJump = 8 '6 + trench to make it through the lvl 3 glitch
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Hangar Attic"
            TempLocation.Vanilla = ItemType.PowerNode 'PowerNode5
            TempLocation.VanillaPlacement = 89
            TempLocation.Region = Area.Edin
            TempLocation.LineNumber1 = 4366
            TempLocation.XLocation = 6960
            TempLocation.YLocation = 3216
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Drill, Powers.LabCoat, Powers.TrenchCoat, Powers.Glitch3})
            If Not OpenEribu1 Then TempLocation.RequiredPowers.AddRange({Powers.Drill})
            TempLocation.RequiredJump = 9 '8 + trench to make it through the lvl 3 glitch
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Hangar Attic Second"
            TempLocation.Vanilla = ItemType.HealthNode 'HealthNode6
            TempLocation.VanillaPlacement = 90
            TempLocation.Region = Area.Edin
            TempLocation.LineNumber1 = 4335
            TempLocation.XLocation = 6928
            TempLocation.YLocation = 3216
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Drill, Powers.LabCoat, Powers.TrenchCoat, Powers.Glitch3})
            If Not OpenEribu1 Then TempLocation.RequiredPowers.AddRange({Powers.Drill})
            TempLocation.RequiredJump = 9 '8 + trench to make it through the lvl 3 glitch
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Open Air Grapple"
            TempLocation.Vanilla = ItemType.HealthNodeFragment
            TempLocation.VanillaPlacement = 102
            TempLocation.Region = Area.Edin
            TempLocation.LineNumber1 = 4368
            TempLocation.XLocation = 528
            TempLocation.YLocation = 3264
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.LabCoat, Powers.TrenchCoat, Powers.Drone, Powers.EnhancedLaunch, Powers.DroneTeleport})
            If Not OpenEribu1 Then TempLocation.RequiredPowers.AddRange({Powers.Drill})
            TempLocation.RequiredJump = 6 'just because of previous areas
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "West Tower Base"
            TempLocation.Vanilla = ItemType.Shards
            TempLocation.VanillaPlacement = 92
            TempLocation.Region = Area.Edin
            TempLocation.LineNumber1 = 4341
            TempLocation.XLocation = 3392
            TempLocation.YLocation = 3632
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.LabCoat, Powers.TrenchCoat, Powers.Glitch3})
            If Not OpenEribu1 Then TempLocation.RequiredPowers.AddRange({Powers.Drill})
            TempLocation.RequiredJump = 6 'just because of previous areas
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Hangar Foyer"
            TempLocation.Vanilla = ItemType.DistortionField
            TempLocation.VanillaPlacement = 84
            TempLocation.Region = Area.Edin
            TempLocation.LineNumber1 = 4330
            TempLocation.XLocation = 6000
            TempLocation.YLocation = 1872
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.LabCoat, Powers.TrenchCoat, Powers.Glitch1, Powers.Drone, Powers.EnhancedLaunch, Powers.DroneTeleport})
            If Not OpenEribu1 Then TempLocation.RequiredPowers.AddRange({Powers.Drill})
            TempLocation.RequiredJump = 8 '6 + trench to make it through the red gate
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Suspended Room"
            TempLocation.Vanilla = ItemType.TendrilsBottom
            TempLocation.VanillaPlacement = 101
            TempLocation.Region = Area.Edin
            TempLocation.LineNumber1 = 4343
            TempLocation.XLocation = 2000
            TempLocation.YLocation = 3088
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.LabCoat, Powers.TrenchCoat, Powers.Grapple, Powers.Glitch1, Powers.Drone, Powers.EnhancedLaunch, Powers.DroneTeleport})
            If Not OpenEribu1 Then TempLocation.RequiredPowers.AddRange({Powers.Drill})
            TempLocation.RequiredJump = 6 'just because of previous areas
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
#End Region
#Region "Area 8 - E-Kur-Mah"
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Behind Seal"
            TempLocation.Vanilla = ItemType.PowerNode 'PowerNode6
            TempLocation.VanillaPlacement = 106
            TempLocation.Region = Area.EKurMah
            TempLocation.LineNumber1 = 3723
            TempLocation.XLocation = 1040
            TempLocation.YLocation = 512
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.LabCoat, Powers.TrenchCoat, Powers.Drone, Powers.DroneTeleport, Powers.EnhancedLaunch, Powers.Key})
            If Not OpenEribu1 Then TempLocation.RequiredPowers.AddRange({Powers.Drill})
            TempLocation.RequiredJump = 8 'some height req because of grapple partial req
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "RedCoat Exhibition"
            TempLocation.Vanilla = ItemType.PowerNodeFragment
            TempLocation.VanillaPlacement = 111
            TempLocation.Region = Area.EKurMah
            TempLocation.LineNumber1 = 3705
            TempLocation.XLocation = 1984
            TempLocation.YLocation = 5936
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.LabCoat, Powers.TrenchCoat, Powers.RedCoat, Powers.Key})
            If Not OpenEribu1 Then TempLocation.RequiredPowers.AddRange({Powers.Drill})
            TempLocation.RequiredJump = 8 'some height req because of grapple partial req
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Secondary Key Chamber"
            TempLocation.Vanilla = ItemType.Lore 'Note3
            TempLocation.VanillaPlacement = 104
            TempLocation.Region = Area.EKurMah
            TempLocation.LineNumber1 = 3683
            TempLocation.XLocation = 3744
            TempLocation.YLocation = 960
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Drone, Powers.DroneTeleport, Powers.EnhancedLaunch, Powers.TrenchCoat})
            If Not OpenEribu1 Then TempLocation.RequiredPowers.AddRange({Powers.Drill})
            TempLocation.RequiredJump = 8 'some height req because of grapple partial req
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Drilled In Entrance"
            TempLocation.Vanilla = ItemType.Lore 'Note1
            TempLocation.VanillaPlacement = 103
            TempLocation.Region = Area.EKurMah
            TempLocation.LineNumber1 = 3682
            TempLocation.XLocation = 1136
            TempLocation.YLocation = 1168
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Drill, Powers.LabCoat, Powers.TrenchCoat, Powers.Drone, Powers.DroneTeleport, Powers.EnhancedLaunch})
            TempLocation.RequiredJump = 8 'some height req because of grapple partial req
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Basement"
            TempLocation.Vanilla = ItemType.RedCoat
            TempLocation.VanillaPlacement = 108
            TempLocation.Region = Area.EKurMah
            TempLocation.LineNumber1 = 3661
            TempLocation.XLocation = 1664
            TempLocation.YLocation = 5600
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Drill, Powers.LabCoat, Powers.TrenchCoat, Powers.Drone, Powers.DroneTeleport, Powers.EnhancedLaunch, Powers.Key})
            TempLocation.RequiredJump = 8 'some height req because of grapple partial req
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Primary Key Chamber"
            TempLocation.Vanilla = ItemType.BreachSuppressor
            TempLocation.VanillaPlacement = 105
            TempLocation.Region = Area.EKurMah
            TempLocation.LineNumber1 = 3658
            TempLocation.XLocation = 3296
            TempLocation.YLocation = 672
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.TrenchCoat, Powers.Drone, Powers.DroneTeleport, Powers.EnhancedLaunch})
            If Not OpenEribu1 Then TempLocation.RequiredPowers.AddRange({Powers.Drill})
            TempLocation.RequiredJump = 8 'some height req because of grapple partial req
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Verdan Cavern"
            TempLocation.Vanilla = ItemType.HealthNodeFragment
            TempLocation.VanillaPlacement = 107
            TempLocation.Region = Area.EKurMah
            TempLocation.LineNumber1 = 3659
            TempLocation.XLocation = 2848
            TempLocation.YLocation = 4896
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Drill, Powers.LabCoat, Powers.TrenchCoat, Powers.Drone, Powers.DroneTeleport, Powers.EnhancedLaunch, Powers.Key})
            TempLocation.RequiredJump = 10
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Basement Shaft"
            TempLocation.Vanilla = ItemType.Lore 'Note11
            TempLocation.VanillaPlacement = 107
            TempLocation.Region = Area.EKurMah
            TempLocation.LineNumber1 = 3688
            TempLocation.XLocation = 3520
            TempLocation.YLocation = 2288
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.LabCoat, Powers.TrenchCoat, Powers.RedCoat, Powers.Drone, Powers.DroneTeleport, Powers.EnhancedLaunch, Powers.Key})
            If Not OpenEribu1 Then TempLocation.RequiredPowers.AddRange({Powers.Drill})
            TempLocation.RequiredJump = 8 'some height req because of grapple partial req
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Passworded Verdan Cavern"
            TempLocation.Vanilla = ItemType.Swim
            TempLocation.VanillaPlacement = 123
            TempLocation.Region = Area.EKurMah
            TempLocation.LineNumber1 = 3660
            TempLocation.XLocation = 1544
            TempLocation.YLocation = 4432
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.LabCoat, Powers.TrenchCoat, Powers.Drone, Powers.DroneTeleport, Powers.EnhancedLaunch, Powers.Key, Powers.Passwords})
            If Not OpenEribu1 Then TempLocation.RequiredPowers.AddRange({Powers.Drill})
            TempLocation.RequiredJump = 10
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
#End Region
#Region "Area 9 - Mar-Uru"
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Above Save Room"
            TempLocation.Vanilla = ItemType.Lore 'Note26
            TempLocation.VanillaPlacement = 117
            TempLocation.Region = Area.MarUru
            TempLocation.LineNumber1 = 11952
            TempLocation.XLocation = 1696
            TempLocation.YLocation = 3744
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Drill, Powers.LabCoat, Powers.TrenchCoat, Powers.RedCoat, Powers.Drone, Powers.EnhancedLaunch, Powers.DroneTeleport})
            TempLocation.RequiredJump = 8 '6 + 2 for red coat
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Final Shaft"
            TempLocation.Vanilla = ItemType.Lore 'Note21
            TempLocation.VanillaPlacement = 119
            TempLocation.Region = Area.MarUru
            TempLocation.LineNumber1 = 11951
            TempLocation.XLocation = 2016
            TempLocation.YLocation = 2496
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Drill, Powers.LabCoat, Powers.TrenchCoat, Powers.RedCoat, Powers.Drone, Powers.EnhancedLaunch, Powers.DroneTeleport})
            TempLocation.RequiredJump = 8 '6 + 2 for red coat
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Hybrid Room"
            TempLocation.Vanilla = ItemType.SizeNode 'SizeNode4
            TempLocation.VanillaPlacement = 116
            TempLocation.Region = Area.MarUru
            TempLocation.LineNumber1 = 11947
            TempLocation.XLocation = 3072
            TempLocation.YLocation = 4320
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Drill, Powers.LabCoat, Powers.TrenchCoat, Powers.RedCoat, Powers.Drone, Powers.EnhancedLaunch, Powers.DroneTeleport})
            TempLocation.RequiredJump = 8 '6 + 2 for red coat
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "After Sentinel"
            TempLocation.Vanilla = ItemType.HealthNode 'HealthNode8
            TempLocation.VanillaPlacement = 112
            TempLocation.Region = Area.MarUru
            TempLocation.LineNumber1 = 11944
            TempLocation.XLocation = 1520
            TempLocation.YLocation = 5312
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Drill, Powers.LabCoat, Powers.TrenchCoat, Powers.RedCoat, Powers.Drone, Powers.EnhancedLaunch, Powers.DroneTeleport})
            TempLocation.RequiredJump = 8 '6 + 2 for red coat
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Glitch Room Below"
            TempLocation.Vanilla = ItemType.Lore 'Note6
            TempLocation.VanillaPlacement = 114
            TempLocation.Region = Area.MarUru
            TempLocation.LineNumber1 = 11946
            TempLocation.XLocation = 2544
            TempLocation.YLocation = 5632
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Drill, Powers.Glitch2, Powers.LabCoat, Powers.TrenchCoat, Powers.RedCoat, Powers.Drone, Powers.EnhancedLaunch, Powers.DroneTeleport})
            TempLocation.RequiredJump = 8 '6 + 2 for red coat
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Hidden Left of Save"
            TempLocation.Vanilla = ItemType.Scythe
            TempLocation.VanillaPlacement = 118
            TempLocation.Region = Area.MarUru
            TempLocation.LineNumber1 = 11953
            TempLocation.XLocation = 1200
            TempLocation.YLocation = 4224
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Drill, Powers.Glitch2, Powers.LabCoat, Powers.TrenchCoat, Powers.RedCoat, Powers.Drone, Powers.EnhancedLaunch, Powers.DroneTeleport})
            TempLocation.RequiredJump = 8 '6 + 2 for red coat
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Glitch Room Hidden"
            TempLocation.Vanilla = ItemType.PowerNodeFragment
            TempLocation.VanillaPlacement = 115
            TempLocation.Region = Area.MarUru
            TempLocation.LineNumber1 = 11946
            TempLocation.XLocation = 2768
            TempLocation.YLocation = 5632
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Drill, Powers.Glitch2, Powers.LabCoat, Powers.TrenchCoat, Powers.RedCoat, Powers.Drone, Powers.EnhancedLaunch, Powers.DroneTeleport})
            TempLocation.RequiredJump = 8 '6 + 2 for red coat
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Glitch Room Primary"
            TempLocation.Vanilla = ItemType.PowerNodeFragment
            TempLocation.VanillaPlacement = 113
            TempLocation.Region = Area.MarUru
            TempLocation.LineNumber1 = 11945
            TempLocation.XLocation = 2624
            TempLocation.YLocation = 5408
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Drill, Powers.Glitch2, Powers.LabCoat, Powers.TrenchCoat, Powers.RedCoat, Powers.Drone, Powers.EnhancedLaunch, Powers.DroneTeleport})
            TempLocation.RequiredJump = 8 '6 + 2 for red coat
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            Locations.Add(TempLocation)
#End Region
            Return Locations
        End Function
    End Class
    Public Class PracticeLocations
        Public Shared Function ResetLocations(Optional OpenEribu1 As Boolean = False, Optional OpenAbsu2 As Boolean = False)

            Dim Locations As List(Of Location)
            Locations = New List(Of Location)
            Dim TempLocation As Location
#Region "PowerUp Locations"
            '__________________________
            TempLocation = New Location()
            TempLocation.Name = "Practice 1"
            TempLocation.Region = Area.Eribu
            TempLocation.AddedDrop = True
            TempLocation.XLocation = 4416
            TempLocation.YLocation = 3120
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            TempLocation.Weight = 20
            Locations.Add(TempLocation)
            '__________________________
            TempLocation = New Location()
            TempLocation.Name = "Practice 2"
            TempLocation.Region = Area.Eribu
            TempLocation.AddedDrop = True
            TempLocation.XLocation = 4336
            TempLocation.YLocation = 3120
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            TempLocation.Weight = 19
            Locations.Add(TempLocation)
            '__________________________
            TempLocation = New Location()
            TempLocation.Name = "Practice 3"
            TempLocation.Region = Area.Eribu
            TempLocation.AddedDrop = True
            TempLocation.XLocation = 4304
            TempLocation.YLocation = 3120
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            TempLocation.Weight = 18
            Locations.Add(TempLocation)
            '__________________________
            TempLocation = New Location()
            TempLocation.Name = "Practice 4"
            TempLocation.Region = Area.Eribu
            TempLocation.AddedDrop = True
            TempLocation.XLocation = 4272
            TempLocation.YLocation = 3120
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            TempLocation.Weight = 17
            Locations.Add(TempLocation)
            '__________________________
            TempLocation = New Location()
            TempLocation.Name = "Practice 5"
            TempLocation.Region = Area.Eribu
            TempLocation.AddedDrop = True
            TempLocation.XLocation = 4240
            TempLocation.YLocation = 3120
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            TempLocation.Weight = 16
            Locations.Add(TempLocation)
            '__________________________
            TempLocation = New Location()
            TempLocation.Name = "Practice 6"
            TempLocation.Region = Area.Eribu
            TempLocation.AddedDrop = True
            TempLocation.XLocation = 4208
            TempLocation.YLocation = 3120
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            TempLocation.Weight = 15
            Locations.Add(TempLocation)
            '__________________________
            TempLocation = New Location()
            TempLocation.Name = "Practice 7"
            TempLocation.Region = Area.Eribu
            TempLocation.AddedDrop = True
            TempLocation.XLocation = 4176
            TempLocation.YLocation = 3120
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            TempLocation.Weight = 14
            Locations.Add(TempLocation)
            '__________________________
            TempLocation = New Location()
            TempLocation.Name = "Practice 8"
            TempLocation.Region = Area.Eribu
            TempLocation.AddedDrop = True
            TempLocation.XLocation = 4144
            TempLocation.YLocation = 3120
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            TempLocation.Weight = 13
            Locations.Add(TempLocation)
            '__________________________
            TempLocation = New Location()
            TempLocation.Name = "Practice 9"
            TempLocation.Region = Area.Eribu
            TempLocation.AddedDrop = True
            TempLocation.XLocation = 4112
            TempLocation.YLocation = 3120
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            TempLocation.Weight = 12
            Locations.Add(TempLocation)
            '__________________________
            TempLocation = New Location()
            TempLocation.Name = "Practice 10"
            TempLocation.Region = Area.Eribu
            TempLocation.AddedDrop = True
            TempLocation.XLocation = 4080
            TempLocation.YLocation = 3120
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            TempLocation.Weight = 11
            Locations.Add(TempLocation)
            '__________________________
            TempLocation = New Location()
            TempLocation.Name = "Practice 11"
            TempLocation.Region = Area.Eribu
            TempLocation.AddedDrop = True
            TempLocation.XLocation = 4048
            TempLocation.YLocation = 3120
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            TempLocation.Weight = 10
            Locations.Add(TempLocation)
            '__________________________
            TempLocation = New Location()
            TempLocation.Name = "Practice 12"
            TempLocation.Region = Area.Eribu
            TempLocation.AddedDrop = True
            TempLocation.XLocation = 4016
            TempLocation.YLocation = 3120
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            TempLocation.Weight = 9
            Locations.Add(TempLocation)
            '__________________________
            TempLocation = New Location()
            TempLocation.Name = "Practice 13"
            TempLocation.Region = Area.Eribu
            TempLocation.AddedDrop = True
            TempLocation.XLocation = 3984
            TempLocation.YLocation = 3120
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            TempLocation.Weight = 8
            Locations.Add(TempLocation)
            '__________________________
            TempLocation = New Location()
            TempLocation.Name = "Practice 14"
            TempLocation.Region = Area.Eribu
            TempLocation.AddedDrop = True
            TempLocation.XLocation = 3952
            TempLocation.YLocation = 3120
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            TempLocation.Weight = 7
            Locations.Add(TempLocation)
            '__________________________
            TempLocation = New Location()
            TempLocation.Name = "Practice 15"
            TempLocation.Region = Area.Eribu
            TempLocation.AddedDrop = True
            TempLocation.XLocation = 3920
            TempLocation.YLocation = 3120
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            TempLocation.Weight = 6
            Locations.Add(TempLocation)
#End Region
#Region "Weapon Locations"
            '__________________________
            'Adding Weapons
            TempLocation = New Location()
            TempLocation.Name = "Weapon 1"
            TempLocation.Region = Area.Eribu
            TempLocation.AddedDrop = True
            TempLocation.XLocation = 5296
            TempLocation.YLocation = 3104
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            TempLocation.Weight = 50
            Locations.Add(TempLocation)
            '__________________________
            TempLocation = New Location()
            TempLocation.Name = "Weapon 2"
            TempLocation.Region = Area.Eribu
            TempLocation.AddedDrop = True
            TempLocation.XLocation = 5328
            TempLocation.YLocation = 3104
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            TempLocation.Weight = 49
            Locations.Add(TempLocation)
            '__________________________
            TempLocation = New Location()
            TempLocation.Name = "Weapon 3"
            TempLocation.Region = Area.Eribu
            TempLocation.AddedDrop = True
            TempLocation.XLocation = 5360
            TempLocation.YLocation = 3104
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            TempLocation.Weight = 48
            Locations.Add(TempLocation)
            '__________________________
            TempLocation = New Location()
            TempLocation.Name = "Weapon 4"
            TempLocation.Region = Area.Eribu
            TempLocation.AddedDrop = True
            TempLocation.XLocation = 5392
            TempLocation.YLocation = 3104
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            TempLocation.Weight = 47
            Locations.Add(TempLocation)
            '__________________________
            TempLocation = New Location()
            TempLocation.Name = "Weapon 5"
            TempLocation.Region = Area.Eribu
            TempLocation.AddedDrop = True
            TempLocation.XLocation = 5424
            TempLocation.YLocation = 3104
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            TempLocation.Weight = 46
            Locations.Add(TempLocation)
            '__________________________
            TempLocation = New Location()
            TempLocation.Name = "Weapon 6"
            TempLocation.Region = Area.Eribu
            TempLocation.AddedDrop = True
            TempLocation.XLocation = 5456
            TempLocation.YLocation = 3104
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            TempLocation.Weight = 45
            Locations.Add(TempLocation)
            '__________________________
            TempLocation = New Location()
            TempLocation.Name = "Weapon 7"
            TempLocation.Region = Area.Eribu
            TempLocation.AddedDrop = True
            TempLocation.XLocation = 5488
            TempLocation.YLocation = 3104
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            TempLocation.Weight = 44
            Locations.Add(TempLocation)
            '__________________________
            TempLocation = New Location()
            TempLocation.Name = "Weapon 8"
            TempLocation.Region = Area.Eribu
            TempLocation.AddedDrop = True
            TempLocation.XLocation = 5520
            TempLocation.YLocation = 3104
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            TempLocation.Weight = 43
            Locations.Add(TempLocation)
            '__________________________
            TempLocation = New Location()
            TempLocation.Name = "Weapon 9"
            TempLocation.Region = Area.Eribu
            TempLocation.AddedDrop = True
            TempLocation.XLocation = 5552
            TempLocation.YLocation = 3104
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            TempLocation.Weight = 42
            Locations.Add(TempLocation)
            '__________________________
            TempLocation = New Location()
            TempLocation.Name = "Weapon 10"
            TempLocation.Region = Area.Eribu
            TempLocation.AddedDrop = True
            TempLocation.XLocation = 5584
            TempLocation.YLocation = 3104
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            TempLocation.Weight = 41
            Locations.Add(TempLocation)
            '__________________________
            TempLocation = New Location()
            TempLocation.Name = "Weapon 11"
            TempLocation.Region = Area.Eribu
            TempLocation.AddedDrop = True
            TempLocation.XLocation = 5616
            TempLocation.YLocation = 3104
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            TempLocation.Weight = 40
            Locations.Add(TempLocation)
            '__________________________
            TempLocation = New Location()
            TempLocation.Name = "Weapon 12"
            TempLocation.Region = Area.Eribu
            TempLocation.AddedDrop = True
            TempLocation.XLocation = 5648
            TempLocation.YLocation = 3104
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            TempLocation.Weight = 39
            Locations.Add(TempLocation)
            '__________________________
            TempLocation = New Location()
            TempLocation.Name = "Weapon 13"
            TempLocation.Region = Area.Eribu
            TempLocation.AddedDrop = True
            TempLocation.XLocation = 5680
            TempLocation.YLocation = 3104
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            TempLocation.Weight = 38
            Locations.Add(TempLocation)
            '__________________________
            TempLocation = New Location()
            TempLocation.Name = "Weapon 14"
            TempLocation.Region = Area.Eribu
            TempLocation.AddedDrop = True
            TempLocation.XLocation = 5712
            TempLocation.YLocation = 3104
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            TempLocation.Weight = 37
            Locations.Add(TempLocation)
            '__________________________
            TempLocation = New Location()
            TempLocation.Name = "Weapon 15"
            TempLocation.Region = Area.Eribu
            TempLocation.AddedDrop = True
            TempLocation.XLocation = 5744
            TempLocation.YLocation = 3104
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            TempLocation.Weight = 36
            Locations.Add(TempLocation)
            '__________________________
            TempLocation = New Location()
            TempLocation.Name = "Weapon 16"
            TempLocation.Region = Area.Eribu
            TempLocation.AddedDrop = True
            TempLocation.XLocation = 5776
            TempLocation.YLocation = 3104
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            TempLocation.Weight = 35
            Locations.Add(TempLocation)
            '__________________________
            TempLocation = New Location()
            TempLocation.Name = "Weapon 17"
            TempLocation.Region = Area.Eribu
            TempLocation.AddedDrop = True
            TempLocation.XLocation = 5808
            TempLocation.YLocation = 3104
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            TempLocation.Weight = 34
            Locations.Add(TempLocation)
            '__________________________
            TempLocation = New Location()
            TempLocation.Name = "Weapon 18"
            TempLocation.Region = Area.Eribu
            TempLocation.AddedDrop = True
            TempLocation.XLocation = 5840
            TempLocation.YLocation = 3104
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            TempLocation.Weight = 33
            Locations.Add(TempLocation)
            '__________________________
            TempLocation = New Location()
            TempLocation.Name = "Weapon 19"
            TempLocation.Region = Area.Eribu
            TempLocation.AddedDrop = True
            TempLocation.XLocation = 5872
            TempLocation.YLocation = 3104
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            TempLocation.Weight = 32
            Locations.Add(TempLocation)
            '__________________________
            TempLocation = New Location()
            TempLocation.Name = "Weapon 20"
            TempLocation.Region = Area.Eribu
            TempLocation.AddedDrop = True
            TempLocation.XLocation = 5904
            TempLocation.YLocation = 3120
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            TempLocation.Weight = 31
            Locations.Add(TempLocation)
            '__________________________
            TempLocation = New Location()
            TempLocation.Name = "Weapon 21"
            TempLocation.Region = Area.Eribu
            TempLocation.AddedDrop = True
            TempLocation.XLocation = 5936
            TempLocation.YLocation = 3104
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            TempLocation.Weight = 30
            Locations.Add(TempLocation)
            '__________________________
            TempLocation = New Location()
            TempLocation.Name = "Weapon 22"
            TempLocation.Region = Area.Eribu
            TempLocation.AddedDrop = True
            TempLocation.XLocation = 5968
            TempLocation.YLocation = 3104
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            TempLocation.Weight = 29
            Locations.Add(TempLocation)
#End Region
#Region "Node Locations"
            '__________________________
            TempLocation = New Location()
            TempLocation.Name = "Size Node 1"
            TempLocation.Region = Area.Eribu
            TempLocation.AddedDrop = True
            TempLocation.XLocation = 6592
            TempLocation.YLocation = 3168
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            TempLocation.Weight = 28
            Locations.Add(TempLocation)
            '__________________________
            TempLocation = New Location()
            TempLocation.Name = "Size Node 2"
            TempLocation.Region = Area.Eribu
            TempLocation.AddedDrop = True
            TempLocation.XLocation = 6592
            TempLocation.YLocation = 3136
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            TempLocation.Weight = 27
            Locations.Add(TempLocation)
            '__________________________
            TempLocation = New Location()
            TempLocation.Name = "Size Node 3"
            TempLocation.Region = Area.Eribu
            TempLocation.AddedDrop = True
            TempLocation.XLocation = 6624
            TempLocation.YLocation = 3136
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            TempLocation.Weight = 26
            Locations.Add(TempLocation)
            '__________________________
            TempLocation = New Location()
            TempLocation.Name = "Size Node 4"
            TempLocation.Region = Area.Eribu
            TempLocation.AddedDrop = True
            TempLocation.XLocation = 6624
            TempLocation.YLocation = 3104
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            TempLocation.Weight = 25
            Locations.Add(TempLocation)
            '__________________________
            TempLocation = New Location()
            TempLocation.Name = "Range Node 1"
            TempLocation.Region = Area.Eribu
            TempLocation.AddedDrop = True
            TempLocation.XLocation = 6320
            TempLocation.YLocation = 3136
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            TempLocation.Weight = 24
            Locations.Add(TempLocation)
            '__________________________
            TempLocation = New Location()
            TempLocation.Name = "Range Node 2"
            TempLocation.Region = Area.Eribu
            TempLocation.AddedDrop = True
            TempLocation.XLocation = 6320
            TempLocation.YLocation = 3104
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            TempLocation.Weight = 23
            Locations.Add(TempLocation)
            '__________________________
            TempLocation = New Location()
            TempLocation.Name = "Range Node 3"
            TempLocation.Region = Area.Eribu
            TempLocation.AddedDrop = True
            TempLocation.XLocation = 6352
            TempLocation.YLocation = 3136
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            TempLocation.Weight = 22
            Locations.Add(TempLocation)
            '__________________________
            TempLocation = New Location()
            TempLocation.Name = "Range Node 4"
            TempLocation.Region = Area.Eribu
            TempLocation.AddedDrop = True
            TempLocation.XLocation = 6352
            TempLocation.YLocation = 3104
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            TempLocation.Weight = 21
            Locations.Add(TempLocation)
            '__________________________
            TempLocation = New Location()
            TempLocation.Name = "Health Node 1"
            TempLocation.Region = Area.Eribu
            TempLocation.AddedDrop = True
            TempLocation.XLocation = 7088
            TempLocation.YLocation = 3200
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            TempLocation.Weight = 75
            Locations.Add(TempLocation)
            '__________________________
            TempLocation = New Location()
            TempLocation.Name = "Health Node 2"
            TempLocation.Region = Area.Eribu
            TempLocation.AddedDrop = True
            TempLocation.XLocation = 7088
            TempLocation.YLocation = 3168
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            TempLocation.Weight = 74
            Locations.Add(TempLocation)
            '__________________________
            TempLocation = New Location()
            TempLocation.Name = "Health Node 3"
            TempLocation.Region = Area.Eribu
            TempLocation.AddedDrop = True
            TempLocation.XLocation = 7088
            TempLocation.YLocation = 3136
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            TempLocation.Weight = 73
            Locations.Add(TempLocation)
            '__________________________
            TempLocation = New Location()
            TempLocation.Name = "Health Node 4"
            TempLocation.Region = Area.Eribu
            TempLocation.AddedDrop = True
            TempLocation.XLocation = 7056
            TempLocation.YLocation = 3200
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            TempLocation.Weight = 72
            Locations.Add(TempLocation)
            '__________________________
            TempLocation = New Location()
            TempLocation.Name = "Health Node 5"
            TempLocation.Region = Area.Eribu
            TempLocation.AddedDrop = True
            TempLocation.XLocation = 7056
            TempLocation.YLocation = 3168
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            TempLocation.Weight = 71
            Locations.Add(TempLocation)
            '__________________________
            TempLocation = New Location()
            TempLocation.Name = "Health Node 6"
            TempLocation.Region = Area.Eribu
            TempLocation.AddedDrop = True
            TempLocation.XLocation = 7056
            TempLocation.YLocation = 3136
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            TempLocation.Weight = 70
            Locations.Add(TempLocation)
            '__________________________
            TempLocation = New Location()
            TempLocation.Name = "Health Node 7"
            TempLocation.Region = Area.Eribu
            TempLocation.AddedDrop = True
            TempLocation.XLocation = 7024
            TempLocation.YLocation = 3136
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            TempLocation.Weight = 69
            Locations.Add(TempLocation)
            '__________________________
            TempLocation = New Location()
            TempLocation.Name = "Health Node 8"
            TempLocation.Region = Area.Eribu
            TempLocation.AddedDrop = True
            TempLocation.XLocation = 7024
            TempLocation.YLocation = 3168
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            TempLocation.Weight = 68
            Locations.Add(TempLocation)
            '__________________________
            TempLocation = New Location()
            TempLocation.Name = "Health Node 9"
            TempLocation.Region = Area.Eribu
            TempLocation.AddedDrop = True
            TempLocation.XLocation = 7024
            TempLocation.YLocation = 3200
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            TempLocation.Weight = 67
            Locations.Add(TempLocation)
            '__________________________
            TempLocation = New Location()
            TempLocation.Name = "Power Node 1"
            TempLocation.Region = Area.Eribu
            TempLocation.AddedDrop = True
            TempLocation.XLocation = 6800
            TempLocation.YLocation = 3152
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            TempLocation.Weight = 66
            Locations.Add(TempLocation)
            '__________________________
            TempLocation = New Location()
            TempLocation.Name = "Power Node 2"
            TempLocation.Region = Area.Eribu
            TempLocation.AddedDrop = True
            TempLocation.XLocation = 6800
            TempLocation.YLocation = 3120
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            TempLocation.Weight = 65
            Locations.Add(TempLocation)
            '__________________________
            TempLocation = New Location()
            TempLocation.Name = "Power Node 3"
            TempLocation.Region = Area.Eribu
            TempLocation.AddedDrop = True
            TempLocation.XLocation = 6832
            TempLocation.YLocation = 3152
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            TempLocation.Weight = 64
            Locations.Add(TempLocation)
            '__________________________
            TempLocation = New Location()
            TempLocation.Name = "Power Node 4"
            TempLocation.Region = Area.Eribu
            TempLocation.AddedDrop = True
            TempLocation.XLocation = 6832
            TempLocation.YLocation = 3120
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            TempLocation.Weight = 63
            Locations.Add(TempLocation)
            '__________________________
            TempLocation = New Location()
            TempLocation.Name = "Power Node 5"
            TempLocation.Region = Area.Eribu
            TempLocation.AddedDrop = True
            TempLocation.XLocation = 6864
            TempLocation.YLocation = 3152
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            TempLocation.Weight = 64
            Locations.Add(TempLocation)
            '__________________________
            TempLocation = New Location()
            TempLocation.Name = "Power Node 6"
            TempLocation.Region = Area.Eribu
            TempLocation.AddedDrop = True
            TempLocation.XLocation = 6864
            TempLocation.YLocation = 3120
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            TempLocation.Weight = 63
            Locations.Add(TempLocation)
            '__________________________
            'Emptying the default location
            TempLocation = New Location()
            TempLocation.Name = "Left From Start"
            TempLocation.Region = Area.Eribu
            TempLocation.LineNumber1 = 2923
            TempLocation.XLocation = 4064
            TempLocation.YLocation = 3184
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            TempLocation.Weight = 100 'Makes this always placed first
            Locations.Add(TempLocation)
#End Region
            Return Locations
        End Function
    End Class
#End Region
End Namespace
