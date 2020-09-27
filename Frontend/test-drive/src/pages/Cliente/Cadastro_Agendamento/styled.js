import styled from 'styled-components'

export const PageDefault = styled.div`
    display:flex;
    flex-direction:column;
`;

export const ContainerImg = styled.div`
    display:flex;

    justify-self:center;
`;

export const InfoRegister = styled.div`
    display:flex;
    flex-direction:column;
    height:30vh;
    width:100vw;
    
    box-sizing:border-box;
    justify-items:center;
    align-items:center; 

    @media(max-width:800px){
       height:50vh;
    }
`;

export const InfoCar = styled.div`
    display:flex;
    height:50vh;
    width:70vw;

    border:2px solid rgb(000,000,000,0.4);
    margin-left:auto;
    margin-right:auto;
    margin-bottom:20px;
    margin-top:10px;

    @media(max-width:800px){
       width:90vw
    }
`;

export const ContainerButton = styled.div`
    display:flex;
    height:10vh;
    width:60vw;

    justify-content:space-evenly;
    @media(max-width:800px){
        flex-direction:column;
        height:20vh;

    }
`;

export const ContainerForm = styled.div`
    display:flex;
    height:10vh;
    width:60vw;

    justify-content:space-evenly;
    margin-top:20px;
    margin-bottom:20px;

    @media(max-width:800px){
        flex-direction:column;
        height:20vh;
        margin-top:30px;
    }
`;

export const Span = styled.span`
    font-size:15px;
    font-style:oblique;
    font-weight:500;

    color:black;
    text-align:center;
`;

export const H1 = styled.h1`
    text-align:center;
    text-decoration:underline;

    font-size:47px;
    font-weight:400;
    color:var(--Blue);

`;