using System;

namespace backend.Models.Response
{
    public class AgendamentoResponse
    {
        public int Id { get; set; }
        public int Veiculo { get; set; }
        public int Cliente { get; set; }
        public string Acompanhante { get; set; }
        public string Funcionario { get; set; }
        public string Inicio { get; set; }
        public string Final { get; set; }
        public string HoraFinal { get; set; }
        public string Status { get; set; }
        public DateTime Data { get; set; }
        public string Feedback { get; set; }
        public string CarroPcd { get; set; }
        public int? Avaliacao { get; set; }
    }
}