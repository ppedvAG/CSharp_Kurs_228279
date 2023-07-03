using System.Reflection.Metadata;

namespace Arrays_Bedingungen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] zahlen = { 2, 4, 45, -123, -8, 0, 11111 };

            Console.WriteLine(zahlen[2]);
            zahlen[2] = 1234;
            Console.WriteLine(zahlen[2]);

            Console.WriteLine(zahlen.Length);

            Console.WriteLine(zahlen.Contains(-123));
            Console.WriteLine(zahlen.Contains(555));


            int a = 35;
            int b = 35;


            if(a < b)
                Console.WriteLine("A ist kleiner als B");
            else if (a == 34)
            {
                Console.WriteLine("A ist 34");
            }
            else if(a > b)
            {
                Console.WriteLine("A ist größer als B");
            }
            else
            {
                Console.WriteLine("A ist gleich B und nicht 34");
            }


            string erg = (a == b) ? "A ist gleich B" : "A ist ungleich B";

            Console.WriteLine("ENDE DES IF-BLOCKS");
        }
    }
}