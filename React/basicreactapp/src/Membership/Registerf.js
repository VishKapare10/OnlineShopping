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
                                <div className="form-group">
                                    <label htmlFor="email">Email address:</label>
                                    <input type="email" className="form-control" id="email"/>
                                </div>
                                <div className="form-group">
                                    <label htmlFor="contact">Contact Number:</label>
                                    <input type="text" className="form-control" id="contact"/>
                                </div>
                                <button type="submit" class="btn btn-success">Submit</button>
                            </form>      
                            </div>
                        </div>
                </div>
    }
}
export default Registerf;