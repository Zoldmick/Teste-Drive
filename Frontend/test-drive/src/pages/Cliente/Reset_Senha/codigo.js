import React from 'react'
import {FormField} from '../../../components/FormField'
import {Page} from './styled'
//import ApiLogin from '../../../services/Login'
import {Toasticontainer,toast} from 'react-toastify'

//const Apil = new ApiLogin();

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