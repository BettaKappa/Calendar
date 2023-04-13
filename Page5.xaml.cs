using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace cld
{
    /// <summary>
    /// Логика взаимодействия для Page5.xaml
    /// </summary>
    public partial class Page5 : Page
    {
        public Page5()
        {
            InitializeComponent();

            int year = DateTime.Today.Year;
            int days = DateTime.DaysInMonth(year, 5);

            SolidColorBrush brush = new SolidColorBrush(Color.FromArgb(255, 66, 65, 65));

            for (int i = 1; i < days + 1; i++)
            {
                DayCardUserControl DayCard = new DayCardUserControl();
                DayCard.Width = 80;
                DayCard.Height = 80;
                DayCard.DateLbl.Content = i;
                DayCard.Margin = new Thickness(2);
                Border myBorder = new Border();
                myBorder.Background = brush;
                myBorder.Child = DayCard;
                myBorder.Margin = new Thickness(3);
                myBorder.CornerRadius = new CornerRadius(5);
                WrapPanel.Children.Add(myBorder);
            }
        }
    }
}
