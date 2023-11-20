using MyFirstProgram.Models;
using System.Linq;

namespace MyFirstProgram
{
    internal class Helpers
    {
        internal static List<Game> games = new List<Game>
        {
            new Game { Date = DateTime.Now.AddDays(1), Type = GameType.Addition, Score = 5 },
            new Game { Date = DateTime.Now.AddDays(2), Type = GameType.Multiplication, Score = 4 },
            new Game { Date = DateTime.Now.AddDays(3), Type = GameType.Division, Score = 4 },
            new Game { Date = DateTime.Now.AddDays(4), Type = GameType.Subtraction, Score = 3 },
            new Game { Date = DateTime.Now.AddDays(5), Type = GameType.Addition, Score = 1 },
            new Game { Date = DateTime.Now.AddDays(6), Type = GameType.Multiplication, Score = 2 },
            new Game { Date = DateTime.Now.AddDays(7), Type = GameType.Division, Score = 3 },
            new Game { Date = DateTime.Now.AddDays(8), Type = GameType.Subtraction, Score = 4 },
            new Game { Date = DateTime.Now.AddDays(9), Type = GameType.Addition, Score = 4 },
            new Game { Date = DateTime.Now.AddDays(10), Type = GameType.Multiplication, Score = 1 },
            new Game { Date = DateTime.Now.AddDays(11), Type = GameType.Subtraction, Score = 0 },
            new Game { Date = DateTime.Now.AddDays(12), Type = GameType.Division, Score = 2 },
            new Game { Date = DateTime.Now.AddDays(13), Type = GameType.Subtraction, Score = 5 }
        };

        internal static void GetGames()
        {
            // var gamesToPrint = games.Where(x => x.Date > new DateTime(2023, 11, 24) && x.Score > 3).OrderByDescending(x => x.Score);
            Console.Clear();
            Console.WriteLine("Games History:");
            Console.WriteLine("--------------------\n");

            foreach (var game in games)
            {
                Console.WriteLine(game.ToString());
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

        internal static void AddToHistory(int score, GameType gameType)
        {
            games.Add(new Game
            {
                Date = DateTime.Now,
                Score = score,
                Type = gameType
            });
        }
    }
}
