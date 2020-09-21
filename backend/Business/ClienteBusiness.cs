using System;

namespace backend.Business
{
    public class ClienteBusiness
    {
        Database.ClienteDatabase db = new Database.ClienteDatabase();
        public Models.TbCliente Consultar(int id)
        {
            Models.TbLogin client = db.ConsultarLogin(id);
            if(client == null) throw new ArgumentException("ID incorreto");
            return db.Consultar(client.IdLogin);
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

            if(r(client.NmCliente)) throw new ArgumentException("Colocar nome completo");

            // if(client.NrTelefone.ToString().Length != 11) throw new ArgumentException("Numero de telefone inválido");

            // if(client.NrCelular.ToString().Length != 11) throw new ArgumentException("Numero de celular inválido");

            // if(client.NrResidencia == 0) throw new ArgumentException("Numero de residencia invalido");

            // if(client.NrCpf.ToString().Length != 11) throw new ArgumentException("CPF invalido");

            // if(client.NrCnh.ToString().Length != 11) throw new ArgumentException("CNH invalido");

            return db.Cadastrar(client);
        }
    }
}