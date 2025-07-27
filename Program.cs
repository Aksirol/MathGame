Random random = new Random();
string[] menuOptions = { "Addition", "Subtraction", "Multiplication", "Division", "History", "Rules", "Exit" };
int c = 0;

Console.WriteLine($"Welcome to Math Game!");

foreach (string option in menuOptions)
{
    c++;
    Console.WriteLine($"{c}. {option}");
}

while (true)
{
    Console.WriteLine($"Enter the number of menu section\n");
    var input = Console.ReadLine();
    int result;
    bool success = int.TryParse(input, out result);

    if (success != true)
    {
        Console.WriteLine($"Please, enter the integer value");
    }
    else if (result > menuOptions.Length || result <= 0)
    {
        Console.WriteLine($"Please, enter number of menu options");
    }

    switch (result)
    {
        case 1:
            Addition();
            break;

        case 2:
            Subtraction();
            break;

        case 3:
            Multiplication();
            break;

        case 4:
           // Division();
            break;
    }
}

void Addition()
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

void Subtraction()
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

void Multiplication()
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

/*
void Division()
{
    Console.WriteLine($"Game started! Type 'Exit', if you want to end the game");

    while (true)
    {

        int a = random.Next(1, 100);
        int b = random.Next(1, 100);

        while (true)
        {

            if (a % b == 0)
            {
                int x = a / b;
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
            else
            {
                break;
            }

        }
    }
}
*/

/*
string History()
{

}
*/