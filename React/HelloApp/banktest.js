var acct=require('./banklogic');
acct.withdraw(1000);
var result=acct.getBalance();
console.log("Balance="+result);