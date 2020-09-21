import styled from 'styled-components'

export const PageDefault = styled.div`
    display:flex;
    height:25vh;
    width:100vw;

    background:var(--Black);
    box-sizing:border-box;

`;

export const InfoWrapper = styled.div`
    display:flex;
    flex-direction:row;
    height:25vh;
    width:100%;

    align-items:center;
    box-sizing:border-box;
    justify-content:space-evenly;
`;

export const Infos = styled.div`
    display:flex;
    flex-direction:column;
    height:15vh;
    width:40vh;

    text-align:center;
    padding:12px;
    padding-top:5px;
`;

export const Span = styled.span`
    font-size:18px;
    font-weight:200;
    font-style:oblique;  
    color:white;

    &:hover{
        color:red;
        transform:translate3d(2,1,4.2)
    }
`;