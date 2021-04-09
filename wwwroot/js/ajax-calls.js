//Batteries product page AJAX call
var bat = new XMLHttpRequest();
bat.onreadystatechange = function () {
    if (this.readyState == 4 && this.status == 200) {
        var batteries = JSON.parse(bat.responseText);
        var numberbats = batteries.length;
        var allBatteries = '';
        for (var i in batteries) {
            allBatteries += '<tr>';
            allBatteries += '<td>' + batteries[i].id + '</td>';
            allBatteries += '<td>' + batteries[i].buildingId + '</td>';
            allBatteries += '<td>' + batteries[i].batteryType + '</td>';
            allBatteries += '<td>' + batteries[i].batteryStatus + '</td>';
            allBatteries += '<td>' + batteries[i].certificateOfOperations + '</td>';
            allBatteries += '<td>' + batteries[i].dateOfCommissioning + '</td>';
            allBatteries += '<td>' + batteries[i].dateOfLastInspection + '</td>';
            allBatteries += '<td>' + batteries[i].information + '</td>';
            allBatteries += '<td>' + batteries[i].updatedAt + '</td></tr>';
        }
        document.getElementById('batteriesData').innerHTML = allBatteries;
        document.getElementById('total-bat').innerHTML = numberbats;
    }
};
bat.open('GET', 'https://donnguyen.herokuapp.com/api/Batteries');
bat.send();



//Columns product page AJAX call
var col = new XMLHttpRequest();
col.onreadystatechange = function () {
    if (this.readyState == 4 && this.status == 200) {
        var columns = JSON.parse(col.responseText);
        var numberColumns = columns.length;
        var allColumns = '';
        for (var i in columns) {
            allColumns += '<tr>';
            allColumns += '<td>' + columns[i].id + '</td>';
            allColumns += '<td>' + columns[i].batteryId + '</td>';
            allColumns += '<td>' + columns[i].columnType + '</td>';
            allColumns += '<td>' + columns[i].columnStatus + '</td>';
            allColumns += '<td>' + columns[i].numberOfFloorsServed + '</td>';
            allColumns += '<td>' + columns[i].information + '</td>';
            allColumns += '<td>' + columns[i].createdAt + '</td>';
            allColumns += '<td>' + columns[i].updatedAt + '</td></tr>';
        }
        document.getElementById('columnsData').innerHTML = allColumns;
        document.getElementById('total-col').innerHTML = numberColumns;
    }
};
col.open('GET', 'https://donnguyen.herokuapp.com/api/Columns');
col.send();



//Elevators product page AJAX call
var elev = new XMLHttpRequest();
elev.onreadystatechange = function () {
    if (this.readyState == 4 && this.status == 200) {
        var elevators = JSON.parse(elev.responseText);
        var numberElevators = elevators.length;
        var allElevators = '';
        for (var i in elevators) {
            allElevators += '<tr>';
            allElevators += '<td>' + elevators[i].id + '</td>';
            allElevators += '<td>' + elevators[i].columnId + '</td>';
            allElevators += '<td>' + elevators[i].serialNumber + '</td>';
            allElevators += '<td>' + elevators[i].elevatorModel + '</td>';
            allElevators += '<td>' + elevators[i].elevatorType + '</td>';
            allElevators += '<td>' + elevators[i].elevatorStatus + '</td>';
            allElevators += '<td>' + elevators[i].dateOfCommissioning + '</td>';
            allElevators += '<td>' + elevators[i].dateOfLastInspection + '</td>';
            allElevators += '<td>' + elevators[i].certificateOfInspection + '</td>';
            allElevators += '<td>' + elevators[i].createdAt + '</td>';
            allElevators += '<td>' + elevators[i].updatedAt + '</td></tr>';
        }
        document.getElementById('elevatorsData').innerHTML = allElevators;
        document.getElementById("total-elev").innerHTML = numberElevators;
        document.getElementById("total-elev").innerHTML = 'hola';
    }
};
elev.open('GET', 'https://donnguyen.herokuapp.com/api/Elevators');
elev.send();