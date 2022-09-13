namespace LA1100
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            int versuche = 0;

            //Zufallszahl wird erstellt

            Random zufall = new Random();
            int RanZahl = zufall.Next(1, 101);

            Console.WriteLine("Zufallszahl zwischen 1-100 erstellt");

            //Benutzer wird aufgefordert eine Zahl zu erraten

            int i = 1;
            while (i == 1)
            {

                Console.WriteLine("Gebe deine Zahl ein.");
                int Zahl = Convert.ToInt32(Console.ReadLine());
                versuche = versuche + 1;

             
               

                    //Zahlen werden verglichen

                    if (Zahl < RanZahl)
                        Console.WriteLine("Falsch, ihre Zahl ist zu klein.");

                    else
                    {
                        if (Zahl > RanZahl)
                            Console.WriteLine("Falsch, ihre Zahl ist zu gross.");

                        else
                            Console.WriteLine("Richtig, die Zufallszahl ist " + RanZahl + ". Sie haben es beim " + versuche + " versuch geschaft.");

                    }

                if (versuche == 5)
                {
                    i = 0;
                    Console.WriteLine("Verloren, alle Versuche verbraucht. Die Zahl War: " + RanZahl);
                }
                

                }
            }
        }
    }
