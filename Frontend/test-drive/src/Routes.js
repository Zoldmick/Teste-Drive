import React from 'react'
import { BrowserRouter, Switch, Route} from 'react-router-dom'
import Login from './pages/Login'
import HomeCliente from './pages/Cliente/Home'
import Register from './pages/Cliente/Cadastro_Agendamento'
import RegisterCliente from './pages/Cliente/Cadastro_Cliente'
import ResetSenha from './pages/Cliente/Reset_Senha'
import Details_Schedule from './pages/Cliente/Detalhes_Agendamento'
import NotFound from './pages/NotFound'

function Routes () {
    return(
        <BrowserRouter>
            <Switch>
                                    /* Global */
                <Route path = '/' component = {Login} exact />
                <Route path = 'cliente/home' component = {HomeCliente} exact />

                                    /* Cliente */
                <Route path = '/register' component = {RegisterCliente} exact  />
                <Route path = '/cliente/agendamento' component = {Register} exact /> 
                <Route path = '/cliente/detalhes-do-agendamento' component = {Details_Schedule} exact/>
                <Route path = '/reset' component = {ResetSenha} exact /> 
                <Route path = '*' component = {NotFound} />                                    
            
            </Switch>
        </BrowserRouter>
    );
}

export default Routes;