function postQuestion() {
    $.ajax({
        type: "POST",
        url: "http://localhost:50337/Question",
        data: JSON.stringify(document.getElementById("questionValue").value),
        dataType: 'json',
        contentType: 'application/json',
        success: function (response) {
        }
    });
}