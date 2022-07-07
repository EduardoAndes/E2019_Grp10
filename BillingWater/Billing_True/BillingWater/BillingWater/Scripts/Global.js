
function LoaderStart() {
    $("#mdLoader").modal({
        backdrop: "static",
        keyboard: false,
        show: true
    });
}

function LoaderEnd() {
    $('#mdLoader').modal('hide');
}
