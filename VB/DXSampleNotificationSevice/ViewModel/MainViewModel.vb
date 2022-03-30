Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.Mvvm.POCO

Namespace DXSampleNotificationSevice.ViewModel

    <POCOViewModel>
    Public Class MainViewModel

        Protected Overridable ReadOnly Property CustomNotificationService As INotificationService
            Get
                Return Nothing
            End Get
        End Property

        Public Async Sub ShowCustomNotification()
            Dim vm As CustomNotificationViewModel = ViewModelSource.Create(Function() New CustomNotificationViewModel())
            vm.Caption = "Custom Notification"
            vm.Content = String.Format("Time: {0}", Date.Now)
            Dim notification As INotification = CustomNotificationService.CreateCustomNotification(vm)
            Dim result As NotificationResult = Await notification.ShowAsync()
            ProcessNotificationResult(result)
        End Sub

        Private Sub ProcessNotificationResult(ByVal result As NotificationResult)
            Select Case result
                Case NotificationResult.Activated
                    CreateLogLine("Activated")
                Case NotificationResult.TimedOut
                    CreateLogLine("Timed out")
                Case NotificationResult.UserCanceled
                    CreateLogLine("Canceled by user")
                Case NotificationResult.Dropped
                    CreateLogLine("Dropped (the queue is full)")
            End Select
        End Sub

        Private Sub CreateLogLine(ByVal text As String)
            System.Diagnostics.Debug.WriteLine(text)
        End Sub
    End Class
End Namespace
