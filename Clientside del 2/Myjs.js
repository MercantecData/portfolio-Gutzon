var cubex = -22,    // initial rotation
    cubey = -38,
    cubez = 0;
var Number;
function rodtate(variableName, degrees) {
    window[variableName] = window[variableName] + degrees;
    rotCube(cubex, cubey, cubez);
}
function onload() {
    Setsideclass('White');
    Setsideclass('Yellow');
    Setsideclass('Blue');
    Setsideclass('Green');
    Setsideclass('Red');
    Setsideclass('Orange');
    updatecube();

}
var cubesX = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0];
var cubesY = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0];
var cubesZ = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0];
var WYCLASS = ['Blue', 'Orange', 'Green', 'Red'];
var ROCLASS = ['Blue', 'White', 'Green', 'Yellow'];
var BGCLASS = ['White', 'Orange', 'Yellow', 'Red'];
function rotate(classname, amount) {
    Number = document.getElementsByClassName(classname).length;
    while (Number > 0) {
        Number -= 1;
        cubenr = parseInt(document.getElementsByClassName(classname)[Number].getAttribute('id').slice(4, 6));
        var cube = document.getElementById('Cube' + cubenr);
        var direction;
        if (amount > 0) {
            direction = 1;
        }
        else {
            direction = -1;
        }
        if (classname == 'White_Side' || classname == 'Yellow_Side') {
            if (cube.classList.contains('Blue_Side')) {
                var n = 0;
                if (direction == -1) { n = 4 }
                cube.classList.add(WYCLASS[0 + direction + n] + '_Update');
                cube.classList.remove('Blue_Side');
            }
            if (cube.classList.contains('Green_Side')) {
                cube.classList.add(WYCLASS[2 + direction] + '_Update');
                cube.classList.remove('Green_Side');
            }
            if (cube.classList.contains('Orange_Side')) {
                cube.classList.add(WYCLASS[1 + direction] + '_Update');
                cube.classList.remove('Orange_Side');
            }
            if (cube.classList.contains('Red_Side')) {
                var n = 0;
                if (direction == 1) { n = -4 }
                cube.classList.add(WYCLASS[3 + direction + n] + '_Update');
                cube.classList.remove('Red_Side');
            }
            cubesY[cubenr] += amount;
        }
        else if (classname == 'Red_Side' || classname == 'Orange_Side') {
            if (cube.classList.contains('Blue_Side')) {
                var n = 0;
                if (direction == -1) { n = 4 }
                cube.classList.add(ROCLASS[0 + direction + n] + '_Update');
                cube.classList.remove('Blue_Side');
            }
            if (cube.classList.contains('Green_Side')) {
                cube.classList.add(ROCLASS[2 + direction] + '_Update');
                cube.classList.remove('Green_Side');
            }
            if (cube.classList.contains('White_Side')) {
                cube.classList.add(ROCLASS[1 + direction] + '_Update');
                cube.classList.remove('White_Side');
            }
            if (cube.classList.contains('Yellow_Side')) {
                var n = 0;
                if (direction == 1) { n = -4 }
                cube.classList.add(ROCLASS[3 + direction + n] + '_Update');
                cube.classList.remove('Yellow_Side');
            }
            cubesX[cubenr] += amount;
        }
        else {
            if (cube.classList.contains('White_Side')) {
                var n = 0;
                if (direction == -1) { n = 4 }
                cube.classList.add(BGCLASS[0 + direction + n] + '_Update');
                cube.classList.remove('White_Side');
            }
            if (cube.classList.contains('Orange_Side')) {
                cube.classList.add(BGCLASS[1 + direction] + '_Update');
                cube.classList.remove('Orange_Side');
            }
            if (cube.classList.contains('Yellow_Side')) {
                cube.classList.add(BGCLASS[2 + direction] + '_Update');
                cube.classList.remove('Yellow_Side');
            }
            if (cube.classList.contains('Red_Side')) {
                var n = 0;
                if (direction == 1) { n = -4 }
                cube.classList.add(BGCLASS[3 + direction + n] + '_Update');
                cube.classList.remove('Red_Side');
            }
            cubesZ[cubenr] += amount;
        }
    }
    updatecube()
}
function Setsideclass(classname) {
    Number = document.getElementsByClassName(classname).length;
    while (Number > 0) {
        Number -= 1;
        document.getElementsByClassName(classname)[Number].parentElement.parentElement.classList.add(classname + '_Side');
    }

}
function UpdateColorClass(classname) {
    Number = document.getElementsByClassName(classname+'_Update').length;
    while (Number > 0) {
        Number -= 1;
        document.getElementsByClassName(classname+'_Update')[Number].classList.add(classname + '_Side');
        document.getElementsByClassName(classname+'_Update')[Number].classList.remove(classname + '_Update');
    }

}
function updatecube() {
    var i = 1;
    while (i < 27) {
        document.getElementById("Cube" + i).style.transform = 'RotateX(' + cubesX[i] + 'deg) RotateY(' + cubesY[i] + 'deg) RotateZ(' + cubesZ[i] + 'deg)'
        i += 1;
    }

    if(document.getElementsByClassName('White_Update').length > 0){
        UpdateColorClass('White');
    }
    if(document.getElementsByClassName('Yellow_Update').length > 0){
        UpdateColorClass('Yellow');
    }
    if(document.getElementsByClassName('Red_Update').length > 0){
        UpdateColorClass('Red');
    }
    if(document.getElementsByClassName('Orange_Update').length > 0){
        UpdateColorClass('Orange');
    }
    if(document.getElementsByClassName('Blue_Update').length > 0){
        UpdateColorClass('Blue');
    }
    if(document.getElementsByClassName('Green_Update').length > 0){
        UpdateColorClass('Green');
    }

}