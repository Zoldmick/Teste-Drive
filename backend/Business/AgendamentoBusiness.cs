using System;
using System.Collections.Generic;

namespace backend.Business
{
    public class AgendamentoBusiness
    {
        Database.AgendamentoDatabase db = new Database.AgendamentoDatabase();
        public List<Models.TbAgendamento> Consultar(string status)
        {
            if(status.ToLower() != "pendente" &&
               status.ToLower() != "conluido" &&
               status.ToLower() != "cancelado" &&
               status.ToLower() != "aprovados" ) throw new ArgumentException("Coloque o status corretamente.");

           List<Models.TbAgendamento> ag = db.Consultar(status);

           if(ag.Count == 0) throw new ArgumentException("Nenhum registro encontrado");

           return ag;
        }
    }
}