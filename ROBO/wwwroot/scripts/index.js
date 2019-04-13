$(document).ready(function () {

    $.get("../api/robo", function (data) {

        $("#pulsoEsquerda").text(data.bracoEsquerdo.rotacao);
        $("#cotoveloEsquerda").text(data.bracoEsquerdo.cotovelo);
        $("#inclinacaoCabeca").text(data.cabeca.inclinacao);
        $("#rotacaoCabeca").text(data.cabeca.rotacao);

    });

    $("#btnAumentarInclinacaoCabeca").click(function () {
        var cabeca = {
            inclinacao: $("#inclinacaoCabeca").text(),
            rotacao: $("#rotacaoCabeca").text()
        };
        $.ajax({
            type: "POST",
            data: JSON.stringify(cabeca),
            url: "../InclinarCabeca?vetor=Positivo",
            contentType: "application/json",

        }).done(function (data) {
            $("#inclinacaoCabeca").text(data.inclinacao);
        });
    });

    $("#btnDiminuirInclinacaoCabeca").click(function () {
        var cabeca = {
            inclinacao: $("#inclinacaoCabeca").text(),
            rotacao: $("#rotacaoCabeca").text()
        };
        $.ajax({
            type: "POST",
            data: JSON.stringify(cabeca),
            url: "../InclinarCabeca?vetor=Negativo",
            contentType: "application/json",

        }).done(function (data) {
            $("#inclinacaoCabeca").text(data.inclinacao);
        });
    });

    $("#btnRotacaoNegativaCabeca").click(function () {
        var cabeca = {
            inclinacao: $("#inclinacaoCabeca").text(),
            rotacao: $("#rotacaoCabeca").text()
        };
        $.ajax({
            type: "POST",
            data: JSON.stringify(cabeca),
            url: "../RotacionarCabeca?vetor=Negativo",
            contentType: "application/json",

        }).done(function (data) {
            $("#rotacaoCabeca").text(data.rotacao);
        });

    });

    $("#btnRotacaoPositivaCabeca").click(function () {
        var cabeca = {
            inclinacao: $("#inclinacaoCabeca").text(),
            rotacao: $("#rotacaoCabeca").text()
        };
        $.ajax({
            type: "POST",
            data: JSON.stringify(cabeca),
            url: "../RotacionarCabeca?vetor=Positivo",
            contentType: "application/json",

        }).done(function (data) {
            $("#rotacaoCabeca").text(data.rotacao);
        });

    });

    $("#btnAumentarTensaoEsquerda").click(function () {
        var braco = {
            cotovelo: $("#cotoveloEsquerda").text(),
            rotacao: $("#pulsoEsquerda").text()
        };
        $.ajax({
            type: "POST",
            data: JSON.stringify(braco),
            url: "../TensionarBraco?vetor=Positivo",
            contentType: "application/json",

        }).done(function (data) {
            $("#cotoveloEsquerda").text(data.cotovelo);
        });

    });

    $("#btnDiminuirTensaoEsquerda").click(function () {
        var braco = {
            cotovelo: $("#cotoveloEsquerda").text(),
            rotacao: $("#pulsoEsquerda").text()
        };
        $.ajax({
            type: "POST",
            data: JSON.stringify(braco),
            url: "../TensionarBraco?vetor=Negativo",
            contentType: "application/json",

        }).done(function (data) {
            $("#cotoveloEsquerda").text(data.cotovelo);
        });

    });


    $("#btnAumentarTensaoDireita").click(function () {
        var braco = {
            cotovelo: $("#cotoveloDireita").text(),
            rotacao: $("#pulsoDireita").text()
        };
        $.ajax({
            type: "POST",
            data: JSON.stringify(braco),
            url: "../TensionarBraco?vetor=Positivo",
            contentType: "application/json",

        }).done(function (data) {
            $("#cotoveloDireita").text(data.cotovelo);
        });

    });

    $("#btnDiminuirTensaoDireita").click(function () {
        var braco = {
            cotovelo: $("#cotoveloDireita").text(),
            rotacao: $("#pulsoDireita").text()
        };
        $.ajax({
            type: "POST",
            data: JSON.stringify(braco),
            url: "../TensionarBraco?vetor=Negativo",
            contentType: "application/json",

        }).done(function (data) {
            $("#cotoveloDireita").text(data.cotovelo);
        });

    });

    $("#btnRotacaoPositivaEsquerda").click(function () {
        var braco = {
            cotovelo: $("#cotoveloEsquerda").text(),
            rotacao: $("#pulsoEsquerda").text()
        };
        $.ajax({
            type: "POST",
            data: JSON.stringify(braco),
            url: "../RotacionarBraco?vetor=Positivo",
            contentType: "application/json",

        }).done(function (data) {
            $("#pulsoEsquerda").text(data.rotacao);
        });
    });

    $("#btnRotacaoNegativaEsquerda").click(function () {
        var braco = {
            cotovelo: $("#cotoveloEsquerda").text(),
            rotacao: $("#pulsoEsquerda").text()
        };
        $.ajax({
            type: "POST",
            data: JSON.stringify(braco),
            url: "../RotacionarBraco?vetor=Negativo",
            contentType: "application/json",

        }).done(function (data) {
            $("#pulsoEsquerda").text(data.rotacao);
        });
    });


    $("#btnRotacaoPositivaDireita").click(function () {
        var braco = {
            cotovelo: $("#cotoveloDireita").text(),
            rotacao: $("#pulsoDireita").text()
        };
        $.ajax({
            type: "POST",
            data: JSON.stringify(braco),
            url: "../RotacionarBraco?vetor=Positivo",
            contentType: "application/json",

        }).done(function (data) {
            $("#pulsoDireita").text(data.rotacao);
        });
    });

    $("#btnRotacaoNegativaDireita").click(function () {
        var braco = {
            cotovelo: $("#cotoveloDireita").text(),
            rotacao: $("#pulsoDireita").text()
        };
        $.ajax({
            type: "POST",
            data: JSON.stringify(braco),
            url: "../RotacionarBraco?vetor=Negativo",
            contentType: "application/json",

        }).done(function (data) {
            $("#pulsoDireita").text(data.rotacao);
        });
    });

});