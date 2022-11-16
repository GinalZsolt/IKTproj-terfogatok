const express = require('express');
let session = require('express-session');
let app = express();



app.use(session({
    resave:true,
    secret:'secret',
    saveUninitialized:true
}))
app.use(require('cors')());
app.use(express.urlencoded({extended:true}));
app.use('/', require('./controllers/routeController'));
app.use('/api', require('./controllers/apiController'));
app.use('/admin', require('./controllers/adminController'));






app.listen(process.env.PORT)