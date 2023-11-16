Console.WriteLine("Please enter your name:");

var name = Console.ReadLine();

var date = DateTime.UtcNow.DayOfWeek;

Menu(name, date);

void AdditionGame()
{
    Console.WriteLine("Addition game selected.");
}

void SubtractionGame()
{
    Console.WriteLine("Subtraction game selected.");
}

void MultiplicationGame()
{
    Console.WriteLine("Multiplication game selected.");
}

void DivisionGame()
{
    Console.WriteLine("Division game selected.");
}

void Menu(string? name, DayOfWeek date)
{
    Console.WriteLine("---------------------------------------");

    var welcomeMessage = string.Format("Hello {0}. It's {1}. This is your math game. It's great that you're working on improving yourself.\n", name, date);

    Console.WriteLine(welcomeMessage);

    Console.WriteLine(@$"What game would you like to play today? Choose from the options below:

A - Addition
S - Subtraction
M - Multiplication
D - Division
Q - Quit the program
");

    var userChoice = Console.ReadLine().ToLower().Trim();

    switch (userChoice)
    {
        case "a":
            AdditionGame();
            break;
        case "s":
            SubtractionGame();
            break;
        case "m":
            MultiplicationGame();
            break;
        case "d":
            DivisionGame();
            break;
        case "q":
            Console.WriteLine("Goodbye.");
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Invalid input.");
            break;
    }
}