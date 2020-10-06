using System;
using System.Linq;
using System.Collections.Generic;
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
            if(!(provedor == "gmail" || provedor == "outlook" || provedor == "yahoo" || provedor == "hotmail")) throw new ArgumentException($"Email inválido {provedor}"); 

            if(db.ConsultarEmail(email) == null) throw new ArgumentException("Email não existe");
            
            return db.RedefinirCodigo(email);
        }

        public Models.TbLogin Alterar(int id, int cod, string senha)
        {
            if(!(db.ConsultarCodigoSenha(id) == cod)) throw new ArgumentException("Codigo de alteração incorreto");

            Func<string, bool> senhaForte = OutrasValidacoes.SenhaForte();

            if(senhaForte(senha)) throw new ArgumentException("Senha fraca. Tente outra senha");

            return db.RedefinirSenha(id,senha);
        }

        public void CadastrarFunc(Models.TbLogin tb)
        {
            if(string.IsNullOrEmpty(tb.DsEmail)) throw new ArgumentException("Email está vazio");
            Console.WriteLine("Validar email");
             
            if(new Database.ClienteDatabase().ConsultarTodos().FirstOrDefault(x => x.IdLoginNavigation.DsEmail == tb.DsEmail) != null) throw new ArgumentException("Email já existe. Tente outro");
            Console.WriteLine("Termino de Validar email");

            if(string.IsNullOrEmpty(tb.DsSenha)) throw new ArgumentException("Senha está vazio"); 

            if(!(tb.DsEmail.ToLower().Contains(".com"))) throw new ArgumentException("Email inválido");

            if(!(tb.DsEmail.ToLower().Contains("@gmail") 
                    || tb.DsEmail.ToLower().Contains("@outlook")
                    || tb.DsEmail.ToLower().Contains("@hotmail"))) throw new ArgumentException("Email inválido");
            
            Func<string, bool> senhaForte = OutrasValidacoes.SenhaForte();

            if(!(senhaForte(tb.DsSenha) && tb.DsSenha.Length >= 8)) throw new ArgumentException("Senha fraca. Tente outra senha");

            db.Cadastrar(tb);
        }

        public List<Models.TbLogin> ConsultarFuncionario (int idADM)
        {
            if(db.ConsultarID(idADM).NrNivel < 3) throw new ArgumentException("Administrador não cadastrado");

            List<Models.TbLogin> funcs = db.ConsultarFunc();
            if(funcs == null) throw new ArgumentException("Nenhum funcionario cadastrado");

            return funcs;
        }

        public Models.TbLogin DeletarFuncionario (int idADM, int idFUNC)
        {
            Models.TbLogin login = db.ConsultarID(idFUNC);
            if(db.ConsultarID(idADM).NrNivel < 3) throw new ArgumentException("Administrador não cadastrado");

            if(login == null) throw new ArgumentException("Funcionario não encontrado");

            return db.DeletarFuncionario(login);
        }

        public Models.TbLogin AlterarFuncionario(int idFunc, Models.TbLogin tb)
        {
            Models.TbLogin login = db.ConsultarID(idFunc);
            if(login == null) throw new ArgumentException("Funcionario não encontrado");

            if(string.IsNullOrEmpty(tb.DsEmail)) throw new ArgumentException("Email está vazio");
            Console.WriteLine("Validar email");
             
            if(new Database.ClienteDatabase().ConsultarTodos().FirstOrDefault(x => x.IdLoginNavigation.DsEmail == tb.DsEmail) != null) throw new ArgumentException("Email já existe. Tente outro");
            Console.WriteLine("Termino de Validar email");

            if(string.IsNullOrEmpty(tb.DsSenha)) throw new ArgumentException("Senha está vazio"); 

            if(!(tb.DsEmail.ToLower().Contains(".com"))) throw new ArgumentException("Email inválido");

            if(!(tb.DsEmail.ToLower().Contains("@gmail") 
                    || tb.DsEmail.ToLower().Contains("@outlook")
                    || tb.DsEmail.ToLower().Contains("@hotmail"))) throw new ArgumentException("Email inválido");
            
            Func<string, bool> senhaForte = OutrasValidacoes.SenhaForte();

            if(!(senhaForte(tb.DsSenha) && tb.DsSenha.Length >= 8)) throw new ArgumentException("Senha fraca. Tente outra senha");

            return db.AlterarFuncionario(login,tb);
        }
    }
}