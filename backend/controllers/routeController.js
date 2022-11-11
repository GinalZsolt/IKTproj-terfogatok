let routes = require('express').Router();

routes.get('/admin/login', (req,res)=>{
    res.sendFile('../frontend/')
})
routes.get('/admin/', (req,res)=>{
    if (req.session.isLoggedin) res.sendFile('../frontend/admin/index.html');
    else res.redirect(403, '/admin/login');
})



module.exports = routes;