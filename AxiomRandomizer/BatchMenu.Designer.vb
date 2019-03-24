<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BatchMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DataGridBatchView = New System.Windows.Forms.DataGridView()
        Me.LocationName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VanillaItem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VanillaPlacementNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemRegion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RequiredPowers = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlacementCount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Drill = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Glitch1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Glitch2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Glitch3Bomb = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabCoat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TrenchCoat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RedCoat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasswordTool = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HighJump = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DroneGun = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EnhancedLaunch = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DroneTeleport = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Grapple = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BreachSuppressor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HPNode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HPNodeFrag = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PwrNode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PwrNodeFrag = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SizeNode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RangeNode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Notes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Damage = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nova = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kilver = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LongBeam = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FatBeam = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridBatchView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridBatchView
        '
        Me.DataGridBatchView.AllowUserToAddRows = False
        Me.DataGridBatchView.AllowUserToDeleteRows = False
        Me.DataGridBatchView.AllowUserToResizeRows = False
        Me.DataGridBatchView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridBatchView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LocationName, Me.VanillaItem, Me.VanillaPlacementNumber, Me.ItemRegion, Me.RequiredPowers, Me.PlacementCount, Me.Drill, Me.Glitch1, Me.Glitch2, Me.Glitch3Bomb, Me.LabCoat, Me.TrenchCoat, Me.RedCoat, Me.PasswordTool, Me.HighJump, Me.DroneGun, Me.EnhancedLaunch, Me.DroneTeleport, Me.Grapple, Me.BreachSuppressor, Me.HPNode, Me.HPNodeFrag, Me.PwrNode, Me.PwrNodeFrag, Me.SizeNode, Me.RangeNode, Me.Notes, Me.Damage, Me.Nova, Me.Kilver, Me.LongBeam, Me.FatBeam})
        Me.DataGridBatchView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridBatchView.Location = New System.Drawing.Point(0, 0)
        Me.DataGridBatchView.Name = "DataGridBatchView"
        Me.DataGridBatchView.Size = New System.Drawing.Size(984, 711)
        Me.DataGridBatchView.TabIndex = 0
        '
        'LocationName
        '
        Me.LocationName.HeaderText = "Name"
        Me.LocationName.Name = "LocationName"
        Me.LocationName.ReadOnly = True
        Me.LocationName.Width = 60
        '
        'VanillaItem
        '
        Me.VanillaItem.HeaderText = "Vanilla Item"
        Me.VanillaItem.Name = "VanillaItem"
        Me.VanillaItem.ReadOnly = True
        Me.VanillaItem.Width = 86
        '
        'VanillaPlacementNumber
        '
        Me.VanillaPlacementNumber.HeaderText = "Place Num."
        Me.VanillaPlacementNumber.Name = "VanillaPlacementNumber"
        Me.VanillaPlacementNumber.ReadOnly = True
        Me.VanillaPlacementNumber.Width = 87
        '
        'ItemRegion
        '
        Me.ItemRegion.HeaderText = "Region"
        Me.ItemRegion.Name = "ItemRegion"
        Me.ItemRegion.ReadOnly = True
        Me.ItemRegion.Width = 66
        '
        'RequiredPowers
        '
        Me.RequiredPowers.HeaderText = "Base Powers"
        Me.RequiredPowers.Name = "RequiredPowers"
        Me.RequiredPowers.ReadOnly = True
        Me.RequiredPowers.Width = 94
        '
        'PlacementCount
        '
        Me.PlacementCount.HeaderText = "Place Count"
        Me.PlacementCount.Name = "PlacementCount"
        Me.PlacementCount.ReadOnly = True
        Me.PlacementCount.Width = 90
        '
        'Drill
        '
        Me.Drill.HeaderText = "Drill"
        Me.Drill.Name = "Drill"
        Me.Drill.ReadOnly = True
        Me.Drill.Width = 49
        '
        'Glitch1
        '
        Me.Glitch1.HeaderText = "Glitch 1"
        Me.Glitch1.Name = "Glitch1"
        Me.Glitch1.ReadOnly = True
        Me.Glitch1.Width = 68
        '
        'Glitch2
        '
        Me.Glitch2.HeaderText = "Glitch 2"
        Me.Glitch2.Name = "Glitch2"
        Me.Glitch2.ReadOnly = True
        Me.Glitch2.Width = 68
        '
        'Glitch3Bomb
        '
        Me.Glitch3Bomb.HeaderText = "Glitch 3 Bomb"
        Me.Glitch3Bomb.Name = "Glitch3Bomb"
        Me.Glitch3Bomb.ReadOnly = True
        Me.Glitch3Bomb.Width = 98
        '
        'LabCoat
        '
        Me.LabCoat.HeaderText = "Lab Coat"
        Me.LabCoat.Name = "LabCoat"
        Me.LabCoat.ReadOnly = True
        Me.LabCoat.Width = 75
        '
        'TrenchCoat
        '
        Me.TrenchCoat.HeaderText = "Trench Coat"
        Me.TrenchCoat.Name = "TrenchCoat"
        Me.TrenchCoat.ReadOnly = True
        Me.TrenchCoat.Width = 91
        '
        'RedCoat
        '
        Me.RedCoat.HeaderText = "Red Coat"
        Me.RedCoat.Name = "RedCoat"
        Me.RedCoat.ReadOnly = True
        Me.RedCoat.Width = 77
        '
        'PasswordTool
        '
        Me.PasswordTool.HeaderText = "Password"
        Me.PasswordTool.Name = "PasswordTool"
        Me.PasswordTool.ReadOnly = True
        Me.PasswordTool.Width = 78
        '
        'HighJump
        '
        Me.HighJump.HeaderText = "High Jump"
        Me.HighJump.Name = "HighJump"
        Me.HighJump.ReadOnly = True
        Me.HighJump.Width = 82
        '
        'DroneGun
        '
        Me.DroneGun.HeaderText = "Drone"
        Me.DroneGun.Name = "DroneGun"
        Me.DroneGun.ReadOnly = True
        Me.DroneGun.Width = 61
        '
        'EnhancedLaunch
        '
        Me.EnhancedLaunch.HeaderText = "Enhanced Drone"
        Me.EnhancedLaunch.Name = "EnhancedLaunch"
        Me.EnhancedLaunch.ReadOnly = True
        Me.EnhancedLaunch.Width = 104
        '
        'DroneTeleport
        '
        Me.DroneTeleport.HeaderText = "Drone Teleport"
        Me.DroneTeleport.Name = "DroneTeleport"
        Me.DroneTeleport.ReadOnly = True
        Me.DroneTeleport.Width = 95
        '
        'Grapple
        '
        Me.Grapple.HeaderText = "Grapple"
        Me.Grapple.Name = "Grapple"
        Me.Grapple.ReadOnly = True
        Me.Grapple.Width = 69
        '
        'BreachSuppressor
        '
        Me.BreachSuppressor.HeaderText = "Key"
        Me.BreachSuppressor.Name = "BreachSuppressor"
        Me.BreachSuppressor.ReadOnly = True
        Me.BreachSuppressor.Width = 50
        '
        'HPNode
        '
        Me.HPNode.HeaderText = "HP Node"
        Me.HPNode.Name = "HPNode"
        Me.HPNode.ReadOnly = True
        '
        'HPNodeFrag
        '
        Me.HPNodeFrag.HeaderText = "HP Node Frag"
        Me.HPNodeFrag.Name = "HPNodeFrag"
        Me.HPNodeFrag.ReadOnly = True
        '
        'PwrNode
        '
        Me.PwrNode.HeaderText = "Pwr Node"
        Me.PwrNode.Name = "PwrNode"
        Me.PwrNode.ReadOnly = True
        '
        'PwrNodeFrag
        '
        Me.PwrNodeFrag.HeaderText = "Pwr Node Frag"
        Me.PwrNodeFrag.Name = "PwrNodeFrag"
        Me.PwrNodeFrag.ReadOnly = True
        '
        'SizeNode
        '
        Me.SizeNode.HeaderText = "Size Node"
        Me.SizeNode.Name = "SizeNode"
        Me.SizeNode.ReadOnly = True
        '
        'RangeNode
        '
        Me.RangeNode.HeaderText = "Range Node"
        Me.RangeNode.Name = "RangeNode"
        Me.RangeNode.ReadOnly = True
        '
        'Notes
        '
        Me.Notes.HeaderText = "Notes"
        Me.Notes.Name = "Notes"
        Me.Notes.ReadOnly = True
        '
        'Damage
        '
        Me.Damage.HeaderText = "Damage"
        Me.Damage.Name = "Damage"
        Me.Damage.ReadOnly = True
        '
        'Nova
        '
        Me.Nova.HeaderText = "Nova Like"
        Me.Nova.Name = "Nova"
        Me.Nova.ReadOnly = True
        '
        'Kilver
        '
        Me.Kilver.HeaderText = "Kilver Like"
        Me.Kilver.Name = "Kilver"
        Me.Kilver.ReadOnly = True
        '
        'LongBeam
        '
        Me.LongBeam.HeaderText = "Long Beam"
        Me.LongBeam.Name = "LongBeam"
        Me.LongBeam.ReadOnly = True
        '
        'FatBeam
        '
        Me.FatBeam.HeaderText = "Fat Beam"
        Me.FatBeam.Name = "FatBeam"
        Me.FatBeam.ReadOnly = True
        '
        'BatchMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 711)
        Me.Controls.Add(Me.DataGridBatchView)
        Me.Name = "BatchMenu"
        Me.ShowIcon = False
        Me.Text = "BatchMenu"
        CType(Me.DataGridBatchView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridBatchView As DataGridView
    Friend WithEvents LocationName As DataGridViewTextBoxColumn
    Friend WithEvents VanillaItem As DataGridViewTextBoxColumn
    Friend WithEvents VanillaPlacementNumber As DataGridViewTextBoxColumn
    Friend WithEvents ItemRegion As DataGridViewTextBoxColumn
    Friend WithEvents RequiredPowers As DataGridViewTextBoxColumn
    Friend WithEvents PlacementCount As DataGridViewTextBoxColumn
    Friend WithEvents Drill As DataGridViewTextBoxColumn
    Friend WithEvents Glitch1 As DataGridViewTextBoxColumn
    Friend WithEvents Glitch2 As DataGridViewTextBoxColumn
    Friend WithEvents Glitch3Bomb As DataGridViewTextBoxColumn
    Friend WithEvents LabCoat As DataGridViewTextBoxColumn
    Friend WithEvents TrenchCoat As DataGridViewTextBoxColumn
    Friend WithEvents RedCoat As DataGridViewTextBoxColumn
    Friend WithEvents PasswordTool As DataGridViewTextBoxColumn
    Friend WithEvents HighJump As DataGridViewTextBoxColumn
    Friend WithEvents DroneGun As DataGridViewTextBoxColumn
    Friend WithEvents EnhancedLaunch As DataGridViewTextBoxColumn
    Friend WithEvents DroneTeleport As DataGridViewTextBoxColumn
    Friend WithEvents Grapple As DataGridViewTextBoxColumn
    Friend WithEvents BreachSuppressor As DataGridViewTextBoxColumn
    Friend WithEvents HPNode As DataGridViewTextBoxColumn
    Friend WithEvents HPNodeFrag As DataGridViewTextBoxColumn
    Friend WithEvents PwrNode As DataGridViewTextBoxColumn
    Friend WithEvents PwrNodeFrag As DataGridViewTextBoxColumn
    Friend WithEvents SizeNode As DataGridViewTextBoxColumn
    Friend WithEvents RangeNode As DataGridViewTextBoxColumn
    Friend WithEvents Notes As DataGridViewTextBoxColumn
    Friend WithEvents Damage As DataGridViewTextBoxColumn
    Friend WithEvents Nova As DataGridViewTextBoxColumn
    Friend WithEvents Kilver As DataGridViewTextBoxColumn
    Friend WithEvents LongBeam As DataGridViewTextBoxColumn
    Friend WithEvents FatBeam As DataGridViewTextBoxColumn
End Class
