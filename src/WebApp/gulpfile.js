/// <binding />

"use strict";

var gulp = require('gulp'),
    sass = require('gulp-sass'),
    postcss = require('gulp-postcss'),
    autoprefixer = require('autoprefixer');

var input = './wwwroot/Static/scss/**/*.scss',
    output = './wwwroot/Static/css/';

var sassOptions = {
    errLogToConsole: true,
    outputStyle: 'expanded'
    //outputStyle: 'compressed'
};

var processors = [autoprefixer({ browsers: ['last 3 version'] })];

gulp.task('sass', function () {
    gulp.src(input)
        .pipe(sass(sassOptions).on('error', sass.logError))
        .pipe(postcss(processors))
        .pipe(gulp.dest(output));
});

gulp.task('watch', function () {
    gulp.watch(input, ['sass'])
        .on('error', function (err) { console.log(err); this.emit('end'); });
});