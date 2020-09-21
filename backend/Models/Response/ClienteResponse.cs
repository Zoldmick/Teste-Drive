using System;

namespace backend.Models.Response
{
    public class ClienteResponse
    {
        public int Id { get; set; }
        public int Login { get; set; }
        public string Nome { get; set; }
        public int Cpf { get; set; }
        public DateTime? Nascimento { get; set; }
        public string Endereco { get; set; }
        public int Telefone { get; set; }
        public int Celular { get; set; }
        public int Residencia { get; set; }
        public bool Deficiencia { get; set; }
        public int Cnh { get; set; }
        public string imagem { get; set; }
    }
}