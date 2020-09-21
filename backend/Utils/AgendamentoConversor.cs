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

        public List<Models.Response.AgendamentoResponse> ParaListaResponse(List<Models.TbAgendamento> tbs)
        {
            return tbs.Select(x => this.ParaResponse(x)).ToList();
        }
    }
}