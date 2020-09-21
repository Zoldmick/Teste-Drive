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

        [HttpPost]
        public ActionResult<List<Models.Response.AgendamentoResponse>> Consultar(string status)
        {
            try
            {
               return conv.ParaListaResponse(buss.Consultar(status));
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(
                    new Models.Response.ErrorResponse(ex.Message,400)
                );
            }
        }
    }
}