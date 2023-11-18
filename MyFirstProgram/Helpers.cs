namespace MyFirstProgram
{
    internal class Helpers
    {
        static List<string> games = new List<string>();

        internal static void GetGames()
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

        internal static int[] GetDivisionNumbers()
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

        internal static void AddToHistory(int score, string gameType)
        {
            games.Add($"{DateTime.Now} - {gameType}: {score} pts");
        }
    }
}
