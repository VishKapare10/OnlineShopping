import logo from './logo.svg';
import './App.css';

import Home from './home';
import List from './List';
import Dashboard from './Dashboard';
import Flower from './flower';
import Aboutus from './aboutus';
import Contactus  from './contactus';


function App() {
  return (
    <div className="App">
       <ol>
        <li>Welcome to Application Component</li>
        <li>This is Component based Approch for defining UI</li>
      </ol>
      <hr/>
      <Home></Home>
      <hr/>
      <Dashboard></Dashboard>
      <hr/>
      <h3>Todays fresh flower</h3>
      <List></List>
      <hr/>
      <Aboutus></Aboutus>
      <hr/>
      <Contactus></Contactus>
    </div>
  );
}

export default App;

