using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfizm
{
    class CamKesme : UrunKesme
    {
        public override void BilgiTanimla()
        {
            MateryalTipi = "Cam";
            KesimBoyutu = 56;
            KesimSekli = "dikdörtgen";
        }

    }
}
