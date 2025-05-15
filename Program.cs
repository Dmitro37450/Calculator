// See https://aka.ms/new-console-template for more information

int result;
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

Console.Write("Input number 1: ");
result = Convert.ToInt16(Console.ReadLine());
Console.Write("Input number 2: ");
input = Convert.ToInt16(Console.ReadLine());

Console.WriteLine(Convert.ToString(division(input, result)));

// Console.WriteLine(Convert.ToString(plus()));
