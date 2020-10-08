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
    min-height:100vh;
    width:100vw;
    
    box-sizing:border-box;
    justify-items:center;
    align-items:center; 
    margin-top:20px;

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
 
export const Custom= styled.div`
    display:flex;
    height:10vh;
    width:70vw;

    justify-content:space-between;
    margin-top:20px;
    margin-bottom:5px;

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

export const Select = styled.select`
    height:35px;
    width:25vw;
    margin-top:30px;
    margin-bottom:15px;

    text-align:center;
    font-size:18px;
    font-display:oblique;
    font-weight:200;
    letter-spacing:2px;
    color:white;

    background:gray;
    box-sizing:border-box;
    padding:5px 16px;
    border-radius:4px;

    overflow:auto;
`;

export const Option = styled.option`
    text-align:center;
    font-size:18px;
    font-display:oblique;
    font-weight:300;
    letter-spacing:2px;
    
    color:darkblue;
    background:white;

    &:hover{
        background: gray;
        color:red;
    }
`;

export const ClienteWrapper = styled.div`
    display:flex;
    flex-direction:column;
    height:90vh;
    width:80vw;

    box-sizing:border-box;
    padding-left:50px;
    padding-top:10px;
    border:1px solid black;
`;

export const FuncWrapper = styled.div`
    display:flex;
    flex-direction:column;
    height:45vh;
    width:80vw;

    box-sizing:border-box;
    padding-left:50px;
    padding-top:10px;
    border:1px solid black;
`;

export const H2 = styled.h2`
    font-size:26px;
    font-weight:200;

    text-align:center;
    letter-spacing:2px;
`;