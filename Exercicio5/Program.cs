Console.Write("Digite o salário base: ");
decimal salarioBase = Convert.ToDecimal(Console.ReadLine());

Console.Write("Digite o total de vendas: ");
decimal totalVendas = Convert.ToDecimal(Console.ReadLine());

Console.Write("Digite a porcentagem da comissão: ");
decimal porcentagemComissao = Convert.ToDecimal(Console.ReadLine());

// cálculo da comissão
decimal comissao = totalVendas * porcentagemComissao / 100;

// cálculo do salário total
decimal salarioTotal = salarioBase + comissao;

Console.WriteLine("Comissão: " + comissao);
Console.WriteLine("Salário total: " + salarioTotal);

Console.ReadLine();