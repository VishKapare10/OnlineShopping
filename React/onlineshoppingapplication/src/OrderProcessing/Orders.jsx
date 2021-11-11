import React from 'react';
class Orders  extends React.Component{
constructor(props){
    super(props);
}
render(){
    return <div className="jumbotron text-center">
                <p>Id: {this.props.id}</p>
                <p>CustomerId: {this.props.CustomerId}</p>
                <p>TotalAmount:{this.props.TotalAmount}</p>
                <p>Status:{this.props.Status}</p>
                <p>Order Date:{this.props.OrderDate}</p>
                <br/>
            </div>
 }
}

export default Orders;
