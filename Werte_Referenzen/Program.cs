﻿using LibraryBsp;

namespace Werte_Referenzen
{
    //Klasse, deren Objekte als REFERENZTYPEN betrachtet werden
    class PersonC
    {
        public int Alter { get; set; }
        public string Name { get; set; }

        public PersonC(int a, string n)
        {
            Alter = a;
            Name = n;
        }
    }

    //Struct, dessen Objekte, wie sämtliche Basisdatentypen, als WERTETYPEN betrachtet werden
    struct PersonS
    {
        public int Alter { get; set; }
        public string Name { get; set; }

        public PersonS(int a, string n)
        {
            Alter = a;
            Name = n;
        }
    }


    internal class Program
    {
        //Methoden, welche jeweils die Alter-Property manipulieren
        public static void Altern(PersonC person)
        {
            person.Alter++;
        }

        public static void Altern(PersonS person)
        {
            person.Alter++;
        }

        //Mittels des REF-Stichworts können Werte als Referenzen an Methoden übergeben werden (s.u.)
        public static void Altern(ref PersonS person)
        {
            person.Alter++;
        }

        static void Main(string[] args)
        {
            //Vergleich bei Neuzuweisung:

            //Wertetypen:
            int a = 5;
            int b = a;
            Console.WriteLine($"a:{a} b:{b}");
            a = 10;
            Console.WriteLine($"a:{a} b:{b}");

            //Referenztypen
            //Lebewesen lb1 = new Lebewesen() { Lieblingsnahrung = "Lasagne" };
            //Lebewesen lb2 = lb1;
            //Console.WriteLine($"lb1:{lb1.Lieblingsnahrung} lb2:{lb2.Lieblingsnahrung}");
            //lb1.Lieblingsnahrung = "Pizza";
            //Console.WriteLine($"lb1:{lb1.Lieblingsnahrung} lb2:{lb2.Lieblingsnahrung}");


            //Instanziierung von Bsp-Objekten
            PersonC classP = new PersonC(30, "Anna");
            PersonS structP = new PersonS(30, "Hugo");
            //Ausgabe der Alter
            Console.WriteLine($"{classP.Name}: {classP.Alter}");
            Console.WriteLine($"{structP.Name}: {structP.Alter}");

            //Übergabe des Klassenobjekts (Referenztyp):
            ///Da bei der Übergabe die Referenz des Objektes an die Methode übergeben wird, wird innerhalb der Methode
            ///das Alter des Objekts manipuliert. Im Ergebnis ist das Objekt nach der Methode ein Jahr älter geworden.
            Altern(classP);
            Console.WriteLine($"{classP.Name}: {classP.Alter}");

            //Übergabe des Structobjekts (Wertetyp):
            ///Als Wertetyp wird das Objekt bei der Übergabe an die Methode kopiert. Die Methode manipuliert nur die Kopie.
            ///In dem Originalobjekt sind keine Veränderungen zu beobachten. Dieses Verhalten findet scih bei allen Wertetypen.
            Altern(structP);
            Console.WriteLine($"{structP.Name}: {structP.Alter}");

            //Übergabe eines Wertetypen mittels ref
            ///Ducrh ref wird auch bei Wertetypen die Referenz übergeben, wodurch hier eine Manipulation des Originalobjekts durchgeführt wird.
            Altern(ref structP);
            Console.WriteLine($"{structP.Name}: {structP.Alter}");
        }
    }
}
