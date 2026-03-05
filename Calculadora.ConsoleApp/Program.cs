while (true)
{
    Console.Clear();

    Console.WriteLine("---- Calculadora ----");
    Console.WriteLine("1 - Somar");
    Console.WriteLine("2 - Subtrair");
    Console.WriteLine("3 - Multiplicar");
    Console.WriteLine("4 - Dividir");
    Console.WriteLine("5 - Sair");

    Console.Write("Escolha: ");
    string opcao = Console.ReadLine();

    if (opcao == "5")
    {
        break;
    }

    Console.Write("Digite o primeiro numero: ");
    double n1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Digite o segundo numero: ");
    double n2 = Convert.ToDouble(Console.ReadLine());

    double resultado = 0;

    if (opcao == "1")
    {
        resultado = n1 + n2;
    }
    else if (opcao == "2")
    {
        resultado = n1 - n2;
    }
    else if (opcao == "3")
    {
        resultado = n1 * n2;
    }
    else if (opcao == "4")
    {
        if (n2 == 0)
        {
            Console.WriteLine("Nao pode dividir por zero");
            Console.ReadLine();
            continue;
        }

        resultado = n1 / n2;
    }
    else
    {
        Console.WriteLine("Opcao invalida");
        Console.ReadLine();
        continue;
    }

    Console.WriteLine("Resultado: " + resultado);
    Console.ReadLine();
}