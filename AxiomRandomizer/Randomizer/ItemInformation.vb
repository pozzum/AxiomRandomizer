Namespace GameInformation
#Region "Classes"
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
    Public Class ItemDrop
        Public Name As String
        Public NickName As String
        Public DropType As ItemType
        Public GivenPowers As List(Of Powers)
        Public GID As Integer
        Public Weight As Double
        Public Placed As Boolean = False
        Public JumpAdded As Integer = 0
    End Class
#End Region
    Public Class VanillaItems
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
            Items.Add(TempItem)
            '______________
            TempItem = New ItemDrop()
            TempItem.Name = ""
            TempItem.DropType = ItemType.DroneGun
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.GivenPowers.AddRange({Powers.Drone, Powers.Drill})
            TempItem.Weight = 3 'weight 3 for coats & drones to maximize variance
            TempItem.GID = 63
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
            TempItem = New ItemDrop()
            TempItem.Name = "HeatSeeker"
            TempItem.DropType = ItemType.HeatSeeker
            TempItem.GivenPowers = New List(Of Powers)
            TempItem.Weight = 10 'weight 10 for weapons
            TempItem.GivenPowers.AddRange({Powers.Damage})
            TempItem.GID = 57 'Guess IDK if it'll work
            Items.Add(TempItem)
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
            If (My.Settings.SteamVersion = 0 Or My.Settings.SteamVersion = 1) Then
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
                'TempItem = New ItemDrop()
                'TempItem.Name = "Note26"
                'TempItem.DropType = ItemType.Lore
                'TempItem.GivenPowers = New List(Of Powers)
                'TempItem.GID = 75
                'TempItem.Weight = -1
                'Items.Add(TempItem)
                ''______________ Added I think
                'TempItem = New ItemDrop()
                'TempItem.Name = "Note27"
                'TempItem.DropType = ItemType.Lore
                'TempItem.GivenPowers = New List(Of Powers)
                'TempItem.GID = 75
                'Items.Add(TempItem)
                ''______________
                'TempItem = New ItemDrop()
                'TempItem.Name = "Note28"
                'TempItem.DropType = ItemType.Lore
                'TempItem.GivenPowers = New List(Of Powers)
                'TempItem.GID = 75
                'Items.Add(TempItem)
            End If
