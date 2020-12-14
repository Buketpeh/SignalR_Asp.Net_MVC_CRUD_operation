//import { get } from "jquery";

var hub = $.connection.NotifyClients;
hub.client.updatedClients = function () {
    FetchVehicles();
}

$.connection.hub.start().done(function () {
    FetchVehicles();
});

function FetchVehicles() {
     var model = $('#myTable');
    $.ajax({
        url: '/home/Index',
        contentType: 'application/html; charset:utf-8',
        type: 'GET',
        dataType: 'html',
        success: function (result){ model.empty().append(result); }

    })
}
function CreateVehicle() {
    var vehicle = {
        plaka: $('#carplate').val(),
        model: $('#carmodel').val(),
        marka: $('#carbrand').val(),
        fiyat: $('#carprice').val(),
        yas: $('#carage').val()
    }
    $.ajax({
        url: '/Home/Create',
        type: 'POST',
        data: JSON.stringify(vehicle),
        contentType: "application/json;charset=utf-8",
        success: function (data) {
            alert('Employee added Succesfuly');
            
        },
        error: function () {
            alert('Employee not added');
        }
    })
};