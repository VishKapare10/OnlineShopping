var http=require('http');    //Node JS API
var fs=require('fs');        //Node JS API
//Create a server
var server=http.createServer(function(request,response){
    if(request.url == '/'){
        fs.readFile('index.html',function(err,data){
            response.writeHead(200,{'Content-Type':'text/html'});
            response.write(data);
            response.end();
        });
    }
    
    else if(request.url == '/aboutus.html'){
        fs.readFile('aboutus.html',function(err,data){
            response.writeHead(200,{'Content-Type':'text/html'});
            response.write(data);
            response.end();
        });
    } 

    else if(request.url == '/contactus.html'){

        fs.readFile('contactus.html',function(err,data){
            response.writeHead(200,{'Content-Type':'text/html'});
            response.write(data);
            response.end();
        });
    }

    
    else if(request.url == '/login.html'){
        fs.readFile('login.html',function(err,data){
            response.writeHead(200,{'Content-Type':'text/html'});
            response.write(data);
            response.end();
        });
    } 
    
    else if(request.url == '/register.html'){
        fs.readFile('register.html',function(err,data){
            response.writeHead(200,{'Content-Type':'text/html'});
            response.write(data);
            response.end();
        });
    } 
    else
        response.end("Invalid Request");
});
server.listen(9000);
//Console will print the message
console.log("Server running at http://127.0.0.1:9000/");