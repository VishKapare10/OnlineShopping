//Javascript is a procedural functional programming scripted language.
//Declare function
exports.show=function(){

    var result=78;
    result++;
    console.log(result);
};

exports.display=function(){

    var banner="Welcome to javascript";
    console.log(banner);
};


//Arithmetic Operations
exports.add=function(num1, num2){
    var temp=num1 + num2;
    return temp;
};


exports.substract=function(num1, num2){
    var temp=num1 - num2;
    return temp;
};

