const path = require('path');

module.exports = {
  entry: path.resolve(__dirname, 'wwwroot', 'app', 'home.js'),
  output: {
    filename: 'homebundle.js',
    path: path.resolve(__dirname, 'wwwroot', '.temp')
  },
  module: {
    rules: [{
      test: /\.scss$/,
      use: [
        "style-loader", // creates style nodes from JS strings
        "css-loader", // translates CSS into CommonJS
        "sass-loader" // compiles Sass to CSS, using Node Sass by default
      ]
    }]
  }
};