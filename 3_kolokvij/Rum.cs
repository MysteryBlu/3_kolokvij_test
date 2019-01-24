using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_kolokvij
{
    class Rum : Sastojak
    {
        public Rum(double volumen, string opis)
        {
            this.volumen = volumen;
            this.opis = "ruma " + opis;
            //porcija = 1;
        }

        public override string Prikazi()
        {
            return String.Format("{0}dcl {1}", VratiDecilitre()/*volumen(?)*/, opis);
        }
    }
}
