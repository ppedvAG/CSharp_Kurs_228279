using LibraryBsp;

namespace OOP_Exe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Modul 06: OOP
            //Deklarierung von Lebewesen-Variablen und Instanziierung von neuen Lebewesen-Objekten per Konstruktor
            LibraryBsp.Lebewesen lebewesen1;
            lebewesen1 = new Lebewesen("Hugo Schmidt", "Pizza", new DateTime(2002, 2, 12), 185);
            Lebewesen lebewesen2 = new Lebewesen("Bello", "Knochen", new DateTime(2020, 3, 15), 50);

            //Lesezugriff auf Property per Getter
            Console.WriteLine("Lebewesen1 heißt " + lebewesen1.Name);
            //Schreibzugriff auf Property per Setter
            lebewesen1.Lieblingsnahrung = "Lasagne";

            Console.WriteLine("Lebewesen1 heißt " + lebewesen1.Name);
            Console.WriteLine("Lebewesen2 heißt " + lebewesen2.Name);

            Console.WriteLine(lebewesen1.Geburtsdatum);
            Console.WriteLine(lebewesen2.Alter);

            //Aufruf von klasseneigenen Funktionen
            lebewesen1.Wachse();
            lebewesen2.Wachse();
            Lebewesen kind = lebewesen1.ProduziereNachwuchs("Maria");
            #endregion


            for (int i = 0; i < 1000; i++)
            {
                lebewesen1 = new Lebewesen($"Lebewesen Nr.{i}", "Egal", DateTime.Now, 100);
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();


            Lebewesen.ZeigeAnzahlAllerLebewesen();




        }
    }
}