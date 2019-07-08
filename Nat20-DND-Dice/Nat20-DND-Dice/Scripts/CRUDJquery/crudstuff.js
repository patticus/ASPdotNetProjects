$("document").ready(function () {
    $(".edit").css({
        "background-color": "purple",
        "color": "antiquewhite",
        "font-family": "Typold",
        "border-radius": "12px",
        "border": "2px solid black",
        "padding": "4px 6px"
    });

    $(".details").css({
        "background-color": "brown",
        "color": "antiquewhite",
        "font-family": "Typold",
        "border-radius": "12px",
        "border": "2px solid black",
        "padding": "4px 6px"
    });

    $(".delete").css({
        "background-color": "blue",
        "color": "antiquewhite",
        "font-family": "Typold",
        "border-radius": "12px",
        "border": "2px solid black",
        "padding": "4px 6px"
    });

    $(".testButton").click(function () {
        $(this).text(function (i, text) {
            return text === "Open Dice Roller" ? "Close Dice Roller" : "Open Dice Roller";
        })
        $("#center").toggle("fast");
        
    });

    $("#button").click(function () {
        $("#dice").effect("shake", { direction: "up", times: 1, distance: 20 }, 200);
        $("#dice").effect("shake", { times: 2, distance: 30 }, 350);
        })

});


var dice = {
    sides: 20,
    roll: function () {
        var randomNumber = Math.floor(Math.random() * this.sides) + 1;
        return randomNumber;
    }
}


function printNumber(number) {
    var dice = document.getElementById('dice');
    dice.innerHTML = number;
}

var clicky = document.getElementById('button');

clicky.onclick = function () {
    var result = dice.roll();
    setTimeout(function () { printNumber(result); }, 580);
}

