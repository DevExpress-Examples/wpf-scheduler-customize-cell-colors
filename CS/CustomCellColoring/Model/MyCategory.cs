using DevExpress.Mvvm.POCO;
using System.Windows.Media;

namespace CustomCellColoring.Model
{
    public class MyCategory
        {
            protected MyCategory(int id, string name, Color color)
            {
                Id = id;
                Name = name;
                ColorInfo = color;
            }
            public static MyCategory Create(int id, string name, Color color)
            {
                return ViewModelSource.Create(() => new MyCategory(id, name, color));
            }

            protected MyCategory() { }

            public virtual int Id { get; set; }
            public virtual string Name { get; set; }
            public virtual Color ColorInfo { get; set; }
        }
}
