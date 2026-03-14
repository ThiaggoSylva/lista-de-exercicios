Console.Write("Digite o peso (kg): ");
double peso = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a altura (m): ");
double altura = Convert.ToDouble(Console.ReadLine());

//Calcula o IMC Peso dividido por altura x altura
double imc = peso / (altura * altura);

Console.WriteLine("Seu IMC é: " + imc.ToString("F2"));

if (imc < 18.5)
{
    Console.WriteLine("Condição: Abaixo do peso");
}
else if (imc >= 18.5 && imc < 25)
{
    Console.WriteLine("Condição: Peso normal");
}
else if (imc >= 25 && imc < 30)
{
    Console.WriteLine("Condição: Acima do peso");
}
else
{
    Console.WriteLine("Condição: Obeso");
}

Console.ReadLine();
