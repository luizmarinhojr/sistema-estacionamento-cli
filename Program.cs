using Desafio_de_Projeto_1.Models;


Console.WriteLine("-------------------------------------------");
Console.WriteLine("Seja bem vindo ao sistema de estacionamento");
Console.WriteLine("-------------------------------------------");


Console.Write("Preço Inicial: R$ ");
decimal precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.Write("Preço por hora: R$ ");
decimal precoPorHora = Convert.ToDecimal(Console.ReadLine());

var estacionamento = new Estacionamento(precoInicial, precoPorHora);

bool status = true;
string? escolha;
while (status) 
{
    Console.Clear();
    Console.WriteLine("-------------------------------------------");
    Console.WriteLine("Seja bem vindo ao sistema de estacionamento");
    Console.WriteLine("-------------------------------------------");
    Console.WriteLine("1 - Cadastrar Veículo\n2 - Remover Veículo\n3 - Listar Veículos\n4 - Encerrar");
    Console.Write("\nDigite a opção -> ");
    escolha = Console.ReadLine();

    switch (escolha)
    {
        case "1":
            estacionamento.CadastrarVeiculo();
            break;

        case "2":
            estacionamento.RemoverVeiculo();
            break;

        case "3":
            estacionamento.ListarVeiculos();
            break;

        case "4":
            status = false;
            break;
        
        default:
            Console.WriteLine("Opção Inválida! ");
            break;
    
    }
}

Console.WriteLine("\nPrograma encerrado");