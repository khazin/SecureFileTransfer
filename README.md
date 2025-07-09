# SecureFileTransfer
# Secure File Transfer System (SFTS) – VB.NET SFTP File Uploader & Downloader

This project demonstrates a secure file transfer system using VB.NET and SFTP. It consists of two applications designed to securely upload and download files between a local machine and an SFTP server.

---

## 💡 Business Use Case / Scenario

This project simulates a **secure internal document exchange** between departments or systems.

### 🔹 Example Scenario:
- The **Finance Department** uses the **SFTPClientSender** app to upload payroll reports or confidential Excel documents to the SFTP server.
- The **Operations Department** uses the **SFTPClientRecipient** app to download those files to their local machine for processing.

---

### 🔹 Additional Possibilities:
- The **Recipient App** (console-based) can be easily **integrated into automated workflows** using:
  - **Task Scheduler** (on Windows)  
    → To automate the download process at specific times (e.g., daily at 6 AM).
  - **Batch Scripts or PowerShell**  
    → To chain file downloads with other tasks, like data imports.

---

### 🔹 Email Notification Feature (Future Idea):
- After downloading files, the app can be enhanced to:
  - Automatically **send an email** to notify users that the download is complete.
  - Attach downloaded files or include a summary of the transfer.
- This can be achieved using:
  - **SMTP client libraries** (e.g., `System.Net.Mail` in .NET Framework).
  - Pre-defined email recipients for each department.

---

## 📁 Project Components

| App             | Description                                  |
|-----------------|----------------------------------------------|
| **SFTPClientSender** | A WinForms application for uploading files to the SFTP server. |
| **SFTPClientRecipient** | A Console application for downloading files from the SFTP server. |

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
