import React from 'react'
import {ButtonMedio} from '../../components/Button'
import FormField from '../../components/FormField'
import Footer from '../../components/Fotter'
import {PageDefault, ContainerImg, InfoRegister, InfoCar} from './styled'

function Register (){
    return(
        <PageDefault>
            <h1>Agendamento</h1>
            <ContainerImg>
                <img src = ""  alt= "imagem do Carro" />
            </ContainerImg>
            <InfoRegister>
                <form>

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
                <FormField 
                    type = 'Reset'
                    name = 'acompanhante'
                />

                <ButtonMedio
                    children = "Salvar"
                />
                </form>
            </InfoRegister>
            <InfoCar>

            </InfoCar>
            <Footer />
        </PageDefault>
    );
}

export default Register;