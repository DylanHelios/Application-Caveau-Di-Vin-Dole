using CaveauDiVinDoleApplication.Views.Mode.ProductForms.ConsommablesViews;
using CaveauDiVinDoleApplication.Views.Mode.ProductForms.VisagesViews;
using CaveauDiVinDoleApplication.ViewsModel;
using Logic.TypesProducts.Consommables;
using Logic.TypesProducts;
using System.Windows;
using Logic;

namespace CaveauDiVinDoleApplication.Views.Mode.ProductForms
{
    /// <summary>
    /// Logique d'interaction pour ProductView.xaml
    /// </summary>
    public partial class ProductView : Window
    {
        #region Property

        private ProductViewModel productViewModel;

        #endregion

        public ProductView(Product? product)
        {
            InitializeComponent();
            productViewModel = new ProductViewModel(product);
            DataContext = productViewModel;
        }

        private void NextStep(object sender, RoutedEventArgs e)
        {
            switch (productViewModel.SelectedOption)
            {
                case "Alcool":
                    Wine wine = new Wine();
                    CallConsommableView(wine);
                    break;
                case "Infusion":
                    Infusion infusion = new Infusion();
                    CallConsommableView(infusion);
                    break;
                case "Saucisson":
                    Saucisson saucisson = new Saucisson();
                    CallConsommableView(saucisson);
                    break;
                case "Visage":
                    CallVisageView();
                    break;
            }

            ///ERREUR TODO
            this.Close();

        }

        #region WindowCall

        private void PreviousPage(object sender, RoutedEventArgs e)
        {
            InventoryView inventoryView = new InventoryView();
            inventoryView.Show();
            this.Close();
        }

        private void CallConsommableView(Consommable consommable)
        {
            ConsommableView consommableView = new ConsommableView(consommable);
            consommableView.Show();
        }

        private void CallVisageView()
        {
            VisageView visageView = new VisageView();
            visageView.Show();
        }

        #endregion
    }
}
