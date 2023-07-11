using static System.Formats.Asn1.AsnWriter;

Menu();
void Menu()
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
                Console.WriteLine("----------------------");
                Console.WriteLine("HISTORY OF GAMES");
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

        Console.WriteLine($"{firstNumber} + {secondNumber}");
        var result = Console.ReadLine();

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
            Console.WriteLine($"Game over. final score is {score}. Type any key to go back to menu");
            Console.ReadLine();
        }
    }
}
 void SubstractionGame(string message)
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
            Console.WriteLine($"Game over. final score is {score}. Type any key to go back to menu");
            Console.ReadLine();
        }
    }
}
void DivisionGame(string message)
{
    var score = 0;
    for (int i = 0; i < 5;i++)
    {
        Console.Clear();
        Console.WriteLine(message);

        var divisionNumbers = GetDivisionNumbers();
        var firstNumber = divisionNumbers[0];
        var secondNumber = divisionNumbers[1];

        Console.WriteLine($"{firstNumber} / {secondNumber}");
        var result = Console.ReadLine();

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
            Console.WriteLine($"Game over. final score is {score}. Type any key to go back to menu");
            Console.ReadLine();
        }
    }
}
void MultiplicationGame(string message)
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
            Console.WriteLine($"Game over. final score is {score}. Type any key to go back to menu");
            Console.ReadLine();
        }
    }
}
int[] GetDivisionNumbers()
{
    var random = new Random();
    var firstNumber = random.Next(1, 99);
    var secondNumber = random.Next(1, 99);

    var result = new int[2];
    
    while (firstNumber % secondNumber !=0)
    {
         firstNumber = random.Next(1, 99);
         secondNumber = random.Next(1, 99);
    }
    
    result[0] = firstNumber; 
    result[1] = secondNumber;

    return result;
}
