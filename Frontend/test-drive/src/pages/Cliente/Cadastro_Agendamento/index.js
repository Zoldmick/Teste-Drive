import React, {useState, useEffect} from 'react'
import {ButtonGrande} from '../../../components/Button'
import {FormField} from '../../../components/FormField'
import Footer from '../../../components/Fotter'
import { FaCar as CarIcon} from 'react-icons/fa';
import {PageDefault, ContainerImg, InfoRegister, InfoCar, ContainerButton, ContainerForm, Span, H1, Select,Option} from './styled'
import Veiculo from '../../../services/Veiculo'
//import { toastContainer, toast } from 'react-toastify'

const ApiCar = new Veiculo();

function Register (){

    const [req, setReq] = useState([]);

    
    const ConsultCar =  async () => {
        try{
            const consult = await ApiCar.Consultar();
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
                    <img src = ''  alt= "imagem do Carro" height='150' width='200'/>

                </div>
            </ContainerImg>

            <InfoRegister>

                <form>
                    <Select name = 'carselect'>
                        <Option value='0' >Selecionar carro para teste</Option>
                        {req.filter(x => x.pcd = true).map(x => 
                            <Option value={x.id} >{x.Modelo}</Option>
                        )}
                    </Select>

                   <ContainerForm>

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
                   </ContainerForm>

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

                </form>
            </InfoRegister>
            <Span> <CarIcon /> Descrição do veiculo:</Span>
            <InfoCar>
               
            </InfoCar>

            <Footer />
        </PageDefault>
    );
}

export default Register;