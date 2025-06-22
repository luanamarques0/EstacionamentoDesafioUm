using System.Text.RegularExpressions;

namespace EstacionamentoDesafio.Models
{
    /// <summary>
    /// Representa um estacionamento físico e realiza controle de entrada e saida
    /// </summary>
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        /*----------------------------------------------------
        * Adiciona veículo
        *---------------------------------------------------*/
        public void AdicionarVeiculo()
        {

            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine().Trim().ToUpper();

            if (!string.IsNullOrWhiteSpace(placa) && Regex.IsMatch(placa, @"^[a-zA-Z0-9]{7}$"))
            {
                if (!(veiculos.Any(x => placa == x)))
                {
                    veiculos.Add(placa);
                    Console.WriteLine($"{placa} adicionada com sucesso!");
                }
                else
                {
                    Console.WriteLine("Placa já cadastrada!");
                }
            }
            else
            {
                Console.WriteLine("Placa invalida, tente novamente!");
            }
        }

        /*----------------------------------------------------
         * Remove veículo
         *---------------------------------------------------*/
        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            string placa = Console.ReadLine().Trim().ToUpper();

            if (veiculos.Any(x => x == placa))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                int horas;

                bool SucessoConversao = int.TryParse(Console.ReadLine().Trim(), out horas);

                if (!SucessoConversao)
                {
                    Console.WriteLine("Hora invalida. digite novamente: ");
                    SucessoConversao = int.TryParse(Console.ReadLine().Trim(), out horas);
                }
                else
                {
                    decimal valorTotal = precoInicial + precoPorHora * horas;
                    veiculos.Remove(placa);
                    Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                }

            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        /*----------------------------------------------------
         * Listar veículos
         *---------------------------------------------------*/
        public void ListarVeiculos()
        {

            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");

                foreach (string placa in veiculos)
                {
                    Console.WriteLine($"- {placa}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}