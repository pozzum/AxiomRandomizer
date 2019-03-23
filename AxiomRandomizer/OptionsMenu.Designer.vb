<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OptionsMenu
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ButtonClearAppData = New System.Windows.Forms.Button()
        Me.ButtonResetSettings = New System.Windows.Forms.Button()
        Me.CheckBoxDebug = New System.Windows.Forms.CheckBox()
        Me.LabelXML = New System.Windows.Forms.Label()
        Me.TrackBarXML = New System.Windows.Forms.TrackBar()
        Me.CheckBoxXMLLimit = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.TextBoxRandomExeLocation = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.TextBoxIlasmLocation = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TextBoxIldasmLocation = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TextBoxXMLSaveLocation = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBoxSaveFileLocation = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBoxGameLocation = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.AVFileSelector = New System.Windows.Forms.Button()
        Me.TextBoxWorkingDecompile = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxVanillaDecompile = New System.Windows.Forms.TextBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.TrackBarXML, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(284, 461)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ButtonClearAppData)
        Me.TabPage1.Controls.Add(Me.ButtonResetSettings)
        Me.TabPage1.Controls.Add(Me.CheckBoxDebug)
        Me.TabPage1.Controls.Add(Me.LabelXML)
        Me.TabPage1.Controls.Add(Me.TrackBarXML)
        Me.TabPage1.Controls.Add(Me.CheckBoxXMLLimit)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(276, 435)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Basic Options"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ButtonClearAppData
        '
        Me.ButtonClearAppData.Location = New System.Drawing.Point(106, 131)
        Me.ButtonClearAppData.Name = "ButtonClearAppData"
        Me.ButtonClearAppData.Size = New System.Drawing.Size(91, 23)
        Me.ButtonClearAppData.TabIndex = 7
        Me.ButtonClearAppData.Text = "Clear App Data"
        Me.ButtonClearAppData.UseVisualStyleBackColor = True
        '
        'ButtonResetSettings
        '
        Me.ButtonResetSettings.Location = New System.Drawing.Point(9, 131)
        Me.ButtonResetSettings.Name = "ButtonResetSettings"
        Me.ButtonResetSettings.Size = New System.Drawing.Size(91, 23)
        Me.ButtonResetSettings.TabIndex = 6
        Me.ButtonResetSettings.Text = "Reset Settings"
        Me.ButtonResetSettings.UseVisualStyleBackColor = True
        '
        'CheckBoxDebug
        '
        Me.CheckBoxDebug.AutoSize = True
        Me.CheckBoxDebug.Location = New System.Drawing.Point(9, 108)
        Me.CheckBoxDebug.Name = "CheckBoxDebug"
        Me.CheckBoxDebug.Size = New System.Drawing.Size(118, 17)
        Me.CheckBoxDebug.TabIndex = 5
        Me.CheckBoxDebug.Text = "Enable Debug Text"
        Me.CheckBoxDebug.UseVisualStyleBackColor = True
        '
        'LabelXML
        '
        Me.LabelXML.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelXML.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelXML.Location = New System.Drawing.Point(49, 77)
        Me.LabelXML.Name = "LabelXML"
        Me.LabelXML.Size = New System.Drawing.Size(39, 13)
        Me.LabelXML.TabIndex = 4
        Me.LabelXML.Text = "10"
        Me.LabelXML.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TrackBarXML
        '
        Me.TrackBarXML.Enabled = False
        Me.TrackBarXML.Location = New System.Drawing.Point(94, 57)
        Me.TrackBarXML.Maximum = 100
        Me.TrackBarXML.Name = "TrackBarXML"
        Me.TrackBarXML.Size = New System.Drawing.Size(179, 45)
        Me.TrackBarXML.TabIndex = 3
        Me.TrackBarXML.TickFrequency = 10
        Me.TrackBarXML.Value = 10
        '
        'CheckBoxXMLLimit
        '
        Me.CheckBoxXMLLimit.AutoSize = True
        Me.CheckBoxXMLLimit.Location = New System.Drawing.Point(9, 57)
        Me.CheckBoxXMLLimit.Name = "CheckBoxXMLLimit"
        Me.CheckBoxXMLLimit.Size = New System.Drawing.Size(79, 17)
        Me.CheckBoxXMLLimit.TabIndex = 2
        Me.CheckBoxXMLLimit.Text = "Limit XMLS"
        Me.CheckBoxXMLLimit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(270, 48)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(103, 19)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(100, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Default Settings"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(6, 19)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(91, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Save Settings"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Button7)
        Me.TabPage2.Controls.Add(Me.TextBoxRandomExeLocation)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Button6)
        Me.TabPage2.Controls.Add(Me.TextBoxIlasmLocation)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Button5)
        Me.TabPage2.Controls.Add(Me.TextBoxIldasmLocation)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Button4)
        Me.TabPage2.Controls.Add(Me.TextBoxXMLSaveLocation)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Button3)
        Me.TabPage2.Controls.Add(Me.TextBoxSaveFileLocation)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Controls.Add(Me.TextBoxGameLocation)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.AVFileSelector)
        Me.TabPage2.Controls.Add(Me.TextBoxWorkingDecompile)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.TextBoxVanillaDecompile)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(276, 435)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Folder Options"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(243, 134)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(25, 23)
        Me.Button7.TabIndex = 23
        Me.Button7.Text = "..."
        Me.Button7.UseVisualStyleBackColor = True
        '
        'TextBoxRandomExeLocation
        '
        Me.TextBoxRandomExeLocation.Location = New System.Drawing.Point(8, 136)
        Me.TextBoxRandomExeLocation.Name = "TextBoxRandomExeLocation"
        Me.TextBoxRandomExeLocation.ReadOnly = True
        Me.TextBoxRandomExeLocation.Size = New System.Drawing.Size(229, 20)
        Me.TextBoxRandomExeLocation.TabIndex = 22
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 120)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(144, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Randomized Game Location:"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(243, 290)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(25, 23)
        Me.Button6.TabIndex = 20
        Me.Button6.Text = "..."
        Me.Button6.UseVisualStyleBackColor = True
        '
        'TextBoxIlasmLocation
        '
        Me.TextBoxIlasmLocation.Location = New System.Drawing.Point(8, 292)
        Me.TextBoxIlasmLocation.Name = "TextBoxIlasmLocation"
        Me.TextBoxIlasmLocation.ReadOnly = True
        Me.TextBoxIlasmLocation.Size = New System.Drawing.Size(229, 20)
        Me.TextBoxIlasmLocation.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 276)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(126, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Ilasm.exe Save Location:"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(243, 251)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(25, 23)
        Me.Button5.TabIndex = 17
        Me.Button5.Text = "..."
        Me.Button5.UseVisualStyleBackColor = True
        '
        'TextBoxIldasmLocation
        '
        Me.TextBoxIldasmLocation.Location = New System.Drawing.Point(8, 253)
        Me.TextBoxIldasmLocation.Name = "TextBoxIldasmLocation"
        Me.TextBoxIldasmLocation.ReadOnly = True
        Me.TextBoxIldasmLocation.Size = New System.Drawing.Size(229, 20)
        Me.TextBoxIldasmLocation.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 237)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(132, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Ildasm.exe Save Location:"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(243, 212)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(25, 23)
        Me.Button4.TabIndex = 14
        Me.Button4.Text = "..."
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TextBoxXMLSaveLocation
        '
        Me.TextBoxXMLSaveLocation.Location = New System.Drawing.Point(8, 214)
        Me.TextBoxXMLSaveLocation.Name = "TextBoxXMLSaveLocation"
        Me.TextBoxXMLSaveLocation.ReadOnly = True
        Me.TextBoxXMLSaveLocation.Size = New System.Drawing.Size(229, 20)
        Me.TextBoxXMLSaveLocation.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 198)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "XML Save Location:"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(243, 173)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(25, 23)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "..."
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TextBoxSaveFileLocation
        '
        Me.TextBoxSaveFileLocation.Location = New System.Drawing.Point(8, 175)
        Me.TextBoxSaveFileLocation.Name = "TextBoxSaveFileLocation"
        Me.TextBoxSaveFileLocation.ReadOnly = True
        Me.TextBoxSaveFileLocation.Size = New System.Drawing.Size(229, 20)
        Me.TextBoxSaveFileLocation.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Save Location:"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(243, 95)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(25, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "..."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBoxGameLocation
        '
        Me.TextBoxGameLocation.Location = New System.Drawing.Point(8, 97)
        Me.TextBoxGameLocation.Name = "TextBoxGameLocation"
        Me.TextBoxGameLocation.ReadOnly = True
        Me.TextBoxGameLocation.Size = New System.Drawing.Size(229, 20)
        Me.TextBoxGameLocation.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Game Location:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(243, 56)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(25, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'AVFileSelector
        '
        Me.AVFileSelector.Location = New System.Drawing.Point(243, 17)
        Me.AVFileSelector.Name = "AVFileSelector"
        Me.AVFileSelector.Size = New System.Drawing.Size(25, 23)
        Me.AVFileSelector.TabIndex = 4
        Me.AVFileSelector.Text = "..."
        Me.AVFileSelector.UseVisualStyleBackColor = True
        '
        'TextBoxWorkingDecompile
        '
        Me.TextBoxWorkingDecompile.Location = New System.Drawing.Point(8, 58)
        Me.TextBoxWorkingDecompile.Name = "TextBoxWorkingDecompile"
        Me.TextBoxWorkingDecompile.ReadOnly = True
        Me.TextBoxWorkingDecompile.Size = New System.Drawing.Size(229, 20)
        Me.TextBoxWorkingDecompile.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Working Decompiled Folder:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Vanilla Decompiled Folder:"
        '
        'TextBoxVanillaDecompile
        '
        Me.TextBoxVanillaDecompile.Location = New System.Drawing.Point(8, 19)
        Me.TextBoxVanillaDecompile.Name = "TextBoxVanillaDecompile"
        Me.TextBoxVanillaDecompile.ReadOnly = True
        Me.TextBoxVanillaDecompile.Size = New System.Drawing.Size(229, 20)
        Me.TextBoxVanillaDecompile.TabIndex = 0
        '
        'OptionsMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 461)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "OptionsMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OptionsMenu"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.TrackBarXML, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents TextBoxWorkingDecompile As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxVanillaDecompile As TextBox
    Friend WithEvents LabelXML As Label
    Friend WithEvents TrackBarXML As TrackBar
    Friend WithEvents CheckBoxXMLLimit As CheckBox
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBoxXMLSaveLocation As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBoxSaveFileLocation As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBoxGameLocation As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents AVFileSelector As Button
    Friend WithEvents CheckBoxDebug As CheckBox
    Friend WithEvents Button5 As Button
    Friend WithEvents TextBoxIldasmLocation As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents TextBoxIlasmLocation As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents TextBoxRandomExeLocation As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ButtonClearAppData As Button
    Friend WithEvents ButtonResetSettings As Button
End Class
