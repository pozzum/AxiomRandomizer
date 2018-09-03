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
        LabCoat
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
        GunModel
        Damage
        Drill
        Nova 'Doors opened by Nova
        Kilver 'Doors Opened by Nova
        FatBeam 'Doors Opened by Fatbeam
        Glitch1
        Glitch2
        Glitch3
        Passwords
        Coat
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
        Public Region As Area
        Public LineNumber1 As Integer
        Public XLocation As Integer
        Public YLocation As Integer
        Public RequiredPowers As List(Of Powers)
        Public PowerOptions As List(Of Powers)
        Public GroupedPowers As List(Of Powers)
        Public Weight As Double
        Public Item As ItemType
        Public ItemName As String = "" 'Required for nodes to save
        Public PlaceOrder As Integer
        Public ItemWeight As Double
        Public InGameItemID As Integer
        Public AddedDrop As Boolean = False
    End Class
    Public Class ItemDrop
        Public Name As String
        Public DropType As ItemType
        Public GivenPowers As List(Of Powers)
        Public GID As Integer
        Public WallRestrict As Boolean
        Public Weight As Double
        Public Placed As Boolean = False
    End Class
#End Region
#Region "Normal Difficulty"
    Public Class NormalLocations
        Public Shared Function ResetLocations()
            Dim Locations As List(Of Location)
            Locations = New List(Of Location)

            Dim TempLocation As Location
            '
            '_______________Eribu
            '
            '_______________Area 1
            TempLocation = New Location()
            TempLocation.Name = "Left From Start"
            TempLocation.Vanilla = ItemType.DataDisruptor
            TempLocation.Region = Area.Eribu
            TempLocation.LineNumber1 = 2923
            TempLocation.XLocation = 4064
            TempLocation.YLocation = 3184
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.GroupedPowers = New List(Of Powers)
            TempLocation.Weight = 1.9 'Makes this always placed first
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Red Ruins"
            TempLocation.Vanilla = ItemType.Nova
            TempLocation.Region = Area.Eribu
            TempLocation.LineNumber1 = 2937
            TempLocation.XLocation = 8880
            TempLocation.YLocation = 1232
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.GroupedPowers = New List(Of Powers)
            TempLocation.Weight = 1.5
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Red Stalagmites"
            TempLocation.Vanilla = ItemType.SizeNode
            TempLocation.Region = Area.Eribu
            TempLocation.LineNumber1 = 3035
            TempLocation.XLocation = 5024
            TempLocation.YLocation = 2096
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Nova})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "After Xedur"
            TempLocation.Vanilla = ItemType.Drill
            TempLocation.Region = Area.Eribu
            TempLocation.LineNumber1 = 2945
            TempLocation.XLocation = 8960
            TempLocation.YLocation = 2672
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Nova})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Entering Absu"
            TempLocation.Vanilla = ItemType.HealthNode
            TempLocation.Region = Area.Eribu
            TempLocation.LineNumber1 = 3000
            TempLocation.XLocation = 8384
            TempLocation.YLocation = 5072
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Drilled Under Xedur"
            TempLocation.Vanilla = ItemType.PowerNode
            TempLocation.Region = Area.Eribu
            TempLocation.LineNumber1 = 2938
            TempLocation.XLocation = 8016
            TempLocation.YLocation = 2928
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Nova})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Upper Left Platforms"
            TempLocation.Vanilla = ItemType.MultiDisruptor
            TempLocation.Region = Area.Eribu
            TempLocation.LineNumber1 = 3025
            TempLocation.XLocation = 5504
            TempLocation.YLocation = 1472
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Nova})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Guarded by Ghouls"
            TempLocation.Vanilla = ItemType.HealthNodeFragment
            TempLocation.Region = Area.Eribu
            TempLocation.LineNumber1 = 3026
            TempLocation.XLocation = 7040
            TempLocation.YLocation = 4944
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.PowerOptions.AddRange({Powers.RedCoat,
                                               Powers.Grapple})
            TempLocation.GroupedPowers = New List(Of Powers)
            TempLocation.GroupedPowers.AddRange({Powers.Drone, Powers.DroneTeleport})
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Lower Left Password"
            TempLocation.Vanilla = ItemType.WallTrace
            TempLocation.Region = Area.Eribu
            TempLocation.LineNumber1 = 3131
            TempLocation.XLocation = 6576
            TempLocation.YLocation = 4384
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Passwords})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.PowerOptions.AddRange({Powers.RedCoat,
                                               Powers.Grapple})
            TempLocation.GroupedPowers = New List(Of Powers)
            TempLocation.GroupedPowers.AddRange({Powers.Drone, Powers.DroneTeleport})
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Under Water"
            TempLocation.Vanilla = ItemType.HealthNodeFragment
            TempLocation.Region = Area.Eribu
            TempLocation.LineNumber1 = 3058
            TempLocation.XLocation = 2272
            TempLocation.YLocation = 3136
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Drone})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.PowerOptions.AddRange({Powers.RedCoat,
                                               Powers.DroneTeleport})
            TempLocation.GroupedPowers = New List(Of Powers)
            TempLocation.GroupedPowers.AddRange({Powers.Glitch3,
                                                Powers.HighJump,
                                                Powers.Grapple})
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Exit to Indi"
            TempLocation.Vanilla = ItemType.PowerNodeFragment
            TempLocation.Region = Area.Eribu
            TempLocation.LineNumber1 = 3085
            TempLocation.XLocation = 8464
            TempLocation.YLocation = 4416
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.RedCoat})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.PowerOptions.AddRange({Powers.Grapple,
                                               Powers.DroneTeleport})
            TempLocation.GroupedPowers = New List(Of Powers)
            TempLocation.GroupedPowers.AddRange({Powers.Drone,
                                                Powers.DroneTeleport})
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Reflector Room"
            TempLocation.Vanilla = ItemType.HealthNode
            TempLocation.Region = Area.Eribu
            TempLocation.LineNumber1 = 3087
            TempLocation.XLocation = 7904
            TempLocation.YLocation = 704
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Nova,
                                                 Powers.Glitch3})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.PowerOptions.AddRange({Powers.Grapple,
                                               Powers.DroneTeleport})
            TempLocation.GroupedPowers = New List(Of Powers)
            TempLocation.GroupedPowers.AddRange({Powers.Drone,
                                                Powers.DroneTeleport})
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Dilled Above First Item"
            TempLocation.Vanilla = ItemType.Lore
            TempLocation.Region = Area.Eribu
            TempLocation.LineNumber1 = 3088
            TempLocation.XLocation = 5040
            TempLocation.YLocation = 2640
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.LabCoat,
                                                 Powers.Drone,
                                                 Powers.DroneTeleport})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Behind Laser wall Password"
            TempLocation.Vanilla = ItemType.PowerNodeFragment
            TempLocation.Region = Area.Eribu
            TempLocation.LineNumber1 = 3057
            TempLocation.XLocation = 4064
            TempLocation.YLocation = 1552
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Nova,
                                                 Powers.Passwords,
                                                 Powers.Grapple})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Main Shaft Glitch Bomb"
            TempLocation.Vanilla = ItemType.LightningGun
            TempLocation.Region = Area.Eribu
            TempLocation.LineNumber1 = 3086
            TempLocation.XLocation = 6000
            TempLocation.YLocation = 3744
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Glitch3,
                                                 Powers.Drone,
                                                 Powers.DroneTeleport})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Far Left Password"
            TempLocation.Vanilla = ItemType.FlameThrower
            TempLocation.Region = Area.Eribu
            TempLocation.LineNumber1 = 3130
            TempLocation.XLocation = 2144
            TempLocation.YLocation = 1776
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Passwords,
                                                 Powers.HighJump,
                                                 Powers.Drone,
                                                 Powers.DroneTeleport})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.PowerOptions.AddRange({Powers.Glitch3,
                                               Powers.RedCoat})
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '
            '_______________Absu
            '
            '_______________Area 2
            TempLocation = New Location()
            TempLocation.Name = "Elsenova"
            TempLocation.Vanilla = ItemType.Kilver
            TempLocation.Region = Area.Absu
            TempLocation.LineNumber1 = 5137
            TempLocation.XLocation = 4064
            TempLocation.YLocation = 2304
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Drilled Shaft"
            TempLocation.Vanilla = ItemType.HealthNodeFragment
            TempLocation.Region = Area.Absu
            TempLocation.LineNumber1 = 5277
            TempLocation.XLocation = 2032
            TempLocation.YLocation = 1744
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "After Telal"
            TempLocation.Vanilla = ItemType.AddressDisruptor1
            TempLocation.Region = Area.Absu
            TempLocation.LineNumber1 = 5325
            TempLocation.XLocation = 6608
            TempLocation.YLocation = 1808
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Bellow Corruption"
            TempLocation.Vanilla = ItemType.RangeNode
            TempLocation.Region = Area.Absu
            TempLocation.LineNumber1 = 5412
            TempLocation.XLocation = 3488
            TempLocation.YLocation = 3152
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Glitch2,
                                                 Powers.LabCoat,
                                                 Powers.Drone})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Drone by Skeleton"
            TempLocation.Vanilla = ItemType.Lore
            TempLocation.Region = Area.Absu
            TempLocation.LineNumber1 = 5409
            TempLocation.XLocation = 1200
            TempLocation.YLocation = 2576
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Drone})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Attic Left"
            TempLocation.Vanilla = ItemType.PowerNodeFragment
            TempLocation.Region = Area.Absu
            TempLocation.LineNumber1 = 5357
            TempLocation.XLocation = 3600
            TempLocation.YLocation = 576
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Grapple})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Bottom Left Main Shaft"
            TempLocation.Vanilla = ItemType.DataGrenade
            TempLocation.Region = Area.Absu
            TempLocation.LineNumber1 = 5353
            TempLocation.XLocation = 1680
            TempLocation.YLocation = 3120
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.TrenchCoat})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Behind Kilver Door"
            TempLocation.Vanilla = ItemType.HealthNodeFragment
            TempLocation.Region = Area.Absu
            TempLocation.LineNumber1 = 5279
            TempLocation.XLocation = 3104
            TempLocation.YLocation = 1056
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Middle of Lower Shaft"
            TempLocation.Vanilla = ItemType.HealthNode
            TempLocation.Region = Area.Absu
            TempLocation.LineNumber1 = 5242
            TempLocation.XLocation = 7392
            TempLocation.YLocation = 2176
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.PowerOptions.AddRange({Powers.Glitch1,
                                               Powers.TrenchCoat})
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Exit to Zi"
            TempLocation.Vanilla = ItemType.PowerNode
            TempLocation.Region = Area.Absu
            TempLocation.LineNumber1 = 5158
            TempLocation.XLocation = 11824
            TempLocation.YLocation = 3488
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.PowerOptions.AddRange({Powers.Glitch1,
                                               Powers.TrenchCoat})
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Jail Cell"
            TempLocation.Vanilla = ItemType.Lore
            TempLocation.Region = Area.Absu
            TempLocation.LineNumber1 = 5414
            TempLocation.XLocation = 3424
            TempLocation.YLocation = 2960
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver,
                                                 Powers.LabCoat})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Green Squid Room"
            TempLocation.Vanilla = ItemType.Lore
            TempLocation.Region = Area.Absu
            TempLocation.LineNumber1 = 5411
            TempLocation.XLocation = 9072
            TempLocation.YLocation = 2592
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.PowerOptions.AddRange({Powers.Glitch1,
                                               Powers.TrenchCoat})
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Pink Vines"
            TempLocation.Vanilla = ItemType.Lore
            TempLocation.Region = Area.Absu
            TempLocation.LineNumber1 = 5410
            TempLocation.XLocation = 6464
            TempLocation.YLocation = 3088
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver,
                                                 Powers.Glitch1})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Lowest Room"
            TempLocation.Vanilla = ItemType.Lore
            TempLocation.Region = Area.Absu
            TempLocation.LineNumber1 = 5408
            TempLocation.XLocation = 3520
            TempLocation.YLocation = 4016
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver,
                                                 Powers.LabCoat})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Lower Right Corrupted"
            TempLocation.Vanilla = ItemType.InertialPulse
            TempLocation.Region = Area.Absu
            TempLocation.LineNumber1 = 5359
            TempLocation.XLocation = 11744
            TempLocation.YLocation = 2304
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver,
                                                 Powers.Glitch2})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Purple Corrupted Diatom"
            TempLocation.Vanilla = ItemType.SizeNode
            TempLocation.Region = Area.Absu
            TempLocation.LineNumber1 = 5320
            TempLocation.XLocation = 7344
            TempLocation.YLocation = 2816
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.PowerOptions.AddRange({Powers.Glitch1,
                                               Powers.TrenchCoat})
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Remote Detonation"
            TempLocation.Vanilla = ItemType.HealthNodeFragment
            TempLocation.Region = Area.Absu
            TempLocation.LineNumber1 = 5278
            TempLocation.XLocation = 10512
            TempLocation.YLocation = 2912
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.PowerOptions.AddRange({Powers.Glitch1,
                                               Powers.TrenchCoat})
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Far Left Hallway"
            TempLocation.Vanilla = ItemType.PowerNodeFragment
            TempLocation.Region = Area.Absu
            TempLocation.LineNumber1 = 5415
            TempLocation.XLocation = 176
            TempLocation.YLocation = 2112
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver,
                                                 Powers.Glitch1})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Upper Attic"
            TempLocation.Vanilla = ItemType.PowerNodeFragment
            TempLocation.Region = Area.Absu
            TempLocation.LineNumber1 = 5355
            TempLocation.XLocation = 4544
            TempLocation.YLocation = 480
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver,
                                                 Powers.Glitch1})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Lava Secret"
            TempLocation.Vanilla = ItemType.PowerNodeFragment
            TempLocation.Region = Area.Absu
            TempLocation.LineNumber1 = 5423
            TempLocation.XLocation = 10800
            TempLocation.YLocation = 3744
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver,
                                                 Powers.TrenchCoat})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.PowerOptions.AddRange({Powers.Grapple,
                                               Powers.HighJump})
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Chasm Tunnel"
            TempLocation.Vanilla = ItemType.Lore
            TempLocation.Region = Area.Absu
            TempLocation.LineNumber1 = 5413
            TempLocation.XLocation = 9232
            TempLocation.YLocation = 3472
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver,
                                                 Powers.Drone})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.PowerOptions.AddRange({Powers.Glitch1,
                                               Powers.TrenchCoat})
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Green Fungus Secret"
            TempLocation.Vanilla = ItemType.RangeNode
            TempLocation.Region = Area.Absu
            TempLocation.LineNumber1 = 5324
            TempLocation.XLocation = 8400
            TempLocation.YLocation = 3152
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver,
                                                 Powers.Drone})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.PowerOptions.AddRange({Powers.Glitch1,
                                               Powers.TrenchCoat})
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Lower Attic"
            TempLocation.Vanilla = ItemType.PowerNodeFragment
            TempLocation.Region = Area.Absu
            TempLocation.LineNumber1 = 5356
            TempLocation.XLocation = 4080
            TempLocation.YLocation = 736
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Glitch3,
                                                 Powers.Grapple})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Right Attic"
            TempLocation.Vanilla = ItemType.PowerNodeFragment
            TempLocation.Region = Area.Absu
            TempLocation.LineNumber1 = 5354
            TempLocation.XLocation = 5152
            TempLocation.YLocation = 448
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Glitch3,
                                                 Powers.Drone})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Boss Secret"
            TempLocation.Vanilla = ItemType.HealthNodeFragment
            TempLocation.Region = Area.Absu
            TempLocation.LineNumber1 = 5358
            TempLocation.XLocation = 8400
            TempLocation.YLocation = 128
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver,
                                                 Powers.LabCoat,
                                                 Powers.Grapple})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.PowerOptions.AddRange({Powers.Glitch1,
                                               Powers.TrenchCoat})
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '
            '_______________Zi
            '
            '_______________Area 3
            TempLocation = New Location()
            TempLocation.Name = "After Uruku"
            TempLocation.Vanilla = ItemType.LabCoat
            TempLocation.Region = Area.Zi
            TempLocation.LineNumber1 = 4896
            TempLocation.XLocation = 6000
            TempLocation.YLocation = 480
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver,
                                                 Powers.HighJump})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.PowerOptions.AddRange({Powers.Glitch1,
                                               Powers.TrenchCoat})
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Bottom Arterial Shaft"
            TempLocation.Vanilla = ItemType.HealthNodeFragment
            TempLocation.Region = Area.Zi
            TempLocation.LineNumber1 = 4949
            TempLocation.XLocation = 5040
            TempLocation.YLocation = 2656
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver,
                                                 Powers.Drone})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.PowerOptions.AddRange({Powers.Glitch1,
                                               Powers.TrenchCoat})
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "High Jump Bypass"
            TempLocation.Vanilla = ItemType.Lore
            TempLocation.Region = Area.Zi
            TempLocation.LineNumber1 = 4940
            TempLocation.XLocation = 3776
            TempLocation.YLocation = 864
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver,
                                                 Powers.HighJump})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.PowerOptions.AddRange({Powers.Glitch1,
                                               Powers.TrenchCoat})
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Veruska Basement"
            TempLocation.Vanilla = ItemType.Lore
            TempLocation.Region = Area.Zi
            TempLocation.LineNumber1 = 4939
            TempLocation.XLocation = 5168
            TempLocation.YLocation = 3488
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver,
                                                 Powers.Drone})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.PowerOptions.AddRange({Powers.Glitch1,
                                               Powers.TrenchCoat})
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Eye Stalk Secret"
            TempLocation.Vanilla = ItemType.PowerNodeFragment
            TempLocation.Region = Area.Zi
            TempLocation.LineNumber1 = 4910
            TempLocation.XLocation = 240
            TempLocation.YLocation = 2336
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver,
                                                 Powers.HighJump})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.PowerOptions.AddRange({Powers.Glitch1,
                                               Powers.TrenchCoat})
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Veruska Secret"
            TempLocation.Vanilla = ItemType.PasswordTool
            TempLocation.Region = Area.Zi
            TempLocation.LineNumber1 = 4909
            TempLocation.XLocation = 4064
            TempLocation.YLocation = 3408
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver,
                                                 Powers.Drone})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.PowerOptions.AddRange({Powers.Glitch1,
                                               Powers.TrenchCoat})
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Above Ruggs"
            TempLocation.Vanilla = ItemType.HealthNodeFragment
            TempLocation.Region = Area.Zi
            TempLocation.LineNumber1 = 4908
            TempLocation.XLocation = 2480
            TempLocation.YLocation = 2864
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver,
                                                 Powers.HighJump})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.PowerOptions.AddRange({Powers.Glitch1,
                                               Powers.TrenchCoat})
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "High Jump Access"
            TempLocation.Vanilla = ItemType.SizeNode
            TempLocation.Region = Area.Zi
            TempLocation.LineNumber1 = 4906
            TempLocation.XLocation = 4032
            TempLocation.YLocation = 2224
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver,
                                                 Powers.HighJump})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.PowerOptions.AddRange({Powers.Glitch1,
                                               Powers.TrenchCoat})
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Steam Secret"
            TempLocation.Vanilla = ItemType.TendrilsTop
            TempLocation.Region = Area.Zi
            TempLocation.LineNumber1 = 4592
            TempLocation.XLocation = 1184
            TempLocation.YLocation = 2592
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver,
                                                 Powers.HighJump})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.PowerOptions.AddRange({Powers.Glitch1,
                                               Powers.TrenchCoat})
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Boss Room"
            TempLocation.Vanilla = ItemType.HealthNode
            TempLocation.Region = Area.Zi
            TempLocation.LineNumber1 = 4893
            TempLocation.XLocation = 4736
            TempLocation.YLocation = 336
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver,
                                                 Powers.HighJump,
                                                 Powers.LabCoat})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.PowerOptions.AddRange({Powers.Glitch1,
                                               Powers.TrenchCoat})
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Maintenance Secret"
            TempLocation.Vanilla = ItemType.Lore
            TempLocation.Region = Area.Zi
            TempLocation.LineNumber1 = 4941
            TempLocation.XLocation = 816
            TempLocation.YLocation = 1552
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver,
                                                 Powers.HighJump,
                                                 Powers.Drone})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.PowerOptions.AddRange({Powers.Glitch1,
                                               Powers.TrenchCoat})
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Maintenance Tunnel"
            TempLocation.Vanilla = ItemType.Voranj
            TempLocation.Region = Area.Zi
            TempLocation.LineNumber1 = 4911
            TempLocation.XLocation = 2160
            TempLocation.YLocation = 1840
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver,
                                                 Powers.HighJump,
                                                 Powers.Drone})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.PowerOptions.AddRange({Powers.Glitch1,
                                               Powers.TrenchCoat})
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Center Steam Room"
            TempLocation.Vanilla = ItemType.RangeNode
            TempLocation.Region = Area.Zi
            TempLocation.LineNumber1 = 4907
            TempLocation.XLocation = 1472
            TempLocation.YLocation = 3120
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver,
                                                 Powers.HighJump,
                                                 Powers.LabCoat})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.PowerOptions.AddRange({Powers.Glitch1,
                                               Powers.TrenchCoat})
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Filtration Preview"
            TempLocation.Vanilla = ItemType.HealthNodeFragment
            TempLocation.Region = Area.Zi
            TempLocation.LineNumber1 = 4897
            TempLocation.XLocation = 4560
            TempLocation.YLocation = 1280
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver,
                                                 Powers.HighJump,
                                                 Powers.LabCoat})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.PowerOptions.AddRange({Powers.Glitch1,
                                               Powers.TrenchCoat})
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Filtration Up High"
            TempLocation.Vanilla = ItemType.PowerNodeFragment
            TempLocation.Region = Area.Zi
            TempLocation.LineNumber1 = 4948
            TempLocation.XLocation = 5632
            TempLocation.YLocation = 128
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver,
                                                 Powers.HighJump,
                                                 Powers.RedCoat,
                                                 Powers.Drone})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '
            '_______________Kur
            '
            '_______________Area 4
            TempLocation = New Location()
            TempLocation.Name = "Below Cavern"
            TempLocation.Vanilla = ItemType.HighJump
            TempLocation.Region = Area.Kur
            TempLocation.LineNumber1 = 4673
            TempLocation.XLocation = 2640
            TempLocation.YLocation = 6704
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.PowerOptions.AddRange({Powers.Glitch1,
                                               Powers.TrenchCoat})
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Drone Runs"
            TempLocation.Vanilla = ItemType.AddressDisruptor2
            TempLocation.Region = Area.Kur
            TempLocation.LineNumber1 = 4931
            TempLocation.XLocation = 704
            TempLocation.YLocation = 6704
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.PowerOptions.AddRange({Powers.Glitch2,
                                               Powers.TrenchCoat,
                                               Powers.Drone})
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Hidden in Cavern"
            TempLocation.Vanilla = ItemType.FireWall
            TempLocation.Region = Area.Kur
            TempLocation.LineNumber1 = 4906
            TempLocation.XLocation = 1952
            TempLocation.YLocation = 6128
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.PowerOptions.AddRange({Powers.Glitch1,
                                               Powers.TrenchCoat})
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Drilled High Jump"
            TempLocation.Vanilla = ItemType.HealthNodeFragment
            TempLocation.Region = Area.Kur
            TempLocation.LineNumber1 = 4803
            TempLocation.XLocation = 2816
            TempLocation.YLocation = 5872
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver,
                                                 Powers.HighJump,
                                                 Powers.Drone})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.PowerOptions.AddRange({Powers.Glitch1,
                                               Powers.TrenchCoat})
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Mountain Slope"
            TempLocation.Vanilla = ItemType.IonBeam
            TempLocation.Region = Area.Kur
            TempLocation.LineNumber1 = 4959
            TempLocation.XLocation = 2128
            TempLocation.YLocation = 3376
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver,
                                                 Powers.HighJump,
                                                 Powers.TrenchCoat})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Near Indi Exit"
            TempLocation.Vanilla = ItemType.PowerNode
            TempLocation.Region = Area.Kur
            TempLocation.LineNumber1 = 4719
            TempLocation.XLocation = 240
            TempLocation.YLocation = 5840
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver,
                                                 Powers.HighJump,
                                                 Powers.LabCoat})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.PowerOptions.AddRange({Powers.Glitch1,
                                               Powers.TrenchCoat})
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Wall Blocked Slope Room"
            TempLocation.Vanilla = ItemType.DroneGun
            TempLocation.Region = Area.Kur
            TempLocation.LineNumber1 = 4782
            TempLocation.XLocation = 3104
            TempLocation.YLocation = 3456
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver,
                                                 Powers.HighJump,
                                                 Powers.LabCoat})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.PowerOptions.AddRange({Powers.Glitch1,
                                               Powers.TrenchCoat})
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Thorn Maze Secret"
            TempLocation.Vanilla = ItemType.VerticalSpread
            TempLocation.Region = Area.Kur
            TempLocation.LineNumber1 = 4957
            TempLocation.XLocation = 2640
            TempLocation.YLocation = 4208
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver,
                                                 Powers.HighJump,
                                                 Powers.LabCoat})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.PowerOptions.AddRange({Powers.Glitch1,
                                               Powers.TrenchCoat,
                                               Powers.RedCoat,
                                               Powers.Drone})
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Lair Secret"
            TempLocation.Vanilla = ItemType.HealthNode
            TempLocation.Region = Area.Kur
            TempLocation.LineNumber1 = 4846
            TempLocation.XLocation = 4544
            TempLocation.YLocation = 3200
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver,
                                                 Powers.HighJump,
                                                 Powers.LabCoat})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.PowerOptions.AddRange({Powers.Glitch2,
                                               Powers.TrenchCoat})
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Above Grapple"
            TempLocation.Vanilla = ItemType.HealthNodeFragment
            TempLocation.Region = Area.Kur
            TempLocation.LineNumber1 = 4853
            TempLocation.XLocation = 7984
            TempLocation.YLocation = 1680
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver,
                                                 Powers.HighJump,
                                                 Powers.LabCoat})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.PowerOptions.AddRange({Powers.Glitch1,
                                               Powers.TrenchCoat})
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Climb out of the Pit"
            TempLocation.Vanilla = ItemType.Grapple
            TempLocation.Region = Area.Kur
            TempLocation.LineNumber1 = 4781
            TempLocation.XLocation = 8048
            TempLocation.YLocation = 2016
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver,
                                                 Powers.HighJump,
                                                 Powers.LabCoat})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.PowerOptions.AddRange({Powers.Glitch1,
                                               Powers.TrenchCoat})
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Grappled Mountain Slope"
            TempLocation.Vanilla = ItemType.HealthNodeFragment
            TempLocation.Region = Area.Kur
            TempLocation.LineNumber1 = 4785
            TempLocation.XLocation = 1728
            TempLocation.YLocation = 3184
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver,
                                                 Powers.HighJump,
                                                 Powers.LabCoat,
                                                 Powers.Grapple})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.PowerOptions.AddRange({Powers.Glitch1,
                                               Powers.TrenchCoat})
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Above Lair"
            TempLocation.Vanilla = ItemType.HealthNodeFragment
            TempLocation.Region = Area.Kur
            TempLocation.LineNumber1 = 4791
            TempLocation.XLocation = 3120
            TempLocation.YLocation = 4320
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver,
                                                 Powers.HighJump,
                                                 Powers.LabCoat,
                                                 Powers.Drone})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.PowerOptions.AddRange({Powers.Glitch2,
                                               Powers.TrenchCoat})
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Crumbling Blocks"
            TempLocation.Vanilla = ItemType.PowerNode
            TempLocation.Region = Area.Kur
            TempLocation.LineNumber1 = 4847
            TempLocation.XLocation = 7760
            TempLocation.YLocation = 1264
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver,
                                                 Powers.HighJump,
                                                 Powers.LabCoat,
                                                 Powers.Grapple})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.PowerOptions.AddRange({Powers.Glitch2,
                                               Powers.TrenchCoat})
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Stalagmite Maze"
            TempLocation.Vanilla = ItemType.TetheredCharge
            TempLocation.Region = Area.Kur
            TempLocation.LineNumber1 = 4975
            TempLocation.XLocation = 4560
            TempLocation.YLocation = 6656
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver,
                                                 Powers.HighJump,
                                                 Powers.LabCoat,
                                                 Powers.Grapple,
                                                 Powers.Glitch1})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.PowerOptions.AddRange({Powers.RedCoat,
                                               Powers.Drone})
            TempLocation.GroupedPowers = New List(Of Powers)
            TempLocation.GroupedPowers.AddRange({Powers.TrenchCoat,
                                               Powers.FatBeam})
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Hidden Ice Crags"
            TempLocation.Vanilla = ItemType.Lore
            TempLocation.Region = Area.Kur
            TempLocation.LineNumber1 = 4953
            TempLocation.XLocation = 4192
            TempLocation.YLocation = 2304
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver,
                                                 Powers.HighJump,
                                                 Powers.LabCoat,
                                                 Powers.Grapple,
                                                 Powers.Drone})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.PowerOptions.AddRange({Powers.Glitch2,
                                               Powers.TrenchCoat})
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Above Stalagmites"
            TempLocation.Vanilla = ItemType.Reflect
            TempLocation.Region = Area.Kur
            TempLocation.LineNumber1 = 4929
            TempLocation.XLocation = 5504
            TempLocation.YLocation = 1472
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver,
                                                 Powers.HighJump,
                                                 Powers.LabCoat,
                                                 Powers.Grapple,
                                                 Powers.Drone})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.PowerOptions.AddRange({Powers.Glitch2,
                                               Powers.TrenchCoat})
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Ice Crag Ruins"
            TempLocation.Vanilla = ItemType.EnhancedLaunch
            TempLocation.Region = Area.Kur
            TempLocation.LineNumber1 = 4928
            TempLocation.XLocation = 5024
            TempLocation.YLocation = 1792
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver,
                                                 Powers.HighJump,
                                                 Powers.LabCoat,
                                                 Powers.Grapple,
                                                 Powers.Drone})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.PowerOptions.AddRange({Powers.Glitch2,
                                               Powers.TrenchCoat})
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Hidden Stalagmite"
            TempLocation.Vanilla = ItemType.HealthNodeFragment
            TempLocation.Region = Area.Kur
            TempLocation.LineNumber1 = 4911
            TempLocation.XLocation = 4576
            TempLocation.YLocation = 2096
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver,
                                                 Powers.HighJump,
                                                 Powers.LabCoat,
                                                 Powers.Grapple,
                                                 Powers.Drone})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.PowerOptions.AddRange({Powers.Glitch2,
                                               Powers.TrenchCoat})
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "High Up Ice Crags"
            TempLocation.Vanilla = ItemType.Lore
            TempLocation.Region = Area.Kur
            TempLocation.LineNumber1 = 4952
            TempLocation.XLocation = 2016
            TempLocation.YLocation = 1632
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver,
                                                 Powers.HighJump,
                                                 Powers.LabCoat,
                                                 Powers.Grapple,
                                                 Powers.Drone,
                                                 Powers.EnhancedLaunch})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.PowerOptions.AddRange({Powers.Glitch2,
                                               Powers.TrenchCoat})
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Higher Up Ice Crags"
            TempLocation.Vanilla = ItemType.PowerNodeFragment
            TempLocation.Region = Area.Kur
            TempLocation.LineNumber1 = 4958
            TempLocation.XLocation = 2176
            TempLocation.YLocation = 1440
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver,
                                                 Powers.HighJump,
                                                 Powers.LabCoat,
                                                 Powers.Grapple,
                                                 Powers.Drone,
                                                 Powers.EnhancedLaunch,
                                                 Powers.DroneTeleport})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.PowerOptions.AddRange({Powers.Glitch2,
                                               Powers.TrenchCoat})
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Top of Kur"
            TempLocation.Vanilla = ItemType.Lore
            TempLocation.Region = Area.Kur
            TempLocation.LineNumber1 = 4956
            TempLocation.XLocation = 3424
            TempLocation.YLocation = 576
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver,
                                                 Powers.HighJump,
                                                 Powers.LabCoat,
                                                 Powers.Grapple,
                                                 Powers.Drone,
                                                 Powers.EnhancedLaunch,
                                                 Powers.DroneTeleport})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.PowerOptions.AddRange({Powers.Glitch2,
                                               Powers.TrenchCoat})
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '
            '_______________Indi
            '
            '_______________Area 5
            TempLocation = New Location()
            TempLocation.Name = "Near Eribu"
            TempLocation.Vanilla = ItemType.Lore
            TempLocation.Region = Area.Indi
            TempLocation.LineNumber1 = 2580
            TempLocation.XLocation = 128
            TempLocation.YLocation = 608
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver,
                                                 Powers.Drone})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.PowerOptions.AddRange({Powers.Glitch1,
                                               Powers.TrenchCoat})
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Near Edin"
            TempLocation.Vanilla = ItemType.Lore
            TempLocation.Region = Area.Indi
            TempLocation.LineNumber1 = 2578
            TempLocation.XLocation = 11344
            TempLocation.YLocation = 336
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver,
                                                 Powers.Drone,
                                                 Powers.HighJump,
                                                 Powers.LabCoat,
                                                 Powers.TrenchCoat})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.PowerOptions.AddRange({Powers.Glitch1,
                                               Powers.TrenchCoat})
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '
            'UkkinNa
            '
            '_______________Area 6
            TempLocation = New Location()
            TempLocation.Name = "Above Ophelia"
            TempLocation.Vanilla = ItemType.Lore
            TempLocation.Region = Area.UkkinNa
            TempLocation.LineNumber1 = 6163
            TempLocation.XLocation = 1312
            TempLocation.YLocation = 1648
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.HighJump,
                                                 Powers.LabCoat})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.PowerOptions.AddRange({Powers.RedCoat})
            TempLocation.GroupedPowers = New List(Of Powers)
            TempLocation.PowerOptions.AddRange({Powers.Glitch2,
                                               Powers.TrenchCoat})
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Above Insanity"
            TempLocation.Vanilla = ItemType.BlackCoat
            TempLocation.Region = Area.UkkinNa
            TempLocation.LineNumber1 = 6147
            TempLocation.XLocation = 3616
            TempLocation.YLocation = 2672
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.HighJump,
                                                 Powers.LabCoat})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.PowerOptions.AddRange({Powers.Glitch2,
                                               Powers.RedCoat})
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Above Waiter"
            TempLocation.Vanilla = ItemType.HealthNodeFragment
            TempLocation.Region = Area.UkkinNa
            TempLocation.LineNumber1 = 6145
            TempLocation.XLocation = 1728
            TempLocation.YLocation = 4608
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.HighJump,
                                                 Powers.LabCoat})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.PowerOptions.AddRange({Powers.RedCoat})
            TempLocation.GroupedPowers = New List(Of Powers)
            TempLocation.PowerOptions.AddRange({Powers.Glitch2,
                                               Powers.Drone,
                                               Powers.DroneTeleport})
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Right of Ophelia"
            TempLocation.Vanilla = ItemType.HealthNode
            TempLocation.Region = Area.UkkinNa
            TempLocation.LineNumber1 = 6137
            TempLocation.XLocation = 1648
            TempLocation.YLocation = 2208
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.HighJump,
                                                 Powers.LabCoat})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.PowerOptions.AddRange({Powers.Glitch2,
                                               Powers.RedCoat})
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Hidden Psychosis"
            TempLocation.Vanilla = ItemType.PowerNodeFragment
            TempLocation.Region = Area.UkkinNa
            TempLocation.LineNumber1 = 6168
            TempLocation.XLocation = 4528
            TempLocation.YLocation = 2080
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.HighJump,
                                                 Powers.LabCoat,
                                                 Powers.Drone})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.PowerOptions.AddRange({Powers.Glitch2,
                                               Powers.RedCoat})
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Wall Blocked Insanity"
            TempLocation.Vanilla = ItemType.PowerNodeFragment
            TempLocation.Region = Area.UkkinNa
            TempLocation.LineNumber1 = 6167
            TempLocation.XLocation = 3456
            TempLocation.YLocation = 3456
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.HighJump,
                                                 Powers.LabCoat,
                                                 Powers.TrenchCoat})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.PowerOptions.AddRange({Powers.Glitch2,
                                               Powers.RedCoat})
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Hidden Maddness"
            TempLocation.Vanilla = ItemType.Lore
            TempLocation.Region = Area.UkkinNa
            TempLocation.LineNumber1 = 6164
            TempLocation.XLocation = 2928
            TempLocation.YLocation = 4256
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.HighJump,
                                                 Powers.LabCoat,
                                                 Powers.TrenchCoat,
                                                 Powers.Drone})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.PowerOptions.AddRange({Powers.Glitch2,
                                               Powers.RedCoat})
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Drop Below Ophelia"
            TempLocation.Vanilla = ItemType.Lore
            TempLocation.Region = Area.UkkinNa
            TempLocation.LineNumber1 = 6162
            TempLocation.XLocation = 1664
            TempLocation.YLocation = 4384
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.HighJump,
                                                 Powers.LabCoat,
                                                 Powers.TrenchCoat})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.PowerOptions.AddRange({Powers.Glitch2,
                                               Powers.RedCoat})
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Below Madness"
            TempLocation.Vanilla = ItemType.PowerNodeFragment
            TempLocation.Region = Area.UkkinNa
            TempLocation.LineNumber1 = 6148
            TempLocation.XLocation = 4208
            TempLocation.YLocation = 4816
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.HighJump,
                                                 Powers.LabCoat,
                                                 Powers.TrenchCoat})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.PowerOptions.AddRange({Powers.RedCoat})
            TempLocation.GroupedPowers = New List(Of Powers)
            TempLocation.GroupedPowers.AddRange({Powers.Glitch2,
                                               Powers.FatBeam})
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Below Pep talk"
            TempLocation.Vanilla = ItemType.HealthNodeFragment
            TempLocation.Region = Area.UkkinNa
            TempLocation.LineNumber1 = 6140
            TempLocation.XLocation = 3744
            TempLocation.YLocation = 1568
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.HighJump,
                                                 Powers.LabCoat,
                                                 Powers.TrenchCoat,
                                                 Powers.Drone})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.PowerOptions.AddRange({Powers.Glitch2,
                                               Powers.RedCoat})
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "High Above Pop Talk"
            TempLocation.Vanilla = ItemType.HealthNodeFragment
            TempLocation.Region = Area.UkkinNa
            TempLocation.LineNumber1 = 6165
            TempLocation.XLocation = 4672
            TempLocation.YLocation = 272
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.HighJump,
                                                 Powers.LabCoat,
                                                 Powers.Drone,
                                                 Powers.EnhancedLaunch,
                                                 Powers.DroneTeleport})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.PowerOptions.AddRange({Powers.Glitch2,
                                               Powers.RedCoat})
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '
            'Edin
            '
            '_______________Area 7
            TempLocation = New Location()
            TempLocation.Name = "Rusalki Bodies"
            TempLocation.Vanilla = ItemType.GlitchBomb
            TempLocation.Region = Area.Edin
            TempLocation.LineNumber1 = 4326
            TempLocation.XLocation = 7456
            TempLocation.YLocation = 3696
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver,
                                                 Powers.HighJump,
                                                 Powers.TrenchCoat})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.PowerOptions.AddRange({Powers.RedCoat})
            TempLocation.GroupedPowers = New List(Of Powers)
            TempLocation.PowerOptions.AddRange({Powers.Glitch3,
                                               Powers.HighJump})
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Hangar Entrance"
            TempLocation.Vanilla = ItemType.Lore
            TempLocation.Region = Area.Edin
            TempLocation.LineNumber1 = 4362
            TempLocation.XLocation = 6160
            TempLocation.YLocation = 3200
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver,
                                                 Powers.HighJump,
                                                 Powers.LabCoat,
                                                 Powers.TrenchCoat})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Western Hangar Entrance"
            TempLocation.Vanilla = ItemType.Lore
            TempLocation.Region = Area.Edin
            TempLocation.LineNumber1 = 4361
            TempLocation.XLocation = 5584
            TempLocation.YLocation = 2928
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver,
                                                 Powers.HighJump,
                                                 Powers.LabCoat,
                                                 Powers.TrenchCoat})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "West Tower Secret"
            TempLocation.Vanilla = ItemType.Lore
            TempLocation.Region = Area.Edin
            TempLocation.LineNumber1 = 4357
            TempLocation.XLocation = 4192
            TempLocation.YLocation = 2880
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver,
                                                 Powers.HighJump,
                                                 Powers.LabCoat,
                                                 Powers.TrenchCoat})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Grapple Up Western"
            TempLocation.Vanilla = ItemType.Lore
            TempLocation.Region = Area.Edin
            TempLocation.LineNumber1 = 4367
            TempLocation.XLocation = 5456
            TempLocation.YLocation = 2160
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver,
                                                 Powers.HighJump,
                                                 Powers.LabCoat,
                                                 Powers.TrenchCoat,
                                                 Powers.Grapple})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "After Ukhu"
            TempLocation.Vanilla = ItemType.DroneTeleport
            TempLocation.Region = Area.Edin
            TempLocation.LineNumber1 = 4328
            TempLocation.XLocation = 2240
            TempLocation.YLocation = 1248
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver,
                                                 Powers.HighJump,
                                                 Powers.LabCoat,
                                                 Powers.TrenchCoat,
                                                 Powers.Drone})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Below Ukhu"
            TempLocation.Vanilla = ItemType.Lore
            TempLocation.Region = Area.Edin
            TempLocation.LineNumber1 = 4356
            TempLocation.XLocation = 3472
            TempLocation.YLocation = 1824
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver,
                                                 Powers.HighJump,
                                                 Powers.LabCoat,
                                                 Powers.TrenchCoat,
                                                 Powers.Drone})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Hidden Tunnel West"
            TempLocation.Vanilla = ItemType.RangeNode
            TempLocation.Region = Area.Edin
            TempLocation.LineNumber1 = 4329
            TempLocation.XLocation = 4688
            TempLocation.YLocation = 3744
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver,
                                                 Powers.HighJump,
                                                 Powers.LabCoat,
                                                 Powers.TrenchCoat,
                                                 Powers.Drone})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "West Tower West Secret"
            TempLocation.Vanilla = ItemType.HealthNode
            TempLocation.Region = Area.Edin
            TempLocation.LineNumber1 = 4342
            TempLocation.XLocation = 2464
            TempLocation.YLocation = 2384
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver,
                                                 Powers.HighJump,
                                                 Powers.LabCoat,
                                                 Powers.TrenchCoat,
                                                 Powers.Drone,
                                                 Powers.DroneTeleport})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Above West Tower"
            TempLocation.Vanilla = ItemType.PowerNodeFragment
            TempLocation.Region = Area.Edin
            TempLocation.LineNumber1 = 4363
            TempLocation.XLocation = 3424
            TempLocation.YLocation = 2112
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver,
                                                 Powers.HighJump,
                                                 Powers.LabCoat,
                                                 Powers.TrenchCoat,
                                                 Powers.Drone,
                                                 Powers.DroneTeleport})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Hangar Attic"
            TempLocation.Vanilla = ItemType.PowerNode
            TempLocation.Region = Area.Edin
            TempLocation.LineNumber1 = 4366
            TempLocation.XLocation = 6960
            TempLocation.YLocation = 3216
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver,
                                                 Powers.HighJump,
                                                 Powers.LabCoat,
                                                 Powers.TrenchCoat,
                                                 Powers.Drone,
                                                 Powers.DroneTeleport})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Hangar Attic Second"
            TempLocation.Vanilla = ItemType.HealthNode
            TempLocation.Region = Area.Edin
            TempLocation.LineNumber1 = 4335
            TempLocation.XLocation = 6928
            TempLocation.YLocation = 3216
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver,
                                                 Powers.HighJump,
                                                 Powers.LabCoat,
                                                 Powers.TrenchCoat,
                                                 Powers.Drone,
                                                 Powers.DroneTeleport})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Open Air Grapple"
            TempLocation.Vanilla = ItemType.HealthNodeFragment
            TempLocation.Region = Area.Edin
            TempLocation.LineNumber1 = 4368
            TempLocation.XLocation = 528
            TempLocation.YLocation = 3264
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver,
                                                 Powers.HighJump,
                                                 Powers.LabCoat,
                                                 Powers.TrenchCoat,
                                                 Powers.Drone,
                                                 Powers.EnhancedLaunch,
                                                 Powers.DroneTeleport})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "West Tower Base"
            TempLocation.Vanilla = ItemType.Shards
            TempLocation.Region = Area.Edin
            TempLocation.LineNumber1 = 4341
            TempLocation.XLocation = 3392
            TempLocation.YLocation = 3632
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver,
                                                 Powers.HighJump,
                                                 Powers.LabCoat,
                                                 Powers.TrenchCoat,
                                                 Powers.Glitch3})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Hangar Foyer"
            TempLocation.Vanilla = ItemType.DistortionField
            TempLocation.Region = Area.Edin
            TempLocation.LineNumber1 = 4330
            TempLocation.XLocation = 6000
            TempLocation.YLocation = 1872
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver,
                                                 Powers.HighJump,
                                                 Powers.LabCoat,
                                                 Powers.TrenchCoat,
                                                 Powers.Glitch1,
                                                 Powers.Drone,
                                                 Powers.EnhancedLaunch,
                                                 Powers.DroneTeleport})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Suspended Room"
            TempLocation.Vanilla = ItemType.TendrilsBottom
            TempLocation.Region = Area.Edin
            TempLocation.LineNumber1 = 4343
            TempLocation.XLocation = 2000
            TempLocation.YLocation = 3088
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver,
                                                 Powers.HighJump,
                                                 Powers.LabCoat,
                                                 Powers.TrenchCoat,
                                                 Powers.Grapple,
                                                 Powers.Glitch1,
                                                 Powers.Drone,
                                                 Powers.EnhancedLaunch,
                                                 Powers.DroneTeleport})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '
            'EKurMah
            '
            '_______________Area 8
            TempLocation = New Location()
            TempLocation.Name = "Behind Seal"
            TempLocation.Vanilla = ItemType.PowerNode
            TempLocation.Region = Area.EKurMah
            TempLocation.LineNumber1 = 3723
            TempLocation.XLocation = 1040
            TempLocation.YLocation = 512
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver,
                                                 Powers.HighJump,
                                                 Powers.LabCoat,
                                                 Powers.TrenchCoat})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.PowerOptions.AddRange({Powers.RedCoat})
            TempLocation.GroupedPowers = New List(Of Powers)
            TempLocation.GroupedPowers.AddRange({Powers.Grapple,
                                                Powers.Drone,
                                                Powers.DroneTeleport,
                                                Powers.Key})
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "RedCoat Exhibition"
            TempLocation.Vanilla = ItemType.PowerNodeFragment
            TempLocation.Region = Area.EKurMah
            TempLocation.LineNumber1 = 3705
            TempLocation.XLocation = 1984
            TempLocation.YLocation = 5936
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver,
                                                 Powers.HighJump,
                                                 Powers.LabCoat,
                                                 Powers.TrenchCoat,
                                                 Powers.RedCoat})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Secondary Key Chamber"
            TempLocation.Vanilla = ItemType.Lore
            TempLocation.Region = Area.EKurMah
            TempLocation.LineNumber1 = 3683
            TempLocation.XLocation = 3744
            TempLocation.YLocation = 960
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver,
                                                 Powers.HighJump,
                                                 Powers.LabCoat,
                                                 Powers.TrenchCoat})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.PowerOptions.AddRange({Powers.RedCoat})
            TempLocation.GroupedPowers = New List(Of Powers)
            TempLocation.GroupedPowers.AddRange({Powers.Grapple,
                                                Powers.Drone,
                                                Powers.DroneTeleport,
                                                Powers.Key})
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Drilled In Entrance"
            TempLocation.Vanilla = ItemType.Lore
            TempLocation.Region = Area.EKurMah
            TempLocation.LineNumber1 = 3682
            TempLocation.XLocation = 1136
            TempLocation.YLocation = 1168
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver,
                                                 Powers.HighJump,
                                                 Powers.LabCoat,
                                                 Powers.TrenchCoat})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.PowerOptions.AddRange({Powers.RedCoat})
            TempLocation.GroupedPowers = New List(Of Powers)
            TempLocation.GroupedPowers.AddRange({Powers.Grapple,
                                                Powers.Drone,
                                                Powers.DroneTeleport,
                                                Powers.Key})
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Basement"
            TempLocation.Vanilla = ItemType.RedCoat
            TempLocation.Region = Area.EKurMah
            TempLocation.LineNumber1 = 3661
            TempLocation.XLocation = 1664
            TempLocation.YLocation = 5600
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver,
                                                 Powers.HighJump,
                                                 Powers.LabCoat,
                                                 Powers.TrenchCoat})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.PowerOptions.AddRange({Powers.RedCoat})
            TempLocation.GroupedPowers = New List(Of Powers)
            TempLocation.GroupedPowers.AddRange({Powers.Grapple,
                                                Powers.Drone,
                                                Powers.DroneTeleport,
                                                Powers.Key})
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Primary Key Chamber"
            TempLocation.Vanilla = ItemType.BreachSuppressor
            TempLocation.Region = Area.EKurMah
            TempLocation.LineNumber1 = 3658
            TempLocation.XLocation = 3296
            TempLocation.YLocation = 672
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver,
                                                 Powers.HighJump,
                                                 Powers.LabCoat,
                                                 Powers.TrenchCoat})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.PowerOptions.AddRange({Powers.RedCoat})
            TempLocation.GroupedPowers = New List(Of Powers)
            TempLocation.GroupedPowers.AddRange({Powers.Grapple,
                                                Powers.Drone,
                                                Powers.DroneTeleport,
                                                Powers.Key})
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Verdan Cavern"
            TempLocation.Vanilla = ItemType.HealthNodeFragment
            TempLocation.Region = Area.EKurMah
            TempLocation.LineNumber1 = 3659
            TempLocation.XLocation = 2848
            TempLocation.YLocation = 4896
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver,
                                                 Powers.HighJump,
                                                 Powers.LabCoat,
                                                 Powers.TrenchCoat,
                                                 Powers.Drone})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.PowerOptions.AddRange({Powers.RedCoat})
            TempLocation.GroupedPowers = New List(Of Powers)
            TempLocation.GroupedPowers.AddRange({Powers.Grapple,
                                                Powers.Drone,
                                                Powers.DroneTeleport,
                                                Powers.Key})
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Basement Shaft"
            TempLocation.Vanilla = ItemType.Lore
            TempLocation.Region = Area.EKurMah
            TempLocation.LineNumber1 = 3688
            TempLocation.XLocation = 3520
            TempLocation.YLocation = 2288
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver,
                                                 Powers.HighJump,
                                                 Powers.LabCoat,
                                                 Powers.TrenchCoat,
                                                 Powers.Drone,
                                                 Powers.DroneTeleport,
                                                 Powers.RedCoat})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Passworded Verdan Cavern"
            TempLocation.Vanilla = ItemType.Swim
            TempLocation.Region = Area.EKurMah
            TempLocation.LineNumber1 = 3660
            TempLocation.XLocation = 1544
            TempLocation.YLocation = 4432
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver,
                                                 Powers.HighJump,
                                                 Powers.LabCoat,
                                                 Powers.TrenchCoat,
                                                 Powers.Drone,
                                                 Powers.DroneTeleport,
                                                 Powers.Passwords,
                                                 Powers.Key})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '
            'MarUru
            '
            '_______________Area 9
            TempLocation = New Location()
            TempLocation.Name = "Above Save Room"
            TempLocation.Vanilla = ItemType.Lore
            TempLocation.Region = Area.MarUru
            TempLocation.LineNumber1 = 11952
            TempLocation.XLocation = 1696
            TempLocation.YLocation = 3744
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver,
                                                 Powers.HighJump,
                                                 Powers.LabCoat,
                                                 Powers.TrenchCoat,
                                                 Powers.RedCoat,
                                                 Powers.Drone,
                                                 Powers.EnhancedLaunch,
                                                 Powers.DroneTeleport})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Final Shaft"
            TempLocation.Vanilla = ItemType.Lore
            TempLocation.Region = Area.MarUru
            TempLocation.LineNumber1 = 11951
            TempLocation.XLocation = 2016
            TempLocation.YLocation = 2496
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver,
                                                 Powers.HighJump,
                                                 Powers.LabCoat,
                                                 Powers.TrenchCoat,
                                                 Powers.RedCoat,
                                                 Powers.Drone,
                                                 Powers.EnhancedLaunch,
                                                 Powers.DroneTeleport})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Hybrid Room"
            TempLocation.Vanilla = ItemType.SizeNode
            TempLocation.Region = Area.MarUru
            TempLocation.LineNumber1 = 11947
            TempLocation.XLocation = 3072
            TempLocation.YLocation = 4320
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver,
                                                 Powers.HighJump,
                                                 Powers.LabCoat,
                                                 Powers.TrenchCoat,
                                                 Powers.RedCoat,
                                                 Powers.Drone,
                                                 Powers.EnhancedLaunch,
                                                 Powers.DroneTeleport})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "After Sentinel"
            TempLocation.Vanilla = ItemType.HealthNode
            TempLocation.Region = Area.MarUru
            TempLocation.LineNumber1 = 11944
            TempLocation.XLocation = 1520
            TempLocation.YLocation = 5312
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver,
                                                 Powers.HighJump,
                                                 Powers.LabCoat,
                                                 Powers.TrenchCoat,
                                                 Powers.RedCoat,
                                                 Powers.Drone,
                                                 Powers.EnhancedLaunch,
                                                 Powers.DroneTeleport})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Glitch Room Below"
            TempLocation.Vanilla = ItemType.Lore
            TempLocation.Region = Area.MarUru
            TempLocation.LineNumber1 = 11946
            TempLocation.XLocation = 2544
            TempLocation.YLocation = 5632
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver,
                                                 Powers.HighJump,
                                                 Powers.LabCoat,
                                                 Powers.TrenchCoat,
                                                 Powers.RedCoat,
                                                 Powers.Drone,
                                                 Powers.EnhancedLaunch,
                                                 Powers.DroneTeleport})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Glitch2,
                                                 Powers.FatBeam})
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Hidden Left of Save"
            TempLocation.Vanilla = ItemType.Scythe
            TempLocation.Region = Area.MarUru
            TempLocation.LineNumber1 = 11953
            TempLocation.XLocation = 1200
            TempLocation.YLocation = 4224
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver,
                                                 Powers.HighJump,
                                                 Powers.LabCoat,
                                                 Powers.TrenchCoat,
                                                 Powers.RedCoat,
                                                 Powers.Drone,
                                                 Powers.EnhancedLaunch,
                                                 Powers.DroneTeleport,
                                                 Powers.Glitch2})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Glitch Room Hidden"
            TempLocation.Vanilla = ItemType.PowerNodeFragment
            TempLocation.Region = Area.MarUru
            TempLocation.LineNumber1 = 11946
            TempLocation.XLocation = 2768
            TempLocation.YLocation = 5632
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver,
                                                 Powers.HighJump,
                                                 Powers.LabCoat,
                                                 Powers.TrenchCoat,
                                                 Powers.RedCoat,
                                                 Powers.Drone,
                                                 Powers.EnhancedLaunch,
                                                 Powers.DroneTeleport})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Glitch2,
                                                 Powers.FatBeam})
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            '_______________
            TempLocation = New Location()
            TempLocation.Name = "Glitch Room Primary"
            TempLocation.Vanilla = ItemType.PowerNodeFragment
            TempLocation.Region = Area.MarUru
            TempLocation.LineNumber1 = 11945
            TempLocation.XLocation = 2624
            TempLocation.YLocation = 5408
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Damage,
                                                 Powers.GunModel,
                                                 Powers.Drill,
                                                 Powers.Kilver,
                                                 Powers.HighJump,
                                                 Powers.LabCoat,
                                                 Powers.TrenchCoat,
                                                 Powers.RedCoat,
                                                 Powers.Drone,
                                                 Powers.EnhancedLaunch,
                                                 Powers.DroneTeleport})
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.RequiredPowers.AddRange({Powers.Glitch2,
                                                 Powers.FatBeam})
            TempLocation.GroupedPowers = New List(Of Powers)
            Locations.Add(TempLocation)
            Return Locations
        End Function
    End Class
    Public Class NormalItems
        Public Shared Function ResetItemPool()
            Dim Items As List(Of ItemDrop)
            Items = New List(Of ItemDrop)
            Dim TempItem As ItemDrop
            '
            '______________UPGRADES
            '
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.Drill
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({
                                          Powers.Drill,
                                          Powers.Damage})
            TempItem.GID = 33
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.AddressDisruptor1
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({
                                          Powers.Glitch1})
            TempItem.GID = 37
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.HighJump
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({
                                          Powers.HighJump})
            TempItem.GID = 37
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.TendrilsTop
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({
                                          Powers.Damage})
            TempItem.GID = 41
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.TendrilsBottom
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({
                                          Powers.Damage})
            TempItem.GID = 42
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.AddressDisruptor2
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({
                                          Powers.Glitch1,
                                          Powers.Glitch2})
            TempItem.GID = 60
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.GlitchTeleport
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({
                                          Powers.Coat,
                                          Powers.LabCoat,
                                          Powers.GunModel})
            TempItem.GID = 61
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.Grapple
            TempItem.WallRestrict = True
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({
                                          Powers.Damage,
                                          Powers.Nova,
                                          Powers.Grapple})
            TempItem.GID = 62
            TempItem.Weight = 0 'increases it's natural weight 
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.DroneGun
            TempItem.WallRestrict = True
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({
                                          Powers.Damage,
                                          Powers.Nova,
                                          Powers.Drill,
                                          Powers.Drone})
            TempItem.GID = 63
            TempItem.Weight = 0 'increases it's natural weight 
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.EnhancedLaunch
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({
                                          Powers.EnhancedLaunch})
            TempItem.GID = 64
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.RedCoat
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({
                                          Powers.GunModel,
                                          Powers.Damage,
                                          Powers.Glitch1,
                                          Powers.Glitch2,
                                          Powers.Coat,
                                          Powers.LabCoat,
                                          Powers.TrenchCoat,
                                          Powers.RedCoat})
            TempItem.GID = 68
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.PasswordTool
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({
                                          Powers.Passwords,
                                          Powers.Coat})
            TempItem.GID = 69
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.GlitchBomb
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({
                                          Powers.Glitch1,
                                          Powers.Glitch2,
                                          Powers.Glitch3})
            TempItem.GID = 70
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.DroneTeleport
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({
                                          Powers.DroneTeleport})
            TempItem.GID = 71
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.BlackCoat
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({
                                          Powers.GunModel,
                                          Powers.Damage,
                                          Powers.Nova,
                                          Powers.Kilver,
                                          Powers.Coat,
                                          Powers.LabCoat,
                                          Powers.TrenchCoat})
            TempItem.GID = 72
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.BreachSuppressor
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({
                                          Powers.Key})
            TempItem.GID = 73
            Items.Add(TempItem)
            '
            '______________WEAPONS
            '
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.DataDisruptor
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({
                                          Powers.GunModel,
                                          Powers.Damage})
            TempItem.GID = 2
            TempItem.Weight = 1.5
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.Nova
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({
                                          Powers.Nova,
                                          Powers.Damage})
            TempItem.GID = 3
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.MultiDisruptor
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({
                                          Powers.Damage})
            TempItem.GID = 35
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.Kilver
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({
                                          Powers.Damage,
                                          Powers.Nova,
                                          Powers.Kilver})
            TempItem.GID = 36
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.FlameThrower
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({
                                          Powers.Damage,
                                          Powers.Nova,
                                          Powers.Kilver})
            TempItem.GID = 40
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.VerticalSpread
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({
                                          Powers.Damage,
                                          Powers.Nova})
            TempItem.GID = 43
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.IonBeam
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({
                                          Powers.Damage})
            TempItem.GID = 44
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.TriCone
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({
                                          Powers.Damage})
            TempItem.GID = 45
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.Reflect
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({
                                          Powers.Damage,
                                          Powers.Nova})
            TempItem.GID = 46
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.WallTrace
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({
                                          Powers.Damage,
                                          Powers.Nova})
            TempItem.GID = 47
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.InertialPulse
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({
                                          Powers.Damage})
            TempItem.GID = 48
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.FireWall
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({
                                          Powers.Damage})
            TempItem.GID = 49
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.TetheredCharge
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({
                                          Powers.Damage,
                                          Powers.Nova})
            TempItem.GID = 50
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.Scythe
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({
                                          Powers.Damage,
                                          Powers.Nova,
                                          Powers.Kilver})
            TempItem.GID = 51
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.Shards
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({
                                          Powers.Damage})
            TempItem.GID = 52
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.DistortionField
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({
                                          Powers.Damage,
                                          Powers.Nova,
                                          Powers.Kilver})
            TempItem.GID = 53
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.Voranj
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({
                                          Powers.Damage})
            TempItem.GID = 54
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.DataGrenade
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({
                                          Powers.Damage})
            TempItem.GID = 55
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.LightningGun
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({
                                          Powers.Damage})
            TempItem.GID = 56
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "FatBeam"
            TempItem.DropType = ItemType.FatBeam
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({
                                          Powers.Damage,
                                          Powers.Nova,
                                          Powers.Kilver,
                                          Powers.FatBeam})
            TempItem.GID = 57
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.Swim
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({
                                          Powers.Damage})
            TempItem.GID = 58
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "WebSlicer"
            TempItem.DropType = ItemType.WebSlicer
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({
                                          Powers.Damage,
                                          Powers.Nova,
                                          Powers.Kilver})
            TempItem.GID = 59
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HeatSeeker"
            TempItem.DropType = ItemType.HeatSeeker
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({
                                          Powers.Damage,
                                          Powers.Nova,
                                          Powers.Kilver})
            TempItem.GID = 76 'Guess IDK if it'll work
            Items.Add(TempItem)
            '
            '______________HEALTH NODES
            '
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNode1"
            TempItem.DropType = ItemType.HealthNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 34
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNode2"
            TempItem.DropType = ItemType.HealthNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 34
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNode3"
            TempItem.DropType = ItemType.HealthNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 34
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNode4"
            TempItem.DropType = ItemType.HealthNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 34
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNode5"
            TempItem.DropType = ItemType.HealthNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 34
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNode6"
            TempItem.DropType = ItemType.HealthNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 34
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNode7"
            TempItem.DropType = ItemType.HealthNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 34
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNode8"
            TempItem.DropType = ItemType.HealthNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 34
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNode9"
            TempItem.DropType = ItemType.HealthNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 34
            Items.Add(TempItem)
            '
            '______________HEALTH NODE FRAGMENTS
            '
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNodeFragment1"
            TempItem.DropType = ItemType.HealthNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 38
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNodeFragment2"
            TempItem.DropType = ItemType.HealthNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 38
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNodeFragment3"
            TempItem.DropType = ItemType.HealthNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 38
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNodeFragment4"
            TempItem.DropType = ItemType.HealthNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 38
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNodeFragment5"
            TempItem.DropType = ItemType.HealthNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 38
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNodeFragment6"
            TempItem.DropType = ItemType.HealthNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 38
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNodeFragment7"
            TempItem.DropType = ItemType.HealthNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 38
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNodeFragment8"
            TempItem.DropType = ItemType.HealthNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 38
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNodeFragment9"
            TempItem.DropType = ItemType.HealthNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 38
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNodeFragment10"
            TempItem.DropType = ItemType.HealthNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 38
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNodeFragment11"
            TempItem.DropType = ItemType.HealthNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 38
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNodeFragment12"
            TempItem.DropType = ItemType.HealthNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 38
            Items.Add(TempItem)
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNodeFragment13"
            TempItem.DropType = ItemType.HealthNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 38
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNodeFragment14"
            TempItem.DropType = ItemType.HealthNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 38
            Items.Add(TempItem)
            '______________....Item is in a Slug
            'TempItem = New ItemDrop()
            'TempItem.Name = "HealthNodeFragment15"
            'TempItem.DropType = ItemType.HealthNodeFragment
            'TempItem.GivenPowers = New List(Of Powers)
            'TempItem.GID = 38
            'Items.Add(TempItem)
            'Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNodeFragment16"
            TempItem.DropType = ItemType.HealthNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 38
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNodeFragment17"
            TempItem.DropType = ItemType.HealthNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 38
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNodeFragment18"
            TempItem.DropType = ItemType.HealthNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 38
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNodeFragment19"
            TempItem.DropType = ItemType.HealthNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 38
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNodeFragment20"
            TempItem.DropType = ItemType.HealthNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 38
            Items.Add(TempItem)
            '
            '______________POWER NODES
            '
            TempItem = New ItemDrop()
            TempItem.Name = "PowerNode1"
            TempItem.DropType = ItemType.PowerNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 32
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "PowerNode2"
            TempItem.DropType = ItemType.PowerNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 32
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "PowerNode3"
            TempItem.DropType = ItemType.PowerNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 32
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "PowerNode4"
            TempItem.DropType = ItemType.PowerNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 32
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "PowerNode5"
            TempItem.DropType = ItemType.PowerNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 32
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "PowerNode6"
            TempItem.DropType = ItemType.PowerNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 32
            Items.Add(TempItem)
            '
            '______________POWER NODES FRAGMENTS
            '
            TempItem = New ItemDrop()
            TempItem.Name = "PowerNodeFragment1"
            TempItem.DropType = ItemType.PowerNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 74
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "PowerNodeFragment2"
            TempItem.DropType = ItemType.PowerNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 74
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "PowerNodeFragment3"
            TempItem.DropType = ItemType.PowerNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 74
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "PowerNodeFragment4"
            TempItem.DropType = ItemType.PowerNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 74
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "PowerNodeFragment5"
            TempItem.DropType = ItemType.PowerNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 74
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "PowerNodeFragment6"
            TempItem.DropType = ItemType.PowerNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 74
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "PowerNodeFragment7"
            TempItem.DropType = ItemType.PowerNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 74
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "PowerNodeFragment8"
            TempItem.DropType = ItemType.PowerNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 74
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "PowerNodeFragment9"
            TempItem.DropType = ItemType.PowerNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 74
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "PowerNodeFragment10"
            TempItem.DropType = ItemType.PowerNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 74
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "PowerNodeFragment11"
            TempItem.DropType = ItemType.PowerNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 74
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "PowerNodeFragment12"
            TempItem.DropType = ItemType.PowerNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 74
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "PowerNodeFragment13"
            TempItem.DropType = ItemType.PowerNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 74
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "PowerNodeFragment14"
            TempItem.DropType = ItemType.PowerNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 74
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "PowerNodeFragment15"
            TempItem.DropType = ItemType.PowerNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 74
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "PowerNodeFragment16"
            TempItem.DropType = ItemType.PowerNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 74
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "PowerNodeFragment17"
            TempItem.DropType = ItemType.PowerNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 74
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "PowerNodeFragment18"
            TempItem.DropType = ItemType.PowerNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 74
            Items.Add(TempItem)
            '
            '______________SIZE NODES
            '
            TempItem = New ItemDrop()
            TempItem.Name = "SizeNode1"
            TempItem.DropType = ItemType.SizeNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 65
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "SizeNode2"
            TempItem.DropType = ItemType.SizeNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 65
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "SizeNode3"
            TempItem.DropType = ItemType.SizeNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 65
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "SizeNode4"
            TempItem.DropType = ItemType.SizeNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 65
            Items.Add(TempItem)
            '
            '______________SIZE NODES
            '
            TempItem = New ItemDrop()
            TempItem.Name = "RangeNode1"
            TempItem.DropType = ItemType.RangeNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 66
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "RangeNode2"
            TempItem.DropType = ItemType.RangeNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 66
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "RangeNode3"
            TempItem.DropType = ItemType.RangeNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 66
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "RangeNode4"
            TempItem.DropType = ItemType.RangeNode
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 66
            Items.Add(TempItem)
            '
            '______________LORE
            '
            TempItem = New ItemDrop()
            TempItem.Name = "Note1"
            TempItem.DropType = ItemType.Lore
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 75
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "Note2"
            TempItem.DropType = ItemType.Lore
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 75
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "Note3"
            TempItem.DropType = ItemType.Lore
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 75
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "Note4"
            TempItem.DropType = ItemType.Lore
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 75
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "Note5"
            TempItem.DropType = ItemType.Lore
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 75
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "Note6"
            TempItem.DropType = ItemType.Lore
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 75
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "Note7"
            TempItem.DropType = ItemType.Lore
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 75
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "Note8"
            TempItem.DropType = ItemType.Lore
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 75
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "Note9"
            TempItem.DropType = ItemType.Lore
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 75
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "Note10"
            TempItem.DropType = ItemType.Lore
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 75
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "Note11"
            TempItem.DropType = ItemType.Lore
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 75
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "Note12"
            TempItem.DropType = ItemType.Lore
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 75
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "Note13"
            TempItem.DropType = ItemType.Lore
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 75
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "Note14"
            TempItem.DropType = ItemType.Lore
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 75
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "Note15"
            TempItem.DropType = ItemType.Lore
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 75
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "Note16"
            TempItem.DropType = ItemType.Lore
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 75
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "Note17"
            TempItem.DropType = ItemType.Lore
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 75
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "Note18"
            TempItem.DropType = ItemType.Lore
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 75
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "Note19"
            TempItem.DropType = ItemType.Lore
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 75
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "Note20"
            TempItem.DropType = ItemType.Lore
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 75
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "Note21"
            TempItem.DropType = ItemType.Lore
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 75
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "Note22"
            TempItem.DropType = ItemType.Lore
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 75
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "Note23"
            TempItem.DropType = ItemType.Lore
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 75
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "Note24"
            TempItem.DropType = ItemType.Lore
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 75
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "Note25"
            TempItem.DropType = ItemType.Lore
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 75
            Items.Add(TempItem)
            '______________...Next 3 removed for hidden weapons
            'TempItem = New ItemDrop()
            'TempItem.Name = "Note26"
            'TempItem.DropType = ItemType.Lore
            'TempItem.GivenPowers = New List(Of Powers)
            'TempItem.GID = 75
            'Items.Add(TempItem)
            '______________
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
            Return Items
        End Function
    End Class
