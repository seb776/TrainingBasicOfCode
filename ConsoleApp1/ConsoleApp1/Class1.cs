using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Class1
    {
        public static void PlayGame()
        {
            Random random = new Random();

            int randomNumber = random.Next(0, 100);

            bool hasFoundNumber = false;
            int trials = 0;
            int maxTrials = 5;
            Console.WriteLine(randomNumber);
            while (!hasFoundNumber && trials < maxTrials)
            {
                Console.WriteLine("Quel est le nombre ? " + (trials + 1));
                int userNumber = 0;
                var userInput = Console.ReadLine();
                int.TryParse(userInput, out userNumber);
                if (userNumber == randomNumber)
                {
                    Console.WriteLine("Wouhou !");
                    hasFoundNumber = true;
                }
                else if (userNumber > randomNumber)
                {
                    Console.WriteLine("C'est moins !");
                }
                else
                {
                    Console.WriteLine("C'est plus !");
                }
                trials++;
            }

            if (hasFoundNumber)
            {
                Console.WriteLine("Bravo ! Tu as trouvé le nombre en " + trials + "essais");
            }
            else
            {
                Console.WriteLine("T'es nul !");
            }
        }

        public static void CorrectionMiniJeu()
        {
            bool continuePlay = true;
            while (continuePlay)
            {
                Console.Clear();

                PlayGame();

                Console.WriteLine("On recommence ?");
                var userInput = Console.ReadKey();
                if (userInput.Key != ConsoleKey.Y)
                    continuePlay = false;
            }
        }
    }
}
