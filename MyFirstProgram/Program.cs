var date = DateTime.UtcNow.DayOfWeek;

var games = new List<string>();

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

        Console.WriteLine("Enter any key to continue.");
        Console.ReadLine();
    }

    AddToHistory(score, "Addition");

    Console.WriteLine($"Game over. Score: {score}/5");
    Console.WriteLine("Enter any key to continue.");
    Console.ReadLine();
}

void AddToHistory(int score, string gameType)
{
    games.Add($"{DateTime.Now} - {gameType}: {score} pts");
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

        Console.WriteLine("Enter any key to continue.");
        Console.ReadLine();
    }

    AddToHistory(score, "Subtraction");
    Console.WriteLine($"Game over. Score: {score}/5");
    Console.WriteLine("Enter any key to continue.");
    Console.ReadLine();
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

        Console.WriteLine("Enter any key to continue.");
        Console.ReadLine();
    }
    AddToHistory(score, "Multiplication");

    Console.WriteLine($"Game over. Score: {score}/5");
    Console.WriteLine("Enter any key to continue.");
    Console.ReadLine();
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

        int[] numbers = GetDivisionNumbers();

        firstNumber = numbers[0];
        secondNumber = numbers[1];

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

        Console.WriteLine("Enter any key to continue.");
        Console.ReadLine();
    }
    AddToHistory(score, "Division");

    Console.WriteLine($"Game over. Score: {score}/5");
    Console.WriteLine("Enter any key to continue.");
    Console.ReadLine();
}

void Menu(string name)
{
    Console.WriteLine("---------------------------------------");

    var welcomeMessage = string.Format("Hello {0}. It's {1}. This is your math game. It's great that you're working on improving yourself.\n", name, date);

    Console.WriteLine(welcomeMessage);

        bool gameOn = true;

    do
    {


        Console.WriteLine(@$"What game would you like to play today? Choose from the options below:
        
        V - Get game history
        A - Addition
        S - Subtraction
        M - Multiplication
        D - Division
        Q - Quit the program
        ");

        var userChoice = Console.ReadLine().ToLower().Trim();

        switch (userChoice)
        {
            case "v":
                GetGames();
                break;
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
                gameOn = false;
                break;
            default:
                Console.WriteLine("Invalid input.");
                break;

        }

        Console.Clear();

    } while (gameOn);

    Console.WriteLine("Goodbye.");

}

void GetGames()
{
    Console.Clear();
    Console.WriteLine("Games History:");
    Console.WriteLine("--------------------\n");

    foreach (var game in games)
    {
        Console.WriteLine(game);
    }
    Console.WriteLine("--------------------\n");

    Console.WriteLine("Enter any key to continue.");
    Console.ReadLine();
}

string GetName()
{
    Console.WriteLine("Please enter your name:");

    var name = Console.ReadLine();
    return name;
}

int[] GetDivisionNumbers()
{
    int number1;
    int number2;

    var random = new Random();

    do
    {
        number1 = random.Next(1, 100);
        number2 = random.Next(1, 100);
    } while (number1 % number2 != 0);

    int[] numbers = { number1, number2 };

    return numbers;
}