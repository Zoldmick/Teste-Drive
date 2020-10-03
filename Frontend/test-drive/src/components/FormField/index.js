import React from 'react'
import styled from 'styled-components'
import InputMask from 'react-input-mask';

const Formfield = styled.div`
  position:relative;

  Input[type='text'] {
    margin-bottom:15px;
  }

  Input[type='number'] {
    width:20vw;
  }

  Input[type='checkbox'] {
    display:flex;
    flex-direction:row-reverse
  }

  @media(max-width: 800px){
    display:flex;
    flex-direction:column;
  }
`;

const Label = styled.label`
  font-size:20px;
  font-weight:900;

  margin-right:10px;
`;

const Input = styled.input` 
  height:35px;
  width:25vw;

  font-size:16px;
  font-style:oblique;
  font-weight:400;
  color:black;
  
  padding-left:10px;
  padding-right:10px;
  border-top-right-radius:16px;
  border-bottom-left-radius:13px;
  border-bottom:5px solid blue;

  &[type='checkbox'] + Label {
    height:3vh;
    width:10vw;
    margin:0;

    color:red;
  }

  @media(max-width: 800px){
    width:70vw;
  }
  
`;

export function FormField({label, type, name, value, onChange}) {
  const fieldId = `id_${name}`;
  const isType = type === 'textarea';
  const tag = isType      ? 'textarea' 
                          : 'input'

  return (

    <Formfield>

      <Label  htmlFor={fieldId}>
        {label}
      </Label>

      <Input
        as = {tag}
        id={fieldId}
        type={type}  
        name={name} 
        value = {value}
        onChange = {onChange}
        
      />  

    </Formfield>
  );  
}

export function FormFieldMask({label, type, name, value, onChange, mask}){
  const fieldId = `id_${name}`;

  return(
    <Formfield>

      <Label  htmlFor={fieldId}>
        {label}
      </Label>

      <Input
        id={fieldId}
        type={type}  
        name={name} 
        value = {value}
        onChange = {onChange}
        mask = {mask}
      />  

    </Formfield>
  );

}