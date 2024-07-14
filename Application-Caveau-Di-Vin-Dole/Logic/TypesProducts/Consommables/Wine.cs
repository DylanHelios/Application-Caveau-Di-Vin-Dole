using Logic.TypesProducts.Consommables.TypeConsommables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.TypesProducts.Consommables
{
    public class Wine : Consommable
    {
        #region Attributes
        private EnumWine type;
        private string cépage;
        private decimal proof;
        private string domaine;
        private string aromes;
        private decimal volume;
        #endregion

        #region Properties

        /// <summary>
        /// The type of the wine, red, orange, yellow, white, ...
        /// </summary>
        public EnumWine Type
        {
            get { return type; }
            set { type = value; }
        }

        /// <summary>
        /// Cépage of the wine
        /// </summary>
        public string Cépage
        {
            get { return cépage; }
            set { cépage = value; }
        }

        /// <summary>
        /// The proof of the wine, exp : 17.5 , 14, 12, ...
        /// </summary>
        public decimal Proof
        {
            get { return proof; }
            set { proof = value; }
        }

        /// <summary>
        /// The domaine of the wine
        /// </summary>
        public string Domaine
        {
            get { return domaine; }
            set { domaine = value; }
        }

        /// <summary>
        /// Aromes of the wines
        /// </summary>
        public string Aromes
        {
            get { return aromes; }
            set { aromes = value; }
        }

        /// <summary>
        /// The volume inside the bottle exp : 1 , 0.75, 3
        /// </summary>
        public decimal Volume
        {
            get { return volume; }
            set { volume = value; }
        }
        #endregion
    }
}
