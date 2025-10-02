//declaração de variáveis

int nu1;

Console.WriteLine("Digite um número.");
nu1 = int.Parse(Console.ReadLine());

if (nu1 > 10) {
    Console.WriteLine($"O número {nu1} é MAIOR que 10.");
}
else
{
    Console.WriteLine($"O número {nu1} é MENOR que 10.");
}