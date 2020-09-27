import React from 'react'
import styled from 'styled-components'
//import InputMask from 'react-input-mask';

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

function FormField({
    label, type, name
  }) {
    const fieldId = `id_${name}`;

    return (
      <Formfield>
        <Label  htmlFor={fieldId}>
          {label}
        </Label>
        <Input
          id={fieldId}
          type={type}  
          name={name} 
    
        />  
      </Formfield>
    );
  }

export default FormField;