Console.Write("Enter the length of the Fibonacci Series: ");

string input = Console.ReadLine();
int length = 0;

if (!Int32.TryParse(input, out length))
{
    Console.WriteLine("Número inválido.");
    return;
}

Console.WriteLine("----FibonacciSeries----");
for (int i = 0; i < length; i++)
{
    Console.Write("{0} ", FibonacciSeries(i));
}
Console.WriteLine("\n----------------");

Console.WriteLine("----Factorial----");
for (int i = 0; i < length; i++)
{
    Console.Write("{0} ", factorial(i));
}
Console.WriteLine("\n----------------");
Console.ReadKey();

static int FibonacciSeries(int n)
{
    if (n == 0) return 0;
    if (n == 1) return 1;
    return FibonacciSeries(n - 1) + FibonacciSeries(n - 2);
}

// recursive function 
static int factorial(int num)
{
    // termination condition
    if (num == 0)
        return 1;
    else
        // recursive call
        return num * factorial(num - 1);
}