namespace ExceptionHandling
{
    class MeineException : Exception
    {
        public MeineException(string msg) : base(msg)
        {
                
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            bool wdh = false;

            do
            {
                string eingabe = Console.ReadLine();

                try
                {
                    int zahl = int.Parse(eingabe);

                    if (zahl == 0)
                        ThrowMeineException();

                    Console.WriteLine(zahl * 2);
                    wdh = false;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Du darfst nur Zahlen eingeben. " + ex.Message);
                    wdh = true;
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine("Deine Zahl ist zu groß/klein. " + ex.Message);
                    wdh = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ein unbekannter Fehler ist aufgetreten. " + ex.Message);
                }
                finally
                {
                    Console.WriteLine("FINALLY");
                }
            } while (wdh);

            Console.WriteLine("ENDE");
        }

        static void ThrowMeineException()
        {
            throw new MeineException("0 ist doof");
        }
    }
}