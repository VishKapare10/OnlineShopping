//Define Product as a class
class Product{
    constructor(title,description, price){
        //defining as well as initializing data members
        this.title=title;
        this.price=price;
        this.description=description;
      
    }
    sell(){
        var message=`This product is sold...${this.title} ${this.description}  ${this.price}`;
        console.log(message);
    }
    update(newTitle,newDescription, newPrice){
        this.title=newTitle;
        this.unitPrice=newPrice;
        this.description=newDescription;
    }
}

let flower1=new Product("Gerbera","Beautiful flower",10);
let flower2=new Product("Jasmine","Awesome arabian jasmine",2);
let flower3=new Product("Lotus","Worship flower",23);

flower1.sell();
flower2.sell();
flower3.sell();