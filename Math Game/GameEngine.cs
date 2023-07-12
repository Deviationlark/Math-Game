using System.Security.Cryptography.X509Certificates;

namespace Math_Game
{
    internal class GameEngine
    {
        internal int Low()
        {
            var diff = new Menu();
            var low = 1;
            return low;
            switch(diff)
            
        }
        internal int High()
        {
            var high = 9;
            return high;
        }
        internal void AdditionGame(string message)
        {
            
            
            var random = new Random();
            var score = 0;

            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);
                firstNumber = random.Next(Low(), High());
                secondNumber = random.Next(Low(), High();

                

                Console.WriteLine($"{firstNumber} + {secondNumber}");
                var result = Console.ReadLine();

                result = Helpers.ValidationResult(result);

               

                if (int.Parse(result) == firstNumber + secondNumber)
                {
                    Console.WriteLine("Your answer is correct! Type for next question");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Wrong. Type for next question");
                    Console.ReadLine();
                }

                if (i == 4)
                {
                    Console.WriteLine($"Game over. final score is {score}. Press enter to go back to menu.");
                    Console.ReadLine();
                }
            }


            Helpers.AddToHistory(score, Models.GameType.Addition);
        }

        internal void SubstractionGame(string message)
        {
            var random = new Random();
            var score = 0;

            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);

                Console.WriteLine($"{firstNumber} - {secondNumber}");
                var result = Console.ReadLine();

                result = Helpers.ValidationResult(result);

                if (int.Parse(result) == firstNumber - secondNumber)
                {
                    Console.WriteLine("Your answer is correct! Type for next question");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Wrong. Type for next question");
                    Console.ReadLine();
                }

                if (i == 4)
                {
                    Console.WriteLine($"Game over. final score is {score}. Press enter to go back to menu.");
                    Console.ReadLine();
                }


            }

            Helpers.AddToHistory(score, Models.GameType.Substraction);
        }
        internal void DivisionGame(string message)
        {
            var score = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                var divisionNumbers = Helpers.GetDivisionNumbers();
                var firstNumber = divisionNumbers[0];
                var secondNumber = divisionNumbers[1];

                Console.WriteLine($"{firstNumber} / {secondNumber}");
                var result = Console.ReadLine();

                result = Helpers.ValidationResult(result);

                if (int.Parse(result) == firstNumber / secondNumber)
                {
                    Console.WriteLine("Your answer is correct! Type for next question");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Wrong. Type for next question");
                    Console.ReadLine();
                }

                if (i == 4)
                {
                    Console.WriteLine($"Game over. final score is {score}. Press enter to go back to menu.");
                    Console.ReadLine();
                }


            }

            Helpers.AddToHistory(score, Models.GameType.Division);
        }
        internal void MultiplicationGame(string message)
        {
            var random = new Random();
            var score = 0;

            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);
                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);

                Console.WriteLine($"{firstNumber} * {secondNumber}");
                var result = Console.ReadLine();

                result = Helpers.ValidationResult(result);

                if (int.Parse(result) == firstNumber * secondNumber)
                {
                    Console.WriteLine("Your answer is correct! Type for next question");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Wrong. Type for next question");
                    Console.ReadLine();
                }

                if (i == 4)
                {
                    Console.WriteLine($"Game over. final score is {score}. Press enter to go back to menu.");
                    Console.ReadLine();
                }


            }

            Helpers.AddToHistory(score, Models.GameType.Multiplication);
        }
    }
}
