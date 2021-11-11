
import React from 'react';
import Counter from './Counter';

class Product  extends React.Component{

constructor(props){
    super(props);
    this.state={likes:props.likes};
    this.handler=this.handler.bind(this); //bind handler
}
 handler(data){
     console.log(data);
     this.setState({likes:data});
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
                <button onClick={()=>{
                    var cartItem={
                        title: this.props.title,
                        unitprice: this.props.unitprice,
                        quantity: this.props.quantity
                    };
                    sessionStorage.setItem("cartItem",JSON.stringify(cartItem));
                }} class="btn btn-success">Add to Cart</button>
                <Counter count={this.props.likes} handler={this.handler}></Counter>
            </div>
 }
}


export default Product;
