import React from 'react'
import FormField from '../../../components/FormField'
import {Page} from './styled'

function Email() {
    return(
        <Page>
    
            <FormField
                label = 'E-mail'
                type = 'text'
                name = 'email'
            />
            <FormField
                label = 'E-mail'
                type = 'text'
                name = 'email'
            />
        
    
        </Page>
    );
}

export default Email;