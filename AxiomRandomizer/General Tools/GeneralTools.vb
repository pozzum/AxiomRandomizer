Imports System.IO    'Files
Imports System.IO.Compression.ZipFile
'https://docs.microsoft.com/en-us/dotnet/api/system.io.compression.zipfile?view=netframework-4.7.2
Public Class GeneralTools
    Shared Sub FolderCheck(FolderPath As String)
        If Directory.Exists(FolderPath) = False Then
            Directory.CreateDirectory(FolderPath)
        End If
    End Sub
#Region "Zipping and unzipping folders"
    'derived from https://www.codeproject.com/Tips/257193/Easily-zip-unzip-files-using-Windows-Shell32
    Shared shObj As Object = Activator.CreateInstance(Type.GetTypeFromProgID("Shell.Application"))
    Shared Sub Zip(FolderTobeZipped)
        Dim OutputZipName As String = Directory.GetParent(Directory.GetParent(FolderTobeZipped).ToString).ToString &
                                      Path.DirectorySeparatorChar &
                                      New DirectoryInfo(FolderTobeZipped).Name &
                                      ".zip"
        If File.Exists(OutputZipName) Then
            'MessageBox.Show("File Exists to be deleted")
            File.Delete(OutputZipName)
        End If
        System.IO.Compression.ZipFile.CreateFromDirectory(FolderTobeZipped, OutputZipName)

        'Lets create an empty Zip File .
        'The following data represents an empty zip file.
        'Dim startBytes() As Byte = {80, 75, 5, 6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
        'Data for an empty zip file.
        'FileIO.FileSystem.WriteAllBytes(OutputZipName, startBytes, False)
        'We have successfully created the empty zip file.
        'Declare the folder which contains the items (files/folders) that you want to zip.
        'Dim input As Object = shObj.NameSpace((FolderTobeZipped))
        'Declare the created empty zip file.
        'Dim output As Object = shObj.NameSpace((OutputZipName))
        'Compress the items into the zip file.
        'output.CopyHere((input.Items), 4)

    End Sub

    Shared Sub UnZip(ZippedFilePath)
        Dim OutputPath As String = Path.GetDirectoryName(ZippedFilePath) &
                                     Path.DirectorySeparatorChar &
                                     Path.GetFileNameWithoutExtension(ZippedFilePath)
        'Create directory in which you will unzip your items.
        If Directory.Exists(OutputPath) Then
            DeleteAllItems(OutputPath)
        End If
        'IO.Directory.CreateDirectory(OutputPath)
        System.IO.Compression.ZipFile.ExtractToDirectory(ZippedFilePath, OutputPath)
        'Declare the folder where the items will be extracted.
        'Dim output As Object = shObj.NameSpace((OutputPath))
        'Declare the input zip file.
        'Dim input As Object = shObj.NameSpace((ZippedFilePath))
        'Extract the items from the zip file.
        'output.CopyHere((input.Items), 4)
    End Sub
#End Region
#Region "Make Writeable"
    Public Shared Sub MakeWriteable(FilePath)

        If Not File.Exists(FilePath) Then
            MessageBox.Show(FilePath & vbNewLine & "Not Found")
            Exit Sub
        End If

        Dim attributes As FileAttributes = File.GetAttributes(FilePath)

        If (attributes And FileAttributes.ReadOnly) = FileAttributes.ReadOnly Then
            attributes = RemoveAttribute(attributes, FileAttributes.ReadOnly)
            File.SetAttributes(FilePath, attributes)
            Console.WriteLine("The {0} file is no longer ReadOnly.", FilePath)
            'Else
            'File.SetAttributes(FilePath, File.GetAttributes(FilePath) Or FileAttributes.ReadOnly)
            'Console.WriteLine("The {0} file is now ReadOnly.", FilePath)
        End If
    End Sub

    Private Shared Function RemoveAttribute(ByVal attributes As FileAttributes, ByVal attributesToRemove As FileAttributes) As FileAttributes
            Return attributes And Not attributesToRemove
        End Function

#End Region
#Region "Moving folder and overwriting"
    Shared Sub MoveAllItems(ByVal fromPath As String, ByVal toPath As String)
        My.Computer.FileSystem.CopyDirectory(fromPath, toPath, True)
        My.Computer.FileSystem.DeleteDirectory(fromPath, FileIO.DeleteDirectoryOption.DeleteAllContents)
    End Sub
    Shared Sub DeleteAllItems(ByVal Path As String)
        Try
            MakeFolderWriteable(Path)
            My.Computer.FileSystem.DeleteDirectory(Path, FileIO.DeleteDirectoryOption.DeleteAllContents)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Shared Sub MakeFolderWriteable(DirectoryPath As String)
        Dim subdirectories As String() = Directory.GetDirectories(DirectoryPath)
        For Each dir As String In subdirectories
            MakeFolderWriteable(dir)
        Next
        Dim Files As String() = Directory.GetFiles(DirectoryPath)
        For Each SoloFile As String In Files
            File.SetAttributes(SoloFile, FileAttributes.Normal)
        Next
    End Sub
#End Region

End Class
