using DevExpress.Mvvm.DataAnnotations;

namespace DXSampleNotificationSevice.ViewModel {
    [POCOViewModel]
    public class CustomNotificationViewModel {
        public virtual string Caption { get; set; }
        public virtual string Content { get; set; }
    }
}
