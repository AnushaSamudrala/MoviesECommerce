$('#addToCart').click(function (movie) { //On click of your button
//function AddToCart(movie){
    debugger;
    //var property1 = $('#property1Id').val(); //Get the values from the page you want to post
    //var property2 = $('#property2Id').val();


    //var JSONObject = { // Create JSON object to pass through AJAX
    //    Property1: property1, //Make sure these names match the properties in VM
    //    Property2: property2
    //};

    //$.ajax({ //Do an ajax post to the controller
    //    type: 'POST',
    //    url: './Cart/Create',
    //    data: JSON.stringify(movie),
    //    //contentType: "application/json; charset=utf-8",
    //    dataType: "json"
    //});
    var data = { playlistId = 1, songId = 1 };
    $.ajax({
        type: "POST",
        url: https://localhost:44357/Cart/AddToCart/',
        data: movie,
        success: function (resultData) {
            debugger;
            // take the result data and update the div
         //   $("#playlistDiv").append(resultData.html)
        },
        dataType: dataType
    });
    });

};

