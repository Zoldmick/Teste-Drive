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

        [HttpPost("status")]
        public ActionResult<List<Models.Response.AgendamentoResponse>> Consultar(int id, string status)
        {
            try
            {
                Console.WriteLine("Controller");
               return conv.ParaListaResponse(buss.Consultar(id,status));
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(
                    new Models.Response.ErrorResponse(ex.Message,400)
                );
            }
        }
        [HttpPut("status")]
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
        [HttpPut("Avafeed")] // Avaliação e Feddback
        public ActionResult<Models.Response.AgendamentoResponse> AlterarAvaFeed(int id, int avaliacao,string feedback)
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

        [HttpPost]
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

        [HttpGet]
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

        [HttpGet("ping")]
        public string ping()
        {
            return "pong";
        }
    }
}