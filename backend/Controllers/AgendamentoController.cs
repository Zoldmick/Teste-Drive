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
        [HttpPost]
        public List<Models.Response.AgendamentoResponse> Consultar(string status)
        {
            
        }
    }
}