using System;

namespace HalloWelt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hallo Welt!");

            int Alter;

            Alter = 34;

            var Stadt = "Berlin";

            Console.WriteLine(Alter);
            Console.WriteLine(Stadt);

            int DoppeltesAlter = Alter * 2;
            Console.WriteLine(DoppeltesAlter);

            char Textzeichen = 'A';

            bool Wahrheitswert = true;

            double Gleitkomma = 45.12;
            Console.WriteLine(Gleitkomma);


            string Satz = "Ich bin " + Alter.ToString() + " Jahre alt und wohne in " + Stadt + ".";
            Console.WriteLine(Satz);
            Console.WriteLine("Ich bin " + Alter.ToString() + " Jahre alt und wohne in " + Stadt + ".");

            Satz = $"Ich bin {Alter} Jahre alt und wohne in {Stadt}.";
            Console.WriteLine(Satz);
            Console.WriteLine($"Ich bin {Alter} Jahre alt und wohne in {Stadt}.");

            Console.WriteLine("Ich bin {0:0.0} Jahre alt und wohne in {1}.", Alter, Stadt);

            int a = 12;
            int b = 34;
            Console.WriteLine($"{a} + {b} = {a+b}");

            string bsp = "Dies ist ein \tTabulator und dies ein \nZeilenumbruch.";
            Console.WriteLine(bsp);

            bsp = $"\"{{\\}}\"";
            Console.WriteLine(bsp);

            string verbatim = @"Dies ist ein    Tabulator und dies ein 
Zeilenumbruch.";
            Console.WriteLine(verbatim);

            Console.Write("Gib deinen Namen ein: ");
            string eingabe = Console.ReadLine();
            Console.WriteLine($"Du heißt also {eingabe}");

            Console.ReadKey();

            Console.Write("Gib deine Lieblingszahl ein: ");
            int zahl = int.Parse(Console.ReadLine());
            Console.WriteLine(zahl * 2);

            zahl = System.Convert.ToInt32(56.789);


            int intZahl = 45;
            double doubleZahl = intZahl;
            Console.WriteLine(doubleZahl);

            doubleZahl = 45.78;
            intZahl = (int)doubleZahl;
            Console.WriteLine(intZahl);

            double zero = 0.0;
            double erg = 67 / zero;
            Console.WriteLine(erg);

        }
    }
}