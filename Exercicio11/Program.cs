Console.Write("Digite seu nome: ");
string? nome = Console.ReadLine();

Console.WriteLine();

Console.Write("Digite sua idade: ");
int idade = Convert.ToInt32(Console.ReadLine());


// Calcula os dias de vida (idade × 365)
int diasDeVida = idade * 365;

Console.WriteLine();

Console.WriteLine(nome + ", você já viveu " + diasDeVida + " dias.");

// Aguarda o usuário pressionar Enter antes de encerrar
Console.ReadLine();
