//This file will contain logic for handling client request.
var http=require('http');
//callback function
//Non Blocking call
var server=http.createServer(function(req,res){
    if (req.url == '/'){
        res.writeHead(200,{'Content-Type':'text/html'});
        res.write('<html>'
                      +'<body>'+
                        '<h1>Transflower Store</h1>'+
                        '<hr/>'+
                        '<ul>'+
                            '<li>Gerbera</li>'+
                            '<li>Rose</li>'+
                            '<li>Lotus</li>'+
                            '<li>Marigold</li>'+
                            '<li>Orchid</li>'+
                        '</ul>'+
                        '<input/>'+
                        '<br/>'+
                        '<button>Click me!</button>'+
                      '</body>'+
                  '</html>');
        res.end();
    }
    else if (req.url == '/student'){
        res.writeHead(200,{'Content-Type':'text/html'});
        res.write('<html>'
        +'<body>'+
          '<h1>Transflower Students</h1>'+
          '<hr/>'+
          '<ul>'+
              '<li>Vishwambhar</li>'+
              '<li>Abhay</li>'+
              '<li>Kiran</li>'+
              '<li>Seema</li>'+
              '<li>Vishal</li>'+
          '</ul>'+
          '<input/>'+
          '<br/>'+
          '<button>Register!</button>'+
        '</body>'+
    '</html>');
        res.end();
    }
    else if (req.url == '/admin'){
        res.writeHead(200,{'Content-Type':'text/html'});
        res.write("<html><body><p>This is admin page.</p></body></html>");
        res.end();
    }
    else{
        res.end('Invalid Request');
    }
    
});
server.listen(9000);
console.log("Node js web server is running on port 9000");