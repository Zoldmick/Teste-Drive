using System;

namespace backend.Models.Response
{
    public class VeiculoResponse
    {
        public int id { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public decimal Valor { get; set; }
        public bool Pcd { get; set; }
        public string[] Adaptacao { get; set; }
        public string Imagem { get; set; }
        public DateTime? Ano { get; set; }
        public string Cor { get; set; }
        public string Combustivel { get; set; }
        public string Marca { get; set; }
    }
}