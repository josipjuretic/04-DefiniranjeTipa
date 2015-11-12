using System;

namespace Vsite.CSharp
{
    class MojaKlasa
    {
        // DO: Dodati jedna privatno polje (podatkovni član)
        int x = 1;

        // DO: Dodati javnu metodu koja će ispisati podatkovni član
        public int DajMiXa();
    {
        return this.x;
    }
    }


    struct MojaStruktura
    {
        // DO: Dodati jedna privatno polje (podatkovni član)
        string s = "Tekst";

        // DO: Dodati javnu metodu koja će ispisati podatkovni član
        public string DajMiString();
    {
        return s;
    }
    }


    class Program
    {
        static void Main(string[] args)
        {
            // DO: Inicijalizirati objekt tipa MojaKlasa i pozvati njegovu metodu
            MojaKlasa mk = new MojaKlasa();
            mk.DajMiXa();

            // DO: Inicijalizirati objekt tipa MojaStruktura i pozvati njegovu metodu

            MojaStruktura ms = new MojaStruktura();
            ms.DajMiString();

            Console.ReadKey();
        }
    }
}
