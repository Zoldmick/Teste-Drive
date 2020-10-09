import React, {useState, useEffect} from 'react'
import {ButtonGrande} from '../../../components/Button'
import {FormField} from '../../../components/FormField'
import Footer from '../../../components/Fotter'
import { FaCar as CarIcon} from 'react-icons/fa';
import {PageDefault, ContainerImg, InfoRegister, InfoCar, ContainerButton, Span, H1, Select,Option, Custom,ClienteWrapper,FuncWrapper, H2} from './styled'
import Veiculo from '../../../services/Veiculo'
import {ToastContainer,toast} from 'react-toastify'
import "react-toastify/dist/ReactToastify.css"

const ApiCar = new Veiculo();

function RegisterAgendamento (){

    const [req, setReq] = useState([]);
    const [pcd,setPcd] = useState(false)
    const [img,setImg] = useState('https://img.elo7.com.br/product/zoom/1F032CF/painel-de-festa-carro-3d-carro-3d.jpg')

    const ConsultCar =  async () => {
        try{
            const consult = await ApiCar.Consultar(pcd);
            setReq([...consult])
        }catch(e) {
        }  
    }

    useEffect(() => {
        ConsultCar()
    }, [])
    

    return(
        <PageDefault>
            <H1>Agendamento</H1>
            <ContainerImg>
                <div>
                    <img src = {img}  alt= '' height='150' width='200'/>
                </div>
            </ContainerImg>

            <InfoRegister>
                <form>
                    <ClienteWrapper>

                        <H2>Dados do Cliente</H2>
                        <Custom>
                            
                            <FormField 
                                label = 'E-mail'
                                type = 'text' 
                                name = 'email'
                                />
                            
                            <FormField 
                                label = 'Senha'
                                type = 'password'
                                name = 'senha'
                            />

                        </Custom>
                    
                        

                    
                        
                        <FormField 
                            label = 'Nome de Usuario'
                            type = 'text'
                            name= 'nmusuario'
                        />
                    
                        

                        <Custom>

                            <FormField 
                                label = 'CPF'
                                type = 'text'
                                name= 'cpf'
                            />

                            <FormField 
                                label = 'Data de Nascimento'
                                type = 'date'
                                name= 'nascimento'
                            />

                        </Custom>
                        

                        <Custom>
                            
                            <FormField 
                                label = 'Endereço'
                                type = 'text'
                                name= 'endereco'
                            />

                            <FormField 
                                label = 'numero'
                                type = 'text'
                                name= 'numero'
                            />

                        </Custom>

                    
                        <Custom>
                            <FormField 
                                label = 'tel'
                                type = 'text'
                                name= 'telefone'
                            />

                            <FormField 
                                label = 'Cel.'
                                type = 'text'
                                name= 'celular'
                            />
                            
                        </Custom>

                        <Custom>

                            <FormField 
                                label = 'CNH'
                                type = 'text'
                                name= 'cnh'
                            />

                            <FormField 
                                label = 'Sou Deficiente.'
                                type = 'checkbox'
                                name= 'deficiente'
                            />    
                            
                        </Custom>                
                    
                    </ClienteWrapper>

                    <hr/>

                    <FuncWrapper>

                        <H2>Dados do Agendamento </H2>      
                
                        <Select name = 'carselect'>
                            <Option value='0' >Selecionar carro para teste</Option>
                            {/* Colocar opção para selecionar o pcd*/}
                            {req.map(x => 
                            <>
                                {setImg(ApiCar.BuscarFoto(x.imagem))}
                                <Option value={x.id} >{x.modelo}</Option>
                            </>
                            )}
                        </Select>

                    
                        <Custom>

                            <FormField 
                                label = 'Data/Hora'
                                type = 'datetime-local' 
                                name = 'data/hora'
                            />

                            <FormField 
                                label = 'Acompanhante'
                                type = 'text'
                                name = 'acompanhante'
                            />

                        </Custom>

                        <ContainerButton>
                            <FormField 
                                type = 'Reset'
                                name = 'acompanhante'
                                value = 'Limpar'
                            />

                            <ButtonGrande
                                children = "Salvar"
                            />
                        </ContainerButton>
                    </FuncWrapper>

                </form>
            </InfoRegister>
            
            <Span> <CarIcon /> Descrição do veiculo:</Span>
            <InfoCar>
               
            </InfoCar>

            <Footer />
        </PageDefault>
    );
}

export default RegisterAgendamento;