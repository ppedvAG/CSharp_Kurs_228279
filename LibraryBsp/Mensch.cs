using LibraryBsp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBsp
{
    public class Mensch : Lebewesen
    {
        public string Vorname { get; set; }
        public Mensch Mutter { get; set; }

        public Mensch(string vorname, string nachname, string lieblingsnahrung, DateTime geburtsdatum, int größe) : base(nachname, lieblingsnahrung, geburtsdatum, größe)
        {
            this.Vorname = vorname;
        }

        public override Lebewesen ProduziereNachwuchs(string kindname)
        {
            return new Mensch(kindname, this.Name, "Brei", DateTime.Now, 30) { Mutter = this };
        }

        public override string ToString()
        {
            return $"{this.Vorname} {base.ToString()}";
        }
    }
}
