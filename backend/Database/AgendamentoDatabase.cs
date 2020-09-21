using System;
using System.Collections.Generic;
using System.Linq;

namespace backend.Database
{
    public class AgendamentoDatabase
    {
        Models.teste_driveContext ctx = new Models.teste_driveContext();
        public List<Models.TbAgendamento> Consultar(string status)
        {
            return ctx.TbAgendamento.Where(x => x.DsStatus.ToLower() == status).ToList();
        }
    }
}