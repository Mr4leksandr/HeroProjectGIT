using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarjutusKangelane
{
    //1. Klassis Kangelane privaatsed isendiväljad järgmise info jaoks: nimi (String), asukoht (String). Klassis on vähemalt üks konstruktor.
    class Hero
    {
        private string _name;
        private string _place;

        public Hero(string name, string place)
        {
            _name = name;
            _place = place;
        }

        // Kõigi isendiväljade jaoks on vastavad get-meetodid ja set-meetodid.
        public string HeroName
        {
            get { return _name; }
            set { _name = value; }
        }

        public string HeroPlace 
        {
            get { return _place; }
            set { _place = value;  }
        }

        // Meetod päästa (int-tüüpi), mille argumendiks on ohus olevate inimeste arv (int). Meetod tagastab päästetud inimeste arvu, mis on ohus olevate inimeste arvust 95 protsenti (ümardatuna täisarvuks).
        public virtual int Save(int indanger)
        {
            return (int)(indanger * 0.95);
        }

        // On ka meetod toString, mis võimaldab kangelast mõistlikult ekraanil kujutada.
        public virtual string ToString()
        {
            return $"{_name} / {_place} \nSaved: {Save(indanger)}\n";
        }
    }
}