//declaração de variáveis

class Program
{
    static void Main()
    {
        Console.Write("Digite a quantidade de números (N): ");
        int n = int.Parse(Console.ReadLine());

        if (n < 3)
        {
            Console.WriteLine("Erro: N deve ser pelo menos 3 para calcular a média excluindo o menor e o maior valor.");
            return;
        }

        List<double> numeros = new List<double>();

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Digite o {i + 1}º número: ");
            double numero = double.Parse(Console.ReadLine());
            numeros.Add(numero);
        }

        double menor = numeros[0];
        double maior = numeros[0];

        foreach (double num in numeros)
        {
            if (num < menor)
                menor = num;
            if (num > maior)
                maior = num;
        }

        numeros.Remove(menor);
        numeros.Remove(maior);

        double soma = 0;
        foreach (double num in numeros)
        {
            soma += num;
        }

        double media = soma / numeros.Count;

        Console.WriteLine($"\nMédia excluindo o menor ({menor}) e o maior ({maior}): {media:F2}");
    }
}
