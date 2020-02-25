using System;
using DevExpress.Mvvm;

namespace DXSample.ViewModels {
    public class AppointmentViewModel : ViewModelBase {
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
        public string Subject {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }
        public int ResourceId {
            get { return GetValue<int>(); }
            set { SetValue(value); }
        }
    }
}