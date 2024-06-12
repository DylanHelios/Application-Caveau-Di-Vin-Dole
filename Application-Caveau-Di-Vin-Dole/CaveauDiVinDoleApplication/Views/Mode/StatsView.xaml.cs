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

namespace CaveauDiVinDoleApplication.Views.Mode
{
    /// <summary>
    /// Logique d'interaction pour StatsView.xaml
    /// </summary>
    public partial class StatsView : Window
    {
        public StatsView()
        {
            InitializeComponent();
        }

        private void PreviousPage(object sender, RoutedEventArgs e)
        {
            ModeViews modeViews = new ModeViews();
            modeViews.Show();
            this.Close();
        }
    }
}
