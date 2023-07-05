//Mittels EXCEPTION-HANDLING werden Laufzeitfehler kommuniziert und verwaltet
namespace ExceptionHandling
{
    //Eigene Exceptions müssen von der Klasse Exception erben, damit diese Mechanik verwendet werden kann
    class MeineException : Exception
    {
        public MeineException() : base("Dies ist mein Fehler")
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            bool wdh;
            do
            {
                wdh = false;
                //Im TRY-Block steht der Code, welcher potenziell Fehler produzieren kann
                try
                {
                    string eingabe = Console.ReadLine();
                    int zahl = int.Parse(eingabe); //int.Parse kann diverse verschiedene Exceptions werfen

                    if (zahl == 0)
                        //Mittels THROW werden Exceptions manuell geworfen
                        Test();

                    //Der Wurf einer Exception verhindert die weitere Ausführung des Try-Blocks
                    Console.WriteLine("Ende Try");
                }
                //Die CATCH-Blöcke fangen die jeweiligen Exceptions ab und sollen diese bearbeiten
                catch (FormatException ex)
                {
                    Console.WriteLine("Du musst eine Zahl eingeben. " + ex.Message);
                    wdh = true;
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine("Deine Zahl ist zu groß/zu klein. " + ex.Message);
                    wdh = true;
                }
                catch (MeineException ex)
                {
                    Console.WriteLine("Gib keine Null ein! " + ex.Message);
                    throw;
                }
                //Allgemeine Catch-Blöcke fangen jede Excpetion ab (es gilt der Polymorphismus)
                catch (Exception ex)
                {
                    Console.WriteLine("Ein unbekannter Fehler ist aufgetreten.");
                }
                //Der optinale FINALLY-Block wird in jedem Fall immer ausgeführt
                finally
                {
                    Console.WriteLine("Wird immer ausgeführt");
                }
            }
            while (wdh);

        }

        static void Test()
        {
            //Mittels THROW werden Exceptions manuell geworfen
            throw new MeineException();
            Console.WriteLine("Niemals");
        }
    }
}
