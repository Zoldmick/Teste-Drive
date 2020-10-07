using System;
using System.Collections.Generic;

namespace backend.Business
{
    public class VeiculoBusiness
    {
        Database.VeiculoDatabase db = new Database.VeiculoDatabase();

        public List<Models.TbVeiculo> Consultar(int id)
        {
           bool deficiente = db.ConsultarCliente(id).BtDeficiente;
           List<Models.TbVeiculo> ret = db.Consultar(deficiente);
           if(ret == null) throw new ArgumentException("Nenhum carro encontrado");
           return ret;
        }

        public Models.TbVeiculo Cadastrar(Models.TbVeiculo tb)
        {
            if(tb.VlValorVeiculo < 0) throw new ArgumentException("Valor de veiculo invalido");

            if(string.IsNullOrEmpty(tb.DsMarca)) throw new ArgumentException("Marca está vazia");

            if(OutrasValidacoes.ContainsEspeciais(tb.DsMarca)) throw new ArgumentException("Marca não pode conter caracteres especiais");

            if(string.IsNullOrEmpty(tb.DsModelo)) throw new ArgumentException("Modelo está vazio");

            if(OutrasValidacoes.ContainsEspeciais(tb.DsModelo)) throw new ArgumentException("Modelo não pode conter caracteres especiais");

            if(db.ConsultarPlaca(tb.DsPlaca) != null) throw new ArgumentException("Placa inválida");

            if(tb.DtAnoModelo.Value > DateTime.Now.AddYears(1) || tb.DtAnoModelo.Value < new DateTime(1850,01,01)) throw new ArgumentException("Ano modelo inválido");

            if(tb.DsCombustivel.ToLower() != "gasolina"
                && tb.DsCombustivel.ToLower() != "diesel"
                && tb.DsCombustivel.ToLower() != "etanol" ) throw new ArgumentException("Combustivel invàlido");

            if(string.IsNullOrEmpty(tb.DsCor)) throw new ArgumentException("Cor está vazia");

             return db.Cadastrar(tb);
        }
        public Models.TbVeiculo Deletar(int id)
        {
            Models.TbVeiculo v = db.ConsultarVeiculo(id);
            if(v ==  null) throw new ArgumentException("Veiculo não encontrado");

            return db.Deletar(v);
        }
        public Models.TbVeiculo Alterar(int id, Models.TbVeiculo tb)
        {
            Models.TbVeiculo v = db.ConsultarVeiculo(id);
            if(v ==  null) throw new ArgumentException("Veiculo não encontrado");

            if(tb.VlValorVeiculo < 0) throw new ArgumentException("Valor de veiculo invalido");

            if(tb.DsCombustivel.ToLower() != "gasolina"
                && tb.DsCombustivel.ToLower() != "diesel"
                && tb.DsCombustivel.ToLower() != "etanol" ) throw new ArgumentException("Combustivel invàlido");

            if(string.IsNullOrEmpty(tb.DsCor)) throw new ArgumentException("Cor está vazia");

            return db.Alterar(v,tb);
        }
    }
}