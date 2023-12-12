using DesafioFundamentos.Models;

Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

bool precoInicialVerificado = false;
bool precoPorHoraVerificado = false;

Console.WriteLine("Seja bem vindo ao sistema de estacionamento!");
Console.WriteLine();

while(!precoInicialVerificado){
    Console.WriteLine("Digite o preço inicial:");
    precoInicial = Convert.ToDecimal(Console.ReadLine());

    if(precoInicial < 0){
        Console.WriteLine("Por favor, digite um valor maior ou igual a 0");
    }
    else{
        precoInicialVerificado = true;
    }
}

Console.WriteLine("--------------------------------------");

while(!precoPorHoraVerificado){
    Console.WriteLine("Agora digite o preço por hora:");
    precoPorHora = Convert.ToDecimal(Console.ReadLine());

    if(precoPorHora < 0){
        Console.WriteLine("Por favor, digite um valor maior ou igual a 0");
    }
    else{
        precoPorHoraVerificado = true;
    }
}

Console.WriteLine("--------------------------------------");
Console.WriteLine();

Estacionamento es = new(precoInicial, precoPorHora);

bool exibirMenu = true;

while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            es.AdicionarVeiculo();
            break;

        case "2":
            es.RemoverVeiculo();
            break;

        case "3":
            es.ListarVeiculos();
            break;

        case "4":
            exibirMenu = false;
            Environment.Exit(1);
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");
