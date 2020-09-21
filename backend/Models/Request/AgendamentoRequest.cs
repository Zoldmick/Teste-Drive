using System;

namespace backend.Models.Request
{
    public class AgendamentoRequest
    {
        public int Veiculo { get; set; }
        public DateTime Data { get; set; }
        public int Cliente { get; set; }
        public string Acompanhante { get; set; }
    }
}