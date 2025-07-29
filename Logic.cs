namespace MathGame
{
    public class Logic
    {
        private static int a;
        private static int b;
        private static int x;
        private static Random random = new Random();
        public static void Addition() => PlayGame((a, b) => a + b, "+");
        public static void Subtraction() => PlayGame((a, b) => a - b, "-");
        public static void Multiplication() => PlayGame((a, b) => a * b, "*");
        public static void Division() => PlayGame((a, b) => a / b, "/");

        /*
        string History()
        {

        }
        */

        public static void PlayGame(Func<int, int, int> operation, string operatorSymbol)
        {
            Console.WriteLine($"Game started! Type 'Exit', if you want to end the game");

            while (true)
            {
                if (operatorSymbol == "/")
                {
                    do
                    {
                        Numbers(out a, out b);
                    } while ((a % b != 0) || (b == 0));
                }
                else
                {
                    Numbers(out a, out b);
                    x = operation(a, b);
                }

                Console.WriteLine($"{a} {operatorSymbol} {b} = ");

                var userInput = Console.ReadLine();

                if (userInput?.ToLower() == "exit")
                {
                    break;
                }

                if (int.TryParse(userInput, out int userAnswer))
                {
                    if (userAnswer == x)
                    {
                        Console.WriteLine($"{a} {operatorSymbol} {b} = {userAnswer} - Correct!");
                    }
                    else
                    {
                        Console.WriteLine($"{a} {operatorSymbol} {b} = {userAnswer} - Wrong!");
                    }
                }
                else
                {
                    Console.WriteLine("Wrong input! Please, type an integer value.");
                }
            }
        }

        public static void Numbers(out int number1, out int number2)
        {
            number1 = random.Next(1, 100);
            number2 = random.Next(1, 100);
        }
    }
}