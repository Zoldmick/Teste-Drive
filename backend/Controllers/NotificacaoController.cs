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

        [HttpPost] // Cliente e Funcionario
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

        [HttpGet("{id}")] // Cliente 
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

        [HttpGet("Filtro/{Nome}")] // Funcionario

        public ActionResult<List<Models.Response.NotificacaoResponse>> ConsultarPorNome(string nome)
        {
            try
            {
                return conv.ParaListaResponse(buss.ConsultarPorNome(nome));
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(
                    new Models.Response.ErrorResponse(ex.Message,400)
                );
            }
        }

        [HttpGet("Todos")] // Funcionario

        public ActionResult<List<Models.Response.NotificacaoResponse>> ConsultarTodos()
        {
            try
            {
                return conv.ParaListaResponse(buss.ConsultarTodos());
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(
                    new Models.Response.ErrorResponse(ex.Message,500)
                );
            }
        }

        [HttpDelete("{id}")] // Cliente
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
        
        [HttpDelete("Lista")] // Cliente 
        public ActionResult<List<Models.Response.NotificacaoResponse>> DeletarLista(List<int> ids)
        {
            try
            {
                Console.WriteLine("Controller");
                return conv.ParaListaResponse(buss.DeletarLista(ids));
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(
                    new Models.Response.ErrorResponse(ex.Message,404)
                );
            }
        }

        [HttpPut] // Cliente e Funcionario
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

        [HttpGet("ping")]
        public string ping()
        {
            return "pong";
        }
    }
}