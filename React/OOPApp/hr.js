//Relationship between more than one classes
//containment has a relationship
//inheritance is a relationship

//Professional way of writing  software code: Object Oriented Programming(OOPs)
class Person{

    constructor(id, fname,lname,email,location){
        //this is a self reference of an instance (object)
        this.id=id;
        this.fname=fname;
        this.lname=lname;
        this.email=email;
        this.location=location;
    }
    getFullName(){
        return this.fname+" "+this.lname;
    }

    display(){
        return `${this.id}, ${this.fname}, ${this.lname}, ${this.email}, ${this.location}`;
    }
}


class Employee extends Person{
    
    constructor(id, fname,lname,email,location, department , salary){
        super(id, fname,lname,email,location);
        this.department=department;
        this.salary=salary;
    }

    show(){
        return super.display()+ ", "+this.department+", "+this.salary;
    }

    computePay(){
        return this.salary + 5000;
    }

}


class SalesEmployee extends Employee{
    constructor(id, fname,lname,email,location, department, salary, incentive){
        super(id, fname,lname,email,location, department , salary);
        this.incentive=incentive;
    }

    computePay(){
        //this.getFullName();
        return super.computePay() + this.incentive;
        
    }
}

let person1= new Person(1,"Rajiv","Patil","rajiv.p@gmail.com","Mumbai");
console.log("Person Details:"+person1.display());
console.log("-----------------------------------------------------------");

let emp1=new Employee(24,"Abhay","kapare","abhay10kapare@gmail.com","Pune","IT",24000);
console.log("Employee Details:"+ emp1.show());
console.log("Employee Total Salary: "+emp1.computePay());

console.log("-----------------------------------------------------------");
let salesEmp=new SalesEmployee(110,"Ganesh","Shinde","shindeg@gmail,com","Manchar","training",10000,4000);
console.log("Sales Employee Total Salary: "+salesEmp.computePay());
