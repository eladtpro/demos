const toobusy = require('toobusy-js');
const express = require('express');
const app = express();
app.use(function(req, res, next) {
    if (toobusy()) { //-> check if service is overwhelmed with traffic
        // log if you see necessary
        res.send(503, "Server Too Busy");
    } else {
    next();
    }
});
