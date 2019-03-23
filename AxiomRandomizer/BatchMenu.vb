Public Class BatchMenu
    Private Sub BatchMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & " Ver: " & My.Application.Info.Version.ToString
        LoadBatch()
    End Sub
    Sub LoadBatch()
        DataGridBatchView.Rows.Clear()
        For i As Integer = 0 To RandomMenu.BatchList.Count - 1
            DataGridBatchView.Rows.Add(
                RandomMenu.BatchList(i).Name,
                RandomMenu.BatchList(i).Vanilla.ToString,
                RandomMenu.BatchList(i).VanillaPlacement,
                RandomMenu.BatchList(i).Region.ToString,
                String.Join(",", Randomizer.LocationInformation(i).RequiredPowers.ToArray()),
                RandomMenu.BatchList(i).PlacedItems.Count.ToString,
               ItemCount(RandomMenu.BatchList(i).PlacedItems, GameInformation.ItemType.Drill).ToString,
               ItemCount(RandomMenu.BatchList(i).PlacedItems, GameInformation.ItemType.AddressDisruptor1).ToString,
               ItemCount(RandomMenu.BatchList(i).PlacedItems, GameInformation.ItemType.AddressDisruptor2).ToString,
               ItemCount(RandomMenu.BatchList(i).PlacedItems, GameInformation.ItemType.GlitchBomb).ToString,
               ItemCount(RandomMenu.BatchList(i).PlacedItems, GameInformation.ItemType.GlitchTeleport).ToString,
               ItemCount(RandomMenu.BatchList(i).PlacedItems, GameInformation.ItemType.BlackCoat).ToString,
               ItemCount(RandomMenu.BatchList(i).PlacedItems, GameInformation.ItemType.RedCoat).ToString,
               ItemCount(RandomMenu.BatchList(i).PlacedItems, GameInformation.ItemType.PasswordTool).ToString,
               ItemCount(RandomMenu.BatchList(i).PlacedItems, GameInformation.ItemType.HighJump).ToString,
               ItemCount(RandomMenu.BatchList(i).PlacedItems, GameInformation.ItemType.DroneGun).ToString,
               ItemCount(RandomMenu.BatchList(i).PlacedItems, GameInformation.ItemType.EnhancedLaunch).ToString,
               ItemCount(RandomMenu.BatchList(i).PlacedItems, GameInformation.ItemType.DroneTeleport).ToString,
               ItemCount(RandomMenu.BatchList(i).PlacedItems, GameInformation.ItemType.Grapple).ToString,
               ItemCount(RandomMenu.BatchList(i).PlacedItems, GameInformation.ItemType.BreachSuppressor).ToString,
               ItemCount(RandomMenu.BatchList(i).PlacedItems, GameInformation.ItemType.HealthNode).ToString,
               ItemCount(RandomMenu.BatchList(i).PlacedItems, GameInformation.ItemType.HealthNodeFragment).ToString,
               ItemCount(RandomMenu.BatchList(i).PlacedItems, GameInformation.ItemType.PowerNode).ToString,
               ItemCount(RandomMenu.BatchList(i).PlacedItems, GameInformation.ItemType.PowerNodeFragment).ToString,
               ItemCount(RandomMenu.BatchList(i).PlacedItems, GameInformation.ItemType.SizeNode).ToString,
               ItemCount(RandomMenu.BatchList(i).PlacedItems, GameInformation.ItemType.RangeNode).ToString,
               ItemCount(RandomMenu.BatchList(i).PlacedItems, GameInformation.ItemType.Lore).ToString,
               ItemCount(RandomMenu.BatchList(i).PlacedItems, {GameInformation.ItemType.DataDisruptor,
                                                                GameInformation.ItemType.MultiDisruptor,
                                                                GameInformation.ItemType.IonBeam,
                                                                GameInformation.ItemType.TriCone,
                                                                GameInformation.ItemType.InertialPulse,
                                                                GameInformation.ItemType.FireWall,
                                                                GameInformation.ItemType.Shards,
                                                                GameInformation.ItemType.Voranj,
                                                                GameInformation.ItemType.DataGrenade,
                                                                GameInformation.ItemType.LightningGun,
                                                                GameInformation.ItemType.Swim}).ToString,
               ItemCount(RandomMenu.BatchList(i).PlacedItems, {GameInformation.ItemType.Nova,
                                                                GameInformation.ItemType.VerticalSpread,
                                                                GameInformation.ItemType.Reflect,
                                                                GameInformation.ItemType.WallTrace,
                                                                GameInformation.ItemType.TetheredCharge}).ToString,
               ItemCount(RandomMenu.BatchList(i).PlacedItems, {GameInformation.ItemType.Kilver,
                                                                GameInformation.ItemType.Scythe,
                                                                GameInformation.ItemType.DistortionField}).ToString,
               ItemCount(RandomMenu.BatchList(i).PlacedItems, {GameInformation.ItemType.FlameThrower,
                                                                GameInformation.ItemType.WebSlicer}).ToString,
               ItemCount(RandomMenu.BatchList(i).PlacedItems, GameInformation.ItemType.FatBeam).ToString
            )
            'MessageBox.Show(String.Join(",", Randomizer.LocationInformation(i).PowersAttained.ToArray()))
        Next
    End Sub
    Function ItemCount(FullList As List(Of GameInformation.ItemType), TestedItem As GameInformation.ItemType)
        Dim Count As Integer = 0
        For i As Integer = 0 To FullList.Count - 1
            If FullList(i) = TestedItem Then
                Count += 1
            End If
        Next
        Return Count
    End Function
    Function ItemCount(FullList As List(Of GameInformation.ItemType), TestedList As GameInformation.ItemType())
        Dim Count As Integer = 0
        For i As Integer = 0 To FullList.Count - 1
            If TestedList.Contains(FullList(i)) Then
                Count += 1
            End If
        Next
        Return Count
    End Function
End Class