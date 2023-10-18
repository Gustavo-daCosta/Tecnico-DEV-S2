const somar = function name(x, y) {
    return x + y;
};

// console.log(somar(50, 10));

const triplo = (numero) => numero * 3;
const dobro = (numero) => {
    return numero * 2
}

console.log(triplo(10));
console.log(dobro(10));

const boaTarde = () => { console.log("Boa Tarde!"); }
boaTarde();

const convidados = [
    "Carlos",
    "Claiton",
    "Rebeca",
    "Magalhães",
    "Guilherme Henrique",
];

convidados.forEach(convidado => {
    console.log(`Convidade: ${convidado}`);
})
