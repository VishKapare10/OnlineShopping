//Classical Javascript
var Account=function(initialAmount){
    var balance=initialAmount;
    var deposit=function(amount){
        balance+=amount;
    };
    var withdraw=function(amount){
        balance-=amount;
    };
    var showBalance=function(amount){
        //return a value
        return balance;
    };

    //This block is used to export functions outside
    //return block
    return{
        Deposit:deposit,
        Withdraw:withdraw,
        ShowBalance:showBalance
    }
}

var acct123=new Account(56000);
acct123.Deposit(60000);
var result=acct123.ShowBalance();
console.log(`Balance= ${result}`);