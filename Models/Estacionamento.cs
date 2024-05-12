using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;


namespace Desafio_de_Projeto_1.Models
{
    public class Estacionamento
    {
        private decimal PrecoInicial {get; set;}
        private decimal PrecoPorHora {get; set;}
        private List<string?> Placas = new List<string?>();
        
        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            PrecoInicial = precoInicial;
            PrecoPorHora = precoPorHora;
            Console.WriteLine($"Preço Inicial: {precoInicial} \nPreço por Hora: {precoPorHora}");
        }

        public void CadastrarVeiculo() 
        {
            Console.Write("Digite a placa do veículo: ");
            string? placa = Console.ReadLine();

            if (!Placas.Contains(placa)) 
            {
                Placas.Add(placa);
                Console.Write("\nCadastrado com sucesso! Pressione Enter para voltar ao menu: ");

            } else {
                Console.Write("\nEssa placa já está cadastrada no sistema. Pressione Enter para voltar ao Menu: ");
            }
            Console.ReadLine();
        }

        public void RemoverVeiculo() 
        {
            Console.Write("Digite a placa do veículo a ser removido: ");
            string? placa = Console.ReadLine();

            if (Placas.Contains(placa)) 
            {
                Console.Write("\nDigite quantas horas o veículo permaneceu estacionado: ");
                decimal horas = Convert.ToDecimal(Console.ReadLine());

                Placas.Remove(placa);
                decimal precoFinal = PrecoInicial + (horas * PrecoPorHora);
                Console.WriteLine("O veículo foi removido e o preço total foi de R$ " + precoFinal);

                Console.Write("\nPressione Enter para voltar ao menu: ");
                Console.ReadLine();    
            } 
            else 
            {
                Console.WriteLine("Essa placa não está cadastrada no sistema.");
                Console.Write("\nPressione Enter para voltar ao menu: ");
                Console.ReadLine();    
            } 
        }

        public void ListarVeiculos() {
            Console.WriteLine();
            for (int contador = 0; contador < Placas.Count(); contador++) 
            {
                Console.WriteLine($"{contador + 1}. {Placas[contador]}");
            }
            Console.Write("\nPressione Enter para voltar ao menu: ");
            Console.ReadLine();
        }
    }
}