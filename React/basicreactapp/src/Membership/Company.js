import React from "react";

class Company extends React.Component{

        constructor(props){
            super(props);
            this.state={
                name:"",
                contactperson:"",
                location:"",
                website:""
            }        
        }
        render(){
            return <div>
                    <form>
                    <h2>Enquiry</h2>
                    <label>Name</label><input type="text" onChange={
                                        (event)=>{
                                            this.setState({name:event.target.value})
                                        }      
                        }
                    value={this.state.name}/><br/>
                    <label>Contact Person</label><input type="text" onChange={
                                        (event)=>{
                                            this.setState({contactperson:event.target.value})
                                        }      
                        }
                    value={this.state.contactperson}/><br/>
                     <label>Location</label><input type="text" onChange={
                                        (event)=>{
                                            this.setState({location:event.target.value})
                                        }      
                        }
                    value={this.state.location}/><br/>
                     <label>Website</label><input type="text" onChange={
                                        (event)=>{
                                            this.setState({website:event.target.value})
                                        }      
                        }
                    value={this.state.website}/><br/>
                    <button type="submit" onClick={()=>{
                                      console.log("Your response has been submitted.");
                        }}>Submit</button>
                    </form>
                   </div>
        }
}

export default  Company;