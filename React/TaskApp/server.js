//a Separate responsibility  for  hosting server and setting middleware
const express = require('express');
var path=require('path');
const cors = require('cors');

var app = express();
app.use(express.static(path.join(__dirname,'public')));
app.use(express.urlencoded({extended:true}));
app.use(express.json());
app.use(cors({
  origin: '*'
}));
var routes = require('./router'); //importing route
routes(app); //register the route
var onListen=function(){
  console.log("server is listening on port 8000")
}
app.listen(8000,onListen);