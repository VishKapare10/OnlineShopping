//const exp = require('constants');
var express=require('express');
var app=express(); //global object for express
var path=require('path');


//set up middleware
//configuration
app.use(express.static(path.join(__dirname,'public')));
app.use(express.urlencoded({extended:true}));
app.use(express.json());


//mapping incoming HTTP requests with its http handlers
var routes=require('./router');
routes(app);

var onListen=function(){
    console.log("Server is listening on port 9898");
};

app.listen(9898,onListen);