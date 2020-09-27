import styled from 'styled-components'

export const PageDefault = styled.div``;

export const Form = styled.form`
    display:flex;
    flex-direction:column;
    width:60vw;

    margin-left:auto;
    margin-right:auto;
    margin-bottom:15px;
    box-sizing:border-box;
    padding-left:16px;
    padding-right:16px;
    border:2px solid gray;

    @media(max-width:800px){
        width:90vw;
    }
`;

export const FormWrapper = styled.div`
    border:1px solid gray;
    padding:16px;
    box-sizing:border-box;

    margin-top:14px;
    margin-bottom:14px;
`;

export const Custom = styled.div`
    display:flex;

    justify-content:space-between;
    margin-top:10px;

    @media(max-width:800px){
        flex-direction:column;
    }
`;

export const ContButton = styled.div`
    display:flex;
    width:60vw;

    justify-content:space-around;
    box-sizing:border-box;
    margin-top:10px;
    margin-bottom:10px;

    @media(max-width:800px){
        flex-direction:column;
        
    }
`;

export const H1 = styled.h1`
    text-align:center;
    text-decoration:underline;

    font-size:67px;
    font-weight:400;
    font-display:oblique;

    color:var(--Blue);
    margin-bottom:15px;

    @media(max-width:800px){
        font-size:47px;
        font-weight:300;
    }
`;