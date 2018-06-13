using CustomCellColoring.Model;
using DevExpress.Mvvm.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace CustomCellColoring.ViewModels
{
    [POCOViewModel]
    public class MyViewModel
    {
        public virtual ObservableCollection<MyCategory> Categories { get; set; }
        protected MyViewModel()
        {
            Categories = CreateCategories();
            UseCustomCellControlStyle = true;
            UseResourceBrushSchema = true;
            UseResourceColors = true;
        }

        #region #CreateCategories
        private ObservableCollection<MyCategory> CreateCategories()
        {
            ObservableCollection<MyCategory> result = new ObservableCollection<MyCategory>();
            result.Add(MyCategory.Create(0, "White category", Colors.White));
            result.Add(MyCategory.Create(1, "Orange category", Colors.Orange));
            result.Add(MyCategory.Create(2, "Red category", Colors.Red));
            return result;
        }
        #endregion #CreateCategories

        public virtual bool UseResourceBrushSchema { get; set; }
        public virtual bool UseResourceColors { get; set; }
        public virtual bool UseCustomCellControlStyle { get; set; }
    }
}
