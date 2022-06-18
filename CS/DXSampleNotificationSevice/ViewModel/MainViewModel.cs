using System;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;

namespace DXSampleNotificationSevice.ViewModel {
    [POCOViewModel]
    public class MainViewModel {
        [ServiceProperty(Key = "ServiceWithDefaultNotifications")]
        protected virtual INotificationService DefaultNotificationService { get { return null; } }
        [ServiceProperty(Key = "ServiceWithCustomNotifications")]
        protected virtual INotificationService CustomNotificationService { get { return null; } }

        public void ShowDefaultNotification() {
            INotification notification = DefaultNotificationService.CreatePredefinedNotification("Predefined Notification", "First line", String.Format("Second line. Time: {0}", DateTime.Now), null);
            notification.ShowAsync();
        }

        public void ShowCustomNotification() {
            CustomNotificationViewModel vm = ViewModelSource.Create(() => new CustomNotificationViewModel());
            vm.Caption = "Custom Notification";
            vm.Content = String.Format("Time: {0}", DateTime.Now);
            INotification notification = CustomNotificationService.CreateCustomNotification(vm);
            notification.ShowAsync();
        }
    }
}
