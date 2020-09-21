import React from 'react'
import styled from 'styled-components'

const Formfield = styled.div`
  align-content:justify;

  Input[type='text'] {
    margin-bottom:15px;
  }

  Input[type='number'] {
    width:20vw;
  }
`;

const Label = styled.div`
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
  
`;

function FormField({
    label, type, name, 
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