using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        Utils.ClienteConversor conv = new Utils.ClienteConversor();
        Business.ClienteBusiness buss = new  Business.ClienteBusiness();
        Business.GerenciadorFotos foto = new Business.GerenciadorFotos();

        [HttpGet("{id}")]
        public ActionResult<Models.Response.ClienteResponse> Consultar(int id)
        {
            try
            {
                return conv.ParaResponse(buss.Consultar(id));
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(
                    new Models.Response.ErrorResponse(ex.Message,400)
                );
            }
        }

        [HttpPost]
        public ActionResult<Models.Response.ClienteResponse> Cadastrar([FromForm] Models.Request.ClienteRequest req)
        {
            try
            {  
                if(req.Imagem != null)
                {
                    Models.TbCliente client = conv.ParaTabela(req);
                    Models.TbLogin login =  buss.CadastrarLogin(req.Email,req.Senha);
                    
                    client.DsImagem = foto.GerarNovoNome(req.Imagem.FileName);
                    client.IdLogin = login.IdLogin;

                    client = buss.Cadastrar(client);
                    foto.salvarFoto(req.Imagem.FileName,req.Imagem);
                    return conv.ParaResponse(client);
                }
                else throw new ArgumentException("Não possui imagem");  
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(
                    new Models.Response.ErrorResponse(ex.Message,400)
                );
            }
        }

        [HttpGet("Foto/{nome}")]
        public ActionResult BuscarFoto(string nome)
        {
            try
            {
                byte[] photo =  foto.LerFoto(nome);
                return File(photo,foto.GerarContentType(nome));
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(
                    new Models.Response.ErrorResponse(ex.Message,404)
                );
            }
        }

        [HttpPost("ping")]
        public string ping()
        {
            return "pong";
        }
    }
}