// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(window).load(function () {
    $("body").removeClass("preload");
});

function openCertificate(certificateAddress) {
    window.open(certificateAddress);
}

//var cw = $('.item-div img').height();
//$('.item-div img').css({
//    'width': cw + 'px'
//});