import React,{ useState } from 'react'
import Menu from '../../../components/Header'
import Tabs from 'react-bootstrap/Tabs'
import Tab from 'react-bootstrap/Tab'
import Footer from '../../../components/Fotter'
import {PageDefault, ContainerMenu, InfosWrapper, Span, Button, Notifica ,NotiWrapper} from './styled'
import { IconContext } from "react-icons";
import {Link} from 'react-router-dom'

//Tabelas de consulta 
import TbAprovados from './aprovados';
import TbCancelados from './cancelados';
import TbEspera from './espera';
import TbConcluido from './concluido';

//icones
import { FcList } from 'react-icons/fc';
import { CgAdd } from "react-icons/cg";
import { IoIosNotificationsOutline } from "react-icons/io";


function HomeCliente() {

    const [email,setEmail] = useState()
    const [senha,setSenha] = useState()

    return(
       <PageDefault>
            <Menu />
            <ContainerMenu>

                <IconContext.Provider value={{  size: "30px", margin: "10px"}}>
                    <div>
                        <FcList />         
                    </div>
                </IconContext.Provider>   

                <Notifica>
                    <IconContext.Provider value={{  size: "30px", margin: "10px"}}>

                        <Button>
                            <IoIosNotificationsOutline />
                        </Button>

                        <NotiWrapper>
                            
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