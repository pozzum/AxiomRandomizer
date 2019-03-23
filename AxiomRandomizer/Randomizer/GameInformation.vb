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

    Public Enum ItemType 'Using in code names comment is in game name
        'weapons
        Empty
        DataDisruptor ' Axiom Disruptor
        Nova
        MultiDisruptor
        LightningGun
        WallTrace 'Orbital Discharge
        FlameThrower
        Kilver
        DataGrenade 'Data Bomb
        InertialPulse
        Voranj
        FireWall
        IonBeam
        VerticalSpread 'Hypo-Atomizer
        TetheredCharge
        Reflect
        TriCone 'Turbine Pulse
        Shards
        DistortionField
        Swim 'Quantum Variegator
        Scythe 'Reverse Slicer
        HeatSeeker
        FatBeam
        WebSlicer 'Scissor Beam
        'upgrades
        Drill
        AddressDisruptor1
        AddressDisruptor2
        GlitchBomb 'Address Bomb
        GlitchTeleport
        BlackCoat 'TrenchCoat
        RedCoat
        PasswordTool
        TendrilsTop 'Bioflux Accelerator
        TendrilsBottom 'Bioflux Accelerator
        HighJump
        DroneGun 'Must be locked behind labcoat or greater
        Grapple 'Must be locked behind labcoat or greater
        EnhancedLaunch
        DroneTeleport
        BreachSuppressor 'Key
        'nodes
        HealthNode '9 by default
        HealthNodeFragment '20 by default, 1 not on map, in a bug #15
        PowerNode '5 by default
        PowerNodeFragment '18 by default
        SizeNode '4 by default
        RangeNode '4 by default
        Lore 'notes 28 by default
    End Enum

    Public Enum Powers
        Damage
        Drill
        Nova 'Doors opened by Nova
        Kilver 'Doors Opened by Kilver
        LongBeam 'Doors Opened by Flamethrower or Scissor Beam
        FatBeam 'Doors Opened by Fatbeam
        Glitch1
        Glitch2
        Glitch3
        Passwords
        LabCoat
        TrenchCoat
        RedCoat
        HighJump
        Grapple
        Drone
        EnhancedLaunch
        DroneTeleport
        Key
    End Enum

    Public Enum CreatureType
        Snailborg
        SpitbugNest
        Spiru
        Buoyg
        SwarmilyParent
        TrapClaw
        Streeg
        Yorchug
        TrapClaw_Meta
        Snailborg_Meta
        MushroomPoof
        LoopDiatom
        LoopDiatom_Violet
        Fungine
        Furglot
        BuhbullSpawner
        Scorpiant
        TubeWorm
        Goolumn
        Prongfish
        Rugg
        Rugg_Meta
        Arachnoptopus
        Quadropus
        Mutant_Idle
        Mutant_Sleeping
        Mutant_Tongue
        Pliaa
        Gill
        Blite
        Spidler
        Piston1
        Piston2
        Piston3
        Drometon
        Mogra
        SmallMogra
        FlynnStone
        NrokSpawner
        Seamk
        Mutant_Strong
        TrapClaw_Gamma
        Oraca
        Glugg
        Blurst
        TubePuff
        RepairDrone
        RepairDrone_egg
        RepairDroneSpawner
        Porcupine
        SentryBot
        Annihiwaiter
        Potato
        Zeborg
        CortantSpawner
        GrippingHands
        Hugger
        Daraga
        TraceHallucination
        Jorm
        Jormite
        NightRayTube
        EyeCopter
        Hoverling
        Volg
        SpaceBat
        WillOWisp
        DeformedTraceChrysalis
        Hoverbug
        Hookfish
        Artichoker
        Diskko
        TieFlighter
        SentryBot_Meta
        DonaughtFactory
        BreachAttractor
        Elsenova
        SpungusSporeSpawner
        ElevatorEndCap
        Athetos
    End Enum

    Public Enum BossType
        SecurityWorm
        SoldierBoss
        SlugBoss
        ScorpionBoss
        MantaBoss
        SpitBugBoss
        SecurityWormAdvanced
        Sentinel
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

    Public Class ItemDrop
        Public Name As String
        Public DropType As ItemType
        Public GivenPowers As List(Of Powers)
        Public GID As Integer
        Public Weight As Double
        Public Placed As Boolean = False
        Public JumpAdded As Integer = 0
    End Class

    Public Class MonsterSpawn
        Public Vanilla As CreatureType
        Public Region As Area
        Public Spawns As CreatureType
    End Class

#End Region
#Region "Easy Difficulty"
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
            'TempLocation.Weight = 1.9 'Makes this always placed first
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
            'TempLocation.Weight = 1.5
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
            TempLocation.Vanilla = ItemType.PowerNode
            TempLocation.VanillaPlacement = 33
            TempLocation.Region = Area.Kur
            TempLocation.LineNumber1 = 4719
            TempLocation.XLocation = 240
            TempLocation.YLocation = 5840
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch1, Powers.HighJump, Powers.LabCoat})
            TempLocation.AddedPowers = New List(Of Powers)
            TempLocation.MapOptionPowers = New List(Of Powers)
            TempLocation.MapOptionPowers.AddRange({Powers.Drone, Powers.DroneTeleport})
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
            TempLocation.RequiredPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Drill, Powers.Kilver, Powers.Glitch2, Powers.HighJump, Powers.TrenchCoat, Powers.Drone, Powers.Grapple, Powers.EnhancedLaunch})
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
            TempLocation.Name = "Basement Shaft"
            TempLocation.Vanilla = ItemType.Lore
            TempLocation.VanillaPlacement = 107
            TempLocation.Region = Area.EKurMah
            TempLocation.LineNumber1 = 3688
            TempLocation.XLocation = 3520
            TempLocation.YLocation = 2288
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
    Public Class EasyItems
        Public Shared Function ResetItemPool()
            Dim Items As List(Of ItemDrop)
            Items = New List(Of ItemDrop)
            Dim TempItem As ItemDrop
#Region "Upgrades"
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.Drill
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({Powers.Drill})
            TempItem.Weight = 5 '5 places drill early
            TempItem.GID = 33
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.AddressDisruptor1
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({Powers.Glitch1})
            TempItem.Weight = 2 'weight 2 for non-essential upgrades
            TempItem.GID = 37
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.HighJump
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({Powers.HighJump})
            TempItem.Weight = 2 'weight 2 for non-essential upgrades
            TempItem.JumpAdded = 2
            TempItem.GID = 37
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.TendrilsTop
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.Weight = 2 'weight 2 for non-essential upgrades
            TempItem.GID = 41
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.TendrilsBottom
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.Weight = 2 'weight 2 for non-essential upgrades
            TempItem.GID = 42
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.AddressDisruptor2
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({Powers.Glitch2})
            TempItem.Weight = 2 'weight 2 for non-essential upgrades
            TempItem.GID = 60
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.GlitchTeleport
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({Powers.LabCoat})
            TempItem.Weight = 3 'weight 3 for coats & drones to maximize variance
            TempItem.GID = 61
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.Grapple
            TempItem.JumpAdded = 2
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({Powers.Grapple})
            TempItem.Weight = 3 'weight 3 for easy.
            TempItem.GID = 62
            TempItem.Weight = 0 'increases it's natural weight 
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.DroneGun
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({Powers.Drone})
            TempItem.Weight = 3 'weight 3 for coats & drones to maximize variance
            TempItem.GID = 63
            TempItem.Weight = 0 'increases it's natural weight 
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.EnhancedLaunch
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({Powers.EnhancedLaunch})
            TempItem.Weight = 2 'weight 2 for non-essential upgrades
            TempItem.GID = 64
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.RedCoat
            TempItem.JumpAdded = 4
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({Powers.RedCoat})
            TempItem.Weight = 4 'weight 4 for red coat so it can be in almost every location
            TempItem.GID = 68
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.PasswordTool
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({Powers.Passwords})
            TempItem.Weight = 2 'weight 2 for non-essential upgrades
            TempItem.GID = 69
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.GlitchBomb
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({Powers.Glitch3})
            TempItem.Weight = 2 'weight 2 for non-essential upgrades
            TempItem.GID = 70
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.DroneTeleport
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({Powers.DroneTeleport})
            TempItem.Weight = 3 'weight 3 for coats & drones to maximize variance
            TempItem.GID = 71
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.BlackCoat
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.JumpAdded = 3 'Red Coat placed first however we want to place redcoat in places reachable by trench so this still has a relevant jump height.
            TempItem.GivenPowers.AddRange({Powers.TrenchCoat})
            TempItem.Weight = 3 'weight 3 for coats & drones to maximize variance
            TempItem.GID = 72
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.BreachSuppressor
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({Powers.Key})
            TempItem.Weight = 2 'weight 2 for non-essential upgrades
            TempItem.GID = 73
            Items.Add(TempItem)
