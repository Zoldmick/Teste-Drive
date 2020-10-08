import React,{ useState } from 'react'
import Menu from '../../../components/Header'
import {FormField} from '../../../components/FormField'
import Footer from '../../../components/Fotter'
import {PageDefault, ContainerMenu, InfosWrapper, Span, Button, Notifica ,NotiWrapper,Custom,Select, Option} from './styled'
import { IconContext } from "react-icons";
import {Link} from 'react-router-dom'
import Table from 'react-bootstrap/Table'

//icones
import { FcList } from 'react-icons/fc';
import { CgAdd } from "react-icons/cg";
import { IoIosNotificationsOutline } from "react-icons/io";
import { FaInfo } from 'react-icons/fa'

function HomeFuncionario() {

    const [email,setEmail] = useState();
    const [senha,setSenha] = useState();

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


                <Custom>
                    <FormField 
                        type = 'text'
                        name = 'nm_cliente'
                        placeholder = 'Buscar por nome do cliente'
                    />

                    <FormField 
                        type = 'month'
                        name = 'nm_cliente'
                    />

                    <Select>
                        <Option value = '0'>Selecione o status </Option>
                        <Option value = '1'>Aprovado</Option>
                        <Option value = '2'>Cancelado</Option>
                        <Option value = '3'>Em analise</Option>
                        <Option value = '4'>concluido</Option>
                    </Select>
                </Custom>
               

               <Span as = {Link} to = '/funcionario/agendamento'><CgAdd />  Adicionar Agendamento</Span>
            
                <Table striped bordered hover>
                    <thead>
                        <tr>
                        <th>#</th>
                        <th>Modelo</th>
                        <th>Data/Hora</th>
                        <th>Funcionario</th>
                        <th>Status</th>
                        <th>Feedback</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                        <td> <FaInfo /> </td>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td></td>
                        </tr>
                
                    </tbody>
                </Table>

            </InfosWrapper>

            <Footer />
        </PageDefault>
    );
}

export default HomeFuncionario;