<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreditsForm
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
        Me.LabelGitHub = New System.Windows.Forms.Label()
        Me.LinkLabelGitHub = New System.Windows.Forms.LinkLabel()
        Me.LabelPozzum = New System.Windows.Forms.Label()
        Me.LinkLabelPozzum = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LinkLabelVideoGameRoulette = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LinkLabelAVDiscord = New System.Windows.Forms.LinkLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LinkLabelRandoDiscord = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'LabelGitHub
        '
        Me.LabelGitHub.AutoSize = True
        Me.LabelGitHub.Location = New System.Drawing.Point(12, 9)
        Me.LabelGitHub.Name = "LabelGitHub"
        Me.LabelGitHub.Size = New System.Drawing.Size(180, 13)
        Me.LabelGitHub.TabIndex = 0
        Me.LabelGitHub.Text = "This project is maintained on GitHub:"
        '
        'LinkLabelGitHub
        '
        Me.LinkLabelGitHub.AutoSize = True
        Me.LinkLabelGitHub.Location = New System.Drawing.Point(198, 9)
        Me.LinkLabelGitHub.Name = "LinkLabelGitHub"
        Me.LinkLabelGitHub.Size = New System.Drawing.Size(27, 13)
        Me.LinkLabelGitHub.TabIndex = 1
        Me.LinkLabelGitHub.TabStop = True
        Me.LinkLabelGitHub.Text = "Link"
        '
        'LabelPozzum
        '
        Me.LabelPozzum.AutoSize = True
        Me.LabelPozzum.Location = New System.Drawing.Point(12, 33)
        Me.LabelPozzum.Name = "LabelPozzum"
        Me.LabelPozzum.Size = New System.Drawing.Size(153, 13)
        Me.LabelPozzum.TabIndex = 2
        Me.LabelPozzum.Text = "Original programmer is Pozzum:"
        '
        'LinkLabelPozzum
        '
        Me.LinkLabelPozzum.AutoSize = True
        Me.LinkLabelPozzum.Location = New System.Drawing.Point(198, 33)
        Me.LinkLabelPozzum.Name = "LinkLabelPozzum"
        Me.LinkLabelPozzum.Size = New System.Drawing.Size(42, 13)
        Me.LinkLabelPozzum.TabIndex = 3
        Me.LinkLabelPozzum.TabStop = True
        Me.LinkLabelPozzum.Text = "Donate"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 26)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Easy logic and other fixes " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "by VideoGameRoulette:"
        '
        'LinkLabelVideoGameRoulette
        '
        Me.LinkLabelVideoGameRoulette.AutoSize = True
        Me.LinkLabelVideoGameRoulette.Location = New System.Drawing.Point(198, 68)
        Me.LinkLabelVideoGameRoulette.Name = "LinkLabelVideoGameRoulette"
        Me.LinkLabelVideoGameRoulette.Size = New System.Drawing.Size(42, 13)
        Me.LinkLabelVideoGameRoulette.TabIndex = 5
        Me.LinkLabelVideoGameRoulette.TabStop = True
        Me.LinkLabelVideoGameRoulette.Text = "Donate"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 26)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Playtesting and suggestions " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Aviom Verge Speedrunners:"
        '
        'LinkLabelAVDiscord
        '
        Me.LinkLabelAVDiscord.AutoSize = True
        Me.LinkLabelAVDiscord.Location = New System.Drawing.Point(198, 103)
        Me.LinkLabelAVDiscord.Name = "LinkLabelAVDiscord"
        Me.LinkLabelAVDiscord.Size = New System.Drawing.Size(43, 13)
        Me.LinkLabelAVDiscord.TabIndex = 7
        Me.LinkLabelAVDiscord.TabStop = True
        Me.LinkLabelAVDiscord.Text = "Discord"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 39)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Randomizer logic and" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "community discussion" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Randomizer Central:"
        '
        'LinkLabelRandoDiscord
        '
        Me.LinkLabelRandoDiscord.AutoSize = True
        Me.LinkLabelRandoDiscord.Location = New System.Drawing.Point(197, 155)
        Me.LinkLabelRandoDiscord.Name = "LinkLabelRandoDiscord"
        Me.LinkLabelRandoDiscord.Size = New System.Drawing.Size(43, 13)
        Me.LinkLabelRandoDiscord.TabIndex = 9
        Me.LinkLabelRandoDiscord.TabStop = True
        Me.LinkLabelRandoDiscord.Text = "Discord"
        '
        'CreditsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(266, 189)
        Me.Controls.Add(Me.LinkLabelRandoDiscord)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LinkLabelAVDiscord)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LinkLabelVideoGameRoulette)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LinkLabelPozzum)
        Me.Controls.Add(Me.LabelPozzum)
        Me.Controls.Add(Me.LinkLabelGitHub)
        Me.Controls.Add(Me.LabelGitHub)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CreditsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Programmer Credits"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelGitHub As Label
    Friend WithEvents LinkLabelGitHub As LinkLabel
    Friend WithEvents LabelPozzum As Label
    Friend WithEvents LinkLabelPozzum As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents LinkLabelVideoGameRoulette As LinkLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents LinkLabelAVDiscord As LinkLabel
    Friend WithEvents Label3 As Label
    Friend WithEvents LinkLabelRandoDiscord As LinkLabel
End Class
