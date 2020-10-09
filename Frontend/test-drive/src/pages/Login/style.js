import  styled from 'styled-components'

export const PageDefault = styled.div`
    display:flex;
    flex-direction:column;
    height:100vh;
    width:100vw;
`;

export const ConteudoWrapper = styled.div`
    display:flex;
    height:80vh;
    width:100vw;

    flex-direction:column;
    box-sizing:border-box;
    align-items:center;
    justify-content:center;
    padding:20px;
`;

export const InfosWrapper = styled.div`
    display:flex;
    height:60vh;
    width:80vw;

    box-sizing:border-box;
    align-content:center;
    border:2px solid rgb(0,0,0,0.1);
    
    @media(max-width:800px){
        flex-direction:column;
        height:80vh;
        width:90vw;
        margin-top:5px;
    }
`;

export const Infos = styled.div`
    display:flex;
    flex-direction:column;
    height:100%;
    width:50%;

    box-sizing:border-box;
    padding:5px 10px;
    border-right:3px solid black;

    @media(max-width:800px){
        overflow:auto;
        width:100%;
        border-right:0;
        border-bottom:3px solid black;
    }
`;

export const InfoLogin = styled.div`
    display:flex;
    flex-direction:column;
    height:100%;
    width:50%;
 
    box-sizing:border-box;
    align-items:center;
    justify-content:center;
    padding:20px 16px;

    @media(max-width: 800px){
        width:100%;
        overflow:auto;
    }
`;

export const ContainerButton = styled.div`
    display:flex;
    height:10vh;
    width:100%;

    margin-top:10px;
    justify-content:center;
    padding-top:20px;
`;

export const ContainerButtonOne = styled.div`
    display:flex;
    height:5vh;
    width:100%;
   
   justify-content:flex-end;
   align-items:flex-end;
`;

export const Span = styled.span`
    font-size:12px;
    margin-right:auto;
    margin-left:120px;
    color:var(--Blue);

    @media(max-width:800px){
        margin-right:auto;
        margin-left:10px;
        margin-bottom:20px;
    }
`;

export const H1 = styled.h1`
    font-size:57px;
    font-weight:500;
    
    text-align:center;
    color:var(--Blue);

    letter-spacing:8px;
    text-decoration:underline;

    @media(max-width:800px){
        margin-top:5px;
    }
`;

export const Custom = styled.div`
    display:flex;

    padding-left:40px;
    box-sizing:border-box;
`;

export const Button = styled.button`
    height:3vh;
    margin:0;
    padding-top:5px;
    border:0;
    box-sizing:border-box;
    background:var(--White);

    @media(max-width:800px){
        margin-top:35px;
    }

`;