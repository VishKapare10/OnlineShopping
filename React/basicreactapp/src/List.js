
import React from 'react';
import Product from './Product';
import data from './data/products.json';
 

 class  List extends React.Component{
     
    render(){

            const flowers=data;

        return <div>  
                    <h3>Todays fresh flowers....</h3>   
                    <ul>
                        {
                            flowers.map(item=>(
                                    <li>
                                        <Product title={item.title}
                                                        description={item.description}
                                                        imageurl={item.imageurl}
                                                        unitprice={item.unitprice}
                                                        quantity={item.quantity} /> 
                                    </li>
                                ))  
                        }
                    </ul>                       
                </div>
    }
 }
 export default List;