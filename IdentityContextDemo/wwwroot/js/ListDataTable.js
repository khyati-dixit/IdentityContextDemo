$(document).ready(function () {
    debugger;
    $('#dataTable').DataTable({
        "processing": true,
        "serverSide": true,
        "filter": true,
        "ajax": {
            "url": '/Book/GetAllBooks',
            "type": "GET",
            "datatype": "json"
        },

        "columns": [
            { "data": "UserId" },
            { "data": "FullName" },
            { "data": "UserEmail" },
            { "data": "" },
            { "data": "" },
        ]
    });
});