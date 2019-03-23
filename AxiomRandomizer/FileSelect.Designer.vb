<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FileSelect
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
        Me.TextBoxFilePath = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AVFileSelector = New System.Windows.Forms.Button()
        Me.OpenFileExe = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFileSave = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioCustom = New System.Windows.Forms.RadioButton()
        Me.RadioExpress = New System.Windows.Forms.RadioButton()
        Me.CheckBoxSave = New System.Windows.Forms.CheckBox()
        Me.CheckBoxLabcoat = New System.Windows.Forms.CheckBox()
        Me.CheckBoxAnimations = New System.Windows.Forms.CheckBox()
        Me.CheckBoxBackground = New System.Windows.Forms.CheckBox()
        Me.CheckBoxWakeUp = New System.Windows.Forms.CheckBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.CheckBoxDisruptorTrace = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBoxFilePath
        '
        Me.TextBoxFilePath.Location = New System.Drawing.Point(12, 28)
        Me.TextBoxFilePath.Name = "TextBoxFilePath"
        Me.TextBoxFilePath.ReadOnly = True
        Me.TextBoxFilePath.Size = New System.Drawing.Size(179, 20)
        Me.TextBoxFilePath.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(210, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Select Axiom Verge EXE"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'AVFileSelector
        '
        Me.AVFileSelector.Location = New System.Drawing.Point(197, 26)
        Me.AVFileSelector.Name = "AVFileSelector"
        Me.AVFileSelector.Size = New System.Drawing.Size(25, 23)
        Me.AVFileSelector.TabIndex = 2
        Me.AVFileSelector.Text = "..."
        Me.ToolTip1.SetToolTip(Me.AVFileSelector, "Select File")
        Me.AVFileSelector.UseVisualStyleBackColor = True
        '
        'OpenFileExe
        '
        Me.OpenFileExe.FileName = "AxiomVerge.exe"
        Me.OpenFileExe.Filter = "Axiom Verge. EXE File|AxiomVerge.*"
        Me.OpenFileExe.InitialDirectory = "C:\Steam\steamapps\common\"
        Me.OpenFileExe.Title = "Select Axiom Verge EXE"
        '
        'OpenFileSave
        '
        Me.OpenFileSave.FileName = "Save3.sav"
        Me.OpenFileSave.Filter = "Axiom Verge Save File|*.*"
        Me.OpenFileSave.Title = "Select Axiom verge save file."
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioCustom)
        Me.GroupBox1.Controls.Add(Me.RadioExpress)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(210, 45)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'RadioCustom
        '
        Me.RadioCustom.AutoSize = True
        Me.RadioCustom.Location = New System.Drawing.Point(119, 16)
        Me.RadioCustom.Name = "RadioCustom"
        Me.RadioCustom.Size = New System.Drawing.Size(60, 17)
        Me.RadioCustom.TabIndex = 1
        Me.RadioCustom.Text = "Custom"
        Me.ToolTip1.SetToolTip(Me.RadioCustom, "Allows custom options for those " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "wishing for a more complex experience." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "MAY CAU" &
        "SE CRASHES")
        Me.RadioCustom.UseVisualStyleBackColor = True
        '
        'RadioExpress
        '
        Me.RadioExpress.AutoSize = True
        Me.RadioExpress.Checked = True
        Me.RadioExpress.Location = New System.Drawing.Point(3, 16)
        Me.RadioExpress.Name = "RadioExpress"
        Me.RadioExpress.Size = New System.Drawing.Size(62, 17)
        Me.RadioExpress.TabIndex = 0
        Me.RadioExpress.TabStop = True
        Me.RadioExpress.Text = "Express"
        Me.ToolTip1.SetToolTip(Me.RadioExpress, "Applies all quality of life changes " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "for best gameplay experience.")
        Me.RadioExpress.UseVisualStyleBackColor = True
        '
        'CheckBoxSave
        '
        Me.CheckBoxSave.AutoSize = True
        Me.CheckBoxSave.Checked = True
        Me.CheckBoxSave.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxSave.Location = New System.Drawing.Point(12, 105)
        Me.CheckBoxSave.Name = "CheckBoxSave"
        Me.CheckBoxSave.Size = New System.Drawing.Size(146, 17)
        Me.CheckBoxSave.TabIndex = 4
        Me.CheckBoxSave.Tag = "0.7.0.0"
        Me.CheckBoxSave.Text = "Change Sav files to Save"
        Me.ToolTip1.SetToolTip(Me.CheckBoxSave, "Seperates ""Axiom Verge"" saves" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "from the ""RandoAV"" saves.")
        Me.CheckBoxSave.UseVisualStyleBackColor = True
        '
        'CheckBoxLabcoat
        '
        Me.CheckBoxLabcoat.AutoSize = True
        Me.CheckBoxLabcoat.Checked = True
        Me.CheckBoxLabcoat.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxLabcoat.Location = New System.Drawing.Point(12, 128)
        Me.CheckBoxLabcoat.Name = "CheckBoxLabcoat"
        Me.CheckBoxLabcoat.Size = New System.Drawing.Size(148, 17)
        Me.CheckBoxLabcoat.TabIndex = 5
        Me.CheckBoxLabcoat.Tag = "0.7.0.0"
        Me.CheckBoxLabcoat.Text = "Give Trace Fake Labcoat"
        Me.ToolTip1.SetToolTip(Me.CheckBoxLabcoat, "Allows Trace to use the Grapple & drone" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "items before acquiring the labcoat.")
        Me.CheckBoxLabcoat.UseVisualStyleBackColor = True
        '
        'CheckBoxAnimations
        '
        Me.CheckBoxAnimations.AutoSize = True
        Me.CheckBoxAnimations.Checked = True
        Me.CheckBoxAnimations.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxAnimations.Location = New System.Drawing.Point(12, 151)
        Me.CheckBoxAnimations.Name = "CheckBoxAnimations"
        Me.CheckBoxAnimations.Size = New System.Drawing.Size(146, 17)
        Me.CheckBoxAnimations.TabIndex = 6
        Me.CheckBoxAnimations.Tag = "0.7.0.0"
        Me.CheckBoxAnimations.Text = "Wake Up Tile Animations"
        Me.ToolTip1.SetToolTip(Me.CheckBoxAnimations, "Allows Tiles to be lit & animate without " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "acquiring the Axiom Disruptor.")
        Me.CheckBoxAnimations.UseVisualStyleBackColor = True
        '
        'CheckBoxBackground
        '
        Me.CheckBoxBackground.AutoSize = True
        Me.CheckBoxBackground.Checked = True
        Me.CheckBoxBackground.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxBackground.Location = New System.Drawing.Point(12, 174)
        Me.CheckBoxBackground.Name = "CheckBoxBackground"
        Me.CheckBoxBackground.Size = New System.Drawing.Size(133, 17)
        Me.CheckBoxBackground.TabIndex = 7
        Me.CheckBoxBackground.Tag = "0.7.0.0"
        Me.CheckBoxBackground.Text = "Wake Up Background"
        Me.ToolTip1.SetToolTip(Me.CheckBoxBackground, "Allows background to be shown" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "& music to be played without" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "acquiring the Axiom " &
        "Disruptor.")
        Me.CheckBoxBackground.UseVisualStyleBackColor = True
        '
        'CheckBoxWakeUp
        '
        Me.CheckBoxWakeUp.AutoSize = True
        Me.CheckBoxWakeUp.Checked = True
        Me.CheckBoxWakeUp.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxWakeUp.Location = New System.Drawing.Point(12, 197)
        Me.CheckBoxWakeUp.Name = "CheckBoxWakeUp"
        Me.CheckBoxWakeUp.Size = New System.Drawing.Size(214, 17)
        Me.CheckBoxWakeUp.TabIndex = 8
        Me.CheckBoxWakeUp.Tag = "0.7.0.0"
        Me.CheckBoxWakeUp.Text = "Remove Wake Up from Axiom Disruptor"
        Me.ToolTip1.SetToolTip(Me.CheckBoxWakeUp, "Removes wakeup animation from" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Axiom Disruptor so it may be picked " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "up with the " &
        "drone.  " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Otherwise the game would crash.")
        Me.CheckBoxWakeUp.UseVisualStyleBackColor = True
        '
        'CheckBoxDisruptorTrace
        '
        Me.CheckBoxDisruptorTrace.AutoSize = True
        Me.CheckBoxDisruptorTrace.Checked = True
        Me.CheckBoxDisruptorTrace.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxDisruptorTrace.Location = New System.Drawing.Point(12, 220)
        Me.CheckBoxDisruptorTrace.Name = "CheckBoxDisruptorTrace"
        Me.CheckBoxDisruptorTrace.Size = New System.Drawing.Size(215, 17)
        Me.CheckBoxDisruptorTrace.TabIndex = 9
        Me.CheckBoxDisruptorTrace.Tag = "0.7.0.1"
        Me.CheckBoxDisruptorTrace.Text = "Remove Trace Sprite from Pickup Anim."
        Me.ToolTip1.SetToolTip(Me.CheckBoxDisruptorTrace, "Removes momentary ""Trace""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "sprite-load when picking up the" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Axiom Disruptor, disa" &
        "bling this" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "will cause picking it up with drone to crash." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.CheckBoxDisruptorTrace.UseVisualStyleBackColor = True
        '
        'FileSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(234, 241)
        Me.Controls.Add(Me.CheckBoxDisruptorTrace)
        Me.Controls.Add(Me.CheckBoxWakeUp)
        Me.Controls.Add(Me.CheckBoxBackground)
        Me.Controls.Add(Me.CheckBoxAnimations)
        Me.Controls.Add(Me.CheckBoxLabcoat)
        Me.Controls.Add(Me.CheckBoxSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.AVFileSelector)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxFilePath)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FileSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select Axiom Verge EXE"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxFilePath As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents AVFileSelector As Button
    Friend WithEvents OpenFileExe As OpenFileDialog
    Friend WithEvents OpenFileSave As OpenFileDialog
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioCustom As RadioButton
    Friend WithEvents RadioExpress As RadioButton
    Friend WithEvents CheckBoxSave As CheckBox
    Friend WithEvents CheckBoxLabcoat As CheckBox
    Friend WithEvents CheckBoxAnimations As CheckBox
    Friend WithEvents CheckBoxBackground As CheckBox
    Friend WithEvents CheckBoxWakeUp As CheckBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents CheckBoxDisruptorTrace As CheckBox
End Class
