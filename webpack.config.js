const path = require('path');

module.exports = {
    entry: path.resolve(__dirname, 'wwwroot', 'app', 'home.js'),
    output: {
        filename: 'homebundle.js',
        path: path.resolve(__dirname, 'wwwroot', '.temp'),
    }
}