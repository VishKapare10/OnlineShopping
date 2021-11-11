
import React from 'react';
import Product from './Product';
import data from '../data/products.json';
 
 class  RestList extends React.Component{
    constructor(props){
        super(props);
        this.state={ products:[] };
    }
 
    // Component Life Cycle
    //Initialization  event
     componentDidMount(){

        //Invoke you data from rest api
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
                    console.log(data);
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
                                        <Product id={item.Id} 
                                                title={item.Title}
                                                description={item.Description}
                                                imageurl={item.imageurl}
                                                unitprice={item.UnitPrice}
                                                quantity={item.Quantity}
                                                likes={item.likes} /> 
                                    </li>
                                ))  
                        }
                    </ul>                       
                </div>
    }
 }
 export default RestList;