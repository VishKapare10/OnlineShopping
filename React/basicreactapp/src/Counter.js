import React  from "react";
class Counter extends React.Component{
    constructor(props){
        super(props);
        //now define state for component
        this.state={count:props.count}
    }
    render(){
        return <div>
                <hr/>
                    <button>-</button>
                    <input type="text" value={this.state.count}/>
                    <button>+</button>
               <hr/>
               </div>
        
    }
}

export default Counter;