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
using Wpf.Ui.Common;

namespace cld
{
    /// <summary>
    /// Логика взаимодействия для DrinksPage.xaml
    /// </summary>
    public partial class DrinksPage : Page
    {
        public DrinksPage()
        {
            InitializeComponent();

            ActionUserControl tea = new ActionUserControl();
            tea.ChosenIcon.Symbol = SymbolRegular.DrinkCoffee20;
            tea.DrinkBox.Text = "Чай";
            tea.Width = 600;
            tea.Height = 60;
            tea.Margin = new Thickness(5);

            ActionUserControl coffee = new ActionUserControl();
            coffee.ChosenIcon.Symbol = SymbolRegular.DrinkToGo20;
            coffee.DrinkBox.Text = "Кофе";
            coffee.Width = 600;
            coffee.Height = 60;
            coffee.Margin = new Thickness(5);

            ActionUserControl beer = new ActionUserControl();
            beer.ChosenIcon.Symbol = SymbolRegular.DrinkBeer20;
            beer.DrinkBox.Text = "Пиво";
            beer.Width = 600;
            beer.Height = 60;
            beer.Margin = new Thickness(5);

            ActionUserControl energy = new ActionUserControl();
            energy.ChosenIcon.Symbol = SymbolRegular.DrinkBottle20;
            energy.DrinkBox.Text = "Энергос";
            energy.Width = 600;
            energy.Height = 60;
            energy.Margin = new Thickness(5);

            ActionUserControl wine = new ActionUserControl();
            wine.ChosenIcon.Symbol = SymbolRegular.DrinkWine20;
            wine.DrinkBox.Text = "Вино";
            wine.Width = 600;
            wine.Height = 60;
            wine.Margin = new Thickness(5);

            ActionUserControl cocktail = new ActionUserControl();
            cocktail.ChosenIcon.Symbol = SymbolRegular.DrinkMargarita20;
            cocktail.DrinkBox.Text = "Коктейль";
            cocktail.Width = 600;
            cocktail.Height = 60;
            cocktail.Margin = new Thickness(5);

            Wrap.Orientation = Orientation.Vertical;
            Wrap.Children.Add(tea);
            Wrap.Children.Add(coffee);
            Wrap.Children.Add(energy);
            Wrap.Children.Add(beer);
            Wrap.Children.Add(wine);
            Wrap.Children.Add(cocktail);
        }
    }
}
