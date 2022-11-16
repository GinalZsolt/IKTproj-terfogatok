require('dotenv').config();
let routes = require('express').Router();
const mysql = require('mysql');
const crypto = require('crypto');
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
    console.log(req.body)
    if (!ValidData(req.body, ['name', 'email', 'message'])) res.status(500).send('Hibás bemeneti adatok!');
    else{
        let formdata = req.body;
        pool.query('insert into tickets values (null, ?, ?, ?, current_timestamp)', [formdata.name, formdata.email, formdata.message], (err,data)=>{
            if (err) res.status(500).send(err.sqlMessage);
            else res.status(200).send(data);
        })
    }
})
routes.post('/login', (req,res)=>{
    console.log(req.body);
    if (!ValidData(req.body, ['username', 'password'])) res.status(500).send('Hibás bemeneti adatok');
    else {
        let formdata = req.body;
        pool.query('select * from users where username=? and passwd=?', [formdata.username, crypto.createHash('sha256').update(formdata.password).digest('hex')], (err,data)=>{
            if (err) res.status(500).send(err);
            else {
                if (data.length==1) res.redirect(200, '/admin');
                else res.redirect(403, '/admin/login');
            }
        })
    }
})
routes.delete('/delete-ticket/:id', (req,res)=>{
    pool.query('delete from tickets where id=?', [req.params.id], (err,data)=>{
        if (err) res.status(500).send(err.message);
        else res.status(200).send(data);
    })
})
function ValidData(data, fieldnames){
    try{Object.values(data);} 
    catch (err){return false;}
    if (Object.values(data).includes('')) return false;
    console.log(fieldnames);
    for (let i = 0; i < Array.from(fieldnames).length; i++) {
        if (!Object.keys(data).includes(fieldnames[i])) return false;        
    }
    return true;
}

module.exports = routes;