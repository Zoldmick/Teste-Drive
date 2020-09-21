import React from 'react'
import Header from '../../components/Header'
import FormField from '../../components/FormField'
import {ButtonMedio, ButtonGrande} from '../../components/Button'
import { PageDefault, ConteudoWrapper, InfosWrapper, Infos , InfoLogin, ContainerButton, ContainerButtonOne, Span } from './style'

function Login(){
    return(
        <PageDefault>

            <Header />
            <ConteudoWrapper>

                <InfosWrapper>
                    <Infos>
                        <p>
                            Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor 
                            ncididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis 
                            nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. 
                            Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu
                            fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in 
                            culpa qui officia deserunt mollit anim id est laborum. 
                        </p>

                        <p>
                            Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor 
                            incididunt ut labore et dolore magna aliqua. In eu mi bibendum neque. Porttitor 
                            rhoncus dolor purus non. Leo a diam sollicitudin tempor
                        </p>
                       <ContainerButton>
                            <ButtonGrande
                                children = 'Cadastra-se'
                                onClick = "{}"
                            /> 
                       </ContainerButton>
                                         

                    </Infos>

                    <InfoLogin>
                        <FormField 
                            label = 'E-mail'
                            type = 'text'
                            name = 'e-mail'
                        />
                            
                        <FormField 
                            label = 'Senha'
                            type = 'password'
                            name = 'senha'
                        />
                        <Span>Redefinir-senha</Span>
                        
                       <ContainerButtonOne>
                            <ButtonMedio 
                            
                                children = 'Entrar'
                                onClick = '{}'
                            />
                       </ContainerButtonOne>

                    </InfoLogin>
                </InfosWrapper>

            </ConteudoWrapper>

        </PageDefault>
    );
}

export default Login;