using System;
using System.Linq;

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
    }
}