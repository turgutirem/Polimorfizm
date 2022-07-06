using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfizm
{
    class MetalKesme : UrunKesme
    {

        public override void BilgiTanimla()
        {
            MateryalTipi = "Metal";
            KesimBoyutu =48;
            KesimSekli = "kare";
        }
    }
}
