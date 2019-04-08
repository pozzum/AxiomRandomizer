<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RandomMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TextBoxSeed = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonRandomSeed = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBoxDifficulties = New System.Windows.Forms.ComboBox()
        Me.CheckBoxIllusion = New System.Windows.Forms.CheckBox()
        Me.CheckBoxWalls = New System.Windows.Forms.CheckBox()
        Me.CheckBoxDropDown = New System.Windows.Forms.CheckBox()
        Me.ButtonBuild = New System.Windows.Forms.Button()
        Me.ButtonSpoiler = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.RadioButtonDefaultMap = New System.Windows.Forms.RadioButton()
        Me.RadioButtonCustomMap = New System.Windows.Forms.RadioButton()
        Me.RadioButtonVanillaMap = New System.Windows.Forms.RadioButton()
        Me.CheckBoxOpenEribu = New System.Windows.Forms.CheckBox()
        Me.CheckBoxOpenAbsu = New System.Windows.Forms.CheckBox()
        Me.CheckBoxOpenElsenova = New System.Windows.Forms.CheckBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenRandomizedGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenBaseGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectExeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThankTheDevsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportAnIssueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBoxDebug = New System.Windows.Forms.TextBox()
        Me.ButtonSpoilerMap = New System.Windows.Forms.Button()
        Me.ButtonGenNumber = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonGenerateBatch = New System.Windows.Forms.Button()
        Me.TrackBarBatchSize = New System.Windows.Forms.TrackBar()
        Me.LabelBatchSize = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.CheckBoxHideItemIcons = New System.Windows.Forms.CheckBox()
        Me.ContextMenuStripDebugMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SaveToFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeeSourceCodeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeeLatestReleaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TrackBarBatchSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStripDebugMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBoxSeed
        '
        Me.TextBoxSeed.Location = New System.Drawing.Point(12, 40)
        Me.TextBoxSeed.MaxLength = 11
        Me.TextBoxSeed.Name = "TextBoxSeed"
        Me.TextBoxSeed.Size = New System.Drawing.Size(228, 20)
        Me.TextBoxSeed.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Seed:"
        '
        'ButtonRandomSeed
        '
        Me.ButtonRandomSeed.Location = New System.Drawing.Point(246, 38)
        Me.ButtonRandomSeed.Name = "ButtonRandomSeed"
        Me.ButtonRandomSeed.Size = New System.Drawing.Size(60, 23)
        Me.ButtonRandomSeed.TabIndex = 2
        Me.ButtonRandomSeed.Text = "Random"
        Me.ButtonRandomSeed.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Difficulty Setting:"
        '
        'ComboBoxDifficulties
        '
        Me.ComboBoxDifficulties.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.ComboBoxDifficulties.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBoxDifficulties.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxDifficulties.FormattingEnabled = True
        Me.ComboBoxDifficulties.Location = New System.Drawing.Point(12, 79)
        Me.ComboBoxDifficulties.Name = "ComboBoxDifficulties"
        Me.ComboBoxDifficulties.Size = New System.Drawing.Size(360, 21)
        Me.ComboBoxDifficulties.TabIndex = 4
        '
        'CheckBoxIllusion
        '
        Me.CheckBoxIllusion.AutoSize = True
        Me.CheckBoxIllusion.Checked = True
        Me.CheckBoxIllusion.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxIllusion.Location = New System.Drawing.Point(192, 189)
        Me.CheckBoxIllusion.Name = "CheckBoxIllusion"
        Me.CheckBoxIllusion.Size = New System.Drawing.Size(153, 17)
        Me.CheckBoxIllusion.TabIndex = 5
        Me.CheckBoxIllusion.Text = "Remove Illusion Sequence"
        Me.ToolTip1.SetToolTip(Me.CheckBoxIllusion, "Removes the the vision fight" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and bioflux visions.  This reduces" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the chances of " &
        "accidental Soft-Lock.")
        Me.CheckBoxIllusion.UseVisualStyleBackColor = True
        '
        'CheckBoxWalls
        '
        Me.CheckBoxWalls.AutoSize = True
        Me.CheckBoxWalls.Checked = True
        Me.CheckBoxWalls.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxWalls.Location = New System.Drawing.Point(12, 189)
        Me.CheckBoxWalls.Name = "CheckBoxWalls"
        Me.CheckBoxWalls.Size = New System.Drawing.Size(174, 17)
        Me.CheckBoxWalls.TabIndex = 6
        Me.CheckBoxWalls.Text = "Change Ukkin-Na 1 Way Walls"
        Me.ToolTip1.SetToolTip(Me.CheckBoxWalls, "Removes the requirement to " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "pick up trenchcoat in Ukkin-Na " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to prevent accident" &
        "al Soft-Lock.")
        Me.CheckBoxWalls.UseVisualStyleBackColor = True
        '
        'CheckBoxDropDown
        '
        Me.CheckBoxDropDown.AutoSize = True
        Me.CheckBoxDropDown.Checked = True
        Me.CheckBoxDropDown.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxDropDown.Location = New System.Drawing.Point(12, 212)
        Me.CheckBoxDropDown.Name = "CheckBoxDropDown"
        Me.CheckBoxDropDown.Size = New System.Drawing.Size(166, 17)
        Me.CheckBoxDropDown.TabIndex = 7
        Me.CheckBoxDropDown.Text = "Change Zi 1 Way Drop Down"
        Me.ToolTip1.SetToolTip(Me.CheckBoxDropDown, "Adds an additional platform in Zi" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "so grapple is not required to exit." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "reduces a" &
        "ccidental Soft-Locks.")
        Me.CheckBoxDropDown.UseVisualStyleBackColor = True
        '
        'ButtonBuild
        '
        Me.ButtonBuild.Location = New System.Drawing.Point(12, 106)
        Me.ButtonBuild.Name = "ButtonBuild"
        Me.ButtonBuild.Size = New System.Drawing.Size(115, 23)
        Me.ButtonBuild.TabIndex = 9
        Me.ButtonBuild.Text = "Build exe From Seed"
        Me.ButtonBuild.UseVisualStyleBackColor = True
        '
        'ButtonSpoiler
        '
        Me.ButtonSpoiler.Location = New System.Drawing.Point(133, 106)
        Me.ButtonSpoiler.Name = "ButtonSpoiler"
        Me.ButtonSpoiler.Size = New System.Drawing.Size(115, 23)
        Me.ButtonSpoiler.TabIndex = 12
        Me.ButtonSpoiler.Text = "Generate Spoiler"
        Me.ButtonSpoiler.UseVisualStyleBackColor = True
        '
        'RadioButtonDefaultMap
        '
        Me.RadioButtonDefaultMap.AutoSize = True
        Me.RadioButtonDefaultMap.Checked = True
        Me.RadioButtonDefaultMap.Location = New System.Drawing.Point(6, 19)
        Me.RadioButtonDefaultMap.Name = "RadioButtonDefaultMap"
        Me.RadioButtonDefaultMap.Size = New System.Drawing.Size(59, 17)
        Me.RadioButtonDefaultMap.TabIndex = 0
        Me.RadioButtonDefaultMap.TabStop = True
        Me.RadioButtonDefaultMap.Text = "Default"
        Me.ToolTip1.SetToolTip(Me.RadioButtonDefaultMap, "Enabled map edits based" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "on your selected difficulty.")
        Me.RadioButtonDefaultMap.UseVisualStyleBackColor = True
        '
        'RadioButtonCustomMap
        '
        Me.RadioButtonCustomMap.AutoSize = True
        Me.RadioButtonCustomMap.Location = New System.Drawing.Point(121, 19)
        Me.RadioButtonCustomMap.Name = "RadioButtonCustomMap"
        Me.RadioButtonCustomMap.Size = New System.Drawing.Size(60, 17)
        Me.RadioButtonCustomMap.TabIndex = 1
        Me.RadioButtonCustomMap.Text = "Custom"
        Me.ToolTip1.SetToolTip(Me.RadioButtonCustomMap, "Allows you to select individual " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "map options.")
        Me.RadioButtonCustomMap.UseVisualStyleBackColor = True
        '
        'RadioButtonVanillaMap
        '
        Me.RadioButtonVanillaMap.AutoSize = True
        Me.RadioButtonVanillaMap.Location = New System.Drawing.Point(242, 19)
        Me.RadioButtonVanillaMap.Name = "RadioButtonVanillaMap"
        Me.RadioButtonVanillaMap.Size = New System.Drawing.Size(56, 17)
        Me.RadioButtonVanillaMap.TabIndex = 2
        Me.RadioButtonVanillaMap.Text = "Vanilla"
        Me.ToolTip1.SetToolTip(Me.RadioButtonVanillaMap, "Disables all map edits to have a " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "vanilla map.  MAY CAUSE SOFT LOCKS.")
        Me.RadioButtonVanillaMap.UseVisualStyleBackColor = True
        '
        'CheckBoxOpenEribu
        '
        Me.CheckBoxOpenEribu.AutoSize = True
        Me.CheckBoxOpenEribu.Location = New System.Drawing.Point(12, 235)
        Me.CheckBoxOpenEribu.Name = "CheckBoxOpenEribu"
        Me.CheckBoxOpenEribu.Size = New System.Drawing.Size(79, 17)
        Me.CheckBoxOpenEribu.TabIndex = 17
        Me.CheckBoxOpenEribu.Text = "Open Eribu"
        Me.ToolTip1.SetToolTip(Me.CheckBoxOpenEribu, "Removes the early Drill requirement.")
        Me.CheckBoxOpenEribu.UseVisualStyleBackColor = True
        '
        'CheckBoxOpenAbsu
        '
        Me.CheckBoxOpenAbsu.AutoSize = True
        Me.CheckBoxOpenAbsu.Location = New System.Drawing.Point(205, 235)
        Me.CheckBoxOpenAbsu.Name = "CheckBoxOpenAbsu"
        Me.CheckBoxOpenAbsu.Size = New System.Drawing.Size(79, 17)
        Me.CheckBoxOpenAbsu.TabIndex = 19
        Me.CheckBoxOpenAbsu.Text = "Open Absu"
        Me.ToolTip1.SetToolTip(Me.CheckBoxOpenAbsu, "Removes the early Glitch 1 requirement.")
        Me.CheckBoxOpenAbsu.UseVisualStyleBackColor = True
        '
        'CheckBoxOpenElsenova
        '
        Me.CheckBoxOpenElsenova.AutoSize = True
        Me.CheckBoxOpenElsenova.Location = New System.Drawing.Point(97, 235)
        Me.CheckBoxOpenElsenova.Name = "CheckBoxOpenElsenova"
        Me.CheckBoxOpenElsenova.Size = New System.Drawing.Size(102, 17)
        Me.CheckBoxOpenElsenova.TabIndex = 25
        Me.CheckBoxOpenElsenova.Text = "Open Elsenova "
        Me.ToolTip1.SetToolTip(Me.CheckBoxOpenElsenova, "Removes the early Kilver requirement.")
        Me.CheckBoxOpenElsenova.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ThankTheDevsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(384, 24)
        Me.MenuStrip1.TabIndex = 20
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenRandomizedGameToolStripMenuItem, Me.OpenBaseGameToolStripMenuItem, Me.SelectExeToolStripMenuItem, Me.OptionsToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenRandomizedGameToolStripMenuItem
        '
        Me.OpenRandomizedGameToolStripMenuItem.Name = "OpenRandomizedGameToolStripMenuItem"
        Me.OpenRandomizedGameToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.OpenRandomizedGameToolStripMenuItem.Text = "Open Randomized Game"
        '
        'OpenBaseGameToolStripMenuItem
        '
        Me.OpenBaseGameToolStripMenuItem.Name = "OpenBaseGameToolStripMenuItem"
        Me.OpenBaseGameToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.OpenBaseGameToolStripMenuItem.Text = "Open Base Game"
        '
        'SelectExeToolStripMenuItem
        '
        Me.SelectExeToolStripMenuItem.Name = "SelectExeToolStripMenuItem"
        Me.SelectExeToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.SelectExeToolStripMenuItem.Text = "Select exe..."
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'ThankTheDevsToolStripMenuItem
        '
        Me.ThankTheDevsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReportAnIssueToolStripMenuItem, Me.SeeSourceCodeToolStripMenuItem, Me.SeeLatestReleaseToolStripMenuItem})
        Me.ThankTheDevsToolStripMenuItem.Name = "ThankTheDevsToolStripMenuItem"
        Me.ThankTheDevsToolStripMenuItem.Size = New System.Drawing.Size(103, 20)
        Me.ThankTheDevsToolStripMenuItem.Text = "Thank the Devs!"
        '
        'ReportAnIssueToolStripMenuItem
        '
        Me.ReportAnIssueToolStripMenuItem.Name = "ReportAnIssueToolStripMenuItem"
        Me.ReportAnIssueToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.ReportAnIssueToolStripMenuItem.Text = "Report an Issue?"
        '
        'TextBoxDebug
        '
        Me.TextBoxDebug.Location = New System.Drawing.Point(12, 255)
        Me.TextBoxDebug.Multiline = True
        Me.TextBoxDebug.Name = "TextBoxDebug"
        Me.TextBoxDebug.ReadOnly = True
        Me.TextBoxDebug.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxDebug.Size = New System.Drawing.Size(360, 294)
        Me.TextBoxDebug.TabIndex = 21
        '
        'ButtonSpoilerMap
        '
        Me.ButtonSpoilerMap.Enabled = False
        Me.ButtonSpoilerMap.Location = New System.Drawing.Point(257, 106)
        Me.ButtonSpoilerMap.Name = "ButtonSpoilerMap"
        Me.ButtonSpoilerMap.Size = New System.Drawing.Size(115, 23)
        Me.ButtonSpoilerMap.TabIndex = 22
        Me.ButtonSpoilerMap.Text = "Spoiler Map"
        Me.ButtonSpoilerMap.UseVisualStyleBackColor = True
        '
        'ButtonGenNumber
        '
        Me.ButtonGenNumber.Enabled = False
        Me.ButtonGenNumber.Location = New System.Drawing.Point(312, 38)
        Me.ButtonGenNumber.Name = "ButtonGenNumber"
        Me.ButtonGenNumber.Size = New System.Drawing.Size(60, 23)
        Me.ButtonGenNumber.TabIndex = 23
        Me.ButtonGenNumber.Text = "Generate"
        Me.ButtonGenNumber.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButtonVanillaMap)
        Me.GroupBox1.Controls.Add(Me.RadioButtonCustomMap)
        Me.GroupBox1.Controls.Add(Me.RadioButtonDefaultMap)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 135)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(360, 48)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Map Options"
        '
        'ButtonGenerateBatch
        '
        Me.ButtonGenerateBatch.Location = New System.Drawing.Point(12, 555)
        Me.ButtonGenerateBatch.Name = "ButtonGenerateBatch"
        Me.ButtonGenerateBatch.Size = New System.Drawing.Size(95, 23)
        Me.ButtonGenerateBatch.TabIndex = 26
        Me.ButtonGenerateBatch.Text = "Generate Batch"
        Me.ButtonGenerateBatch.UseVisualStyleBackColor = True
        '
        'TrackBarBatchSize
        '
        Me.TrackBarBatchSize.LargeChange = 100
        Me.TrackBarBatchSize.Location = New System.Drawing.Point(113, 554)
        Me.TrackBarBatchSize.Maximum = 1000
        Me.TrackBarBatchSize.Name = "TrackBarBatchSize"
        Me.TrackBarBatchSize.Size = New System.Drawing.Size(259, 45)
        Me.TrackBarBatchSize.SmallChange = 10
        Me.TrackBarBatchSize.TabIndex = 27
        Me.TrackBarBatchSize.TickFrequency = 100
        Me.TrackBarBatchSize.Value = 100
        '
        'LabelBatchSize
        '
        Me.LabelBatchSize.AutoSize = True
        Me.LabelBatchSize.Location = New System.Drawing.Point(12, 586)
        Me.LabelBatchSize.Name = "LabelBatchSize"
        Me.LabelBatchSize.Size = New System.Drawing.Size(82, 13)
        Me.LabelBatchSize.TabIndex = 28
        Me.LabelBatchSize.Text = "Batch Size: 100"
        '
        'FolderBrowserDialog1
        '
        Me.FolderBrowserDialog1.SelectedPath = "0"
        '
        'CheckBoxHideItemIcons
        '
        Me.CheckBoxHideItemIcons.AutoSize = True
        Me.CheckBoxHideItemIcons.Location = New System.Drawing.Point(192, 212)
        Me.CheckBoxHideItemIcons.Name = "CheckBoxHideItemIcons"
        Me.CheckBoxHideItemIcons.Size = New System.Drawing.Size(100, 17)
        Me.CheckBoxHideItemIcons.TabIndex = 29
        Me.CheckBoxHideItemIcons.Text = "Hide Item Icons"
        Me.CheckBoxHideItemIcons.UseVisualStyleBackColor = True
        '
        'ContextMenuStripDebugMenu
        '
        Me.ContextMenuStripDebugMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToFileToolStripMenuItem})
        Me.ContextMenuStripDebugMenu.Name = "ContextMenuStripDebugMenu"
        Me.ContextMenuStripDebugMenu.Size = New System.Drawing.Size(143, 26)
        '
        'SaveToFileToolStripMenuItem
        '
        Me.SaveToFileToolStripMenuItem.Name = "SaveToFileToolStripMenuItem"
        Me.SaveToFileToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SaveToFileToolStripMenuItem.Text = "Save to File..."
        '
        'SeeSourceCodeToolStripMenuItem
        '
        Me.SeeSourceCodeToolStripMenuItem.Name = "SeeSourceCodeToolStripMenuItem"
        Me.SeeSourceCodeToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SeeSourceCodeToolStripMenuItem.Text = "See Source Code"
        '
        'SeeLatestReleaseToolStripMenuItem
        '
        Me.SeeLatestReleaseToolStripMenuItem.Name = "SeeLatestReleaseToolStripMenuItem"
        Me.SeeLatestReleaseToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SeeLatestReleaseToolStripMenuItem.Text = "See Latest Release"
        '
        'RandomMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 611)
        Me.Controls.Add(Me.CheckBoxHideItemIcons)
        Me.Controls.Add(Me.LabelBatchSize)
        Me.Controls.Add(Me.TrackBarBatchSize)
        Me.Controls.Add(Me.ButtonGenerateBatch)
        Me.Controls.Add(Me.CheckBoxOpenElsenova)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ButtonGenNumber)
        Me.Controls.Add(Me.ButtonSpoilerMap)
        Me.Controls.Add(Me.TextBoxDebug)
        Me.Controls.Add(Me.CheckBoxOpenAbsu)
        Me.Controls.Add(Me.CheckBoxOpenEribu)
        Me.Controls.Add(Me.ButtonSpoiler)
        Me.Controls.Add(Me.ButtonBuild)
        Me.Controls.Add(Me.CheckBoxDropDown)
        Me.Controls.Add(Me.CheckBoxWalls)
        Me.Controls.Add(Me.CheckBoxIllusion)
        Me.Controls.Add(Me.ComboBoxDifficulties)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ButtonRandomSeed)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxSeed)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RandomMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Randomizer Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TrackBarBatchSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStripDebugMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxSeed As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonRandomSeed As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBoxDifficulties As ComboBox
    Friend WithEvents CheckBoxIllusion As CheckBox
    Friend WithEvents CheckBoxWalls As CheckBox
    Friend WithEvents CheckBoxDropDown As CheckBox
    Friend WithEvents ButtonBuild As Button
    Friend WithEvents ButtonSpoiler As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents CheckBoxOpenEribu As CheckBox
    Friend WithEvents CheckBoxOpenAbsu As CheckBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectExeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ThankTheDevsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenRandomizedGameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenBaseGameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBoxDebug As TextBox
    Friend WithEvents ButtonSpoilerMap As Button
    Friend WithEvents ButtonGenNumber As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButtonVanillaMap As RadioButton
    Friend WithEvents RadioButtonCustomMap As RadioButton
    Friend WithEvents RadioButtonDefaultMap As RadioButton
    Friend WithEvents CheckBoxOpenElsenova As CheckBox
    Friend WithEvents ButtonGenerateBatch As Button
    Friend WithEvents TrackBarBatchSize As TrackBar
    Friend WithEvents LabelBatchSize As Label
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents ReportAnIssueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckBoxHideItemIcons As CheckBox
    Friend WithEvents ContextMenuStripDebugMenu As ContextMenuStrip
    Friend WithEvents SaveToFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SeeSourceCodeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SeeLatestReleaseToolStripMenuItem As ToolStripMenuItem
End Class
