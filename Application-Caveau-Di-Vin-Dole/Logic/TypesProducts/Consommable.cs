using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.TypesProducts
{
    public abstract class Consommable : Product
    {
        #region Attributes
        private bool pdo;
        private bool pgi;
        private bool organic;
        private bool demeter;
        private bool vegetarian;
        private bool vegan;
        private string allergens;
        private string medals;
        private string flavor;
        private string preservation;
        private DateTime expiry_Date;
        private decimal price_weight;
        #endregion

        #region Properties
        public bool PDO
        {
            get { return pdo; }
            set { pdo = value; }
        }

        public bool PGI
        {
            get { return pgi; }
            set { pgi = value; }
        }

        public bool Organic
        {
            get { return organic; }
            set { organic = value; }
        }

        public bool Demeter
        {
            get { return demeter; }
            set { demeter = value; }
        }

        public bool Vegetarian
        {
            get { return vegetarian; }
            set { vegetarian = value; }
        }

        public bool Vegan
        {
            get { return vegan; }
            set { vegan = value; }
        }

        public string Allergens
        {
            get { return allergens; }
            set { allergens = value; }
        }

        public string Medals
        {
            get { return medals; }
            set { medals = value; }
        }

        public string Flavor
        {
            get { return flavor; }
            set { flavor = value; }
        }

        public string Preservation
        {
            get { return preservation; }
            set { preservation = value; }
        }

        public DateTime Expiry_Date
        {
            get { return expiry_Date; }
            set { expiry_Date = value; }
        }

        public decimal Price_weight
        {
            get { return price_weight; }
            set { price_weight = value; }
        }
        #endregion


    }
}
