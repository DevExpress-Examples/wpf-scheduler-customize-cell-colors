using System;
using System.Windows.Media;
using DevExpress.Mvvm;

namespace DXSample.ViewModels {
    public class ResourceViewModel : ViewModelBase {
        public int Id {
            get { return GetValue<int>(); }
            set { SetValue(value); }
        }
        public string Caption {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }
        public SolidColorBrush Brush {
            get { return GetValue<SolidColorBrush>(); }
            set { SetValue(value); }
        }
    }
}