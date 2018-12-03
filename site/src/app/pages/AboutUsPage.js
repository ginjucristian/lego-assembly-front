import React from "react";
import Paper from "@material-ui/core/Paper"
import Typography from "@material-ui/core/Typography"
import { CardContent, CardMedia } from "@material-ui/core";

export class AboutUsPage extends React.Component {
  render() {
    return (
      <div className="content-papers">
        <Paper className={"content"}>
          <Typography variant = "h3" color="inherit" component="h3">
            Despre noi - grupa B1
          </Typography>
        </Paper>

        <Paper className={"content"}>
          <Typography variant = "h4" color="inherit" component="h4">
            Scurtă descriere
          </Typography>

          <Typography component="p" align="justify">
            Programul necesită ca input un model 3D partiționat în multiple straturi, fiecare fiind împărțit într-o grilă dreptunghiulară. Fiecare pătrat din această grilă ori va fi umplut cu un cub Lego, fie lăsat gol, iar anumite pătrate pot fi alipite pentru a crea cărămizi mai complexe.
          </Typography> 
        </Paper>

        <Paper className={"content"}>
          <Typography variant = "h4" color="inherit" component="h4">
            Poză de grup
          </Typography>
        
          <CardContent>
            <CardMedia
              image="../../src/media/grupa_B1.jpg"
              title="grupa B1"
              id={"group-image"}
            />
          </CardContent>
        </Paper>
      </div>
    );
  }
}
