using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MathGame
{
    public class Menu
    {
        public static void MenuInterface()
        {
            int c = 0;

            Console.WriteLine($"Welcome to Math Game!");

            foreach (string option in Enum.GetNames(typeof(MenuOptions)))
            {
                c++;
                Console.WriteLine($"{c}. {option}");
            }

            while (true)
            {
                Console.WriteLine($"Enter the number of menu section");
                var input = Console.ReadLine();
                int result;
                bool success = int.TryParse(input, out result);

                if (success != true)
                {
                    Console.WriteLine($"Please, enter the integer value");
                }
                else if (result > 7 || result <= 0)
                {
                    Console.WriteLine($"Please, enter number of menu options");
                }

                switch (result)
                {
                    case 1:
                        Logic.Addition();
                        break;

                    case 2:
                        Logic.Subtraction();
                        break;

                    case 3:
                        Logic.Multiplication();
                        break;

                    case 4:
                        Logic.Division();
                        break;
                }
            }
        }
    }
}