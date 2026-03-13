Console.Write("Digite o salário inicial: ");
decimal salarioInicial = Convert.ToDecimal(Console.ReadLine());

// Aumento de 15%
decimal aumento = salarioInicial * 0.15m;
decimal salarioComAumento = salarioInicial + aumento;

// Desconto de 8% de impostos
decimal imposto = salarioComAumento * 0.08m;
decimal salarioFinal = salarioComAumento - imposto;

// Exibindo os resultados
Console.WriteLine("Salário inicial: " + salarioInicial);
Console.WriteLine();
Console.WriteLine("Salário com aumento: " + salarioComAumento);
Console.WriteLine();
Console.WriteLine("Salário final: " + salarioFinal);

Console.ReadLine();
