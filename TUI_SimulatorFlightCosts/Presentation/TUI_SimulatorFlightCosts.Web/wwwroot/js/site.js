// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function CalculDistance(flightName) {
    $.ajax({
        type: "Get",
        url: "/Home/CalculDistance?flightName=" + flightName,
        contentType: "application/json; charset=utf-8"        
    });
}

function CalculConsumptionFuel(flightName) {
    $.ajax({
        type: "Get",
        url: "/Home/CalculConsumptionFuel?flightName=" + flightName,
        contentType: "application/json; charset=utf-8"
    });
}