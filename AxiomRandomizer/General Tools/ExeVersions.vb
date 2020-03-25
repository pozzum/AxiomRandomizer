Imports System.IO
Imports System.Security.Cryptography
Imports System.Windows.Forms 'MessageBoxes
Public Class ExeVersions
#Region "Hash Functions"
    'http://us.informatiweb.net/tutorials/programing/1-vb-net/36--generate-hashes-md5-sha-1-and-sha-256-of-a-file.html
    Shared Function Md5Hash(ByVal FileName As String)
        Return HashGenerator("md5", FileName)
    End Function
    Shared Function HashGenerator(ByVal HashType As String, ByVal FileName As String)
        ' We declare the variable: hash
        Dim Hash
        If HashType.ToLower = "md5" Then
            ' Initializes a hash object : md5
            Hash = MD5.Create
        ElseIf HashType.ToLower = "sha1" Then
            ' Initializes a hash object : SHA-1
            Hash = SHA1.Create()
        ElseIf HashType.ToLower = "sha256" Then
            ' Initializes a hash object : SHA-256
            Hash = SHA256.Create()
        Else
            MsgBox("Type of hash unknown : " & HashType, MsgBoxStyle.Critical)
            Return False
        End If
        ' We declare a variable that will be an array of bytes (bytes)
        Dim HashValue() As Byte
        Try
            ' We create a FileStream for the file passed as a parameter
            Dim FileStream As FileStream = File.OpenRead(FileName)
            ' We position the cursor at the beginning of the stream
            FileStream.Position = 0
            ' The hash of the file
            HashValue = Hash.ComputeHash(FileStream)
            ' The Byte array Is converted to hexadecimal for easy reading
            Dim HashHex = PrintByteArray(HashValue)
            ' The open file Is closed
            FileStream.Close()
            ' Return the hash
            Return HashHex
        Catch
            MessageBox.Show("Error occurred! Try Again.")
        End Try
        'if file open fails
        Return Nothing
    End Function
    ' One parses the array Of bytes (bytes) And converts Each Byte (Byte) To hexadecimal
    Public Shared Function PrintByteArray(ByVal Array() As Byte)
        Dim HexValue As String = ""
        ' The Byte array (bytes)
        Dim i As Integer
        For i = 0 To Array.Length - 1
            ' Each byte Is converted to hexadecimal
            HexValue += Array(i).ToString("X2")
        Next i
        ' Return the string to lowercase
        Return HexValue.ToUpper
    End Function
#End Region

    Public Enum Version As Integer
        Steam
        Epic
        Source
    End Enum

    Shared Function CheckExe(EXEFilePath)
        Dim EXEhash As String = Md5Hash(EXEFilePath)
        My.Settings.ExeHashString = EXEhash
        'MessageBox.Show(EXEhash)
        If EXEhash = "B5AD0D15712898CED08A78084FEEB6D1" Then
            My.Settings.VersionString = "Version 1.43, 8/1/2018"
            My.Settings.SteamVersion = Version.Steam
            'Version 1.43, 8/1/2018
            'Randomizer origionally developed for this version (Steam)
            Return True
        ElseIf EXEhash = "E99C059B3F743465AAAAB366DE1F536E" Then
            My.Settings.VersionString = "Version 1.47, 2/7/2019"
            My.Settings.SteamVersion = Version.Epic
            'Version 1.47, 2/8/2019
            'Epic Games Version
            Return True
        ElseIf MessageBox.Show("Game version is unknown randomizer may not work." & vbNewLine &
                                    "File Hash: " & EXEhash & vbNewLine &
                                    "Continue?", "Unknown EXE!", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            My.Settings.VersionString = "Version 1.50, 2020"
            My.Settings.SteamVersion = Version.Source
            Return True
        Else
            Return False
        End If
    End Function
    Shared Function CheckBackup(BackupPath, EXEFilePath)
        Dim Backhash As String = Md5Hash(BackupPath)
        Dim EXEhash As String = Md5Hash(EXEFilePath)
        If Backhash = EXEhash Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
