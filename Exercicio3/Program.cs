Console.Write("Digite a Quilometragem inicial: ");
decimal kmInicial = Convert.ToDecimal(Console.ReadLine());

Console.Write("Digite a Quilometragem Final do veiculo: ");
decimal kmFinal = Convert.ToDecimal(Console.ReadLine());

Console.Write("Digite a Quantidade de Combustivel consumido(litros): ");
decimal combustivelConsumido = Convert.ToDecimal(Console.ReadLine());

decimal distanciaPercorrida = kmFinal - kmInicial;

decimal consumoLitrosPorKm = distanciaPercorrida / combustivelConsumido;

Console.WriteLine($"O Consumo de Combustivel na Viagem foi de: {consumoLitrosPorKm}");