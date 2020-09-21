using System;

namespace backend.Models.Response
{
    public class AgendamentoResponse
    {
        public int Id { get; set; }
        public string Veiculo { get; set; }
        public string Acompanhante { get; set; }
        public string Funcionario { get; set; }
        public string Inicial { get; set; }
        public string Final { get; set; }
        public string Status { get; set; }
        public DateTime Data { get; set; }
        public string CarroPCD { get; set; }
        public string Feedback { get; set; }
        public int Avaliacao { get; set; }
    }
}