import React from "react";
import Button from '@material-ui/core/Button';
import Paper from "@material-ui/core/Paper"
import Typography from "@material-ui/core/Typography"

export class EvolutionPage extends React.Component {
  render() {
    return (
      <div className="content-papers">
        <Paper className={"content"}>
          <Typography variant = "h3" color="inherit" component="h3">
            Evoluția proiectului
          </Typography>
        </Paper>

        <Paper className={"content"}>
          <Typography variant = "h4" color="inherit" component="h4">
            Săptămâna a 7-a
          </Typography>

          <Typography component="p" align="justify">
            Am conceput arhitectura proiectului și am stabilit tehnologiile folosite - Unity și Python. Am împărțit aplicațiile în submodule, am stabilit flow-urile de lucru și am făcut repository-urile Github ale proiectului. Am stabilit repartiția membrilor grupei în echipe. 
          </Typography> 
        </Paper>

        <Paper className={"content"}>
          <Typography variant = "h4" color="inherit" component="h4">
            Săptămâna a 8-a
          </Typography>
        
          <Typography component="p" align="justify">
            Am început să ne organizăm mai mult la nivel de grupe. Am ales lideri, am distribuit oameni la submodule și ne-am făcut table Kanban pe Meistertask pentru gestionarea task-urilor. Am definitivat comunicarea dintre front și back, structura json a fișierelor care descriu modelul 3D și sculptura Lego, precum și modul de funcționare al aplicațiilor.
          </Typography> 
        </Paper>

        <Paper className={"content"}>
          <Typography variant = "h4" color="inherit" component="h4">
            Săptămâna a 9-a
          </Typography>
        
          <Typography component="p" align="justify">
          Ne-am apucat propriu-zis de implementarea funcționalităților de bază. Pe front s-au definitivat cu succes construcția și ștergerea cuburilor, gestionarea camerei și interfața. S-au făcut progrese în validarea construcției și în prezentarea, dar care nu au fost încă integrate. Gestionarea IO și modelarea pieselor de Lego au fost reprogramate pentru săpămâna următoare, pe lângă alte îmbunătățiri generale. 
Echipa de la back-end a reușit de implementat o primă iterație a tuturor modulelor, urmând o perioadă de integrare și de testare. 
Cei de la testare au realizat mai multe fișiere json cu scopul de a fi folosite ca date de test de către cei de la back-end, urmând ca de acum să realizeze și câteva sculpturi lego pentru testarea funcționalităților de pe front.
La nivel de administrare, au fost purtate discuții cu echipele tehnice pentru a definitiva structurile de date folosite la nivel de back-end, precum și anumiți algoritmi de identificare a pieselor și a rotațiilor lor. În plus, a început implementarea acestui site.
          </Typography> 
        </Paper>
      </div>
    );
  }
}
