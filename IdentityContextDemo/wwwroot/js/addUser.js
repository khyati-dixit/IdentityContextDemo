
$(document).ready(function () {

    $("#btnAdd").click(function () {
        $.ajax({
            url: '/Book/Insert',
            type: 'POST',
            data: {
                FullName: $("#AName").val(),
                UserEmail: $("#ALat").val(),
                success: function (data) {
                    location.reload();
                }
                }
            });

        });
    });
