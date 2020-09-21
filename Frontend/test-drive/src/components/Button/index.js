import React from 'react'
import styled from 'styled-components'

const Button = styled.button`
    height:35px;
    width:97px;

    border-radius:8px;
    background:var(--Blue);

    font-size:16px;
    font-weight:200;
    font-style:oblique;    
    color: var(--White);

    &:hover{
        background:var(--White);
        color:red;
    }
`; 

const ButtonG = styled.button`
    height:37px;
    width:217px;

    border-radius:8px;
    background:var(--Blue);

    font-size:16px;
    font-weight:200;
    font-style:oblique;    
    color: var(--White);

    &:hover{
        background:var(--White);
        color:red;
    }
`; 

export function ButtonMedio ({ children, onClick }){

    return(
        <Button onclick = {onClick} >
            {children}
        </Button>
    );
}

export function ButtonGrande ({ children, onClick }){

    return(
        <ButtonG onclick = {onClick} >
            {children}
        </ButtonG>
    );
}
