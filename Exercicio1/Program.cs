Console.Write("Digite o comprimento da caixa: ");
decimal comprimento = Convert.ToDecimal(Console.ReadLine());

Console.Write("Digite a largura da caixa: ");
decimal largura = Convert.ToDecimal(Console.ReadLine());

Console.Write("Digite a altura da caixa: ");
decimal altura = Convert.ToDecimal(Console.ReadLine());

decimal volume = comprimento * largura * altura;

Console.WriteLine($"O volume da Caixa retangular é: {volume} cm³");

Console.ReadLine();