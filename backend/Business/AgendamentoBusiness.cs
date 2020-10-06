using System;
using System.Collections.Generic;

namespace backend.Business
{
    public class AgendamentoBusiness
    {
        Database.AgendamentoDatabase db = new Database.AgendamentoDatabase();
        public List<Models.TbAgendamento> Consultar(int id, string status)
        {
            if(status.ToLower() != "pendente" &
               status.ToLower() != "concluido" &
               status.ToLower() != "cancelado" &
               status.ToLower() != "aprovado" ) throw new ArgumentException("Coloque o um status valido.");

            if(db.ConsultarLogin(id) == null) throw new ArgumentException("Cliente não existe");

           List<Models.TbAgendamento> ag = db.Consultar(id,status);

           if(ag.Count == 0) throw new ArgumentException("Nenhum agendamento encontrado");

           return ag;
        }

        public List<Models.TbAgendamento> ConsultarCliente(string nome)
        {
            if(string.IsNullOrEmpty(nome)) throw new ArgumentException("Nome esta vazio");

            if(db.ConsultarNomeCliente(nome) ==  null) throw new ArgumentException("Cliente não existe");

            foreach(char letra in nome.ToLower())
            {
                if(((int)letra < 97 || (int)letra > 122 ) && (int)letra != 32) throw new ArgumentException("Um nome só pode conter letras");
            }

            return db.ConsultarAgendamentosPorCliente(nome);


        }

        public Models.TbAgendamento Deletar (int id)
        {
            Models.TbAgendamento tb = db.ConsultarAgendamento(id);
            if(tb == null) throw new ArgumentException("Agendamento não exite");

            return db.Deletar(tb);
        }        
        public Models.TbAgendamento AlterarStatus(int id, string status)
        {
             if(status.ToLower() != "pendente" &&
               status.ToLower() != "concluido" && 
               status.ToLower() != "cancelado" &&
               status.ToLower() != "aprovado" ) throw new ArgumentException("Coloque o um status valido.");

             if(db.ConsultarAgendamento(id) == null) throw new ArgumentException("Agendamento não existe");

             return db.AlterarStatus(id,status);
        }

        public Models.TbAgendamento Cadastrar(int id, Models.TbAgendamento tb)
        {
            if(db.ConsultaCliente(id) == null) throw new ArgumentException("Cliente não foi encontrado");

            if((tb.DtAgendamento - DateTime.Now).TotalDays < 0) throw new ArgumentException("Data invalida");

            if(tb.DtAgendamento.Year > 2021) throw new ArgumentException("Data muito longe");

            if(db.ConsultarVeiculo(tb.IdVeiculo) == null) throw new ArgumentException("O veiculo não foi encontrado");

                tb.IdCliente = db.ConsultaCliente(id).IdCliente;
            return db.Cadastrar(tb);
        }

        public Models.TbAgendamento AlterarAvaFeed(int id,int avaliacao, string feedback)
        {
            if(avaliacao < 0) throw new ArgumentException("Avaliação inválida");

            if(string.IsNullOrEmpty(feedback)) throw new ArgumentException("Feedback está vazio");

            if(feedback.Length > 50) throw new ArgumentException("Feedback muito grande. Diminua o texto");

            if(avaliacao > 5) throw new ArgumentException("Avaliação inválida");

            if(db.ConsultarAgendamento(id) == null) throw new ArgumentException("Agendamento não encontrado");

            return db.AlterarAvaFeed(id,avaliacao,feedback);
        }

        public List<DateTime> ConsultarHorarios(DateTime dia)
        {
             if((dia - DateTime.Now).TotalDays < 0) throw new ArgumentException("Data invalida");

             return db.ConsultarHorarios(new DateTime(dia.Year,dia.Month,dia.Day));             
        }

        public List<Models.TbAgendamento>  FiltrarPorMes(int id,int mes)
        {
            if(db.ConsultarLogin(id) == null) throw new ArgumentException("Usuario não existe");

            if(mes > 12 && mes < 1) throw new ArgumentException("Mês invalido");

            List<Models.TbAgendamento> ags = db.FiltrarPorMes(id,mes);
            if(ags == null) throw new ArgumentException("Não foi realizado nenhum agendamento esse mês");
            return ags;
        }

        public List<Models.TbAgendamento>  FiltrarPorSemana(int id, DateTime semana)
        {
            if(db.ConsultarLogin(id) == null) throw new ArgumentException("Usuario não existe");

            if(semana.Year != DateTime.Now.Year) throw new ArgumentException("Ano invalido");

            if(semana.Month != DateTime.Now.Month) throw new ArgumentException("Mês invalido");

            List<Models.TbAgendamento> ags = db.FiltrarPorSemana(id,semana);
            if(ags == null) throw new ArgumentException("Não foi raelizado nenhum agendamento essa semana");
            return ags;
        }
    }
}