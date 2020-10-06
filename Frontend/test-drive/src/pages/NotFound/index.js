import React from 'react'
import Carro from '../../assets/img/Carro.jpg'
import {PageDefault,InfoWrapper,Mensagem,ImgContainer,VidContainer} from './styled'



function NotFound(){
    return(
        <PageDefault>
            <InfoWrapper>
                <Mensagem>

                </Mensagem>
                <ImgContainer>
                    <Img src = {Carro} alt='Carro quebrado' />
                </ImgContainer>
            </InfoWrapper>
            <VidContainer>
                
            </VidContainer>
        </PageDefault>
    );
}