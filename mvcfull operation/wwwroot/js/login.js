$(document).ready(function () {
    var baseUrl = $("#baseurl").val();
    alert("login page");
    //Save
    $("#btnSave").click(function (e) {
        if ($("#Email").val() == '')
            alert("email name  is null");
        var PostData = {
            Email: $("#Email").val(),
            Password: $("#Password").val()
            
        }

        $.ajax({
            type: "POST",
            url: "/Login/SaveLogin",
            data: PostData,
            success: function (result) {
                if (result.Item1 !== "") {
                    if (result.Item1 == 2)
                        swal("", response.Item2, "warning").then((value) => {
                        });
                    else if (response.Item1 == 1) {
                        swal("", response.Item2, "success").then((value) => {
                        });
                    }

                }
            },
            error: function (response) {
            }
        });
    });
});