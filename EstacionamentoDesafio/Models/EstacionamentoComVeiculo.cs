using System.Text.RegularExpressions;

namespace EstacionamentoDesafio.Models
{
    /// <summary>
    /// Cria uma classe que repreesenta um estacionamento físico com Veiculo.
    /// </summary>
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<Veiculo> veiculos = new List<Veiculo>();

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

            string placa = Console.ReadLine()?.Trim().ToUpper();

            //Vê se a string placa é diferente de null e possui 7 digitoos entre letras e numeros
            if (!string.IsNullOrWhiteSpace(placa) && Regex.IsMatch(placa, @"^[a-zA-Z0-9]{7}$"))
            {
                if (!(veiculos.Any(x => placa == x.Placa)))
                {
                    Veiculo veiculo = new Veiculo(placa);
                    veiculos.Add(veiculo);
                }
                else
                {
                    Console.WriteLine("Placa já registrada no sistema!");
                }
                // Console.WriteLine("test: pegou");
            }
            else
            {
                Console.WriteLine("Placa inválida!");
            }
        }

        /*----------------------------------------------------
         * Remove veículo
         *---------------------------------------------------*/
        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            string placa = Console.ReadLine()?.Trim().ToUpper() ?? "";

            if (veiculos.Any(x => x.Placa == placa))
            {

                Veiculo veiculo = veiculos.Find(x => x.Placa == placa);

                TimeSpan tempoEstacionado = DateTime.Now - veiculo.HoraEntrada;
                double horas = Math.Ceiling(tempoEstacionado.TotalHours);

                if (horas < 1)
                {
                    horas = 1;
                }

                decimal valorTotal = precoInicial + precoPorHora * (decimal)horas;

                veiculos.Remove(veiculo);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal:F2}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente.");
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

                foreach (Veiculo v in veiculos)
                {
                    Console.WriteLine($"- {v.Placa} | Entrada: {v.HoraEntrada:T}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