#End Region
#Region "Weapons"
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.DataDisruptor
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({Powers.Damage})
            TempItem.Weight = 10 'weight 10 for weapons
            TempItem.GID = 2
            TempItem.Weight = 5
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.Nova
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({Powers.Damage, Powers.Nova})
            TempItem.Weight = 10 'weight 10 for weapons
            TempItem.GID = 3
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.MultiDisruptor
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({Powers.Damage})
            TempItem.Weight = 10 'weight 10 for weapons
            TempItem.GID = 35
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.Kilver
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({Powers.Damage, Powers.Kilver})
            TempItem.Weight = 10 'weight 10 for weapons
            TempItem.GID = 36
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.FlameThrower
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Kilver, Powers.LongBeam})
            TempItem.Weight = 10 'weight 10 for weapons
            TempItem.GID = 40
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.VerticalSpread
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({Powers.Damage, Powers.Nova})
            TempItem.Weight = 10 'weight 10 for weapons
            TempItem.GID = 43
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.IonBeam
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({Powers.Damage})
            TempItem.Weight = 10 'weight 10 for weapons
            TempItem.GID = 44
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.TriCone
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({Powers.Damage})
            TempItem.Weight = 10 'weight 10 for weapons
            TempItem.GID = 45
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.Reflect
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.Weight = 10 'weight 10 for weapons
            TempItem.GivenPowers.AddRange({Powers.Damage, Powers.Nova})
            TempItem.GID = 46
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.WallTrace
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.Weight = 10 'weight 10 for weapons
            TempItem.GivenPowers.AddRange({Powers.Damage, Powers.Nova})
            TempItem.GID = 47
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.InertialPulse
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.Weight = 10 'weight 10 for weapons
            TempItem.GivenPowers.AddRange({Powers.Damage})
            TempItem.GID = 48
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.FireWall
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.Weight = 10 'weight 10 for weapons
            TempItem.GivenPowers.AddRange({Powers.Damage})
            TempItem.GID = 49
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.TetheredCharge
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.Weight = 10 'weight 10 for weapons
            TempItem.GivenPowers.AddRange({Powers.Damage, Powers.Nova})
            TempItem.GID = 50
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.Scythe
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.Weight = 10 'weight 10 for weapons
            TempItem.GivenPowers.AddRange({Powers.Damage, Powers.Kilver})
            TempItem.GID = 51
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.Shards
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.Weight = 10 'weight 10 for weapons
            TempItem.GivenPowers.AddRange({Powers.Damage})
            TempItem.GID = 52
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.DistortionField
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.Weight = 10 'weight 10 for weapons
            TempItem.GivenPowers.AddRange({Powers.Damage, Powers.Kilver})
            TempItem.GID = 53
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.Voranj
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.Weight = 10 'weight 10 for weapons
            TempItem.GivenPowers.AddRange({Powers.Damage})
            TempItem.GID = 54
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.DataGrenade
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.Weight = 10 'weight 10 for weapons
            TempItem.GivenPowers.AddRange({Powers.Damage})
            TempItem.GID = 55
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.LightningGun
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.Weight = 10 'weight 10 for weapons
            TempItem.GivenPowers.AddRange({Powers.Damage})
            TempItem.GID = 56
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "FatBeam"
            TempItem.DropType = ItemType.FatBeam
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.Weight = 10 'weight 10 for weapons
            TempItem.GivenPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Kilver, Powers.FatBeam})
            TempItem.GID = 57
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.Swim
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.Weight = 10 'weight 10 for weapons
            TempItem.GivenPowers.AddRange({Powers.Damage})
            TempItem.GID = 58
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "WebSlicer"
            TempItem.DropType = ItemType.WebSlicer
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.Weight = 10 'weight 10 for weapons
            TempItem.GivenPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Kilver, Powers.LongBeam})
            TempItem.GID = 59
            Items.Add(TempItem)
            '______________
            'TempItem = New ItemDrop()
            'TempItem.Name = "HeatSeeker"
            'TempItem.DropType = ItemType.HeatSeeker
            'TempItem.GivenPowers = New List(Of Powers)
            'TempItem.GivenPowers.AddRange({Powers.Damage})
            'TempItem.GID = 57 'Guess IDK if it'll work
            'Items.Add(TempItem)
#End Region
#Region "Health Nodes"
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNode1"
            TempItem.DropType = ItemType.HealthNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 34
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNode2"
            TempItem.DropType = ItemType.HealthNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 34
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNode3"
            TempItem.DropType = ItemType.HealthNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 34
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNode4"
            TempItem.DropType = ItemType.HealthNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 34
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNode5"
            TempItem.DropType = ItemType.HealthNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 34
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNode6"
            TempItem.DropType = ItemType.HealthNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 34
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNode7"
            TempItem.DropType = ItemType.HealthNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 34
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNode8"
            TempItem.DropType = ItemType.HealthNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 34
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNode9"
            TempItem.DropType = ItemType.HealthNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 34
            TempItem.Weight = -1
            Items.Add(TempItem)
            '
            '______________HEALTH NODE FRAGMENTS
            '
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNodeFragment1"
            TempItem.DropType = ItemType.HealthNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 38
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNodeFragment2"
            TempItem.DropType = ItemType.HealthNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 38
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNodeFragment3"
            TempItem.DropType = ItemType.HealthNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 38
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNodeFragment4"
            TempItem.DropType = ItemType.HealthNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 38
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNodeFragment5"
            TempItem.DropType = ItemType.HealthNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 38
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNodeFragment6"
            TempItem.DropType = ItemType.HealthNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 38
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNodeFragment7"
            TempItem.DropType = ItemType.HealthNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 38
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNodeFragment8"
            TempItem.DropType = ItemType.HealthNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 38
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNodeFragment9"
            TempItem.DropType = ItemType.HealthNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 38
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNodeFragment10"
            TempItem.DropType = ItemType.HealthNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 38
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNodeFragment11"
            TempItem.DropType = ItemType.HealthNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 38
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNodeFragment12"
            TempItem.DropType = ItemType.HealthNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 38
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNodeFragment13"
            TempItem.DropType = ItemType.HealthNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 38
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNodeFragment14"
            TempItem.DropType = ItemType.HealthNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 38
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________....Item is in a Slug
            'TempItem = New ItemDrop()
            'TempItem.Name = "HealthNodeFragment15"
            'TempItem.DropType = ItemType.HealthNodeFragment
            'TempItem.GivenPowers = New List(Of Powers)
            'TempItem.GID = 38
            'TempItem.Weight = -1
            'Items.Add(TempItem)
            'Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNodeFragment16"
            TempItem.DropType = ItemType.HealthNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 38
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNodeFragment17"
            TempItem.DropType = ItemType.HealthNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 38
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNodeFragment18"
            TempItem.DropType = ItemType.HealthNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 38
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNodeFragment19"
            TempItem.DropType = ItemType.HealthNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 38
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNodeFragment20"
            TempItem.DropType = ItemType.HealthNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 38
            TempItem.Weight = -1
            Items.Add(TempItem)
#End Region
#Region "Power Nodes"
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "PowerNode1"
            TempItem.DropType = ItemType.PowerNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 32
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "PowerNode2"
            TempItem.DropType = ItemType.PowerNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 32
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "PowerNode3"
            TempItem.DropType = ItemType.PowerNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 32
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "PowerNode4"
            TempItem.DropType = ItemType.PowerNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 32
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "PowerNode5"
            TempItem.DropType = ItemType.PowerNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 32
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "PowerNode6"
            TempItem.DropType = ItemType.PowerNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 32
            TempItem.Weight = -1
            Items.Add(TempItem)
            '
            '______________POWER NODES FRAGMENTS
            '
            TempItem = New ItemDrop()
            TempItem.Name = "PowerNodeFragment1"
            TempItem.DropType = ItemType.PowerNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 74
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "PowerNodeFragment2"
            TempItem.DropType = ItemType.PowerNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 74
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "PowerNodeFragment3"
            TempItem.DropType = ItemType.PowerNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 74
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "PowerNodeFragment4"
            TempItem.DropType = ItemType.PowerNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 74
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "PowerNodeFragment5"
            TempItem.DropType = ItemType.PowerNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 74
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "PowerNodeFragment6"
            TempItem.DropType = ItemType.PowerNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 74
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "PowerNodeFragment7"
            TempItem.DropType = ItemType.PowerNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 74
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "PowerNodeFragment8"
            TempItem.DropType = ItemType.PowerNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 74
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "PowerNodeFragment9"
            TempItem.DropType = ItemType.PowerNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 74
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "PowerNodeFragment10"
            TempItem.DropType = ItemType.PowerNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 74
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "PowerNodeFragment11"
            TempItem.DropType = ItemType.PowerNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 74
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "PowerNodeFragment12"
            TempItem.DropType = ItemType.PowerNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 74
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "PowerNodeFragment13"
            TempItem.DropType = ItemType.PowerNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 74
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "PowerNodeFragment14"
            TempItem.DropType = ItemType.PowerNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 74
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "PowerNodeFragment15"
            TempItem.DropType = ItemType.PowerNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 74
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "PowerNodeFragment16"
            TempItem.DropType = ItemType.PowerNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 74
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "PowerNodeFragment17"
            TempItem.DropType = ItemType.PowerNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 74
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "PowerNodeFragment18"
            TempItem.DropType = ItemType.PowerNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 74
            TempItem.Weight = -1
            Items.Add(TempItem)
