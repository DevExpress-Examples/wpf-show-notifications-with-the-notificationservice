<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128642452/14.1.4%2B)
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
# How to: use NotificationService


This example demonstrates how to use NotificationService to show notifications. NotificationService is used in the same manner as other <a href="https://documentation.devexpress.com/#WPF/CustomDocument16926">services</a>. When the UseWin8NotificationsIfAvailable option is enabled, it's necessary to use an appropriate ApplicationId. <br>This id should be specified in the application shortcut located in the "<em>%APPDATA%\Microsoft\Windows\Start Menu\Programs"</em> directory. This is a requirement of the technology. To create a shortcut with the required application id, you can use our DevExpress.Data.ShellHelper class as shown below:<br>


```cs
DevExpress.Data.ShellHelper.TryCreateShortcut("sample_notification_app", "DXSampleNotificationSevice");
```


<p>Then, assign <em>sample_notification_app</em> to the NotificationService.ApplicationId property:</p>


```xaml
<dxmvvm:Interaction.Behaviors>
    <dxmvvm:NotificationService x:Name="ServiceWithDefaultNotifications" ApplicationId="sample_notification_app" .../>
</dxmvvm:Interaction.Behaviors>
```


<p>An advantage of native Windows 8 notifications is that thy can be shown over WinRT applications</p>
<br><br>

<br/>


