<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SpoilerForm
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Placed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemWeight = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocationName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Area = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VanillaItem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VanillaOrder = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocationWeight = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rerolls = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportLocationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportLocationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Placed, Me.ItemType, Me.ItemName, Me.ItemWeight, Me.LocationName, Me.Area, Me.VanillaItem, Me.VanillaOrder, Me.LocationWeight, Me.Rerolls})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 24)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(734, 687)
        Me.DataGridView1.TabIndex = 1
        '
        'Placed
        '
        Me.Placed.HeaderText = "Placed"
        Me.Placed.Name = "Placed"
        Me.Placed.ReadOnly = True
        Me.Placed.Width = 65
        '
        'ItemType
        '
        Me.ItemType.HeaderText = "Item Type"
        Me.ItemType.Name = "ItemType"
        Me.ItemType.ReadOnly = True
        Me.ItemType.Width = 73
        '
        'ItemName
        '
        Me.ItemName.HeaderText = "Item Name"
        Me.ItemName.Name = "ItemName"
        Me.ItemName.ReadOnly = True
        Me.ItemName.Width = 77
        '
        'ItemWeight
        '
        Me.ItemWeight.HeaderText = "Item Weight"
        Me.ItemWeight.Name = "ItemWeight"
        Me.ItemWeight.ReadOnly = True
        Me.ItemWeight.Width = 82
        '
        'LocationName
        '
        Me.LocationName.HeaderText = "Nick Name"
        Me.LocationName.Name = "LocationName"
        Me.LocationName.ReadOnly = True
        Me.LocationName.Width = 78
        '
        'Area
        '
        Me.Area.HeaderText = "Area"
        Me.Area.Name = "Area"
        Me.Area.ReadOnly = True
        Me.Area.Width = 54
        '
        'VanillaItem
        '
        Me.VanillaItem.HeaderText = "Vanilla Item"
        Me.VanillaItem.Name = "VanillaItem"
        Me.VanillaItem.ReadOnly = True
        Me.VanillaItem.Width = 79
        '
        'VanillaOrder
        '
        Me.VanillaOrder.HeaderText = "Vanilla Order"
        Me.VanillaOrder.Name = "VanillaOrder"
        Me.VanillaOrder.ReadOnly = True
        Me.VanillaOrder.Width = 85
        '
        'LocationWeight
        '
        Me.LocationWeight.HeaderText = "Location Weight"
        Me.LocationWeight.Name = "LocationWeight"
        Me.LocationWeight.ReadOnly = True
        Me.LocationWeight.Width = 101
        '
        'Rerolls
        '
        Me.Rerolls.HeaderText = "Rerolls"
        Me.Rerolls.Name = "Rerolls"
        Me.Rerolls.ReadOnly = True
        Me.Rerolls.Width = 64
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportLocationsToolStripMenuItem, Me.ImportLocationsToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(50, 20)
        Me.ToolStripMenuItem1.Text = "Seed: "
        '
        'ExportLocationsToolStripMenuItem
        '
        Me.ExportLocationsToolStripMenuItem.Name = "ExportLocationsToolStripMenuItem"
        Me.ExportLocationsToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.ExportLocationsToolStripMenuItem.Text = "Export Locations"
        '
        'ImportLocationsToolStripMenuItem
        '
        Me.ImportLocationsToolStripMenuItem.Name = "ImportLocationsToolStripMenuItem"
        Me.ImportLocationsToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.ImportLocationsToolStripMenuItem.Text = "Import Locations"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(734, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "seed.xml"
        Me.OpenFileDialog1.Filter = "xml file|*.xml|All files|*.*"
        '
        'SpoilerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 711)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "SpoilerForm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Spoiler Menu"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ExportLocationsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents ImportLocationsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Placed As DataGridViewTextBoxColumn
    Friend WithEvents ItemType As DataGridViewTextBoxColumn
    Friend WithEvents ItemName As DataGridViewTextBoxColumn
    Friend WithEvents ItemWeight As DataGridViewTextBoxColumn
    Friend WithEvents LocationName As DataGridViewTextBoxColumn
    Friend WithEvents Area As DataGridViewTextBoxColumn
    Friend WithEvents VanillaItem As DataGridViewTextBoxColumn
    Friend WithEvents VanillaOrder As DataGridViewTextBoxColumn
    Friend WithEvents LocationWeight As DataGridViewTextBoxColumn
    Friend WithEvents Rerolls As DataGridViewTextBoxColumn
End Class
