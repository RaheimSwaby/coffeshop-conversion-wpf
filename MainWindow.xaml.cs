using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace coffeshop_conversion
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Datasource.CreateData();
            BeveragesDataGrid.ItemsSource = Datasource.Beverages;

        }

        private void BeveragesDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void RemoveCoffeeButton_Click(object sender, RoutedEventArgs e)
        {
            var selectedCoffee = (Coffee)BeveragesDataGrid.SelectedItem;

            if (selectedCoffee != null)
            {
                Datasource.Beverages.Remove(selectedCoffee); // to remove selected coffee
                BeveragesDataGrid.Items.Refresh();
            }
            else
            {
                MessageBox.Show("Please select a coffee to remove","No selection", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void AddCoffeeButton_Click(object sender, RoutedEventArgs e)
        {
            var newcoffee = new Coffee
            {
                name = "New Coffee",
                Size = "Medium",
                BrewStrength = BrewStrength.Strong,
                Roast = Roast.Medium,
                Temp = Temp.Hot,
                InStock = true,
                BeveragePrice = 3.99,
                Ordername = Datasource.Beverages.Count + 1
            };
            Datasource.Beverages.Add(newcoffee);
            BeveragesDataGrid.Items.Refresh();
        }
    }
}