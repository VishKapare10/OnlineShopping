//REST API HTTP request handlers logic
var Task=require('./dal');

exports.getAllTasks=function(req,res){
    //get all tasks from database table
    var onDataReceivedFromDAL=function(err,result){
        if(err)
            res.send(err);
        res.send(result);
    };

    //registering callback function to be called only after 
    //dal logic is processed
    Task.getAllTask(onDataReceivedFromDAL); 
};

exports.getById=function(req,res){

    //get the task whose id is matched
    Task.getById(req.param);
};

exports.insert=function(req,res){
    //insert new record into tasks based on data received inside body
    Task.insert(req.body);
};

exports.update=function(req,res){
    //update existing record whose id is matched and the object is sent to
    //tables which will be extracted from the body of request
    Task.update();
};

exports.remove=function(req,res){
    //delete existing record whose id is matched
    Task.delete();
};
