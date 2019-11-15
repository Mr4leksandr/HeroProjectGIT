using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarjutusKangelane
{
    class Program
    {
        private static List<Hero> heroes = new List<Hero>();
        private static void LoadHeroesFromFile(string Filename)
        {
            string[] data = File.ReadAllLines(Filename);
            //TODO load file parse data, add to heroes list
            for (int i = 0; i < data.Length; i++)
            {
                string[] name_loc = data[i].Split(" / ");

                if (name_loc[0].EndsWith("*"))
                {
                    heroes.Add(new SuperHero(name_loc[0].Substring(0, name_loc[0].Length-1), name_loc[1]));
                }
                else
                {
                    heroes.Add(new Hero(name_loc[0], name_loc[1]));
                }
            }

            heroes.Add(new Hero("Ironman", "Las Vegas"));
            heroes.Add(new SuperHero("Superman*", "The World"));
        }

        static void Main(string[] args)
        {
            Hero k1 = new Hero("Batman", "Tartu");
            k1.HeroName = "Batman";
            Console.WriteLine("Nimi: " + k1.HeroName);
            k1.HeroPlace = "Tartu";
            Console.WriteLine("Asukoht: " + k1.HeroPlace);
            int saved = k1.Save(160);
            Console.WriteLine("Päästis: " + saved);
            Console.WriteLine("");
            Console.WriteLine(k1.ToString());

            Console.WriteLine("");

            SuperHero k2 = new SuperHero("Superman*", "Tallinn");
            k2.HeroName = "Superman*";
            Console.WriteLine("Nimi: " + k2.HeroName);
            k2.HeroPlace = "Tallinn";
            Console.WriteLine("Asukoht: " + k2.HeroPlace);
            int saved1 = k2.Save(160);
            Console.WriteLine("Päästis: " + saved);
            Console.WriteLine("");
            Console.WriteLine(k2.ToString());

            LoadHeroesFromFile("kangelased.txt");
        }
    }
}
