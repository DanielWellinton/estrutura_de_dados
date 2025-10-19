string esp = "************************************";
int[] integerValues = { -11, 12, -42, 0, 1, 90, 68, 6, -9 };

Console.WriteLine("Vetor de inteiros");
SelectionSort.SelectionSort.Sort(integerValues);
Console.WriteLine(string.Join(",", integerValues));
Console.WriteLine(esp);

string[] stringValues = {
    "Bolsonaro", "Kléber", "Putin", "Pica-Pau",
    "Matuê", "Barack Hussein Obama", "Taís Carla"
};

Console.WriteLine("Vetor de nomes");
SelectionSort.SelectionSort.Sort(stringValues);
Console.WriteLine(string.Join(",", stringValues));
Console.WriteLine(esp);