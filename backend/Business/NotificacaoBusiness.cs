using System;
using System.Collections.Generic;

namespace backend.Business
{
    public class NotificacaoBusiness
    {
        Database.NotificacaoDatabase db = new Database.NotificacaoDatabase();
        public Models.TbNotificacao Cadastrar(Models.TbNotificacao tb)
        {
            if(tb.DsMensagem.Length > 100) throw new ArgumentException("Mensagem muito grande");

            if(db.ConsultarLogin(tb.IdLogin) == null) throw new ArgumentException("Login não existe");

            return db.Cadastrar(tb);
        }

        public List<Models.TbNotificacao> Consultar(int id)
        {
            if(db.ConsultarLogin(id) == null) throw new ArgumentException("Login não existe");

            return db.Consultar(id);
        }

        public Models.TbNotificacao Deletar(int id)
        {
            Models.TbNotificacao nit = db.ConsultarNit(id);
            if(nit == null) throw new ArgumentException("Registro não existe");

            return db.Deletar(nit);
        }

        public List<Models.TbNotificacao> DeletarLista(List<int> ids)
        {
            List<Models.TbNotificacao> noexcluir = new List<Models.TbNotificacao>();

            foreach(int id in ids)
            {
                Models.TbNotificacao nit = db.ConsultarNit(id);
                if(nit != null && nit.DsStatus.ToLower() != "não lido") db.Deletar(nit);

                else noexcluir.Add(nit);
            }

            return noexcluir;
        }

        public List<Models.TbNotificacao> ConsultarPorNome(string nome)
        {
            if(string.IsNullOrEmpty(nome)) throw new ArgumentException("Nome está vazio");

            if(db.ConsultarCliente(nome) ==  null) throw new ArgumentException("Nome não existe");

            List<Models.TbNotificacao> ret =  db.ConsultarPorNome(nome);
            if(ret == null) throw new ArgumentException("Nenhuma notificação encontrada");

            return ret;
        }

        public List<Models.TbNotificacao> ConsultarTodos()
        {
            List<Models.TbNotificacao> ret = db.ConsultarTodos();
            if(ret == null) throw new ArgumentException("Nenhum registro encontrado");

            return ret;
        }

        public void AlterarStatus()
        {
            db.AlterarStatus();
        }
    }
}