import React, { Component } from 'react'
// //import { Fade } from 'react-bootstrap'
import {FormField} from '../../../components/FormField'
import {ButtonMedio,ButtonGrande} from '../../../components/Button'
import {PageDefault,Header,H1, InfoWrapper, Custom, FeedWrapper , H3 , ContButton, CometiWrapper} from './styled'
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
    
    
                <FeedWrapper>
                    <H3>FeedBack</H3>
    
                    <CometiWrapper>
                        <Map google= {this.props.google} zoom={14}>    
                            <Marker onClick={this.onMarkerClick}
                            name={'Current location'} />
                            <InfoWindow onClose={this.onInfoWindowClose}>
                        </InfoWindow>
                        </Map>                           
                    </CometiWrapper>
                    
                    <FormField 
                        Label = 'Comentario'
                        type = 'textarea'
                    />
    
                    <ContButton>
                        <ButtonMedio>Adicionar Feed</ButtonMedio>
    
                        <ButtonGrande>Cancelar Agendamento</ButtonGrande>
                    </ContButton>
    
                </FeedWrapper>
            </PageDefault>
        );
    }
}

export default GoogleApiWrapper({
  apiKey: ("AIzaSyCGWZzaFc3roC3dMm2z7rnmw1KofA1XDv8")
})(Details_Schedule)