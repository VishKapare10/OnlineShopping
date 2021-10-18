
import React from 'react';
import Counter from './Counter';

class Product  extends React.Component{

 render(){
    return <div>
                <p>Title: {this.props.title}</p>
                <img src= {this.props.imageurl} width="100" height="100"/>
                <p>Description:{this.props.description}</p>
                <p>Unit Price:{this.props.unitprice}</p>
                <p>Quantity:{this.props.quantity}</p>
                <p>Likes:{this.props.likes}</p>
                <br/>
                <button>Add to Cart</button>
                <Counter count={this.props.likes}></Counter>
            </div>
 }
}


export default Product;
