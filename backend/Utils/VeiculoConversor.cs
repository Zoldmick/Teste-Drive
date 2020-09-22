using System;
using System.Collections.Generic;
using System.Linq;

namespace backend.Utils
{
    public class VeiculoConversor
    {
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