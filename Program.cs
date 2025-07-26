string[] menuOptions = { "Addition", "Subtraction", "Multiplication", "Division", "Rules", "Exit" };
int c = 0;

Console.WriteLine($"Welcome to Math Game!");

foreach (string option in menuOptions)
{
    c++;
    Console.WriteLine($"{c}. {option}");
}



/*while (true)
{

}
*/