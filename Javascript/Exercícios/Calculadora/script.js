function calcular() {
    event.preventDefault();
    let n1 = parseFloat(document.getElementById("numero1").value);
    let n2 = parseFloat(document.getElementById("numero2").value);
    let op = document.getElementById("operacao").value;
    let res; // undefined

    // Verifica se os valores foram preenchidos
    if (isNaN(n1) || isNaN(n2)) {
        alert("Preencha todos os campos!");
        return;
    }

    switch (op) {
        case "+":
            res = somar(n1, n2);
            break;
        case "-":
            res = subtrair(n1, n2);
            break;
        case "*":
            res = multiplicar(n1, n2);
            break;
        case "/":
            res = n2 != 0 ? dividir(n1, n2) : "Impossível dividir por zero (0)";
            break;
        default:
            res = "Operação inválida";
    }

    // Mostra o resultado da conta no site
    document.getElementById("resultado").innerText = res;
}

function somar(x, y) {
    return x + y;
}

function subtrair(x, y) {
    return x - y;
}

function multiplicar(x, y) {
    return x * y;
}

function dividir(x, y) {
    return (x / y).toFixed(2);
}