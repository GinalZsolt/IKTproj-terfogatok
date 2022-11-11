const express = require('express');
let app = express();




app.use(require('cors')());
app.use(express.urlencoded({extended:true}));
app.use('/', require('./controllers/routeController'));
app.use('/api', require('./controllers/apiController'));






app.listen(process.env.PORT)