//SOC: Seperation of Concern
//Decoupled solution
//External javascript file
var onGetData=function(){
    //by using Document Object Model (DOM)           
    var firstname=document.getElementById("firstname").value;
    var lastname=document.getElementById("lastname").value;

    pFullName=document.getElementById("fullname");
    pFullName.innerHTML=firstname+" "+lastname;
}
var onPing=function(){
    console.log("Button is clicked");
    var pTitle1=document.getElementById("ptitle1");
    pTitle1.innerHTML="Ping"; //property
}
var onPong=function(){
    console.log("Button is clicked");
    var pTitle1=document.getElementById("ptitle2");
    pTitle1.innerHTML="Pong"; //property
} 