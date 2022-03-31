<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128642452/21.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T156651)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [App.xaml.cs](./CS/DXSampleNotificationSevice/App.xaml.cs)
* **[MainView.xaml](./CS/DXSampleNotificationSevice/View/MainView.xaml) (VB: [MainView.xaml](./VB/DXSampleNotificationSevice/View/MainView.xaml))**
* [MainView.xaml.cs](./CS/DXSampleNotificationSevice/View/MainView.xaml.cs) (VB: [MainView.xaml.vb](./VB/DXSampleNotificationSevice/View/MainView.xaml.vb))
* [CustomNotificationViewModel.cs](./CS/DXSampleNotificationSevice/ViewModel/CustomNotificationViewModel.cs) (VB: [CustomNotificationViewModel.vb](./VB/DXSampleNotificationSevice/ViewModel/CustomNotificationViewModel.vb))
* [MainViewModel.cs](./CS/DXSampleNotificationSevice/ViewModel/MainViewModel.cs) (VB: [MainViewModel.vb](./VB/DXSampleNotificationSevice/ViewModel/MainViewModel.vb))
<!-- default file list end -->
# How To: Use NotificationService to Create Custom Notifications


This example demonstrates how to use [NotificationService](https://docs.devexpress.com/WPF/18138/mvvm-framework/services/predefined-set/notificationservice) to create a custom notification that does not depend on the Windows 10/11 notification API.

Use the **NotificationService.CustomNotificationTemplate** property to define a custom notification layout.

```xaml
<DataTemplate x:Key="CustomNotificationTemplate">
    <Border Background="White" BorderThickness="1" BorderBrush="Black">
        <StackPanel Orientation="Vertical" HorizontalAlignment="Stretch" VerticalAlignment="Stretch">
            <TextBlock HorizontalAlignment="Left" Text="{Binding Caption}" Foreground="Blue" FontSize="20" Margin="5"/>
            <TextBlock HorizontalAlignment="Center" Text="{Binding Content}" Foreground="Black" FontSize="16" Margin="3"/>
        </StackPanel>
    </Border>
</DataTemplate>
```
To create a custom notification, use the **NotificationService.CreateCustomNotification** method. This method requires a notification’s View Model as a parameter.

```cs
[POCOViewModel]
public class MainViewModel {
    protected virtual INotificationService CustomNotificationService { get { return null; } }
    public async void ShowCustomNotification() {
        CustomNotificationViewModel vm = ViewModelSource.Create(() => new CustomNotificationViewModel());
        vm.Caption = "Custom Notification";
        vm.Content = String.Format("Time: {0}", DateTime.Now);
        INotification notification = CustomNotificationService.CreateCustomNotification(vm);
        NotificationResult result = await notification.ShowAsync();
        ProcessNotificationResult(result);
    }
    void ProcessNotificationResult(NotificationResult result) {
        ...
    }
    ...
}
```

<br/>
