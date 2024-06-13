using Logic.TypesProducts;
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
using System.Windows.Shapes;

namespace CaveauDiVinDoleApplication.Views.Mode.ProductViews
{
    /// <summary>
    /// Logique d'interaction pour ProductView.xaml
    /// </summary>
    public partial class ProductView : Window
    {
        public ProductView()
        {
            InitializeComponent();
            products.ItemsSource = Enum.GetNames(typeof(EnumProducts));
        }

        private void NextStep(object sender, RoutedEventArgs e)
        {
            ComboBoxItem selectedItem = (ComboBoxItem)products.SelectedItem;

            switch (products.SelectedItem.ToString()) 
            {
                case "Alcool":
                    MessageBox.Show("Alcool");
                    break;
                case "Infusion":
                    MessageBox.Show("Infusion");
                    break;
            }

        }

        private void PreviousPage(object sender, RoutedEventArgs e)
        {
            InventoryView inventoryView = new InventoryView();
            inventoryView.Show();
            this.Close();
        }


    }
}
