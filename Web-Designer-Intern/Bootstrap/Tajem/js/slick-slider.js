$(".image-slick").slick({
	accessibility: true,
	// autoplay: true,
	cssEase: 'ease',
	slidesToShow: 5,
	slidesToScroll: 5,
	dots: false,
	mobileFirst: true,
	centerMode: true,
	responsive: [{
		breakpoint: 1200,
		settings: {
			slidesToShow: 5,
			slidesToScroll: 5,
			centerPadding: '0px',
		}
	},
	{
		breakpoint: 891,
		settings: {
			slidesToShow: 3,
			slidesToScroll: 5,
			centerPadding: '5px'
		}
	},
	{
		breakpoint: 768,
		settings: {
			slidesToShow: 3,
			slidesToScroll: 5,
			centerPadding: '0px'
		}
	},
	{
		breakpoint: 690,
		settings: {
			slidesToShow: 3,
			centerPadding: '5px'
		}
	},
	{
		breakpoint: 375,
		settings: {
			slidesToShow: 1,
			centerPadding: '0px'
		}
	},
	{
		breakpoint: 200,
		settings: {
			slidesToShow: 1,
			centerPadding: '0px'
		}
	}

	]
});