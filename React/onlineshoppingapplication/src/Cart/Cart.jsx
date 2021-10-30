import React  from "react";
class Cart extends React.Component{
    constructor(props){
        super(props);
        this.state={ 
            title:"",
            unitprice:"",
            quantity:""
        };
    }
    componentDidMount(){
        var cartItem=JSON.parse(sessionStorage.getItem("cartItem"));
        if (cartItem != null){
            console.log(cartItem.title);
            this.setState({title : cartItem.title});
            this.setState({unitprice : cartItem.unitPrice});
            this.setState({quantity : cartItem.quantity});
        }
        
    }
    onCheckOut(){
        console.log("Proceed to checkout");
    }
    render(){
        return <div className="jumbotron text-center">
                <h3>Your Cart</h3>
                <hr/> 
                <p>Title:  {this.state.title}</p>
                <p>Quantity: {this.state.quantity}</p>
                <p>Unit Price: {this.state.unitprice  }</p>
                <p>Total Amount {this.state.quantity*this.state.unitprice}</p>
                <hr/>
                <button class="btn btn-success" onClick={this.onCheckOut}>Checkout</button>            
               </div>
        
    }
}

export default Cart;