#End Region
#Region "Size Nodes"
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "SizeNode1"
            TempItem.DropType = ItemType.SizeNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 65
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "SizeNode2"
            TempItem.DropType = ItemType.SizeNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 65
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "SizeNode3"
            TempItem.DropType = ItemType.SizeNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 65
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "SizeNode4"
            TempItem.DropType = ItemType.SizeNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 65
            TempItem.Weight = -1
            Items.Add(TempItem)
#End Region
#Region "Range Nodes"
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "RangeNode1"
            TempItem.DropType = ItemType.RangeNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 66
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "RangeNode2"
            TempItem.DropType = ItemType.RangeNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 66
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "RangeNode3"
            TempItem.DropType = ItemType.RangeNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 66
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "RangeNode4"
            TempItem.DropType = ItemType.RangeNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 66
            TempItem.Weight = -1
            Items.Add(TempItem)
#End Region
#Region "Lore"
            '
            '______________LORE
            '
            TempItem = New ItemDrop()
            TempItem.Name = "Note1"
            TempItem.DropType = ItemType.Lore
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 75
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "Note2"
            TempItem.DropType = ItemType.Lore
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 75
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "Note3"
            TempItem.DropType = ItemType.Lore
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 75
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "Note4"
            TempItem.DropType = ItemType.Lore
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 75
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "Note5"
            TempItem.DropType = ItemType.Lore
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 75
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "Note6"
            TempItem.DropType = ItemType.Lore
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 75
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "Note7"
            TempItem.DropType = ItemType.Lore
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 75
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "Note8"
            TempItem.DropType = ItemType.Lore
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 75
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "Note9"
            TempItem.DropType = ItemType.Lore
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 75
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "Note10"
            TempItem.DropType = ItemType.Lore
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 75
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "Note11"
            TempItem.DropType = ItemType.Lore
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 75
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "Note12"
            TempItem.DropType = ItemType.Lore
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 75
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "Note13"
            TempItem.DropType = ItemType.Lore
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 75
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "Note14"
            TempItem.DropType = ItemType.Lore
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 75
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "Note15"
            TempItem.DropType = ItemType.Lore
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 75
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "Note16"
            TempItem.DropType = ItemType.Lore
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 75
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "Note17"
            TempItem.DropType = ItemType.Lore
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 75
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "Note18"
            TempItem.DropType = ItemType.Lore
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 75
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "Note19"
            TempItem.DropType = ItemType.Lore
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 75
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "Note20"
            TempItem.DropType = ItemType.Lore
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 75
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "Note21"
            TempItem.DropType = ItemType.Lore
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 75
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "Note22"
            TempItem.DropType = ItemType.Lore
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 75
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "Note23"
            TempItem.DropType = ItemType.Lore
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 75
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "Note24"
            TempItem.DropType = ItemType.Lore
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 75
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "Note25"
            TempItem.DropType = ItemType.Lore
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 75
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________...Next 3 removed for hidden weapons
            TempItem = New ItemDrop()
            TempItem.Name = "Note26"
            TempItem.DropType = ItemType.Lore
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 75
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________ Added I think
            'TempItem = New ItemDrop()
            'TempItem.Name = "Note27"
            'TempItem.DropType = ItemType.Lore
            'TempItem.GivenPowers = New List(Of Powers)
            'TempItem.GID = 75
            'Items.Add(TempItem)
            '______________
            'TempItem = New ItemDrop()
            'TempItem.Name = "Note28"
            'TempItem.DropType = ItemType.Lore
            'TempItem.GivenPowers = New List(Of Powers)
            'TempItem.GID = 75
            'Items.Add(TempItem)
