using Logic.TypesProducts.Consommables.TypeConsommables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.TypesProducts.Consommables
{
    public class Saucisson : Consommable
    {
        #region Attributes
        private EnumSaucisson type_Saucisson;
        private string meat;
        #endregion

        #region Properties
        /// <summary>
        /// Types of the saucissons exp : Sec, noix, noisette, ...
        /// </summary>
        public EnumSaucisson Type_Saucisson
        {
            get { return type_Saucisson; }
            set { type_Saucisson = value; }
        }

        /// <summary>
        /// The meat of the saucisson
        /// </summary>
        public string Meat
        {
            get { return meat; }
            set { meat = value; }
        }
        #endregion
    }
}
