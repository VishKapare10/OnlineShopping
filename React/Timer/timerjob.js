//Browserless code / application
var handler=require('./handler');




//Register showMessage function with setInterval
setInterval(handler.showMessage,3000);
setInterval(handler.displayMessage,1000); 

//blocking call
//add(); 

console.log("Program is about to be terminated...");