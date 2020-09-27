import styled from 'styled-components';


export const PageDefault = styled.div`
    display:flex;
    flex-direction:column;
`;

export const Header = styled.header`
    height:15vh;
    width:70vw;

    border-bottom:2px solid var(--Blue);
    padding:16px;
    margin-bottom:20px;
    margin-left:auto;
    margin-right:auto;

    @media(max-width:800px){
        height:20vh;
    }
`;


export const H1 = styled.h1`
    text-align:center;
    text-decoration:underline;
    letter-spacing:3px;

    font-size:47px;
    font-weight:300;
    color: var(--Blue);

    @media(max-width:800px){
        font-size:30px;
    }
`;

export const InfoWrapper = styled.div`
    display:flex;
    flex-direction:column;
    width:75vw;
    height:45vh;
    
    padding:18px;
    box-sizing:border-box;
    margin-left:auto;
    margin-right:auto;
    margin-bottom:15px;
    border:2px solid rgb(000,000,000,0.2);

    justify-content:space-around;

    @media(max-width:800px){
        height:120vh;
        width:90vw;
    }
    
`;

export const Custom = styled.div`
    display:flex;
    
    justify-content:space-between;

    @media(max-width:800px){
        flex-direction:column;
    }
`;

export const FeedWrapper = styled.div`
    display:flex;
    flex-direction:column;
    width:75vw;
    height:60vh;
    
    padding:18px;
    box-sizing:border-box;
    margin-left:auto;
    margin-right:auto;
    margin-bottom:20px;
    border:2px solid rgb(000,000,000,0.2);

    justify-content:space-around;
    overflow:auto;

    @media(max-width:800px){
        width:90vw;
        height:80vh;
    }   
`;

export const H3 = styled.h3`
    text-align:center;
    text-decoration:underline;
    text-decoration-color:var(--Blue);

    @media(max-width:800px){
        font-size:47px;
    }
`;

export const ContButton = styled.div`
    display:flex;
    width:60vw;

    justify-content:space-around;

    @media(max-width:800px){
        width:80vw;
        height:40vh;
        margin-top:20px;
        flex-direction:column;
    }
`;

export const CometiWrapper = styled.div`
    height:400px;
    width:400px;
`;
