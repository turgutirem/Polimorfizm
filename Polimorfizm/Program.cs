using System;

namespace Polimorfizm
{
    class Program
    {
        static void Main(string[] args)
        {
            //polimorfizmm
            string durum;
            UrunKesme urun = new UrunKesme();
            durum = urun.kes();
            Console.WriteLine(durum);

            urun = new CamKesme();
            durum = urun.kes();
            Console.WriteLine(durum);

            urun= new MetalKesme();
            durum = urun.kes();
            Console.WriteLine(durum);

            Console.ReadKey();
            //aynı işi yapan methodların aynı işi yapabilir olması=Static poli.

        }
    }
}
