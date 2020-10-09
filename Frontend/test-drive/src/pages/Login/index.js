import React, { useState } from 'react'
import {FormField} from '../../components/FormField'
import {ButtonMedio, ButtonGrande, Button as But } from '../../components/Button'
import { PageDefault, ConteudoWrapper, InfosWrapper, Infos , InfoLogin,
ContainerButton, ContainerButtonOne, Span, H1,Custom,Button } from './style'
import { GrView } from 'react-icons/gr'
import { IconContext } from "react-icons";
import {Link} from 'react-router-dom'
import ApiLogin from '../../services/Login'
import {ToastContainer,toast} from 'react-toastify'
import "react-toastify/dist/ReactToastify.css"
const apil = new ApiLogin()


function ViewPassword(){
   let tipo =  document.getElementsByName("senha")[0];
   if(tipo.type === 'password'){
        tipo.type = 'text';
    }else{
       tipo.type = 'password';
    }
};


function Login(){

    const [email,setEmail] = useState('');
    const [senha,setSenha] = useState('');

    async function Logar(){ 
        try{
                const req = {
                    Email: email,
                    Senha: senha
                }

                const resp = await apil.Consultar(req)
                console.log(resp)
                localStorage.setItem('id',resp.id)
                if(resp.nivelLogin == 0){
                    window.location.replace('http://localhost:3000/cliente/home');
                }
                else if (resp.nivelLogin == 1){
                    window.location.replace('http://localhost:3000/funcionario/home');
                }
                else if (resp.nivelLogin == 3){
                    window.location.replace('http://localhost:3000/funcionario/home');
                }
                return resp
        }catch(e){
            if(e.response.data.error) toast.warning(e.response.data.error);
            else toast.error("Algo deu errado. Tente novamente")
        }        
    }
        
    return(

        <PageDefault>
            <ToastContainer />
            <ConteudoWrapper>
            <H1>Flagstaff Car</H1>
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
                                as = {Link}
                                to = '/register'
                                
                            /> 
                       </ContainerButton>
                                         

                    </Infos>

                    <InfoLogin>
                    
                        <FormField 
                            label = 'E-mail'
                            type = 'text'
                            name = 'e-mail'
                            value = {email}
                            onChange = {(e) => setEmail(e.target.value)}
                        />

                        <Custom>

                            <FormField
                                label = 'Senha'
                                type = 'password'
                                name = 'senha'
                                value = {senha}
                                onChange ={(e) => setSenha(e.target.value)}
                            />

                            <IconContext.Provider value={{ color: "red", size: "20px", margin: "0px" }}>
                                <Button type = 'Button' onClick={ViewPassword} >
                                    <GrView />
                                </Button>
                            </IconContext.Provider>                                
                          
                        </Custom>  
                       
                        <Span as = {Link} to = '/reset'>Redefinir-senha</Span> 
                        
                        
                       <ContainerButtonOne>

                            <But onClick = {Logar}>
                                Entrar
                            </But>
                       </ContainerButtonOne>
                    </InfoLogin>
                </InfosWrapper>

            </ConteudoWrapper>
        </PageDefault>
    );
}

export default Login;