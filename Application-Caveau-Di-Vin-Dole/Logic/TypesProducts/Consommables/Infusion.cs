using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.TypesProducts.Consommables
{
    public class Infusion : Consommable
    {
        #region Attributes
        private string infusion_Type;
        private string type;
        private string roasting;
        private int bitterness;
        private int sweet;
        private int acidulous;
        private int well_Seasoned;
        private int aromatic;
        private int intensity;
        #endregion

        #region Properties
        public string Infusion_Type
        {
            get { return infusion_Type; }
            set { infusion_Type = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public string Roasting
        {
            get { return roasting; }
            set { roasting = value; }
        }

        public int Bitterness
        {
            get { return bitterness; }
            set { bitterness = value; }
        }

        public int Sweet
        {
            get { return sweet; }
            set { sweet = value; }
        }

        public int Acidulous
        {
            get { return acidulous; }
            set { acidulous = value; }
        }

        public int Well_Seasoned
        {
            get { return well_Seasoned; }
            set { well_Seasoned = value; }
        }

        public int Aromatic
        {
            get { return aromatic; }
            set { aromatic = value; }
        }

        public int Intensity
        {
            get { return intensity; }
            set { intensity = value; }
        }
        #endregion
        
    }
}
