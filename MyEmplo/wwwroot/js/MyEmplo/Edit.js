$(document).ready(function () {

    LoadMyEmploServices();


    $("#createMyEmploServiceModal form").submit(function (event) {
        event.preventDefault();

        $.ajax({
            url: $(this).attr('action'),
            type: $(this).attr('method'),
            data: $(this).serialize(),
            success: function (data) {
                toastr["success"]("Add new employees services")
                LoadMyEmploServices();
            },
            error: function () {
                toastr["error"]("Coœ posz³o Ÿle")
            }
        })
    });
