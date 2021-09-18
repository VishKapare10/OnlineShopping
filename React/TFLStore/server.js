var express=require('express');
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
    res.send(flowers[1]);
});

app.get("/api/customers",function(req,res){
    res.send(customers);
});

app.get("/api/customers/:id",function(req,res){
    res.send(flowers[1]);
});

//CRUD Operation
app.post("/api/flowers",function(req,res){
        //Add new json object to collection flowers
        console.log("new object to be appended in the exisiting collection flowers");
        var newFlower=JSON.stringify(req.body);
        flowers.push(req.body); //to insert into json array
        console.log(newFlower);
        res.send('new object is appended to collection');

});

app.put("/api/flowers/:id", function(req,res){
        //Update 
        console.log("existing object of flower to be modified by received object from client");
        res.send('existing object of flower is replaced by new object received from client');
});

app.delete("/api/flowers/:id", function(req,res){
         console.log("existing object of flower to be deleted from the collection");
         res.send('existing object of flower is removed from collection');
});

////////////////////////////////

app.post("/api/customers",function(req,res){
    //Add new json object to collection flowers
    console.log("new object to be appended in the exisiting collection customers");
    var newCustomer=JSON.stringify(req.body);
    customers.push(req.body); //to insert into json array
    console.log(newCustomer);
    res.send('new object is appended to collection');
});

app.put("/api/customers/:id", function(req,res){
    //Update 
    console.log("existing object of customer to be modified by received object from client");
    res.send('existing object of customer is replaced by new object received from client');
});

app.delete("/api/customers/:id", function(req,res){
     console.log("existing object of customer to be deleted from the collection");
     res.send('existing object of customer is removed from collection');
});

app.listen(9898);
console.log("Server is listening on port 9898");