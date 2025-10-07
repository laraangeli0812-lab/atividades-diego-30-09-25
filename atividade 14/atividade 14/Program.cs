// declaração de variáveis

Console.WriteLine("digite um valor N (maior que 0): ");
int N = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine($"\nNumeros de 1 ate {N}:");
for (int i = 1; i <= N; i++)
               
Console.WriteLine(i);