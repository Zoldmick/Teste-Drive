using System;

namespace backend.Utils
{
    public class ClienteConversor
    {
        public Models.TbCliente ParaTabela(Models.Request.ClienteRequest req)
        {
            return new Models.TbCliente {
               NmCliente =  req.Nome,
               DsCelular = req.Celular,
               DtNascimeto = req.Nascimento,
               DsCnh = req.Cnh,
               DsCpf = req.Cpf,
               BtDeficiente = req.Deficiencia,
               DsEndereco = req.Endereco,
               DsTelefone = req.Telefone,
               NrResidencia = req.Residencia,
            };
        }

        public Models.Response.ClienteResponse ParaResponse(Models.TbCliente tb)
        {
            return new Models.Response.ClienteResponse {
                Id = tb.IdCliente,
                Login = tb.IdLogin,
                Nome = tb.NmCliente,
                Celular = tb.DsCelular,
                Nascimento = tb.DtNascimeto,
                Cnh = tb.DsCnh,
                Cpf = tb.DsCpf,
                Deficiencia = tb.BtDeficiente,
                Endereco = tb.DsEndereco,
                Telefone = tb.DsTelefone,
                Residencia = tb.NrResidencia,
                imagem = tb.DsImagem,
                Email = tb.IdLoginNavigation.DsEmail
            };
        }
    }
}