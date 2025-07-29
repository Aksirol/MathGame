using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MathGame
{
    public class Logic
    {
        private static int a;
        private static int b;
        private static int x;
        public static void Addition()

        {
            Console.WriteLine($"Game started! Type 'Exit', if you want to end the game");

            while (true)
            {
                Numbers(out a, out b);
                x = a + b;

                Console.WriteLine($"{a} + {b} = ");

                var userInput = Console.ReadLine();

                if (userInput == "exit")
                {
                    break;
                }

                int userAnswer;
                bool success = int.TryParse(userInput, out userAnswer);

                if (success != true)
                {
                    Console.WriteLine($"Wrong input! Please, type integer value");
                }

                if (userAnswer == x)
                {
                    Console.WriteLine($"{a} + {b} = {userAnswer} - Correct!");
                }
                else
                {
                    Console.WriteLine($"{a} + {b} = {userAnswer} - Wrong!");
                }
            }
        }

        public static void Subtraction()
        {
            Console.WriteLine($"Game started! Type 'Exit', if you want to end the game");

            while (true)
            {
                Numbers(out a, out b);
                x = a - b;

                Console.WriteLine($"{a} - {b} = ");

                var userInput = Console.ReadLine();

                if (userInput == "exit")
                {
                    break;
                }

                int userAnswer;
                bool success = int.TryParse(userInput, out userAnswer);

                if (success != true)
                {
                    Console.WriteLine($"Wrong input! Please, type integer value");
                }

                if (userAnswer == x)
                {
                    Console.WriteLine($"{a} - {b} = {userAnswer} - Correct!");
                }
                else
                {
                    Console.WriteLine($"{a} - {b} = {userAnswer} - Wrong!");
                }
            }
        }

        public static void Multiplication()
        {
            Console.WriteLine($"Game started! Type 'Exit', if you want to end the game");

            while (true)
            {
                Numbers(out a, out b);
                x = a * b;

                Console.WriteLine($"{a} * {b} = ");

                var userInput = Console.ReadLine();

                if (userInput == "exit")
                {
                    break;
                }

                int userAnswer;
                bool success = int.TryParse(userInput, out userAnswer);

                if (success != true)
                {
                    Console.WriteLine($"Wrong input! Please, type integer value");
                }

                if (userAnswer == x)
                {
                    Console.WriteLine($"{a} * {b} = {userAnswer} - Correct!");
                }
                else
                {
                    Console.WriteLine($"{a} * {b} = {userAnswer} - Wrong!");
                }
            }
        }

        public static void Division()
        {
            Console.WriteLine($"Game started! Type 'Exit', if you want to end the game");

            while (true)
            {
                do
                {
                    Numbers(out a, out b);

                } while ((a % b != 0) || (b == 0));

                x = a / b;

                Console.WriteLine($"{a} / {b} = ");

                var userInput = Console.ReadLine();

                if (userInput == "exit")
                {
                    break;
                }

                int userAnswer;
                bool success = int.TryParse(userInput, out userAnswer);

                if (success != true)
                {
                    Console.WriteLine($"Wrong input! Please, type integer value");
                }

                if (userAnswer == x)
                {
                    Console.WriteLine($"{a} / {b} = {userAnswer} - Correct!");
                }
                else
                {
                    Console.WriteLine($"{a} / {b} = {userAnswer} - Wrong!");
                }
            }
        }


        /*
        string History()
        {

        }
        */

        public static void Numbers(out int number1, out int number2)
        {
            Random random = new Random();
            number1 = random.Next(1, 100);
            number2 = random.Next(1, 100);
        }
    }
}