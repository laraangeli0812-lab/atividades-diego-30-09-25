//declaração de variáveis

Console.WriteLine("digite a 1ª nota: ");
double nota1 = double.Parse(Console.ReadLine());

Console.WriteLine("digite a 2ª nota: ");
double nota2 = double.Parse(Console.ReadLine());

double media = (nota1 + nota2) / 2;

Console.WriteLine($"nota da 1ª avaliação: {nota1}.");
Console.WriteLine($"nota da 2ª avaliação: {nota2}.");
Console.WriteLine($"média: {media:f2}.");

if (media >= 6.0)
    Console.WriteLine("aluno aprovado.");
else
    Console.WriteLine("aluno reprovado.");