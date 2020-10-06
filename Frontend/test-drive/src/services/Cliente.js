import axios from 'axios'

const api = axios.create({
    baseURL:'localhost:5000'
})

export default class Cliente {

    async ConsultarPorID(id){
        const response = await api.get(`/Cliente/${id}`)
        return response.data
    }

    async Cadastrar({Email, Senha, Nome, Cpf, Nascimento, Endereco, Telefone, Celular, Residencia, Deficiencia, Cnh, Imagem}){
        const f = new FormData()
        f.append('Email',Email) 
        f.append('Senha',Senha) 
        f.append('Nome',Nome) 
        f.append('Nascimento',Nascimento)
        f.append('Endereco',Endereco)
        f.append('Telefone',Telefone) // string
        f.append('Celular',Celular) // string
        f.append('Residencia',Residencia) // Numero de residencia -- int
        f.append('Deficiencia',Deficiencia) 
        f.append('Cnh',Cnh) // int
        f.append('Imagem',Imagem)
        
        const response = await api.post(`/Cliente`,f,{
            headers: {'content-type' : 'multipart/form-data'}
        })

        return response.data
    }

    BuscarFoto(nome){
        const response = await api.get(`/Cliente/Foto/${nome}`)
        return response.data
    }

    async Deletar(id){
        const response = await api.delete(`/Cliente/${id}`)
        return response.data
    }
}