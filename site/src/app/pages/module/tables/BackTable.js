import React from "react";
import Paper from "@material-ui/core/Paper"
import Table from "@material-ui/core/Table"
import { TableRow, TableHead, TableBody, TableCell } from "@material-ui/core";
import { withStyles } from '@material-ui/core/styles';

const CustomTableCell = withStyles(theme => ({
    head: {
      backgroundColor: theme.palette.common.black,
      color: theme.palette.common.white,
    },
    body: {
      fontSize: 14,
    },
  }))(TableCell);

export class BackTable extends React.Component {

    constructor(props) {
        super(props);

        this.state = {
            rows: []
        }
    }

    componentDidMount() {
        const data = [
            this.createData("Validarea input-ului", "", "Feciuc Stelian & Bojescu Mihai (lider echipă)"),
            this.createData("Gestionarea Input-Ouput", "", "Băcăoanu Camelia & Amariei Oana (B4)"),
            this.createData("Îmbinarea cuburilor", "", "Cojocaru Dragoș & Tîrpescu Andrei"),
            this.createData("Construcția grafului", "", "Crivoi Andrei"),
            this.createData("Validarea grafului", "", "Cășuneanu Andrei & Timofte Andrei"),
        ]

        this.setState({
            id: this.state.id,
            rows: data
        })
    }

    createData(module, description, members) {
        return {module, description, members}
    }

  render() {
    return (
            <Table>
                <TableHead>
                    <TableRow>
                        <CustomTableCell>Nume</CustomTableCell>
                        <CustomTableCell>Scurtă descriere</CustomTableCell>
                        <CustomTableCell>Membri</CustomTableCell>
                    </TableRow>
                </TableHead>
                <TableBody>
                    {
                        this.state.rows.map( (row, rowId = 0) => {
                            return (
                                <TableRow key={rowId++}>
                                    <TableCell>{row.module}</TableCell>
                                    <TableCell>{row.description}</TableCell>
                                    <TableCell>{row.members}</TableCell>
                                </TableRow>
                            )
                        })
                    }
                </TableBody>
            </Table>
    );
  }
}
