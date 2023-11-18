namespace MyFirstProgram
{
    internal class GameEngine
    {

        internal void AdditionGame()
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

            Helpers.AddToHistory(score, "Addition");

            Console.WriteLine($"Game over. Score: {score}/5");
            Console.WriteLine("Enter any key to continue.");
            Console.ReadLine();
        }

        internal void SubtractionGame()
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

            Helpers.AddToHistory(score, "Subtraction");
            Console.WriteLine($"Game over. Score: {score}/5");
            Console.WriteLine("Enter any key to continue.");
            Console.ReadLine();
        }

        internal void MultiplicationGame()
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
            Helpers.AddToHistory(score, "Multiplication");

            Console.WriteLine($"Game over. Score: {score}/5");
            Console.WriteLine("Enter any key to continue.");
            Console.ReadLine();
        }

        internal void DivisionGame()
        {
            var random = new Random();

            int firstNumber;
            int secondNumber;

            var score = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();

                int[] numbers = Helpers.GetDivisionNumbers();

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
            Helpers.AddToHistory(score, "Division");

            Console.WriteLine($"Game over. Score: {score}/5");
            Console.WriteLine("Enter any key to continue.");
            Console.ReadLine();
        }

    }
}
