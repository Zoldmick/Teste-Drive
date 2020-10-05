using System;

namespace backend.Models.Response
{
    public class ClienteResponse
    {
        public int Id { get; set; }
        public int Login { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime? Nascimento { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public int Residencia { get; set; }
        public bool Deficiencia { get; set; }
        public string Cnh { get; set; }
        public string imagem { get; set; }

        public string Email { get; set; }
    }
}