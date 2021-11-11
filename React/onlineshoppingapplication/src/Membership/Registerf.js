import React from 'react';

class Registerf extends React.Component{

constructor()
{
    super();
}

render(){
    return <div className="container"> 
                <div className="row">
                            <div className="col-sm-4">
                            </div>
                            <div className="col-sm-4">
                            <form>
                                <h2>Sign Up</h2>
                                <hr/>
                                <div className="form-group">
                                    <label htmlFor="username">Username</label>
                                    <input type="text" className="form-control" id="username"/>
                                </div>
                                <div className="form-group">
                                    <label htmlFor="password">Password</label>
                                    <input type="password" className="form-control" id="password"/>
                                </div>
                                <div className="form-group">
                                    <label htmlFor="firstname">First Name</label>
                                    <input type="text" className="form-control" id="firstname"/>
                                </div>
                                <div className="form-group">
                                    <label htmlFor="lastname">Last Name</label>
                                    <input type="text" className="form-control" id="lastname"/>
                                </div>
                                <div className="form-group">
                                    <label htmlFor="email">Email</label>
                                    <input type="email" className="form-control" id="email"/>
                                </div>
                                <div className="form-group">
                                    <label htmlFor="contact">Contact Number</label>
                                    <input type="tel" className="form-control" id="contact"/>
                                </div>
                                <button type="submit" onClick={()=>{
                                        console.log("Registration completed successfully.")
                                }} class="btn btn-success">Submit</button>
                            </form>      
                            </div>
                        </div>
                </div>
    }
}
export default Registerf;