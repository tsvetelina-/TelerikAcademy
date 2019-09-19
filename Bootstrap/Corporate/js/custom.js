// $(document).on('ready',function(){

// 	jQuery(".modal-backdrop, #myModal .close, #myModal .btn").live("click", function() {
//         jQuery("#myModal iframe").attr("src", jQuery("#myModal iframe").attr("src"));
// 	});

// });


$("#myModal").on('hidden.bs.modal', function (e) {
	$("#myModal iframe").attr("src", $("#myModal iframe").attr("src"));
});