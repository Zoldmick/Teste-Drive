import axios from 'axios'

const api = axios.create({
    baseURL:'localhost:5000'
})

export default class Login {

    async Consultar(req){
        const response = await api.post(`/Login`,req)
        return response.data
    }

    async AlterarSenha(id,code,senha){
        const response = await api.put(`/Login/${id}?code=${code}&senha=${senha}`)
        return response.data
    }

    async EnviarSenha(email,to){
        const response = await api.post(`/Login/Senha?email=${email}&to=${to}`)
        return response.data
    }
}