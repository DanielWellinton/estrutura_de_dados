Console.WriteLine("Invertendo palavras com pilhas");

Stack<char> chars = new Stack<char>();
Console.WriteLine("Digite uma palavra: ");
string? palavra = Console.ReadLine();
string? palavra_invertida = null;

foreach (var c in palavra)
{
    chars.Push(c);
}
while (chars.Count > 0)
{
    palavra_invertida += chars.Pop();
}
if (palavra_invertida.ToLower() == palavra.ToLower())
{
    Console.WriteLine("É um palíndromo");
}
Console.WriteLine(palavra_invertida);
Console.WriteLine("");