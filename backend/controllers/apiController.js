require('dotenv').config();
let routes = require('express').Router();
const mysql = require('mysql');
let pool = mysql.createPool({
    host:process.env.DBHOST,
    password:process.env.DBPASS,
    user:process.env.DBUSER,
    database:process.env.DBNAME,
    connectionLimit:process.env.DBLIMIT
})

routes.get('/tickets', (req,res)=>{
    pool.query('select * from tickets', (err,data)=>{
        if (err) res.status(500).send(err.sqlMessage);
        else res.status(200).send(data);
    })
})
routes.post('/new-ticket', (req,res)=>{
    if (!ValidData()) res.status(500).send('Hibás bemeneti adatok!');
    let formdata = req.body;
    pool.query('insert into tickets values (null, ?, ?, ?, current_timestamp)', [formdata.name, formdata.email, formdata.message], (err,data)=>{
        if (err) res.status(500).send(err.sqlMessage);
        else res.status(200).send(data);
    })
})

function ValidData(data){
    try{Object.values(data);} 
    catch (err){return false;}
    return true;
}

module.exports = routes;