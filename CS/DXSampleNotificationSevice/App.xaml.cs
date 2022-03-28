using System.Windows;

namespace DXSampleNotificationSevice {
    public partial class App : Application {
        protected override void OnStartup(StartupEventArgs e) {
            DevExpress.Data.ShellHelper.TryCreateShortcut("sample_notification_app", "DXSampleNotificationSevice");
            base.OnStartup(e);
        }
    }
}
