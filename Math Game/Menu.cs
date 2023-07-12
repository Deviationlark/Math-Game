namespace Math_Game
{
    internal class Menu
    {
        GameEngine gameEngine = new();
        internal void ShowMenu()
        {
            bool isGameOn = true;
            do
            {
                Console.Clear();
                string? operation;
                string? option;
                Console.WriteLine("MATH GAME");
                Console.WriteLine("p. Play");
                Console.WriteLine("h. History");
                Console.WriteLine("e. Exit");
                Console.Write("Choose: ");
                option = Console.ReadLine();

                switch (option?.Trim().ToLower())
                {

                    case "p":
                        Console.WriteLine("\na. +");
                        Console.WriteLine("s. -");
                        Console.WriteLine("m. *");
                        Console.WriteLine("d. /");
                        Console.Write("Choose an operator: ");
                        operation = Console.ReadLine();
                        gameEngine.Operator(operation);
                        break;

                    case "h":
                        Helpers.History();
                        break;

                    case "e":
                        Console.WriteLine("BYE");
                        isGameOn = false;
                        break;

                    default:
                        Console.WriteLine("wrong");
                        break;
                }
            } while (isGameOn);
        }
        internal void Operator(string operation)
        {
            var operationInstance = new GameEngine();

            switch (operation.Trim().ToLower())
            {
                case "a":
                    operationInstance.AdditionGame("Addition Selected");
                    break;
                case "s":
                    operationInstance.SubstractionGame("Subtraction Selected");
                    break;
                case "m":
                    operationInstance.MultiplicationGame("Multiplication Selected");
                    break;
                case "d":
                    operationInstance.DivisionGame("Division Selected");
                    break;
                default:
                    Console.WriteLine("Invalid operation");
                    Environment.Exit(1);
                    break;
            }
        }
        internal void Difficulty(string difficulty)
        { Console.WriteLine(@"Choose a Difficulty:");
            Console.WriteLine("e. Easy");
            Console.WriteLine("m. Medium");
            Console.WriteLine("h. Hard");
            difficulty = Console.ReadLine();
            switch (difficulty.Trim().ToLower())
            
               
            }
        }
    } 
}
