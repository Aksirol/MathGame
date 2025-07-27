using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MathGame
{
    public class Logic
    {
        static Random random = new Random();

        public static void Addition()
        {
            Console.WriteLine($"Game started! Type 'Exit', if you want to end the game");

            while (true)
            {
                int a = random.Next(100);
                int b = random.Next(100);
                int x = a + b;

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
                int a = random.Next(100);
                int b = random.Next(100);
                int x = a - b;

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
                int a = random.Next(100);
                int b = random.Next(100);
                int x = a * b;

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


        }


        /*
        string History()
        {

        }
        */
    }
}