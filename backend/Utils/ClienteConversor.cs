using System;

namespace backend.Utils
{
    public class ClienteConversor
    {
        public Models.TbCliente ParaTabela(Models.Request.ClienteRequest req)
        {
            return new Models.TbCliente {
               NmCliente =  req.Nome,
               IdLogin = req.Login,
               NrCelular = req.Celular,
               DtNascimeto = req.Nascimento,
               NrCnh = req.Cnh,
               NrCpf = req.Cpf,
               BtDeficiente = req.Deficiencia,
               DsEndereco = req.Endereco,
               NrTelefone = req.Telefone,
               NrResidencia = req.Residencia
            };
        }

        public Models.Response.ClienteResponse ParaResponse(Models.TbCliente tb)
        {
            return new Models.Response.ClienteResponse {
                Nome = tb.NmCliente,
                Celular = tb.NrCelular,
                Nascimento = tb.DtNascimeto,
                Cnh = tb.NrCnh,
                Cpf = tb.NrCpf,
                Deficiencia = tb.BtDeficiente,
                Endereco = tb.DsEndereco,
                Telefone = tb.NrTelefone,
                Residencia = tb.NrResidencia,
                imagem = tb.DsImagem
            };
        }
    }
}