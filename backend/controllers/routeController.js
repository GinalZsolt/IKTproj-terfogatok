let routes = require('express').Router();
let path = require('path');
routes.get('/', (req,res)=>{
    res.status(200).sendFile(path.join(__dirname, '../../frontend/promo/promo.html'));
})
routes.get('/admin/login', (req,res)=>{
    res.sendFile(path.join(__dirname, '../../frontend/admin/index.html'));
})

module.exports = routes;