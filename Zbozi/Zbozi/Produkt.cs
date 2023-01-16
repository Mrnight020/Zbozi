using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zbozi
{
    internal class Produkt:Zbozi
    {
        bool lzezlevnit;
        public Produkt(string nazev, int cena, DateTime datumvyroby, int minimalnitrvanlivost,bool lzezlevnit) : base(nazev, cena, datumvyroby, minimalnitrvanlivost)
        { 
            this.lzezlevnit= lzezlevnit;
        }

        public override double cenasDPH()
        {
            lzezlevnit = base.Splnujemintrv();
            if (lzezlevnit)
            {
                return (cena * 1.21);
            }
            else
            {
                return (cena * 1.21) * (0.60);
            }
        }

    }
}
