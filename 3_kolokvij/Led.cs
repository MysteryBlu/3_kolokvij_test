using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_kolokvij
{
    class Led : Sastojak
    {
        public Led(string opis)
        {
            this.opis ="Led " + opis;
            volumen = 1;
        }

        public override string Prikazi()
        {
            return opis;
        }
    }
}
