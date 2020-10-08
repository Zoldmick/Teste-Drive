import styled from 'styled-components'

export const PageDefault = styled.div`
    display:flex;
    flex-direction:column;
`;

export const ContainerMenu = styled.div`
    display:flex;
    height:10vh;

    justify-content:space-between;
`;

export const InfosWrapper = styled.div`
    display:flex;
    flex-direction:column;
    height:50vh;

    box-sizing:border-box;
    padding-top:55px;
    padding-left:180px;
    padding-right:180px;
    margin-bottom:10px;

    @media(max-width: 880px){
        padding-left:20px;
        padding-right:20px;
        overflow:auto;

    }
`;

export const Span = styled.div`
    color:black;
`;


//Css Notficição

export const Button = styled.button`
    height:3vh;
    margin:0;
    padding-top:5px;
    border:0;
    box-sizing:border-box;
    background:var(--White);
`; 


export const NotiWrapper = styled.div`
  display: none;
  height:90vh;
  width: 30vw;
  
  border:1px solid black;
  border-radius:8px;
  box-sizing:border-box;
  padding:16px;

  position: absolute;
  z-index: 1;
  background-color: #f1f1f1;
  
  box-shadow: 0px 8px 16px 0px rgba(0,0,0,0.2);
  overflow:auto;

  top:-4em;
  left:-25em;
`;

export const Notifica = styled.div`
  position: relative;
  display: inline-block;

  &:hover ${NotiWrapper}{
      display:block;
    }
`;


export const Custom = styled.div`
    display:flex;
    
    justify-content:space-evenly;

`;

export const Select = styled.select`
    height:35px;
    width:20vw;
    background:whitesmoke;

    box-sizing:border-box;
    padding-left:auto;
    padding-right:auto;
    margin-left:10px;
    
    border-top-right-radius:16px;
    border-bottom-left-radius:13px;
    border-bottom:5px solid blue;

    text-align:center;
`;

export const Option = styled.option`
    padding-left:10px;
    background:var(--Blue);
    color:var(--White);

    font-size:16px;
    font-weight:200;
    font-display:oblique;
`;