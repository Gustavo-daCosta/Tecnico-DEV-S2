const evento = {
    dataEvento: new Date(),
    descricao : "Venha aprender JavaScript e todo seu poder!!",
    titulo: "Mão na massa EcmaScript",
    presenca : true,
    comentario: "Gostei do evento"
}

const {dataEvento, descricao, titulo, ...resto} = evento;

console.log(`
    Evento: ${titulo}
    Descrição: ${descricao}
    Data: ${dataEvento}
    Resto: ${resto.comentario}
`);