import React, {useState, useEffect} from 'react'
import {ButtonGrande} from '../../../components/Button'
import {FormField} from '../../../components/FormField'
import Footer from '../../../components/Fotter'
import { FaCar as CarIcon} from 'react-icons/fa';
import {PageDefault, ContainerImg, InfoRegister, InfoCar, ContainerButton, ContainerForm, Span, H1, Select,Option} from './styled'
import Veiculo from '../../../services/Veiculo'
import { ToastContainer, toast } from 'react-toastify'
import Agendamento from '../../../services/Agendamento'
const ApiAg = new Agendamento()
const ApiCar = new Veiculo()

function Register (){

    const [req, setReq] = useState([]);
    const [pcd,setPcd] = useState(false)
    const [veiculo,setVeiculo] = useState()
    const [data,setData] = useState()
    const [acompanhante,setAcompanhante] = useState()

    async function CadastrarAgendamento(){
        try{
            const req = {
                Login:localStorage.getItem('id'),
                Data:data,
                Veiculo:veiculo,
                Acompanhante:acompanhante
            }

            console.log(req)
            const resp = await ApiAg.Cadastrar(req)
            return resp

        }catch(e){
            toast.info(e.response.data)
        }
    }

    async function ConsultCar(){
        try{
            if(localStorage.getItem('id') == null) window.location.replace(`http://${window.location.host}`)
            const consult = await ApiCar.Consultar(localStorage.getItem('id'));
            console.log(localStorage.getItem('id'))
            console.log(consult)
            setReq([...consult])
        }catch(e) {
            console.log(e.response.data)
        }  
    }

    useEffect(() => {
        ConsultCar()
    }, [])
    
    return(
        <PageDefault>
           
            <H1>Agendamento</H1>
            <ContainerImg>
                <div>
                    <img src = '#'  alt= "imagem do Carro" height='150' width='200'/>
                </div>
            </ContainerImg>

            <InfoRegister>

                <form>
                    <Select name = 'carselect' onChange={(e) => setVeiculo(e.target.value)}>
                        <Option value='0' >Selecionar carro para teste</Option>
                        {req.map(x => 
                            <>
                                {console.log(x)}
                                <Option key={x.id} value={x.id} >{x.modelo}</Option>
                            </>
                        )}
                    </Select>

                   <ContainerForm>

                        <FormField 
                            label = 'Data/Hora'
                            type = 'datetime-local' 
                            name = 'data/hora'
                            value = {data}
                            onChange = {(e) => setData(e.target.value)}
                            />

                        <FormField 
                            label = 'Acompanhante'
                            type = 'text'
                            name = 'acompanhante'
                            value = {acompanhante}
                            onChange = {(e) => setAcompanhante(e.target.value)}
                        />
                   </ContainerForm>

                   <ContainerButton>
                        <FormField 
                            type = 'Reset'
                            name = 'acompanhante'
                            value = 'Limpar'
                        />

                        <ButtonGrande
                            onClick = {CadastrarAgendamento}
                            children = "Salvar"
                        />
                   </ContainerButton>

                </form>
            </InfoRegister>
            <Span> <CarIcon /> Descrição do veiculo:</Span>
            <InfoCar>
               
            </InfoCar>

            <Footer />
        </PageDefault>
    );
}

export default Register;