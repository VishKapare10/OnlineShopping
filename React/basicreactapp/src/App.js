import logo from './logo.svg';
import './App.css';

import Home from './home';
import List from './ProductCatalog/List';
import Dashboard from './ProductCatalog/Dashboard';
//import Flower from './ProductCatalog/flower';
import Aboutus from './CRM/aboutus';
import Contactus  from './CRM/contactus';
import Login  from './Membership/Login';
import Company from './Membership/Company';


function App() {
  return (
    <div className="App">
      <Login></Login>
      <hr/>
      <Company></Company>
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

