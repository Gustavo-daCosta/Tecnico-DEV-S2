const camisaLacoste = {
    descricao: "Camisa Lacoste",
    preco: 399.98,
    marca: "Lacoste",
    tamanho: "G",
    cor: "Azul",
    promo: true,
}

// const descricao = camisaLacoste.descricao;
// const preco = camisaLacoste.preco;

// Exemplo de destructuring:
const { descricao, preco, promo } = camisaLacoste;

console.log(`
    Produto: ${descricao}
    Preço: ${preco}
    Promoção: ${promo ? 'Sim' : 'Não'}
`);

/*
    Crie um objeto evento com as propriedades:
        * DATA EVENTO
        * DESCRIÇÃO DO EVENTO
        * TÍTULO
        * PRESENÇA
        * COMENTÁRIO
    
    Crie uma destructuring das propriedades do objeto evento e as exiba no console.

    OBS: Para a presença deve-se exibir "sim" ou "não"
*/

let now = new Date();
const evento = {
    data: `${now.getDate()}/${now.getMonth() + 1}/${now.getFullYear()}`,
    descricaoEvento: "Festival com diversos artistas e músicas para todos os gostos",
    titulo: "Festival de música Senai",
    presenca: true,
    comentario: "Ótimo evento!",
}

const { data, descricaoEvento, titulo, presenca, comentario } = evento;

console.log(`
    Título: ${titulo}
    Descrição: ${descricaoEvento}
    Data: ${data}
    Estará presente? ${presenca ? "Sim" : "Não"}
    Comentário: ${comentario}
`);

