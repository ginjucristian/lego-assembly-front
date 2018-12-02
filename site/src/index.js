import React from 'react';
import { render } from 'react-dom';

import { BrowserRouter } from 'react-router-dom'
import { App }  from './app/components/App.js'

import "./media/styles.css"

render((
    <BrowserRouter>
            <App />
    </BrowserRouter>
), window.document.getElementById('root'));