#End Region
            Return Items
        End Function
    End Class
    Public Class EasyMonsters
        Public Shared Function ResetMonsters()
            Dim Spawns As List(Of MonsterSpawn)
            Spawns = New List(Of MonsterSpawn)
            Dim TempSpawn As MonsterSpawn
            '
            '_______________Eribu
            '
            '_______________Area 1
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Snailborg
            TempSpawn.Region = Area.Eribu
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.SpitbugNest
            TempSpawn.Region = Area.Eribu
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Spiru
            TempSpawn.Region = Area.Eribu
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Buoyg
            TempSpawn.Region = Area.Eribu
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.SwarmilyParent
            TempSpawn.Region = Area.Eribu
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.TrapClaw
            TempSpawn.Region = Area.Eribu
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Yorchug
            TempSpawn.Region = Area.Eribu
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Streeg
            TempSpawn.Region = Area.Eribu
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Snailborg_Meta
            TempSpawn.Region = Area.Eribu
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.TrapClaw_Meta
            TempSpawn.Region = Area.Eribu
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Quadropus
            TempSpawn.Region = Area.Eribu
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.TrapClaw_Gamma
            TempSpawn.Region = Area.Eribu
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Mutant_Strong
            TempSpawn.Region = Area.Eribu
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.SentryBot_Meta
            TempSpawn.Region = Area.Eribu
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.TubePuff
            TempSpawn.Region = Area.Eribu
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Blurst
            TempSpawn.Region = Area.Eribu
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.WillOWisp
            TempSpawn.Region = Area.Eribu
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Gill
            TempSpawn.Region = Area.Eribu
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Hoverbug
            TempSpawn.Region = Area.Eribu
            Spawns.Add(TempSpawn)
            '
            '_______________Absu
            '
            '_______________Area 2
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Snailborg
            TempSpawn.Region = Area.Absu
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.SpitbugNest
            TempSpawn.Region = Area.Absu
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.MushroomPoof
            TempSpawn.Region = Area.Absu
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Buoyg
            TempSpawn.Region = Area.Absu
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.SwarmilyParent
            TempSpawn.Region = Area.Absu
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.LoopDiatom
            TempSpawn.Region = Area.Absu
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.LoopDiatom_Violet
            TempSpawn.Region = Area.Absu
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Streeg
            TempSpawn.Region = Area.Absu
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Snailborg_Meta
            TempSpawn.Region = Area.Absu
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.TrapClaw_Meta
            TempSpawn.Region = Area.Absu
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Fungine
            TempSpawn.Region = Area.Absu
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Arachnoptopus
            TempSpawn.Region = Area.Absu
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Quadropus
            TempSpawn.Region = Area.Absu
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Mutant_Idle
            TempSpawn.Region = Area.Absu
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Mutant_Tongue
            TempSpawn.Region = Area.Absu
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Mutant_Sleeping
            TempSpawn.Region = Area.Absu
            Spawns.Add(TempSpawn)
            '______________
            'TempSpawn = New MonsterSpawn()
            'TempSpawn.Vanilla = CreatureType.RepairDrone
            'TempSpawn.Region = Area.Absu
            'Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Mutant_Strong
            TempSpawn.Region = Area.Absu
            Spawns.Add(TempSpawn)
            '
            '_______________Zi
            '
            '_______________Area 3
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Furglot
            TempSpawn.Region = Area.Zi
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.BuhbullSpawner
            TempSpawn.Region = Area.Zi
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Scorpiant
            TempSpawn.Region = Area.Zi
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.TubeWorm
            TempSpawn.Region = Area.Zi
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Goolumn
            TempSpawn.Region = Area.Zi
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Prongfish
            TempSpawn.Region = Area.Zi
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Rugg
            TempSpawn.Region = Area.Zi
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Rugg_Meta
            TempSpawn.Region = Area.Zi
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Arachnoptopus
            TempSpawn.Region = Area.Zi
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Mutant_Idle
            TempSpawn.Region = Area.Zi
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Piston1
            TempSpawn.Region = Area.Zi
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Piston1
            TempSpawn.Region = Area.Zi
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Piston2
            TempSpawn.Region = Area.Zi
            Spawns.Add(TempSpawn)
            '______________ 'TraceHallucination not replaced
            'TempSpawn = New MonsterSpawn()
            'TempSpawn.Vanilla = CreatureType.RepairDrone
            'TempSpawn.Region = Area.Zi
            'Spawns.Add(TempSpawn)
            '
            '_______________Kur
            '
            '_______________Area 4
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Pliaa
            TempSpawn.Region = Area.Kur
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Quadropus
            TempSpawn.Region = Area.Kur
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Gill
            TempSpawn.Region = Area.Kur
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Blite
            TempSpawn.Region = Area.Kur
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Spidler
            TempSpawn.Region = Area.Kur
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Drometon
            TempSpawn.Region = Area.Kur
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Mogra
            TempSpawn.Region = Area.Kur
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.SmallMogra
            TempSpawn.Region = Area.Kur
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.FlynnStone
            TempSpawn.Region = Area.Kur
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.NrokSpawner
            TempSpawn.Region = Area.Kur
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Seamk
            TempSpawn.Region = Area.Kur
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Mutant_Strong
            TempSpawn.Region = Area.Kur
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Mutant_Sleeping
            TempSpawn.Region = Area.Kur
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.TrapClaw_Gamma
            TempSpawn.Region = Area.Kur
            Spawns.Add(TempSpawn)
            '______________
            'TempSpawn = New MonsterSpawn()
            'TempSpawn.Vanilla = CreatureType.RepairDroneSpawner
            'TempSpawn.Region = Area.Kur
            'Spawns.Add(TempSpawn)
            '______________
            'TempSpawn = New MonsterSpawn()
            'TempSpawn.Vanilla = CreatureType.RepairDrone
            'TempSpawn.Region = Area.Kur
            'Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.EyeCopter
            TempSpawn.Region = Area.Kur
            Spawns.Add(TempSpawn)
            '
            '_______________Indi
            '
            '_______________Area 5
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Drometon
            TempSpawn.Region = Area.Indi
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Glugg
            TempSpawn.Region = Area.Indi
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Blurst
            TempSpawn.Region = Area.Indi
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.TubePuff
            TempSpawn.Region = Area.Indi
            Spawns.Add(TempSpawn)
            '______________
            'TempSpawn = New MonsterSpawn()
            'TempSpawn.Vanilla = CreatureType.RepairDrone
            'TempSpawn.Region = Area.Indi
            'Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Snailborg
            TempSpawn.Region = Area.Indi
            Spawns.Add(TempSpawn)
            '
            '_______________UkkinNa "Normal"
            '
            '_______________Area 6
            'TempSpawn = New MonsterSpawn()
            'TempSpawn.Vanilla = CreatureType.RepairDrone
            'TempSpawn.Region = Area.UkkinNa
            'Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.SentryBot
            TempSpawn.Region = Area.UkkinNa
            Spawns.Add(TempSpawn)
            '______________
            'Annihiwaiter will remain
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Potato
            TempSpawn.Region = Area.UkkinNa
            Spawns.Add(TempSpawn)
            '______________
            'Daraga will remain
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Glugg
            TempSpawn.Region = Area.UkkinNa
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.TubePuff
            TempSpawn.Region = Area.UkkinNa
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Elsenova
            TempSpawn.Region = Area.UkkinNa
            Spawns.Add(TempSpawn)
            '
            '_______________Edin
            '
            '_______________Area 7
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Jorm
            TempSpawn.Region = Area.Edin
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Jormite
            TempSpawn.Region = Area.Edin
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.NightRayTube
            TempSpawn.Region = Area.Edin
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.EyeCopter
            TempSpawn.Region = Area.Edin
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Mutant_Strong
            TempSpawn.Region = Area.Edin
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Hoverling
            TempSpawn.Region = Area.Edin
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Volg
            TempSpawn.Region = Area.Edin
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.SpaceBat
            TempSpawn.Region = Area.Edin
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.WillOWisp
            TempSpawn.Region = Area.Edin
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.DeformedTraceChrysalis
            TempSpawn.Region = Area.Edin
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Hoverling
            TempSpawn.Region = Area.Edin
            Spawns.Add(TempSpawn)
            '
            '_______________EKurMah
            '
            '_______________Area 8
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Hoverbug
            TempSpawn.Region = Area.EKurMah
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Hookfish
            TempSpawn.Region = Area.EKurMah
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Furglot
            TempSpawn.Region = Area.EKurMah
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Artichoker
            TempSpawn.Region = Area.EKurMah
            Spawns.Add(TempSpawn)
            '
            '_______________MarUru
            '
            '_______________Area 9
            'TempSpawn = New MonsterSpawn()
            'TempSpawn.Vanilla = CreatureType.Diskko
            'TempSpawn.Region = Area.MarUru
            'Spawns.Add(TempSpawn)
            '______________
            'TempSpawn = New MonsterSpawn()
            'TempSpawn.Vanilla = CreatureType.SentryBot_Meta
            'TempSpawn.Region = Area.MarUru
            'Spawns.Add(TempSpawn)
            '______________
            'TieFlighter to stay for puzzle
            'DonaughtFactory staying because it's basically the final boss.
            'BreachAttractor staying for final boss
            'Elsenova staying for final boss
            'ElevatorEndCap staying for final boss
            'Athetos staying for final boss
            Return Spawns
        End Function
        Public Shared Function BannedMonsters()
            Dim Bans As List(Of CreatureType) = New List(Of CreatureType)
            Bans.Add(CreatureType.Piston1)
            Bans.Add(CreatureType.Piston2)
            Bans.Add(CreatureType.Piston3)
            Bans.Add(CreatureType.Diskko)
            Bans.Add(CreatureType.SentryBot_Meta)
            Bans.Add(CreatureType.DonaughtFactory)
            Bans.Add(CreatureType.TieFlighter)
            Bans.Add(CreatureType.Oraca)
            Bans.Add(CreatureType.BreachAttractor)
            Bans.Add(CreatureType.ElevatorEndCap)
            Bans.Add(CreatureType.Elsenova)
            Bans.Add(CreatureType.Athetos)
            Bans.Add(CreatureType.TraceHallucination)
            Bans.Add(CreatureType.RepairDroneSpawner)
            Bans.Add(CreatureType.RepairDrone)
            Bans.Add(CreatureType.RepairDrone_egg)
            Return Bans
        End Function
    End Class
#End Region
#Region "Normal Difficulty"
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
    Public Class NormalItems
        Public Shared Function ResetItemPool()
            Dim Items As List(Of ItemDrop)
            Items = New List(Of ItemDrop)
            Dim TempItem As ItemDrop
#Region "Upgrades"
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.Drill
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({Powers.Drill})
            TempItem.Weight = 5 '5 places drill after first weapons making sure it is placed real early
            TempItem.GID = 33
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.AddressDisruptor1
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({Powers.Glitch1})
            TempItem.Weight = 2 'weight 2 for non-essential upgrades
            TempItem.GID = 37
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.HighJump
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({Powers.HighJump})
            TempItem.Weight = 2 'weight 2 for non-essential upgrades
            TempItem.JumpAdded = 2
            TempItem.GID = 37
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.TendrilsTop
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.Weight = 2 'weight 2 for non-essential upgrades
            TempItem.GID = 41
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.TendrilsBottom
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.Weight = 2 'weight 2 for non-essential upgrades
            TempItem.GID = 42
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.AddressDisruptor2
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({Powers.Glitch2})
            TempItem.Weight = 2 'weight 2 for non-essential upgrades
            TempItem.GID = 60
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.GlitchTeleport
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({Powers.LabCoat})
            TempItem.Weight = 3 'weight 3 for coats & drones to maximize variance
            TempItem.GID = 61
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.Grapple
            TempItem.JumpAdded = 2
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({Powers.Grapple})
            TempItem.Weight = 2 'weight 2 for non-essential upgrades
            TempItem.GID = 62
            TempItem.Weight = 0 'increases it's natural weight 
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.DroneGun
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({Powers.Drone})
            TempItem.Weight = 3 'weight 3 for coats & drones to maximize variance
            TempItem.GID = 63
            TempItem.Weight = 0 'increases it's natural weight 
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.EnhancedLaunch
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({Powers.EnhancedLaunch})
            TempItem.Weight = 2 'weight 2 for non-essential upgrades
            TempItem.GID = 64
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.RedCoat
            TempItem.JumpAdded = 4
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({Powers.RedCoat})
            TempItem.Weight = 4 'weight 4 for red coat so it can be in almost every location
            TempItem.GID = 68
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.PasswordTool
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({Powers.Passwords})
            TempItem.Weight = 2 'weight 2 for non-essential upgrades
            TempItem.GID = 69
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.GlitchBomb
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({Powers.Glitch3})
            TempItem.Weight = 2 'weight 2 for non-essential upgrades
            TempItem.GID = 70
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.DroneTeleport
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({Powers.DroneTeleport})
            TempItem.Weight = 3 'weight 3 for coats & drones to maximize variance
            TempItem.GID = 71
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.BlackCoat
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.JumpAdded = 3 'Red Coat placed first however we want to place redcoat in places reachable by trench so this still has a relevant jump height.
            TempItem.GivenPowers.AddRange({Powers.TrenchCoat})
            TempItem.Weight = 3 'weight 3 for coats & drones to maximize variance
            TempItem.GID = 72
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.BreachSuppressor
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({Powers.Key})
            TempItem.Weight = 2 'weight 2 for non-essential upgrades
            TempItem.GID = 73
            Items.Add(TempItem)
