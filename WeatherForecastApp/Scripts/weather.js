
$(document).ready(function () {
    LoadWeatherPartial();
    var interval = $('#refreshInterval').text();
    SetRefreshTimer(interval);

    $('input:radio').change(function () {
               LoadWeatherPartial();
    });

    $("#woeidButton").click(function () {
        LoadWeatherPartial();
    });
});

function SetRefreshTimer(interval) {
    setInterval(function () {
        LoadWeatherPartial();
    }, interval);
}

function LoadWeatherPartial() {
    var api = '/Weather/GetWeatherPartial/' + $('[name="woeidInput"]').val() + '/' + $('input:radio[name=temperatureUnits]:checked').val();
    $.ajax({
        url: api,
        datatype: 'html',
        success: function (data) {
            $('#showdata').empty().html(data);
            $('#lastRefresh').text((new Date).toString());
        },
        error: function (data) {
            $('#showdata').empty().html(data);
        }
    });
}



// not required
//function LoadWeather(url) {
//    $.getJSON(url, function (data) {
//        $.each(data.channel, function (item) {
//            $('#showdata').empty().html(data.channel[item].item[0].description);
//        }
//        );

//    });
//}

