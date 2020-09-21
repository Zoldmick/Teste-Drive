using System;
using System.Collections.Generic;
using System.Linq;

namespace backend.Utils
{
    public class NotificacaoConversor
    {
        public Models.TbNotificacao ParaTabela (Models.Request.NotificacaoRequest req)
        {
            return new Models.TbNotificacao {
                DsMensagem = req.mensagem,
                IdLogin = req.login,
                DtEnvio = DateTime.Now,
                DsStatus = "Não lido"
            };
        }

        public Models.Response.NotificacaoResponse ParaResponse(Models.TbNotificacao tb)
        {
            return new Models.Response.NotificacaoResponse {
                id = tb.IdNotificacao,
                login = tb.IdLogin,
                mensagem = tb.DsMensagem,
                envio = tb.DtEnvio,
                leitura = tb.DsStatus
            };
        }  

        public List<Models.Response.NotificacaoResponse> ParaListaResponse(List<Models.TbNotificacao> tbs)
        {
            return tbs.Select(x => this.ParaResponse(x)).ToList();
        }      
    }
}