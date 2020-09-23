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

            if(client.NrTelefone.Length != 11) throw new ArgumentException("Numero de telefone inválido");

            if(client.NrCelular.Length != 11) throw new ArgumentException("Numero de celular inválido");

            if(client.NrResidencia == 0) throw new ArgumentException("Numero de residencia invalido");

            if(client.NrCpf.Replace("-","").Length != 11) throw new ArgumentException("CPF invalido");

            if(client.NrCnh.Replace("-","").Length != 11) throw new ArgumentException("CNH invalido");

            if(string.IsNullOrEmpty(client.IdLoginNavigation.DsEmail)) throw new ArgumentException("Email está vazio");

            if(string.IsNullOrEmpty(client.IdLoginNavigation.DsSenha)) throw new ArgumentException("Senha está vazio"); 

            if(!(client.IdLoginNavigation.DsEmail.ToLower().Contains(".com"))) throw new ArgumentException("Email inválido");

            if(!(client.IdLoginNavigation.DsEmail.ToLower().Contains("@gmail") || client.IdLoginNavigation.DsEmail.ToLower().Contains("@outlook"))) throw new ArgumentException("Email inválido");
            
            Func<string, bool> senhaForte = (s) => {
                int esp = 0, num = 0;
                foreach(char letra in s)
                {
                    if(char.GetNumericValue(letra) >= 0) num += 1;
                    else if(((int)letra < 97 && (int)letra > 122)) esp += 1; 
                }
                return esp >= 2 && num >= 2;
            };

            if(senhaForte(client.IdLoginNavigation.DsSenha) && client.IdLoginNavigation.DsSenha.Length >= 8) throw new ArgumentException("Senha fraca. Tente outra senha");

            return db.Cadastrar(client);
        }
    }
}