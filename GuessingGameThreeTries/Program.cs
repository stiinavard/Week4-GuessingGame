using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhusliku numbri 1-10;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis numbri ära arvata, siis ta on mängu võitnud;
            //kasutajal on kolm katset, kui kasutaja ei ole suutnud kolme katsega numbrit ära arvata
            //siis mängu võidab arvuti.
            //*programm genereerib juhusliku numbri ühe korra.


            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);

            int i = 0;

            while (i < 3)
            {
                Console.WriteLine("Paku oma number:");
                int userNumber = Convert.ToInt32(Console.ReadLine());
               
                if (userNumber == cpuNumber)
                {
                    Console.WriteLine("Palju õnne! Võitsid mängu!");
                    break;
                }

                else
                {
                    i++;
                    Console.WriteLine($"Vale number, {3 - i} katset on veel jäänud.");
                }
            }

            Console.WriteLine("Kena päeva!");
        }

    }
}
