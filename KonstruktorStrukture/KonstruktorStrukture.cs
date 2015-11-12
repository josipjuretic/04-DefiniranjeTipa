using System;

namespace Vsite.CSharp
{
    class KonstruktorStrukture
    {
        struct MojaStruktura
        {
                public MojaStruktura(int p1, string p2)
            {
                // Complete member initialization
                this.p1 = p1;
                this.p2 = p2;
            }


            private int p1;
            private string p2;
        }

        static void Main(string[] args)
        {
            // Stvoriti objekt strukture MojaStruktura i ispisati vrijednosti članova

            MojaStruktura ms = new MojaStruktura();
            Console.WriteLine(ms.a);
            Console.WriteLine(ms.s);

            // U strukturi MojaStruktura promijeniti prazan konstruktor tako da prima dva argumenta kojima se inicijaliziraju članovi te ponoviti gornji postupak

            MojaStruktura ms1 = new MojaStruktura(3, "zagreb");
            Console.WriteLine(ms1.a);
            Console.WriteLine(ms1.s);

            Console.ReadKey();

        }
    }
}
