function PegarValores(dados) {
    let valores = [];
    let tamanho = dados.length;
    let indice = 0;

    while (indice < tamanho) {
        valores.push(dados[indice].valores);
        indice++;
    }

    return valores;
}

function PegarTipoDespesas(dados) {
    let labels = [];
    let tamanho = dados.length;
    let indice = 0;

    while (indice < tamanho) {
        labels.push(dados[indice].tipoDespesas);
        indice++;
    }

    return labels;
}

function PegarMeses(dados) {
    let labels = [];
    let tamanho = dados.length;
    let indice = 0;

    while (indice < tamanho) {
        labels.push(dados[indice].nomeMeses[0]);
        indice++;
    }

    return labels;
}

function PegarCores(quantidade) {
    let cores = [];

    while (quantidade > 0) {
        let r = Math.floor(Math.random() * 255);
        let g = Math.floor(Math.random() * 255);
        let b = Math.floor(Math.random() * 255);

        cores.push("rgb("+ r + ", " + g + "," + b + ")");

        quantidade--;
    }

    return cores;
}