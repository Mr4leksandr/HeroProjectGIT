using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarjutusKangelane
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero k1 = new Hero("Batman", "Tartu");
            k1.HeroName = "Batman";
            Console.WriteLine("Nimi: "+k1.HeroName);
            k1.HeroPlace = "Tartu";
            Console.WriteLine("Asukoht: "+k1.HeroPlace);
            int saved = k1.Save(160);
            Console.WriteLine("P‰‰stis: "+saved);
            Console.WriteLine("");
            Console.WriteLine(k1.ToString());

            Console.WriteLine("");

            SuperHero k2 = new SuperHero("Superman*", "Tallinn");
            k2.HeroName = "Superman*";
            Console.WriteLine("Nimi: " + k2.HeroName);
            k2.HeroPlace = "Tallinn";
            Console.WriteLine("Asukoht: " + k2.HeroPlace);
            int saved1 = k2.Save(160);
            Console.WriteLine("P‰‰stis: " + saved);
            Console.WriteLine("");
            Console.WriteLine(k2.ToString());
        }
    }
}
