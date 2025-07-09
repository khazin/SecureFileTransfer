Imports Renci.SshNet
Imports System.Configuration
Imports System.IO

Public Class Form1
    Private Sub btnSelectFile_Click(sender As Object, e As EventArgs) Handles btnSelectFile.Click
        ' Allow user to pick a file to upload
        Using ofd As New OpenFileDialog()
            If ofd.ShowDialog() = DialogResult.OK Then
                txtSelectedFile.Text = ofd.FileName
            End If
        End Using
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Dim host As String = ConfigurationManager.AppSettings("SftpHost")
        Dim port As Integer = Convert.ToInt32(ConfigurationManager.AppSettings("SftpPort"))
        Dim username As String = ConfigurationManager.AppSettings("SftpUsername")
        Dim password As String = ConfigurationManager.AppSettings("SftpPassword")
        Dim remoteFolder As String = ConfigurationManager.AppSettings("RemoteFilePath")
        Dim localFilePath As String = txtSelectedFile.Text

        If File.Exists(localFilePath) Then
            Try
                Using sftp As New SftpClient(host, port, username, password)
                    sftp.Connect()

                    ' Create remote folder if it doesn't exist
                    If Not sftp.Exists(remoteFolder) Then
                        sftp.CreateDirectory(remoteFolder)
                    End If

                    ' Upload file to remote folder
                    Dim remoteFilePath As String = remoteFolder & Path.GetFileName(localFilePath)
                    Using fileStream As New FileStream(localFilePath, FileMode.Open)
                        sftp.UploadFile(fileStream, remoteFilePath)
                    End Using

                    sftp.Disconnect()
                    MessageBox.Show("File uploaded successfully.")
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Please select a valid file.")
        End If
    End Sub
End Class
