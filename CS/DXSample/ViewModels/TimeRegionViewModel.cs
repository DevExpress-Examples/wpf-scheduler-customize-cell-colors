using System;
using System.Windows.Media;
using DevExpress.Mvvm;

namespace DXSample.ViewModels {
    public class TimeRegionViewModel : ViewModelBase {
        public int Id {
            get { return GetValue<int>(); }
            set { SetValue(value); }
        }
        public DateTime StartTime {
            get { return GetValue<DateTime>(); }
            set { SetValue(value); }
        }
        public DateTime EndTime {
            get { return GetValue<DateTime>(); }
            set { SetValue(value); }
        }
        public SolidColorBrush Brush {
            get { return GetValue<SolidColorBrush>(); }
            set { SetValue(value); }
        }
        public int ResourceId {
            get { return GetValue<int>(); }
            set { SetValue(value); }
        }
    }
}