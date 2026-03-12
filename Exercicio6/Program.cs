Console.Write("Digite a quantidade de notas: ");
int quantidade = Convert.ToInt32(Console.ReadLine());

//Cria um array armazenando as notas
decimal[] notas = new decimal[quantidade];
decimal soma = 0;

//Usa um for para ler as notas e somar o inverso delas
for (int contador = 0; contador < quantidade; contador++)
{
    Console.Write($"Digite a nota {contador + 1}: ");
    notas[contador] = Convert.ToDecimal(Console.ReadLine());

    soma += 1 / notas[contador];
}

//calcula a média harmonica do aluno
decimal mediaHarmonica = quantidade / soma;

Console.WriteLine($"A média harmônica é: {mediaHarmonica:F2}");

Console.ReadLine();