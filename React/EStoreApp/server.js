var express=require('express');
var app=express();

//HTTP handlers
//incoming request routing
//callback functions are mapped with urls
//URL Route mapping
var onDefault=function(req,res){
    res.send("<h1>Transflower learning pvt.ltd.<h1>"+
              "<hr/>"+
              "<ol>"+
              "<li>Mentoring for skill building</li>"+
              "<li>Workshops</li>"+
              "<li>Online Courses</li>"+
              "<li>CDAC Courses</li>"
    );
}
var onAboutus=function(req,res){
    res.send("<h1>Chied Mentor: Ravi Tambade<h1>")
}
var onContact=function(req,res){
    res.send("<h1>Email ID: ravi.tamdade@transflower.in<h1>")
}

app.get("/",onDefault);
app.get("/aboutus",onAboutus);
app.get("/contactus",onContact);
app.listen(8888);
console.log("web server is listening on port 8888");