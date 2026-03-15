// Laço que percorre de 1 até 100
        for (int i = 1; i <= 100; i++)
        {
            // Verifica se é múltiplo de 3 e 5
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            // Verifica se é múltiplo de 3
            else if (i % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            // Verifica se é múltiplo de 5
            else if (i % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            // Caso não seja múltiplo
            else
            {
                Console.WriteLine(i);
            }
        }

        Console.ReadLine();