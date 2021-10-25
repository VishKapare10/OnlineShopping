import React from 'react';
class Orders  extends React.Component{
constructor(props){
    super(props);
    this.state={likes:props.likes};
    this.handler=this.handler.bind(this); //bind handler
}
render(){
    return <div>
                <p>Id: {this.props.id}</p>
                <p>Title: {this.props.title}</p>
                <img src= {this.props.imageurl} width="100" height="100"/>
                <p>Description:{this.props.description}</p>
                <p>Unit Price:{this.props.unitprice}</p>
                <p>Quantity:{this.props.quantity}</p>
                <p>Likes:{this.state.likes}</p>
                <br/>
            </div>
 }
}

export default Orders;