#End Region
#Region "Weapons"
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.DataDisruptor
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({Powers.Damage})
            TempItem.Weight = 10 'weight 10 for weapons
            TempItem.GID = 2
            TempItem.Weight = 5
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.Nova
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({Powers.Damage, Powers.Nova})
            TempItem.Weight = 10 'weight 10 for weapons
            TempItem.GID = 3
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.MultiDisruptor
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({Powers.Damage})
            TempItem.Weight = 10 'weight 10 for weapons
            TempItem.GID = 35
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.Kilver
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({Powers.Damage, Powers.Kilver})
            TempItem.Weight = 10 'weight 10 for weapons
            TempItem.GID = 36
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.FlameThrower
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Kilver, Powers.LongBeam})
            TempItem.Weight = 10 'weight 10 for weapons
            TempItem.GID = 40
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.VerticalSpread
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({Powers.Damage, Powers.Nova})
            TempItem.Weight = 10 'weight 10 for weapons
            TempItem.GID = 43
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.IonBeam
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({Powers.Damage})
            TempItem.Weight = 10 'weight 10 for weapons
            TempItem.GID = 44
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.TriCone
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({Powers.Damage})
            TempItem.Weight = 10 'weight 10 for weapons
            TempItem.GID = 45
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.Reflect
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.Weight = 10 'weight 10 for weapons
            TempItem.GivenPowers.AddRange({Powers.Damage, Powers.Nova})
            TempItem.GID = 46
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.WallTrace
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.Weight = 10 'weight 10 for weapons
            TempItem.GivenPowers.AddRange({Powers.Damage, Powers.Nova})
            TempItem.GID = 47
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.InertialPulse
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.Weight = 10 'weight 10 for weapons
            TempItem.GivenPowers.AddRange({Powers.Damage})
            TempItem.GID = 48
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.FireWall
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.Weight = 10 'weight 10 for weapons
            TempItem.GivenPowers.AddRange({Powers.Damage})
            TempItem.GID = 49
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.TetheredCharge
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.Weight = 10 'weight 10 for weapons
            TempItem.GivenPowers.AddRange({Powers.Damage, Powers.Nova})
            TempItem.GID = 50
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.Scythe
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.Weight = 10 'weight 10 for weapons
            TempItem.GivenPowers.AddRange({Powers.Damage, Powers.Kilver})
            TempItem.GID = 51
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.Shards
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.Weight = 10 'weight 10 for weapons
            TempItem.GivenPowers.AddRange({Powers.Damage})
            TempItem.GID = 52
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.DistortionField
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.Weight = 10 'weight 10 for weapons
            TempItem.GivenPowers.AddRange({Powers.Damage, Powers.Kilver})
            TempItem.GID = 53
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.Voranj
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.Weight = 10 'weight 10 for weapons
            TempItem.GivenPowers.AddRange({Powers.Damage})
            TempItem.GID = 54
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.DataGrenade
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.Weight = 10 'weight 10 for weapons
            TempItem.GivenPowers.AddRange({Powers.Damage})
            TempItem.GID = 55
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.LightningGun
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.Weight = 10 'weight 10 for weapons
            TempItem.GivenPowers.AddRange({Powers.Damage})
            TempItem.GID = 56
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "FatBeam"
            TempItem.DropType = ItemType.FatBeam
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.Weight = 10 'weight 10 for weapons
            TempItem.GivenPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Kilver, Powers.LongBeam, Powers.FatBeam})
            TempItem.GID = 57
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.Swim
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.Weight = 10 'weight 10 for weapons
            TempItem.GivenPowers.AddRange({Powers.Damage})
            TempItem.GID = 58
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "WebSlicer"
            TempItem.DropType = ItemType.WebSlicer
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.Weight = 10 'weight 10 for weapons
            TempItem.GivenPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Kilver, Powers.LongBeam})
            TempItem.GID = 59
            Items.Add(TempItem)
            '______________
            'TempItem = New ItemDrop()
            'TempItem.Name = "HeatSeeker"
            'TempItem.DropType = ItemType.HeatSeeker
            'TempItem.GivenPowers = New List(Of Powers)
            'TempItem.GivenPowers.AddRange({Powers.Damage})
            'TempItem.GID = 57 'Guess IDK if it'll work
            'Items.Add(TempItem)
#End Region
#Region "Health Nodes"
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNode1"
            TempItem.DropType = ItemType.HealthNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 34
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNode2"
            TempItem.DropType = ItemType.HealthNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 34
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNode3"
            TempItem.DropType = ItemType.HealthNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 34
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNode4"
            TempItem.DropType = ItemType.HealthNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 34
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNode5"
            TempItem.DropType = ItemType.HealthNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 34
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNode6"
            TempItem.DropType = ItemType.HealthNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 34
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNode7"
            TempItem.DropType = ItemType.HealthNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 34
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNode8"
            TempItem.DropType = ItemType.HealthNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 34
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNode9"
            TempItem.DropType = ItemType.HealthNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 34
            TempItem.Weight = -1
            Items.Add(TempItem)
            '
            '______________HEALTH NODE FRAGMENTS
            '
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNodeFragment1"
            TempItem.DropType = ItemType.HealthNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 38
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNodeFragment2"
            TempItem.DropType = ItemType.HealthNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 38
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNodeFragment3"
            TempItem.DropType = ItemType.HealthNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 38
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNodeFragment4"
            TempItem.DropType = ItemType.HealthNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 38
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNodeFragment5"
            TempItem.DropType = ItemType.HealthNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 38
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNodeFragment6"
            TempItem.DropType = ItemType.HealthNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 38
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNodeFragment7"
            TempItem.DropType = ItemType.HealthNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 38
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNodeFragment8"
            TempItem.DropType = ItemType.HealthNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 38
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNodeFragment9"
            TempItem.DropType = ItemType.HealthNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 38
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNodeFragment10"
            TempItem.DropType = ItemType.HealthNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 38
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNodeFragment11"
            TempItem.DropType = ItemType.HealthNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 38
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNodeFragment12"
            TempItem.DropType = ItemType.HealthNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 38
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNodeFragment13"
            TempItem.DropType = ItemType.HealthNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 38
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNodeFragment14"
            TempItem.DropType = ItemType.HealthNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 38
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________....Item is in a Slug
            'TempItem = New ItemDrop()
            'TempItem.Name = "HealthNodeFragment15"
            'TempItem.DropType = ItemType.HealthNodeFragment
            'TempItem.GivenPowers = New List(Of Powers)
            'TempItem.GID = 38
            'TempItem.Weight = -1
            'Items.Add(TempItem)
            'Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNodeFragment16"
            TempItem.DropType = ItemType.HealthNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 38
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNodeFragment17"
            TempItem.DropType = ItemType.HealthNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 38
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNodeFragment18"
            TempItem.DropType = ItemType.HealthNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 38
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNodeFragment19"
            TempItem.DropType = ItemType.HealthNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 38
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNodeFragment20"
            TempItem.DropType = ItemType.HealthNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 38
            TempItem.Weight = -1
            Items.Add(TempItem)
#End Region
#Region "Power Nodes"
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "PowerNode1"
            TempItem.DropType = ItemType.PowerNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 32
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "PowerNode2"
            TempItem.DropType = ItemType.PowerNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 32
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "PowerNode3"
            TempItem.DropType = ItemType.PowerNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 32
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "PowerNode4"
            TempItem.DropType = ItemType.PowerNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 32
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "PowerNode5"
            TempItem.DropType = ItemType.PowerNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 32
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "PowerNode6"
            TempItem.DropType = ItemType.PowerNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 32
            TempItem.Weight = -1
            Items.Add(TempItem)
            '
            '______________POWER NODES FRAGMENTS
            '
            TempItem = New ItemDrop()
            TempItem.Name = "PowerNodeFragment1"
            TempItem.DropType = ItemType.PowerNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 74
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "PowerNodeFragment2"
            TempItem.DropType = ItemType.PowerNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 74
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "PowerNodeFragment3"
            TempItem.DropType = ItemType.PowerNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 74
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "PowerNodeFragment4"
            TempItem.DropType = ItemType.PowerNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 74
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "PowerNodeFragment5"
            TempItem.DropType = ItemType.PowerNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 74
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "PowerNodeFragment6"
            TempItem.DropType = ItemType.PowerNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 74
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "PowerNodeFragment7"
            TempItem.DropType = ItemType.PowerNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 74
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "PowerNodeFragment8"
            TempItem.DropType = ItemType.PowerNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 74
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "PowerNodeFragment9"
            TempItem.DropType = ItemType.PowerNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 74
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "PowerNodeFragment10"
            TempItem.DropType = ItemType.PowerNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 74
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "PowerNodeFragment11"
            TempItem.DropType = ItemType.PowerNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 74
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "PowerNodeFragment12"
            TempItem.DropType = ItemType.PowerNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 74
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "PowerNodeFragment13"
            TempItem.DropType = ItemType.PowerNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 74
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "PowerNodeFragment14"
            TempItem.DropType = ItemType.PowerNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 74
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "PowerNodeFragment15"
            TempItem.DropType = ItemType.PowerNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 74
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "PowerNodeFragment16"
            TempItem.DropType = ItemType.PowerNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 74
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "PowerNodeFragment17"
            TempItem.DropType = ItemType.PowerNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 74
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "PowerNodeFragment18"
            TempItem.DropType = ItemType.PowerNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 74
            TempItem.Weight = -1
            Items.Add(TempItem)
