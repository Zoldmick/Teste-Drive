using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Agendamento : ControllerBase
    {
        Business.AgendamentoBusiness buss = new Business.AgendamentoBusiness();
        Utils.AgendamentoConversor conv = new Utils.AgendamentoConversor();

        [HttpGet("Filtro/Status/{id}")] // Cliente e Funcionario
        public ActionResult<List<Models.Response.AgendamentoResponse>> Consultar(int id, string status)
        {
            try
            {
               return conv.ParaListaResponse(buss.Consultar(id,status));
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(
                    new Models.Response.ErrorResponse(ex.Message,400)
                );
            }
        }
        [HttpGet("Filtro/Cliente")] // Funcionario
        public ActionResult<List<Models.Response.AgendamentoResponse>> ConsultarCliente(string nome)
        {
            try
            {
                return conv.ParaListaResponse(buss.ConsultarCliente(nome));
            }
            catch(Exception ex)
            {
                return new BadRequestObjectResult(
                    new Models.Response.ErrorResponse(ex.Message,400)
                );
            }
        }

        [HttpPut("Status/{id}")] // Cliente e Funcionario
        public ActionResult<Models.Response.AgendamentoResponse> AlterarStatus(int id, string status)
        {
            try
            {
                return conv.ParaResponse(buss.AlterarStatus(id,status));
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(
                    new Models.Response.ErrorResponse(ex.Message,400)
                );
            }
        }
        [HttpPost("AFeed/{id}")] // Avaliação e Feddback
        public ActionResult<Models.Response.AgendamentoResponse> InserirFeedAva(int id, int avaliacao,string feedback)
        {
            try
            {
                return conv.ParaResponse(buss.AlterarAvaFeed(id,avaliacao,feedback));
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(
                    new Models.Response.ErrorResponse(ex.Message, 400)
                );
            }
        }

        [HttpPost] // Cliente e Funcionario
        public ActionResult<Models.Response.AgendamentoResponse> Cadastrar(Models.Request.AgendamentoRequest req)
        {
            try
            {    
                Models.TbAgendamento ag = conv.ParaTabela(req);
                return conv.ParaResponse(buss.Cadastrar(req.Login,ag));
            }
            catch (Exception ex)
            {
               return new BadRequestObjectResult(
                   new Models.Response.ErrorResponse(ex.Message,400)
               );
            }
        }

        [HttpGet("Horarios")] // Cliente e Funcionario
        public ActionResult<List<DateTime>> ConsultarHorarios(DateTime dia)
        {
            try
            {
                return buss.ConsultarHorarios(dia);
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(
                    new Models.Response.ErrorResponse(ex.Message,400)
                ); 
            }
        }

        [HttpDelete("{id}")] // Cliente e Funcionario
        public ActionResult<Models.Response.AgendamentoResponse> Deletar(int id)
        {
            try
            {
                return conv.ParaResponse(buss.Deletar(id));
            }
            catch(Exception ex)
            {
                return new BadRequestObjectResult(
                    new Models.Response.ErrorResponse(ex.Message,404)
                );
            }
        }

        [HttpGet("Filtro/Mes/{id}")] // Cliente e Funcionario
        public ActionResult<List<Models.Response.AgendamentoResponse>> FiltrarPorMes(int id,int mes)
        {
            try
            {
                return conv.ParaListaResponse(buss.FiltrarPorMes(id,mes));
            }
            catch(Exception ex)
            {
                return new BadRequestObjectResult(
                    new Models.Response.ErrorResponse(ex.Message, 404)
                );
            }
        }

        [HttpGet("Filtro/Semana")] // Cliente e Funcionario
        // Ainda aberto para discussão
        public ActionResult<List<Models.Response.AgendamentoResponse>> FiltrarPorSemana(int id,DateTime data)
        {
            try
            {
                return conv.ParaListaResponse(buss.FiltrarPorSemana(id,data));
            }
            catch(Exception ex)
            {
                return new BadRequestObjectResult(
                    new Models.Response.ErrorResponse(ex.Message, 404)
                );
            }
        }

        [HttpGet("ping")]
        public string ping()
        {
            return "pong";
        }
    }
}