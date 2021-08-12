// TODO: Remove this after Bootstrap 5.0 upgrade.
// Bootstrap 4 fix.
$(window).on('shown.bs.modal', function() {
  $("button[data-dismiss=modal]").click(function()
  {
    $(".modal").modal('hide');
  });
});

$(".sub-menu").mouseover(function () {
    $(this).find('.dropdown-menu').first().addClass('show')
})
$(".sub-menu").mouseout(function () {
    $(this).find('.dropdown-menu').first().removeClass('show')
})