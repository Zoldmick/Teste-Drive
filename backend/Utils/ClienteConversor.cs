using System;

namespace backend.Utils
{
    public class ClienteConversor
    {
        public Models.TbCliente ParaTabela(Models.Request.ClienteRequest req)
        {
            return new Models.TbCliente {
               NmCliente =  req.Nome,
               NrCelular = req.Celular,
               DtNascimento = req.Nascimento,
               NrCnh = req.Cnh,
               NrCpf = req.Cpf,
               BtDeficiente = req.Deficiencia,
               DsEndereco = req.Endereco,
               NrTelefone = req.Telefone,
               NrResidencia = req.Residencia,
               IdLoginNavigation = new Models.TbLogin {
                   DsSenha = req.Senha,
                   DsEmail = req.Email,
                   NrNivel = 0
               }
            };
        }

        public Models.Response.ClienteResponse ParaResponse(Models.TbCliente tb)
        {
            return new Models.Response.ClienteResponse {
                Id = tb.IdCliente,
                Login = tb.IdLogin,
                Nome = tb.NmCliente,
                Celular = tb.NrCelular,
                Nascimento = tb.DtNascimento,
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