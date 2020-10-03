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
                    Console.WriteLine("POST!!!!");
                    Models.TbCliente client = conv.ParaTabela(req);
                    Console.WriteLine("Converteu!");
                    client.DsImagem = foto.GerarNovoNome(req.Imagem.FileName);
                    Console.WriteLine("Vai entrar na business");
                    client = buss.Cadastrar(client, req.Email, req.Senha);
                    Console.WriteLine("Salvar foto");

                    foto.salvarFoto(client.DsImagem,req.Imagem);
                    Console.WriteLine("Imagem Salva");
                    
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

        [HttpDelete]
        public ActionResult<Models.Response.ClienteResponse> Deletar(int id)
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

        [HttpGet("ping")]
        public string ping()
        {
            return "pong";
        }
    }
}