#End Region
#Region "Source Items"
            If (My.Settings.SteamVersion = 2) Then
                '______________
                TempItem = New ItemDrop()
                TempItem.Name = "HealthNode10"
                TempItem.DropType = ItemType.HealthNode
                TempItem.GivenPowers = New List(Of Powers)
                TempItem.GID = 34
                TempItem.Weight = -1
                Items.Add(TempItem)
                '______________
                TempItem = New ItemDrop()
                TempItem.Name = "HealthNodeFragment21"
                TempItem.DropType = ItemType.HealthNodeFragment
                TempItem.GivenPowers = New List(Of Powers)
                TempItem.GID = 38
                TempItem.Weight = -1
                Items.Add(TempItem)
                '______________
                TempItem = New ItemDrop()
                TempItem.Name = "HealthNodeFragment22"
                TempItem.DropType = ItemType.HealthNodeFragment
                TempItem.GivenPowers = New List(Of Powers)
                TempItem.GID = 38
                TempItem.Weight = -1
                Items.Add(TempItem)
                '______________
                TempItem = New ItemDrop()
                TempItem.Name = "HealthNodeFragment23"
                TempItem.DropType = ItemType.HealthNodeFragment
                TempItem.GivenPowers = New List(Of Powers)
                TempItem.GID = 38
                TempItem.Weight = -1
                Items.Add(TempItem)
                '______________
                TempItem = New ItemDrop()
                TempItem.Name = "HealthNodeFragment24"
                TempItem.DropType = ItemType.HealthNodeFragment
                TempItem.GivenPowers = New List(Of Powers)
                TempItem.GID = 38
                TempItem.Weight = -1
                Items.Add(TempItem)
                '______________
                TempItem = New ItemDrop()
                TempItem.Name = "HealthNodeFragment25"
                TempItem.DropType = ItemType.HealthNodeFragment
                TempItem.GivenPowers = New List(Of Powers)
                TempItem.GID = 38
                TempItem.Weight = -1
                Items.Add(TempItem)
                '______________
                TempItem = New ItemDrop()
                TempItem.Name = "PowerNode7"
                TempItem.DropType = ItemType.PowerNode
                TempItem.GivenPowers = New List(Of Powers)
                TempItem.GID = 32
                TempItem.Weight = -1
                Items.Add(TempItem)
                '______________
                TempItem = New ItemDrop()
                TempItem.Name = "PowerNodeFragment19"
                TempItem.DropType = ItemType.PowerNodeFragment
                TempItem.GivenPowers = New List(Of Powers)
                TempItem.GID = 74
                TempItem.Weight = -1
                Items.Add(TempItem)
                '______________
                TempItem = New ItemDrop()
                TempItem.Name = "PowerNodeFragment20"
                TempItem.DropType = ItemType.PowerNodeFragment
                TempItem.GivenPowers = New List(Of Powers)
                TempItem.GID = 74
                TempItem.Weight = -1
                Items.Add(TempItem)
                '______________
                TempItem = New ItemDrop()
                TempItem.Name = "PowerNodeFragment21"
                TempItem.DropType = ItemType.PowerNodeFragment
                TempItem.GivenPowers = New List(Of Powers)
                TempItem.GID = 74
                TempItem.Weight = -1
                Items.Add(TempItem)
                '______________
                TempItem = New ItemDrop()
                TempItem.Name = "PowerNodeFragment22"
                TempItem.DropType = ItemType.PowerNodeFragment
                TempItem.GivenPowers = New List(Of Powers)
                TempItem.GID = 74
                TempItem.Weight = -1
                Items.Add(TempItem)
                '______________
                TempItem = New ItemDrop()
                TempItem.Name = "PowerNodeFragment23"
                TempItem.DropType = ItemType.PowerNodeFragment
                TempItem.GivenPowers = New List(Of Powers)
                TempItem.GID = 74
                TempItem.Weight = -1
                Items.Add(TempItem)
                '______________
                TempItem = New ItemDrop()
                TempItem.Name = "PowerNodeFragment24"
                TempItem.DropType = ItemType.PowerNodeFragment
                TempItem.GivenPowers = New List(Of Powers)
                TempItem.GID = 74
                TempItem.Weight = -1
                Items.Add(TempItem)
                '______________
                TempItem = New ItemDrop()
                TempItem.Name = "PowerNodeFragment25"
                TempItem.DropType = ItemType.PowerNodeFragment
                TempItem.GivenPowers = New List(Of Powers)
                TempItem.GID = 74
                TempItem.Weight = -1
                Items.Add(TempItem)
                '______________
                TempItem = New ItemDrop()
                TempItem.Name = "PowerNodeFragment26"
                TempItem.DropType = ItemType.PowerNodeFragment
                TempItem.GivenPowers = New List(Of Powers)
                TempItem.GID = 74
                TempItem.Weight = -1
                Items.Add(TempItem)
                '______________
                TempItem = New ItemDrop()
                TempItem.Name = "PowerNodeFragment27"
                TempItem.DropType = ItemType.PowerNodeFragment
                TempItem.GivenPowers = New List(Of Powers)
                TempItem.GID = 74
                TempItem.Weight = -1
                Items.Add(TempItem)
                '______________
                TempItem = New ItemDrop()
                TempItem.Name = "PowerNodeFragment28"
                TempItem.DropType = ItemType.PowerNodeFragment
                TempItem.GivenPowers = New List(Of Powers)
                TempItem.GID = 74
                TempItem.Weight = -1
                Items.Add(TempItem)
                '______________
                TempItem = New ItemDrop()
                TempItem.Name = "PowerNodeFragment29"
                TempItem.DropType = ItemType.PowerNodeFragment
                TempItem.GivenPowers = New List(Of Powers)
                TempItem.GID = 74
                TempItem.Weight = -1
                Items.Add(TempItem)
                '______________
                TempItem = New ItemDrop()
                TempItem.Name = "PowerNodeFragment30"
                TempItem.DropType = ItemType.PowerNodeFragment
                TempItem.GivenPowers = New List(Of Powers)
                TempItem.GID = 74
                TempItem.Weight = -1
                Items.Add(TempItem)
            End If
#End Region
            Return Items
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
    Public Class VariableItems
        Public Shared Function ResetItemPool(PoolDifficulty As Randomizer.DifficultySetting)
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
#Region "Variable Nodes"