#End Region
#Region "Practice Mode"
    Public Class PracticeLocations
        Public Shared Function ResetLocations()

            Dim Locations As List(Of Location)
            Locations = New List(Of Location)
            Dim TempLocation As Location
            '__________________________
            TempLocation = New Location()
            TempLocation.Name = "Practice 1"
            TempLocation.Region = Area.Eribu
            TempLocation.AddedDrop = True
            TempLocation.XLocation = 4416
            TempLocation.YLocation = 3120
            TempLocation.RequiredPowers = New List(Of Powers)
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.GroupedPowers = New List(Of Powers)
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
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.GroupedPowers = New List(Of Powers)
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
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.GroupedPowers = New List(Of Powers)
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
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.GroupedPowers = New List(Of Powers)
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
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.GroupedPowers = New List(Of Powers)
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
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.GroupedPowers = New List(Of Powers)
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
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.GroupedPowers = New List(Of Powers)
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
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.GroupedPowers = New List(Of Powers)
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
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.GroupedPowers = New List(Of Powers)
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
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.GroupedPowers = New List(Of Powers)
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
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.GroupedPowers = New List(Of Powers)
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
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.GroupedPowers = New List(Of Powers)
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
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.GroupedPowers = New List(Of Powers)
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
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.GroupedPowers = New List(Of Powers)
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
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.GroupedPowers = New List(Of Powers)
            TempLocation.Weight = 6
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
            TempLocation.PowerOptions = New List(Of Powers)
            TempLocation.GroupedPowers = New List(Of Powers)
            TempLocation.Weight = 5 'Makes this always placed first
            Locations.Add(TempLocation)
            Return Locations
        End Function
    End Class
    Public Class PracticeItems
        Public Shared Function ResetItemPool()
            Dim Items As List(Of ItemDrop)
            Items = New List(Of ItemDrop)
            Dim TempItem As ItemDrop
            '
            '______________WEAPONS
            '
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.DataDisruptor
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({
                                          Powers.GunModel,
                                          Powers.Damage})
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
            TempItem.GivenPowers.AddRange({
                                          Powers.Drill,
                                          Powers.Damage})
            TempItem.GID = 33
            TempItem.Weight = 19
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.AddressDisruptor1
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({
                                          Powers.Glitch1})
            TempItem.GID = 37
            TempItem.Weight = 18
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.AddressDisruptor2
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({
                                          Powers.Glitch1,
                                          Powers.Glitch2})
            TempItem.GID = 60
            TempItem.Weight = 17
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.GlitchBomb
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({
                                          Powers.Glitch1,
                                          Powers.Glitch2,
                                          Powers.Glitch3})
            TempItem.GID = 70
            TempItem.Weight = 16
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.HighJump
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({
                                          Powers.HighJump})
            TempItem.GID = 37
            TempItem.Weight = 15
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.Grapple
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({
                                          Powers.Damage,
                                          Powers.Nova,
                                          Powers.Grapple})
            TempItem.GID = 62
            TempItem.Weight = 14
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.GlitchTeleport
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({
                                          Powers.Coat,
                                          Powers.LabCoat,
                                          Powers.GunModel})
            TempItem.GID = 61
            TempItem.Weight = 13
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.BlackCoat
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({
                                          Powers.GunModel,
                                          Powers.Damage,
                                          Powers.Nova,
                                          Powers.Kilver,
                                          Powers.Coat,
                                          Powers.LabCoat,
                                          Powers.TrenchCoat})
            TempItem.GID = 72
            TempItem.Weight = 12
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.RedCoat
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({
                                          Powers.GunModel,
                                          Powers.Damage,
                                          Powers.Glitch1,
                                          Powers.Glitch2,
                                          Powers.Coat,
                                          Powers.LabCoat,
                                          Powers.TrenchCoat,
                                          Powers.RedCoat})
            TempItem.GID = 68
            TempItem.Weight = 11
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.DroneGun
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({
                                          Powers.Damage,
                                          Powers.Nova,
                                          Powers.Drill,
                                          Powers.Drone})
            TempItem.GID = 63
            TempItem.Weight = 10
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.EnhancedLaunch
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({
                                          Powers.EnhancedLaunch})
            TempItem.GID = 64
            TempItem.Weight = 9
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.DroneTeleport
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({
                                          Powers.DroneTeleport})
            TempItem.GID = 71
            TempItem.Weight = 8
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.PasswordTool
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({
                                          Powers.Passwords,
                                          Powers.Coat})
            TempItem.GID = 69
            TempItem.Weight = 7
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.BreachSuppressor
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({
                                          Powers.Key})
            TempItem.GID = 73
            TempItem.Weight = 6
            Items.Add(TempItem)
            '______________
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = "HealthNodeFragment25"
            TempItem.DropType = ItemType.HealthNodeFragment
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GID = 38
            TempItem.Weight = 25
            Items.Add(TempItem)
            Return Items
        End Function

    End Class
#End Region
End Namespace
