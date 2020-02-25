using System.Collections.ObjectModel;
using DevExpress.Mvvm;

namespace DXSample.ViewModels {
    public class SchedulingViewModel : ViewModelBase {
        public SchedulingViewModel() {
            Appointments = DataHelper.GetAppointments();
            Resources = DataHelper.GetResources();
            TimeRegions = DataHelper.GetTimeRegions();
        }
        public ObservableCollection<AppointmentViewModel> Appointments {
            get { return GetValue<ObservableCollection<AppointmentViewModel>>(); }
            set { SetValue(value); }
        }
        public ObservableCollection<ResourceViewModel> Resources {
            get { return GetValue<ObservableCollection<ResourceViewModel>>(); }
            set { SetValue(value); }
        }
        public ObservableCollection<TimeRegionViewModel> TimeRegions {
            get { return GetValue<ObservableCollection<TimeRegionViewModel>>(); }
            set { SetValue(value); }
        }
    }
}