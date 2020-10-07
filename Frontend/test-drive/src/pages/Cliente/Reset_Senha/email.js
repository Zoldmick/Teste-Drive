import React,{useState} from 'react'
import {FormField} from '../../../components/FormField'
import {Page} from './styled'
import ApiLogin from '../../services/Login'

const Apil = new ApiLogin();

function Email() {

    const [email,setEmail] = useState('')
    const [emailR,setEmailR] = useState('')

    function Cod_email(){

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
    
        </Page>
    );
}

export default Email;