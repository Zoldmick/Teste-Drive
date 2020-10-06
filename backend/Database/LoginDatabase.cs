using System;
using System.Collections.Generic;
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

        public Models.TbLogin ConsultarID (int id)
        {
            return ctx.TbLogin.FirstOrDefault(x => x.IdLogin == id);
        }

        public void Cadastrar(Models.TbLogin tb)
        {
            ctx.TbLogin.Add(tb);
            ctx.SaveChanges();
        }

        public Models.TbLogin DeletarFuncionario(Models.TbLogin tb)
        {
            ctx.TbLogin.Remove(tb);
            ctx.SaveChanges();
            return tb;
        }

        public List<Models.TbLogin> ConsultarFunc()
        {
            return ctx.TbLogin.Where(x => x.NrNivel > 0).ToList();
        }
        
        public int? ConsultarCodigoSenha(int id)
        {
            return ctx.TbLogin.FirstOrDefault(x => x.IdLogin == id).NrCodigoAlteracao;
        }

        public Models.TbLogin ConsultarEmail(string email)
        {
            return ctx.TbLogin.FirstOrDefault(x => x.DsEmail == email);
        }

        public int[] RedefinirCodigo(string email)
        {
            Models.TbLogin login = ctx.TbLogin.FirstOrDefault(x => x.DsEmail == email);
            Random rand = new Random();
            login.NrCodigoAlteracao = rand.Next(100000,999999);
            ctx.SaveChanges();
            return new int[2]{ (int) login.NrCodigoAlteracao ,login.IdLogin};
        }
        public Models.TbLogin RedefinirSenha(int id, string senha)
        {
            Models.TbLogin login = ctx.TbLogin.FirstOrDefault(x => x.IdLogin == id);
            login.DsSenha = senha;
            ctx.SaveChanges();

            login.NrCodigoAlteracao = null;
            ctx.SaveChanges();

            return login;
        }

        public Models.TbLogin AlterarFuncionario(Models.TbLogin b, Models.TbLogin a)
        {
            b.DsEmail = a.DsEmail; 
            b.DsSenha = a.DsSenha;
            ctx.SaveChanges();

            return b;
        }
    }
}