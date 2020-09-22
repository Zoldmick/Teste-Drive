import React from 'react'
import {ButtonGrande} from '../../../components/Button'
import FormField from '../../../components/FormField'
import Footer from '../../../components/Fotter'
import { FaCar as CarIcon} from 'react-icons/fa';
import {PageDefault, ContainerImg, InfoRegister, InfoCar, ContainerButton, ContainerForm, Span, H1} from './styled'

function Register (){
    return(
        <PageDefault>
            <H1>Agendamento</H1>
            <ContainerImg>
                <div>
                    <img src = ""  alt= "imagem do Carro" height='150' width='200'/>
                </div>
            </ContainerImg>

            <InfoRegister>

                <form>
                    
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