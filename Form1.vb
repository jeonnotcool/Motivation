Imports System.Diagnostics
Public Class Form1

    ' Motivation Configuration [https://github.com/jeonnotcool/Motivation]
    ' You may configure anything you want.
    ' Written in Visual Basic .NET

    Dim ShutdownTime As Integer = 2 ' After showing the shutdown message, shutdown pc.
    Dim ShutdownMessage As String = "Goodbye"
    Dim NotificationTitle As String = "Itulog mo nalang ang iyong problema"
    Dim NotificationMessage As String = "Motivation message"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        My.Computer.Audio.Play(My.Resources.lolol, AudioPlayMode.Background)

        System.Threading.Thread.Sleep(6000)
        Dim notification As New System.Windows.Forms.NotifyIcon()
        notification.Icon = SystemIcons.Information
        notification.Visible = True
        notification.BalloonTipTitle = NotificationTitle
        notification.BalloonTipText = NotificationMessage
        notification.ShowBalloonTip(5000)

        System.Threading.Thread.Sleep(3000)
        ' Shutdown the PC
        Process.Start("C:\Windows\System32\shutdown.exe", "-s -t " & ShutdownTime & " -c " & ShutdownMessage)

    End Sub

End Class
