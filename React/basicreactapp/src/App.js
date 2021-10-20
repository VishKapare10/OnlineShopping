import { BrowserRouter as Router, Link, Switch, Route} from 'react-router-dom';
import logo from './logo.svg';
import './App.css';

//import Home from './home';
import List from './ProductCatalog/List';
import Dashboard from './ProductCatalog/Dashboard';
//import Flower from './ProductCatalog/flower';
//import Aboutus from './CRM/aboutus';
//import Contactus  from './CRM/contactus';
import Login  from './Membership/Login';
//import Register from './Membership/Register';
import Registerf from './Membership/Registerf';

function App() {
  return (
    <div className="App">
    <BasicRouting></BasicRouting>
    </div>
  );
}

export default App;

function BasicRouting(){
    return(
          <div>
              <h1>Transflower Store</h1>
              <Router>
                <Link to="/">Home</Link> | <Link to="/about">About us</Link> | <Link to="/contact">Contact us</Link> | <Link to="/flowers">Flowers</Link> | <Link to="/Login">Login</Link> | <Link to="/register">Register</Link>
                <hr/>
                <Switch>
                  <Route exact path="/"><Home/></Route>
                  <Route exact path="/about"><About/></Route>
                  <Route exact path="/contact"><Contact/></Route>
                  <Route exact path="/flowers"><List/></Route>
                  <Route exact path="/login"><Login /></Route>
                  <Route exact path="/register"><Registerf /></Route>
                </Switch>
              </Router>
          </div>
    );
}

function Home(){
  return(
      <div>
           <div className="jumbotron text-center">
              <h2>Transflower Learning Pvt.Ltd.</h2>
              <p>Mentor as a Service</p>
              <p>React JS Learning is a fun</p>
           </div>
           <div className="container">
              <div className="row">
                  <div className="col-sm-4">
                    <h2>Flowers</h2>
                    <p>Celebrate every moment with flowers</p>
                  </div>
                  <div className="col-sm-4">
                    <h2>Fruits</h2>
                    <p>Enjoy healthy life using fresh fruits</p>
                  </div>
                  <div className="col-sm-4">
                    <h2>Vegetables</h2>
                    <p>Increase immunity with our fresh vegetables</p>
                  </div>
              </div>
           </div>
      </div>

  )
}

function About(){
  return(
    <div>
        <h2>About Us:</h2>
        <h2>Transflower Learning Pvt.Ltd.</h2>
        <p>Online Learning Center</p>
        <p>601,Rama Apartment, Walvekar Nagar,Pune</p>
        <p>Doing ordinary things extraordinarily</p>
    </div>
);
}


function Contact(){
  return(
    <div> 
        <h2>Contact Us:</h2>
        <p>Address:</p>
        <p>Transflower Learning Pvt. Ltd.</p>
        <p>Walvekar nagar, Pune Satara Road, Pune</p>
        <p>Email: ravi.tambdade@transflower.in</p>
        <p>Contact Number: +91-9980771213</p>
    </div>
);

}