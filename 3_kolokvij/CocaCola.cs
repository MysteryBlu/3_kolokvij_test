using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_kolokvij
{
    class CocaCola : Sastojak
    {
        public CocaCola(double kol, string opis)
        {
            porcija = 2.5;
            volumen = kol * porcija;
            this.opis = "Coca-cola " + opis;
        }

        public override string Prikazi()
        {
            return String.Format("{0} {1}", volumen / porcija, opis);
        }
    }
}
