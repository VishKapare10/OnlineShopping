// code for database  CRUD Operations

var sql=require('./mysqlconnect');

// CRUD Operations functions for Tasks
// SQL  CRUD Queries:
// Select task from task
// select task from task where id= ?
// insert into task  values(.......)
// update task set ........ where id ...
// delete from task where id=....

//Business object
//Constructor
//Object is real world instance which has state, behaviour and identity
var Task=function(task){
    this.task=task.task;        //attribute
    this.status=task.status;    //attribute
    this.created_at=new Date(); //attribute
    this.owner="Ravi Tamdade";
    this.company="Transflower";
};

Task.createTask=function(){

};

Task.getAllTasks=function(result){
    // code to fetch all records
    sql.query('SELECT * FROM tap.tasks;',function (err, result, fields) {
      if (err)
        console.log("error:"+err);
        result(err,null);
      console.log(result);
    })
};

Task.getById=function(){

};

Task.update=function(){

};

Task.remove=function(){

};

 

  // code  to fetch particular record
  sql.query('select  * from tasks where id=3',function (err, result, fields) {
    if (err) throw err;
    console.log(result);
  })

  // code to delete existing record
  sql.query('delete  from tasks where id=3',function (err, result, fields) {
    if (err) throw err;
    console.log(result);
  })

   //Code to update existing recrod
    sql.query("UPDATE tasks SET task = 'complete handson' WHERE id = 5",
            function (err, result, fields) {
                if (err) throw err;
                console.log(result);
    })

     //Code to insert into existing recrod
     sql.query("INSERT INTO tap.tasks (id,task, status, created_at) VALUES (9,'Fix bugs',1,'2021-10-7 11:19:01')",
     function (err, result, fields) {
         if (err) throw err;
         console.log(result); 
     }) 

module.exports=Task;