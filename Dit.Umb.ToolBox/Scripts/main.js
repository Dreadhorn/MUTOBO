
var keydown = "";
var curs = false;

document.addEventListener('keydown', function (event) {
    keydown += event.key.toLowerCase();
    if (!curs) {
        if (keydown.includes("finger")) {
            curs = true;
            keydown = "";
            $.getScript('/scripts/Dreadhorn/cursor.js', function () {
                keyFinger();
            });
        }
        else if (keydown.includes("einhorn")) {
            curs = true;
            keydown = "";
            $.getScript('/scripts/Dreadhorn/cursor.js', function () {
                keyEinhorn();
            });
        }
    }
});

