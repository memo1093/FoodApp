// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.



// Write your JavaScript code.
var x = window.matchMedia("(max-width: 700px)");
if (x.matches) {
    $("#hideOnSmall").hide(); 
}
$('.product-card').on('click',function(){$('.collapse').collapse('hide');})


$(function () {
    
    $('[data-toggle="tooltip"]').tooltip()
  });

  
      




  
  
