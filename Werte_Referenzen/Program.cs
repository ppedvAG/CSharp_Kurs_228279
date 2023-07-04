using LibraryBsp;

namespace Werte_Referenzen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            Console.WriteLine($"a:{a}, b:{b}");
            a = b;
            Console.WriteLine($"a:{a}, b:{b}");
            b = 15;
            Console.WriteLine($"a:{a}, b:{b}");

            Lebewesen lb1 = new Lebewesen() { Lieblingsnahrung = "Obst" };
            Lebewesen lb2 = new Lebewesen() { Lieblingsnahrung = "Wurst" };
            Console.WriteLine($"Lb1:{lb1.Lieblingsnahrung}, Lb2:{lb2.Lieblingsnahrung}");
            lb1 = lb2;
            Console.WriteLine($"Lb1:{lb1.Lieblingsnahrung}, Lb2:{lb2.Lieblingsnahrung}");
            lb1.Lieblingsnahrung = "Gemüse";
            Console.WriteLine($"Lb1:{lb1.Lieblingsnahrung}, Lb2:{lb2.Lieblingsnahrung}");


            PersonC KlassenPerson = new PersonC("Anna", 30);
            PersonS StructPerson = new PersonS("Hugo", 30);

            Console.WriteLine($"{KlassenPerson.Name}: {KlassenPerson.Alter}");
            Console.WriteLine($"{StructPerson.Name}: {StructPerson.Alter}");

            Altern(KlassenPerson);
            Altern(StructPerson);

            Console.WriteLine($"{KlassenPerson.Name}: {KlassenPerson.Alter}");
            Console.WriteLine($"{StructPerson.Name}: {StructPerson.Alter}");

            Altern(ref StructPerson);
            Console.WriteLine($"{StructPerson.Name}: {StructPerson.Alter}");
        }

        public static void Altern(PersonC person)
        {
            person.Alter++;
        }
        public static void Altern(PersonS person)
        {
            person.Alter++;
        }
        public static void Altern(ref PersonS person)
        {
            person.Alter++;
        }
    }


    class PersonC
    {
        public int Alter { get; set; }
        public string Name { get; set; }

        public PersonC(string name, int alter)
        {
            this.Alter = alter;
            this.Name = name;
        }
    }

    struct PersonS
    {
        public int Alter { get; set; }
        public string Name { get; set; }

        public PersonS(string name, int alter)
        {
            this.Alter = alter;
            this.Name = name;
        }
    }
}