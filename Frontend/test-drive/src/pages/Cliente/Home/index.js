import React from 'react'
import Menu from '../../../components/Header'
import Tabs from 'react-bootstrap/Tabs'
import Tab from 'react-bootstrap/Tab'
import Footer from '../../../components/Fotter'
import {PageDefault, ContainerMenu, InfosWrapper, Span} from './styled'
import { IconContext } from "react-icons";

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
    return(
       <PageDefault>
            <Menu />
            <ContainerMenu>

                <IconContext.Provider value={{  size: "30px", margin: "10px"}}>
                    <div>
                        <FcList />         
                    </div>
                </IconContext.Provider>   

                <IconContext.Provider value={{  size: "30px", margin: "10px"}}>
                    <div>
                        <IoIosNotificationsOutline />
                    </div>
                </IconContext.Provider>   

            </ContainerMenu>
            
            <InfosWrapper>
                   <Span><CgAdd />  Adicionar Agendamento</Span>
            
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