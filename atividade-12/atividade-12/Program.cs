//declaração de variáveis

Console.WriteLine("digite o primeiro valor: ");
double a = double.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("digite o segundo valor: ");
double b = double.Parse(Console.ReadLine() ?? "0");

double maior = (a > b) ? a : b;

Console.WriteLine($"o maior valor é: {maior}");