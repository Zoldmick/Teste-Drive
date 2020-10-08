import React, { useState } from 'react'
import { FormField } from '../../../components/FormField'
//import InputMask from 'react-input-mask';
import { ButtonMedio, Button } from '../../../components/Button'
import { PageDefault, H1, Form, FormWrapper, Custom, ContButton } from  './styled'
import ApiClient from '../../../services/Cliente' 
import { toast, ToastContainer } from 'react-toastify'
const client = new ApiClient()


function RegisterCliente (){

    const [nm,setNm] = useState('')
    const [email,setEmail] = useState('')
    const [senha,setSenha] = useState('')
    const [cpf,setCpf] = useState('')
    const [nasc,setNasc] = useState()
    const [endereco,setEndereco] = useState('')
    const [num,setNum] = useState('')
    const [tel,setTel] = useState('')
    const [celular,setCelular] = useState('')
    const [cnh,setCnh] = useState('')
    const [deficiente,setDeficiente] = useState(false)
    const [imagem,setImagem] = useState()

    async function Cadastrar(){
        try{

            const req = {
                Email:email,
                Senha:senha,
                Nome:nm,
                Cpf:cpf,
                Nascimento:nasc,
                Endereco:endereco,
                Telefone:tel,
                Celular:celular,
                Residencia:num,
                Deficiencia:deficiente,
                Cnh:cnh,
                Imagem:imagem 
            }
            console.log(req)
            const resp = await client.Cadastrar(req)
            toast.success("Cadastramento concluido com sucesso")
        }catch(e){
            console.log(e.response.data)
            toast.info(e.response.data.error)
        }
    } 

    return(
        <PageDefault>
            <H1>Cadastra-se</H1>
            <Form method='dialog'>
                <Custom>
                    <FormField 
                        label = 'E-mail'
                        type = 'text'
                        name ='e-mail'
                        value = {email}
                        onChange = {(e) => setEmail(e.target.value)} 
                    />

                    <FormField 
                        label = 'Senha'
                        type = 'password'
                        name = 'senha'
                        value = {senha}
                        onChange = {(e) => setSenha(e.target.value)}
                    />
                </Custom>

                <FormWrapper>
                    <FormField 
                        label = 'Imagem'
                        type = 'file'
                        name = 'imagem'
                        onChange = {(e) => setImagem(e.target.files[0])}
                    />

                    <FormField 
                        label = 'Nome de Usuario'
                        type = 'text'
                        name= 'nmusuario'
                        value = {nm}
                        onChange = {(e) => setNm(e.target.value)} 
                    />

                    <Custom>
                        <FormField 
                            label = 'CPF'
                            type = 'text'
                            name= 'cpf'
                            value = {cpf}
                            onChange = {(e) => setCpf(e.target.value)}
                        />

                        <FormField 
                            label = 'Data de Nascimento'
                            type = 'date'
                            name= 'nascimento'
                            value = {nasc}
                            onChange = {(e) => setNasc(e.target.value)}
                        />
                    </Custom>
                    <Custom>
                        <FormField 
                            label = 'Endereço'
                            type = 'text'
                            name= 'endereco'
                            value = {endereco}
                            onChange = {(e) => setEndereco(e.target.value)}
                        />

                        <FormField 
                            label = 'numero'
                            type = 'number'
                            name= 'numero'
                            value = {num}
                            onChange = {(e) => setNum(e.target.value)}
                        />
                    </Custom>
                    <Custom>
                        <FormField 
                            label = 'Telefone'
                            type = 'text'
                            name= 'telefone'
                            value = {tel}
                            onChange = {(e) => setTel(e.target.value)}
                        />

                        <FormField 
                            label = 'Celular'
                            type = 'text'
                            name= 'celular'
                            value = {celular}
                            onChange = {(e) => setCelular(e.target.value)}
                        />
                    </Custom>

                </FormWrapper>
                <Custom>
                    <FormField 
                        label = 'CNH'
                        type = 'text'
                        name= 'cnh'
                        value = {cnh}
                        onChange = {(e) => setCnh(e.target.value)}
                    />

                    <FormField 
                        label = 'Sou Deficiente.'
                        type = 'checkbox'
                        name= 'deficiente'
                        value = {deficiente}
                        onChange = {(e) => setDeficiente(e.target.value)}
                    />
                </Custom>
               
                <ContButton>
                    <Button onClick = {Cadastrar}>Salvar</Button>

                    <FormField 
                        type = 'reset'
                        value = 'Limpar'
                    />
                </ContButton>
                <ToastContainer />
            </Form>
        </PageDefault>
    );
}

export default RegisterCliente;