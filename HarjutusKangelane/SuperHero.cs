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
        private double _dexterity;

        // Klassis on vähemalt üks konstruktor, mis muuhulgas määrab juhuslikult superkangelase osavuse.
        public SuperHero(string name, string place, int dexterity) : base(name, place)
        {
            _dexterity = dexterity;
        }

        // Klassis SuperKangelane on veel isendiväli osavuse kohta (double), mis kõigub vahemikus [1-5).
        public double DexterityValue()
        {
            Random r = new Random();
            return _dexterity = r.Next(1, 5);
        }

        // Meetod päästa kaetakse üle nii, et meetod tagastab päästetud inimeste arvu, mis on ohus olevate inimeste arvust (95 + osavus) protsenti (ümardatuna täisarvuks).
        public override int Save(int saved)
        {
            return saved = 95 + (int)_dexterity;
        }

        // Meetodi toString ülekatmisel on rakendatud ülemklassi meetodit toString lisades osavuse väljastamise.
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
