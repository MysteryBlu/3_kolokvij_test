using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_kolokvij
{
    class Sastojak
    {
        protected double volumen;
        protected string opis;
        protected double porcija;
        public double VratiDecilitre()
        {
            return volumen;
        }

        public virtual string Prikazi()
        {
            return String.Format("Sastojak nepoznat");
        }
    }
}
