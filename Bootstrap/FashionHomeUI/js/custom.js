$(document).on('ready',function(){
    $('.owl-carousel').owlCarousel({
        loop:true,
        margin:10,
        nav:true,
        dots: false,
        arrows: true,
        navText: ["<img src='images/prev-button.png'>", "<img src='images/next-button.png'>"],
        navClass: ['owl-prev', 'owl-next'],
        autoplay: false ,
        margin: 60 ,
        autoplayTimeout: false ,
        responsive:{
            0:{
                items:2
            },
            600:{
                items:3
            },
            1000:{
                items:4
            }
        }
    });
});

