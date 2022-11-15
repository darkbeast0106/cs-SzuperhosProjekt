using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzuperhosProjekt
{
    public abstract class Bosszuallo : ISzuperhos
    {
        private double szuperero;
        private bool vanEGyengesege;

        protected Bosszuallo(double szuperero, bool vanEGyengesege)
        {
            this.szuperero = szuperero;
            this.vanEGyengesege = vanEGyengesege;
        }

        public double Szuperero { get => szuperero; set => szuperero = value; }
        public bool VanEGyengesege { get => vanEGyengesege; set => vanEGyengesege = value; }

        public bool LegyoziE(ISzuperhos szuperhos)
        {
            bool legyoziE = false;
            if (szuperhos is Bosszuallo bosszuallo)
            {
                if (bosszuallo.vanEGyengesege && 
                    bosszuallo.MekkoraAzEreje() < this.MekkoraAzEreje())
                {
                    legyoziE = true;
                }
            }
            else if (szuperhos is Batman)
            {
                if (szuperhos.MekkoraAzEreje() * 2 <= this.MekkoraAzEreje())
                {
                    legyoziE = true;
                }
            }

            return legyoziE;
        }

        public abstract bool MegmentiAVilagot();

        public double MekkoraAzEreje()
        {
            return this.szuperero;
        }

        public override string ToString()
        {
            return String.Format("Szupererő: {0}, {1} gyengesége",
                this.szuperero, this.VanEGyengesege ? "van" : "nincs");
        }
    }
}
