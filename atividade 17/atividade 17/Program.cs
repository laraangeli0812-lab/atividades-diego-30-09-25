//declaração de variáveis

class Program
{
    static void Main()
    {
        Console.Write("Digite a quantidade de valores a serem lidos: ");
        int n = int.Parse(Console.ReadLine());

        int negativos = 0;

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Digite o {i + 1}º valor: ");
            double valor = double.Parse(Console.ReadLine());

            if (valor < 0)
            {
                negativos++;
            }
        }

        Console.WriteLine($"\nQuantidade de valores negativos: {negativos}");
    }
}