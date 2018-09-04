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
        Me.TextBoxExeLocation = New System.Windows.Forms.TextBox()
        Me.ButtonBuild = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonFileSelect = New System.Windows.Forms.Button()
        Me.ButtonSpoiler = New System.Windows.Forms.Button()
        Me.ButtonOpenBaseGame = New System.Windows.Forms.Button()
        Me.ButtonOpenRando = New System.Windows.Forms.Button()
        Me.LabelDonate = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.CheckBoxHideItems = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'TextBoxSeed
        '
        Me.TextBoxSeed.Location = New System.Drawing.Point(12, 25)
        Me.TextBoxSeed.MaxLength = 10
        Me.TextBoxSeed.Name = "TextBoxSeed"
        Me.TextBoxSeed.Size = New System.Drawing.Size(194, 20)
        Me.TextBoxSeed.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Seed:"
        '
        'ButtonRandomSeed
        '
        Me.ButtonRandomSeed.Location = New System.Drawing.Point(212, 23)
        Me.ButtonRandomSeed.Name = "ButtonRandomSeed"
        Me.ButtonRandomSeed.Size = New System.Drawing.Size(60, 23)
        Me.ButtonRandomSeed.TabIndex = 2
        Me.ButtonRandomSeed.Text = "Random"
        Me.ButtonRandomSeed.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 48)
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
        Me.ComboBoxDifficulties.Location = New System.Drawing.Point(12, 64)
        Me.ComboBoxDifficulties.Name = "ComboBoxDifficulties"
        Me.ComboBoxDifficulties.Size = New System.Drawing.Size(260, 21)
        Me.ComboBoxDifficulties.TabIndex = 4
        '
        'CheckBoxIllusion
        '
        Me.CheckBoxIllusion.AutoSize = True
        Me.CheckBoxIllusion.Checked = True
        Me.CheckBoxIllusion.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxIllusion.Location = New System.Drawing.Point(12, 91)
        Me.CheckBoxIllusion.Name = "CheckBoxIllusion"
        Me.CheckBoxIllusion.Size = New System.Drawing.Size(155, 17)
        Me.CheckBoxIllusion.TabIndex = 5
        Me.CheckBoxIllusion.Text = "Allow Illusion Bypass Route"
        Me.CheckBoxIllusion.UseVisualStyleBackColor = True
        '
        'CheckBoxWalls
        '
        Me.CheckBoxWalls.AutoSize = True
        Me.CheckBoxWalls.Checked = True
        Me.CheckBoxWalls.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxWalls.Location = New System.Drawing.Point(12, 114)
        Me.CheckBoxWalls.Name = "CheckBoxWalls"
        Me.CheckBoxWalls.Size = New System.Drawing.Size(174, 17)
        Me.CheckBoxWalls.TabIndex = 6
        Me.CheckBoxWalls.Text = "Change Ukkin-Na 1 Way Walls"
        Me.CheckBoxWalls.UseVisualStyleBackColor = True
        '
        'CheckBoxDropDown
        '
        Me.CheckBoxDropDown.AutoSize = True
        Me.CheckBoxDropDown.Checked = True
        Me.CheckBoxDropDown.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxDropDown.Location = New System.Drawing.Point(12, 137)
        Me.CheckBoxDropDown.Name = "CheckBoxDropDown"
        Me.CheckBoxDropDown.Size = New System.Drawing.Size(166, 17)
        Me.CheckBoxDropDown.TabIndex = 7
        Me.CheckBoxDropDown.Text = "Change Zi 1 Way Drop Down"
        Me.CheckBoxDropDown.UseVisualStyleBackColor = True
        '
        'TextBoxExeLocation
        '
        Me.TextBoxExeLocation.Location = New System.Drawing.Point(12, 219)
        Me.TextBoxExeLocation.Name = "TextBoxExeLocation"
        Me.TextBoxExeLocation.ReadOnly = True
        Me.TextBoxExeLocation.Size = New System.Drawing.Size(229, 20)
        Me.TextBoxExeLocation.TabIndex = 8
        '
        'ButtonBuild
        '
        Me.ButtonBuild.Location = New System.Drawing.Point(12, 246)
        Me.ButtonBuild.Name = "ButtonBuild"
        Me.ButtonBuild.Size = New System.Drawing.Size(125, 23)
        Me.ButtonBuild.TabIndex = 9
        Me.ButtonBuild.Text = "Build exe From Seed"
        Me.ButtonBuild.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 203)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Exe Location:"
        '
        'ButtonFileSelect
        '
        Me.ButtonFileSelect.Location = New System.Drawing.Point(247, 217)
        Me.ButtonFileSelect.Name = "ButtonFileSelect"
        Me.ButtonFileSelect.Size = New System.Drawing.Size(25, 23)
        Me.ButtonFileSelect.TabIndex = 11
        Me.ButtonFileSelect.Text = "..."
        Me.ButtonFileSelect.UseVisualStyleBackColor = True
        '
        'ButtonSpoiler
        '
        Me.ButtonSpoiler.Location = New System.Drawing.Point(147, 246)
        Me.ButtonSpoiler.Name = "ButtonSpoiler"
        Me.ButtonSpoiler.Size = New System.Drawing.Size(125, 23)
        Me.ButtonSpoiler.TabIndex = 12
        Me.ButtonSpoiler.Text = "Generate Spoiler"
        Me.ButtonSpoiler.UseVisualStyleBackColor = True
        '
        'ButtonOpenBaseGame
        '
        Me.ButtonOpenBaseGame.Location = New System.Drawing.Point(147, 275)
        Me.ButtonOpenBaseGame.Name = "ButtonOpenBaseGame"
        Me.ButtonOpenBaseGame.Size = New System.Drawing.Size(125, 23)
        Me.ButtonOpenBaseGame.TabIndex = 14
        Me.ButtonOpenBaseGame.Text = "Open Base Game"
        Me.ButtonOpenBaseGame.UseVisualStyleBackColor = True
        '
        'ButtonOpenRando
        '
        Me.ButtonOpenRando.Location = New System.Drawing.Point(12, 275)
        Me.ButtonOpenRando.Name = "ButtonOpenRando"
        Me.ButtonOpenRando.Size = New System.Drawing.Size(125, 23)
        Me.ButtonOpenRando.TabIndex = 15
        Me.ButtonOpenRando.Text = "Open Rando Game"
        Me.ButtonOpenRando.UseVisualStyleBackColor = True
        '
        'LabelDonate
        '
        Me.LabelDonate.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.LabelDonate.Location = New System.Drawing.Point(155, 301)
        Me.LabelDonate.Name = "LabelDonate"
        Me.LabelDonate.Size = New System.Drawing.Size(117, 17)
        Me.LabelDonate.TabIndex = 16
        Me.LabelDonate.Text = "Developed By Pozzum"
        Me.LabelDonate.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.ToolTip1.SetToolTip(Me.LabelDonate, "donations are appreciated :)")
        '
        'CheckBoxHideItems
        '
        Me.CheckBoxHideItems.AutoSize = True
        Me.CheckBoxHideItems.Enabled = False
        Me.CheckBoxHideItems.Location = New System.Drawing.Point(12, 160)
        Me.CheckBoxHideItems.Name = "CheckBoxHideItems"
        Me.CheckBoxHideItems.Size = New System.Drawing.Size(76, 17)
        Me.CheckBoxHideItems.TabIndex = 17
        Me.CheckBoxHideItems.Text = "Hide Items"
        Me.CheckBoxHideItems.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Enabled = False
        Me.CheckBox1.Location = New System.Drawing.Point(12, 183)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(125, 17)
        Me.CheckBox1.TabIndex = 18
        Me.CheckBox1.Text = "Randomize Monsters"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'RandomMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 331)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.CheckBoxHideItems)
        Me.Controls.Add(Me.LabelDonate)
        Me.Controls.Add(Me.ButtonOpenRando)
        Me.Controls.Add(Me.ButtonOpenBaseGame)
        Me.Controls.Add(Me.ButtonSpoiler)
        Me.Controls.Add(Me.ButtonFileSelect)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ButtonBuild)
        Me.Controls.Add(Me.TextBoxExeLocation)
        Me.Controls.Add(Me.CheckBoxDropDown)
        Me.Controls.Add(Me.CheckBoxWalls)
        Me.Controls.Add(Me.CheckBoxIllusion)
        Me.Controls.Add(Me.ComboBoxDifficulties)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ButtonRandomSeed)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxSeed)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RandomMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Randomizer Menu"
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
    Friend WithEvents TextBoxExeLocation As TextBox
    Friend WithEvents ButtonBuild As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents ButtonFileSelect As Button
    Friend WithEvents ButtonSpoiler As Button
    Friend WithEvents ButtonOpenBaseGame As Button
    Friend WithEvents ButtonOpenRando As Button
    Friend WithEvents LabelDonate As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents CheckBoxHideItems As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
End Class
