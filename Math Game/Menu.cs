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
                        Operator(operation);
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
            if (operation == "a"||operation == "s" || operation == "m" || operation == "d")
            {
                Difficulty("Operation Selected");
            }
        }
        public void Difficulty(string op)
        {
            Console.WriteLine(op);
            var difficultyInstance = new GameEngine();
            Console.WriteLine("\nChoose a Difficulty:");
            Console.WriteLine("e. Easy");
            Console.WriteLine("m. Medium");
            Console.WriteLine("h. Hard");
            difficulty = Console.ReadLine();
            switch (difficulty.Trim().ToLower())
            
               
            }
        }
    } 
}
