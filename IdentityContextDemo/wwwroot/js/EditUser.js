function EditUserDetails(id) {
    debugger;
    $.ajax({
        url: '/Book/Edit?Id=' + id,
        type: 'GET',
        dataType: 'json',
        contentType: 'application/json',
        async: true,
        success: function (data) {
            debugger;
            console.log(data);
            $("#AId0").val(data.data.userId);
            $("#AName0").val(data.data.fullName);
            $("#ALat0").val(data.userEmail);
           
            }
    });
}


$(document).ready(function () {
    debugger;
    $("#btnEdit").click(function () {
        $.ajax({
            url: '/Book/Edit',
            type: 'POST',
            data: {
                UserId: $("#AId0").val(),
                FullName: $("#AName0").val(),
                UserEmail: $("#ALat0").val(),
                // Address: Address,
                //CivilIdNumber: civilIdNumber,
            },
                success: function (data) {
                    location.reload();
                }
            
        });
    });
 });