#End Region
            Return Items
        End Function
        Public Shared Function GetVarianceNum(Min As Integer, Variance As Integer)
            Dim ReturnAsDouble As Double = 0
            For i As Integer = 0 To Variance - 1
                ReturnAsDouble += Randomizer.Generator.NextDouble 'rand
            Next
            Dim ReturnAsInteger As Integer = Math.Floor(ReturnAsDouble) + Min
            Return ReturnAsInteger
        End Function
        Public Shared Function GenerateHealthNodes(PoolDifficulty As Randomizer.DifficultySetting, Optional MinNodes As Integer = -1, Optional VarianceNodes As Integer = -1)
            If MinNodes = -1 AndAlso VarianceNodes = -1 Then
                Select Case PoolDifficulty
                    Case Randomizer.DifficultySetting.Easy
                        MinNodes = 1
                        VarianceNodes = 9
                    Case Randomizer.DifficultySetting.Normal
                        MinNodes = 1
                        VarianceNodes = 10
                        'Case Randomizer.DifficultySetting.Hard
                        ' MinNodes = 0
                        ' VarianceNodes = 5
                End Select
            End If
            Return GetVarianceNum(MinNodes, VarianceNodes)
        End Function
        Public Shared Function GenerateHealthFragments(PoolDifficulty As Randomizer.DifficultySetting, Optional MinNodes As Integer = -1, Optional VarianceNodes As Integer = -1)
            If MinNodes = -1 AndAlso VarianceNodes = -1 Then
                Select Case PoolDifficulty
                    'Note +1 from Slug Fragment
                    Case Randomizer.DifficultySetting.Easy
                        MinNodes = 1
                        VarianceNodes = 19
                    Case Randomizer.DifficultySetting.Normal
                        MinNodes = 4
                        VarianceNodes = 20
                        'Case Randomizer.DifficultySetting.Hard
                        ' MinNodes = 4
                        ' VarianceNodes = 16
                End Select
            End If
            Return GetVarianceNum(MinNodes, VarianceNodes)
        End Function
        Public Shared Function GeneratePowerNodes(PoolDifficulty As Randomizer.DifficultySetting, Optional MinNodes As Integer = -1, Optional VarianceNodes As Integer = -1)
            If MinNodes = -1 AndAlso VarianceNodes = -1 Then
                Select Case PoolDifficulty
                    Case Randomizer.DifficultySetting.Easy
                        MinNodes = 1
                        VarianceNodes = 6
                    Case Randomizer.DifficultySetting.Normal
                        MinNodes = 2
                        VarianceNodes = 9
                        'Case Randomizer.DifficultySetting.Hard
                        ' MinNodes = 0
                        ' VarianceNodes = 9
                End Select
            End If
            Return GetVarianceNum(MinNodes, VarianceNodes)
        End Function
        Public Shared Function GeneratePowerFragments(PoolDifficulty As Randomizer.DifficultySetting, Optional MinNodes As Integer = -1, Optional VarianceNodes As Integer = -1)
            If MinNodes = -1 AndAlso VarianceNodes = -1 Then
                Select Case PoolDifficulty
                    Case Randomizer.DifficultySetting.Easy
                        MinNodes = 1
                        VarianceNodes = 20
                    Case Randomizer.DifficultySetting.Normal
                        MinNodes = 6
                        VarianceNodes = 18
                        'Case Randomizer.DifficultySetting.Hard
                        ' MinNodes = 0
                        ' VarianceNodes = 19
                End Select
            End If
            Return GetVarianceNum(MinNodes, VarianceNodes)
        End Function
        Public Shared Function GenerateSizeNodes(PoolDifficulty As Randomizer.DifficultySetting, Optional MinNodes As Integer = -1, Optional VarianceNodes As Integer = -1)
            If MinNodes = -1 AndAlso VarianceNodes = -1 Then
                Select Case PoolDifficulty
                    Case Randomizer.DifficultySetting.Easy
                        MinNodes = 2
                        VarianceNodes = 5
                    Case Randomizer.DifficultySetting.Normal
                        MinNodes = 2
                        VarianceNodes = 9
                        'Case Randomizer.DifficultySetting.Hard
                        ' MinNodes = 0
                        ' VarianceNodes = 6
                End Select
            End If
            Return GetVarianceNum(MinNodes, VarianceNodes)
        End Function
        Public Shared Function GenerateRangeNodes(PoolDifficulty As Randomizer.DifficultySetting, Optional MinNodes As Integer = -1, Optional VarianceNodes As Integer = -1)
            If MinNodes = -1 AndAlso VarianceNodes = -1 Then
                Select Case PoolDifficulty
                    Case Randomizer.DifficultySetting.Easy
                        MinNodes = 2
                        VarianceNodes = 5
                    Case Randomizer.DifficultySetting.Normal
                        MinNodes = 2
                        VarianceNodes = 9
                        'Case Randomizer.DifficultySetting.Hard
                        ' MinNodes = 0
                        ' VarianceNodes = 6
                End Select
            End If
            Return GetVarianceNum(MinNodes, VarianceNodes)
        End Function
        Public Shared Function OnGenerateRemaningNoteCount(ItemCount As Integer)
            Return 124 - ItemCount
        End Function
    End Class
End Namespace