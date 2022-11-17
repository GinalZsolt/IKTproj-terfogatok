let routes = require('express').Router();
let path = require('path');

routes.get('/login', (req,res)=>{
    res.sendFile(path.join(__dirname, '../../frontend/admin/index.html'));
})
routes.get('/', (req,res)=>{
    if (req.session.isLoggedin) res.sendFile(path.join(__dirname, '../../frontend/admin/dash.html'));
    else res.redirect('/admin/login');
})



module.exports = routes;