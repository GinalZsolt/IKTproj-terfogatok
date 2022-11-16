let routes = require('express').Router();

routes.get('/', (req,res)=>{
    res.status(200).sendFile('../frontend/promo/promo.html');
})

module.exports = routes;