using System;
using System.Linq;

namespace backend.Database
{
    public class LoginDatabase
    {
        Models.teste_driveContext ctx = new Models.teste_driveContext();
        public Models.TbLogin Consultar (Models.TbLogin tb)
        {
           return ctx.TbLogin.FirstOrDefault(x => x.DsEmail == tb.DsEmail &&
                                                  x.DsSenha == tb.DsSenha);
        }
        
        public int? ConsultarCodigoSenha(int id)
        {
            return ctx.TbLogin.FirstOrDefault(x => x.IdLogin == id).NrCodigoAlteracao;
        }

        public int? ConsultarEmail(string email)
        {
            return ctx.TbLogin.FirstOrDefault(x => x.DsEmail == email).NrCodigoAlteracao;
        }
        public Models.TbLogin RedefinirSenha(int id, string senha)
        {
            Models.TbLogin login = ctx.TbLogin.FirstOrDefault(x => x.IdLogin == id);
            login.DsSenha = senha;
            ctx.SaveChanges();

            Random rand = new Random();
            login.NrCodigoAlteracao = rand.Next(100000,999999);
            ctx.SaveChanges();

            return login;
        }

    }
}