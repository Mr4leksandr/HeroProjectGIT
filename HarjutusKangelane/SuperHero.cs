using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarjutusKangelane
{
    //2. Klass SuperKangelane on klassi Kangelane alamklass. Klassis SuperKangelane on veel isendiväli osavuse kohta (double), mis kõigub vahemikus [1-5).
    //Ülemklassis olemasolevaid isendivälju siin uuesti mitte kirjeldada.
    class SuperHero : Hero
    {
        // Isendiväli (double)
        private double _skill;
        private static Random r = new Random();

        // Klassis on vähemalt üks konstruktor, mis muuhulgas määrab juhuslikult superkangelase osavuse.
        public SuperHero(string name, string place) : base(name, place)
        {
            _skill = r.Next(100, 501)/100.0;
        }

        // Klassis SuperKangelane on veel isendiväli osavuse kohta (double), mis kõigub vahemikus [1-5).
        public double Skill
        {
            get => _skill;
        }

        // Meetod päästa kaetakse üle nii, et meetod tagastab päästetud inimeste arvu, mis on ohus olevate inimeste arvust (95 + osavus) protsenti (ümardatuna täisarvuks).
        public override int Save(int saved)
        {
            return saved = 95 + (int)_skill;
        }

        // Meetodi toString ülekatmisel on rakendatud ülemklassi meetodit toString lisades osavuse väljastamise.
        public override string ToString()
        {
            return base.ToString()+"\nLisaks on ta võimekas "+_skill+" %";
        }
    }
}
