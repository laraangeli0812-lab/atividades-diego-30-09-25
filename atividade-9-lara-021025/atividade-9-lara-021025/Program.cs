//declaração de variáveis

Console.WriteLine("digite a quantidade de maças compradas: ");

int quantidade = int.Parse(Console.ReadLine());

decimal precouni = (quantidade < 12) ? 1.30m : 1.00m;
decimal total = precouni * quantidade;

Console.WriteLine();
Console.WriteLine($"quantidade : {quantidade}");
Console.WriteLine($"preço unitário: {precouni.ToString("c")}");
Console.WriteLine($"custo total da compra de maçãs: {total.ToString("c")}");
