Console.Write("Digite a largura do terreno: ");
decimal largura = Convert.ToDecimal(Console.ReadLine());

Console.Write("Digite o comprimento do terreno: ");
decimal comprimento = Convert.ToDecimal(Console.ReadLine());

decimal area = largura * comprimento;

Console.WriteLine("A área do terreno é: " + area + " m²");

Console.ReadLine();
