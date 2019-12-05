using System;
using System.Threading;
using System.Threading.Tasks;

namespace Multithreading_med_Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gæt et tal mellem 1-10. Du har 10 sekunder");
            Console.WriteLine("Tryk på \"Enter\" for at starte");
            Console.ReadLine();
            Random rdn = new Random();
            int answer = rdn.Next(0, 11);
            int guess = 0;
            Task countdown = new Task(() => {
                int i = 10;
                while (i > 0)
                {
                    Console.Clear();
                    Console.WriteLine(i);
                    Thread.Sleep(1000);
                    i -= 1;
                    if (answer == guess) { i = 0; }
                };
                Console.Clear();
                if (answer == guess)
                {
                    Console.WriteLine("Tillykke du gættede rigtigt!!!");
                }

                else
                {
                    Console.WriteLine("Du nåede desvære ikke at gætte tallet");
                }
                Console.WriteLine("Svaret var: " + answer);

            });
            countdown.Start();
            while (answer != guess)
            {
                Int32.TryParse(Console.ReadLine(), out guess);
            }
            countdown.Wait();
            Console.ReadLine();
        }
    }
}
