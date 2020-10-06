import axios from 'axios'

const api = axios.create({
    baseURL:'localhost:5000'
})

export default class Agendamento {

    async ConsultarPorStatus(id,status){
        const response = await api.post(`/Agendamento/Filtro/Status/${id}?status=${status}`)
        return response.data
    }

    async AlterarStatus(id,status){
        const response = await api.put(`/Agendamento/Status/${id}?status=${status}`)
        return response.data
    }

    async AvaliacaoFeedback(id,avaliacao, feedback){
        const response = await api.put(`/Agendamento/AFeed/${id}?avaliacao=${avaliacao}&feedback=${feedback}`)
        return response.data
    }

    async Cadastrar(req){
        const response = await api.post(`/Agendamento`,req)
        return response
    }

    async ConsultaHorarios(dia){
        const response = await api.get(`/Agendamento/Horarios?dia=${dia}`)
        return response.data        
    }

    async Deletar(id){
        const response = await api.delete(`/Agendamento/${id}`)
        return response.data
    }

    async ConsultarPorMes(id,mes){
        const response = await api.get(`/Agendamento/Filtro/Mes/${id}?mes=${mes}`)
        return response.data
    }

    async ConsultarPorSemana(id,data){
        const response = await api.get(`/Agendamento/Filtro/Semana/${id}?data=${data}`)
        return response.data
    }


}