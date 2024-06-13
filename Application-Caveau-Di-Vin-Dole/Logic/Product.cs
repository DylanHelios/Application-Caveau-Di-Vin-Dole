using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public abstract class Product 
    {
        #region Attributes

        private int id_Product;
        private string country;
        private string region;
        private string name;
        private string description_;
        private decimal price_VAT;
        private decimal price_ET;
        private long nb_Stock;

        #endregion


    }

}

