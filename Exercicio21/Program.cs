// Pede para o usuário digitar um número
Console.Write("Digite um número: ");
int A = Convert.ToInt32(Console.ReadLine());

// A variável contador começa com o valor digitado
int contador = A;

// Variável que armazenará o resultado do fatorial
int fatorial = 1;

// Mostra o início da expressão do fatorial (ex: 5! = )
Console.Write(A + "! = ");

// Enquanto contador for maior que 0 o laço continuará executando
while (contador > 0)
{
    // Mostra o número atual da multiplicação
    Console.Write(contador);

    // Se ainda houver números para multiplicar, mostra o "x"
    if (contador > 1)
    {
        Console.Write(" x ");
    }

    // Calcula o fatorial multiplicando o valor atual
    fatorial = fatorial * contador;

    // Diminui 1 do valor de contador
    contador--;
}

// Mostra o resultado final do fatorial
Console.WriteLine(" = " + fatorial);

//Pede que o usuario Digite Enter para finalizar o programa
Console.ReadLine();

