let indexLivro = {


    enviar: () => {
        document.getElementById("gravando").innerHTML = "Gravando... Aguarde!";
        let dados = {
            nome: document.getElementById("nome").value,    
            editora: document.getElementById("editoraId").value,            
            autor: document.getElementById("autorId").value,
            qtd: document.getElementById("qtd").value
        }
        HTTPClient.post("/CadastrarLivro/Gravar", dados)
            .then(result => {
                return result.json();
            })
            .then(dados => {
                if (dados.msg == "Falha ao Gravar Livro!") {
                    document.getElementById("gravou").innerHTML = "<div class='alert alert-danger alert-dismissible' role='alert'><button type='button' class='close' data-dismiss='alert' aria-label='Close'><span aria-hidden='true'>×</span></button><i class='fa fa-times-circle'></i> " + dados.msg + "!</div>";
                }
                else if (dados.msg == "Preencha Todos os Campos") {
                    document.getElementById("gravou").innerHTML = "<div class='alert alert-danger alert-dismissible' role='alert'><button type='button' class='close' data-dismiss='alert' aria-label='Close'><span aria-hidden='true'>×</span></button><i class='fa fa-times-circle'></i> " + dados.msg + "!</div>";
                }
                else
                    document.getElementById("gravou").innerHTML = "<div class='alert alert-success alert-dismissible' role='alert'><button type='button' class='close' data-dismiss='alert' aria-label='Close'><span aria-hidden='true'>×</span></button><i class='fa fa-check-circle'></i> " + dados.msg + "</div>";
            })
            .catch(() => {
                console.log("Falha ao Gravar");
            });
        document.getElementById("gravando").innerHTML = "";
    },

}