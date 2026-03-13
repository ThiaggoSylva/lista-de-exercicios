Console.Write("Digite um número: ");
int numero = Convert.ToInt32(Console.ReadLine());

bool primo = true;

// Números menores ou iguais a 1 não são primos
if (numero <= 1)
{
    primo = false;
}
else
{
    //laço de que verifica se o numero é divisivel por 2 ou numero anterior a ele
    for (int contador = 2; contador < numero; contador++)
    {
        if (numero % contador == 0)
        {
            primo = false;
            break;
        }
    }
}

if (primo)
{
    Console.WriteLine("O número é primo.");
}
else
{
    Console.WriteLine("O número não é primo.");
}

Console.ReadLine();
