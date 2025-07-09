Imports System.Configuration
Imports Renci.SshNet
Imports System.IO

Module Module1
    Sub Main()
        ' Read SFTP settings from config file
        Dim host As String = ConfigurationManager.AppSettings("SftpHost")
        Dim port As Integer = Convert.ToInt32(ConfigurationManager.AppSettings("SftpPort"))
        Dim username As String = ConfigurationManager.AppSettings("SftpUsername")
        Dim password As String = ConfigurationManager.AppSettings("SftpPassword")
        Dim remoteFilePath As String = ConfigurationManager.AppSettings("RemoteFilePath")
        Dim localFilePath As String = ConfigurationManager.AppSettings("LocalFilePath")

        Using sftp As New SftpClient(host, port, username, password)
            Try
                sftp.Connect()
                Console.WriteLine("Connected to SFTP server.")

                ' Ensure local directory exists
                Dim localDir As String = Path.GetDirectoryName(localFilePath)
                If Not Directory.Exists(localDir) Then
                    Directory.CreateDirectory(localDir)
                End If

                ' Check if remote file exists before downloading
                If sftp.Exists(remoteFilePath) Then
                    Using fileStream As New FileStream(localFilePath, FileMode.Create)
                        sftp.DownloadFile(remoteFilePath, fileStream)
                    End Using
                    Console.WriteLine("File downloaded successfully to " & localFilePath)
                Else
                    Console.WriteLine("Remote file not found: " & remoteFilePath)
                End If

                sftp.Disconnect()
            Catch ex As Exception
                Console.WriteLine("Error: " & ex.Message)
            End Try
        End Using

        Console.WriteLine("Press any key to exit...")
        Console.ReadKey()
    End Sub
End Module
