namespace MyFirstProgram
{
    internal class Menu
    {

        GameEngine gameEngine = new GameEngine();

        internal void ShowMenu(string name, DateTime date)
        {
            Console.WriteLine("---------------------------------------");

            var welcomeMessage = string.Format("Hello {0}. It's {1}. This is your math game. It's great that you're working on improving yourself.\n", name, date.DayOfWeek);

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
                        Helpers.GetGames();
                        break;
                    case "a":
                        gameEngine.AdditionGame();
                        break;
                    case "s":
                        gameEngine.SubtractionGame();
                        break;
                    case "m":
                        gameEngine.MultiplicationGame();
                        break;
                    case "d":
                        gameEngine.DivisionGame();
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

    }
}
