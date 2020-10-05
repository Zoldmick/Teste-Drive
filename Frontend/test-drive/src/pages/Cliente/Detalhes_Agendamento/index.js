import React, { Component } from 'react'
// //import { Fade } from 'react-bootstrap'
import {FormField} from '../../../components/FormField'
import {ButtonMedio,ButtonGrande} from '../../../components/Button'
import {PageDefault,Header,H1, InfoWrapper, Custom, FeedWrapper , H3 , ContButton, CometiWrapper,MapContainer} from './styled'
import {Map, InfoWindow, Marker, GoogleApiWrapper} from 'google-maps-react';

class Details_Schedule extends Component {
    render(){
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
                        />
    
                        <FormField 
                            label = 'Data/Hora'
                            type = 'datetime-local'
                        />
                    </Custom>
    
                    <Custom>
    
                        <FormField
                            label = 'Acompanhante'
                            type = 'text'
                        />
                        <FormField
                            label = 'Status'
                            type = 'text'
                        />
    
                    </Custom>
    
                    <Custom>
    
                        <FormField 
                            label = 'funcionario'
                            type = 'text'
                        />
                        <FormField 
                            label = 'Carro PCD'
                            type = 'checkbox'
                        />
    
                    </Custom>    
    
                    <Custom>
    
                        <FormField 
                            label = 'Rota inicial'
                            type = 'text'
                        />
                        <FormField
                            label = 'Rota final'
                            type = 'text'
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
                    />
    
                    <ContButton>
                        <ButtonGrande>Adicionar Feedback</ButtonGrande>
    
                        <ButtonGrande>Cancelar Agendamento</ButtonGrande>
                    </ContButton>
    
                </FeedWrapper>
            </PageDefault>
        );
    }
}

export default GoogleApiWrapper({
  apiKey: ('AIzaSyCGWZzaFc3roC3dMm2z7rnmw1KofA1XDv8')
})(Details_Schedule)