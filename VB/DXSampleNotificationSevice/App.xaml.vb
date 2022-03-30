Imports System.Windows

Namespace DXSampleNotificationSevice

    Public Partial Class App
        Inherits Application

        Protected Overrides Sub OnStartup(ByVal e As StartupEventArgs)
            DevExpress.Data.ShellHelper.TryCreateShortcut("sample_notification_app", "DXSampleNotificationSevice")
            MyBase.OnStartup(e)
        End Sub
    End Class
End Namespace
