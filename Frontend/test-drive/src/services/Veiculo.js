import axios from  'axios'

const api = axios.create({
    baseURL:'localhost:5000'
})

export default class Veiculo {
    
    async Consultar(pcd){
        const response = await api.get(`/Veiculo?pcd=${pcd}`)
        return response.data 
    }
}