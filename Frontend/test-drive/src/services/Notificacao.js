 import axios from 'axios'

 const api = axios.create({
     baseURL:'localhost:5000'
 })

export default class Notificacao {
    async Cadastrar(req){
        const response = await api.post(`/Notificacao`,req)
        return response.data 
    }

    async Consultar(id){
        const response = await api.get(`/Notificacao/${id}`)
        return response.data 
    }

    async Deletar(id){
        const response = await api.delete(`/Notificacao/${id}`)
        return response.data
    }

    async DeletarLista(ids){
        const response = await api.delete(`/Notificacao`,ids)
        return response.data
    }

    async ConsultarPorNome(nome){ // funcionario
        const response = await api.get(`/Notificacao/Filtro/${nome}`)
        return response.data
    }

    async ConsultarTodos(){ // funcionario
        const response = await api.get(`/Notificacao/Todos`)
        return response.data
    }

    async AlterarStatus(){
        const response = await api.put(`/Notificacao`)
        return response.data
    }
}