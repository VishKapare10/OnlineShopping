var express=require('express');
const { fstat } = require('fs');
var app=express(); //Global object
var path=require('path');

//Data Store
var customers=[{"id":12,"firstname":"Rajiv","lastname":"Patil","email":"rajiv.patil@gmail.com","contactnumber":"9899887651"},
               {"id":15,"firstname":"Rahul","lastname":"Kale","email":"rahul.kale@gmail.com","contactnumber":"9900876543"},
               {"id":20,"firstname":"Abhay","lastname":"Kapare","email":"abhay10kapare@gmail.com","contactnumber":"7799887651"},
               {"id":21,"firstname":"Akash","lastname":"Aurade","email":"a.aurade@gmail.com","contactnumber":"7899887651"},
               {"id":22,"firstname":"Pratik","lastname":"Takawale","email":"ptakawale@gmail.com","contactnumber":"9099887651"},
               {"id":25,"firstname":"Kiran","lastname":"Muluk","email":"kirn.m@gmail.com","contactnumber":"7299887651"}];

var flowers=[{"id":1,"name":"Gerbera","description":"Wedding flower","unitprice":12,"quantity":5000},
             {"id":2,"name":"Rose","description":"Valentine flower","unitprice":20,"quantity":10000},
             {"id":3,"name":"Lotus","description":"Worship flower","unitprice":20,"quantity":1500},
             {"id":4,"name":"Carnation","description":"Delicate flower","unitprice":15,"quantity":15000}
            ];

//configuration
app.use(express.static(path.join(__dirname,'public'))); //for setting path for static files
app.use(express.urlencoded({extended:true}));
app.use(express.json());

//API handlers
app.get("/",function(req,res){
            res.sendFile("./index.html")
        }
);

//GET Operations
app.get("/api/flowers",function(req,res){
    res.send(flowers);
});

app.get("/api/flowers/:id",function(req,res){
    let id=req.params.id;
    let f=flowers.find(x=> x.id=id); //arrow function
    res.send(f);
});

app.get("/api/customers",function(req,res){
    res.send(customers);
});

app.get("/api/customers/:id",function(req,res){
        let id=req.params.id;
        let cust=customers.find(x=> x.id=id); //arrow function
        res.send(cust);
});

//CRUD Operation
app.post("/api/flowers",function(req,res){
        var newFlower=JSON.stringify(req.body);
        flowers.push(req.body); //to insert into json array
        console.log(newFlower);
});

app.post("/api/account",function(req,res){
        var user=JSON.stringify(req.body);
        console.log(user);
});

app.post("/api/login",(req,res)=>{
        //server side users credentials are verified.
        var claim=req.body;
        if(claim.username =="ravi" && claim.password =="seed"){
             console.log("valid user");
        }
        else{
             console.log("invalid user");
        }
        console.log(claim);
});

app.post("/api/register",(req,res)=>{
        //server side will add new customer to the customers collection.
        var customer=req.body;
        customers.push(customer);
        console.log(customers);
});

app.put("/api/flowers/:id", function(req,res){
        //Update
        let id=req.params.id;
        flowers=flowers.filter(x=>x.id!=id);
        flowers.push(req.body);
        res.send(req.body);
});

app.delete("/api/flowers/:id", function(req,res){
        let id=req.params.id;
        let f=flowers.find(x=> x.id=id); //arrow function
        flowers=flowers.filter(x=>x.id!=id);
        res.send(f);
});

////////////////////////////////

app.post("/api/customers",function(req,res){
        //Add new json object to collection flowers
        console.log("new object to be appended in the exisiting collection customers");
        var newCustomer=JSON.stringify(req.body);
        customers.push(req.body); //to insert into json array
        res.send('new object is appended to collection');
});

app.put("/api/customers/:id", function(req,res){
        let id=req.params.id;
        customers=customers.filter(x=>x.id!=id);
        customers.push(req.body);
        res.send(req.body);
});

app.delete("/api/customers/:id", function(req,res){
        let id=req.params.id;
        let cust=customers.find(x=> x.id=id); //arrow function
        customers=customers.filter(x=>x.id!=id);
        res.send(cust);
});

app.listen(9898);
console.log("Server is listening on port 9898");