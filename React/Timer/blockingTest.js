var blockingLib=require("./blockingLib");

console.log("Start of Blocking Javascript");
blockingLib.add(); //This function is blocking main
console.log("End of Blocking Javascript")