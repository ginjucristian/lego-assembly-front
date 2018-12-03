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

export class TestTable extends React.Component {

    constructor(props) {
        super(props);

        this.state = {
            rows: []
        }
    }

    componentDidMount() {
        const data = [
            this.createData("", "", "Apușcășiței Silviu (lider echipă)"),
            this.createData("", "", "Anton Cătălin"),
            this.createData("", "", "Dima Ionuț"),
            this.createData("", "", "Tincu Gabriel"),
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
