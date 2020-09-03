var dataTable;

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#DT_Load').DataTable({
        "ajax": {
            "url": "/admin/getall",
            "type": "GET",
            "datatype": "json"
        },
        "columns": [
            { "data": "firstName", "width": "15%" },
            { "data": "middleName", "width": "15%" },
            { "data": "lastName", "width": "15%" },
            { "data": "email", "width": "20%" },
            { "data": "dateOfBirth", "width": "15%" },
            {
                "data": "id",
                "render": function (data) {
                    return `<div class="text-center">
                            <a href="/Admin/Upsert?id=${data}" class='btn btn-success text-white' style='cursor:pointer; width:70px;'>Edit</a>
                            &nbsp;
                            <a class='btn btn-danger text-white' style='cursor:pointer; width:70px;' onclick=Delete('/admin/Delete?id='+${data})>Delete</a>
                            </div>`;
                }, "width": "30%"
            }
        ],
        "language": {
            "emptyTable": "no data found"
        },
        "width": "100%"
    })
}

function Delete(url) {
    swal({
        title: "Are you sure?",
        text: "Once delete, you cannot recover",
        icon: "warning",
        buttons: true,
        dangerMode: true
    }).then((willDelete) => {
        if (willDelete) {
            $.ajax({
                type: "DELETE",
                url: url,
                success: function (data) {
                    if (data.success) {
                        toastr.success(data.message);
                        dataTable.ajax.reload();
                    }
                    else {
                        toastr.error(data.message);
                    }
                }
            });
        }
    });
}