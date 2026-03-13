Console.Write("Digite a quantidade de pães vendidos: ");
int quantidadePaes = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite a quantidade de broas vendidas: ");
int quantidadeBroas = Convert.ToInt32(Console.ReadLine());

decimal precoPao = 0.12m;
decimal precoBroa = 1.50m;

// Calcula o total arrecadado com pães
decimal totalPaes = quantidadePaes * precoPao;

// Calcula o total arrecadado com broas
decimal totalBroas = quantidadeBroas * precoBroa;

// Calcula o total arrecadado no dia
decimal totalArrecadado = totalPaes + totalBroas;

// Calcula 10% do total para guardar na poupança
decimal valorPoupanca = totalArrecadado * 0.10m;

Console.WriteLine("Total arrecadado: R$ " + totalArrecadado);
Console.WriteLine("Guardar na poupança (10%): R$ " + valorPoupanca);

Console.ReadLine();
