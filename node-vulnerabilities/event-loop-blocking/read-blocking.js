const fs = require('fs');
fs.readFile('/file.txt', (err, data) => {
  // perform actions on file content
});
fs.unlinkSync('/file.txt');