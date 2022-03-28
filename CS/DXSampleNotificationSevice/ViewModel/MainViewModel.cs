using System;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;

namespace DXSampleNotificationSevice.ViewModel {
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
            switch (result) {
                case NotificationResult.Activated:
                    CreateLogLine("Activated");
                    break;
                case NotificationResult.TimedOut:
                    CreateLogLine("Timed out");
                    break;
                case NotificationResult.UserCanceled:
                    CreateLogLine("Canceled by user");
                    break;
                case NotificationResult.Dropped:
                    CreateLogLine("Dropped (the queue is full)");
                    break;
            }
        }
        void CreateLogLine(string text) {
            System.Diagnostics.Debug.WriteLine(text);
        }
    }
}
