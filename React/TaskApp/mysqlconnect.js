//a seperate responsibility for mysql connection string
//database connectivity 
var mysql=require('mysql');

var connection=mysql.createConnection({
    host:'localhost',
    user:'root',
    password:'Know@9999#',
    database:'tap'
});
connection.connect(function(err){

    //Runtime Error handling (Exception handling)
    if(err) 
    throw err;    // raise an exception 
                  //Exception : gracefully terminateing application
});

//This would allow your connection object to be available outside
module.exports=connection;
