//a Separate responsibility  for  flowerss database crud operation

var sql = require('../mysqlconnect');

//model

var flowers = function(flowers){
    this.flowers = flowers.flowers;
    this.status = flowers.status;
    this.created_at = new Date();
};

flowers.createflowers = function (newflowers, result) {    
        sql.query("INSERT INTO flowers set ?", newflowers, function (err, res) {
                if(err) {
                  console.log("error: ", err);
                  result(err, null);
                }
                else{
                  console.log(res.insertId);
                  result(null, res.insertId);
                }
            });           
};

flowers.getflowersById = function (flowerId, result) {
  sql.query("Select * from flowers where id = ? ", flowerId, function (err, res) {             
          if(err) {
            console.log("error: ", err);
            result(err, null);
          }
          else{
            result(null, res);     
          }
      });   
};


flowers.getAllflowers = function (result) {
      console.log("Invoking dal getall flowers");
      
        sql.query("Select * from flowers", function (err, res) {
                if(err) {
                  console.log("error: ", err);
                  result(null, err);
                }
                else{
                  console.log('flowers : ', res);  
                  result(null, res);
                }
            });   
};

flowers.updateById = function(id, flowers, result){
  sql.query("UPDATE flowers SET flowers = ? WHERE id = ?", [flowers.flowers, id], function (err, res) {
          if(err) {
                console.log("error: ", err);
                result(null, err);
             }
           else{   
             result(null, res);
            }
    }); 
};


flowers.remove = function(id, result){
    sql.query("DELETE FROM flowers WHERE id = ?", [id], function (err, res) {
                if(err) {
                    console.log("error: ", err);
                    result(null, err);
                }
                else{
                    result(null, res);
                }
            }); 
};

module.exports=flowers;