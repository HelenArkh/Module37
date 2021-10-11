using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Home_App.Pages
{
    public partial class GridPage : ContentPage
    {
       
        public GridPage()
        {

            //PopulateGrid();
        }

        /// <summary>
        ///  Заполнение лейаута
        /// </summary>
        public void PopulateGrid(Grid grid)
        {
            // Добавление элементов по определенным позициям
            grid.Children.Add(new BoxView { Color = Color.FromRgb(250, 253, 255) }, 0 /* Позиция слева */, 0 /* Позиция сверху */);

            // Сохраняем элемент перед добавлением, чтобы потом модифицировать
            var mergedRow = new BoxView { Color = Color.FromRgb(196, 232, 255) };
            // Добавляем в Grid
            grid.Children.Add(mergedRow, 0, 1);
            // Устанавливаем свойство ColumnSpan, чтобы расширить элемент на 3 позиции
            Grid.SetColumnSpan(mergedRow, 3);

            grid.Children.Add(new BoxView { Color = Color.FromRgb(133, 207, 255) }, 0, 2);

            grid.Children.Add(new BoxView { Color = Color.FromRgb(87, 189, 255) }, 1, 0);
            // grid.Children.Add(new BoxView { Color = Color.FromRgb(43, 172, 255) }, 1, 1);
            grid.Children.Add(new BoxView { Color = Color.FromRgb(23, 164, 255) }, 1, 2);

            grid.Children.Add(new BoxView { Color = Color.FromRgb(0, 121, 199) }, 2, 0);
            // grid.Children.Add(new BoxView { Color = Color.FromRgb(0, 76, 199) }, 2, 1);
            grid.Children.Add(new BoxView { Color = Color.FromRgb(0, 76, 199) }, 2, 2);
        }
    }
}