#End Region
#Region "Size Nodes"
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "SizeNode1"
            TempItem.DropType = ItemType.SizeNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 65
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "SizeNode2"
            TempItem.DropType = ItemType.SizeNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 65
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "SizeNode3"
            TempItem.DropType = ItemType.SizeNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 65
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "SizeNode4"
            TempItem.DropType = ItemType.SizeNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 65
            TempItem.Weight = -1
            Items.Add(TempItem)
#End Region
#Region "Range Nodes"
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "RangeNode1"
            TempItem.DropType = ItemType.RangeNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 66
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "RangeNode2"
            TempItem.DropType = ItemType.RangeNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 66
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "RangeNode3"
            TempItem.DropType = ItemType.RangeNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 66
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "RangeNode4"
            TempItem.DropType = ItemType.RangeNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 66
            TempItem.Weight = -1
            Items.Add(TempItem)
#End Region
#Region "Lore"
            '
            '______________LORE
            '
            TempItem = New ItemDrop()
            TempItem.Name = "Note1"
            TempItem.DropType = ItemType.Lore
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 75
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "Note2"
            TempItem.DropType = ItemType.Lore
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 75
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "Note3"
            TempItem.DropType = ItemType.Lore
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 75
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "Note4"
            TempItem.DropType = ItemType.Lore
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 75
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "Note5"
            TempItem.DropType = ItemType.Lore
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 75
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "Note6"
            TempItem.DropType = ItemType.Lore
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 75
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "Note7"
            TempItem.DropType = ItemType.Lore
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 75
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "Note8"
            TempItem.DropType = ItemType.Lore
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 75
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "Note9"
            TempItem.DropType = ItemType.Lore
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 75
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "Note10"
            TempItem.DropType = ItemType.Lore
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 75
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "Note11"
            TempItem.DropType = ItemType.Lore
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 75
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "Note12"
            TempItem.DropType = ItemType.Lore
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 75
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "Note13"
            TempItem.DropType = ItemType.Lore
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 75
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "Note14"
            TempItem.DropType = ItemType.Lore
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 75
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "Note15"
            TempItem.DropType = ItemType.Lore
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 75
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "Note16"
            TempItem.DropType = ItemType.Lore
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 75
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "Note17"
            TempItem.DropType = ItemType.Lore
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 75
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "Note18"
            TempItem.DropType = ItemType.Lore
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 75
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "Note19"
            TempItem.DropType = ItemType.Lore
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 75
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "Note20"
            TempItem.DropType = ItemType.Lore
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 75
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "Note21"
            TempItem.DropType = ItemType.Lore
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 75
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "Note22"
            TempItem.DropType = ItemType.Lore
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 75
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "Note23"
            TempItem.DropType = ItemType.Lore
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 75
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "Note24"
            TempItem.DropType = ItemType.Lore
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 75
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "Note25"
            TempItem.DropType = ItemType.Lore
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 75
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________...Next 3 removed for hidden weapons
            TempItem = New ItemDrop()
            TempItem.Name = "Note26"
            TempItem.DropType = ItemType.Lore
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 75
            TempItem.Weight = -1
            Items.Add(TempItem)
            '______________ Added I think
            'TempItem = New ItemDrop()
            'TempItem.Name = "Note27"
            'TempItem.DropType = ItemType.Lore
            'TempItem.GivenPowers = New List(Of Powers)
            'TempItem.GID = 75
            'Items.Add(TempItem)
            '______________
            'TempItem = New ItemDrop()
            'TempItem.Name = "Note28"
            'TempItem.DropType = ItemType.Lore
            'TempItem.GivenPowers = New List(Of Powers)
            'TempItem.GID = 75
            'Items.Add(TempItem)
