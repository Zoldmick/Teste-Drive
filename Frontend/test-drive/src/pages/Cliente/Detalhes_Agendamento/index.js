import React, { Component, useEffect, useState } from 'react'
// //import { Fade } from 'react-bootstrap'
import {FormField} from '../../../components/FormField'
import {ButtonMedio,ButtonGrande} from '../../../components/Button'
import {PageDefault,Header,H1, InfoWrapper, Custom, FeedWrapper , H3 , ContButton, CometiWrapper,MapContainer} from './styled'
import {Map, InfoWindow, Marker, GoogleApiWrapper} from 'google-maps-react';
import Agendamento from  '../../../services/Agendamento'
const Api = new Agendamento()


class Details_Schedule extends Component {
    render(){
        
        const [id,setId] = useState(0) // aguardando valor externo
        const [modelo,setModelo] = useState('')
        const [acompanhante,setAcompanhante] = useState('') 
        const [funcionario,setFuncionario] = useState('')
        const [inicio,setInicio] = useState('')
        const [final,setFinal] = useState('')
        const [hrFinal,setHrFinal] = useState('')
        const [data,setData] = useState('')
        const [feedback,setFeedback] = useState('')
        const [avaliacao,setAvaliacao] = useState('')
        const [status,setStatus] = useState('')
        const [pcd,setPcd] = useState('')

        async function consultarAgendamento(){
            const resp = await Api.ConsultarAgendamento(id)
            setModelo(resp.Veiculo)
            setAcompanhante(resp.Acompanhante)
            setData(resp.Data)
            setHrFinal(resp.HoraFinal)
            setInicio(resp.Inicio)
            setFinal(resp.Final)
            setStatus(resp.Status)
            setPcd(resp.CarroPcd)
            setFuncionario(resp.Funcionario)
            return resp
        }

        async function alterarFeedbackAvaliacao(){
            const resp = await Api.AvaliacaoFeedback(id,avaliacao,feedback)
            return resp
        }

        async function cancelarAgendamento(){
            const resp = await Api.AlterarStatus(id,'cancelado')
            return resp
        }

        useEffect(() => {
            consultarAgendamento()
        },[])

        return(
            <PageDefault>
                <Header>
                    <H1>Detalhes do Agendamento</H1>
                </Header>
                <InfoWrapper>
    
                    <Custom>
                        <FormField 
                            label = 'Modelo'
                            type = 'text'
                            value = {modelo}
                            onChange = ''
                        />
    
                        <FormField 
                            label = 'Data/Hora'
                            type = 'datetime-local'
                            value = {data}
                        />
                    </Custom>
    
                    <Custom>
    
                        <FormField
                            label = 'Acompanhante'
                            type = 'text'
                            value = {acompanhante}
                        />
                        <FormField
                            label = 'Status'
                            type = 'text'
                            value = {status}
                        />
    
                    </Custom>
    
                    <Custom>
    
                        <FormField 
                            label = 'funcionario'
                            type = 'text'
                            value = {funcionario}
                        />
                        <FormField 
                            label = 'Carro PCD'
                            type = 'checkbox'
                            value = {pcd}
                        /> 
    
                    </Custom>    
    
                    <Custom>
    
                        <FormField 
                            label = 'Rota inicial'
                            type = 'text'
                            value = {inicio}
                        />
                        <FormField
                            label = 'Rota final'
                            type = 'text'
                            value = {final}
                        />
    
                    </Custom>
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            
                </InfoWrapper>  

                <MapContainer>

                    <Map google= {this.props.google}                     
                        containerStyle={{width: '70vw', height: '80vh', position: 'relative'}}
                        style={{width: '70vw', height: '80vh', position: 'relative'}}
                        initialCenter={{
                            lat: -23.708222,
                            lng: -46.700221
                        }}
                        zoom={13}>  

                        <Marker
                            title={'The marker`s title will appear as a tooltip.'}
                            name={'SOMA'}
                            position={{lat: -23.680306, lng: -46.707996}} 
                        />
                            
                        <Marker
                            name={'Dolores park'}
                            position={{lat: -23.733598, lng: -46.699074}} 
                        />

                    </Map>    

                </MapContainer>         

                <FeedWrapper>
                    <H3>FeedBack</H3>
    
                    <CometiWrapper>
                                      
                    
                    </CometiWrapper>
                    
                    <FormField 
                        Label = 'Comentario'
                        type = 'textarea'
                        value = {feedback}
                        onChange = {(e) => setFeedback(e.target.value)}
                    />
                    {/* Falta a avaliacao */}
                    <ContButton>
                        <ButtonGrande onClick={alterarFeedbackAvaliacao}>Adicionar Feedback</ButtonGrande>
    
                        <ButtonGrande onClick={cancelarAgendamento}>Cancelar Agendamento</ButtonGrande>
                    </ContButton>
    
                </FeedWrapper>
            </PageDefault>
        );
    }
}

export default GoogleApiWrapper({
  apiKey: ('AIzaSyCGWZzaFc3roC3dMm2z7rnmw1KofA1XDv8')
})(Details_Schedule)