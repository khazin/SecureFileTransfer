<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnSelectFile = New System.Windows.Forms.Button()
        Me.txtSelectedFile = New System.Windows.Forms.TextBox()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSelectFile
        '
        Me.btnSelectFile.Location = New System.Drawing.Point(306, 83)
        Me.btnSelectFile.Name = "btnSelectFile"
        Me.btnSelectFile.Size = New System.Drawing.Size(115, 28)
        Me.btnSelectFile.TabIndex = 0
        Me.btnSelectFile.Text = "Select File"
        Me.btnSelectFile.UseVisualStyleBackColor = True
        '
        'txtSelectedFile
        '
        Me.txtSelectedFile.Location = New System.Drawing.Point(306, 130)
        Me.txtSelectedFile.Name = "txtSelectedFile"
        Me.txtSelectedFile.ReadOnly = True
        Me.txtSelectedFile.Size = New System.Drawing.Size(100, 26)
        Me.txtSelectedFile.TabIndex = 1
        '
        'btnUpload
        '
        Me.btnUpload.Location = New System.Drawing.Point(301, 188)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(120, 54)
        Me.btnUpload.TabIndex = 2
        Me.btnUpload.Text = "Upload to SFTP"
        Me.btnUpload.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnUpload)
        Me.Controls.Add(Me.txtSelectedFile)
        Me.Controls.Add(Me.btnSelectFile)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSelectFile As Button
    Friend WithEvents txtSelectedFile As TextBox
    Friend WithEvents btnUpload As Button
End Class
