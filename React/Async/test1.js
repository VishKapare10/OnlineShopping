async function startWorking(){
    console.log("Working on request");
    console.log("Working on request");
    console.log("Working on request");
    console.log("Working on request");
    console.log("Working on request");
    return "work is completed";
};

function onComplete(){
    console.log("after receiving response");
    console.log("Processing response and updating screen");
}
startWorking().then(onComplete); 
console.log("Task is completed...");