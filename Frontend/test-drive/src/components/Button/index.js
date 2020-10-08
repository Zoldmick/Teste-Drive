import React from 'react'
import styled from 'styled-components'

export const Button = styled.button`
    height:35px;
    width:97px;

    border-radius:8px;
    background:var(--Blue);

    text-align:center;
    font-size:16px;
    font-weight:200;
    font-style:oblique;    
    color: var(--White);

    &:hover{
        background:var(--White);
        color:red;
        border:1px solid  black;
    }
`; 

const ButtonG = styled.button`
    height:37px;
    width:217px;

    border-radius:8px;
    background:var(--Blue);

    text-align:center;
    font-size:16px;
    font-weight:200;
    font-style:oblique;    
    color: var(--White);

    &:hover{
        background:var(--White);
        color:red;
        border:1px solid  black;
    }
`; 

export function ButtonMedio ({ children, onClick, to, as }){

    return(
        <Button as ={as} to = {to}  onClick = {onClick} >
            {children}
        </Button>
    );
}

export function ButtonGrande ({ children, onClick, to, as }){

    return(
        <ButtonG as={as} to ={to} onclick = {onClick} >
            {children}
        </ButtonG>
    );
}
