$(function() {

    $("#LastName").change(function() {
        var val = $("#LastName").val();
        debugger 
         val = isValid(val);

        if (!val) {

            $(this).addClass("notValid");

        } else {


            $(this).remove("class", "notValid");


        }


    });


});

function isValid(val) {


    return false;

}