using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zbozi
{
    internal class Zbozi
    {
        protected string nazev;
        protected int cena;
        protected DateTime datumvyroby;
        protected int minimalnitrvanlivost;

        public Zbozi(string nazev, int cena, DateTime datumvyroby, int minimalnitrvanlivost)
        {
            this.nazev = nazev;
            this.cena = cena;
            this.datumvyroby = datumvyroby;
            this.minimalnitrvanlivost = minimalnitrvanlivost;
        }

        public bool Splnujemintrv()
        {
            DateTime dnes = DateTime.Now;
            TimeSpan rozdil = dnes - datumvyroby;
            if(minimalnitrvanlivost >= rozdil.TotalDays)return true;
            else return false;
        }

        public virtual double cenasDPH()
        {
            return (cena * 1.21);
        }

        public override string ToString()
        {
            return String.Format("Název: {0}\nDatum výroby: {1}\nMin.Trvanlivost: {2}\nZbozi {3}splnuje min.trvalivost" +
                "\nCena bez DPH: {4} Kč\nKonečná cena s DPH {6}: {5} Kč" +
                "",nazev,datumvyroby,minimalnitrvanlivost,Splnujemintrv()?"":"ne",cena,cenasDPH(),Splnujemintrv()?"":"zlevněná o 40%");
        }


    }
}
