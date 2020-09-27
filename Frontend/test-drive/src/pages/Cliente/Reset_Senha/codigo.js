import React from 'react'
import FormField from '../../../components/FormField'
import {Page} from './styled'

function Codigo(){
    return(
        <Page>
            <FormField 
                label = 'Codigo'
                type = 'number'
                name = 'codigo'
            />
        </Page>
    )
}

export default Codigo;