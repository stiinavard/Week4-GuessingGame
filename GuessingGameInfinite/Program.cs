using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhusliku numbri 1-10;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis numbri ära arvata, siis ta on mängu võitnud;
            //katsete arv on piiramatu.
            //*programm genereerib juhusliku numbri ühe korra.

            bool loopActive = true;

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);

            while (loopActive)
            {
                Console.WriteLine("Paku oma number:");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                if (userNumber == cpuNumber)
                {
                    Console.WriteLine("Palju õnne! Võitsid mängu!");
                    loopActive = false;
                }
                else
                {
                    Console.WriteLine("Vale number, proovi uuesti!");
                }
            }

            Console.WriteLine("Kena päeva!");
        }
    }
}
