using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Product 
    {
        #region Attributes
        private int idProduct;
        private string country;
        private string region;
        private string name;
        private string description;
        private decimal priceVAT;
        private decimal priceET;
        private decimal taxePourcentage;
        private long numberInStock;

        #endregion

        #region Properties
        public int IdProduct
        {
            get { return idProduct; }
            set { idProduct = value; }
        }

        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        public string Region
        {
            get { return region; }
            set { region = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public decimal PriceVAT
        {
            get { return priceVAT; }
            set { priceVAT = value; }
        }

        public decimal PriceET
        {
            get { return priceET; }
            set { priceET = value; }
        }

        public long NumberInStock
        {
            get { return numberInStock; }
            set { numberInStock = value; }
        }

        public decimal TaxePourcentage
        {
            get { return taxePourcentage; }
            set { taxePourcentage = value; }
        }
        #endregion

        #region Constructor 

        /// <summary>
        /// The constructor of the product
        /// </summary>
        public Product()
        {
            this.Name = string.Empty;
            this.Country = string.Empty;
            this.Region = string.Empty;
            this.Description = string.Empty;
            this.PriceVAT = 0;
            this.PriceET = 0;
            this.TaxePourcentage = 0;
            this.NumberInStock = 0;
        }


        #endregion



    }

}

