using System;
using System.Linq;
using System.Collections.Generic;

namespace backend.Utils
{
    public class AgendamentoConversor
    {
        public Models.Response.AgendamentoResponse ParaResponse(Models.TbAgendamento tb)
        {
            return new Models.Response.AgendamentoResponse {
                Id = tb.IdAgendamento,
                Feedback = tb.DsFeedback,
                Final = tb.DsRotaFinal,
                Inicio = tb.DsRotaInicial,
                Status = tb.DsStatus,
                Data = tb.DtAgendamento,
                HoraFinal = tb.DtFinal.ToLongTimeString(),
                Avaliacao = tb.NrAvaliacao,
                Cliente = tb.IdCliente,
                Veiculo = tb.IdVeiculo,
                Acompanhante = tb.DsAcompanhante,
                Funcionario =  "José Arignaldo dos santos",
                CarroPcd = new Database.AgendamentoDatabase().ConsultarVeiculo(tb.IdVeiculo).BtCarroPcd
                    ? "Sim"
                    : "Não"  
            };
        }
        
        public Models.TbAgendamento ParaTabela(Models.Request.AgendamentoRequest req)
        {
            return new Models.TbAgendamento {
              DsRotaInicial = "Avenida Coronel Octaviano de Freitas Costa,463 - Socorro",
              DsRotaFinal = "R. Maria Casusa Feitosa, 129",
              DsStatus = "pendente",
              DtAgendamento = req.Data,
              DsAcompanhante = req.Acompanhante,
              IdVeiculo = req.Veiculo,
              DtFinal = req.Data.AddMinutes(40)   
            };
        }
        public List<Models.Response.AgendamentoResponse> ParaListaResponse(List<Models.TbAgendamento> tbs)
        {
            return tbs.Select(x => this.ParaResponse(x)).ToList();
        }
    }
}