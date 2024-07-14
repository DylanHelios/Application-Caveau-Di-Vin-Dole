using CaveauDiVinDoleApplication.Views.Mode.ProductForms;
using System.Windows;

namespace CaveauDiVinDoleApplication.Views.Mode
{
    /// <summary>
    /// Logique d'interaction pour InventoryView.xaml
    /// </summary>
    public partial class InventoryView : Window
    {
        public InventoryView()
        {
            InitializeComponent();
        }

        private void PreviousPage(object sender, RoutedEventArgs e)
        {
            ModeViews modeViews = new ModeViews();
            modeViews.Show();
            this.Close();
        }

        private void AddProduct(object sender, RoutedEventArgs e)
        {
            ProductView productView = new ProductView(null);
            productView.Show();
            this.Close();
        }

        private void ModifyProduct(object sender, RoutedEventArgs e)
        {
            /// todo
        }
    }
}
