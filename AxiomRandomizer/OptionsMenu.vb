Public Class OptionsMenu
    Private Sub OptionsMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBasicOptionsTab()
        LoadFolderOptionsTab()
    End Sub
    Private Sub OptionsMenu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Application.OpenForms().OfType(Of RandomMenu).Any Then
            RandomMenu.Show()
        End If
    End Sub
#Region "Basic Options"
    Sub LoadBasicOptionsTab()
        LabelXML.ForeColor = System.Drawing.SystemColors.ControlText
        CheckBoxXMLLimit.Checked = My.Settings.XMLLimited
        CheckBoxDebug.Checked = My.Settings.DebugMode
        TrackBarXML.Value = My.Settings.XMLLimitCount
        LabelXML.Text = TrackBarXML.Value.ToString
        LabelXML.Enabled = CheckBoxXMLLimit.Checked
    End Sub
    Private Sub CheckBoxXMLLimit_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxXMLLimit.CheckedChanged
        My.Settings.XMLLimited = CheckBoxXMLLimit.Checked
        If CheckBoxXMLLimit.Checked Then
            TrackBarXML.Enabled = True
            LabelXML.Enabled = True
        Else
            TrackBarXML.Enabled = False
            LabelXML.Enabled = False
        End If
    End Sub
    Private Sub TrackBarXML_Scroll(sender As Object, e As EventArgs) Handles TrackBarXML.Scroll
        LabelXML.Text = TrackBarXML.Value.ToString
        My.Settings.XMLLimitCount = TrackBarXML.Value
    End Sub
    Private Sub CheckBoxDebug_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxDebug.CheckedChanged
        My.Settings.DebugMode = CheckBoxDebug.Checked
        RandomMenu.MenuHeight()
    End Sub
    Private Sub ButtonResetSettings_Click(sender As Object, e As EventArgs) Handles ButtonResetSettings.Click
        My.Settings.Reset()
        My.Settings.Save()
        Me.Close()
    End Sub
    Private Sub ButtonClearAppData_Click(sender As Object, e As EventArgs) Handles ButtonClearAppData.Click
        GeneralTools.DeleteAllItems(My.Settings.VanillaDecompileLocation)
        GeneralTools.DeleteAllItems(My.Settings.WorkingDecompileLocation)
    End Sub
#End Region
#Region "Folder Options"
    Sub LoadFolderOptionsTab()
        TextBoxVanillaDecompile.Text = My.Settings.VanillaDecompileLocation
        TextBoxWorkingDecompile.Text = My.Settings.WorkingDecompileLocation
        TextBoxGameLocation.Text = My.Settings.ExeFilePath
        TextBoxRandomExeLocation.Text = My.Settings.RandoExePath
        TextBoxSaveFileLocation.Text = My.Settings.SaveFilePath
        TextBoxXMLSaveLocation.Text = My.Settings.XMLSaveLocation
        TextBoxIldasmLocation.Text = My.Settings.IldasmSavedPath
        TextBoxIlasmLocation.Text = My.Settings.IlasmSavedPath
    End Sub
#End Region

End Class