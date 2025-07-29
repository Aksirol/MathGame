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
            Console.WriteLine($"Welcome to Math Game!");

            var options = Enum.GetNames(typeof(MenuOptions));
            for (int i = 0; i < options.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {options[i]}");
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
                    continue;
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