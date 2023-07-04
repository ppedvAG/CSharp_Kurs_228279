namespace Funktionen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int summe = Addiere(13, 56);
            Console.WriteLine(summe);

            double dblSumme = Addiere(12.5, 34.5);
            Console.WriteLine(dblSumme);

            dblSumme = Addiere(1.2, 3.5, d:5.6);
            Console.WriteLine(dblSumme);

            summe = BildeSumme(1, 34, 67, -12, 56, 76, 12, 78);
            Console.WriteLine(summe);

            //int diff = -23;

            summe = AddiereUndSubtrahiere(14, 4, out int diff);
            Console.WriteLine(summe);
            Console.WriteLine(diff);

            string eingabe = Console.ReadLine();
            if(int.TryParse(eingabe, out int result))
            {
                Console.WriteLine(result * 5);
            }
        }


        static int Addiere(int a, int b)
        {
            return a + b;
        }

        static double Addiere(double a, double b) 
        { 
            return a + b; 
        }

        static int Addiere(int a, int b, int c)
        {
            return a + b + c;
        }

        static double Addiere(double a, double b, double c = 0, double d = 0)
        {
            return a + b + c + d;
        }

        static int BildeSumme(params int[] summanden)
        {
            int summe = 0;

            foreach (int i in summanden)
            {
                summe += i;
            }

            return summe;
        }

        static int AddiereUndSubtrahiere(int a, int b, out int differenz)
        {
            differenz = a - b;

            return a + b;
        }

    }
}