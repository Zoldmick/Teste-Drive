using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;
using System.Net;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {
        Business.LoginBusiness buss = new Business.LoginBusiness();
        Utils.LoginConversor conv = new Utils.LoginConversor();

        [HttpPost] // Cliente e Funcionario
        public ActionResult<Models.Response.LoginResponse> Consultar(Models.Request.LoginRequest req)
        {
            try
            {
                Models.TbLogin login = conv.ParaTabela(req);
                return conv.ParaResponse(buss.Consultar(login));
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(
                    new Models.Response.ErrorResponse(ex.Message,400)
                );
            }
        }

        [HttpPost("Senha")] // Cliente 
        public ActionResult<int> RedefinirSenha(string email, string to)
        {
            try
            {
                int[] v = buss.RedefinirSenha(email,to);
                MailMessage mail = new MailMessage("venanciodacostacarloshenrique@gmail.com",email);
                mail.Subject = $"{v[0]} é seu codigo de verificação do FlagStaff Car";
                mail.IsBodyHtml = true;
                mail.Body = "";
                mail.SubjectEncoding = Encoding.GetEncoding("UTF-8");
                mail.BodyEncoding = Encoding.GetEncoding("UTF-8");
                
                SmtpClient smtp = new SmtpClient("smtp.gmail.com",587);
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("venanciodacostacarloshenrique@gmail.com","Blizard2020");
                smtp.EnableSsl = true;
                smtp.Send(mail);

                return v[1];
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(
                    new Models.Response.ErrorResponse(ex.Message,500)
                );
            }
        }

        [HttpPut("{id}")] // Cliente
        public ActionResult<Models.Response.LoginResponse> AlterarSenha(int id, int code, string senha)
        {
            try
            {
                return conv.ParaResponse(buss.Alterar(id,code,senha));
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(
                    new Models.Response.ErrorResponse(ex.Message,400)
                );
            }
        }

        [HttpPost("Funcionario/{idADM}")] // Adm
        public ActionResult CadastrarFuncionario(int idADM, Models.Request.LoginRequest req)
        {
            try
            {
                Models.TbLogin login = conv.ParaTabelaFunc(idADM,req);
                return new OkResult();
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(
                    new Models.Response.ErrorResponse(ex.Message,400)
                );
            }
        }

        [HttpPost("Funcionario/Consultar/{idADM}")] // Adm
        public ActionResult<List<Models.Response.LoginResponse>> ConsultarFuncionario(int idADM)
        {
            try
            {
                return conv.ParaListaResponse(buss.ConsultarFuncionario(idADM));
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(
                    new Models.Response.ErrorResponse(ex.Message,400)
                );
            }
        }

        [HttpDelete("Funcionario/Deletar/{idADM}")] // Adm
        public ActionResult<Models.Response.LoginResponse> DeletarFuncionario(int idADM, int idFunc)
        {
            try
            {
                return conv.ParaResponse(buss.DeletarFuncionario(idADM,idFunc));
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(
                    new Models.Response.ErrorResponse(ex.Message,400)
                );
            }
        }

        [HttpPut("Funcionario/Alterar/{idADM}")] // Adm

        public ActionResult<Models.Response.LoginResponse> AlterarFuncionario(int idADM, int idFunc, Models.Request.LoginRequest tb)
        {
            try
            {
                Models.TbLogin login = conv.ParaTabelaFunc(idADM,tb);
                return conv.ParaResponse(buss.AlterarFuncionario(idFunc,login));
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