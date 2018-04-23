Imports System.Windows

Namespace DXSampleNotificationSevice
    Partial Public Class App
        Inherits Application

        Private Sub OnAppStartup_UpdateThemeName(ByVal sender As Object, ByVal e As StartupEventArgs)
            DevExpress.Xpf.Core.ApplicationThemeHelper.UpdateApplicationThemeName()
            DevExpress.Data.ShellHelper.TryCreateShortcut("sample_notification_app", "DXSampleNotificationSevice")
        End Sub
    End Class
End Namespace
