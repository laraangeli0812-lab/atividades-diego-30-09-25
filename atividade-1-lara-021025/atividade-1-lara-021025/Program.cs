//declaração de variáveis

int a = 10, b = 20, c = 0;

/*
console.writeline("Digite um valor pra A:");
a = int.parse(console.readline());
console.writeline("Digite um valor pra B:");
b = int.parse(console.readline());
*/

Console.WriteLine($"O valor ANTERIOR de: A = {a}, B = {b}");

c = a;
a = b;
b = c;

Console.WriteLine($"O valor ATUAL de: A = {a}, B = {b}");
