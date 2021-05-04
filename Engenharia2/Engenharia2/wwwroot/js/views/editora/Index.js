let indexEditora = {


    enviar: () => {

        let dados = {
            nome: document.getElementById("nome").value,
            descricao: document.getElementById("descricao").value,
            telefone: document.getElementById("telefone").value
        }
        HTTPClient.post("/CadastrarEditora/Gravar", dados)
            .then(result => {
                
                return result.json();
            })
            .then(dados => {
                if (dados.msg == "Falha ao Gravar Editora!") {
                    document.getElementById("gravou").innerHTML = "<div class='alert alert-danger alert-dismissible' role='alert'><button type='button' class='close' data-dismiss='alert' aria-label='Close'><span aria-hidden='true'>×</span></button><i class='fa fa-times-circle'></i> "+dados.msg+"!</div>";
                }
                else if (dados.msg == "Preencha Todos os Campos"){
                    document.getElementById("gravou").innerHTML = "<div class='alert alert-danger alert-dismissible' role='alert'><button type='button' class='close' data-dismiss='alert' aria-label='Close'><span aria-hidden='true'>×</span></button><i class='fa fa-times-circle'></i> " + dados.msg + "!</div>";
                }
                else
                    document.getElementById("gravou").innerHTML = "<div class='alert alert-success alert-dismissible' role='alert'><button type='button' class='close' data-dismiss='alert' aria-label='Close'><span aria-hidden='true'>×</span></button><i class='fa fa-check-circle'></i> " + dados.msg + "</div>";
            })
            .catch(() => {
                console.log("Falha ao Gravar");
            });
        document.getElementById("txtNome").value = "";
        document.getElementById("selCategoria").value = "";
    },

    obterCategorias: () => {

        HTTPClient.get("/Produto/ObterCategorias")
            .then(result => {
                return result.json();
            })
            .then(dados => {
                indexProduto.preencherCategorias(dados);
            })
            .catch(() => {
                alert("Não foi possível obter as categorias.");
            })

    },

    preencherCategorias: (dados) => {
        
        let selCategoria = document.getElementById("selCategoria")

        //abordagem 1
        let opts = "<option></option>";

        for (let i = 0; i < dados.length; i++) {

            opts += `<option value="${dados[i].id}">${dados[i].nome}</option>`;
        }

        selCategoria.innerHTML = opts;

        //abordagem 2
        //for (let i = 0; i < dados.length; i++) {

        //    let opt = document.createElement("option");
        //    opt.value = dados[i].id;
        //    opt.innerHTML = dados[i].nome;
        //    selCategoria.appendChild(opt);
        //}


    }
}


document.addEventListener("DOMContentLoaded", () => {

    

});

