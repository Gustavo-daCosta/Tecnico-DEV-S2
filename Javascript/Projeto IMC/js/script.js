let usuarios = new Array();

function calcular() {
    event.preventDefault();
    let nome = document.getElementById('nome').value.trim();
    let altura = parseFloat(document.getElementById('altura').value);
    let peso = parseFloat(document.getElementById('peso').value);

    const imc = peso / Math.pow(altura, 2);
    let classificacao = gerarClassificacao(imc);

    if (isNaN(altura) || isNaN(peso) || nome.length < 2) {
        alert('Preencha todos os campos antes de cadastrar!');
        return;
    }

    let now = new Date();
    let usuario = {
        nome,
        altura: altura.toFixed(2),
        peso: peso.toFixed(0),
        imc: imc.toFixed(2),
        classificacao: classificacao,
        dataCadastro: `${now.getDate()}/${now.getMonth() + 1}/${now.getFullYear()} ${now.getHours()}:${now.getMinutes()}`,
    };

    adicionarRegistro(usuario);
    limparFormulario();
}

function gerarClassificacao(imc) {
    let classificacao;

    if (imc < 16.9) {
        classificacao = "Muito abaixo do peso";
    } else if (imc < 18.4) {
        classificacao = "Abaixo do peso";
    } else if (imc < 24.9) {
        classificacao = "Peso normal";
    } else if (imc < 29.9) {
        classificacao = "Acima do peso";
    } else if (imc < 34.9) {
        classificacao = "Obesidade grau I";
    } else if (imc < 40) {
        classificacao = "Obesidade grau II";
    } else {
        classificacao = "Obesidade grau III";
    }

    return classificacao;
}

function adicionarRegistro(usuario) {
    usuarios.push(usuario);
    exibirDados();
}

function exibirDados() {
    var listaUsuarios = document.getElementById('corpo-tabela');
    listaUsuarios.innerHTML = '';

    usuarios.forEach(function (usuario) {
        var row = document.createElement('tr');
        var properties = ["nome", "altura", "peso", "imc", "classificacao", "dataCadastro"];
        properties.forEach(function(property) {
            var cell = document.createElement('td');
            cell.setAttribute('data-cell', property);
            cell.textContent = usuario[property];
            row.appendChild(cell);
        });
        listaUsuarios.appendChild(row);
    });
}

function limparFormulario() {
    document.getElementById('nome').value = '';
    document.getElementById('altura').value = '';
    document.getElementById('peso').value = '';
}

function deletarRegistros() {
    usuarios = [];
    document.getElementById('corpo-tabela').innerHTML = '';
}
