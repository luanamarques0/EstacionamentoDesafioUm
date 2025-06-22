namespace EstacionamentoDesafio.Models
{
    /// <summary>
    /// Cria um objeto que representa um veiculo com placa e HoraData de entrada no estacionamento;
    /// </summary>
    public class Veiculo
    {
        public string Placa { get; set; }
        public DateTime HoraEntrada { get; set; }

        public Veiculo(string placa)
        {
            Placa = placa.ToUpper();
            HoraEntrada = DateTime.Now;
        }
    }
}