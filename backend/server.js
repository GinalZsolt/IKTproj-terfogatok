const express = require('express');
let session = require('express-session');
let app = express();
let path = require('path');


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

app.use('/css', express.static(path.join(__dirname, '../frontend/assets/css')));
app.use('/js', express.static(path.join(__dirname, '../frontend/assets/js')));
app.use('/img', express.static(path.join(__dirname, '../frontend/assets/img')));




app.listen(process.env.PORT)