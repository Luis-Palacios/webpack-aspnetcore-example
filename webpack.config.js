const path = require('path');

module.exports = {
    mode: 'development',
    entry: {
        'common': path.resolve(__dirname, 'wwwroot', 'app', 'common.js'),
        'home': path.resolve(__dirname, 'wwwroot', 'app', 'home.js'),
        'search': path.resolve(__dirname, 'wwwroot', 'app', 'search.js'),
    },
    devtool: 'inline-source-map',
    devServer: {
        publicPath: '/.temp/',
        proxy: {
            '**': {
                target: 'http://localhost:5000',
                changeOrigin: true,
            },
        }
    },
    output: {
        filename: '[name].bundle.js',
        path: path.resolve(__dirname, 'wwwroot', '.temp'),
    },
    module: {
        rules: [
            {
                test: /\.scss$/,
                use: [
                    'style-loader',
                    'css-loader',
                    'sass-loader'
                ]
            },
            {
                test: /\.css$/,
                use: ['style-loader', 'css-loader']
            }
        ]
    }
}