import React from 'react';
class Register extends React.Component{

constructor()
{
    super();
    this.state={
                    username:"vishk",
                    password:"****",
                    firstname:"Vishwambhar",
                    lastname:"Kapare",
                    email:"vish10kapare@gmail.com",
                    contact:"7720037983"
                };
}

render(){
    return <div>
                <div className="form-group">
                <label htmlFor="username">Login Name:</label>
                <input type="text" name="username" value={this.state.username} 
                    onChange={
                        (event)=>{
                                this.setState({username:event.target.value});
                        }          
                    } />
                </div>

              <div className="form-group">
                <label htmlFor="pwd">Password:</label>
                <input type="text" name="pwd" value={this.state.password}
                    onChange={
                        (event)=>{
                                this.setState({password:event.target.value});
                        }          
                    } />
              </div>

              <div className="form-group">
              <label htmlFor="email">Email address:</label>    
              <input type="text" name="email" value={this.state.email}
                    onChange={
                        (event)=>{
                                this.setState({email:event.target.value});
                        }          
                    }/>
                </div>

              <div className="form-group">

                <label htmlFor="firstname">First Name:</label>           
                <input type="text" name="firstname" value={this.state.firstname}
                    onChange={
                        (event)=>{
                                this.setState({firstname:event.target.value});
                        }          
                    } />
              </div>
             
              <div className="form-group">
                <label htmlFor="lastname">Email address:</label>    
                <input type="text" name="lastname" value={this.state.lastname}
                    onChange={
                        (event)=>{
                                this.setState({lastname:event.target.value});
                        }          
                    } />
             </div>

             <div className="form-group">
                <label htmlFor="contact">Contact Number:</label>    
                <input type="text" name="contact" value={this.state.contact}
                        onChange={
                            (event)=>{
                                    this.setState({contact:event.target.value});
                            }          
                        } />
            
             </div>
 
            <button className="btn btn-default" onClick={ 
                        ()=>{
                                console.log(this.state); 
                            }
                        }>Register</button>
    </div>
}
}
export default Register;