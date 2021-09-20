var name= "Ravi";
names=['Rajiv','Shubham','Akash','Saurav','Rahul'];

/*console.log(names[0]);
console.log(names[1]);
console.log(names[2]);



var size=names.length;
console.log(size);
console.log(names);


//Remove elements from array
names.length=3;
console.log(names);


names.length=7;
names[3]="Virat";
names[4]="Rohit";
names[5]="MSD";
names[6]="Ajinkya";
console.log(names);
*/


//remove elements from array
/*let scores=[1,2,3,4,5]; //let is used for scope variable
console.log(scores);

let deletedScores=scores.splice(0,2);

console.log(scores);
console.log(deletedScores);

//Insert elements using splice method
let colors=['red','green','blue'];
colors.splice(2,0,'purple');
console.log(colors);
colors.splice(1,0,'yellow','pink');
console.log(colors);

//check array elements using for loop.
let numbers=[1,3,5];  //classical Javascript
let result=true;
for(let i=0;i<numbers.length;i++){
    //console.log(numbers[i]);
    if(numbers[i]<=0){
        result=false;
        break;
    }
}
console.log(result);

//Modern Programming
//clean code
//code is supposed to be simple, elegant and powerful
let numbers=[1,3,5];
let result=numbers.every(function(e){
    return e>0;
});
console.log(result);*/


//ES6: Ecmascript Javascript
//Arrow function
let numbers=[1,3,5];
let result=numbers.every(e=>e>0);
console.log(result);