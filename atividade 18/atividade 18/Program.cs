//declaração de variáveis

class Program
{
    static void Main()
    {
        List<int> numeros = new List<int>();
        bool todosSaoPares = true;

        while (true)
        {
            Console.Write("Digite um número (0 para encerrar): ");
            int num = int.Parse(Console.ReadLine());

            if (num == 0)
            {
                if (todosSaoPares)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Nem todos os números são pares. A leitura continuará.");
                    continue;
                }
            }

            numeros.Add(num);

            if (num % 2 != 0)
            {
                todosSaoPares = false;
            }
        }

        if (numeros.Count > 0)
        {
            double soma = 0;
            foreach (int n in numeros)
            {
                soma += n;
            }

            double media = soma / numeros.Count;
            Console.WriteLine($"\nMédia dos números digitados: {media:F2}");
        }
        else
        {
            Console.WriteLine("Nenhum número foi digitado para calcular a média.");
        }
    }
}
