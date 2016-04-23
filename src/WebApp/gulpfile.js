/// <binding />

"use strict";

var gulp = require('gulp');
var sass = require('gulp-sass');

var input = './wwwroot/Static/scss/*.scss';
//var input = './wwwroot/lib/foundation-sites/scss/*.scss';
var output = './wwwroot/Static/css/';

var sassOptions = {
    errLogToConsole: true,
    //outputStyle: 'compressed'
};

gulp.task('sass', function () {
    gulp.src(input)
        .pipe(sass(sassOptions).on('error', sass.logError))
        .pipe(gulp.dest(output));
});

//gulp.task('default', function () {
//    gulp.watch('Static/sass/*.scss', ['sass'])
//        .on('error', function (err) { console.log(err); this.emit('end'); });
//});