// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
let response = prompt("Please enter your name:")
if (response == null || response == "") {
    document.getElementById("welcome").innerHTML = `Welcome, Guest!`
}
else {
    document.getElementById("welcome").innerHTML = `Welcome, ${response}!`
}
