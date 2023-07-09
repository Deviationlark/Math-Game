string operation;

string option = Menu();
string Menu()
{
    string option;
    Console.WriteLine("MATH GAME");
    Console.WriteLine("p. Play");
    Console.WriteLine("h. History");
    Console.WriteLine("e. Exit");
    Console.Write("Choose: ");
    option = Console.ReadLine();
    return option;
}
switch (option.Trim().ToLower())
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
        Console.WriteLine("----------------------");
        Console.WriteLine("HISTORY OF GAMES");
        break;

    case "e":
        Console.WriteLine("BYE");
        break;
    default:
        Console.WriteLine("wrong");
        Environment.Exit(1);
        break;
}
void Operator(string operation)
{
    switch (operation.Trim().ToLower())
    {
        case "a":
            AdditionGame("Addition Selected");
            break;
        case "s":
            SubstractionGame("Subtraction Selected");
            break;
        case "m":
            MultiplicationGame("Multiplication Selected");
            break;
        case "d":
            DivisionGame("Division Selected");
            break;
        default:
            Console.WriteLine("Invalid operation");
            Environment.Exit(1);
            break;
    }
}
void AdditionGame(string message)
{
    Console.WriteLine(message);
}
void SubstractionGame(string message)
{
    Console.WriteLine(message);
}

void DivisionGame(string message)
{
    Console.WriteLine(message);
}

void MultiplicationGame(string message)
{
    Console.WriteLine(message);
}

