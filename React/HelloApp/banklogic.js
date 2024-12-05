
//Wrapper function for all account related operations.
//exports.Account=function(){

    var balance=56000;
    exports.withdraw=function(amount){

        balance=balance-amount;
    };
    
    exports.deposit=function(amount){
    
        balance=balance+amount;
    };

    exports.getBalance=function(){
        return balance;
    };
//};


