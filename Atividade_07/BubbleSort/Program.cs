using BubbleSort;

string esp = "****************************";
Console.WriteLine("Ordenacao com BubbleSort");
Console.WriteLine(esp);
Console.WriteLine("Vetor Inicial");
int[] arrNumbers = new int[] { 99, 50, -24, 0, 1 };
foreach (var number in arrNumbers)
{
    Console.Write($" [{number}] ");
}
Console.WriteLine("\n"+esp);
Console.WriteLine("Vetor Ordenado");
var arrOrdered = BubbleSortOrder.Sort<int>(arrNumbers);
foreach (var number in arrOrdered)
{
    Console.Write($" [{number}] ");
}
Console.WriteLine("\n" + esp);

Console.WriteLine("Ordenacao com BubbleSort - String");
Console.WriteLine(esp);
Console.WriteLine("Vetor Inicial");
string[] arrStrings = new string[] { "A", "50", "Z", "T"};
foreach (var i in arrStrings)
{
    Console.Write($" [{i}] ");
}
Console.WriteLine("\n"+esp);
Console.WriteLine("Vetor Ordenado");
var arrOrderedString = BubbleSortOrder.Sort<string>(arrStrings);
foreach (var i in arrOrderedString)
{
    Console.Write($" [{i}] ");
}
Console.WriteLine("\n"+esp);
