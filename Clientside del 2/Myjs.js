function onload() {
    Setsideclass('White');
    Setsideclass('Yellow');
    Setsideclass('Blue');
    Setsideclass('Green');
    Setsideclass('Red');
    Setsideclass('Orange');
    updatecube();

}
var number = 0;
var ColorSelected;
var cubesX = [-22, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0];
var cubesY = [-28, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0];
var cubesZ = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0];
var WYCLASS = ['Blue', 'Orange', 'Green', 'Red'];
var ROCLASS = ['Blue', 'White', 'Green', 'Yellow'];
var BGCLASS = ['White', 'Orange', 'Yellow', 'Red'];
function rotate(classname, amount) {
    number = document.getElementsByClassName(classname).length;
    while (number > 0) {
        number -= 1;
        var cubenr = document.getElementsByClassName(classname)[number].getAttribute('id').slice(4, 8);
        document.getElementById('test').innerHTML = classname + ' ' + cubenr + ' ' + number;
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
    number = document.getElementsByClassName(classname).length;
    while (number > 0) {
        number -= 1;
        var mom = document.getElementsByClassName(classname)[number].parentElement.parentElement;
        if (mom.getAttribute('id') != null) {
            if (mom.getAttribute('id').slice(0, 4) == 'Cube') {
                mom.classList.add(classname + '_Side');
            }
        }
    }

}
function UpdateColorClass(classname) {
    number = document.getElementsByClassName(classname + '_Update').length;
    while (number > 0) {
        number -= 1;
        document.getElementsByClassName(classname + '_Update')[number].classList.add(classname + '_Side');
        document.getElementsByClassName(classname + '_Update')[number].classList.remove(classname + '_Update');
    }

}
function updatecube() {
    var i = 1;
    while (i < 27) {
        document.getElementById("Cube" + i).style.transform = 'RotateX(' + cubesX[i] + 'deg) RotateY(' + cubesY[i] + 'deg) RotateZ(' + cubesZ[i] + 'deg)'
        i += 1;
    }

    if (document.getElementsByClassName('White_Update').length > 0) {
        UpdateColorClass('White');
    }
    if (document.getElementsByClassName('Yellow_Update').length > 0) {
        UpdateColorClass('Yellow');
    }
    if (document.getElementsByClassName('Red_Update').length > 0) {
        UpdateColorClass('Red');
    }
    if (document.getElementsByClassName('Orange_Update').length > 0) {
        UpdateColorClass('Orange');
    }
    if (document.getElementsByClassName('Blue_Update').length > 0) {
        UpdateColorClass('Blue');
    }
    if (document.getElementsByClassName('Green_Update').length > 0) {
        UpdateColorClass('Green');
    }

}
function UpdateMainCube() {
    document.getElementById("RubriksCube").style.transform = 'RotateX(' + cubesX[0] + 'deg) RotateY(' + cubesY[0] + 'deg) RotateZ(' + cubesZ[0] + 'deg)'
}
function RotateButton(val) {
    rotate(ColorSelected + '_Side', val);
}

function SelectColor(color) {
    if (document.getElementsByClassName('Color_Selected').length > 0) {
        document.getElementsByClassName('Color_Selected')[0].classList.remove('Color_Selected');
    }
    ColorSelected = color.getAttribute('class');
    color.classList.add('Color_Selected');
    document.getElementById('test').innerHTML = ColorSelected + '_Side';
}