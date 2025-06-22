using System.Text.RegularExpressions;

namespace EstacionamentoDesafio.Models
{
    /// <summary>
    /// Cria uma classe que repreesenta um estacionamento físico.
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

        public void AdicionarVeiculo()
        {

            Console.WriteLine("Digite a placa do veículo para estacionar:");

            string placa = Console.ReadLine()?.Trim().ToUpper();
            if (Regex.IsMatch(placa, @"^[a-zA-Z0-9]{7}$"))
            {
                Veiculo veiculo = new Veiculo(placa);
                veiculos.Add(veiculo);
                // Console.WriteLine("pegou");
            }
            else
            {
                Console.WriteLine("Placa inválida!");
            }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            string placa = Console.ReadLine()?.Trim().ToUpper();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                int qtdHorasVeiculoPermaneceuEstacionado = int.TryParse(Console.ReadLine().Trim());
                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal
                // *IMPLEMENTE AQUI*
                int horas = 0;
                decimal valorTotal = 0;

                // TODO: Remover a placa digitada da lista de veículos
                // *IMPLEMENTE AQUI*

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                // *IMPLEMENTE AQUI*
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
