using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NotificacaoController : ControllerBase
    {
        Utils.NotificacaoConversor conv = new Utils.NotificacaoConversor();
        Business.NotificacaoBusiness buss = new Business.NotificacaoBusiness();

        [HttpPost]
        public ActionResult<Models.Response.NotificacaoResponse> Cadastrar(Models.Request.NotificacaoRequest req)
        {
            try
            {
                Models.TbNotificacao notifi = conv.ParaTabela(req);
                return conv.ParaResponse(buss.Cadastrar(notifi));
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(
                    new Models.Response.ErrorResponse(ex.Message,400)
                );
            }
        }

        [HttpGet]
        public ActionResult<List<Models.Response.NotificacaoResponse>> Consultar(int id)
        {
            try
            {
                return conv.ParaListaResponse(buss.Consultar(id));
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(
                    new Models.Response.ErrorResponse(ex.Message,500)
                );
            }
        }

        [HttpDelete]
        public ActionResult<Models.Response.NotificacaoResponse> Deletar(int id)
        {
            try
            {
                return conv.ParaResponse(buss.Deletar(id));
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(
                    new Models.Response.ErrorResponse(ex.Message,404)
                );
            }
        }
        [HttpDelete("Lista")]
        public ActionResult<List<Models.Response.NotificacaoResponse>> DeletarLista(List<int> ids)
        {
            try
            {
                return conv.ParaListaResponse(buss.DeletarLista(ids));
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(
                    new Models.Response.ErrorResponse(ex.Message,404)
                );
            }
        }

        [HttpPut]
        public void AlterarStatus()
        {
            try
            {
                buss.AlterarStatus();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}