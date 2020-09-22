using System;
using Microsoft.AspNetCore.Http;

namespace backend.Models.Request
{
    public class ClienteRequest
    {
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime Nascimento { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public int Residencia { get; set; }
        public bool Deficiencia { get; set; }
        public string Cnh { get; set; }
        public IFormFile Imagem { get; set; }
    }
}