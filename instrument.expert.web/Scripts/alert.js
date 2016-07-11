function confirmMsg(btntext1, btntext2, msg, btntext2callback) {
    var panel = "<div id=\"alertTool\"><label>" + msg + "</label></div>";
    $("#alertTool").remove();
    $("body").append(panel);
    $("#alertTool").dialog({
        title: "<span class=\"glyphicon glyphicon-info-sign\"></span> 提示信息",
        backdrop: "static",
        onClose: function() {
            $(this).dialog("close");
        },
        dialogClass: "modal-sm",
        buttons: [
            {
                text: btntext1,
                'class': "btn-info glyphicon glyphicon-remove-sign",
                click: function() {
                    $(this).dialog("close");
                }
            },
            {
                text: btntext2,
                'class': "btn-success glyphicon glyphicon-ok-sign",
                click: function() {
                    $(this).dialog("close");
                    if (btntext2callback != null) {
                        btntext2callback();
                    }
                }
            }
        ]
    });
}

function alertMsg(btntext1, msg, btntext1callback) {
    var panel = "<div id=\"alertTool\"><label>" + msg + "</label></div>";
    $("#alertTool").remove();
    $("body").append(panel);
    $("#alertTool").dialog({
        title: "提示信息",
        dialogClass: "modal-sm",
        backdrop: "static",
        onClose: function() {
            $(this).dialog("close");
        },
        buttons: [
            {
                text: btntext1,
                'class': "btn-success glyphicon glyphicon-ok",
                click: function() {
                    $(this).dialog("close");
                    if (btntext1callback != null) {
                        btntext1callback();
                    }
                }
            }
        ]
    });
}