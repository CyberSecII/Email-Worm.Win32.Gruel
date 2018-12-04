<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fake_Error
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label5.Location = New System.Drawing.Point(12, 235)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(171, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Windows X found serious error."
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(397, 67)
        Me.Panel1.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(300, 26)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Windows has encoutered a problem and needs to close. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "We are sorry for the incon" &
    "venience."
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Email_Worm.Win32.Gruel.My.Resources.Resources.ssWinver
        Me.PictureBox1.Location = New System.Drawing.Point(342, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(45, 42)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(-8, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(405, 165)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"Event ID: 1001", "Source: Save Dump", "Description:", "The computer has rebooted from a bugcheck. The bugcheck was : ", "0xc000021a (0xe1270188, 0x00000001, 0x00000000, 0x00000000). ", "Microsoft Windows NT (v15.1381). A dump was saved in: ", "C:\WINNT\MEMORY.DMP.", "MachineImageType i386", "NumberProcessors 1", "BugCheckCode 0xc000021a", "BugCheckParameter1 0xe1270188", "BugCheckParameter2 0x00000001", "BugCheckParameter3 0x00000000", "BugCheckParameter4 0x00000000", "", "ExceptionCode 0x80000003", "ExceptionFlags 0x00000001", "ExceptionAddress 0x8014fb84 ", "Ntoskrnl.exe" & Global.Microsoft.VisualBasic.ChrW(9) & "80100000   270272  40064 434816" & Global.Microsoft.VisualBasic.ChrW(9) & "Sun May 11 ", "00:10:39 1997", "   Hal.dll " & Global.Microsoft.VisualBasic.ChrW(9) & "80010000   20384   2720" & Global.Microsoft.VisualBasic.ChrW(9) & " 9344" & Global.Microsoft.VisualBasic.ChrW(9) & "Mon Mar 10 16:39:20 ", "1997", "   Aic78xx.sys" & Global.Microsoft.VisualBasic.ChrW(9) & "80001000   20512   2272" & Global.Microsoft.VisualBasic.ChrW(9) & " 0" & Global.Microsoft.VisualBasic.ChrW(9) & "Sat Apr 05 ", "21:16:21 1997", "   Scsiport.sys" & Global.Microsoft.VisualBasic.ChrW(9) & "801d7000   9824" & Global.Microsoft.VisualBasic.ChrW(9) & "   32" & Global.Microsoft.VisualBasic.ChrW(9) & " 15552" & Global.Microsoft.VisualBasic.ChrW(9) & "Mon Mar 10 ", "16:42:27 1997", "   Disk.sys" & Global.Microsoft.VisualBasic.ChrW(9) & "80008000   3328" & Global.Microsoft.VisualBasic.ChrW(9) & "   0" & Global.Microsoft.VisualBasic.ChrW(9) & " 7072" & Global.Microsoft.VisualBasic.ChrW(9) & "Thu Apr 24 ", "22:27:46 1997", "   Class2.sys" & Global.Microsoft.VisualBasic.ChrW(9) & "8000c000   7040" & Global.Microsoft.VisualBasic.ChrW(9) & "   0" & Global.Microsoft.VisualBasic.ChrW(9) & " 1632" & Global.Microsoft.VisualBasic.ChrW(9) & "Thu Apr 24 ", "22:23:43 1997", "   Ino_flpy.sys" & Global.Microsoft.VisualBasic.ChrW(9) & "801df000   9152" & Global.Microsoft.VisualBasic.ChrW(9) & "   1472" & Global.Microsoft.VisualBasic.ChrW(9) & " 2080" & Global.Microsoft.VisualBasic.ChrW(9) & "Tue May 26 ", "18:21:40 1998", "   Ntfs.sys" & Global.Microsoft.VisualBasic.ChrW(9) & "801e3000   68160   5408" & Global.Microsoft.VisualBasic.ChrW(9) & " 269632" & Global.Microsoft.VisualBasic.ChrW(9) & "Thu Apr 17 22:02:31 ", "1997", "   Floppy.sys" & Global.Microsoft.VisualBasic.ChrW(9) & "f7290000   1088" & Global.Microsoft.VisualBasic.ChrW(9) & "   672" & Global.Microsoft.VisualBasic.ChrW(9) & " 7968" & Global.Microsoft.VisualBasic.ChrW(9) & "Wed Jul 17 ", "00:31:09 1996", "   Cdrom.sys" & Global.Microsoft.VisualBasic.ChrW(9) & "f72a0000   12608   32" & Global.Microsoft.VisualBasic.ChrW(9) & " 3072" & Global.Microsoft.VisualBasic.ChrW(9) & "Wed Jul 17 ", "00:31:29 1996", "   Cdaudio.sys" & Global.Microsoft.VisualBasic.ChrW(9) & "f72b8000   960" & Global.Microsoft.VisualBasic.ChrW(9) & "   0" & Global.Microsoft.VisualBasic.ChrW(9) & " 14912" & Global.Microsoft.VisualBasic.ChrW(9) & "Mon Mar 17 ", "18:21:15 1997", "   Null.sys" & Global.Microsoft.VisualBasic.ChrW(9) & "f75c9000   0" & Global.Microsoft.VisualBasic.ChrW(9) & "   0" & Global.Microsoft.VisualBasic.ChrW(9) & " 288" & Global.Microsoft.VisualBasic.ChrW(9) & "Wed Jul 17 00:31:21 ", "1996", "   Ksecdd.sys" & Global.Microsoft.VisualBasic.ChrW(9) & "f7464000   1280" & Global.Microsoft.VisualBasic.ChrW(9) & "   224" & Global.Microsoft.VisualBasic.ChrW(9) & " 3456" & Global.Microsoft.VisualBasic.ChrW(9) & "Wed Jul 17 ", "20:34:19 1996", "   Beep.sys" & Global.Microsoft.VisualBasic.ChrW(9) & "f75ca000   1184" & Global.Microsoft.VisualBasic.ChrW(9) & "   0" & Global.Microsoft.VisualBasic.ChrW(9) & " 0" & Global.Microsoft.VisualBasic.ChrW(9) & "Wed Apr 23 ", "15:19:43 1997", "   Cs32ba11.sys" & Global.Microsoft.VisualBasic.ChrW(9) & "fcd1a000   52384   45344 14592" & Global.Microsoft.VisualBasic.ChrW(9) & "Wed Mar 12 ", "17:22:33 1997", "   Msi8042.sys" & Global.Microsoft.VisualBasic.ChrW(9) & "f7000000   20192   1536" & Global.Microsoft.VisualBasic.ChrW(9) & " 0" & Global.Microsoft.VisualBasic.ChrW(9) & "Mon Mar 23 ", "22:46:22 1998", "   Mouclass.sys" & Global.Microsoft.VisualBasic.ChrW(9) & "f7470000   1984" & Global.Microsoft.VisualBasic.ChrW(9) & "   0" & Global.Microsoft.VisualBasic.ChrW(9) & " 0" & Global.Microsoft.VisualBasic.ChrW(9) & "Mon Mar 10 ", "16:43:11 1997", "   Kbdclass.sys" & Global.Microsoft.VisualBasic.ChrW(9) & "f7478000   1952" & Global.Microsoft.VisualBasic.ChrW(9) & "   0" & Global.Microsoft.VisualBasic.ChrW(9) & " 0" & Global.Microsoft.VisualBasic.ChrW(9) & "Wed Jul 17 ", "00:31:16 1996", "   Videoprt.sys" & Global.Microsoft.VisualBasic.ChrW(9) & "f72d8000   2080" & Global.Microsoft.VisualBasic.ChrW(9) & "   128" & Global.Microsoft.VisualBasic.ChrW(9) & " 11296" & Global.Microsoft.VisualBasic.ChrW(9) & "Mon Mar 10 ", "16:41:37 1997", "   Ati.sys " & Global.Microsoft.VisualBasic.ChrW(9) & "f7010000   960" & Global.Microsoft.VisualBasic.ChrW(9) & "   9824" & Global.Microsoft.VisualBasic.ChrW(9) & " 48768" & Global.Microsoft.VisualBasic.ChrW(9) & "Fri Dec 12 15:20:37 1997", "   Vga.sys " & Global.Microsoft.VisualBasic.ChrW(9) & "f7488000   128" & Global.Microsoft.VisualBasic.ChrW(9) & "   32" & Global.Microsoft.VisualBasic.ChrW(9) & " 10784" & Global.Microsoft.VisualBasic.ChrW(9) & "Wed Jul 17 ", "00:30:37 1996", "   Msfs.sys" & Global.Microsoft.VisualBasic.ChrW(9) & "f7308000   864" & Global.Microsoft.VisualBasic.ChrW(9) & "   32" & Global.Microsoft.VisualBasic.ChrW(9) & " 15328" & Global.Microsoft.VisualBasic.ChrW(9) & "Mon Mar 10 ", "16:45:01 1997", "   Npfs.sys" & Global.Microsoft.VisualBasic.ChrW(9) & "f7020000   6560" & Global.Microsoft.VisualBasic.ChrW(9) & "   192" & Global.Microsoft.VisualBasic.ChrW(9) & " 22624" & Global.Microsoft.VisualBasic.ChrW(9) & "Mon Mar 10 ", "16:44:48 1997", "   Ndis.sys" & Global.Microsoft.VisualBasic.ChrW(9) & "fccda000   11744   704" & Global.Microsoft.VisualBasic.ChrW(9) & " 96768" & Global.Microsoft.VisualBasic.ChrW(9) & "Thu Apr 17 ", "22:19:45 1997", "   Win32k.sys" & Global.Microsoft.VisualBasic.ChrW(9) & "a0000000   1162624 40064 0" & Global.Microsoft.VisualBasic.ChrW(9) & "Fri Apr 25 21:17:32 1997", "   Ati.dll " & Global.Microsoft.VisualBasic.ChrW(9) & "fccba000   106176  17024 0" & Global.Microsoft.VisualBasic.ChrW(9) & "Fri Dec 12 15:20:08 1997", "   Cdfs.sys" & Global.Microsoft.VisualBasic.ChrW(9) & "f7050000   5088" & Global.Microsoft.VisualBasic.ChrW(9) & "   608   45984" & Global.Microsoft.VisualBasic.ChrW(9) & "Mon Mar 10 ", "16:57:04 1997", "   Ino_fltr.sys" & Global.Microsoft.VisualBasic.ChrW(9) & "fc42f000   29120   38176 1888" & Global.Microsoft.VisualBasic.ChrW(9) & "Tue Jun 02 ", "16:33:05 1998", "   Tdi.sys " & Global.Microsoft.VisualBasic.ChrW(9) & "fc4a2000   4480    96" & Global.Microsoft.VisualBasic.ChrW(9) & " 288" & Global.Microsoft.VisualBasic.ChrW(9) & "Wed Jul 17 00:39:08 ", "1996", "   Tcpip.sys" & Global.Microsoft.VisualBasic.ChrW(9) & "fc40b000   108128  7008" & Global.Microsoft.VisualBasic.ChrW(9) & " 10176" & Global.Microsoft.VisualBasic.ChrW(9) & "Fri May 09 ", "17:02:39 1997", "   Netbt.sys" & Global.Microsoft.VisualBasic.ChrW(9) & "fc3ee000   79808   1216" & Global.Microsoft.VisualBasic.ChrW(9) & " 23872" & Global.Microsoft.VisualBasic.ChrW(9) & "Sat Apr 26 ", "21:00:42 1997", "   El90x.sys" & Global.Microsoft.VisualBasic.ChrW(9) & "f7320000   24576   1536" & Global.Microsoft.VisualBasic.ChrW(9) & " 0" & Global.Microsoft.VisualBasic.ChrW(9) & "Wed Jun 26 ", "20:04:31 1996", "   Afd.sys " & Global.Microsoft.VisualBasic.ChrW(9) & "f70d0000   1696    928" & Global.Microsoft.VisualBasic.ChrW(9) & " 48672" & Global.Microsoft.VisualBasic.ChrW(9) & "Thu Apr 10 15:09:17 ", "1997", "   Netbios.sys" & Global.Microsoft.VisualBasic.ChrW(9) & "f7280000   13280   224" & Global.Microsoft.VisualBasic.ChrW(9) & " 10720" & Global.Microsoft.VisualBasic.ChrW(9) & "Mon Mar 10 ", "16:56:01 1997", "   Parport.sys" & Global.Microsoft.VisualBasic.ChrW(9) & "f7460000   3424    32" & Global.Microsoft.VisualBasic.ChrW(9) & " 0" & Global.Microsoft.VisualBasic.ChrW(9) & "Wed Jul 17 ", "00:31:23 1996", "   Parallel.sys" & Global.Microsoft.VisualBasic.ChrW(9) & "f746c000   7904    32" & Global.Microsoft.VisualBasic.ChrW(9) & " 0" & Global.Microsoft.VisualBasic.ChrW(9) & "Wed Jul 17 ", "00:31:23 1996", "   Parvdm.sys" & Global.Microsoft.VisualBasic.ChrW(9) & "f7552000   1312    32" & Global.Microsoft.VisualBasic.ChrW(9) & " 0" & Global.Microsoft.VisualBasic.ChrW(9) & "Wed Jul 17 ", "00:31:25 1996", "   Serial.sys" & Global.Microsoft.VisualBasic.ChrW(9) & "f7120000   2560    0" & Global.Microsoft.VisualBasic.ChrW(9) & " 18784" & Global.Microsoft.VisualBasic.ChrW(9) & "Mon Mar 10 ", "16:44:11 1997", "   Rdr.sys " & Global.Microsoft.VisualBasic.ChrW(9) & "fc385000   13472   1984" & Global.Microsoft.VisualBasic.ChrW(9) & " 219104" & Global.Microsoft.VisualBasic.ChrW(9) & "Wed Mar 26 14:22:36 ", "1997", "   Mup.sys " & Global.Microsoft.VisualBasic.ChrW(9) & "fc374000   2208    6752" & Global.Microsoft.VisualBasic.ChrW(9) & " 48864" & Global.Microsoft.VisualBasic.ChrW(9) & "Mon Mar 10 ", "16:57:09 1997", "   Srv.sys " & Global.Microsoft.VisualBasic.ChrW(9) & "fc24a000   42848   7488" & Global.Microsoft.VisualBasic.ChrW(9) & " 163680" & Global.Microsoft.VisualBasic.ChrW(9) & "Fri Apr 25 13:59:31 1997", "   Pscript.dll" & Global.Microsoft.VisualBasic.ChrW(9) & "f9ec3000   0       0" & Global.Microsoft.VisualBasic.ChrW(9) & " 0", "   Fastfat.sys" & Global.Microsoft.VisualBasic.ChrW(9) & "f9e00000   6720    672" & Global.Microsoft.VisualBasic.ChrW(9) & " 114368" & Global.Microsoft.VisualBasic.ChrW(9) & "Mon Apr 21 ", "16:50:22 1997", "   Ntdll.dll" & Global.Microsoft.VisualBasic.ChrW(9) & "77f60000   237568  20480 0" & Global.Microsoft.VisualBasic.ChrW(9) & "Fri Apr 11 16:38:50 1997", "   ---------------------------------------------------------------------", "   Total   " & Global.Microsoft.VisualBasic.ChrW(9) & "2377632    255040  1696384", "MachineImageType     i386", "   NumberProcessors     1", "   BugCheckCode         0xc000021a", "   BugCheckParameter2   0x00000001", "   BugCheckParameter3   0x00000000", "   BugCheckParameter4   0x00000000", "", "   ExceptionCode        0x80000003", "   ExceptionFlags       0x00000001", "   ExceptionAddress     0x8014fb84"})
        Me.ListBox1.Location = New System.Drawing.Point(15, 18)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(379, 134)
        Me.ListBox1.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(223, 230)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "<< Back"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(304, 230)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(81, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Fake_Error
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 265)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Fake_Error"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Windows"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
End Class
