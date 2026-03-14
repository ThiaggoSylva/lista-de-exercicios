Console.Write("Digite o valor de A: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o valor de B: ");
int B = Convert.ToInt32(Console.ReadLine());

int C;

if (A == B)
{
    C = A + B;
}
else
{
    C = A * B;
}

Console.WriteLine("O valor de C é: " + C);

Console.ReadLine();
