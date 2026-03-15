Console.Write("Digite um número: ");
        int limite = Convert.ToInt32(Console.ReadLine());

        int a = 0;
        int b = 1;

        Console.WriteLine("Sequência de Fibonacci:");

        while (a <= limite)
        {
            Console.Write(a + " ");

            int proximo = a + b; // soma dos dois números anteriores
            a = b;               // atualiza o primeiro número
            b = proximo;        // atualiza o segundo número
        }

        Console.ReadLine();