#End Region
            Return Items
        End Function
    End Class
    Public Class NormalMonsters
        Public Shared Function ResetMonsters()
            Dim Spawns As List(Of MonsterSpawn)
            Spawns = New List(Of MonsterSpawn)
            Dim TempSpawn As MonsterSpawn
            '
            '_______________Eribu
            '
            '_______________Area 1
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Snailborg
            TempSpawn.Region = Area.Eribu
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.SpitbugNest
            TempSpawn.Region = Area.Eribu
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Spiru
            TempSpawn.Region = Area.Eribu
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Buoyg
            TempSpawn.Region = Area.Eribu
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.SwarmilyParent
            TempSpawn.Region = Area.Eribu
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.TrapClaw
            TempSpawn.Region = Area.Eribu
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Yorchug
            TempSpawn.Region = Area.Eribu
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Streeg
            TempSpawn.Region = Area.Eribu
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Snailborg_Meta
            TempSpawn.Region = Area.Eribu
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.TrapClaw_Meta
            TempSpawn.Region = Area.Eribu
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Quadropus
            TempSpawn.Region = Area.Eribu
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.TrapClaw_Gamma
            TempSpawn.Region = Area.Eribu
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Mutant_Strong
            TempSpawn.Region = Area.Eribu
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.SentryBot_Meta
            TempSpawn.Region = Area.Eribu
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.TubePuff
            TempSpawn.Region = Area.Eribu
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Blurst
            TempSpawn.Region = Area.Eribu
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.WillOWisp
            TempSpawn.Region = Area.Eribu
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Gill
            TempSpawn.Region = Area.Eribu
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Hoverbug
            TempSpawn.Region = Area.Eribu
            Spawns.Add(TempSpawn)
            '
            '_______________Absu
            '
            '_______________Area 2
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Snailborg
            TempSpawn.Region = Area.Absu
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.SpitbugNest
            TempSpawn.Region = Area.Absu
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.MushroomPoof
            TempSpawn.Region = Area.Absu
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Buoyg
            TempSpawn.Region = Area.Absu
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.SwarmilyParent
            TempSpawn.Region = Area.Absu
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.LoopDiatom
            TempSpawn.Region = Area.Absu
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.LoopDiatom_Violet
            TempSpawn.Region = Area.Absu
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Streeg
            TempSpawn.Region = Area.Absu
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Snailborg_Meta
            TempSpawn.Region = Area.Absu
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.TrapClaw_Meta
            TempSpawn.Region = Area.Absu
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Fungine
            TempSpawn.Region = Area.Absu
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Arachnoptopus
            TempSpawn.Region = Area.Absu
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Quadropus
            TempSpawn.Region = Area.Absu
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Mutant_Idle
            TempSpawn.Region = Area.Absu
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Mutant_Tongue
            TempSpawn.Region = Area.Absu
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Mutant_Sleeping
            TempSpawn.Region = Area.Absu
            Spawns.Add(TempSpawn)
            '______________
            'TempSpawn = New MonsterSpawn()
            'TempSpawn.Vanilla = CreatureType.RepairDrone
            'TempSpawn.Region = Area.Absu
            'Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Mutant_Strong
            TempSpawn.Region = Area.Absu
            Spawns.Add(TempSpawn)
            '
            '_______________Zi
            '
            '_______________Area 3
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Furglot
            TempSpawn.Region = Area.Zi
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.BuhbullSpawner
            TempSpawn.Region = Area.Zi
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Scorpiant
            TempSpawn.Region = Area.Zi
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.TubeWorm
            TempSpawn.Region = Area.Zi
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Goolumn
            TempSpawn.Region = Area.Zi
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Prongfish
            TempSpawn.Region = Area.Zi
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Rugg
            TempSpawn.Region = Area.Zi
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Rugg_Meta
            TempSpawn.Region = Area.Zi
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Arachnoptopus
            TempSpawn.Region = Area.Zi
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Mutant_Idle
            TempSpawn.Region = Area.Zi
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Piston1
            TempSpawn.Region = Area.Zi
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Piston1
            TempSpawn.Region = Area.Zi
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Piston2
            TempSpawn.Region = Area.Zi
            Spawns.Add(TempSpawn)
            '______________ 'TraceHallucination not replaced
            'TempSpawn = New MonsterSpawn()
            'TempSpawn.Vanilla = CreatureType.RepairDrone
            'TempSpawn.Region = Area.Zi
            'Spawns.Add(TempSpawn)
            '
            '_______________Kur
            '
            '_______________Area 4
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Pliaa
            TempSpawn.Region = Area.Kur
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Quadropus
            TempSpawn.Region = Area.Kur
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Gill
            TempSpawn.Region = Area.Kur
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Blite
            TempSpawn.Region = Area.Kur
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Spidler
            TempSpawn.Region = Area.Kur
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Drometon
            TempSpawn.Region = Area.Kur
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Mogra
            TempSpawn.Region = Area.Kur
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.SmallMogra
            TempSpawn.Region = Area.Kur
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.FlynnStone
            TempSpawn.Region = Area.Kur
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.NrokSpawner
            TempSpawn.Region = Area.Kur
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Seamk
            TempSpawn.Region = Area.Kur
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Mutant_Strong
            TempSpawn.Region = Area.Kur
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Mutant_Sleeping
            TempSpawn.Region = Area.Kur
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.TrapClaw_Gamma
            TempSpawn.Region = Area.Kur
            Spawns.Add(TempSpawn)
            '______________
            'TempSpawn = New MonsterSpawn()
            'TempSpawn.Vanilla = CreatureType.RepairDroneSpawner
            'TempSpawn.Region = Area.Kur
            'Spawns.Add(TempSpawn)
            '______________
            'TempSpawn = New MonsterSpawn()
            'TempSpawn.Vanilla = CreatureType.RepairDrone
            'TempSpawn.Region = Area.Kur
            'Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.EyeCopter
            TempSpawn.Region = Area.Kur
            Spawns.Add(TempSpawn)
            '
            '_______________Indi
            '
            '_______________Area 5
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Drometon
            TempSpawn.Region = Area.Indi
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Glugg
            TempSpawn.Region = Area.Indi
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Blurst
            TempSpawn.Region = Area.Indi
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.TubePuff
            TempSpawn.Region = Area.Indi
            Spawns.Add(TempSpawn)
            '______________
            'TempSpawn = New MonsterSpawn()
            'TempSpawn.Vanilla = CreatureType.RepairDrone
            'TempSpawn.Region = Area.Indi
            'Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Snailborg
            TempSpawn.Region = Area.Indi
            Spawns.Add(TempSpawn)
            '
            '_______________UkkinNa "Normal"
            '
            '_______________Area 6
            'TempSpawn = New MonsterSpawn()
            'TempSpawn.Vanilla = CreatureType.RepairDrone
            'TempSpawn.Region = Area.UkkinNa
            'Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.SentryBot
            TempSpawn.Region = Area.UkkinNa
            Spawns.Add(TempSpawn)
            '______________
            'Annihiwaiter will remain
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Potato
            TempSpawn.Region = Area.UkkinNa
            Spawns.Add(TempSpawn)
            '______________
            'Daraga will remain
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Glugg
            TempSpawn.Region = Area.UkkinNa
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.TubePuff
            TempSpawn.Region = Area.UkkinNa
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Elsenova
            TempSpawn.Region = Area.UkkinNa
            Spawns.Add(TempSpawn)
            '
            '_______________Edin
            '
            '_______________Area 7
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Jorm
            TempSpawn.Region = Area.Edin
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Jormite
            TempSpawn.Region = Area.Edin
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.NightRayTube
            TempSpawn.Region = Area.Edin
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.EyeCopter
            TempSpawn.Region = Area.Edin
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Mutant_Strong
            TempSpawn.Region = Area.Edin
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Hoverling
            TempSpawn.Region = Area.Edin
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Volg
            TempSpawn.Region = Area.Edin
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.SpaceBat
            TempSpawn.Region = Area.Edin
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.WillOWisp
            TempSpawn.Region = Area.Edin
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.DeformedTraceChrysalis
            TempSpawn.Region = Area.Edin
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Hoverling
            TempSpawn.Region = Area.Edin
            Spawns.Add(TempSpawn)
            '
            '_______________EKurMah
            '
            '_______________Area 8
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Hoverbug
            TempSpawn.Region = Area.EKurMah
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Hookfish
            TempSpawn.Region = Area.EKurMah
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Furglot
            TempSpawn.Region = Area.EKurMah
            Spawns.Add(TempSpawn)
            '______________
            TempSpawn = New MonsterSpawn()
            TempSpawn.Vanilla = CreatureType.Artichoker
            TempSpawn.Region = Area.EKurMah
            Spawns.Add(TempSpawn)
            '
            '_______________MarUru
            '
            '_______________Area 9
            'TempSpawn = New MonsterSpawn()
            'TempSpawn.Vanilla = CreatureType.Diskko
            'TempSpawn.Region = Area.MarUru
            'Spawns.Add(TempSpawn)
            '______________
            'TempSpawn = New MonsterSpawn()
            'TempSpawn.Vanilla = CreatureType.SentryBot_Meta
            'TempSpawn.Region = Area.MarUru
            'Spawns.Add(TempSpawn)
            '______________
            'TieFlighter to stay for puzzle
            'DonaughtFactory staying because it's basically the final boss.
            'BreachAttractor staying for final boss
            'Elsenova staying for final boss
            'ElevatorEndCap staying for final boss
            'Athetos staying for final boss
            Return Spawns
        End Function
        Public Shared Function BannedMonsters()
            Dim Bans As List(Of CreatureType) = New List(Of CreatureType)
            Bans.Add(CreatureType.Piston1)
            Bans.Add(CreatureType.Piston2)
            Bans.Add(CreatureType.Piston3)
            Bans.Add(CreatureType.Diskko)
            Bans.Add(CreatureType.SentryBot_Meta)
            Bans.Add(CreatureType.DonaughtFactory)
            Bans.Add(CreatureType.TieFlighter)
            Bans.Add(CreatureType.Oraca)
            Bans.Add(CreatureType.BreachAttractor)
            Bans.Add(CreatureType.ElevatorEndCap)
            Bans.Add(CreatureType.Elsenova)
            Bans.Add(CreatureType.Athetos)
            Bans.Add(CreatureType.TraceHallucination)
            Bans.Add(CreatureType.RepairDroneSpawner)
            Bans.Add(CreatureType.RepairDrone)
            Bans.Add(CreatureType.RepairDrone_egg)
            Return Bans
        End Function
    End Class
#End Region
#Region "Practice Mode"
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
    Public Class PracticeItems
        Public Shared Function ResetItemPool()
            Dim Items As List(Of ItemDrop)
            Items = New List(Of ItemDrop)
            Dim TempItem As ItemDrop
            'GivenPowers Removed for Practice so iterations do not happen//
#Region "PowerUp Drops"
            '
            '______________WEAPONS
            '
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.DataDisruptor
            TempItem.GivenPowers = New List(Of Powers)
            'TempItem.GivenPowers.AddRange({Powers.Damage})
            TempItem.GID = 2
            TempItem.Weight = 20
            Items.Add(TempItem)
            '
            '______________UPGRADES
            '
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.Drill
            TempItem.GivenPowers = New List(Of Powers)
            'TempItem.GivenPowers.AddRange({Powers.Drill})
            TempItem.GID = 33
            TempItem.Weight = 19
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.AddressDisruptor1
            TempItem.GivenPowers = New List(Of Powers)
            'TempItem.GivenPowers.AddRange({Powers.Glitch1})
            TempItem.GID = 37
            TempItem.Weight = 18
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.AddressDisruptor2
            TempItem.GivenPowers = New List(Of Powers)
            ''TempItem.GivenPowers.AddRange({Powers.Glitch2})
            TempItem.GID = 60
            TempItem.Weight = 17
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.GlitchBomb
            TempItem.GivenPowers = New List(Of Powers)
            'TempItem.GivenPowers.AddRange({Powers.Glitch3})
            TempItem.GID = 70
            TempItem.Weight = 16
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.HighJump
            TempItem.GivenPowers = New List(Of Powers)
            'TempItem.GivenPowers.AddRange({Powers.HighJump})
            TempItem.GID = 37
            TempItem.Weight = 15
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.Grapple
            TempItem.GivenPowers = New List(Of Powers)
            'TempItem.GivenPowers.AddRange({Powers.Grapple})
            TempItem.GID = 62
            TempItem.Weight = 14
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.GlitchTeleport
            TempItem.GivenPowers = New List(Of Powers)
            'TempItem.GivenPowers.AddRange({Powers.LabCoat})
            TempItem.GID = 61
            TempItem.Weight = 13
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.BlackCoat
            TempItem.GivenPowers = New List(Of Powers)
            'TempItem.GivenPowers.AddRange({Powers.TrenchCoat})
            TempItem.GID = 72
            TempItem.Weight = 12
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.RedCoat
            TempItem.GivenPowers = New List(Of Powers)
            'TempItem.GivenPowers.AddRange({Powers.RedCoat})
            TempItem.GID = 68
            TempItem.Weight = 11
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.DroneGun
            TempItem.GivenPowers = New List(Of Powers)
            'TempItem.GivenPowers.AddRange({Powers.Drone})
            TempItem.GID = 63
            TempItem.Weight = 10
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.EnhancedLaunch
            TempItem.GivenPowers = New List(Of Powers)
            'TempItem.GivenPowers.AddRange({Powers.EnhancedLaunch})
            TempItem.GID = 64
            TempItem.Weight = 9
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.DroneTeleport
            TempItem.GivenPowers = New List(Of Powers)
            'TempItem.GivenPowers.AddRange({Powers.DroneTeleport})
            TempItem.GID = 71
            TempItem.Weight = 8
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.PasswordTool
            TempItem.GivenPowers = New List(Of Powers)
            'TempItem.GivenPowers.AddRange({Powers.Passwords})
            TempItem.GID = 69
            TempItem.Weight = 7
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.BreachSuppressor
            TempItem.GivenPowers = New List(Of Powers)
            'TempItem.GivenPowers.AddRange({Powers.Key})
            TempItem.GID = 73
            TempItem.Weight = 6
            Items.Add(TempItem)
