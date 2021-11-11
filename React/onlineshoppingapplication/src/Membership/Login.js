import React from "react";

class Login extends React.Component{

        constructor(props){
            super(props);
            this.state={
                username:"",
                password:""
            }        
        }
        render(){
            return  <div className="jumbotron text-center">
                        <h2>Login</h2>
                        <hr/>
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
                               if(this.state.username=="vishk" & this.state.password=="alpha@9999"){
                                   console.log("Valid User")
                               }
                               else{
                                console.log("Invalid User");
                               }
                            }
                } class="btn btn-success">Login</button>
                </div>
        }
}

export default Login;