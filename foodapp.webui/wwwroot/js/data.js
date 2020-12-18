

$(document).ready(function () {
    var notification;
    
    
    $.ajax({
        type: "GET",
        url: "/cart",
        success: function (response) {
            if (response.match(/productInCart/gm)==null) {
                $("#notification").css("display", "none");
            }else{
                $("#notification").css("display", "inline");
            notification = response.match(/productInCart/gm).length;
            $("#notification").html(notification);
            }
            
            
            
        }
    });

});
   
          

