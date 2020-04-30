

function postQuestion() {
    var askedQuestions = {
        RootQuestionName: document.getElementById('rootQuestionInput').value,
        SubQuestionNames: []

    }

    var subQuestions = document.getElementsByClassName('subQuestionInput');
    for (var i = 0; i < subQuestions.length; i++) {
        askedQuestions.SubQuestionNames.push(subQuestions.item(i).value);
    }

    askedQuestions.SubQuestionNames.push("Final Decision");

    $.ajax({
        type: "POST",
        url: "/api/Question/add",
        dataType: 'json',
        contentType: 'application/json',
        success: function (response) {
            $(':input').val('');
        },
        data: JSON.stringify(askedQuestions)
    });
}

function addSubQuestion() {
    var element = '<div class="ml-3"><div class="col-md-11"><input class="subQuestionInput form-control" type="text" name="question" placeholder="Type your Question Here" maxlength="255" /></div ><button class="btn btn-danger">&#10005;</button></div><br />'
    $(element).appendTo("#subQuestions");
}

function deleteQuestionInfo(id) {
    $.ajax({
        type: "POST",
        url: "/api/Question/delete/" + id,
        dataType: 'json',
        contentType: 'application/json',
        //success: function (response) {
        //    $(':input').val('');
        //},
        data: null
    });
}

function getJsonForTree(rootId) {
    //window.alert("Getting tree data id:" + rootId)
    var d = 0;
    
    $.ajax({
        type: "GET",
        url: "/api/Question/tree/" + rootId,
        success: function (data) {
            console.log(data);
            return data;
            //d = data;
        }
    });
    //return d;
}

function answerQuestion(rootId, sid, value) {
    //window.alert(rootId + "\n" + sid + "\n" + value);
    $.ajax({
        type: "POST",
        url: "/api/Question/answer/" + rootId + "/" + sid + "/" + value,
        dataType: 'json',
        contentType: 'application/json',
        data: null
    });
}

function updateGraph(id) {
    $.ajax({
        type: "POST",
        url: "/api/Question/update/" + id,
        dataType: 'json',
        contentType: 'application/json',
        data: null
    });
}

function getNumAnswers(id, fun) {
    var num = 1
    num = $.ajax({
        type: "GET",
        url: "/api/question/" + id,
        success: function (data) {
            fun(id, data.answeredSubQuestions[0].answers.length);
        }
    });
   
 }

function getUserQuestionSet(id) {
    $.ajax({
        type: "GET",
        url: "/api/question/" + id,
        success: function (data) {
            document.getElementById('collapse-' + id).innerHTML = '';
            //document.getElementById('collapse-' + id).innerText = JSON.stringify(data);
            var subQuestions = data.answeredSubQuestions;
            subQuestions.forEach(function (item) {
                var subQuestion = item.subQuestion;
                document.getElementById('collapse-' + id).innerHTML +=
                    '<p>' + subQuestion.name +
                    '<div class="m-3"><input class="form-check-input m-3" type="radio" name="y' + subQuestion.id + '" id="y' + subQuestion.id + '" value="option1" checked>' +
                    '<label class="form-check-label m-3 p-3" for="y' + subQuestion.id + '">Yes</label></div>' +
                    '<div class="m-3"><input class="form-check-input m-3" type="radio" name="y' + subQuestion.id + '" id="y' + subQuestion.id + '" value="option1">' +
                    '<label class="form-check-label m-3" for="y' + subQuestion.id + '">No</label></div><br />' + '</p>';
            });
            document.getElementById('collapse-' + id).innerHTML += '<button class="btn btn-success" onclick="">Submit</button><br/><br/>';
        }
    });
}