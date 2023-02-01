using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Prog_124_W23_Lecture_9_Abstract
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Observable Collection()
        ObservableCollection<Product> products = new ObservableCollection<Product>();
        ObservableCollection<Drink> drinks = new ObservableCollection<Drink>();

        public MainWindow()
        {
            InitializeComponent();
            Preload();
 

            // To attach an ObservableCollection to a Selection Box
            // Attach it to the ItemsSource
            lbDisplay.ItemsSource = products;

            
        }
        // Cold Brew
        // Butter Crossiant
        // Tourist Mug 1
        // Vente Latte
        void Preload()
        {
            products.Add(new ColdDrink("Cold Brew", 4.00m, "12344", Drink.Size.Venti, false));
            products.Add(new BakedGood("Butter Crossiant", 2.99m, "12334574", "02/18/2023"));
            products.Add(new Merchandise("Travel Mug 1", 16.00m, "1231234", Merchandise.Color.BlueBlue));
            products.Add(new HotDrink("Latte", 7.00m, "1236576744", Drink.Size.Tall, 178.7));
       
            

            drinks.Add(new HotDrink("Latte", 7.00m, "1236576744", Drink.Size.Venti, 178.7));

            
        }

        private void btnAddProduct_Click(object sender, RoutedEventArgs e)
        {
            // Adds a product to our observable collection

            //   Can you create a new instance of an abstract class?
            // I cannot create a new INSTANCE of an abstract object
            //products.Add(new Product("1", 1, "1"));




            // Calling this updates the data on the listbox
            lbDisplay.Items.Refresh();

        } // btnAddProduct_Click
    }
}
