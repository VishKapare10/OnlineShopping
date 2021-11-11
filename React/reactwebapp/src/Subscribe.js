import React, { Component } from "react";
class NewComp extends Component {
  constructor(props) {
        super(props);
        this.state = {
            message: "Subscribe to Transflower"
        };
    }
    styles = {
        fontStyle: "bold",
        color: "teal"    
    };

    Buttonchange = () => { this.setState({
            message: "Thank you for subscribing"
            });
    };

    render() {
        return (
        <div className="App">
        <h3 style={this.styles}>{this.state.message}</h3>
        <button onClick={this.Buttonchange}>Subscribe</button>
        </div>
        );
    }
}
export default NewComp;