using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class MainWindow : Window
    {
        public int Month;
        public MainWindow()
        {
            InitializeComponent();
            
            Month = DateTime.Today.Month;
            CurrentMonth();
        }

        private void CurrentMonth()
        {
            switch (Month)
            {
                case 1:
                    TextBox.Text = "Январь";
                    PageFrame.Content = new Page1();
                    break;
                case 2:
                    TextBox.Text = "Февраль";
                    PageFrame.Content = new Page2();
                    break;
                case 3:
                    TextBox.Text = "Март";
                    PageFrame.Content = new Page3();
                    break;
                case 4:
                    TextBox.Text = "Апрель";
                    PageFrame.Content = new Page4();
                    break;
                case 5:
                    TextBox.Text = "Май";
                    PageFrame.Content = new Page5();
                    break;
                case 6:
                    TextBox.Text = "Июнь";
                    PageFrame.Content = new Page6();
                    break;
                case 7:
                    TextBox.Text = "Июль";
                    PageFrame.Content = new Page7();
                    break;
                case 8:
                    TextBox.Text = "Август";
                    PageFrame.Content = new Page8();
                    break;
                case 9:
                    TextBox.Text = "Сентябрь";
                    PageFrame.Content = new Page9();
                    break;
                case 10:
                    TextBox.Text = "Октябрь";
                    PageFrame.Content = new Page10();
                    break;
                case 11:
                    TextBox.Text = "Ноябрь";
                    PageFrame.Content = new Page11();
                    break;
                case 12:
                    TextBox.Text = "Декабрь";
                    PageFrame.Content = new Page12();
                    break;

            }
        }

        private void ButtonLeft_OnClick(object sender, RoutedEventArgs e)
        {
            Month -= 1;
            Month = Month == 0 ? 12 : Month;
            CurrentMonth();
        }

        private void ButtonRight_OnClick(object sender, RoutedEventArgs e)
        {
            Month += 1;
            Month = Month == 13 ? 1 : Month;
            CurrentMonth();
        }


        private void DatePicker_OnSelectedDateChanged(object? sender, SelectionChangedEventArgs e)
        {
            Month = DatePicker.SelectedDate.Value.Month;
            CurrentMonth();
        }
    }
}
