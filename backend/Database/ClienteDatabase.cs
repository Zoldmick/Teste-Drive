using System;
using System.Linq;
using System.Collections.Generic;
namespace backend.Database
{
    public class ClienteDatabase
    {
        Models.teste_driveContext ctx = new Models.teste_driveContext();

        public Models.TbCliente Cadastrar(Models.TbCliente client, string senha, string email)
        {
            Models.TbLogin Login = new Models.TbLogin{
                DsEmail = email,
                DsSenha = senha,
                TbCliente = new List<Models.TbCliente>{ client }
            };
            Console.WriteLine("Database");            
            ctx.TbLogin.Add(Login);
            ctx.SaveChanges();
            Console.WriteLine("Ta Salvo");
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

        public List<Models.TbLogin> ConsultarLogins()
        {
            return ctx.TbLogin.ToList();
        }
    }
}