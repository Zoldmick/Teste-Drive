using System;
using System.Collections.Generic;

namespace backend.Business
{
    public class VeiculoBusiness
    {
        Database.VeiculoDatabase db = new Database.VeiculoDatabase();
        public List<Models.TbVeiculo> Consultar(bool pcd)
        {
           List<Models.TbVeiculo> ret = db.Consultar(pcd);
           
           if(ret == null) throw new ArgumentException("Nenhum carro encontrado");

           return ret;
        }
    }
}