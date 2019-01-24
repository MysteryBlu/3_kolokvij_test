using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_kolokvij
{
    class Limeta : Sastojak
    {
        public Limeta(double kol)
        {
            porcija = 0.4;
            opis = "limete";
            volumen = porcija * kol;
        }

        public override string Prikazi()
        {
            return String.Format("{0} {1}", volumen/porcija, opis);
        }
    }
}
