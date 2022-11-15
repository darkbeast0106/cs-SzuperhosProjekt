namespace SzuperhosProjekt
{
    public class Batman : ISzuperhos, IMilliardos
    {
        private double lelemenyesseg;
        public Batman()
        {
            this.lelemenyesseg = 100;
        }

        public void KutyutKeszit()
        {
            this.lelemenyesseg += 50;
        }

        public bool LegyoziE(ISzuperhos szuperhos)
        {
            return szuperhos.MekkoraAzEreje() < this.lelemenyesseg;
        }

        public double MekkoraAzEreje()
        {
            return lelemenyesseg * 2;
        }

        public override string ToString()
        {
            return String.Format("Batman: leleményesség: {0}", this.lelemenyesseg);
        }
    }
}