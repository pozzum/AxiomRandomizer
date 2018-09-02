Imports System.Text.RegularExpressions
Imports System.Windows.Forms 'messageboxes
Imports System
Public Class OnlineVersion
    'uses smrando's updater as a base https://github.com/Dessyreqt/smrandomizer/blob/master/SuperMetroidRandomizer/Net/RandomizerVersion.cs
    Public Enum UpdateType
        None
        MinorBugFix
        MajorBugFix
        MinorUpdate
        MajorUpdate
    End Enum
    Shared PageAddress As String = "https://pozzum.github.io/AxiomRandomizer/"
    'Dim LocalVersionSplit() As Integer = CInt(Split(LocalVersion, "."))
    Shared Sub CheckUpdate()
        Try
            Dim Response = GetResponse(PageAddress)
            If String.IsNullOrWhiteSpace(Response) Then
                'do nothing
            End If
            MessageBox.Show("Response Get")
            Const pattern As String = "Current Version: (?<version>\d.\d.\d.\d)"
            Dim TempMatch As Match = Regex.Match(Response, pattern)
            If TempMatch.Success Then
                Dim CurrentVersion As String = TempMatch.Groups("version").Value
                Dim CurrentVersionTemp() As String = Split(CurrentVersion, ".")
                Dim CurrentVersionInt(3) As Integer
                Dim LocalVersion As String = My.Application.Info.Version.ToString
                Dim LocalVersionTemp() As String = Split(LocalVersion, ".")
                Dim LocalVersionInt(3) As Integer
                For s As Integer = 0 To 3
                    CurrentVersionInt(s) = CInt(CurrentVersionTemp(s))
                    LocalVersionInt(s) = CInt(LocalVersionTemp(s))
                Next
                Dim ChangeType As String = ""
                ChangeType = GetUpdateType(CurrentVersionInt, LocalVersionInt)
                If Not ChangeType = UpdateType.None Then
                    Dim result As Integer = MessageBox.Show("You have version " & LocalVersion &
                                                            " and there is a new " & GetUpdateString(ChangeType) &
                                                            " version " & CurrentVersion &
                                                            vbNewLine & "Would you like to update?",
                                                            "Version Update",
                                                            MessageBoxButtons.YesNo)
                    If result = DialogResult.Yes Then
                        Help.ShowHelp(Nothing, PageAddress)

                    Else
                        'do nothing
                    End If
                Else
                    'do nothing
                End If

            End If
        Catch ex As NullReferenceException
            'Do nothing
        End Try
    End Sub
    Shared Function GetResponse(Address As String)
        If Not Address.Contains("pozzum.github.io/AxiomRandomizer") Then
            Return ""
        End If
        Dim TempBrowser As WebBrowser = New WebBrowser With {
            .ScrollBarsEnabled = False,
            .ScriptErrorsSuppressed = True}
        TempBrowser.Navigate(Address)
        While (TempBrowser.ReadyState = WebBrowserReadyState.Complete) = False
            Application.DoEvents()
        End While
        Return TempBrowser.Document.Body.InnerHtml
    End Function
    Shared Function GetUpdateType(CheckedVersion, LocalVersion) As UpdateType
        If CheckedVersion(0) > LocalVersion(0) Then
            Return UpdateType.MajorUpdate
        ElseIf CheckedVersion(1) > LocalVersion(1) Then
            Return UpdateType.MinorUpdate
        ElseIf CheckedVersion(2) > LocalVersion(2) Then
            Return UpdateType.MajorBugFix
        ElseIf CheckedVersion(3) > LocalVersion(3) Then
            Return UpdateType.MinorBugFix
        Else
            Return UpdateType.None
        End If

    End Function
    Shared Function GetUpdateString(ChangeType As UpdateType)
        If ChangeType = UpdateType.MajorUpdate Then
            Return "major update"
        ElseIf ChangeType = UpdateType.MinorUpdate Then
            Return "minor update"
        ElseIf ChangeType = UpdateType.MajorBugFix Then
            Return "major bugfix"
        ElseIf ChangeType = UpdateType.MinorBugFix Then
            Return "minor bugfix"
        Else
            Return ""
        End If
    End Function

End Class
