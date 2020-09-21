using System;

namespace backend.Models.Response
{
    public class NotificacaoResponse
    {
        public int id { get; set; }
        public int login { get; set; }
        public DateTime envio { get; set; }
        public string mensagem { get; set; }
        public string leitura { get; set; }
    }
}