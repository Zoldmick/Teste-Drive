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

        [HttpGet("{id}")] // Cliente e Funcionario
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

        [HttpGet("Clientes")] // Funcionario
        public ActionResult<List<Models.Response.ClienteResponse>> ConsultarTodos(string nome)
        {
            try
            {
                return conv.ParaListaResponse(buss.ConsultarTodos(nome));
            }
            catch(Exception ex)
            {
                return new BadRequestObjectResult(
                    new Models.Response.ErrorResponse(ex.Message,400)
                );
            }
        }        

        [HttpPost] // Cliente
        public ActionResult<Models.Response.ClienteResponse> Cadastrar([FromForm] Models.Request.ClienteRequest req)
        {
            try
            {  
                if(req.Imagem != null)
                {
                    Models.TbCliente client = conv.ParaTabela(req);
                    client.DsImagem = foto.GerarNovoNome(req.Imagem.FileName);

                    client = buss.Cadastrar(client, req.Email, req.Senha);
                    foto.salvarFoto(client.DsImagem,req.Imagem);
                    
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


        [HttpGet("Foto/{nome}")] // Cliente e Funcionario
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

        [HttpDelete("{id}")] // Cliente
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