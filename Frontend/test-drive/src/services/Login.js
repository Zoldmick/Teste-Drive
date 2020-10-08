import axios from 'axios'

const api = axios.create({
    baseURL:'http://localhost:5000'
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

    async CadastrarFunc(id,req){ // adm
        const response = await api.post(`/Login/Funcionario/${id}`,req)
        return response.data
    }

    async ConsultarFuncs(id){ // adm
        const response = await api.post(`/Login/Funcionario/Consulta/${id}`)
        return response.data
    }

    async DeletarFunc(id,idFunc){ // adm
        const response = await api.delete(`/Login/Funcionario/Deletar/${id}?idFunc=${idFunc}`)
        return response
    }

    async AlterarFunc(id,idFunc,req){ // adm
        const response = await api.put(`/Login/Funcionario/Alterar/${id}?idFunc=${idFunc}`,req)
        return response
    }
}