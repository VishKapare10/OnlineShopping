import React from 'react';
import ReactDOM from 'react-dom';
import './index.css';
import App from './App';

import reportWebVitals from './reportWebVitals';

//JSX: extension for javascript
ReactDOM.render(
  <React.StrictMode>
    <h2>This is Main Content</h2>
    <hr/>
    <App /> 
  </React.StrictMode>,
  document.getElementById('root')
);
reportWebVitals();
