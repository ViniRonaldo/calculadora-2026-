    Console.WriteLine("Quantos anos você tem? ");

    string strIdade = Console.ReadLine();
    
    int idade = Convert.ToInt32(strIdade);

    if (idade < 18)
    {
        Console.WriteLine("Você é menor de idade: " + idade);
    }
    else
    {
        Console.WriteLine("Você é maior de idade: " + idade);
    }

    Console.ReadLine();