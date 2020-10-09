import React,{ useState, useEffect } from 'react'
import Menu from '../../../components/Header'
import Tabs from 'react-bootstrap/Tabs'
import Tab from 'react-bootstrap/Tab'
import Footer from '../../../components/Fotter'
import {PageDefault, ContainerMenu, InfosWrapper, Span, Button, Notifica ,NotiWrapper} from './styled'
import { IconContext } from "react-icons";
import {Link} from 'react-router-dom'
import {ToastContainer,toast} from 'react-toastify'
import "react-toastify/dist/ReactToastify.css"

//Tabelas de consulta 
import TbAprovados from './aprovados';
import TbCancelados from './cancelados';
import TbEspera from './espera';
import TbConcluido from './concluido';

//icones
import { FcList } from 'react-icons/fc';
import { CgAdd } from "react-icons/cg";
import { IoIosNotificationsOutline } from "react-icons/io";

import Notificacao from '../../../services/Notificacao'
const ApiNotificacao = new Notificacao() 

function HomeCliente() {

    const [email,setEmail] = useState()
    const [senha,setSenha] = useState()
    const [notifi,setNotifi] = useState([])

    async function ConsultarNotificacao(){
        try{
            console.log(localStorage.getItem('id'))
            const resp = await ApiNotificacao.Consultar(localStorage.getItem('id'))
            console.log(resp)
            setNotifi(...resp)

        }catch(e){
            // if(e.response.data.erro) toast.info(e.response.data.error)
            // else toast.error("Algo deu errado, tente novamente")
        }
    } 

    useEffect(() => {
        ConsultarNotificacao()
    },[])
    
    return(
       <PageDefault>
            <Menu />
            <ToastContainer />
            <ContainerMenu>

                <IconContext.Provider value={{  size: "30px", margin: "10px"}}>
                    <div> 
                        <FcList />         
                    </div>
                </IconContext.Provider>   

                <Notifica>
                    <IconContext.Provider value={{  size: "30px", margin: "10px"}}>

                        <Button onClick={ConsultarNotificacao}>
                            <IoIosNotificationsOutline />
                        </Button>

                        <NotiWrapper>
                            {notifi.map(x => 
                                <div>
                                    <div>{x.envio}</div>
                                    <div>{x.mensagem}</div>
                                </div>
                                )}
                        </NotiWrapper>

                    </IconContext.Provider>   
                </Notifica>
                
            </ContainerMenu>
            
            <InfosWrapper>
                   <Span as = {Link} to = '/cliente/agendamento'><CgAdd />  Adicionar Agendamento</Span>
            
                <Tabs defaultActiveKey="Aprovados" id="uncontrolled-tab-example">
                    <Tab eventKey="Aprovados" title="Aprovados">
                        <TbAprovados />
                    </Tab>
                    <Tab eventKey="Cancelados" title="Cancelados">
                        <TbCancelados />
                    </Tab>
                    <Tab eventKey="Concluidos" title="Concluidos" >
                        <TbConcluido />
                    </Tab>
                    <Tab eventKey="Analise" title="Analise" >
                        <TbEspera />
                    </Tab>
                </Tabs>

            </InfosWrapper>

            <Footer />
        </PageDefault>
    );
}

export default HomeCliente;