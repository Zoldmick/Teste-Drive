import axios from 'axios'

const api = axios.create({
    baseURL:'localhost:5000'
})

export default class Agendamento {
    async ConsultarPorStatus(id,status){
        const response = await api.post(`/Agendamento/Status?id=${id}&status=${status}`)
        return response.data
    }

    async AlterarStatus(id,status){
        const response = await api.put(`/Agendamento/Status?id=${id}&status=${status}`)
        return response.data
    }

    async AvaliacaoFeedback(id,avaliacao, feedback){
        const response = await api.put(`/Agendamento?id=${id}&avaliacao=${avaliacao}&feedback=${feedback}`)
        return response.data
    }

    async Cadastrar(req){
        const response = await api.post(`/Agendamento`,req)
        return response
    }

    async ConsultaHorarios(dia){
        const response = await api.get(`/Agendamento?dia=${dia}`)
        return response.data        
    }
}