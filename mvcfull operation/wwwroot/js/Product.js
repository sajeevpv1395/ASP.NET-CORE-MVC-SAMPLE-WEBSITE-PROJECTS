//Save
$(document).on('click', "#btnSave", function () {
    if (!EmptyFieldValidation()) {
        $("#addField .error-message").text('Please fill the required fields...');
        $("#addField .error-message").show();
        return false;
    }
    $("#overlay").show();
    var PostData = {
        FieldId: fieldId,
        CustomerId: $("#customerId").val(),
        SheetName: $("#sheetname").val(),
        TableName: $("#tablename").val(),
        FieldName: $("#fieldname").val(),
        IsActive: $("#IsActive").is(":checked"),
        YearId: $("#yearId").val(),
    }

    $.ajax({
        type: "POST",
        url: baseUrl + "FieldManagement/InsertUpdateFields",
        data: PostData,
        beforeSend: function () {
            $("#overlay").show();
        },
        complete: function () {
            $("#overlay").hide();
        },
        success: function (result) {
            var response = JSON.parse(result);
            $("#overlay").hide();
            if (response.Item1 !== "") {
                if (response.Item1 == 2)
                    swal("", response.Item2, "warning").then((value) => {
                    });
                else if (response.Item1 == 1) {
                    $("#addField").modal('hide');
                    ClearFields();
                    swal("", response.Item2, "success").then((value) => {
                        $(".modal-backdrop").remove()
                    });
                }
                else if (response.Item1 == 4)
                    swal({
                        title: response.Item2,
                        icon: "warning",
                        dangerMode: true,
                        buttons: ['NO', 'YES']
                    })
                        .then((willUpdate) => {
                            if (willUpdate) {
                                ConfirmedStarFieldUpdate(PostData);
                            }
                        });

                else if (response.Item1 == 3)
                    swal("", response.Item2, "error").then((value) => {
                    });
                else if (response.Item1 == -1)
                    swal("", response.Item2, "error").then((value) => {
                    });
                else
                    swal("", response.Item2, "error").then((value) => {
                    });
            }
            FieldDataTableGrids.ajax.reload();
            $("#overlay").hide();
        },
        error: function (response) {
            $("#overlay").hide();
            $("#addField").modal('hide');
            ClearFields();
        }
    });
});

function ConfirmedStarFieldUpdate(data) {
    $.ajax({
        type: "POST",
        url: baseUrl + "FieldManagement/UpdateStarFields",
        data: data,
        beforeSend: function () {
            $("#overlay").show();
        },
        complete: function () {
            $("#overlay").hide();
        },
        success: function (result) {
            var response = JSON.parse(result);
            $("#overlay").hide();
            if (response.Item1 !== "") {
                if (response.Item1 == 1) {
                    $("#addField").modal('hide');
                    ClearFields();
                    swal("", response.Item2, "success").then((value) => {
                        $(".modal-backdrop").remove()
                    });
                }
                else if (response.Item1 == 3)
                    swal("", response.Item2, "error").then((value) => {
                    });

                else
                    swal("", response.Item2, "error").then((value) => {
                    });
            }
            FieldDataTableGrids.ajax.reload();
            $("#overlay").hide();
        },
        error: function (response) {
            $("#overlay").hide();
            $("#addField").modal('hide');
            ClearFields();
        }
    });
}

