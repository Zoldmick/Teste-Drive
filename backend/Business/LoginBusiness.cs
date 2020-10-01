using System;
using Microsoft.AspNetCore.HttpsPolicy;

namespace backend.Business
{
    public class LoginBusiness
    {
        Database.LoginDatabase db = new Database.LoginDatabase();
        public Models.TbLogin Consultar (Models.TbLogin tb)
        {
            Models.TbLogin login =  db.Consultar(tb);
            if(login == null) throw new ArgumentException("Email ou senha incorretos");
            return login;
        }    

        public int[] RedefinirSenha(string email,string to)
        {
            if(!(to.ToLower().Contains(".com") && to.Contains("@"))) throw new ArgumentException("Email inválido");

                string provedor = to.Substring(to.IndexOf("@") + 1,email.IndexOf(".com")).ToLower();
            if(!(provedor == "gmail" || provedor == "outlook")) throw new ArgumentException($"Email inválido {provedor}"); 

            if(db.ConsultarEmail(email) == null) throw new ArgumentException("Email não existe");
            
            return db.RedefinirCodigo(email);
        }

        public Models.TbLogin Alterar(int id, int cod, string senha)
        {
            if(!(db.ConsultarCodigoSenha(id) == cod)) throw new ArgumentException("Codigo de alteração incorreto");

             Func<string, bool> senhaForte = ValidarSenha.SenhaForte();

            if(senhaForte(senha)) throw new ArgumentException("Senha fraca. Tente outra senha");

            return db.RedefinirSenha(id,senha);
        }
    }
}