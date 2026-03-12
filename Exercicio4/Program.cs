Console.Write("Digite a temperatura em Celsius: ");
double celsius = Convert.ToDouble(Console.ReadLine());

double fahrenheit = (celsius * 9 / 5) + 32;

Console.WriteLine("A Temperatura em Fahrenheit é: " + fahrenheit);

Console.ReadLine();