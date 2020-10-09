import React, { useState, useEffect } from 'react'

import Notificacao from '../../../services/Notificacao'
const ApiNotificacao = new Notificacao()

export default function Notificacao(){
    const [notifi,setNotificacao] = useState([])

    async function ConsultarNotificacao(){
        try{
            console.log(localStorage.getItem('id'))
            const resp = await ApiNotificacao.Consultar(localStorage.getItem('id'))
            const r = ['Ola','seja','bem-vindo']
            setNotificacao([...r])
            console.log(resp)
            return resp

        }catch(e){
            // if(e.response.data.erro) toast.info(e.response.data.error)
            // else toast.error("Algo deu errado, tente novamente")
        }
    } 

    useEffect(() => {
        ConsultarNotificacao()
        console.log(notifi)
    },[])
}