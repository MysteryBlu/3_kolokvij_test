using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_kolokvij
{
    class Koktel
    {
        static List<Sastojak> sastojci = new List<Sastojak>();

        private string naziv;

        public Koktel(string naziv)
        {
            this.naziv = naziv;
        }
        public void Dodaj(Sastojak s)
        {
            sastojci.Add(s);
        }

        private double IzracunVolumena()
        {
            double casa = 0;

            foreach(Sastojak s in sastojci)
            {
                casa += s.VratiDecilitre();
            }

            return casa;
        }
        public string Posluzi()
        {
            int i = 0;

            return String.Format(
                "Posluzujem koktel {0}\n" +
                "Sastojci ({1})\n" +
                "{2}\n" +
                "{3}\n" +
                "{4}\n" +
                "{5}\n" +
                "Potrebna casa minimalno dcl: {6}",
                naziv,
                sastojci.Count(), 
                sastojci.ElementAt(i++).Prikazi(), 
                sastojci.ElementAt(i++).Prikazi(),
                sastojci.ElementAt(i++).Prikazi(), 
                sastojci.ElementAt(i++).Prikazi(),
                 IzracunVolumena());
           
        }
    }
}
