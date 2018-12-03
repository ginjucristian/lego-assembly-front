import React from "react";
import BottomNavigation from '@material-ui/core/BottomNavigation';
import BottomNavigationAction from '@material-ui/core/BottomNavigationAction';
import RestoreIcon from '@material-ui/icons/Restore';
import FavoriteIcon from '@material-ui/icons/Favorite';
import LocationOnIcon from '@material-ui/icons/LocationOn';

export class Footer extends React.Component {
  render() {
    return (
        <footer>
            <BottomNavigation
                value={500}
                onChange={this.handleChange}
                showLabels
            >
                <BottomNavigationAction label="Facebook" to="https://github.com/Lucian-Bosinceanu/lego-assembly-back" icon={<RestoreIcon />} />
                <BottomNavigationAction label="Youtube" icon={<FavoriteIcon />} />
                <BottomNavigationAction label="Front repo" icon={<FavoriteIcon />} />
                <BottomNavigationAction label="Back repo" icon={<FavoriteIcon />} />
                <BottomNavigationAction label="Google" icon={<LocationOnIcon />} />
            </BottomNavigation>
      </footer>
    );
  }
}
