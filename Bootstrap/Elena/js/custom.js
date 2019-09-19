$(document).on('ready',function(){
    $('.owl-carousel').owlCarousel({
        loop:true,
        margin:10,
        nav:false,
        autoplay: true ,
        margin: 60 ,
        autoplayTimeout: 2000 ,
        responsive:{
            0:{
                items:3
            },
            600:{
                items:4
            },
            1000:{
                items:4
            }
        }
    });
});