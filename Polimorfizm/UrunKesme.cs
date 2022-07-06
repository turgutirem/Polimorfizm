using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfizm
{
    class UrunKesme
    {
        private int kesimBoyutu;
        private string materyalTipi,kesimSekli;

        public int KesimBoyutu;
        public string MateryalTipi;
        public string KesimSekli;
        public virtual void BilgiTanimla()//alt sınıflarda değişiklik yapabilmek için virtual olarak tanımladık
        {
            //varsayılan değerler
            MateryalTipi = "Ahşap";
            KesimBoyutu = 50;
            KesimSekli = "Ucgen";
        }
        public void BilgiGir()
        {
            kesimSekli = KesimSekli;
            kesimBoyutu = KesimBoyutu;
            materyalTipi = MateryalTipi;
        }

        public string kes()
        {
            BilgiGir();
            BilgiTanimla();
            string durum;
            durum = KesimBoyutu + "cm boyutlu " + MateryalTipi + " materyali  " + KesimSekli + " şeklinde kesilmiştir.";

            return durum;
        } 
    }
}
