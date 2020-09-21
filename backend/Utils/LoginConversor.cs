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
        public Models.Response.LoginResponse ParaResponse(Models.TbLogin tb)
        {
            return new Models.Response.LoginResponse {
                Id = tb.IdLogin,
                Email = tb.DsEmail,
                NivelLogin = tb.NrNivel
            };
        }
    }
}