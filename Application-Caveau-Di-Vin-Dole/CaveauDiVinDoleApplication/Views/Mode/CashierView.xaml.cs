using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CaveauDiVinDoleApplication.Views.Mode
{
    /// <summary>
    /// Logique d'interaction pour CashierView.xaml
    /// </summary>
    public partial class CashierView : Window
    {
        public CashierView()
        {
            InitializeComponent();
        }

        private void AddProduct(object sender, RoutedEventArgs e)
        {

        }

        private void RemoveProduct(object sender, RoutedEventArgs e)
        {

        }

        private void PreviousPage(object sender, RoutedEventArgs e)
        {
            MessageBoxResult resultPopUp = MessageBox.Show("Est-ce que vous êtes sure de vouloir revenir à la page précedente", "Oui", MessageBoxButton.YesNo,MessageBoxImage.Question);

            if (resultPopUp == MessageBoxResult.Yes) 
            {
                this.Close();
            }
        }

        private void FinishCommand(object sender, RoutedEventArgs e)
        {

        }


    }
}
