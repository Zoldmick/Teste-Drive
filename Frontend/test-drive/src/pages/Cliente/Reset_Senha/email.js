import React,{useState} from 'react'
import {FormField} from '../../../components/FormField'
import {Page} from './styled'
//import ApiLogin from '../../services/Login'
import {Toasticontainer,toast} from 'react-toastify'

//const Apil = new ApiLogin();

function Email() {

    const [email,setEmail] = useState('')
    const [emailR,setEmailR] = useState('')

    async function Cod_email(){
        /*try{
            const req = await Apil.EnviarSenha(email,emailR)
            return req;
        }catch(e){
            toast.error(e.response.data.error)
        }*/
    
    }
    return(
        <Page>
     
            <FormField
                label = 'E-mail'
                type = 'text'
                name = 'email'
                value = {email}
                onChange = {(e) => setEmail(e.target.value)}
            />

            <FormField
                label = 'E-mail de recupeção de conta'
                type = 'text'
                name = 'email'
                value = {emailR}
                onChange = {(e) => setEmailR(e.target.value)}
            />
            
            {/*<Link to = '/reset/codigo' >
               <ButtonGrande onClick = {Cod_email}
                   children = 'Enviar codigo'
                />
            </Link>*/}
        </Page>
    );
}

export default Email;