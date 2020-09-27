import React from 'react'
//import { Fade } from 'react-bootstrap'
import FormField from '../../../components/FormField'
import {ButtonMedio,ButtonGrande} from '../../../components/Button'
import {PageDefault,Header,H1, InfoWrapper, Custom, FeedWrapper , H3 , ContButton, CometiWrapper} from './styled'
//import {Loader, LoaderOptions } from 'google-maps'

/*function inicializar() {
    var coordenadas = {lat: -23.716267, lng: -46.683243};

    var mapa = new google.maps.Map(document.getElementById('mapa'), {
      zoom: 15,
      center: coordenadas 
    });

    var marker = new google.maps.Marker({
      position: coordenadas,
      map: mapa,
      title: 'Meu marcador'
    });
}
<script>
    async defer
    src="https://maps.googleapis.com/maps/api/js?key=AIzaSyCpE-1PQJETS6x03KnAF2LO17Zo_h1lnRc&callback=inicializa

    AIzaSyCpE-1PQJETS6x03KnAF2LO17Zo_h1lnRc

    </script>
*/

function Details_Schedule(){
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

export default Details_Schedule;