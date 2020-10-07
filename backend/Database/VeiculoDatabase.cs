using System;
using System.Collections.Generic;
using System.Linq;

namespace backend.Database
{
    public class VeiculoDatabase
    {
        Models.teste_driveContext ctx = new Models.teste_driveContext();

        public List<Models.TbVeiculo> Consultar(bool pcd)
        {
            return ctx.TbVeiculo.Where(x => x.BtDisponivel == true &&
                                            x.BtCarroPcd == pcd).ToList();
        }

        public Models.TbVeiculo ConsultarVeiculo(int id)
        {
            return ctx.TbVeiculo.FirstOrDefault(x => x.IdVeiculo == id);
        }

        public Models.TbCliente ConsultarCliente(int id)
        {
            return ctx.TbCliente.FirstOrDefault(x => x.IdLogin == id);
        }

        public Models.TbVeiculo Deletar(Models.TbVeiculo tb)
        {
            ctx.TbVeiculo.Remove(tb);
            ctx.SaveChanges();
            return tb;
        }

        public Models.TbVeiculo ConsultarPlaca(string placa)
        {
            return ctx.TbVeiculo.FirstOrDefault(x => x.DsPlaca == placa.ToUpper());
        }

        public Models.TbVeiculo Cadastrar(Models.TbVeiculo tb)
        {
            ctx.TbVeiculo.Add(tb);
            ctx.SaveChanges();
            return tb;
        }

        public Models.TbVeiculo Alterar(Models.TbVeiculo b, Models.TbVeiculo a)
        {
            b.BtCarroPcd = a.BtCarroPcd;
            b.DsAdaptacao = a.DsAdaptacao;
            b.DsCombustivel = a.DsCombustivel;
            b.DsCor = b.DsCor;
            b.VlValorVeiculo = a.VlValorVeiculo; 

            if(!string.IsNullOrEmpty(a.DsImagem))
            {
                b.DsImagem = a.DsImagem;
            }

            return b;
        }
    }
}