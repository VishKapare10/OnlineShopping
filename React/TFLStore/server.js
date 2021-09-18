var express=require('express');
var app=express(); //Global object
var path=require('path');

//Data Store
var customers=[{"id":12,"firstname":"Rajiv","lastname":"Patil","email":"rajiv.patil@gmail.com","contactno":"9899887651"},
               {"id":15,"firstname":"Rahul","lastname":"Kale","email":"rahul.kale@gmail.com","contactno":"9900876543"},
               {"id":20,"firstname":"Abhay","lastname":"Kapare","email":"abhay10kapare@gmail.com","contactno":"7799887651"},
               {"id":21,"firstname":"Akash","lastname":"Aurade","email":"a.aurade@gmail.com","contactno":"7899887651"},
               {"id":22,"firstname":"Pratik","lastname":"Takawale","email":"ptakawale@gmail.com","contactno":"9099887651"},
               {"id":25,"firstname":"Kiran","lastname":"Muluk","email":"kirn.m@gmail.com","contactno":"7299887651"}];

var flowers=[{"id":1,"name":"Gerbera","description":"Wedding flower","unitprice":12,"quantity":5000},
             {"id":2,"name":"Rose","description":"Valentine flower","unitprice":20,"quantity":10000},
             {"id":3,"name":"Lotus","description":"Worship flower","unitprice":20,"quantity":1500},
             {"id":4,"name":"Carnation","description":"Delicate flower","unitprice":15,"quantity":15000}
            ];


app.use(express.static(path.join(__dirname,'public'))); //for setting path for static files
app.get("/",function(req,res){
            res.sendFile("./index.html")
        }
);

//GET Operations
app.get("/api/flowers",function(req,res){
    res.send(flowers);
});

app.get("/api/customers",function(req,res){
    res.send(customers);
});

//CRUD Operation
app.post("/api/flowers",function(req,res){
        //Add new json object to collection flowers

});

app.put("/api/flowers/:id", function(req,res){
        //Update 
});


app.delete("/api/flowers/:id", function(req,res){
        
});

app.listen(9898);
console.log("Server is listening on port 9898");