import React from 'react'
import {FormField} from '../../../components/FormField'
//import InputMask from 'react-input-mask';
import {ButtonMedio} from '../../../components/Button'
import { PageDefault, H1, Form, FormWrapper, Custom, ContButton} from  './styled'

function RegisterCliente (){
    return(
        <PageDefault>
            <H1>Cadastra-se</H1>

            <Form>
                <Custom>
                    <FormField 
                        label = 'E-mail'
                        type = 'text'
                        name='e-mail'
                    />

                    <FormField 
                        label = 'Senha'
                        type = 'password'
                        name= 'senha'
                    />
                </Custom>

                <FormWrapper>
                    <FormField 
                        label = 'Nome de Usuario'
                        type = 'text'
                        name= 'nmusuario'
                    />

                    <Custom>
                        <FormField 
                            label = 'CPF'
                            type = 'text'
                            name= 'cpf'
                        />
                        <FormField 
                            label = 'Data de Nascimento'
                            type = 'date'
                            name= 'nascimento'
                        />
                    </Custom>
                    <Custom>
                        <FormField 
                            label = 'Endereço'
                            type = 'text'
                            name= 'endereco'
                        />
                        <FormField 
                            label = 'numero'
                            type = 'text'
                            name= 'numero'
                        />
                    </Custom>
                    <Custom>
                        
                        <FormField 
                            label = 'tel'
                            type = 'text'
                            name= 'telefone'
                        />

                        <FormField 
                            label = 'Cel.'
                            type = 'text'
                            name= 'celular'
                        />
                    </Custom>

                </FormWrapper>
                <Custom>
                    <FormField 
                        label = 'CNH'
                        type = 'text'
                        name= 'cnh'
                    />
                    <FormField 
                        label = 'Sou Deficiente.'
                        type = 'checkbox'
                        name= 'deficiente'
                    />
                </Custom>
               
                <ContButton>
                    <ButtonMedio
                        children = 'Salvar'
                    />

                    <FormField 
                        type = 'Reset'
                        value = 'Limpar'
                    />
                </ContButton>
            </Form>
        </PageDefault>
    );
}

export default RegisterCliente;