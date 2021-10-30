
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
 onSaveData(){
    console.log("Button clicked to save data");
    var cartItem={
            title: this.props.title,
            unitPrice: this.props.unitprice,
            quantity: this.props.quantity   
    };
    console.log(cartItem);
    sessionStorage.setItem("cartItem",JSON.stringify(cartItem));
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
                <button onClick={this.onSaveData()} class="btn btn-success">Add to Cart</button>
                <Counter count={this.props.likes} handler={this.handler}></Counter>
            </div>
 }
}


export default Product;
