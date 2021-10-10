//a Separate responsibility  for  hosting server and setting middleware
const express = require('express');
var path=require('path');
var app = express();
app.use(express.static(path.join(__dirname,'public')));
app.use(express.urlencoded({extended:true}));
app.use(express.json());
var routes = require('./router'); //importing route
routes(app); //register the route
var onListen=function(){
  console.log("server is listening on port 3000")
}
app.listen(3000,onListen);