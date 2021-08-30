const express = require('express'),
app = express(),
bodyParser = require('body-parser');

app.use(bodyParser.urlencoded({ extended: true }));
app.use(bodyParser.json());

var routes = require('./router'); //importing route
routes(app); //register the route

var onListen=function(){
  console.log("server is listening on port 3000 ");
}

//lambda expression ( arrow function)
// are used to define callback function
// Can we have a function without a name (Annonymous)
// and its should be inline function
app.listen(3000,()=>{console.log("Server is listening on port 3000")});
