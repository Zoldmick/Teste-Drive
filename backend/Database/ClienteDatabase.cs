using System;
using System.Linq;
using System.Collections.Generic;
namespace backend.Database
{
    public class ClienteDatabase
    {
        Models.teste_driveContext ctx = new Models.teste_driveContext();

        public Models.TbLogin ConsultarLogin(int id)
        {
          return ctx.TbLogin.FirstOrDefault(x => x.IdLogin == id);
        }

        public Models.TbCliente Cadastrar(Models.TbCliente client)
        {
            ctx.TbCliente.Add(client);
            ctx.SaveChanges();
            return client;
        }        
        public Models.TbCliente Consultar(int id)
        {
            return ctx.TbCliente.FirstOrDefault(x => x.IdLogin == id);
        }

        public List<Models.TbCliente> ConsultarTodos()
        {
            return ctx.TbCliente.ToList();
        }
        public Models.TbLogin CadastrarLogin(string email, string senha)
        {
            Models.TbLogin login = new Models.TbLogin {
                DsSenha = senha,
                DsEmail = email,
                NrNivel = 0
            };

            ctx.TbLogin.Add(login);
            ctx.SaveChanges();
            return login;
        }
 
    }
}