var date = DateTime.UtcNow.DayOfWeek;

var name = GetName();

Menu(name);

void AdditionGame()
{
    var random = new Random();

    int firstNumber;
    int secondNumber;

    var score = 0;

    for (int i = 0; i < 5; i++)
    {
        Console.Clear();

        firstNumber = random.Next(1, 10);
        secondNumber = random.Next(1, 10);

        Console.WriteLine($"{firstNumber} + {secondNumber}");

        var input = Console.ReadLine();

        if (int.Parse(input) == firstNumber + secondNumber)
        {
            Console.WriteLine("Your answer was correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Your answer was incorrect.");
        }
    }
    Console.WriteLine($"Game over. Score: {score}/5");
}

void SubtractionGame()
{
    var random = new Random();

    int firstNumber;
    int secondNumber;

    var score = 0;

    for (int i = 0; i < 5; i++)
    {
        Console.Clear();

        firstNumber = random.Next(1, 10);
        secondNumber = random.Next(1, 10);

        Console.WriteLine($"{firstNumber} - {secondNumber}");

        var input = Console.ReadLine();

        if (int.Parse(input) == firstNumber - secondNumber)
        {
            Console.WriteLine("Your answer was correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Your answer was incorrect.");
        }
    }
    Console.WriteLine($"Game over. Score: {score}/5");
}

void MultiplicationGame()
{
    var random = new Random();

    int firstNumber;
    int secondNumber;

    var score = 0;

    for (int i = 0; i < 5; i++)
    {
        Console.Clear();

        firstNumber = random.Next(1, 10);
        secondNumber = random.Next(1, 10);

        Console.WriteLine($"{firstNumber} * {secondNumber}");

        var input = Console.ReadLine();

        if (int.Parse(input) == firstNumber * secondNumber)
        {
            Console.WriteLine("Your answer was correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Your answer was incorrect.");
        }
    }
    Console.WriteLine($"Game over. Score: {score}/5");
}

void DivisionGame()
{
    var random = new Random();

    int firstNumber;
    int secondNumber;

    var score = 0;

    for (int i = 0; i < 5; i++)
    {
        Console.Clear();

        firstNumber = random.Next(1, 10);
        secondNumber = random.Next(1, 10);

        Console.WriteLine($"{firstNumber} / {secondNumber}");

        var input = Console.ReadLine();

        if (int.Parse(input) == firstNumber / secondNumber)
        {
            Console.WriteLine("Your answer was correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Your answer was incorrect.");
        }
    }
    Console.WriteLine($"Game over. Score: {score}/5");
}

void Menu(string name)
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

string GetName()
{
    Console.WriteLine("Please enter your name:");

    var name = Console.ReadLine();
    return name;
}