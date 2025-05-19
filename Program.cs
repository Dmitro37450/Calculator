// See https://aka.ms/new-console-template for more information

using Microsoft.VisualBasic;

int result = 0;
int input;
char operation;
char[] availableOperations = { '+', '-', '/', '*' };

static int addition(int y, int x = 0) {
    return x + y;
};

static int subtraction(int y, int x = 0) {
    return x - y;
}

static int multiplication(int y, int x = 0) {
    return x * y;
}

static int division(int y, int x = 0) {
    if (x == 0) return 0;
    return x / y;
}

void operationChoose()
{
    do
    {
        Console.WriteLine("[+]: Addition");
        Console.WriteLine("[-]: Subtraction");
        Console.WriteLine("[*]: Multiplication");
        Console.WriteLine("[/]: Division");

        Console.Write("Choose operation: ");
        operation = Console.ReadKey().KeyChar;

        if (!availableOperations.Contains(operation))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nInvalid operation!");
            Console.ResetColor();
            Console.WriteLine("Press anything to continue.");
            Console.ReadKey();
        }
        else
        {
            break;
        }

    } while (true);
}
// Core function

Console.Write("Input number: ");
result = Convert.ToInt16(Console.ReadLine());
operationChoose();

do
{
    Console.Write("\nInput number: ");
    input = Convert.ToInt16(Console.ReadLine());
    switch (operation)
    {
        case '+':
            result = addition(input, result);
            break;
        case '-':
            result = subtraction(input, result);
            break;
        case '*':
            result = multiplication(input, result);
            break;
        case '/':
            result = division(input, result);
            break;
        default:
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("\nSomething Went Wrong!");
            Environment.Exit(0);
            break;
    }

    //Console.Clear();
    Console.WriteLine("\nResult: "+result);

    operationChoose();
} while (true);