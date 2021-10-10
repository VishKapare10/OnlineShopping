// API routes for Controller callback functions
//a Separate responsibility  for navigation

var taskController=require("./controllers/taskcontroller");

module.exports=function(app){
//mapping code for different HTTP requests 

app.route("/tasks")
    .get(taskController.getAll)
    .post(taskController.insert);

app.route('/tasks/:id')
    .get(taskController.getBy)
    .put(taskController.update)
    .delete(taskController.remove);
};
// MVC ( Model View Controller)