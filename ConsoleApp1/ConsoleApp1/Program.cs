using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        private static void _miniGame()
        {
            Random rand = new Random();

            while (true)
            {
                int numberToGuess = rand.Next(0, 100);
                bool guessedRight = false;
                Console.WriteLine("Devine le nombre entre 0 et 100");
                while (!guessedRight)
                {
                    Console.WriteLine("Quelle est le nombre magique ?");
                    string typed = Console.ReadLine();

                    int typedNumber = 0;

                    if (int.TryParse(typed, out typedNumber))
                    {

                        if (typedNumber > numberToGuess)
                            Console.WriteLine("C'est moins !");
                        else if (typedNumber < numberToGuess)
                            Console.WriteLine("C'est plus !");

                        guessedRight = (typedNumber == numberToGuess);
                    }
                    else
                    {
                        Console.WriteLine("Merci d'entrer un nombre !");
                    }
                }
                Console.WriteLine("Bravo ! Tu as trouvé le nombre était bien " + numberToGuess);
                Console.WriteLine("On continue ? (Y pour oui)");
                if (Console.ReadKey().Key != ConsoleKey.Y)
                    break;
                Console.Clear();

            }

        }
        static void Main(string[] args)
        {
            _miniGame();
            Console.WriteLine("Appuyez sur une touche pour terminer...");
            Console.ReadKey();
        }
    }
}
