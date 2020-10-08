import React from 'react'
import {BrowserRouter as Router,Switch,Route,Link} from "react-router-dom";
import {PageDefault,H1,ConteudoWrapper} from './styled'
import {ButtonMedio, ButtonGrande} from '../../../components/Button'
import Email from './email'
import Codigo from './codigo'
import NovaSenha from './resetsenha'


    
export default function ResetSenha(){
    return(
        <PageDefault>
            <H1>Recuperação de Senha</H1>
            
            <ConteudoWrapper>
                <Router>
                    <Switch>
                        <Route path="/reset/nvsenha">
                           <NovaSenha />
                           <Link to = '/' >
                                <ButtonMedio 
                                    children = 'Concluir'
                                />
                           </Link>
                        </Route>
                        <Route path="/reset/codigo">
                            <Codigo />
                            <Link to = '/reset/nvsenha' >
                                <ButtonGrande 
                                    children = 'Confirmar código'
                                />
                            </Link>
                        </Route>
                        <Route path="/">
                            <Email />   
                           
                        </Route>
                    </Switch>
                   
                </Router>
                
            </ConteudoWrapper>
        </PageDefault>
    );    
}