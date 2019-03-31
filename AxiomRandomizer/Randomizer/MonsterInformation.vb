Namespace GameInformation
#Region "Classes"
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
    Public Class MonsterSpawn
        Public Vanilla As CreatureType
        Public Region As Area
        Public Spawns As CreatureType
    End Class
#End Region
    Public Class MonsterInformation
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
    End Class
End Namespace
