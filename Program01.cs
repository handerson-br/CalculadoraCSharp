// See https://aka.ms/new-console-template for more information

//Declare variaveis e  inicializar com zero.
int num1 = 0; int num2 = 0;

//Tela de titulos para o console.

Console.WriteLine("Calculadora de Console em C#\r");
Console.WriteLine("--------------------------  \n");

//Pergunta ao usuario o primeiro numero.
Console.WriteLine("Insira um numero, e pressione Enter ");
num1 = Convert.ToInt32(Console.ReadLine());

//Pergunta ao usuário o segundo numero.
Console.WriteLine("Insira o proximo numero, e precione Enter");
num2 = Convert.ToInt32(Console.ReadLine());

//Pergunta ao usuario qual a opção desejada.

Console.WriteLine("Escolha a opção a seguir na lista:");
Console.WriteLine("\ta - Soma");
Console.WriteLine("\ts - Subtração");
Console.WriteLine("\tm - Multiplicação");
Console.WriteLine("\td - Divisão");

//Uso um das opções matemáticas

switch (Console.ReadLine())
    {
    case "a":
        Console.WriteLine($"Seu Resultado é: {num1} + {num2} = " + (num1+num2));
        break;
    case "s":
        Console.WriteLine($"Seu Resultado é: {num1} - {num2} = " + (num1-num2));
        break;
    case "m":
        Console.WriteLine($"Seu Resultado é: {num1} * {num2} = " + (num1*num2));
        break;
    case "d":
        Console.WriteLine($"Seu Resultado é: {num1} / {num2} = " + (num1/num2));
        break;
    }
//Esperar o usuário responder para fechar a aplicação.
Console.Write("Precione qualquer tecla para fechar a Calculadora...");
Console.ReadKey();

    
