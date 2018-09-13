$('[data-attr="submit"]').on('click', function () {
    $.ajax(
        {
            url: "/Record/Index",
            type: "POST",
            data: $('#StudentSearch').serialize(),
            success: function (response) {
                // console.log(response)
                $('#PartialView').hide()
                $('#PartialResultView').html("")
                $('#PartialResultView').html(response)

            },
            error: function (err) {
                // console.log(err)
            }
        });
});