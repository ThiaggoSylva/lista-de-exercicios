int soma = 0;
int contador = 1;

while (contador <= 500)
{
    if (contador % 2 != 0 && contador % 3 == 0)
    {
        soma = soma + contador;
    }

    contador++;
}

Console.WriteLine("A soma é: " + soma);

Console.ReadLine();

