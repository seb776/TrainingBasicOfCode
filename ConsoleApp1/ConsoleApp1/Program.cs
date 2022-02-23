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
            Random rand = new Random((int)DateTime.Now.Ticks);

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

        static void test(int a)
        {
            for (int j = 0; j < 25; ++j)
            {
                for (int i = 0; i < 100; ++i)
                {
                    var colora = ConsoleColor.Red;
                    var colorb = ConsoleColor.Black;
                    
                    Console.BackgroundColor = ((i+j+a) % 2 == 0 ? colora : colorb);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            //_miniGame();
            //float maVariable = 42.0f;
            //float maVariable2 = 43.0f;

            //float maVariable3 = maVariable + maVariable2; // operateurs + - / * (^ & | %)
            //int age = 42;
            //bool cond = maVariable < maVariable2; // < > <= >= == !=
            //// https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/boolean-logical-operators
            //if ((age + 42) > 18)
            //    Console.WriteLine("Hello");
            //else
            //{

            //}
            //// && || 

            //int myAge = 0;
            //var typedAge = Console.ReadLine();
            //int.TryParse(typedAge, out myAge);

            //bool test = Console.ReadKey().Key == ConsoleKey.A;

            int myAge = 42;

            int moneyToGive = myAge < 18 ? 100 : 1000; // ternaire / ternary operator

            int i = 0;
            while (true)
            {
                test(i%2);
                i++;
                System.Threading.Thread.Sleep(500);
                Console.Clear();
            }
            Console.WriteLine("Appuyez sur une touche pour terminer...");
            Console.ReadKey();
        }
    }
}
