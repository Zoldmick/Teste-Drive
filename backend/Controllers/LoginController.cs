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

        [HttpGet]
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
        
        [HttpPost]
        public ActionResult<Models.Response.LoginResponse> Cadastrar (Models.Request.LoginRequest req)
        {
            try
            {
                Models.TbLogin login  = conv.ParaTabela(req);
                login.NrNivel = 0;

                return conv.ParaResponse(buss.Cadastrar(login));                
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(
                    new Models.Response.ErrorResponse(ex.Message,400)
                );
            }
        }

        [HttpPost("Senha")]
        public void RedefinirSenha(string email, string to)
        {
            try
            {
                int? v = buss.RedefinirSenha(email,to);
                MailMessage mail = new MailMessage("venanciodacostacarloshenrique@gmail.com",email);
                mail.Subject = $"{v} é seu codigo de verificação do FlagStaff Car";
                mail.IsBodyHtml = true;
                mail.Body = "";
                mail.SubjectEncoding = Encoding.GetEncoding("UTF-8");
                mail.BodyEncoding = Encoding.GetEncoding("UTF-8");
                SmtpClient smtp = new SmtpClient("smtp.gmail.com",587);
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("venanciodacostacarloshenrique@gmail.com","Blizard2020");
                smtp.EnableSsl = true;
                smtp.Send(mail);
            }
            catch (Exception ex)
            {
               Console.WriteLine(ex.Message);
            }
        }

        [HttpPut]
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
        
        [HttpPost("ping")]
        public string ping()
        {
            return "pong";
        }
    }
}