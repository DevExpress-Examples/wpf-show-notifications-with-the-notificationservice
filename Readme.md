<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128642452/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T156651)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# Display Notifications in MVVM Applications Using the NotificationService

This example illustrates how you can display notifications using our [NotificationService](https://docs.devexpress.com/WPF/18138/mvvm-framework/services/predefined-set/notificationservice).

![image](https://user-images.githubusercontent.com/12169834/183671856-7988b381-fcc4-4935-aa32-2bd5139bd2e5.png)

Our `NotificationService` is used in the same manner as other [services](https://docs.devexpress.com/WPF/17414/mvvm-framework/services). When the `UseWin8NotificationsIfAvailable` option is enabled, you must use an appropriate `ApplicationId`. 

This id should be specified in the application shortcut located in the *"%APPDATA%\Microsoft\Windows\Start Menu\Programs"* directory. To create a shortcut with the required application id, you can use the `DevExpress.Data.ShellHelper` class as shown below:


```cs
DevExpress.Data.ShellHelper.TryCreateShortcut("sample_notification_app", "DXSampleNotificationSevice");
```

Once complete, assign *sample_notification_app* to the `NotificationService.ApplicationId` property:

```xaml
<dxmvvm:Interaction.Behaviors>
    <dxmvvm:NotificationService x:Name="ServiceWithDefaultNotifications" ApplicationId="sample_notification_app" .../>
</dxmvvm:Interaction.Behaviors>
```

<!-- default file list -->
## Files to Look At

* [App.xaml.cs](./CS/DXSampleNotificationSevice/App.xaml.cs)
* **[MainView.xaml](./CS/DXSampleNotificationSevice/View/MainView.xaml) (VB: [MainView.xaml](./VB/DXSampleNotificationSevice/View/MainView.xaml))**
* [MainView.xaml.cs](./CS/DXSampleNotificationSevice/View/MainView.xaml.cs) (VB: [MainView.xaml.vb](./VB/DXSampleNotificationSevice/View/MainView.xaml.vb))
* [CustomNotificationViewModel.cs](./CS/DXSampleNotificationSevice/ViewModel/CustomNotificationViewModel.cs) (VB: [CustomNotificationViewModel.vb](./VB/DXSampleNotificationSevice/ViewModel/CustomNotificationViewModel.vb))
* [MainViewModel.cs](./CS/DXSampleNotificationSevice/ViewModel/MainViewModel.cs) (VB: [MainViewModel.vb](./VB/DXSampleNotificationSevice/ViewModel/MainViewModel.vb))
<!-- default file list end -->

## Documentation

* [Notification Service](https://docs.devexpress.com/WPF/18138/mvvm-framework/services/predefined-set/notificationservice)
* [UI Services](https://docs.devexpress.com/WPF/17414/mvvm-framework/services)

## More Examples

* [WPF NotificationService - Create Interactive Notifications](https://github.com/DevExpress-Examples/wpf-notificationservice-create-interactive-notifications)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-display-notifications-using-the-notificationservice&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-display-notifications-using-the-notificationservice&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
