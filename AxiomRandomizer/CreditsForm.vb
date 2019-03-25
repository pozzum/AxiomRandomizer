Public Class CreditsForm
    Private Sub Credits_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & " Ver: " & My.Application.Info.Version.ToString
        LinkLabelGitHub.Links.Add(LinkLabelGitHub.LinkArea.Start, LinkLabelGitHub.LinkArea.Length, "https://github.com/pozzum/AxiomRandomizer")
        LinkLabelPozzum.Links.Add(LinkLabelPozzum.LinkArea.Start, LinkLabelPozzum.LinkArea.Length, "http://paypal.me/pozzum")
        LinkLabelVideoGameRoulette.Links.Add(LinkLabelVideoGameRoulette.LinkArea.Start, LinkLabelVideoGameRoulette.LinkArea.Length, "https://paypal.me/VideoGameRoulette")
        LinkLabelAVDiscord.Links.Add(LinkLabelAVDiscord.LinkArea.Start, LinkLabelAVDiscord.LinkArea.Length, "https://discord.gg/mTRtcS8")
        LinkLabelRandoDiscord.Links.Add(LinkLabelRandoDiscord.LinkArea.Start, LinkLabelRandoDiscord.LinkArea.Length, "https://discordapp.com/invite/tEGFUZW")
    End Sub

    Private Sub LinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelGitHub.LinkClicked, LinkLabelPozzum.LinkClicked
        Process.Start(e.Link.LinkData.ToString())
    End Sub
End Class