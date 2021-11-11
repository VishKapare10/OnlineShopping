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
import RestList from './ProductCatalog/RestList';
import Enquiry from './Membership/Enquiry';
import MyOrders from './OrderProcessing/MyOrders';
import Cart from './Cart/Cart';

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
                <Link to="/">Home</Link> | <Link to="/about">About us</Link> | <Link to="/contact">Contact us</Link> | <Link to="/flowers">Flowers</Link> | <Link to="/Login">Login</Link> | <Link to="/register">Register</Link> | <Link to="/enquiry">Enquiry</Link> | <Link to="/orders">Orders</Link> | <Link to="/cart">Cart</Link>  
                <hr/>
                <Switch>
                  <Route exact path="/"><Home/></Route>
                  <Route exact path="/about"><About/></Route>
                  <Route exact path="/contact"><Contact/></Route>
                  <Route exact path="/flowers"><List/></Route>
                  <Route exact path="/login"><Login /></Route>
                  <Route exact path="/register"><Registerf /></Route>
                  <Route exact path="/enquiry"><Enquiry /></Route>
                  <Route exact path="/orders"><MyOrders /></Route>
                  <Route exact path="/cart"><Cart /></Route>                  
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
              <i>Mentor as a Service</i>
           </div>
           <div className="container">
              <div className="row">
                  <div className="col-sm-4">
                    <h2>Flowers</h2>
                    <i>Celebrate every moment with flowers</i>
                  </div>
                  <div className="col-sm-4">
                    <h2>Fruits</h2>
                    <i>Enjoy healthy life using fresh fruits</i>
                  </div>
                  <div className="col-sm-4">
                    <h2>Vegetables</h2>
                    <i>Increase immunity with our fresh vegetables</i>
                  </div>
              </div>
           </div>
      </div>

  )
}

function About(){
  return(
    <div className="jumbotron text-center">
        <h2>About Us</h2>
        <hr/>
        <h3>Transflower Learning Pvt.Ltd.</h3>
        <i>Online Learning Center</i><br/>
        <i>Doing ordinary things extraordinarily</i>
    </div>
);
}


function Contact(){
  return(
    <div className="jumbotron text-center">
        <h2>Contact Us</h2>
        <hr/>
        <p>Address:</p>
        <p>Transflower Learning Pvt. Ltd.</p>
        <p>Walvekar nagar, Pune Satara Road, Pune</p>
        <p>Email: ravi.tambade@transflower.in</p>
        <p>Contact Number: +91-9980771213</p>
    </div>
);

}