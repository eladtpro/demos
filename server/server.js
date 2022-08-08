'use strict';

const express = require('express');
const requestIp = require('request-ip');

// Constants
const PORT = 8080;
const HOST = '0.0.0.0';

// App
const app = express();
app.get('/', (req, res) => {
  const clientIp = requestIp.getClientIp(req);
  console.log(`New request from CLIENT: ${clientIp}, called on ${new Date().toTimeString()}`);
  res.send('Hello World');
});

app.listen(PORT, HOST);
console.log(`Running on http://${HOST}:${PORT}`);