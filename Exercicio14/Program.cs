Console.WriteLine("Digite 3 numeros diferentes");
Console.WriteLine();

Console.Write("Digite o primeiro número: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o segundo número: ");
int B = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o terceiro número: ");
int C = Convert.ToInt32(Console.ReadLine());

//Valida se o usuario nao digitou valores iguais
if (A == B || A == C || B == C)
{
    Console.WriteLine("Erro: Os números devem ser diferentes.");
    return;
}


// Verifica se A é o maior número
if (A > B && A > C)
{
    if (B > C)
        // Se B é maior que C, a ordem decrescente é A, B, C
        Console.WriteLine($"{A}, {B}, {C}");
    else
        // Caso contrário, C é maior que B
        Console.WriteLine($"{A}, {C}, {B}");
}
// Verifica se B é o maior número
else if (B > A && B > C)
{
    if (A > C)
        // Se A é maior que C, a ordem é B, A, C
        Console.WriteLine($"{B}, {A}, {C}");
    else
        // Caso contrário, C é maior que A
        Console.WriteLine($"{B}, {C}, {A}");
}
else
{
    // Verificamos quem é maior entre A e B
    if (A > B)
        // Se A é maior que B
        Console.WriteLine($"{C}, {A}, {B}");
    else
        // Caso contrário B é maior que A
        Console.WriteLine($"{C}, {B}, {A}");
}