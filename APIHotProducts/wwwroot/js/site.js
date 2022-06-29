// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

//Displaying Forms fields
function displayWarehouse() {
    var x = document.getElementById("Warehouse");
    if (x.style.display === "none") {
        x.style.display = "block";
    } else {
        x.style.display = "none";
    }
}

function displayCyclotronS() {
    var x = document.getElementById("CyclotronSpares");
    if (x.style.display === "none") {
        x.style.display = "block";
    } else {
        x.style.display = "none";
    }
}

function displayChemistry1() {
    var x = document.getElementById("Chemistry1");
    if (x.style.display === "none") {
        x.style.display = "block";
    } else {
        x.style.display = "none";
    }
}

function displayBombarding() {
    var x = document.getElementById("Bombarding");
    if (x.style.display === "none") {
        x.style.display = "block";
    } else {
        x.style.display = "none";
    }
}

function displayChemistry2() {
    var x = document.getElementById("Chemistry2");
    if (x.style.display === "none") {
        x.style.display = "block";
    } else {
        x.style.display = "none";
    }
}

function displayTimeCyclotron() {
    var x = document.getElementByClass("displaytime");
    var item = document.getElementsByTagName("p")
    if (x.innerHTML = item[0].getAttribute("value") === "N/A") {
        x.style.display = "none";
    } else {
        x.style.display = "block";
    }
}
