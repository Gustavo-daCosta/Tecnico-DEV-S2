const numeros = [1, 2, 3, 4, 5, 10, 300];

const dobro = numeros.map( (n) => n * 2);

// console.log(numeros);
// console.log(dobro);

const pares = numeros.filter( (n) => n % 2 === 0);

// console.log(`Valor pares: ${pares}`)

const comentarios = [
    { comentario: "bla bla bla", exibe: true },
    { comentario: "Evento foi uma", exibe: false },
    { comentario: "Ótimo evento!", exibe: true },
]

const comentariosFiltrados = comentarios.filter((c) => c.exibe);

comentariosFiltrados.forEach( (c, index) => {
    console.log(`Comentário ${index + 1}: ${c.comentario}`);
})
    