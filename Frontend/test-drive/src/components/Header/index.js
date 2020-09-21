import React from 'react'
import {PageDefault, NmEmpresa, Logotipo, H1} from './styled'

function Header (){
    return(
        <PageDefault>
            <NmEmpresa>
                <H1>Flagstaff Car</H1>
            </NmEmpresa>
            <Logotipo>
                <img src = "" alt="Logotipo Flagstaff Car" height='100' />
            </Logotipo>
        </PageDefault>  
    );
}

export default Header;