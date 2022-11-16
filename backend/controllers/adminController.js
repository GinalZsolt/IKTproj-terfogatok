let routes = require('express').Router();


routes.get('/admin/login', (req,res)=>{
    res.sendFile('../frontend/admin/index.html')
})
routes.get('/admin/', (req,res)=>{
    if (req.session.isLoggedin) res.sendFile('../frontend/admin/dash.html');
    else res.redirect(403, '/admin/login');
})



module.exports = routes;