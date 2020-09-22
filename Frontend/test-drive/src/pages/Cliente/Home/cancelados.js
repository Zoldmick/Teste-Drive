import React from 'react'
import Table from 'react-bootstrap/Table'
import { FaInfo } from 'react-icons/fa'

function TbCancelados(){
    return(
        <Table striped bordered hover>
            <thead>
                <tr>
                <th>#</th>
                <th>Modelo</th>
                <th>Data/Hora</th>
                <th>Funcionario</th>
                <th>Status</th>
                <th>Feedback</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                <td> <FaInfo /> </td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                </tr>
                <tr>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                </tr>
                <tr>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                </tr>
            </tbody>
        </Table>
    );
}

export default TbCancelados;