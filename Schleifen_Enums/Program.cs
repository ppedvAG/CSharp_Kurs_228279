namespace Schleifen_Enums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 10;

            while (a < b)
            {
                Console.WriteLine("A ist kleiner als B");

                a++;

                if (a == 5)
                    break;
            }

            Console.WriteLine("ENDE");

            a = -45;

            do
            {
                Console.WriteLine(a);
                a--;

                continue;

                a--;

            } while (a > 0);


            for (int index = 0; index < 10; index+=2)
            {
                Console.WriteLine(index);

                index++;
            }


            int[] zahlen = { 2, 45, 1, -3, 56, 68 };

            for (int i = 0; i < zahlen.Length; i++)
            {
                Console.WriteLine(zahlen[i]);
            }

            foreach (var item in zahlen)
            {
                Console.WriteLine(item);
            }


            Wochentag heutigerTag = Wochentag.Montag;

            Console.WriteLine($"Heute ist {heutigerTag}.");


            Console.WriteLine("Welchen Wochentag magst du am liebsten?");
            for (int i = 1; i <= Enum.GetValues(typeof(Wochentag)).Length; i++)
            {
                Console.WriteLine($"{i}: {(Wochentag)i}");
            }
            heutigerTag = (Wochentag)int.Parse(Console.ReadLine());
            Console.WriteLine($"Du magst {heutigerTag} besonders.");

            heutigerTag = (Wochentag)Enum.Parse(typeof(Wochentag), Console.ReadLine());
            Console.WriteLine($"Du magst {heutigerTag} besonders.");

            if(Console.ReadKey().Key == ConsoleKey.Enter)
                Console.WriteLine("Du hast ENTER gedrückt.");


            switch (heutigerTag)
            {
                case Wochentag.Montag:
                    Console.WriteLine("Wochenstart");
                    break;
                case Wochentag.Dienstag:
                case Wochentag.Mittwoch:
                case Wochentag.Donnerstag:
                    Console.WriteLine("Wochentag");
                    break;
                case Wochentag.Freitag:
                case Wochentag.Samstag:
                case Wochentag.Sonntag:
                    Console.WriteLine("Wochenende");
                    break;
                default:
                    Console.WriteLine("FEHLER");
                    break;
            }

            int zahl = 23;

            switch (zahl)
            {
                case 5:
                    Console.WriteLine("Variable ist 5");
                    break;
                case int z when z < 8:
                    Console.WriteLine("Variable ist < 8");
                    break;
                default:
                    break;
            }

        }
    }

    enum Wochentag { Montag = 1, Dienstag, Mittwoch, Donnerstag, Freitag, Samstag, Sonntag}
}