using System;
using System.Collections.Generic;
using System.Linq;
namespace backend.Utils
{
    public class LoginConversor
    {
        public Models.TbLogin ParaTabela(Models.Request.LoginRequest req)
        {
            return new Models.TbLogin {
                DsEmail = req.Email,
                DsSenha = req.Senha
            };
        }     

        public Models.TbLogin ParaTabelaFunc(int idADM, Models.Request.LoginRequest req)
        {
            Models.TbLogin login = new Models.TbLogin();
            if(new Database.LoginDatabase().ConsultarID(idADM).NrNivel >= 3)
                login.NrNivel = 1;
            login.DsEmail = req.Email;
            login.DsSenha = req.Senha;

            return login;
        }
        public Models.Response.LoginResponse ParaResponse(Models.TbLogin tb)
        {
            return new Models.Response.LoginResponse {
                Id = tb.IdLogin,
                Email = tb.DsEmail,
                NivelLogin = tb.NrNivel
            };
        }

        public List<Models.Response.LoginResponse> ParaListaResponse(List<Models.TbLogin> tb)
        {
            return tb.Select(x => this.ParaResponse(x)).ToList();
        }
    }
}