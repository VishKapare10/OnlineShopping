import React from "react";

class Enquiry extends React.Component{

        constructor(props){
            super(props);
            this.state={
                name:"",
                contactno:"",
                location:"",
                email:""
            }        
        }
        render(){
            return <div className="jumbotron text-center">
                    <form>
                    <h2>Enquiry</h2>
                    <hr/>
                    <label>Name</label><br/><input type="text" onChange={
                                        (event)=>{
                                            this.setState({name:event.target.value})
                                        }      
                        }
                    value={this.state.name}/><br/>
                    <label>Contact Number</label><br/><input type="tel" onChange={
                                        (event)=>{
                                            this.setState({contactno:event.target.value})
                                        }      
                        }
                    value={this.state.contactno}/><br/>
                     <label>Location</label><br/><input type="text" onChange={
                                        (event)=>{
                                            this.setState({location:event.target.value})
                                        }      
                        }
                    value={this.state.location}/><br/>
                     <label>Email</label><br/><input type="email" onChange={
                                        (event)=>{
                                            this.setState({email:event.target.value})
                                        }      
                        }
                    value={this.state.email}/><br/>
                    <button type="submit" onClick={()=>{
                                      console.log("Your response has been submitted");
                        }} class="btn btn-success">Submit</button>
                    </form>
                   </div>
        }
}

export default  Enquiry;