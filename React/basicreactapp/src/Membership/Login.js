import React from "react";

class Login extends React.Component{

        constructor(props){
            super(props);
            this.state={
                username:"vishk",
                password:"emp1"
            }        
        }
        render(){
            return <div>
                        <h2>Login</h2>
                        <label>Username</label><input type="text" onChange={
                                        (event)=>{
                                            this.setState({username:event.target.value})
                                        }      
                        }
                        value={this.state.username}/><br/>
                        <label>Password</label><input type="password" onChange={
                                        (event)=>{
                                            this.setState({password:event.target.value})
                                        }      
                        }
                        value={this.state.password}/><br/>
                        <button onClick={()=>{
                            //Check the credentials of user
                            //Check username and password
                            if(this.state.username="vishk" && this.state.password=="emp1"){
                                console.log("valid user");
                            }
                            else{
                                console.log("Invalid user");
                            }

                        }}>Login</button>
                </div>
        }
}

export default Login;