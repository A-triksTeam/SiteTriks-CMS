﻿const path = require('path');
const webpack = require('webpack');
const UglifyJsPlugin = require('uglifyjs-webpack-plugin');

module.exports = {
    mode: 'development',
    entry: {
        // source files
        // common:
        'common/logger': './scripts/common/logger.js',
        'common/mediator': './scripts/common/mediator.js',

        // modules:
        'grid': './scripts/modules/grid.js',

        // sitetriks specific:
        'sitetriks/libraries': './scripts/sitetriks/libraries.js',
        'sitetriks/files': './scripts/sitetriks/files.js',
        'sitetriks/pages': './scripts/sitetriks/pages.js',
        'sitetriks/edit-content': './scripts/sitetriks/edit-content.js',
        'sitetriks/templates': './scripts/sitetriks/templates.js',
        'sitetriks/dashboard': './scripts/sitetriks/dashboard.js',
        'sitetriks/news': './scripts/sitetriks/news.js',
        'sitetriks/dashboard-configuration': './scripts/sitetriks/dashboard-configuration.js',
        'frontend-layout-scripts': './scripts/frontend-layout-scripts.js',
        'home-page': './scripts/home-page.js',
        'sitetriks/users': './scripts/sitetriks/users.js',
        'sitetriks/user-groups': './scripts/sitetriks/user-groups.js',
        'sitetriks/roles': './scripts/sitetriks/roles.js',
        'sitetriks/dynamics': './scripts/sitetriks/dynamics.js',
        'sitetriks/extensions': './scripts/sitetriks/extensions.js',
        'sitetriks/thumbnailSizes': './scripts/sitetriks/thumbnailSizes.js',
        'sitetriks/widget-configuration': './scripts/sitetriks/widget-configuration.js',
        'sitetriks/marketing-emails': './scripts/sitetriks/marketing-emails.js',
        'sitetriks/blog': './scripts/sitetriks/blog.js',
        'sitetriks/helpers': './scripts/sitetriks/helpers.js',
        'sitetriks/forum': './scripts/sitetriks/forum.js',
        'sitetriks/setup': './scripts/sitetriks/setup.js',
        'sitetriks/storemanager': './scripts/sitetriks/storemanager.js',
        'sitetriks/storeitemmanager': './scripts/sitetriks/storeitemmanager.js',
        'sitetriks/categorymanager': './scripts/sitetriks/categorymanager.js',
        'sitetriks/store-skins': './scripts/sitetriks/store-skins.js',
        'sitetriks/documentation': './scripts/sitetriks/documentation.js',
        'sitetriks/endpoints': './scripts/sitetriks/endpoints.js',
        'sitetriks/languages': './scripts/sitetriks/languages.js',
        'sitetriks/sitesync': './scripts/sitetriks/sitesync.js',
        'sitetriks/dynamic-views': './scripts/sitetriks/dynamic-views.js',
        'manage-profile-index': './scripts/manage-profile-index.js',
        'sitetriks/layout': './scripts/sitetriks/layout.js',
        'sitetriks/permissions': './scripts/sitetriks/permissions.js',
        'scss/site': './styles/site.scss',
        'scss/front-end-entry': './styles/front-end-entry.scss',
        'scss/back-end-entry': './styles/back-end-entry.scss'
    },
    resolve: {
        modules: [
            path.resolve('./scripts'),
            path.resolve('./node_modules')
        ],
        // file extensions
        extensions: ['.js']
    },
    module: {
        rules: [{
            test: /\.js$/,
            exclude: [/node_modules/],
            use: {
                loader: 'babel-loader',
                options: {
                    presets: ['env']
                }
            }
        },
        {
            test: /\.scss$/,
            use: [
                {
                    loader: 'file-loader',
                    options: {
                        name: 'css/scss/[name]-sitetriks.css'
                    }
                },
                {
                    loader: 'extract-loader'
                },
                {
                    loader: 'css-loader?-url'
                },
                {
                    loader: 'postcss-loader'
                },
                {
                    loader: 'sass-loader'
                }
            ]
        }]
    },
    optimization: {
        minimizer: [
            // specifying a custom UglifyJsPlugin here to get source maps
            new UglifyJsPlugin({
                cache: true,
                parallel: true,
                uglifyOptions: {
                    compress: false,
                    ecma: 6,
                    mangle: true
                },
                sourceMap: true
            })
        ]
    },
    devtool: false,
    plugins: [
        new webpack.SourceMapDevToolPlugin()
    ],
    output: {
        // The format for the outputted files
        filename: 'js/[name].js',
        // The output directory "wwwroot/js/"
        path: path.resolve(__dirname, 'wwwroot/'),
        publicPath: '/js/'
    }
};