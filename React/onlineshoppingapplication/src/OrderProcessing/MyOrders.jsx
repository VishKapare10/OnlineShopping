import React from 'react';
import Orders from './Orders';
 
 class  RestList extends React.Component{
    constructor(props){
        super(props);
        this.state={ orders:[] };
    }
 
     componentDidMount(){
        const url='http://localhost:4000/api/orders';
        fetch(url)
            .then(
                async response=>{
                    const data= await response.json();
                    if(!response.ok)
                    {
                        const error=(data && data.messge) ||response.statusText
                        return Promise.reject(error);
                    }
                    this.setState({orders:data})
                    console.log(data);
                })
            .catch(error=>{
                console.log(`Error occured: ${error}`);
            })
     }

    render(){

       return <div>  
                    <h2>Orders</h2>
                    <hr/> 
                    <ul>
                        {
                            this.state.orders.map(item=>(
                                    <li>
                                        <Orders id={item.id} 
                                                CustomerId={item.customerId}
                                                TotalAmount={item.totalAmount}
                                                Status={item.status}
                                                OrderDate={item.orderDate}
                                                /> 
                                    </li>
                                ))  
                        }
                    </ul>                       
                </div>
    }
 }
 export default RestList;