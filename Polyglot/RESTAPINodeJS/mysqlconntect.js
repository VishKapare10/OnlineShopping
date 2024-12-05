'user strict';

// express, fs, body-parser, path, http node modules
// 
var mysql = require('mysql');

var connection = mysql.createConnection({
    host     : 'localhost',
    user     : 'root',
    password : '',
    database : 'actsdb'
});

connection.connect((err)=> {if (err) throw err;});

module.exports = connection;