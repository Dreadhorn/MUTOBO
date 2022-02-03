
var curser;
var skript;

function createElement(){
    var cur = document.createElement('div')
    cur.id = 'curser'
    document.body.prepend(cur)
}

function keyFinger() {
    createElement();
    skript = '/scripts/Dreadhorn/svg/finger.js';
}

function keyEinhorn() {
    createElement();
    skript = '/scripts/Dreadhorn/svg/einhorn.js';
}

setTimeout(
    function () {
        $.getScript(skript, function () {
            curser = new cursor();

        }).then(() => {

            $('#curser').html(curser.point);
            document.body.style.cursor = "none";

            $(this).mousedown(function (e) {
                $('#curser').html(curser.down);
            })

            $(this).mouseup(function (e) {
                $('#curser').html(curser.point);
            })

            $(this).mousemove(function (e) {
                $('#curser').css({ top: e.pageY - curser.posY(), left: e.pageX - curser.posX() });
            });
        })
    }, 100);


