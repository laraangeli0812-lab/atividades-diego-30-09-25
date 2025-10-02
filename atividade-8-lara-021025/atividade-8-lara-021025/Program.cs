//declaração de variáveis

namespace VerificarValorPositivoOuNegativo
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            while (true)
            {
                Console.Write("Digite um número (diferente de zero): ");

                bool entradaValida = int.TryParse(Console.ReadLine(), out numero);

                if (!entradaValida)
                {
                    Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");
                }
                else if (numero == 0)
                {
                    Console.WriteLine("Valor zero não é permitido. Tente novamente.");
                }
                else
                {
                    break;
                }
            }
            if (numero > 0)
            {
                Console.WriteLine("O número é POSITIVO.");
            }
            else
            {
                Console.WriteLine("O número é NEGATIVO.");
            }
        }
    }
}