#End Region
#Region "Weapon Drops"
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.Nova
            TempItem.GivenPowers = New List(Of Powers)
            'TempItem.GivenPowers.AddRange({Powers.Nova, Powers.Damage})
            TempItem.GID = 3
            TempItem.Weight = 50
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.MultiDisruptor
            TempItem.GivenPowers = New List(Of Powers)
            'TempItem.GivenPowers.AddRange({Powers.Damage})
            TempItem.GID = 35
            TempItem.Weight = 49
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.Kilver
            TempItem.GivenPowers = New List(Of Powers)
            'TempItem.GivenPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Kilver})
            TempItem.GID = 36
            TempItem.Weight = 48
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.FlameThrower
            TempItem.GivenPowers = New List(Of Powers)
            'TempItem.GivenPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Kilver})
            TempItem.GID = 40
            TempItem.Weight = 47
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.VerticalSpread
            TempItem.GivenPowers = New List(Of Powers)
            'TempItem.GivenPowers.AddRange({Powers.Damage, Powers.Nova})
            TempItem.GID = 43
            TempItem.Weight = 46
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.IonBeam
            TempItem.GivenPowers = New List(Of Powers)
            'TempItem.GivenPowers.AddRange({Powers.Damage})
            TempItem.GID = 44
            TempItem.Weight = 45
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.TriCone
            TempItem.GivenPowers = New List(Of Powers)
            'TempItem.GivenPowers.AddRange({Powers.Damage})
            TempItem.GID = 45
            TempItem.Weight = 44
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.Reflect
            TempItem.GivenPowers = New List(Of Powers)
            'TempItem.GivenPowers.AddRange({Powers.Damage, Powers.Nova})
            TempItem.GID = 46
            TempItem.Weight = 43
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.WallTrace
            TempItem.GivenPowers = New List(Of Powers)
            'TempItem.GivenPowers.AddRange({Powers.Damage, Powers.Nova})
            TempItem.GID = 47
            TempItem.Weight = 42
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.InertialPulse
            TempItem.GivenPowers = New List(Of Powers)
            'TempItem.GivenPowers.AddRange({Powers.Damage})
            TempItem.GID = 48
            TempItem.Weight = 41
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.FireWall
            TempItem.GivenPowers = New List(Of Powers)
            'TempItem.GivenPowers.AddRange({Powers.Damage})
            TempItem.GID = 49
            TempItem.Weight = 40
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.TetheredCharge
            TempItem.GivenPowers = New List(Of Powers)
            'TempItem.GivenPowers.AddRange({Powers.Damage, Powers.Nova})
            TempItem.GID = 50
            TempItem.Weight = 39
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.Scythe
            TempItem.GivenPowers = New List(Of Powers)
            'TempItem.GivenPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Kilver})
            TempItem.GID = 51
            TempItem.Weight = 38
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.Shards
            TempItem.GivenPowers = New List(Of Powers)
            'TempItem.GivenPowers.AddRange({Powers.Damage})
            TempItem.GID = 52
            TempItem.Weight = 37
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.DistortionField
            TempItem.GivenPowers = New List(Of Powers)
            'TempItem.GivenPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Kilver})
            TempItem.GID = 53
            TempItem.Weight = 36
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.Voranj
            TempItem.GivenPowers = New List(Of Powers)
            'TempItem.GivenPowers.AddRange({Powers.Damage})
            TempItem.GID = 54
            TempItem.Weight = 35
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.DataGrenade
            TempItem.GivenPowers = New List(Of Powers)
            'TempItem.GivenPowers.AddRange({Powers.Damage})
            TempItem.GID = 55
            TempItem.Weight = 34
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.LightningGun
            TempItem.GivenPowers = New List(Of Powers)
            'TempItem.GivenPowers.AddRange({Powers.Damage})
            TempItem.GID = 56
            TempItem.Weight = 33
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "FatBeam"
            TempItem.DropType = ItemType.FatBeam
            TempItem.GivenPowers = New List(Of Powers)
            'TempItem.GivenPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Kilver, Powers.FatBeam})
            TempItem.GID = 57
            TempItem.Weight = 32
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.Swim
            TempItem.GivenPowers = New List(Of Powers)
            'TempItem.GivenPowers.AddRange({Powers.Damage})
            TempItem.GID = 58
            TempItem.Weight = 31
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "WebSlicer"
            TempItem.DropType = ItemType.WebSlicer
            TempItem.GivenPowers = New List(Of Powers)
            'TempItem.GivenPowers.AddRange({Powers.Damage, Powers.Nova, Powers.Kilver})
            TempItem.GID = 59
            TempItem.Weight = 30
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HeatSeeker"
            TempItem.DropType = ItemType.HeatSeeker
            TempItem.GivenPowers = New List(Of Powers)
            'TempItem.GivenPowers.AddRange({Powers.Damage})
            TempItem.GID = 57 'Guess IDK if it'll work
            TempItem.Weight = 29
            Items.Add(TempItem)
#End Region
#Region "Node Drops"
            '
            '______________SIZE NODES
            '
            TempItem = New ItemDrop()
            TempItem.Name = "SizeNode1"
            TempItem.DropType = ItemType.SizeNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 65
            TempItem.Weight = 28
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "SizeNode2"
            TempItem.DropType = ItemType.SizeNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 65
            TempItem.Weight = 27
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "SizeNode3"
            TempItem.DropType = ItemType.SizeNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 65
            TempItem.Weight = 26
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "SizeNode4"
            TempItem.DropType = ItemType.SizeNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 65
            TempItem.Weight = 25
            Items.Add(TempItem)
            '
            '______________RANGE NODES
            '
            TempItem = New ItemDrop()
            TempItem.Name = "RangeNode1"
            TempItem.DropType = ItemType.SizeNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 66
            TempItem.Weight = 24
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "RangeNode2"
            TempItem.DropType = ItemType.SizeNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 66
            TempItem.Weight = 23
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "RangeNode3"
            TempItem.DropType = ItemType.SizeNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 66
            TempItem.Weight = 22
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "RangeNode4"
            TempItem.DropType = ItemType.SizeNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 66
            TempItem.Weight = 21
            Items.Add(TempItem)
            '
            '______________Health NODES
            '
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNode1"
            TempItem.DropType = ItemType.HealthNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 34
            TempItem.Weight = 75
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNode2"
            TempItem.DropType = ItemType.HealthNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 34
            TempItem.Weight = 74
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNode3"
            TempItem.DropType = ItemType.HealthNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 34
            TempItem.Weight = 73
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNode4"
            TempItem.DropType = ItemType.HealthNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 34
            TempItem.Weight = 72
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNode5"
            TempItem.DropType = ItemType.HealthNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 34
            TempItem.Weight = 71
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNode6"
            TempItem.DropType = ItemType.HealthNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 34
            TempItem.Weight = 70
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNode7"
            TempItem.DropType = ItemType.HealthNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 34
            TempItem.Weight = 69
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNode8"
            TempItem.DropType = ItemType.HealthNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 34
            TempItem.Weight = 68
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNode9"
            TempItem.DropType = ItemType.HealthNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 34
            TempItem.Weight = 67
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "PowerNode1"
            TempItem.DropType = ItemType.PowerNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 32
            TempItem.Weight = 66
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "PowerNode2"
            TempItem.DropType = ItemType.PowerNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 32
            TempItem.Weight = 65
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "PowerNode3"
            TempItem.DropType = ItemType.PowerNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 32
            TempItem.Weight = 64
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "PowerNode4"
            TempItem.DropType = ItemType.PowerNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 32
            TempItem.Weight = 63
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "PowerNode5"
            TempItem.DropType = ItemType.PowerNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 32
            TempItem.Weight = 62
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "PowerNode6"
            TempItem.DropType = ItemType.PowerNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 32
            TempItem.Weight = 61
            Items.Add(TempItem)
#End Region
            '______________
            'To Delete the old disruptor location
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNodeFragment25"
            TempItem.DropType = ItemType.HealthNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 38
            TempItem.Weight = 100
            Items.Add(TempItem)

            Return Items
        End Function

    End Class
#End Region
End Namespace
