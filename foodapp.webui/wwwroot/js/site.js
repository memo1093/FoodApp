// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.



// Write your JavaScript code.
$(document).ready(function () {
    var large = window.matchMedia("(max-width: 1024px)");
    if (large.matches) {
    
        $(".card-horizontal").removeAttr("class");//+
        
        
        
        $(".changingImage").removeClass("img-fluid");
        $(".changingImage").addClass("img-top");
        $(".changingImage").attr("style","width:100%;");
    
    }

    var medium = window.matchMedia("(max-width: 768px)");
    if (medium.matches) {
    
        
    
    }

    
    
    var small = window.matchMedia("(max-width: 576px");
    if (small.matches) {
        $(".hideOnSmall").hide(); 
        
        
        
    }
    
});

$('.product-card').on('click',function(){$('.collapse').collapse('hide');})



$(function () {
    
    $('[data-toggle="tooltip"]').tooltip()
});

  
      
function isNumber(evt) {
    evt = (evt) ? evt : window.event;
    var charCode = (evt.which) ? evt.which : evt.keyCode;
    if (charCode > 31 && (charCode < 48 || charCode > 57)) {
        return false;
    }
    return true;
}








  
  
