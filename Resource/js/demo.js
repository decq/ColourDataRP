
$('.dropdown_toggle').on('click', function(e) {
	$(e.target).parent().find('.dropdown_list').toggle()
})
