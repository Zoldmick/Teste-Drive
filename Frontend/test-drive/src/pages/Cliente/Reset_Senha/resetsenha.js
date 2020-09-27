import React from 'react'
import FormField from '../../../components/FormField'
import {Page} from './styled'

function NovaSenha() {
    return(
        <Page>
    
            <FormField
                label = 'Nova Senha'
                type = 'password'
                name = 'senha'
            />
            <FormField
                label = 'Nova Senha'
                type = 'password'
                name = 'senha'
            />
        
        </Page>
    );
}

export default NovaSenha;