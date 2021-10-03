//first fetch data from server
//url http://localhost:9898/api/flowers
//RPC 
//readymade api provided by one standard javascript library
//Library: jQuery
//set of reusable javascript functions
//Invoke server side data

var dataUrl="http://localhost:9898/api/flowers";

//This function will fetch data from above url
$.ajax({
        url:dataUrl, //which url
        type:"GET", //What is the type of request
        success:function(data){ 
                console.log(data);
                },
        error:function(err){
                console.log(err);
                }
});