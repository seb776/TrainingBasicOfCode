using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        private static void miniGame()
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
        static void testFonction(int number, string text)
        {
            Console.WriteLine(number);
            Console.WriteLine(text);
        }

        static int Pow(int a, int exponent)
        {
            int result = 1;
            for (int i = 0; i < exponent; ++i)
            {
                result = result* a;
            }
            return result;
        }

        struct Material
        {
            public string Name;
            public float Albedo;
            public float Specular;
            public float Opacity;
            public bool TwoSided;
        }

        static Material MakeNewMaterial(string name, float albdedo, float specular, float opacity, bool twoSided)
        {
            Material myMat = new Material();

            myMat.Name = name;
            myMat.Albedo = albdedo;
            myMat.Specular = specular;
            myMat.Opacity = opacity;
            myMat.TwoSided = twoSided;
            return myMat;
        }

        static Material GetMaterial(int materialId)
        {
            Material[] myArray = new Material[5];

            myArray[0] = MakeNewMaterial("wood", 0.5f, 0.5f, 0.5f, true);
            myArray[1] = MakeNewMaterial("water", 1.5f, 0.5f, 0.5f, true);
            myArray[2] = MakeNewMaterial("brick", 0.5f, 2.5f, 0.5f, true);
            myArray[3] = MakeNewMaterial("sand", 0.5f, 0.5f, 0.5f, false);
            myArray[4] = MakeNewMaterial("grass", 0.5f, 0.5f, 0.5f, true);

            return myArray[materialId];

            //return MakeNewMaterial("default", 0.5f, 1.0f, 0.1f, false); ;
        }



        static void Main(string[] args)
        {
            //miniGame();
            //var currentMaterial = GetMaterial(42);
            //currentMaterial.Opacity

            //// 2^5  a^exponent
            //// 2 * 2 * 2 * 2 * 2

            //int number = Pow(2, 5);

            //Console.WriteLine(number);

            //int typedNumber = 0;
            //string typed = Console.ReadLine();
            //int.TryParse(typed, out typedNumber);


            //typedNumber = 0;
            //typed = Console.ReadLine();
            //int.TryParse(typed, out typedNumber);


            Class1.CorrectionMiniJeu();


            Console.ReadKey();
            return;
            //int count = 0;


            //while (count < typedNumber)
            //{
            //    count = count + 1;
            //    Console.WriteLine("Je ne dois pas copier sur mon voisin !" + count);
            //}

            //Console.ReadKey();
            //return;
            //int typedNumber = 42;
            //int iterations = 0;

            ////while (iterations < 50)
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Tappez votre age ");


            //}
            //Console.ReadKey();
            //return;
            //Console.WriteLine("Tappez votre age");

            //var typed = Console.ReadLine();
            //int.TryParse(typed, out typedNumber);

            //Console.WriteLine(typedNumber);


            //if (typedNumber > 18)
            //{
            //    Console.WriteLine("T'es majeur");
            //}
            //else
            //{
            //    Console.WriteLine("T'es mineur");
            //}

            //Console.ReadKey();
            ////return;
            //int mavariable = 5;

            //bool test = !(mavariable != 42); // < > <= >= == != // Operateurs de comparaisons

            //// &&
            //// ||
            //// Commentaire sur une ligne
            ///* 
            // Commentaire sur plusieurs lignes

            // */
            //if (mavariable == 32 || (mavariable * 2 != 42 && !(mavariable > 18)))
            //{
            //    Console.WriteLine("Yeah!");
            //}

            //Console.WriteLine("Appuyez sur une touche pour terminer...");
            //Console.ReadKey();
        }
    }
}
