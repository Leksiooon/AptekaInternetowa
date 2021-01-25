function updatePlus() {
    tmp = parseInt(document.getElementById('ilosc').value);
    tmp2 = tmp + 1;

    if (tmp2 <= 50) {
        document.getElementById('ilosc').value = tmp2;
        document.getElementById('show').value = tmp2;
    }
}

function updateMinus() {
    tmp = parseInt(document.getElementById('ilosc').value);
    tmp2 = tmp - 1;
    if (tmp2 > 0) {
        document.getElementById('ilosc').value = tmp2;
        document.getElementById('show').value = tmp2;
    }
}