using System;
using System.Collections.Generic;
using System.Linq;

namespace backend.Utils
{
    public class VeiculoConversor
    {

        public Models.TbVeiculo ParaTabela(Models.Request.VeiculoRequest req)
        {
            string adap = string.Empty;

            for(int i = 0; i < req.Adaptacao.Length; i++)
            {
                if(i == req.Adaptacao.Length - 1)
                    adap += $"{req.Adaptacao[i]}";
 
                else adap += $"{req.Adaptacao[i]},";
            }

            return new Models.TbVeiculo {
                DsAdaptacao =  adap,
                DtAnoModelo = req.Ano,
                DsCombustivel = req.Combustivel,
                DsCor = req.Cor,
                DsMarca = req.Marca,
                DsModelo = req.Modelo,
                BtCarroPcd = req.Pcd,
                DsPlaca = req.Placa.ToUpper(),
                VlValorVeiculo = req.Valor,
                BtDisponivel = true,  
            };
        }
        public Models.Response.VeiculoResponse ParaResponse(Models.TbVeiculo tb)
        {
            Models.Response.VeiculoResponse ret = new Models.Response.VeiculoResponse {
                id = tb.IdVeiculo,
                Ano = tb.DtAnoModelo,
                Pcd = tb.BtCarroPcd,
                Combustivel = tb.DsCombustivel,
                Cor = tb.DsCor,
                Imagem = tb.DsImagem,
                Marca = tb.DsMarca,
                Modelo = tb.DsModelo,
                Placa = tb.DsPlaca,
                Valor = tb.VlValorVeiculo
            };
            if(string.IsNullOrEmpty(tb.DsAdaptacao)) return ret;

            else {
                ret.Adaptacao = tb.DsAdaptacao.Split(",");
                return ret;
            }
        }

        public List<Models.Response.VeiculoResponse> ParaListaResponse(List<Models.TbVeiculo> tb)
        {
            return tb.Select(x => this.ParaResponse(x)).ToList();
        }
    }
}