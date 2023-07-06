namespace Delegates
{
    public delegate int MeinDelegate(int a, int b);

    internal class Program
    {
        static void Main(string[] args)
        {
            MeinDelegate delegateVariable;

            delegateVariable = new MeinDelegate(Addiere);
            delegateVariable = Addiere;

            int erg = delegateVariable(13, 45);
            Console.WriteLine(erg);

            delegateVariable = Subtrahiere;
            erg = delegateVariable(13, 45);
            Console.WriteLine(erg);

            delegateVariable += Addiere;
            delegateVariable += Addiere;
            delegateVariable += Addiere;
            delegateVariable += Addiere;
            delegateVariable += Addiere;

            erg = delegateVariable(13, 45);
            Console.WriteLine(erg);


            foreach (var item in delegateVariable.GetInvocationList())
            {
                Console.WriteLine(item.Method);
            }

            delegateVariable -= Addiere;

            delegateVariable = null;


            Func<int, int, int> meinFunc = Addiere;


            FühreAus(meinFunc);
            FühreAus(Addiere);

            List<string> Städteliste = new List<string>() { "Berlin", "Hamburg", "München", "Köln", "Düsseldorf" };

            string ergebnis = Städteliste.Find(FindeStadtMitH);
            Console.WriteLine(ergebnis);

            ergebnis = Städteliste.Find
                (
                    delegate (string input)
                    {
                        return input.StartsWith('H');
                    }
                );
            Console.WriteLine(ergebnis);

            ergebnis = Städteliste.Find((string input) => { return input.StartsWith('H'); });
            ergebnis = Städteliste.Find(input => input.StartsWith('H'));


            Städteliste = Städteliste.OrderBy(stadt => stadt.Length).ToList();
            foreach (var item in Städteliste)
            {
                Console.WriteLine(item);
            }

            Städteliste = Städteliste.OrderBy(stadt => stadt[0]).ToList();
            foreach (var item in Städteliste)
            {
                Console.WriteLine(item);
            }
        }

        public static bool FindeStadtMitH(string input)
        {
            return input.StartsWith('H');
        }

        public static void FühreAus(Func<int, int, int> mehrLogik)
        {
            Console.WriteLine(mehrLogik(100, 200));
        }

        public static void FühreAus02(Func<int, int, int> mehrLogik) => Console.WriteLine(mehrLogik(100, 200));

        public static int Addiere(int a, int b)
        {
            Console.WriteLine("Addiere");
            return a + b;
        }

        public static int Subtrahiere(int a, int b)
        {
            Console.WriteLine("Subtrahiere");
            return a - b;
        }
    }
}