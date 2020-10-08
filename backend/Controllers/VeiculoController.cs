using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VeiculoController : ControllerBase
    {
        Business.VeiculoBusiness buss = new Business.VeiculoBusiness();

        Business.GerenciadorFotos fotos = new Business.GerenciadorFotos();
        Utils.VeiculoConversor conv = new Utils.VeiculoConversor();

        // Adicionar rota de inserir so para os funcionarios
        // Rota de alterar e deletar so para o funcionario

        [HttpGet("{id}")] // Cliente 
        public ActionResult<List<Models.Response.VeiculoResponse>> Consultar(int id)
        {
            try
            {
                return  conv.ParaListaResponse(buss.Consultar(id));
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(
                    new Models.Response.ErrorResponse(ex.Message,404)
                );
            }
        }

        [HttpPost] // funcionario
        public ActionResult<Models.Response.VeiculoResponse> Cadastrar([FromForm] Models.Request.VeiculoRequest req)
        {
            try
            {
                if(req.Imagem != null)
                {
                    Models.TbVeiculo v = conv.ParaTabela(req);
                    v.DsImagem = fotos.GerarNovoNome(req.Imagem.FileName);

                    Models.TbVeiculo v1 = buss.Cadastrar(v);
                    fotos.salvarFoto(v1.DsImagem,req.Imagem);

                    return conv.ParaResponse(v1);
                }
                else throw new ArgumentException("Imagem está vazia");
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(
                    new Models.Response.ErrorResponse(ex.Message, 400)
                );
            }
        }

        [HttpGet("Foto/{nome}")] // Cliente e Funcionario 
        public ActionResult BsucarFoto(string nome)
        {
            try
            {
                byte[] f = fotos.LerFoto(nome);
                return File(f,fotos.GerarContentType(nome));
            }
            catch(Exception ex)
            {
                return new BadRequestObjectResult(
                    new Models.Response.ErrorResponse(ex.Message, 404)
                );
            }
        }

        [HttpDelete("{id}")] // funcionario
        public ActionResult<Models.Response.VeiculoResponse> Deletar(int id)
        {
            try
            {
                return conv.ParaResponse(buss.Deletar(id));
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(
                    new Models.Response.ErrorResponse(ex.Message, 404)
                );
            }
        }
        [HttpPut("{id}")] // funcionario
        public ActionResult<Models.Response.VeiculoResponse> Alterar(int id,[FromForm] Models.Request.VeiculoRequest req)
        {
            try
            {
                if(req.Imagem != null)
                {
                    Models.TbVeiculo v = conv.ParaTabela(req);
                    v.DsImagem = fotos.GerarNovoNome(req.Imagem.FileName);

                    Models.TbVeiculo v1 = buss.Alterar(id,v);
                    fotos.salvarFoto(v1.DsImagem,req.Imagem);

                    return conv.ParaResponse(v1);
                }
                else 
                {
                    Models.TbVeiculo v = conv.ParaTabela(req);
                    return conv.ParaResponse(buss.Alterar(id,v));
                }
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(
                    new Models.Response.ErrorResponse(ex.Message, 400)
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