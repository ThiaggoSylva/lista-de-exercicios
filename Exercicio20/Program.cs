Console.Write("Digite um número de 1 a 10: ");
int N = Convert.ToInt32(Console.ReadLine());

int contador = 0;

while (contador <= 10)
{
    Console.WriteLine(contador + " x " + N + " = " + (contador * N));
    contador++;
}

Console.ReadLine();
