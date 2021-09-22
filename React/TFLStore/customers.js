let customers=[{"id":12,"firstname":"Rajiv","lastname":"Patil","city":"delhi","age":24,"email":"rajiv.patil@gmail.com","contactnumber":"9899887651"},
               {"id":15,"firstname":"Rahul","lastname":"Kale","city":"delhi","age":29,"email":"rahul.kale@gmail.com","contactnumber":"9900876543"},
               {"id":20,"firstname":"Abhay","lastname":"Kapare","city":"delhi","age":45,"email":"abhay10kapare@gmail.com","contactnumber":"7799887651"},
               {"id":21,"firstname":"Akash","lastname":"Aurade","city":"pune","age":55,"email":"a.aurade@gmail.com","contactnumber":"7899887651"},
               {"id":22,"firstname":"Pratik","lastname":"Takawale","city":"mumbai","age":28,"email":"ptakawale@gmail.com","contactnumber":"9099887651"},
               {"id":25,"firstname":"Kiran","lastname":"Muluk","city":"pune","age":65,"email":"kirn.m@gmail.com","contactnumber":"7299887651"}];

//Javascript Query
//Data Analytics

//Age greater than 25
customers.filter(customer => customer.age>25)
.sort((c1,c2)=>c1.age-c2.age)
.map(customer => console.log(customer.firstname+" : "+customer.age));

//Age less than 25
customers.filter(customer => customer.age<25)
.sort((c1,c2)=>c1.age-c2.age)
.map(customer => console.log(customer.firstname+" : "+customer.age));

//Get all customers
customers.forEach(customer=>console.log(customer));

//City = delhi
customers.filter(customer => customer.city=="delhi")
.map(customer => console.log(customer.firstname+" : "+customer.age));

//Insert elements using splice method
customers.splice(2,0,{"id":30,"firstname":"Swapnil","lastname":"Modi","city":"newasa","age":45,"email":"smodi.m@gmail.com","contactnumber":"9299887651"});
//console.log(customers);

//Remove
/*customers.length=2;
console.log(customers);

//Remove
customers.splice(4,0);
console.log(customers);
*/

//Remove specific customer
//let customer=customers.find(x=> x.id=12);
let upCustomers=customers.filter(x=>x.id!=12);
console.log(upCustomers);


//Update
customers.forEach(customer=>{
        if(customer.firstname=="Abhay"){
                customer.contactnumber=7720037983;
        }
});
console.log(customers);