Imports System.Text.RegularExpressions
Imports System.Management

Public Class Form1

    Dim FlashToolLocationVerified = False
    Dim BinaryLocationVerified = False
    Dim COMVerified = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FlashtoolLabel.Text = My.Settings.LastFlashLocation
        BinaryLabel.Text = My.Settings.LastBinLocation

        If (My.Computer.FileSystem.FileExists(Application.StartupPath + "\esptool.exe")) Then
            If (My.Settings.HasSeenFlashDirectoryWarning = False) Then
                MsgBox("Application is running in the same path as esptool, will use this tool over the selected one. To avoid this in the future, place this tool elsewhere. THIS MESSAGE WILL ONLY BE SHOWN ONCE.")
                My.Settings.HasSeenFlashDirectoryWarning = True
            End If

            My.Settings.LastFlashLocation = Application.StartupPath + "\esptool.exe"
            FlashtoolLabel.Text = Application.StartupPath + "\esptool.exe"
            FlashToolLocationVerified = True

            My.Settings.Save()
        End If

        If (My.Computer.FileSystem.FileExists(Application.StartupPath + "\ESP.bin")) Then
            If (My.Settings.HasSeenDefaultBinWarning = False) Then
                MsgBox("Default override ESP.bin found in this path, will default to this binary unless another is selected. THIS MESSAGE WILL ONLY BE SHOWN ONCE.")
                My.Settings.HasSeenDefaultBinWarning = True
            End If

            My.Settings.LastBinLocation = Application.StartupPath + "\ESP.bin"
            BinaryLabel.Text = Application.StartupPath + "\ESP.bin"
            BinaryLocationVerified = True
            My.Settings.Save()
        End If

        Dim ComX = findComDevice("Silicon Labs CP210x USB to UART Bridge")
        If (ComX.StartsWith("COM")) Then
            ComDevLabel.Text = ComX
            COMVerified = True
        End If

        EnableButtonX()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start("https://github.com/espressif/esptool/releases/")
    End Sub

    Private Sub EnableButtonX()
        If (FlashToolLocationVerified = True And BinaryLocationVerified = True And COMVerified = True) Then
            FlashButton.Enabled = True
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        OpenFileDialog1.ShowDialog()
        Dim FilenameX = OpenFileDialog1.FileName

        If (FilenameX.EndsWith(".bin")) Then
            BinaryLabel.Text = FilenameX
            BinaryLocationVerified = True
            My.Settings.LastBinLocation = FilenameX
            My.Settings.Save()
        Else
            BinaryLabel.Text = "File did not have the .bin extension, retry."
        End If

        EnableButtonX()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        OpenFileDialog1.ShowDialog()
        Dim FileX = OpenFileDialog1.FileName

        If (FileX.Contains("esptool.exe")) Then
            FlashtoolLabel.Text = FileX
            FlashToolLocationVerified = True
            My.Settings.LastFlashLocation = FileX
            My.Settings.Save()
        Else
            FlashtoolLabel.Text = "Invalid, or renamed tool. Retry."
        End If

        EnableButtonX()
    End Sub

    Private Sub FlashButton_Click(sender As Object, e As EventArgs) Handles FlashButton.Click
        WarningLabel.Enabled = True
        FlashWarningTimer.Start()
        FlasherWorker.RunWorkerAsync()
    End Sub

    Public Function findComDevice(ByVal PartialName As String) As String
        Try
            Dim moReturn As Management.ManagementObjectCollection
            Dim moSearch As Management.ManagementObjectSearcher
            Dim mo As Management.ManagementObject
            moSearch = New Management.ManagementObjectSearcher("Select * from Win32_PnPEntity")
            moReturn = moSearch.Get

            For Each mo In moReturn
                If IsNothing(mo.Properties.Item("Name").Value) Then Continue For
                If CStr(mo.Properties.Item("Name").Value).ToUpper.Contains(PartialName.ToUpper) Then
                    'returns something like: "Prolific USB-to-Serial Comm Port (COM17)"
                    Dim IPRegEx As Regex = New Regex("(?<=\().*?(?=\))")
                    Return IPRegEx.Match(mo.Properties.Item("Name").Value.ToString).Value

                End If
            Next
            Return Nothing
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
            Return Nothing
        End Try

    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim ComX = findComDevice("Silicon Labs CP210x USB to UART Bridge")
        If (ComX.StartsWith("COM")) Then
            ComDevLabel.Text = ComX
            COMVerified = True
        End If
    End Sub

    Private Sub FlasherWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles FlasherWorker.DoWork

        Dim Argbuilder As String = "--port " + ComDevLabel.Text + " --baud 921600 write_flash -fm dio 0x00000 " + BinaryLabel.Text

        Dim oProcess As New Process()
        Dim oStartInfo As New ProcessStartInfo(FlashtoolLabel.Text, Argbuilder)
        oStartInfo.UseShellExecute = False
        oStartInfo.RedirectStandardOutput = True
        oStartInfo.RedirectStandardError = True
        oStartInfo.CreateNoWindow = True
        oProcess.StartInfo = oStartInfo
        oProcess.Start()

        Dim sOutput As String
        Using oStreamReader As System.IO.StreamReader = oProcess.StandardOutput
            sOutput = oStreamReader.ReadToEnd()
            Console.WriteLine(sOutput)
        End Using
        Console.WriteLine(sOutput)
        FlasherWorker.ReportProgress(100)
    End Sub

    Private Sub FlasherWorker_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles FlasherWorker.ProgressChanged
        If (e.ProgressPercentage = 100) Then
            FlashWarningTimer.Stop()
            WarningLabel.Enabled = False
        End If
    End Sub

    Private Sub FlashWarningTimer_Tick(sender As Object, e As EventArgs) Handles FlashWarningTimer.Tick
        If (WarningLabel.ForeColor = Color.Red) Then
            WarningLabel.ForeColor = Color.Green
        Else
            WarningLabel.ForeColor = Color.Red
        End If

    End Sub
End Class
