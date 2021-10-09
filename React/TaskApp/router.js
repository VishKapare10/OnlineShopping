//API routes for Controller callback functions
var taskController=require('./taskcontroller');

module.exports=function(app){

    //mapping code for diffrent HTTP requests
    app.route("/task")
        .get(taskController.getAll)
        .post(taskController.insert);

    app.route("/tasks/:id")
        .get(taskController.getBy)
        .put(taskController.update)
        .delete(taskController.remove);
}