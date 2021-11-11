import React from "react";
import "./App.css";
import NewComp from "./Subscribe.js";
class App extends React.Component {

    styles = { 
       fontStyle: "italic",
       color: "orange"
    };
    render() {
      return (
        <div className="App">
          <h1 style={this.styles}>Welcome</h1>
          <NewComp />
        </div>
      );
    }
}
export default App;