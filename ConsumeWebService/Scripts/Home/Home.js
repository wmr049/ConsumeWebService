var ambiente = null;

function getValues() {
    this.chave1 = $("#chave1").val();
    this.valor1 = $("#valor1").val();
    this.chave2 = $("#chave2").val();
    this.valor2 = $("#valor2").val();
    this.chave3 = $("#chave3").val();
    this.valor3 = $("#valor3").val();
    this.chave4 = $("#chave4").val();
    this.valor4 = $("#valor4").val();
    this.chave5 = $("#chave5").val();
    this.valor5 = $("#valor5").val();
    this.chave6 = $("#chave6").val();
    this.valor6 = $("#valor6").val();
    this.chave7 = $("#chave7").val();
    this.valor7 = $("#valor7").val();
    this.chave8 = $("#chave8").val();
    this.valor8 = $("#valor8").val();
}

$("#btnExecute").click(function () {

    var requisicao = new getValues();

    $.ajax({
        url: document.URL + "/Home/KeyValue",
        type: 'POST',
        data: JSON.stringify(requisicao),
        contentType: 'application/json; charset=utf-8',
        success: function (data) {
            if (data) {
                $("#resultado").text(data.status.msg);
            }
        },
        error: function () { 
        }
    });
})