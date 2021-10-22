
import React from 'react';
import Product from './Product';
import data from '../data/products.json';
 
 class  RestList extends React.Component{
    constructor(props){
        super(props);
        this.state={ products:[] };


    }
    // after construction and before rendersing
    // we have to fetch data from rest api
    // and populate into the state of component
    // Component Life Cycle
    //Initialization  event
     componentDidMount(){

        //Polymorphsim
        // attach polymorphic behaviour by overriding parent behaviour
        //Late  Binding
        //changing the behaviour of object from base class behaviour
        //overriding
        //invoke you data from rest api
        const url='http://localhost:8000/api/flowers'
        fetch(url)
            .then(
                async response=>{
                    const data= await response.json();
                    if(!response.ok)
                    {
                        const error=(data && data.messge) ||response.statusText
                        return Promise.reject(error);
                    }
                    this.setState({products:data})
                })
            .catch(error=>{
                console.log(`Error occured: ${error}`);
            })
     }

    render(){

       return <div>  
                    <h3>Todays fresh flowers from Tambade mala.</h3>   
                    <ul>
                        {
                            this.state.products.map(item=>(
                                    <li>
                                        <Product title={item.title}
                                                description={item.description}
                                                imageurl={item.imageurl}
                                                unitprice={item.unitprice}
                                                quantity={item.quantity}
                                                likes={item.likes} /> 
                                    </li>
                                ))  
                        }
                    </ul>                       
                </div>
    }
 }
 export default RestList;