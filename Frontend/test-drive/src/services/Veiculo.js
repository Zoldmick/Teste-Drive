import axios from  'axios'

const api = axios.create({
    baseURL:'localhost:5000'
})

export default class Veiculo {
    
    async Consultar(pcd){
        const response = await api.get(`/Veiculo?pcd=${pcd}`)
        return response.data 
    }

    async Cadastrar({Marca, Modelo, Placa, Pcd, Adaptacao, Imagem, Ano, Cor, Combustivel}){ // funcionario
        const f = new FormData()
        f.append('Modelo',Modelo) 
        f.append('Placa',Placa) 
        f.append('Pcd',Pcd) 
        f.append('Adaptação',Adaptacao) // vetor de string
        f.append('Imagem',Imagem)
        f.append('Ano',Ano) 
        f.append('Cor',Cor) 
        f.append('Combustivel',Combustivel) 
        f.append('Marca',Marca) 
        
        const response = await api.post(`/Veiculo`,f,{
            headers: {'content-type' : 'multipart/form-data'}
        })
        return response
    }

    BuscarFoto(nome){
        const response =  api.get(`/Veiculo/Foto/${nome}`)
        return response.data
    }
    
    async Deletar(id){ // funcionario
        const response = await api.delete(`/Veiculo/${id}`)
        return response
    }

    async Alterar(id,{Marca, Modelo, Placa, Pcd, Adaptacao, Imagem, Ano, Cor, Combustivel}){ // funcionario
        const f = new FormData()
        f.append('Modelo',Modelo) 
        f.append('Placa',Placa) 
        f.append('Pcd',Pcd) 
        f.append('Adaptação',Adaptacao) // vetor de string
        f.append('Imagem',Imagem)
        f.append('Ano',Ano) 
        f.append('Cor',Cor) 
        f.append('Combustivel',Combustivel) 
        f.append('Marca',Marca) 
        
        const response = await api.put(`/Veiculo/${id}`,f,{
            headers: {'content-type' : 'multipart/form-data'}
        })
        return response
    }
}