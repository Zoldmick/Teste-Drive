using System;
using System.Collections.Generic;
using System.Linq;

namespace backend.Database
{
    public class VeiculoDatabase
    {
        Models.teste_driveContext ctx = new Models.teste_driveContext();

        public List<Models.TbVeiculo> Consultar(bool pcd)
        {
            return ctx.TbVeiculo.Where(x => x.BtDisponivel == true &&
                                            x.BtCarroPcd == pcd).ToList();
        }
    }
}