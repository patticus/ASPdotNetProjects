$("document").ready(function () {

    $(".testButton").css({
        "background-color": "#C06300",
        "color": "aliceblue",
        "font-family": "Century Gothic",
        "border-radius": "8px",
        "padding": "8px 6px"
    });

    $(".center").css({
        "display": "none"
    });

    $(".testButton").click(function () {

        $(".center").toggle();
        $([document.documentElement, document.body]).animate({
            scrollTop: $(".center").offset().top
        }, 800);
        $(".div1").fadeIn(800);
        setTimeout(function () { $(".div2").fadeIn(800); }, 700);
        setTimeout(function () { $(".div3").fadeIn(800); }, 1400);
    });
});