import logo from './logo.svg';
import './App.css';

import Home from './home';
import List from './ProductCatalog/List';
import Dashboard from './ProductCatalog/Dashboard';
//import Flower from './ProductCatalog/flower';
import Aboutus from './CRM/aboutus';
import Contactus  from './CRM/contactus';
import Login  from './Membership/Login';


function App() {
  return (
    <div className="App">
       <ol>
        <li>Welcome to Application Component</li>
        <li>This is Component based Approch for defining UI</li>
      </ol>
      <hr/>
      <Login></Login>
      {/* <Home></Home>
      <hr/>
      <Dashboard></Dashboard>
      <hr/>
      <h3>Todays fresh flower</h3>
      <List></List>
      <hr/>
      <Aboutus></Aboutus>
      <hr/>
      <Contactus></Contactus> */}
    </div>
  );
}

export default App;

