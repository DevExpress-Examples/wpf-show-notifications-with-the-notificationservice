Imports System
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.Mvvm.POCO

Namespace DXSampleNotificationSevice.ViewModel
    <POCOViewModel> _
    Public Class MainViewModel
        <ServiceProperty(Key := "ServiceWithDefaultNotifications")> _
        Protected Overridable ReadOnly Property DefaultNotificationService() As INotificationService
            Get
                Return Nothing
            End Get
        End Property
        <ServiceProperty(Key := "ServiceWithCustomNotifications")> _
        Protected Overridable ReadOnly Property CustomNotificationService() As INotificationService
            Get
                Return Nothing
            End Get
        End Property

        Public Sub ShowDefaultNotification()
            Dim notification As INotification = DefaultNotificationService.CreatePredefinedNotification("Predefined Notification", "First line", String.Format("Second line. Time: {0}", Date.Now), Nothing)
            notification.ShowAsync()
        End Sub

        Public Sub ShowCustomNotification()
            Dim vm As CustomNotificationViewModel = ViewModelSource.Create(Function() New CustomNotificationViewModel())
            vm.Caption = "Custom Notification"
            vm.Content = String.Format("Time: {0}", Date.Now)
            Dim notification As INotification = CustomNotificationService.CreateCustomNotification(vm)
            notification.ShowAsync()
        End Sub
    End Class
End Namespace
