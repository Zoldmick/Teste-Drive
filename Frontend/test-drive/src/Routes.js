import React from 'react'
import { BrowserRouter, Switch, Route} from 'react-router-dom'
import Login from './pages/Login'
import HomeCliente from './pages/Home'
import Register from './pages/Cadastro'

function Routes () {
    return(
        <BrowserRouter>
            <Switch>
                <Route path = '/' component = {Login} exact />
                <Route path = '/home' component = {HomeCliente} exact />
                <Route path = '/register' component = {Register} exact /> 
            </Switch>
        </BrowserRouter>
    );
}

export default Routes;