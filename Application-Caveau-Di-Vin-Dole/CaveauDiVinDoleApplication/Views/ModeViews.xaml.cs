using CaveauDiVinDoleApplication.Views.Mode;
using System.Windows;

namespace CaveauDiVinDoleApplication.Views
{
    /// <summary>
    /// Logique d'interaction pour ModeViews.xaml
    /// </summary>
    public partial class ModeViews : Window
    {
        public ModeViews()
        {
            InitializeComponent();
        }

        private void InventoryPage(object sender, RoutedEventArgs e)
        {
            InventoryView inventoryView = new InventoryView();
            inventoryView.Show();
            this.Close();

        }

        private void CashierPage(object sender, RoutedEventArgs e)
        {
            CashierView cashierView = new CashierView();
            cashierView.Show();
        }

        private void StatsPage(object sender, RoutedEventArgs e)
        {
            StatsView statsView = new StatsView();
            statsView.Show();   
            this.Close();
        }
    }
}
