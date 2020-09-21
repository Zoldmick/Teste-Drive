using System;

namespace backend.Models.Request
{
    public class NotificacaoRequest
    {
        public int login { get; set; } 
        public string mensagem { get; set; }       
    }
}