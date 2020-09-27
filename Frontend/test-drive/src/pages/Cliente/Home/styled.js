import styled from 'styled-components'

export const PageDefault = styled.div`
    display:flex;
    flex-direction:column;
`;

export const ContainerMenu = styled.div`
    display:flex;
    height:10vh;

    justify-content:space-between;
`;

export const InfosWrapper = styled.div`
    display:flex;
    flex-direction:column;
    height:50vh;

    box-sizing:border-box;
    padding-top:55px;
    padding-left:180px;
    padding-right:180px;
    margin-bottom:10px;

    @media(max-width: 880px){
        padding-left:20px;
        padding-right:20px;
        overflow:auto;

    }
`;

export const Span = styled.div``;

