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

    box-sizing:border-box;
    align-items:center;
    justify-content:center;
    padding:20px;
`;

export const InfosWrapper = styled.div`
    display:flex;
    height:60vh;
    width:70vw;

    box-sizing:border-box;
    align-content:center;
    border:2px solid rgb(0,0,0,0.1);
    
`;

export const Infos = styled.div`
    display:flex;
    flex-direction:column;
    height:100%;
    width:50%;

    box-sizing:border-box;
    padding:5px 10px;
    border-right:3px solid black;
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
    margin-left:40px;
`;