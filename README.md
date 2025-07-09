# SecureFileTransfer
# Secure File Transfer System (SFTS) – VB.NET SFTP File Uploader & Downloader

This project demonstrates a secure file transfer system using VB.NET and SFTP. It consists of two applications designed to securely upload and download files between a local machine and an SFTP server.

---

## 📁 Project Components

| App             | Description                                  |
|-----------------|----------------------------------------------|
| **SFTS Sender** | A WinForms application for uploading files to the SFTP server. |
| **SFTS Recipient** | A Console application for downloading files from the SFTP server. |

---

## 🚀 Features
- Secure file transfer using SFTP (via SSH.NET)
- Easy file upload and download
- Auto-creates remote folders if missing
- Auto-creates local folders if missing
- Reads SFTP credentials from configuration (no hardcoded values)
- Supports all file types (Word, Excel, PDF, etc.)
- Simple and clean code, ready for extension

---

## 🛠️ Technologies Used
- **VB.NET** (.NET Framework 4.8)
- **WinForms** (for Sender)
- **Console App** (for Recipient)
- **SSH.NET** Library (Renci.SshNet)
- **App.config** for storing SFTP connection settings

---

## ⚙️ Configuration

Both applications use `App.config` for their settings.

Sample `App.config` keys:
```xml
<appSettings>
  <add key="SftpHost" value="127.0.0.1" />
  <add key="SftpPort" value="22" />
  <add key="SftpUsername" value="your_username" />
  <add key="SftpPassword" value="your_password" />
  <add key="RemoteFilePath" value="/uploads/" />
  <add key="LocalFilePath" value="C:\DownloadedFiles\yourfile.txt" />
</appSettings>
