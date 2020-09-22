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
                Inicial = tb.DsRotaInicial,
                Status = tb.DsStatus,
                Data = tb.DtAgendamento,
                HoraFinal = tb.HrFinal,
                Avaliacao = tb.NrAvaliacao,
                Cliente = tb.IdCliente,
                Veiculo = tb.IdVeiculo
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
              HrFinal = TimeSpan.Parse(req.Data.AddMinutes(30).ToLongTimeString()),        
            };
        }
        public List<Models.Response.AgendamentoResponse> ParaListaResponse(List<Models.TbAgendamento> tbs)
        {
            return tbs.Select(x => this.ParaResponse(x)).ToList();
        }
    }
}