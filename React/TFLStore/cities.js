let cities=[
    {name:'Los Angeles',population:98723663},
    {name:'New York',population:77723663},
    {name:'Shicago',population:253663},
    {name:'Hoston',population:55002011},
    {name:'Philadelphia',population:223663}
]

/*let bigCities=[];
for(let i=0;i<cities.length;i++){
        if(cities[i].population>3000000){
            bigCities.push(cities[i]);
        }
}
console.log(bigCities);

let bigCities=cities.filter(function(e){
    return e.population>3000000;
})
console.log(bigCities);*/


let bigCities = cities.filter(city => city.population >3000000);
console.log(bigCities);

//Javascript Query
//Data Analytics
cities.filter(city => city.population >3000000)
.sort((c1,c2)=>c1.population-c2.population)
.map(city=>console.log(city.name+" : "+city.population));
