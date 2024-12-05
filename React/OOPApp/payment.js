class Customer{
    constructor(id, contactPerson, location){
        this.id=id;
        this.contactPerson=contactPerson;
        this.location=location;
    }
}
class Payment{
    constructor(id,customer,amount){
        this.id=id;
        this.customer=customer;
        this.amount=amount;
    }
}

let cust=new Customer(88,"Ravi Tambade","Pune");
let pmt=new Payment(45,cust,56000); //has a relationship
console.log(pmt);