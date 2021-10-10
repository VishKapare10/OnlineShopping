// API routes for Controller callback functions
//a Separate responsibility  for navigation

var taskController=require("./controllers/taskcontroller");
var flowersController=require("./controllers/flowersController");

module.exports=function(app){
//mapping code for different HTTP requests 

app.route("/tasks")
    .get(taskController.getAll)
    .post(taskController.insert);

app.route('/tasks/:id')
    .get(taskController.getBy)
    .put(taskController.update)
    .delete(taskController.remove);

app.route("/flowers")
    .get(flowersController.getAll)
    .post(flowersController.insert);

app.route('/flowers/:id')
    .get(flowersController.getBy)
    .put(flowersController.update)
    .delete(flowersController.remove);
};
//MVC ( Model View Controller)