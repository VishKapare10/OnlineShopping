//a Separate responsibility  for  flowerss  HTTP request handling

var flowers = require('../DAL/flowersdal.js');

exports.getAll = function(req, res) {
  console.log("calling controller function");
  flowers.getAllflowers(function(err, flowers) {
    if (err)
      res.send(err);
    res.send(flowers);
  });
};

exports.insert = function(req, res) {
  
  var new_flowers = new flowers(req.body);

  //handles null error 
   if(!new_flowers.flowers || !new_flowers.status){
      res.status(400).send({ error:true, message: 'Please provide flowers/status' });
    }
   else{
    flowers.createflowers(new_flowers, function(err, flowers) {
      if (err)
      res.send(err);
    res.json(flowers);
    });
  }
};

exports.getBy = function(req, res) {
  flowers.getflowersById(req.params.id, function(err, flowers) {
    if (err)
      res.send(err);
    res.json(flowers);
  });
};

exports.update = function(req, res) {
  flowers.updateById(req.params.id, new flowers(req.body), function(err, flowers) {
    if (err)
      res.send(err);
    res.json(flowers);
  });
};

exports.remove = function(req, res) {
  flowers.remove( req.params.id, function(err, flowers) {
    if (err)
      res.send(err);
    res.json({ message: 'flowers successfully deleted' });
  });
};