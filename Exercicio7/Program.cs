Console.Write("Digite a nota da primeira prova: ");
decimal nota1 = Convert.ToDecimal(Console.ReadLine());

Console.Write("Digite o peso da primeira prova: ");
decimal peso1 = Convert.ToDecimal(Console.ReadLine());

Console.Write("Digite a nota da segunda prova: ");
decimal nota2 = Convert.ToDecimal(Console.ReadLine());

Console.Write("Digite o peso da segunda prova: ");
decimal peso2 = Convert.ToDecimal(Console.ReadLine());

decimal somaPesos = peso1 + peso2;

decimal mediaPonderada = (nota1 * peso1 + nota2 * peso2) / somaPesos;

Console.WriteLine("---------------------------------");
Console.WriteLine("A Média ponderada é: " + mediaPonderada);
Console.WriteLine("---------------------------------");

Console.ReadLine();