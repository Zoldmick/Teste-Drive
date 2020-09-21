using System;
using System.Collections.Generic;
using System.Linq;

namespace backend.Utils
{
    public class VeiculoConversor
    {
        public Models.Response.VeiculoResponse ParaResponse(Models.TbVeiculo tb)
        {
            return new Models.Response.VeiculoResponse {
                Ano = tb.DtAnoModelo,
                Adaptacao =  tb.DsAdaptacao.Split(','),
                Pcd = tb.BtCarroPcd,
                Combustivel = tb.DsCombustivel,
                Cor = tb.DsCor,
                Imagem = tb.DsImagem,
                Marca = tb.DsMarca,
                Modelo = tb.DsModelo,
                Placa = tb.DsPlaca,
                Valor = tb.VlValorVeiculo
            };
        }

        public List<Models.Response.VeiculoResponse> ParaListaResponse(List<Models.TbVeiculo> tb)
        {
            return tb.Select(x => this.ParaResponse(x)).ToList();
        }
    }
}