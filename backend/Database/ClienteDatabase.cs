using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
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

        public Models.TbCliente ConsultarCliente(int id)
        {
            return ctx.TbCliente.FirstOrDefault(x => x.IdCliente == id);
        }
        public Models.TbCliente ConsultarLogin(int id)
        {
            return ctx.TbCliente.FirstOrDefault(x => x.IdLogin == id);
        }

        public Models.TbCliente Deletar(Models.TbCliente tb)
        {
            ctx.TbCliente.Remove(tb);
            ctx.SaveChanges();

            ctx.TbLogin.Remove(tb.IdLoginNavigation);
            ctx.SaveChanges();

            return tb;
        }

        public List<Models.TbCliente> ConsultarTodos()
        {
            return ctx.TbCliente.ToList();
        } 
    }
}