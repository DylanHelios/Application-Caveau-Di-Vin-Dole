using Logic;
using Logic.TypesProducts;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace CaveauDiVinDoleApplication.ViewsModel
{
    public class ProductViewModel : INotifyPropertyChanged
    {
        #region attributs 

        private string selectedOption;
        private Product product;
        private readonly ObservableCollection<string> options;

        #endregion

        #region Property

        /// <summary>
        /// The choice selected in the combobox
        /// </summary>
        public string SelectedOption
        {
            get 
            { 
                return selectedOption; 
            }
            set
            {
                if (selectedOption != value)
                {
                    selectedOption = value;
                    OnPropertyChanged(nameof(SelectedOption));
                }
            }
        }

        /// <summary>
        /// Binding liste for product type
        /// </summary>
        public ObservableCollection<string> Options
        {
            get
            {
                return options;
            }
        }

        /// <summary>
        /// The name product
        /// </summary>
        public string ProductName
        {
            get 
            {
                return this.product.Name ;
            }
            set
            {
                this.product.Name = value;
                OnPropertyChanged(nameof(ProductName));
            }
        }

        /// <summary>
        /// The region where comes from the product
        /// </summary>
        public string Region
        {
            get 
            { 
                return this.product.Region; 
            }
            set 
            {
                this.product.Region = value; 
                OnPropertyChanged(); 
            }
        }

        /// <summary>
        /// The country where comes from the product
        /// </summary>
        public string Country
        {
            get 
            { 
                return this.product.Country; 
            }
            set 
            { 
                this.product.Country = value; 
                OnPropertyChanged(); 
            }
        }

        /// <summary>
        /// Price with taxes
        /// </summary>
        public decimal PriceVAT
        {
            get 
            { 
                return this.product.PriceVAT; 
            }
            set 
            {
                this.product.PriceVAT = value; 
                OnPropertyChanged(); 
            }
        }

        /// <summary>
        /// The Pourcentage of the taxe
        /// </summary>
        public decimal TaxePourcentage
        {
            get 
            { 
                return this.product.TaxePourcentage; 
            }
            set 
            {
                this.product.TaxePourcentage = value; 
                OnPropertyChanged(); 
            }
        }

        /// <summary>
        /// Price excluding taxes
        /// </summary>
        public decimal PriceET
        {
            get 
            { 
                return this.product.PriceET; 
            }
            set 
            {
                this.product.PriceET = value; 
                OnPropertyChanged(); 
            }
        }

        /// <summary>
        /// The number of product in stock
        /// </summary>
        public long NumberInStock
        {
            get 
            { 
                return this.product.NumberInStock; 
            }
            set 
            {
                this.product.NumberInStock = value; 
                OnPropertyChanged(); 
            }
        }

        #endregion

        #region Constructor    

        /// <summary>
        /// Constructor of the ViewModel
        /// </summary>
        public ProductViewModel(Product? product)
        {
            if (product != null)
            {
                this.product = product;
            }
            else
            {
                this.product = new Product();
            }

            options = new ObservableCollection<string>(Enum.GetNames(typeof(EnumProducts)));
            SelectedOption = options[0];
        }

        #endregion

        #region PropertyChanged

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        #endregion

    }
}
