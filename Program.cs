// See https://aka.ms/new-console-template for more information

int result = 0;
int input;
char operation;

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
    if(x==0) return 0;
    return y / x;
}

// Core function
do {
    Console.Write("Input number 1: ");
    result = Convert.ToInt16(Console.ReadLine());
    Console.Write("Input number 2: ");
    input = Convert.ToInt16(Console.ReadLine());
    
    bool valid = false;
    do {
        Console.Clear();
        Console.WriteLine(Convert.ToString(result));
        Console.WriteLine("Input: " + Convert.ToString(input) + '\n');
        Console.WriteLine("[+]: Addition");
        Console.WriteLine("[-]: Subtraction");
        Console.WriteLine("[*]: Multiplication");
        Console.WriteLine("[/]: Division");

        Console.Write("Choose operation: ");
        operation = Console.ReadKey().KeyChar;

        switch (operation)
        {
            default:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nInvalid operation!");
            Console.ResetColor();
            Console.WriteLine("Press anything to continue.");
            Console.ReadKey();
            break;
        }

        if (valid) {
            valid = false;
        }

    } while (!valid);
    
} while(true);
/*
Console.Write("Input number 1: ");
result = Convert.ToInt16(Console.ReadLine());
Console.Write("Input number 2: ");
input = Convert.ToInt16(Console.ReadLine());

Console.WriteLine(Convert.ToString(division(input, result)));

// Console.WriteLine(Convert.ToString(plus()));
*/