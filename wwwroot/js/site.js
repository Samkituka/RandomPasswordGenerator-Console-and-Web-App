// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function myFunction() {
    navigator.clipboard.writeText(document.getElementById('myInput').innerText)
        .then(function () {
            console.log('text has been copied!')
            alert("Copied!!")
        })
}