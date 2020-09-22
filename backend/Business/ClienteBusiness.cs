using System;
using System.Linq;

namespace backend.Business
{
    public class ClienteBusiness
    {
        Database.ClienteDatabase db = new Database.ClienteDatabase();
        public Models.TbCliente Consultar(int id)
        {
            Models.TbLogin login = db.ConsultarLogin(id);
            if(login == null) throw new ArgumentException("ID incorreto");
            return db.Consultar(login.IdLogin);
        }

        public Models.TbCliente Cadastrar(Models.TbCliente client)
        {
            if(string.IsNullOrEmpty(client.DsEndereco)) throw new ArgumentException("Adicione um endereço");

            if((DateTime.Now.Year - client.DtNascimeto.Value.Year) < 18) throw new ArgumentException("Menor de idade não pode fazer cadastro");

            if(db.ConsultarLogin(client.IdLogin) == null) throw new ArgumentException("Login não existe");

            if(string.IsNullOrEmpty(client.NmCliente)) throw new ArgumentException("Nome do cliente está nulo");

            Func<string,bool> r = (a) => {
                int cont = 0;
                foreach(char u in a)
                {
                    if(u == ' ') cont += 1;
                }
                return cont < 2;
            };

            if(db.ConsultarTodos().Any(x => x.NmCliente == client.NmCliente)) throw new ArgumentException("Nome ja existe. Tente outro");

            if(r(client.NmCliente)) throw new ArgumentException("Colocar nome completo");

            if(client.NrTelefone.ToString().Length != 11) throw new ArgumentException("Numero de telefone inválido");

            if(client.NrCelular.ToString().Length != 11) throw new ArgumentException("Numero de celular inválido");

            if(client.NrResidencia == 0) throw new ArgumentException("Numero de residencia invalido");

            if(client.NrCpf.ToString().Length != 11) throw new ArgumentException("CPF invalido");

            if(client.NrCnh.ToString().Length != 11) throw new ArgumentException("CNH invalido");

            return db.Cadastrar(client);
        }

        public Models.TbLogin CadastrarLogin(string email, string senha)
        {
            if(string.IsNullOrEmpty(email)) throw new ArgumentException("Email está vazio");

            if(string.IsNullOrEmpty(senha)) throw new ArgumentException("Senha está vazio"); 

            if(!(email.ToLower().Contains(".com"))) throw new ArgumentException("Email inválido");

            if(!(email.ToLower().Contains("@gmail") || email.ToLower().Contains("@outlook"))) throw new ArgumentException("Email inválido");
            
            Func<string, bool> senhaForte = (s) => {
                int esp = 0, num = 0;
                foreach(char letra in s)
                {
                    if(char.GetNumericValue(letra) >= 0) num += 1;
                    else if(((int)letra < 97 && (int)letra > 122)) esp += 1; 
                }
                return esp >= 2 && num >= 2;
            };

            if(senhaForte(senha) && senha.Length >= 8) throw new ArgumentException("Senha fraca. Tente outra senha");
            return db.CadastrarLogin(email,senha);
        }
    }
}