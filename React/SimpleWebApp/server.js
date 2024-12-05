//This file will contain logic for handling client request.
var http=require('http');
//callback function
//Non Blocking call
var onReceive=function(req,res){
    res.writeHead(200,{'Content-Type':'text/html'});
    res.write("<h1>Welcome to Server side Programming!</h1>");
    res.end();
};
var server=http.createServer(onReceive);
server.listen(8000);
console.log("Server is listening on port 8000");